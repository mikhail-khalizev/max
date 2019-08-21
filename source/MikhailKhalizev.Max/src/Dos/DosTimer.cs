using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using MikhailKhalizev.Max.Program;
using MikhailKhalizev.Processor.x86.Core.Abstractions;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Max.Dos
{
    public class DosTimer : BridgeProcessor
    {
        public RawProgramMain RawProgramMain { get; }

        /** Кол-во тактов в секунду. */
        private const double PIT_TICK_RATE = 1193182;

        private pit_block[] pit = new pit_block[3];
        /* Создаётся в динамической памяти и не уничтожается после вызова 'exit', что позволяет использовать его в ещё работающих потоках, до которых 'exit' ещё не дошёл. */
        private object pit_0_mutex = new object();
        private bool gate2;

        private int latched_timerstatus;
        // the timer status can not be overwritten until it is read or the timer was reprogrammed.
        private bool latched_timerstatus_locked;


        public DosTimer(IProcessor implementation, RawProgramMain rawProgramMain)
            : base(implementation)
        {
            RawProgramMain = rawProgramMain;
        }

        public void Initialize()
        {
            /* Setup Timer 0 */
            pit[0].cntr = 0x10000;
            pit[0].write_state = 3;
            pit[0].read_state = 3;
            pit[0].read_latch = 0;
            pit[0].write_latch = 0;
            pit[0].mode = 3;
            pit[0].bcd = false;
            pit[0].go_read_latch = true;
            pit[0].counterstatus_set = false;
            pit[0].update_count = false;

            pit[1].bcd = false;
            pit[1].write_state = 1;
            pit[1].read_state = 1;
            pit[1].go_read_latch = true;
            pit[1].cntr = 18;
            pit[1].mode = 2;
            pit[1].write_state = 3;
            pit[1].counterstatus_set = false;

            pit[2].read_latch = 1320;    /* MadTv1 */
            pit[2].write_state = 3;    /* Chuck Yeager */
            pit[2].read_state = 3;
            pit[2].mode = 3;
            pit[2].bcd = false;
            pit[2].cntr = 1320;
            pit[2].go_read_latch = true;
            pit[2].counterstatus_set = false;
            pit[2].counting = false;

            pit[0].start = pit[1].start = pit[2].start = get_total_nsec();

            pit[0].delay = TimeSpan.FromSeconds(pit[0].cntr / PIT_TICK_RATE);
            pit[1].delay = TimeSpan.FromSeconds(pit[1].cntr / PIT_TICK_RATE);
            pit[2].delay = TimeSpan.FromSeconds(pit[2].cntr / PIT_TICK_RATE);

            latched_timerstatus_locked = false;
            gate2 = false;
        }

        private Task _start;
        public void Start()
        {
            if (_start == null)
                _start = pit0_event();
        }

        private TimeSpan get_total_nsec()
        {
            return new TimeSpan(DateTime.UtcNow.Ticks);
        }

        private async Task pit0_event()
        {
            //    pthread_cond_t pit_0_change;
            //    int ok = pthread_cond_init(&pit_0_change, NULL);
            //    if (ok != 0)
            //        exo::linux::general_exception::throw_exception();
            //
            //    auto func_cond_destroy = [](pthread_cond_t * cond2).void
            //    {
            //        try
            //        {
            //            int ok2 = pthread_cond_destroy(cond2);
            //            if (ok2 != 0)
            //                exo::linux::general_exception::throw_exception();
            //        }
            //        catch(...)
            //        {}
            //    };
            //    std::unique_ptr<pthread_cond_t, decltype(func_cond_destroy)> cond_destroy(
            //        &pit_0_change, func_cond_destroy);

            var locked = false;
            Monitor.Enter(pit_0_mutex, ref locked);
            if (!locked)
                throw new NotImplementedException();

            try
            {
                while (true)
                {
                    if (pit[0].mode != 0 && pit[0].update_count)
                    {
                        pit[0].delay = TimeSpan.FromSeconds(pit[0].cntr / PIT_TICK_RATE);
                        pit[0].update_count = false;
                    }

                    if (pit[0].mode == 0)
                    {
                        throw new NotImplementedException();
                        //            ok = pthread_cond_wait(&pit_0_change, pit_0_mutex.native_handle());
                        //            if (ok != 0)
                        //                exo::linux::general_exception::throw_exception();
                        //
                        //            continue;
                    }
                    else
                    {
                        var timeNow = get_total_nsec();
                        var wait = pit[0].start + pit[0].delay - timeNow;

                        if (wait < TimeSpan.Zero)
                        {
                            pit[0].start += (int)((timeNow - pit[0].start) / pit[0].delay) * pit[0].delay;
                            wait = pit[0].start + pit[0].delay - timeNow;
                        }

                        if (wait < TimeSpan.FromSeconds(0.05))
                            wait = TimeSpan.FromSeconds(0.05);

                        Monitor.Exit(pit_0_mutex);
                        locked = false;

                        await Task.Delay(wait);
                        RawProgramMain.DosPic.activate_irq(0);

                        Monitor.Enter(pit_0_mutex, ref locked);
                        if (!locked)
                            throw new NotImplementedException();

                        pit[0].start += pit[0].delay;
                    }
                }
            }
            finally
            {
                if (locked)
                    Monitor.Exit(pit_0_mutex);
            }
        }

        private bool counter_output(int counter)
        {
            ref var p = ref pit[counter];
            var index = get_total_nsec() - p.start;
            switch (p.mode)
            {
                case 0:
                    if (p.new_mode)
                        return false;

                    if (p.delay < index)
                        return true;
                    else
                        return false;

                case 2:
                    {
                        if (p.new_mode)
                            return true;
                        var i = index.Ticks % p.delay.Ticks;
                        return 0 < i;
                    }

                case 3:
                    {
                        if (p.new_mode)
                            return true;
                        var i = index.Ticks % p.delay.Ticks;
                        return i * 2 < p.delay.Ticks;
                    }

                case 4:
                    //Only low on terminal count
                    // if(fmod(index,(double)p.delay) == 0) return false; //Maybe take one rate tick in consideration
                    //Easiest solution is to report always high (Space marines uses this mode)
                    return true;

                default:
                    throw new NotImplementedException();
            }
        }

        private void status_latch(int counter)
        {
            // the timer status can not be overwritten until it is read or the timer was reprogrammed.
            if (latched_timerstatus_locked)
                return;

            ref var p = ref pit[counter];
            latched_timerstatus = 0;

            // Timer Status Word
            // 0: BCD
            // 1-3: Timer mode
            // 4-5: read/load mode
            // 6: "NULL" - this is 0 if "the counter value is in the counter" ;)
            // should rarely be 1 (i.e. on exotic modes)
            // 7: OUT - the logic level on the Timer output pin

            if (p.bcd)
                latched_timerstatus |= 0x1;

            latched_timerstatus |= ((p.mode & 7) << 1);

            if ((p.read_state == 0) || (p.read_state == 3))
                latched_timerstatus |= 0x30;
            else if (p.read_state == 1)
                latched_timerstatus |= 0x10;
            else if (p.read_state == 2)
                latched_timerstatus |= 0x20;

            if (counter_output(counter))
                latched_timerstatus |= 0x80;
            if (p.new_mode)
                latched_timerstatus |= 0x40;

            // The first thing that is being read from this counter now is the
            // counter status.

            p.counterstatus_set = true;
            latched_timerstatus_locked = true;
        }

        private void counter_latch(int counter)
        {
            /* Fill the read_latch of the selected counter with current count */
            ref var p = ref pit[counter];
            p.go_read_latch = false;

            // If gate2 is disabled don't update the read_latch
            if (counter == 2 && !gate2 && p.mode != 1)
                return;

            var index = get_total_nsec() - p.start;
            switch (p.mode)
            {
                case 4:    /* Software Triggered Strobe */
                case 0:    /* Interrupt on Terminal Count */
                           /* Counter keeps on counting after passing terminal count */
                    if (p.delay < index)
                    {
                        index -= p.delay;
                        if (p.bcd)
                        {
                            var i = index.Ticks % (10000 * TimeSpan.TicksPerSecond / PIT_TICK_RATE);
                            p.read_latch = checked((int)(9999 - i * PIT_TICK_RATE / TimeSpan.TicksPerSecond));
                        }
                        else
                        {
                            var i = index.Ticks % (0x10000 * TimeSpan.TicksPerSecond / PIT_TICK_RATE);
                            p.read_latch = checked((int)(0xffff - i * PIT_TICK_RATE / TimeSpan.TicksPerSecond));
                        }
                    }
                    else
                        p.read_latch = checked((int)(p.cntr - index.Ticks * PIT_TICK_RATE / TimeSpan.TicksPerSecond));
                    break;

                case 1: // countdown
                    if (p.counting)
                    {
                        if (p.delay < index) // has timed out
                            p.read_latch = 0xffff; // unconfirmed
                        else
                            p.read_latch = checked((int)(p.cntr - index.Ticks * PIT_TICK_RATE / TimeSpan.TicksPerSecond));
                    }
                    break;

                case 2:    /* Rate Generator */
                    p.read_latch = checked((int)(p.cntr * (p.delay.Ticks - index.Ticks % p.delay.Ticks) / p.delay.Ticks));
                    // NonBlockingConsole.WriteLine($"timer Rate Generator read_latch: {p.read_latch}");
                    break;

                case 3:    /* Square Wave Rate Generator */
                    index = TimeSpan.FromTicks((index.Ticks % p.delay.Ticks) * 2);
                    if (p.delay < index)
                        index -= p.delay;
                    p.read_latch = checked((int)(p.cntr - index.Ticks * p.cntr / p.delay.Ticks));
                    // In mode 3 it never returns odd numbers LSB (if odd number is written 1 will be
                    // subtracted on first clock and then always 2)
                    // fixes "Corncob 3D"
                    p.read_latch &= 0xfffe;
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        public void timer_write_latch(int port, int val)
        {
            var counter = port - 0x40;

            var locked = false;
            try
            {
                if (counter == 0)
                {
                    Monitor.Enter(pit_0_mutex, ref locked);
                    if (!locked)
                        throw new NotImplementedException();
                }

                ref var p = ref pit[counter];
                if (p.bcd)
                    throw new NotImplementedException();

                switch (p.write_state)
                {
                    case 0:
                        p.write_latch = p.write_latch | (val << 8);
                        p.write_state = 3;
                        break;
                    case 3:
                        p.write_latch = val;
                        p.write_state = 0;
                        break;
                    case 1:
                        p.write_latch = val;
                        break;
                    case 2:
                        p.write_latch = val << 8;
                        break;
                }

                if (p.write_state != 0)
                {
                    if (p.write_latch == 0)
                    {
                        if (p.bcd == false)
                            p.cntr = 0x10000;
                        else
                            p.cntr = 9999;
                    }
                    else
                        p.cntr = p.write_latch;

                    if ((!p.new_mode) && (p.mode == 2) && (counter == 0))
                    {
                        // In mode 2 writing another value has no direct effect on the count
                        // until the old one has run out. This might apply to other modes too.
                        // This is not fixed for PIT2 yet!!
                        p.update_count = true;
                        return;
                    }

                    p.start = get_total_nsec();
                    p.delay = TimeSpan.FromSeconds(p.cntr / PIT_TICK_RATE);

                    switch (counter)
                    {
                        case 0:    /* Timer hooked to IRQ 0 */
                                   //            if (p.new_mode || p.mode == 0)
                                   //            {
                                   //                if (p.mode == 0)
                                   //                    PIC_RemoveEvents(pit0_event); // DoWhackaDo demo
                                   //                PIC_AddEvent(pit0_event, p.delay);
                                   //            }
                                   //            else
                                   //                throw exo::exception::not_implemented(); // LOG(LOG_PIT,LOG_NORMAL)("PIT 0 Timer set without new control word");
                                   //LOG(LOG_PIT,LOG_NORMAL)("PIT 0 Timer at %.4f Hz mode %d",1000.0/p.delay,p.mode);
                            break;
                        case 2:            /* Timer hooked to PC-Speaker */
                                           //            LOG(LOG_PIT,"PIT 2 Timer at %.3g Hz mode %d",PIT_TICK_RATE/(double)p.cntr,p.mode);
                                           //            PCSPEAKER_SetCounter(p.cntr,p.mode);
                            break;

                        default:
                            throw new NotImplementedException(); // LOG(LOG_PIT,LOG_ERROR)("PIT:Illegal timer selected for writing");
                    }
                    p.new_mode = false;
                }
            }
            finally
            {
                if (locked)
                    Monitor.Exit(pit_0_mutex);
            }
        }

        public int timer_read_latch(int port)
        {
            var counter = port - 0x40;
            long ret = 0;


            var locked = false;
            try
            {
                if (counter == 0)
                {
                    Monitor.Enter(pit_0_mutex, ref locked);
                    if (!locked)
                        throw new NotImplementedException();
                }

                if (pit[counter].counterstatus_set)
                {
                    pit[counter].counterstatus_set = false;
                    latched_timerstatus_locked = false;
                    ret = latched_timerstatus;
                }
                else
                {
                    if (pit[counter].go_read_latch)
                        counter_latch(counter);

                    if (pit[counter].bcd)
                        throw new NotImplementedException();

                    switch (pit[counter].read_state)
                    {
                        case 0: /* read MSB & return to state 3 */
                            ret = pit[counter].read_latch >> 8;
                            pit[counter].read_state = 3;
                            pit[counter].go_read_latch = true;
                            break;

                        case 3: /* read LSB followed by MSB */
                            ret = pit[counter].read_latch;
                            pit[counter].read_state = 0;
                            break;

                        case 1: /* read LSB */
                            ret = pit[counter].read_latch;
                            pit[counter].go_read_latch = true;
                            break;

                        case 2: /* read MSB */
                            ret = pit[counter].read_latch >> 8;
                            pit[counter].go_read_latch = true;
                            break;

                        default:
                            throw new NotImplementedException();
                    }
                }

                return checked((int)ret);
            }
            finally
            {
                if (locked)
                    Monitor.Exit(pit_0_mutex);
            }
        }

        public void timer_write_p43(int val)
        {
            var locked = false;
            try
            {
                var latch = (val >> 6) & 0x03;

                if (latch == 0)
                {
                    Monitor.Enter(pit_0_mutex, ref locked);
                    if (!locked)
                        throw new NotImplementedException();
                }

                switch (latch)
                {
                    case 0:
                    case 1:
                    case 2:
                        if ((val & 0x30) == 0)
                        {
                            /* Counter latch command */
                            counter_latch(latch);
                        }
                        else
                        {
                            pit[latch].bcd = (val & 1) != 0;
                            if (pit[latch].bcd && 9999 <= pit[latch].cntr)
                                pit[latch].cntr = 9999;

                            // Timer is being reprogrammed, unlock the status
                            if (pit[latch].counterstatus_set)
                            {
                                pit[latch].counterstatus_set = false;
                                latched_timerstatus_locked = false;
                            }

                            pit[latch].update_count = false;
                            pit[latch].counting = false;
                            pit[latch].write_state = pit[latch].read_state = (val >> 4) & 0x03;

                            var mode = (val >> 1) & 0x07;
                            if (5 < mode)
                                mode -= 4; // 6,7 become 2 and 3

                            /* Don't set it directly so counter_output uses the old mode */
                            /* That's theory. It breaks panic. So set it here again */
                            if (pit[latch].mode == 0)
                                pit[latch].mode = mode;

                            /* If the line goes from low to up => generate irq.
                             *      ( BUT needs to stay up until acknowlegded by the cpu!!! therefore: )
                             * If the line goes to low => disable irq.
                             * Mode 0 starts with a low line. (so always disable irq)
                             * Mode 2,3 start with a high line.
                             * counter_output tells if the current counter is high or low
                             * So actually a mode 2 timer enables and disables irq al the time. (not handled) */

                            if (latch == 0)
                            {
                                // PIC_RemoveEvents(pit0_event);

                                if (mode == 0)
                                    RawProgramMain.DosPic.deactivate_irq(0);
                                else if (!counter_output(0) && (mode != 0))
                                    RawProgramMain.DosPic.activate_irq(0);
                            }

                            pit[latch].new_mode = true;
                            pit[latch].mode = mode; // Set the correct mode (here)
                        }
                        break;

                    case 3:
                        if ((val & 0x20) == 0)
                        {    /* Latch multiple pit counters */
                            if ((val & 0x02) != 0)
                            {
                                Monitor.Enter(pit_0_mutex, ref locked);
                                if (!locked)
                                    throw new NotImplementedException();
                                counter_latch(0);
                            }
                            if ((val & 0x04) != 0) counter_latch(1);
                            if ((val & 0x08) != 0) counter_latch(2);
                        }
                        // status and values can be latched simultaneously
                        if ((val & 0x10) == 0)
                        {    /* Latch status words */
                             // but only 1 status can be latched simultaneously
                            if ((val & 0x02) != 0)
                            {
                                Monitor.Enter(pit_0_mutex, ref locked);
                                if (!locked)
                                    throw new NotImplementedException();
                                status_latch(0);
                            }
                            else if ((val & 0x04) != 0) status_latch(1);
                            else if ((val & 0x08) != 0) status_latch(2);
                        }
                        break;
                }
            }
            finally
            {
                if (locked)
                    Monitor.Exit(pit_0_mutex);
            }
        }

        public void TIMER_SetGate2(bool @in)
        {
            //No changes if gate doesn't change
            if (gate2 == @in)
                return;

            var mode = pit[2].mode;
            switch (mode)
            {
                case 0:
                    if (@in)
                        pit[2].start = get_total_nsec();
                    else
                    {
                        //Fill readlatch and store it.
                        counter_latch(2);
                        pit[2].cntr = pit[2].read_latch;
                    }
                    break;

                case 1:
                    // gate 1 on: reload counter; off: nothing
                    if (@in)
                    {
                        pit[2].counting = true;
                        pit[2].start = get_total_nsec();
                    }
                    break;

                case 2:
                case 3:
                    // If gate is enabled restart counting. If disable store the current read_latch
                    if (@in)
                        pit[2].start = get_total_nsec();
                    else
                        counter_latch(2);
                    break;

                case 4:
                case 5:
                    throw new NotImplementedException();
            }

            gate2 = @in; // Set it here so the counter_latch above works
        }


        private struct pit_block
        {
            public int cntr;

            public TimeSpan delay;
            public TimeSpan start;

            public int read_latch;
            public int write_latch;

            public int mode;
            public int latch_mode;
            public int read_state;
            public int write_state;

            public bool bcd;
            public bool go_read_latch;
            public bool new_mode;
            public bool counterstatus_set;
            public bool counting;
            public bool update_count;
        }
    }
}