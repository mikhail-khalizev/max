using System;
using System.Threading.Tasks;
using MikhailKhalizev.Max.Program;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions;

namespace MikhailKhalizev.Max.Dos
{
    public enum dma_event
    {
        reached_tc,
        masked,
        unmasked,
        transferend
    };

    public delegate void dma_callback(dma_channel chan, dma_event @event);

    public class dma_channel
    {
        private Processor.x86.CSharpExecutor.Processor Processor;

        dma_callback callback;

        public int pagebase;

        public int curraddr;
        public int baseaddr;

        public int basecnt;
        public int currcnt;

        public int channum;
        public int pagenum;
        /* 0 or 1. */
        public int DMA16;
        //    uint_<8> trantype;

        public bool increment;
        public bool autoinit;
        public bool masked = true;
        public bool tcount;
        public bool request;

        const int dma_wrapping = 0xffff;

        public dma_channel(int num, bool dma16, Processor.x86.CSharpExecutor.Processor processor)
        {
            if (num == 4)
                return;

            channum = num;
            Processor = processor;
            DMA16 = dma16 ? 0x1 : 0x0;
            increment = true;
        }

        public void do_callback(dma_event @event)
        {
            callback?.Invoke(this, @event);
        }

        public void set_mask(bool _mask)
        {
            masked = _mask;
            do_callback(masked ? dma_event.masked : dma_event.unmasked);
        }

        public void register_callback(dma_callback _cb)
        {
            callback = _cb;
            set_mask(masked);

            if (callback != null)
                raise_request();
            else
                clear_request();
        }

        public void reached_tc()
        {
            tcount = true;
            do_callback(dma_event.reached_tc);
        }

        public void set_page(int val)
        {
            pagenum = val;

            pagebase = val & (~DMA16);
            pagebase <<= 16;
        }

        public void raise_request()
        {
            request = true;
        }

        public void clear_request()
        {
            request = false;
        }

        public int read(ArraySegment<byte> buffer)
        {
            var want = buffer.Count >> DMA16;
            var done = 0;
            curraddr &= dma_wrapping;

        again:

            var left = currcnt + 1;
            if (want < left)
            {
                dma_block_read(buffer, pagebase, curraddr, want, DMA16);
                done += want;
                curraddr += want;
                currcnt -= want;
            }
            else
            {
                dma_block_read(buffer, pagebase, curraddr, left, DMA16);

                buffer = buffer.Slice(left << DMA16);
                want -= left;
                done += left;
                reached_tc();

                if (autoinit)
                {
                    currcnt = basecnt;
                    curraddr = baseaddr;
                    if (want != 0)
                        goto again;
                }
                else
                {
                    curraddr += left;
                    currcnt = 0xffff;
                    masked = true;
                    do_callback(dma_event.transferend);
                }
            }

            return done;
        }

        public int write(ArraySegment<byte> buffer)
        {
            var want = buffer.Count >> DMA16;
            var done = 0;
            curraddr &= dma_wrapping;

        again:

            var left = (currcnt + 1);
            if (want < left)
            {
                dma_block_write(buffer, pagebase, curraddr, want, DMA16);
                done += want;
                curraddr += want;
                currcnt -= want;
            }
            else
            {
                dma_block_write(buffer, pagebase, curraddr, left, DMA16);
                buffer = buffer.Slice(left << DMA16);
                want -= left;
                done += left;
                reached_tc();

                if (autoinit)
                {
                    currcnt = basecnt;
                    curraddr = baseaddr;
                    if (want != 0)
                        goto again;
                }
                else
                {
                    curraddr += left;
                    currcnt = 0xffff;
                    masked = true;
                    do_callback(dma_event.transferend);
                }
            }

            return done;
        }

