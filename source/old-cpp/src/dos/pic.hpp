#ifndef OPENMAX_DOS_PIC_HPP_INCLUDED
#define OPENMAX_DOS_PIC_HPP_INCLUDED

#include <exo/global.hpp>
#include <boost/thread/mutex.hpp>

namespace raw_program {
namespace dos {

class pic_general
{
    struct IRQ_Block
    {
        bool masked;
        bool active;
        bool inservice;
        uint_<32> vector;

        IRQ_Block()
        : masked()
        , active()
        , inservice()
        , vector()
        {}
    };

    struct PIC_Controller
    {
        uint_<32> icw_words;
        uint_<32> icw_index;
        uint_<32> masked;

        bool special;
        bool auto_eoi;
        bool rotate_on_auto_eoi;
        bool single;
        bool request_issr;
        uint_<8> vector_base;

        PIC_Controller()
        : icw_words()
        , icw_index()
        , masked()
        , special()
        , auto_eoi()
        , rotate_on_auto_eoi()
        , single()
        , request_issr()
        , vector_base()
        {}
    };

    uint_<32> PIC_IRQCheck;
    uint_<32> PIC_IRQOnSecondPicActive;
    int PIC_IRQActive;


    IRQ_Block irqs[16];
    PIC_Controller pics[2];
    bool PIC_Special_Mode; // Saves one compare in the pic_run_irqloop

    boost::mutex mutex;

    void _write_command(uint_<16> port, uint_<8> val);
    void _write_data(uint_<16> port, uint_<8> val);
    uint_<8> _read_command(uint_<16> port);
    uint_<8> _read_data(uint_<16> port);

    void _activate_irq(int irq);
    void _deactivate_irq(int irq);
    void _set_irq_mask(uint_<32> irq, bool masked);

    void start_irq(int i);
    /** @return true if all interrupts handled. */
    int _run_irqs(void);

public:

    pic_general();

    void write_command(uint_<16> port, uint_<8> val);
    void write_data(uint_<16> port, uint_<8> val);
    uint_<8> read_command(uint_<16> port);
    uint_<8> read_data(uint_<16> port);

    void run_irqs();

    void activate_irq(int irq);
    void deactivate_irq(int irq);
    void set_irq_mask(uint_<32> irq, bool masked);
};

extern pic_general & pic;

} /* namespace dos */
} /* namespace raw_program */

#endif /* OPENMAX_DOS_PIC_HPP_INCLUDED */
