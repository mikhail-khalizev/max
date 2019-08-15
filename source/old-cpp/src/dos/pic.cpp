#include <boost/thread.hpp>
#include <exo/exception.hpp>

#include "dos/pic.hpp"
#include "x86/registers.hpp"
#include "x86/instructions.hpp"


namespace raw_program {

extern bool extra_log;

namespace dos {

// file +

using namespace x86;

/* Создаётся в динамической памяти и не уничтожается после вызова 'exit', что позволяет использовать его в ещё работающих потоках, до которых 'exit' ещё не дошёл. */
pic_general & pic = * new pic_general();


// +
void pic_general::_write_command(uint_<16> port, uint_<8> val)
{
    PIC_Controller * pic_ctr = &pics[(port == 0x20) ? 0 : 1];
    int irq_base = (port == 0x20) ? 0 : 8;

    static const uint_<8>::type IRQ_priority_table[16] = {0, 1, 2, 8, 9, 10, 11, 12, 13, 14, 15, 3, 4, 5, 6, 7};

    if (0 != (val & 0x10)) // ICW1 issued
    {
        if (0 != (val & 0x04))
            throw exo::exception::not_implemented(); // E_Exit("PIC: 4 byte interval not handled");
        if (0 != (val & 0x08))
            throw exo::exception::not_implemented(); // E_Exit("PIC: level triggered mode not handled");
        if (0 != (val & 0xe0))
            throw exo::exception::not_implemented(); // E_Exit("PIC: 8080/8085 mode not handled");

        pic_ctr -> single = ((val & 0x02) == 0x02);
        pic_ctr -> icw_index = 1;            // next is ICW2
        pic_ctr -> icw_words = 2 + (val&0x01);    // =3 if ICW4 needed
    }
    else if (0 != (val & 0x08)) // OCW3 issued
    {
        if (0 != (val & 0x04))
            throw exo::exception::not_implemented(); // E_Exit("PIC: poll command not handled");

        if (0 != (val & 0x02)) // function select
        {
            if (0 != (val & 0x01))
                pic_ctr -> request_issr = true;    /* select read interrupt in-service register */
            else
                pic_ctr -> request_issr = false;/* select read interrupt request register */
        }

        if (0 != (val & 0x40)) // special mask select
        {
            if (0 != (val & 0x20))
                pic_ctr -> special = true;
            else
                pic_ctr -> special = false;

            if (pic_ctr[0].special || pics[1].special)
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
                throw exo::exception::not_implemented(); // E_Exit("rotate mode not supported");

            if (0 != (val & 0x40)) // specific EOI
            {
                if (PIC_IRQActive == (irq_base + val - 0x60))
                {
                    irqs[PIC_IRQActive].inservice = false;
                    PIC_IRQActive = -1;
                    for (int i = 0; i <= 15; i++)
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
                if (PIC_IRQActive < (irq_base + 8))
                {
                    irqs[PIC_IRQActive].inservice = false;
                    PIC_IRQActive = -1;
                    for (int i = 0; i <= 15; i++)
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
                    pic_ctr -> rotate_on_auto_eoi = true;
                else
                    pic_ctr -> rotate_on_auto_eoi = false;
            }
//                else if (val & 0x80)
//                {
//                    LOG(LOG_PIC,LOG_NORMAL)("set priority command not handled");
//                }    // else NOP command
        }
    }
}

// +
void pic_general::_write_data(uint_<16> port, uint_<8> val)
{
    PIC_Controller * pic_ctr = &pics[port == 0x21 ? 0 : 1];
    int irq_base = ((port == 0x21) ? 0 : 8);

    bool old_irq2_mask = irqs[2].masked;

    switch (pic_ctr -> icw_index)
    {
    case 0:    /* mask register */
        for (int i = 0; i <= 7; i++)
        {
            irqs[i + irq_base].masked = ((val & (1 << i)) != 0);
            if (port == 0x21)
            {
                if (irqs[i + irq_base].active && !irqs[i + irq_base].masked)
                    PIC_IRQCheck |= (1 << (i + irq_base));
                else
                    PIC_IRQCheck &= ~(1 << (i + irq_base));
            } else
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
            for (int i = 8; i <= 15; i++)
                if (irqs[i].active && !irqs[i].masked && !irqs[2].masked)
                    PIC_IRQCheck |= (1 << i);
                else
                    PIC_IRQCheck &= ~(1 << i);
        break;

    case 1:    /* icw2 */
        for (int i = 0; i <= 7; i++)
            irqs[i + irq_base].vector = (val & 0xf8) + i;

        pic_ctr -> icw_index++;
        if (pic_ctr -> icw_index > pic_ctr -> icw_words)
            pic_ctr -> icw_index = 0;
        else if (pic_ctr -> single)
            pic_ctr -> icw_index = 3;    /* skip ICW3 in single mode */
        break;

    case 2:    /* icw 3 */
        pic_ctr -> icw_index++;
        if (pic_ctr -> icw_index > pic_ctr -> icw_words)
            pic_ctr -> icw_index = 0;
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
        pic_ctr -> auto_eoi = (val & 0x2) != 0;

        if ((val & 0x01) == 0)
            throw exo::exception::not_implemented(); // E_Exit("PIC:ICW4: %x, 8085 mode not handled",val);
//            if ((val & 0x10) != 0)
//                LOG_MSG("PIC:ICW4: %x, special fully-nested mode not handled",val);

        pic_ctr -> icw_index++;
        if (pic_ctr -> icw_index > pic_ctr -> icw_words)
            pic_ctr -> icw_index = 0;
        break;
    default:
//            LOG(LOG_PIC,LOG_NORMAL)("ICW HUH? %X",val);
        break;
    }
}

// +
uint_<8> pic_general::_read_command(uint_<16> port)
{
    PIC_Controller * pic_ctr = &pics[(port == 0x20) ? 0 : 1];
    int irq_base = (port == 0x20) ? 0 : 8;

    uint_<8> ret = 0;
    uint_<8> b = 1;

    if (pic_ctr -> request_issr)
    {
        for (int i = irq_base; i < irq_base + 8; i++)
        {
            if (irqs[i].inservice)
                ret |= b;
            b <<= 1;
        }
    }
    else
    {
        for (int i = irq_base; i < irq_base + 8; i++)
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

// +
uint_<8> pic_general::_read_data(uint_<16> port)
{
    int irq_base = (port == 0x21) ? 0 : 8;
    uint_<8> ret = 0;
    uint_<8> b = 1;

    for (int i = irq_base; i <= irq_base + 7; i++)
    {
        if (irqs[i].masked)
            ret |= b;
        b <<= 1;
    }

    return ret;
}

// +
void pic_general::_activate_irq(int irq)
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

// +
void pic_general::_deactivate_irq(int irq)
{
    if (irq < 16)
    {
        irqs[irq].active = false;
        PIC_IRQCheck &= ~(1 << irq);
        PIC_IRQOnSecondPicActive &= ~(1 << irq);
    }
}

// +
void pic_general::start_irq(int i)
{
    /* irqs on second pic only if irq 2 isn't masked */

    irqs[i].active = false;
    PIC_IRQCheck &= ~(1 << i);
    PIC_IRQOnSecondPicActive &= ~(1 << i);


    PIC_Controller * pic_ctr = &pics[(i & 8) >> 3];

    if (!pic_ctr -> auto_eoi)
    {
        PIC_IRQActive = i;
        irqs[i].inservice = true;
    }
    else if (pic_ctr -> rotate_on_auto_eoi)
        throw exo::exception::not_implemented(); // E_Exit("rotate on auto EOI not handled");
}

// +
int pic_general::_run_irqs(void)
{
    if (if_ == false)
        return -1;

    if (PIC_IRQCheck == 0)
        return -1;

    static const uint_<8>::type IRQ_priority_order[16] = {0, 1, 2, 8, 9, 10, 11, 12, 13, 14, 15, 3, 4, 5, 6, 7};
    static const uint_<8>::type IRQ_priority_lookup[17] = {0, 1, 2, 11, 12, 13, 14, 15, 3, 4, 5, 6, 7, 8, 9, 10, 16};
    int activeIRQ = PIC_IRQActive;

    if (activeIRQ == -1)
        activeIRQ = 16;

    /* Get the priority of the active irq */
    uint_<8> Priority_Active_IRQ = IRQ_priority_lookup[activeIRQ];

    /* If one of the pics is in special mode use a check that cares for that. */
    if (!PIC_Special_Mode)
    {
        for (int j = 0; j < Priority_Active_IRQ; j++)
        {
            uint_<8> i = IRQ_priority_order[j];
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
        for (int j = 0; j <= 15; j++)
        {
            uint_<8> i = IRQ_priority_order[j];
            if ((j < Priority_Active_IRQ) || pics[ ((i & 8) >> 3) ].special)
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

// +
void pic_general::_set_irq_mask(uint_<32> irq, bool masked)
{
    if (irqs[irq].masked == masked)
        return;    /* Do nothing if mask doesn't change */

    bool old_irq2_mask = irqs[2].masked;
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
        for (int i = 8; i <= 15; i++)
        {
            if (irqs[i].active && !irqs[i].masked && !irqs[2].masked)
                PIC_IRQCheck |= (1 << i);
            else
                PIC_IRQCheck &= ~(1 << i);
        }
    }
}

// +
pic_general::pic_general()
: PIC_IRQCheck(0)
, PIC_IRQOnSecondPicActive(0)
, PIC_IRQActive(-1)
, PIC_Special_Mode(false)
, mutex()
{
    /* Setup pic0 and pic1 with initial values like DOS has normally */

    for (int i = 0; i < 2; i++)
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

    for (int i = 0; i <= 7; i++)
    {
        irqs[i].active = false;
        irqs[i].masked = true;
        irqs[i].inservice = false;

        irqs[i + 8].active = false;
        irqs[i + 8].masked = true;
        irqs[i + 8].inservice = false;

        irqs[i].vector = 0x8 + i;
        irqs[i + 8].vector = 0x70 + i;
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

// +
void pic_general::write_command(uint_<16> port, uint_<8> val)
{
    boost::lock_guard<boost::mutex> lock(mutex);
    _write_command(port, val);
}

// +
void pic_general::write_data(uint_<16> port, uint_<8> val)
{
    boost::lock_guard<boost::mutex> lock(mutex);
    _write_data(port, val);
}

// +
uint_<8> pic_general::read_command(uint_<16> port)
{
    boost::lock_guard<boost::mutex> lock(mutex);
    return _read_command(port);
}

// +
uint_<8> pic_general::read_data(uint_<16> port)
{
    boost::lock_guard<boost::mutex> lock(mutex);
    return _read_data(port);
}

// +
// @todo Внедрить внутрь correct_function_position для повышения производительности?
void pic_general::run_irqs()
{
    static bool in_run_irqs = false;

    if (in_run_irqs)
        return; // Не будем делать прерывание в прерывании.


    in_run_irqs = true;

    bool save_extra_log = extra_log;
    extra_log = false;

    auto _clr_in_run_irqs = [&](void *) -> void
    {
        extra_log = save_extra_log;
        in_run_irqs = false;
    };
    std::unique_ptr<void, decltype(_clr_in_run_irqs)> clr_in_run_irqs(
            &in_run_irqs /* Что угодно, только не NULL. */,
            _clr_in_run_irqs);


    for(;;)
    {
        uint_<32> vector;

        {
            boost::lock_guard<boost::mutex> lock(mutex);

            int irq = _run_irqs();
            if (irq < 0)
                return;

            vector = irqs[irq].vector;
        }

        uint_<32> ret_addr = cs.get_base() + eip_next;
        uint_<8> mode = (cs.get_db() ? 32 : 16);
        int_internal(vector, false, false, false, 0);
        if (correct_function_position(ret_addr))
            throw exo::exception::not_implemented();
        check_mode();
    }
}

// +
void pic_general::activate_irq(int irq)
{
    boost::lock_guard<boost::mutex> lock(mutex);
    _activate_irq(irq);
}

// +
void pic_general::deactivate_irq(int irq)
{
    boost::lock_guard<boost::mutex> lock(mutex);
    _deactivate_irq(irq);
}

// +
void pic_general::set_irq_mask(uint_<32> irq, bool masked)
{
    boost::lock_guard<boost::mutex> lock(mutex);
    _set_irq_mask(irq, masked);
}


} /* namespace dos */
} /* namespace raw_program */