        /* read a block from physical memory */
        void dma_block_read(ArraySegment<byte> buffer, int @base, int offset, int size, int dma16)
        {
            if (dma_wrapping < offset + size)
                throw new NotImplementedException();

            size <<= dma16;
            offset <<= dma16;
            var dma_wrap = ((0xffff << dma16) + dma16) | dma_wrapping;

            var size_p1 = Math.Min(size, dma_wrap + 1 - offset);

            Processor.Memory.mem_phys_raw(@base + offset, size_p1).Slice(0, size_p1).CopyTo(buffer);

            var size_p2 = size - size_p1;
            if (size_p2 != 0)
                Processor.Memory.mem_phys_raw(@base, size_p2).Slice(0, size_p2).CopyTo(buffer.Slice(size_p1));
        }

        /* write a block into physical memory */
        void dma_block_write(Span<byte> buffer, int @base, int offset, int size, int dma16)
        {
            if (dma_wrapping < offset + size)
                throw new NotImplementedException();

            size <<= dma16;
            offset <<= dma16;
            var dma_wrap = ((0xffff << dma16) + dma16) | dma_wrapping;

            var size_p1 = Math.Min(size, dma_wrap + 1 - offset);

            buffer.CopyTo(
                Processor.Memory.mem_phys_raw(@base + offset, size_p1).Slice(0, size_p1));

            var size_p2 = size - size_p1;
            if (size_p2 != 0)
                buffer.Slice(size_p1).CopyTo(Processor.Memory.mem_phys_raw(@base, size_p2).Slice(0, size_p2));
        }
    }

    public class dma_controller
    {
        dma_channel[] dma_channels = new dma_channel[4];
        /** first or second DMA controller */
        int ctrlnum;
        bool flipflop;


        /** @param num first or second DMA controller */
        public dma_controller(int num, Processor.x86.CSharpExecutor.Processor processor)
        {
            ctrlnum = num;
            for (var i = 0; i < 4; i++)
                dma_channels[i] = new dma_channel(num * 4 + i, num == 1, processor);
        }

        public dma_channel get_channel(int chan)
        {
            return dma_channels[chan];
        }

        public void write_controller_reg(int reg, int val)
        {
            switch (reg)
            {
                case 0x0:    /* set base address of DMA transfer (1st byte low part, 2nd byte high part) */
                case 0x2:
                case 0x4:
                case 0x6:
                    {
                        var chan = get_channel(reg >> 1);
                        flipflop = !flipflop;
                        if (flipflop)
                        {
                            chan.baseaddr = (chan.baseaddr & 0xff00) | val;
                            chan.curraddr = (chan.curraddr & 0xff00) | val;
                        }
                        else
                        {
                            chan.baseaddr = (chan.baseaddr & 0x00ff) | (val << 8);
                            chan.curraddr = (chan.curraddr & 0x00ff) | (val << 8);
                        }
                        break;
                    }

                case 0x1:    /* set DMA transfer count (1st byte low part, 2nd byte high part) */
                case 0x3:
                case 0x5:
                case 0x7:
                    {
                        var chan = get_channel(reg >> 1);
                        flipflop = !flipflop;
                        if (flipflop)
                        {
                            chan.basecnt = (chan.basecnt & 0xff00) | val;
                            chan.currcnt = (chan.currcnt & 0xff00) | val;
                        }
                        else
                        {
                            chan.basecnt = (chan.basecnt & 0x00ff) | (val << 8);
                            chan.currcnt = (chan.currcnt & 0x00ff) | (val << 8);
                        }
                        break;
                    }

                case 0x8:    /* Comand reg not used */
                    throw new NotImplementedException();

                case 0x9:    /* Request registers, memory to memory */
                    throw new NotImplementedException();

                case 0xa:    /* Mask Register */
                    get_channel(val & 3).set_mask((val & 0x4) != 0);
                    break;

                case 0xb:    /* Mode Register */
                    {
                        var chan = get_channel(val & 3);
                        chan.autoinit = (val & 0x10) != 0;
                        chan.increment = (val & 0x20) != 0;
                        //TODO Maybe other bits?
                        break;
                    }

                case 0xc:    /* Clear Flip/Flip */
                    flipflop = false;
                    break;

                case 0xd:    /* Master Clear/Reset */
                    for (var ct = 0; ct < 4; ct++)
                    {
                        var chan = get_channel(ct);
                        chan.set_mask(true);
                        chan.tcount = false;
                    }
                    flipflop = false;
                    break;

                case 0xe:    /* Clear Mask register */
                    for (var ct = 0; ct < 4; ct++)
                    {
                        var chan = get_channel(ct);
                        chan.set_mask(false);
                    }
                    break;

                case 0xf:    /* Multiple Mask register */
                    for (var ct = 0; ct < 4; ct++)
                    {
                        var chan = get_channel(ct);
                        chan.set_mask((val & 1) != 0);
                        val >>= 1;
                    }
                    break;
            }
        }

