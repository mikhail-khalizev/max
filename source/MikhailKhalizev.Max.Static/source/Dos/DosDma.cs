using System;
using System.Threading.Tasks;
using MikhailKhalizev.Max.Program;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions;

namespace MikhailKhalizev.Max.Dos
{
    public enum DmaEvent
    {
        ReachedTc,
        Masked,
        Unmasked,
        TransferEnd
    };

    public delegate void DmaCallback(DmaChannel chan, DmaEvent @event);

    public class DmaChannel
    {
        private readonly Processor.x86.CSharpExecutor.Cpu _cpu;

        private DmaCallback _callback;

        public int PageBase;

        public int CurrAddr;
        public int BaseAddr;

        public int BaseCnt;
        public int CurrCnt;

        public int ChanNum;
        public int PageNum;
        /* 0 or 1. */
        public int Dma16;
        //    uint_<8> trantype;

        public bool Increment;
        public bool AutoInit;
        public bool Masked = true;
        public bool Tcount;
        public bool Request;

        private const int DmaWrapping = 0xffff;

        public DmaChannel(int num, bool dma16, Processor.x86.CSharpExecutor.Cpu cpu)
        {
            if (num == 4)
                return;

            ChanNum = num;
            _cpu = cpu;
            Dma16 = dma16 ? 0x1 : 0x0;
            Increment = true;
        }

        public void do_callback(DmaEvent @event)
        {
            _callback?.Invoke(this, @event);
        }

        public void set_mask(bool mask)
        {
            Masked = mask;
            do_callback(Masked ? DmaEvent.Masked : DmaEvent.Unmasked);
        }

        public void register_callback(DmaCallback cb)
        {
            _callback = cb;
            set_mask(Masked);

            if (_callback != null)
                raise_request();
            else
                clear_request();
        }

        public void reached_tc()
        {
            Tcount = true;
            do_callback(DmaEvent.ReachedTc);
        }

        public void set_page(int val)
        {
            PageNum = val;

            PageBase = val & (~Dma16);
            PageBase <<= 16;
        }

        public void raise_request()
        {
            Request = true;
        }

        public void clear_request()
        {
            Request = false;
        }

        public int Read(ArraySegment<byte> buffer)
        {
            var want = buffer.Count >> Dma16;
            var done = 0;
            CurrAddr &= DmaWrapping;

        again:

            var left = CurrCnt + 1;
            if (want < left)
            {
                dma_block_read(buffer, PageBase, CurrAddr, want, Dma16);
                done += want;
                CurrAddr += want;
                CurrCnt -= want;
            }
            else
            {
                dma_block_read(buffer, PageBase, CurrAddr, left, Dma16);

                buffer = buffer.Slice(left << Dma16);
                want -= left;
                done += left;
                reached_tc();

                if (AutoInit)
                {
                    CurrCnt = BaseCnt;
                    CurrAddr = BaseAddr;
                    if (want != 0)
                        goto again;
                }
                else
                {
                    CurrAddr += left;
                    CurrCnt = 0xffff;
                    Masked = true;
                    do_callback(DmaEvent.TransferEnd);
                }
            }

            return done;
        }

        public int Write(ArraySegment<byte> buffer)
        {
            var want = buffer.Count >> Dma16;
            var done = 0;
            CurrAddr &= DmaWrapping;

        again:

            var left = (CurrCnt + 1);
            if (want < left)
            {
                dma_block_write(buffer, PageBase, CurrAddr, want, Dma16);
                done += want;
                CurrAddr += want;
                CurrCnt -= want;
            }
            else
            {
                dma_block_write(buffer, PageBase, CurrAddr, left, Dma16);
                buffer = buffer.Slice(left << Dma16);
                want -= left;
                done += left;
                reached_tc();

                if (AutoInit)
                {
                    CurrCnt = BaseCnt;
                    CurrAddr = BaseAddr;
                    if (want != 0)
                        goto again;
                }
                else
                {
                    CurrAddr += left;
                    CurrCnt = 0xffff;
                    Masked = true;
                    do_callback(DmaEvent.TransferEnd);
                }
            }

            return done;
        }

        /* read a block from physical memory */
        private void dma_block_read(ArraySegment<byte> buffer, int @base, int offset, int size, int dma16)
        {
            if (DmaWrapping < offset + size)
                throw new NotImplementedException();

            size <<= dma16;
            offset <<= dma16;
            var dmaWrap = ((0xffff << dma16) + dma16) | DmaWrapping;

            var sizeP1 = Math.Min(size, dmaWrap + 1 - offset);

            _cpu.Memory.mem_phys_raw(@base + offset, sizeP1).Slice(0, sizeP1).CopyTo(buffer);

            var sizeP2 = size - sizeP1;
            if (sizeP2 != 0)
                _cpu.Memory.mem_phys_raw(@base, sizeP2).Slice(0, sizeP2).CopyTo(buffer.Slice(sizeP1));
        }

        /* write a block into physical memory */
        private void dma_block_write(Span<byte> buffer, int @base, int offset, int size, int dma16)
        {
            if (DmaWrapping < offset + size)
                throw new NotImplementedException();

            size <<= dma16;
            offset <<= dma16;
            var dmaWrap = ((0xffff << dma16) + dma16) | DmaWrapping;

            var sizeP1 = Math.Min(size, dmaWrap + 1 - offset);

            buffer.CopyTo(
                _cpu.Memory.mem_phys_raw(@base + offset, sizeP1).Slice(0, sizeP1));

            var sizeP2 = size - sizeP1;
            if (sizeP2 != 0)
                buffer.Slice(sizeP1).CopyTo(_cpu.Memory.mem_phys_raw(@base, sizeP2).Slice(0, sizeP2));
        }
    }

