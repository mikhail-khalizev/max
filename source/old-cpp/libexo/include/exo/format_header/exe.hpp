#ifndef EXO_FORMAT_HEADER_EXE_HPP_INCLUDED
#define EXO_FORMAT_HEADER_EXE_HPP_INCLUDED

#include <exo/attributes.hpp>
#include <exo/math/std_types.hpp>


namespace exo {
namespace format_header {


/** 16-bit DOS MZ executable
 * @note all multi-byte values are stored LSB first. One block is 512 bytes,
 * one paragraph is 16 bytes */
struct exe_dos
{
    typedef math::uint_<16> u16;
    typedef math::uint_<32> u32;


    /** 0x4d, 0x5a. This is the "magic number" of an EXE file. The first byte of
     * the file is 0x4d and the second is 0x5a. */
    u16 signature;

    /** The number of bytes in the last block of the program that are actually
     * used. If this value is zero, that means the entire last block is used
     * (i.e. the effective value is 512). */
    u16 bytes_in_last_block;

    /** Number of blocks in the file that are part of the EXE file. If it is
     * non-zero, only that much of the last block is used. */
    u16 blocks_in_file;

    /** Number of relocation entries stored after the header. May be zero. */
    u16 num_relocs;

    /** Number of paragraphs in the header. The program's data begins just after
     * the header, and this field can be used to calculate the appropriate file
     * offset. The header includes the relocation entries. Note that some OSs
     * and/or programs may fail if the header is not a multiple of 512 bytes. */
    u16 header_paragraphs;

    /** Number of paragraphs of additional memory that the program will need.
     * This is the equivalent of the BSS size in a Unix program. The program
     * can't be loaded if there isn't at least this much memory available to it. */
    u16 min_extra_paragraphs;

    /** Maximum number of paragraphs of additional memory. Normally, the OS
     * reserves all the remaining conventional memory for your program, but you
     * can limit it with this field. */
    u16 max_extra_paragraphs;

    /** Relative value of the stack segment. This value is added to the segment
     * the program was loaded at, and the result is used to initialize the SS
     * register. */
    u16 ss;

    /** Initial value of the SP register. */
    u16 sp;

    /** Word checksum. If set properly, the 16-bit sum of all words in the file
     * should be zero. Usually, this isn't filled in. */
    u16 checksum;

    /** Initial value of the IP register. */
    u16 ip;

    /** Initial value of the CS register, relative to the segment the program
     * was loaded at. */
    u16 cs;

    /** Offset of the first relocation item in the file. In bytes.*/
    u16 reloc_table_offset;

    /** Overlay number. Normally zero, meaning that it's the main program. */
    u16 overlay_number;


    bool is_correct()
    {
        return signature == 0x5a4d && bytes_in_last_block < 512;
    }

    /** The offset of the byte just after the EXE data (in DJGPP, the size of
     * the stub and the start of the COFF image). */
    u32 extra_data_start()
    {
        u32 ret = static_cast<u32>(blocks_in_file) * 512;

        if (bytes_in_last_block != 0)
            ret -= (512u - bytes_in_last_block);

        return ret;
    }

    /** The offset of the beginning of the EXE data. */
    u32 exe_data_start()
    {
        return static_cast<u32>(header_paragraphs) * 16;
    }

    u32 exe_data_size()
    {
        return extra_data_start() - exe_data_start();
    }

#ifdef BOOST_POLYGON_INTERVAL_DATA_HPP
    boost::polygon::interval_data<u32> exe_data()
    {
        u32 exe_start = exe_data_start();
        return boost::polygon::interval_data<u32>(start, extra_data_start() - exe_start);
    }
#endif

    struct reloc
    {
        u16 offset;
        u16 segment;

        reloc()
        : offset()
        , segment()
        {}

        operator u32() const
        {
            return static_cast<u32>(segment) * 16 + offset;
        }
    };
};// __attribute_packed__;

static_assert(sizeof(exe_dos) == 28, "Компилятор неправильно упаковал структуру.");


/* 32-bit Portable Executable */
/*
struct exe_pe
{

} __attribute_packed__;
*/


} /* namespace format_header */
} /* namespace exo */

#endif /* EXO_FORMAT_HEADER_EXE_HPP_INCLUDED */