        public int read_controller_reg(int reg)
        {
            switch (reg)
            {
                case 0x0:    /* read base address of DMA transfer (1st byte low part, 2nd byte high part) */
                case 0x2:
                case 0x4:
                case 0x6:
                {
                    var chan = get_channel(reg >> 1);
                    flipflop = !flipflop;
                    if (flipflop)
                        return chan.curraddr & 0xff;
                    else
                        return (chan.curraddr >> 8) & 0xff;
                }

                case 0x1:    /* read DMA transfer count (1st byte low part, 2nd byte high part) */
                case 0x3:
                case 0x5:
                case 0x7:
                {
                    var chan = get_channel(reg >> 1);
                    flipflop = !flipflop;
                    if (flipflop)
                        return chan.currcnt & 0xff;
                    else
                        return (chan.currcnt >> 8) & 0xff;
                }

                case 0x8:    /* Status Register */
                {
                    var ret = 0;
                    for (var ct = 0; ct < 4; ct++)
                    {
                        var chan = get_channel(ct);

                        if (chan.tcount)
                            ret |= 1 << ct;

                        chan.tcount = false;

                        if (chan.request)
                            ret |= 1 << (4 + ct);
                    }
                    return ret;
                }

                default:
                    throw new NotImplementedException();
            }
        }
    }

    public class DosDma : BridgeProcessor
    {
        public RawProgramMain RawProgramMain { get; }

        public dma_controller[] dma_controllers = new dma_controller[2];

        public DosDma(IProcessor implementation, RawProgramMain rawProgramMain)
            : base(implementation)
        {
            RawProgramMain = rawProgramMain;
            dma_controllers[0] = new dma_controller(0, rawProgramMain.Implementation);
            dma_controllers[1] = new dma_controller(1, rawProgramMain.Implementation);

            Task.Run(async () => {
                var chan = RawProgramMain.DosDma.dma_get_channel(5);

                while (true)
                {
                    if (!chan.masked)
                    {
                        var buf = new byte[2 * 50];
                        chan.read(buf);
                    }
                    await Task.Delay(TimeSpan.FromSeconds(0.05));
                }
            });
        }

        public void dma_write_p8x(int port, int val)
        {
            switch (port)
            {
                /* write DMA page register */
                case 0x81: dma_get_channel(2).set_page(val); break;
                case 0x82: dma_get_channel(3).set_page(val); break;
                case 0x83: dma_get_channel(1).set_page(val); break;
                case 0x89: dma_get_channel(6).set_page(val); break;
                case 0x8a: dma_get_channel(7).set_page(val); break;
                case 0x8b: dma_get_channel(5).set_page(val); break;
                default: throw new InvalidOperationException("port number");
            }
        }

        public int dma_read_p8x(int port)
        {
            switch (port)
            {
                /* read DMA page register */
                case 0x81: return dma_get_channel(2).pagenum;
                case 0x82: return dma_get_channel(3).pagenum;
                case 0x83: return dma_get_channel(1).pagenum;
                case 0x89: return dma_get_channel(6).pagenum;
                case 0x8a: return dma_get_channel(7).pagenum;
                case 0x8b: return dma_get_channel(5).pagenum;
                default: throw new InvalidOperationException("port number");
            }
        }

        public dma_channel dma_get_channel(int chan)
        {
            if (chan < 4) /* channel on first DMA controller */
                return dma_controllers[0].get_channel(chan);

            if (chan < 8) /* channel on second DMA controller */
                return dma_controllers[1].get_channel(chan - 4);

            throw new InvalidOperationException("channal number");
        }
    }
}