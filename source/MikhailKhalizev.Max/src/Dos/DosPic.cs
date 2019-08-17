using System;
using MikhailKhalizev.Max.Program;
using MikhailKhalizev.Processor.x86;
using MikhailKhalizev.Processor.x86.Core.Abstractions;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Max.Dos
{
    public class DosPic : BridgeProcessor
    {
        public new Processor.x86.Core.Processor Implementation { get; }
        public RawProgramMain RawProgramMain { get; }

        private const bool logging = false;

        private int PIC_IRQCheck;
        private int PIC_IRQOnSecondPicActive;
        private int PIC_IRQActive = -1;

        private IRQ_Block[] irqs = new IRQ_Block[16];
        private PIC_Controller[] pics = new PIC_Controller[2];
        private bool PIC_Special_Mode; // Saves one compare in the pic_run_irqloop

        private object mutex = new object();
        private bool in_run_irqs = false;


        public DosPic(Processor.x86.Core.Processor implementation, RawProgramMain rawProgramMain)
            : base(implementation)
        {
            Implementation = implementation;
            RawProgramMain = rawProgramMain;

            /* Setup pic0 and pic1 with initial values like DOS has normally */

            for (var i = 0; i < 2; i++)
            {
                pics[i].masked = 0xff;
                pics[i].auto_eoi = false;
                pics[i].rotate_on_auto_eoi = false;
                pics[i].request_issr = false;
                pics[i].special = false;
                pics[i].single = false;
                pics[i].icw_index = 0;
                pics[i].icw_words = 0;
            }

            for (var i = 0; i <= 7; i++)
            {
                irqs[i].active = false;
                irqs[i].masked = true;
                irqs[i].inservice = false;

                irqs[i + 8].active = false;
                irqs[i + 8].masked = true;
                irqs[i + 8].inservice = false;

                irqs[i].InterruptVector = 0x8 + i;
                irqs[i + 8].InterruptVector = 0x70 + i;
            }

            irqs[0].masked = false;    /* Enable system timer */
            irqs[1].masked = false;    /* Enable Keyboard IRQ */
            irqs[2].masked = false;    /* Enable second pic */
            irqs[8].masked = false;    /* Enable RTC IRQ */

            //        if (machine == MCH_PCJR)
            //        {
            //            /* Enable IRQ6 (replacement for the NMI for PCJr) */
            //            irqs[6].masked = false;
            //        }
        }

        public void set_irq_mask(int irq, bool masked)
        {
            if (logging)
                NonBlockingConsole.WriteLine($"pic set_irq_mask. irq: 0x{irq:x}, masked: {masked}");

            lock (mutex)
                _set_irq_mask(irq, masked);
        }

        public void activate_irq(int irq)
        {
            if (logging)
                NonBlockingConsole.WriteLine($"pic activate_irq. irq: 0x{irq:x}");

            lock(mutex)
                _activate_irq(irq);
        }

        public void deactivate_irq(int irq)
        {
            if (logging)
                NonBlockingConsole.WriteLine($"pic deactivate_irq. irq: 0x{irq:x}");

            lock (mutex)
                _deactivate_irq(irq);
        }

        public void write_command(int port, int value)
        {
            if (logging)
                NonBlockingConsole.WriteLine($"pic write_command. port: 0x{port:x}, value: 0x{value:x}");

            lock (mutex)
                _write_command(port, value);
        }

        public void write_data(int port, int value)
        {
            if (logging)
                NonBlockingConsole.WriteLine($"pic write_data. port: 0x{port:x}, value: 0x{value:x}");

            lock (mutex)
                _write_data(port, value);
        }

        public int read_command(int port)
        {
            int value;
            lock (mutex)
                value = _read_command(port);

            if (logging)
                NonBlockingConsole.WriteLine($"pic read_command. port: 0x{port:x}, value: 0x{value:x}");

            return value;
        }

        public int read_data(int port)
        {
            int value;
            lock (mutex)
                value = _read_data(port);

            if (logging)
                NonBlockingConsole.WriteLine($"pic read_data. port: 0x{port:x}, value: 0x{value:x}");

            return value;
        }

        public void RunIrqs()
        {
            // TODO Внедрить этот код внутрь correct_function_position для повышения производительности?

            if (in_run_irqs)
                return; // Не будем делать прерывание в прерывании.

            try
            {
                in_run_irqs = true;

                while (true)
                {
                    int interruptVector;

                    lock (mutex)
                    {
                        var irq = _run_irqs();
                        if (irq < 0)
                            return;

                        interruptVector = irqs[irq].InterruptVector;
                    }

                    var retAddress = cs[eip];
                    var mode = (cs.db ? 32 : 16);
                    Implementation.int_internal(interruptVector, false, false, false, 0);
                    if (Implementation.CorrectMethodPosition(retAddress))
                        throw new NotImplementedException();
                    Implementation.check_mode(mode);
                }
            }
            finally
            {
                in_run_irqs = false;
            }
        }


        private void _write_command(int port, int val)
        {
            ref var pic_ctr = ref pics[(port == 0x20) ? 0 : 1];
            var irq_base = (port == 0x20) ? 0 : 8;

            var IRQ_priority_table = new[] { 0, 1, 2, 8, 9, 10, 11, 12, 13, 14, 15, 3, 4, 5, 6, 7 };

            if (0 != (val & 0x10)) // ICW1 issued
            {
                if (0 != (val & 0x04))
                    throw new NotImplementedException(); // E_Exit("PIC: 4 byte interval not handled");
                if (0 != (val & 0x08))
                    throw new NotImplementedException(); // E_Exit("PIC: level triggered mode not handled");
                if (0 != (val & 0xe0))
                    throw new NotImplementedException(); // E_Exit("PIC: 8080/8085 mode not handled");

                pic_ctr.single = ((val & 0x02) == 0x02);
                pic_ctr.icw_index = 1;            // next is ICW2
                pic_ctr.icw_words = 2 + (val & 0x01);    // =3 if ICW4 needed
            }
            else if (0 != (val & 0x08)) // OCW3 issued
            {
                if (0 != (val & 0x04))
                    throw new NotImplementedException(); // E_Exit("PIC: poll command not handled");

                if (0 != (val & 0x02)) // function select
                {
                    if (0 != (val & 0x01))
                        pic_ctr.request_issr = true;    /* select read interrupt in-service register */
                    else
                        pic_ctr.request_issr = false;/* select read interrupt request register */
                }

                if (0 != (val & 0x40)) // special mask select
                {
                    if (0 != (val & 0x20))
                        pic_ctr.special = true;
                    else
                        pic_ctr.special = false;

                    if (pic_ctr.special || pics[1].special)
                        PIC_Special_Mode = true;
                    else
                        PIC_Special_Mode = false;
                }
            }
            else // OCW2 issued
            {
                if (0 != (val & 0x20)) // EOI commands
                {
                    if (0 != (val & 0x80))
                        throw new NotImplementedException(); // E_Exit("rotate mode not supported");

                    if (0 != (val & 0x40)) // specific EOI
                    {
                        if (PIC_IRQActive == (irq_base + val - 0x60))
                        {
                            irqs[PIC_IRQActive].inservice = false;
                            PIC_IRQActive = -1;
                            for (var i = 0; i <= 15; i++)
                                if (irqs[IRQ_priority_table[i]].inservice)
                                {
                                    PIC_IRQActive = IRQ_priority_table[i];
                                    break;
                                }
                        }
                        //                if (val & 0x80);    // perform rotation
                    }
                    else // nonspecific EOI
                    {
                        // If there is no irq in service, ignore the call,
                        // some games send an eoi to both pics when a sound irq happens (regardless of the irq).

                        if (0 <= PIC_IRQActive && PIC_IRQActive < (irq_base + 8))
                        {
                            irqs[PIC_IRQActive].inservice = false;
                            PIC_IRQActive = -1;
                            for (var i = 0; i <= 15; i++)
                                if (irqs[IRQ_priority_table[i]].inservice)
                                {
                                    PIC_IRQActive = IRQ_priority_table[i];
                                    break;
                                }
                        }
                        //                if (val&0x80);    // perform rotation
                    }
                }
                else
                {
                    if (0 == (val & 0x40)) // rotate in auto EOI mode
                    {
                        if (0 != (val & 0x80))
                            pic_ctr.rotate_on_auto_eoi = true;
                        else
                            pic_ctr.rotate_on_auto_eoi = false;
                    }
                    //                else if (val & 0x80)
                    //                {
                    //                    LOG(LOG_PIC,LOG_NORMAL)("set priority command not handled");
                    //                }    // else NOP command
                }
            }
        }

        private void _write_data(int port, int val)
        {
            ref var pic_ctr = ref pics[port == 0x21 ? 0 : 1];
            var irq_base = ((port == 0x21) ? 0 : 8);

            var old_irq2_mask = irqs[2].masked;

            switch (pic_ctr.icw_index)
            {
                case 0:    /* mask register */
                    for (var i = 0; i <= 7; i++)
                    {
                        irqs[i + irq_base].masked = ((val & (1 << i)) != 0);
                        if (port == 0x21)
                        {
                            if (irqs[i + irq_base].active && !irqs[i + irq_base].masked)
                                PIC_IRQCheck |= (1 << (i + irq_base));
                            else
                                PIC_IRQCheck &= ~(1 << (i + irq_base));
                        }
                        else
                        {
                            if (irqs[i + irq_base].active && !irqs[i + irq_base].masked && !irqs[2].masked)
                                PIC_IRQCheck |= (1 << (i + irq_base));
                            else
                                PIC_IRQCheck &= ~(1 << (i + irq_base));
                        }
                    }

                    //            if (machine == MCH_PCJR)
                    //            {
                    //                /* irq6 cannot be disabled as it serves as pseudo-NMI */
                    //                irqs[6].masked = false;
                    //            }

                    if (irqs[2].masked != old_irq2_mask) /* Irq 2 mask has changed recheck second pic */
                        for (var i = 8; i <= 15; i++)
                            if (irqs[i].active && !irqs[i].masked && !irqs[2].masked)
                                PIC_IRQCheck |= (1 << i);
                            else
                                PIC_IRQCheck &= ~(1 << i);
                    break;

                case 1:    /* icw2 */
                    for (var i = 0; i <= 7; i++)
                        irqs[i + irq_base].InterruptVector = (val & 0xf8) + i;

                    pic_ctr.icw_index++;
                    if (pic_ctr.icw_index > pic_ctr.icw_words)
                        pic_ctr.icw_index = 0;
                    else if (pic_ctr.single)
                        pic_ctr.icw_index = 3;    /* skip ICW3 in single mode */
                    break;

                case 2:    /* icw 3 */
                    pic_ctr.icw_index++;
                    if (pic_ctr.icw_index > pic_ctr.icw_words)
                        pic_ctr.icw_index = 0;
                    break;

                case 3:    /* icw 4 */
                           /*
                               0        1 8086/8080  0 mcs-8085 mode
                               1        1 Auto EOI   0 Normal EOI
                               2-3       0x Non buffer Mode
                                      10 Buffer Mode Slave
                                      11 Buffer mode Master
                               4        Special/Not Special nested mode
                           */
                    pic_ctr.auto_eoi = (val & 0x2) != 0;

                    if ((val & 0x01) == 0)
                        throw new NotImplementedException(); // E_Exit("PIC:ICW4: %x, 8085 mode not handled",val);
                                                             //            if ((val & 0x10) != 0)
                                                             //                LOG_MSG("PIC:ICW4: %x, special fully-nested mode not handled",val);

                    pic_ctr.icw_index++;
                    if (pic_ctr.icw_index > pic_ctr.icw_words)
                        pic_ctr.icw_index = 0;
                    break;
                default:
                    //            LOG(LOG_PIC,LOG_NORMAL)("ICW HUH? %X",val);
                    break;
            }
        }

        private int _read_command(int port)
        {
            ref var pic_ctr = ref pics[(port == 0x20) ? 0 : 1];
            var irq_base = (port == 0x20) ? 0 : 8;

            var ret = 0;
            var b = 1;

            if (pic_ctr.request_issr)
            {
                for (var i = irq_base; i < irq_base + 8; i++)
                {
                    if (irqs[i].inservice)
                        ret |= b;
                    b <<= 1;
                }
            }
            else
            {
                for (var i = irq_base; i < irq_base + 8; i++)
                {
                    if (irqs[i].active)
                        ret |= b;
                    b <<= 1;
                }

                if (irq_base == 0 && (0 != (PIC_IRQCheck & 0xff00)))
                    ret |= 4;
            }

            return ret;
        }

        private int _read_data(int port)
        {
            var irq_base = (port == 0x21) ? 0 : 8;
            var ret = 0;
            var b = 1;

            for (var i = irq_base; i <= irq_base + 7; i++)
            {
                if (irqs[i].masked)
                    ret |= b;
                b <<= 1;
            }

            return ret;
        }

        private void _activate_irq(int irq)
        {
            if (irq < 8)
            {
                irqs[irq].active = true;
                if (!irqs[irq].masked)
                    PIC_IRQCheck |= (1 << irq);
            }
            else if (irq < 16)
            {
                irqs[irq].active = true;
                PIC_IRQOnSecondPicActive |= (1 << irq);
                if (!irqs[irq].masked && !irqs[2].masked)
                    PIC_IRQCheck |= (1 << irq);
            }
        }

        private void _deactivate_irq(int irq)
        {
            if (irq < 16)
            {
                irqs[irq].active = false;
                PIC_IRQCheck &= ~(1 << irq);
                PIC_IRQOnSecondPicActive &= ~(1 << irq);
            }
        }

        private void start_irq(int i)
        {
            /* irqs on second pic only if irq 2 isn't masked */

            irqs[i].active = false;
            PIC_IRQCheck &= ~(1 << i);
            PIC_IRQOnSecondPicActive &= ~(1 << i);


            ref var pic_ctr = ref pics[(i & 8) >> 3];

            if (!pic_ctr.auto_eoi)
            {
                PIC_IRQActive = i;
                irqs[i].inservice = true;
            }
            else if (pic_ctr.rotate_on_auto_eoi)
                throw new NotImplementedException(); // E_Exit("rotate on auto EOI not handled");
        }

        private int _run_irqs()
        {
            if (eflags.@if == false)
                return -1;

            if (PIC_IRQCheck == 0)
                return -1;

            var IRQ_priority_order = new[] { 0, 1, 2, 8, 9, 10, 11, 12, 13, 14, 15, 3, 4, 5, 6, 7 };
            var IRQ_priority_lookup = new[] { 0, 1, 2, 11, 12, 13, 14, 15, 3, 4, 5, 6, 7, 8, 9, 10, 16 };
            var activeIRQ = PIC_IRQActive;

            if (activeIRQ == -1)
                activeIRQ = 16;

            /* Get the priority of the active irq */
            var Priority_Active_IRQ = IRQ_priority_lookup[activeIRQ];

            /* If one of the pics is in special mode use a check that cares for that. */
            if (!PIC_Special_Mode)
            {
                for (var j = 0; j < Priority_Active_IRQ; j++)
                {
                    var i = IRQ_priority_order[j];
                    if (!irqs[i].masked && irqs[i].active)
                    {
                        if (7 < i && irqs[2].masked)
                            continue;

                        start_irq(i);
                        return i;
                    }
                }
            }
            else /* Special mode variant */
            {
                for (var j = 0; j <= 15; j++)
                {
                    var i = IRQ_priority_order[j];
                    if ((j < Priority_Active_IRQ) || pics[((i & 8) >> 3)].special)
                        if (!irqs[i].masked && irqs[i].active)
                        {
                            if (7 < i && irqs[2].masked)
                                continue;

                            /* the irq line is active. it's not masked and
                             * the irq is allowed priority wise. So let's start it */
                            /* If started successfully return, else go for the next */

                            start_irq(i);
                            return i;
                        }
                }
            }

            return -1;
        }

        private void _set_irq_mask(int irq, bool masked)
        {
            if (irqs[irq].masked == masked)
                return;    /* Do nothing if mask doesn't change */

            var old_irq2_mask = irqs[2].masked;
            irqs[irq].masked = masked;

            if (irq < 8)
            {
                if (irqs[irq].active && !irqs[irq].masked)
                    PIC_IRQCheck |= (1 << irq);
                else
                    PIC_IRQCheck &= ~(1 << irq);
            }
            else
            {
                if (irqs[irq].active && !irqs[irq].masked && !irqs[2].masked)
                    PIC_IRQCheck |= (1 << irq);
                else
                    PIC_IRQCheck &= ~(1 << irq);
            }

            if (irqs[2].masked != old_irq2_mask) /* Irq 2 mask has changed recheck second pic */
            {
                for (var i = 8; i <= 15; i++)
                {
                    if (irqs[i].active && !irqs[i].masked && !irqs[2].masked)
                        PIC_IRQCheck |= (1 << i);
                    else
                        PIC_IRQCheck &= ~(1 << i);
                }
            }
        }


        private struct IRQ_Block
        {
            public bool masked;
            public bool active;
            public bool inservice;
            public int InterruptVector;
        }

        private struct PIC_Controller
        {
            public int icw_words;
            public int icw_index;
            public int masked;

            public bool special;
            public bool auto_eoi;
            public bool rotate_on_auto_eoi;
            public bool single;
            public bool request_issr;
            public int vector_base;
        };
    }
}