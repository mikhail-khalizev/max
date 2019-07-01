#ifndef OPENMAX_DOS_DMA_HPP_INCLUDED
#define OPENMAX_DOS_DMA_HPP_INCLUDED

#include <exo/global.hpp>

namespace raw_program {
namespace dos {


enum class dma_event
{
    reached_tc,
    masked,
    unmasked,
    transferend
};

class dma_channel;
typedef void (* dma_callback)(dma_channel * chan, dma_event event);

class dma_channel
{
private:

    dma_callback callback;

public:

    uint_<32> pagebase;

    uint_<32> curraddr;
    uint_<16> baseaddr;

    uint_<16> basecnt;
    uint_<16> currcnt;

    uint_<8> channum;
    uint_<8> pagenum;
    /* 0 or 1. */
    uint_<8> DMA16;
//    uint_<8> trantype;

    bool increment;
    bool autoinit;
    bool masked;
    bool tcount;
    bool request;

    dma_channel(uint_<8> num, bool dma16);

    void do_callback(dma_event event);
    void set_mask(bool mask);
    void register_callback(dma_callback cb);
    void reached_tc(void);
    void set_page(uint_<8> val);
    void raise_request(void);
    void clear_request(void);

    uint_<32> read(void * buffer, uint_<32> size);
    uint_<32> write(uint_<8> * buffer, uint_<32> size);
};

class dma_controller
{
private:

    dma_channel dma_channels[4];
    /** first or second DMA controller */
    uint_<8> ctrlnum;
    bool flipflop;

public:

    /** @param num first or second DMA controller */
    dma_controller(int num);

    dma_channel & get_channel(uint_<8> chan);

    void write_controller_reg(uint_<32> reg, uint_<32> val);
    uint_<16> read_controller_reg(uint_<16> reg);
};



extern dma_controller dma_controllers[2];


void dma_write_p8x(uint_<16> port, uint_<16> val);
uint_<16> dma_read_p8x(uint_<16> port);

dma_channel & dma_get_channel(uint_<8> chan);


} /* namespace dos */
} /* namespace raw_program */

#endif /* OPENMAX_DOS_DMA_HPP_INCLUDED */