    public class DmaController
    {
        private readonly DmaChannel[] _dmaChannels = new DmaChannel[4];
        /** first or second DMA controller */
        private int _ctrlnum;
        private bool _flipflop;


        /** @param num first or second DMA controller */
        public DmaController(int num, Processor.x86.CSharpExecutor.Cpu cpu)
        {
            _ctrlnum = num;
            for (var i = 0; i < 4; i++)
                _dmaChannels[i] = new DmaChannel(num * 4 + i, num == 1, cpu);
        }

        public DmaChannel get_channel(int chan)
        {
            return _dmaChannels[chan];
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
                        _flipflop = !_flipflop;
                        if (_flipflop)
                        {
                            chan.BaseAddr = (chan.BaseAddr & 0xff00) | val;
                            chan.CurrAddr = (chan.CurrAddr & 0xff00) | val;
                        }
                        else
                        {
                            chan.BaseAddr = (chan.BaseAddr & 0x00ff) | (val << 8);
                            chan.CurrAddr = (chan.CurrAddr & 0x00ff) | (val << 8);
                        }
                        break;
                    }

                case 0x1:    /* set DMA transfer count (1st byte low part, 2nd byte high part) */
                case 0x3:
                case 0x5:
                case 0x7:
                    {
                        var chan = get_channel(reg >> 1);
                        _flipflop = !_flipflop;
                        if (_flipflop)
                        {
                            chan.BaseCnt = (chan.BaseCnt & 0xff00) | val;
                            chan.CurrCnt = (chan.CurrCnt & 0xff00) | val;
                        }
                        else
                        {
                            chan.BaseCnt = (chan.BaseCnt & 0x00ff) | (val << 8);
                            chan.CurrCnt = (chan.CurrCnt & 0x00ff) | (val << 8);
                        }
                        break;
                    }

                case 0x8:    /* Command reg not used */
                    throw new NotImplementedException();

                case 0x9:    /* Request registers, memory to memory */
                    throw new NotImplementedException();

                case 0xa:    /* MaskUInt64 Register */
                    get_channel(val & 3).set_mask((val & 0x4) != 0);
                    break;

                case 0xb:    /* Mode Register */
                    {
                        var chan = get_channel(val & 3);
                        chan.AutoInit = (val & 0x10) != 0;
                        chan.Increment = (val & 0x20) != 0;
                        //TODO Maybe other bits?
                        break;
                    }

                case 0xc:    /* Clear Flip/Flip */
                    _flipflop = false;
                    break;

                case 0xd:    /* Master Clear/Reset */
                    for (var ct = 0; ct < 4; ct++)
                    {
                        var chan = get_channel(ct);
                        chan.set_mask(true);
                        chan.Tcount = false;
                    }
                    _flipflop = false;
                    break;

                case 0xe:    /* Clear MaskUInt64 register */
                    for (var ct = 0; ct < 4; ct++)
                    {
                        var chan = get_channel(ct);
                        chan.set_mask(false);
                    }
                    break;

                case 0xf:    /* Multiple MaskUInt64 register */
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
                    _flipflop = !_flipflop;
                    if (_flipflop)
                        return chan.CurrAddr & 0xff;
                    else
                        return (chan.CurrAddr >> 8) & 0xff;
                }

                case 0x1:    /* read DMA transfer count (1st byte low part, 2nd byte high part) */
                case 0x3:
                case 0x5:
                case 0x7:
                {
                    var chan = get_channel(reg >> 1);
                    _flipflop = !_flipflop;
                    if (_flipflop)
                        return chan.CurrCnt & 0xff;
                    else
                        return (chan.CurrCnt >> 8) & 0xff;
                }

                case 0x8:    /* Status Register */
                {
                    var ret = 0;
                    for (var ct = 0; ct < 4; ct++)
                    {
                        var chan = get_channel(ct);

                        if (chan.Tcount)
                            ret |= 1 << ct;

                        chan.Tcount = false;

                        if (chan.Request)
                            ret |= 1 << (4 + ct);
                    }
                    return ret;
                }

                default:
                    throw new NotImplementedException();
            }
        }
    }

    public class DosDma : BridgeCpu
    {
        public RawProgramMain RawProgramMain { get; }

        public DmaController[] DmaControllers = new DmaController[2];

        public DosDma(ICpu implementation, RawProgramMain rawProgramMain)
            : base(implementation)
        {
            RawProgramMain = rawProgramMain;
            DmaControllers[0] = new DmaController(0, rawProgramMain.Implementation);
            DmaControllers[1] = new DmaController(1, rawProgramMain.Implementation);

            Task.Run(async () => {
                var chan = RawProgramMain.DosDma.dma_get_channel(5);

                while (true)
                {
                    if (!chan.Masked)
                    {
                        var buf = new byte[2 * 50];
                        chan.Read(buf);
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
                case 0x81: return dma_get_channel(2).PageNum;
                case 0x82: return dma_get_channel(3).PageNum;
                case 0x83: return dma_get_channel(1).PageNum;
                case 0x89: return dma_get_channel(6).PageNum;
                case 0x8a: return dma_get_channel(7).PageNum;
                case 0x8b: return dma_get_channel(5).PageNum;
                default: throw new InvalidOperationException("port number");
            }
        }

        public DmaChannel dma_get_channel(int chan)
        {
            if (chan < 4) /* channel on first DMA controller */
                return DmaControllers[0].get_channel(chan);

            if (chan < 8) /* channel on second DMA controller */
                return DmaControllers[1].get_channel(chan - 4);

            throw new InvalidOperationException("channel number");
        }
    }
}