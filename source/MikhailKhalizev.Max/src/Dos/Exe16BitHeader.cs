using System;
using System.Runtime.InteropServices;

namespace MikhailKhalizev.Max.Dos
{
    // TODO migrate to http://formats.kaitai.io/dos_mz/csharp.html

    /// <summary>
    /// 16-bit DOS MZ executable.
    /// </summary>
    /// <remarks>
    /// all multi-byte values are stored LSB first.One block is 512 bytes,
    /// one paragraph is 16 bytes.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 28, CharSet = CharSet.Ansi)]
    public struct Exe16BitHeader
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 4, CharSet = CharSet.Ansi)]
        public struct reloc
        {
            ushort offset;

            ushort segment;

            public int Get()
            {
                return segment * 16 + offset;
            }
        }


        static Exe16BitHeader()
        {
            if (Marshal.SizeOf<Exe16BitHeader>() != 28)
                throw new Exception("SizeOf(Exe16BitHeader) != 28");
        }

        /// <summary>
        /// 0x4d, 0x5a. This is the "magic number" of an EXE file. The first byte of
        /// the file is 0x4d and the second is 0x5a.
        /// </summary>
        public ushort signature;

        /// <summary>
        /// The number of bytes in the last block of the program that are actually
        /// used. If this value is zero, that means the entire last block is used
        /// (i.e. the effective value is 512).
        /// </summary>
        public ushort bytes_in_last_block;

        /// <summary>
        /// Number of blocks in the file that are part of the EXE file. If it is
        /// non-zero, only that much of the last block is used.
        /// </summary>
        public ushort blocks_in_file;

        /// <summary>
        /// Number of relocation entries stored after the header. May be zero.
        /// </summary>
        public ushort num_relocs;

        /// <summary>
        /// Number of paragraphs in the header. The program's data begins just after
        /// the header, and this field can be used to calculate the appropriate file
        /// offset. The header includes the relocation entries. Note that some OSs
        /// and/or programs may fail if the header is not a multiple of 512 bytes.
        /// </summary>
        public ushort header_paragraphs;

        /// <summary>
        /// Number of paragraphs of additional memory that the program will need.
        /// This is the equivalent of the BSS size in a Unix program. The program
        /// can't be loaded if there isn't at least this much memory available to it.
        /// </summary>
        public ushort min_extra_paragraphs;

        /// <summary>
        /// Maximum number of paragraphs of additional memory. Normally, the OS
        /// reserves all the remaining conventional memory for your program, but you
        /// can limit it with this field.
        /// </summary>
        public ushort max_extra_paragraphs;

        /// <summary>
        /// Relative value of the stack segment. This value is added to the segment
        /// the program was loaded at, and the result is used to initialize the SS
        /// register.
        /// </summary>
        public ushort ss;

        /// <summary>
        /// Initial value of the SP register.
        /// </summary>
        public ushort sp;

        /// <summary>
        /// Word checksum. If set properly, the 16-bit sum of all words in the file
        /// should be zero. Usually, this isn't filled in.
        /// </summary>
        public ushort checksum;

        /// <summary>
        /// Initial value of the IP register.
        /// </summary>
        public ushort ip;

        /// <summary>
        /// Initial value of the CS register, relative to the segment the program
        /// was loaded at.
        /// </summary>
        public ushort cs;

        /// <summary>
        /// Offset of the first relocation item in the file. In bytes.
        /// </summary>
        public ushort reloc_table_offset;

        /// <summary>
        /// Overlay number. Normally zero, meaning that it's the main program.
        /// </summary>
        public ushort overlay_number;


        public bool is_correct()
        {
            return signature == 0x5a4d && bytes_in_last_block < 512;
        }

        /// <summary>
        /// The offset of the byte just after the EXE data (in DJGPP, the size of
        /// the stub and the start of the COFF image).
        /// </summary>
        public int extra_data_start()
        {
            var ret = blocks_in_file * 512;

            if (bytes_in_last_block != 0)
                ret -= 512 - bytes_in_last_block;

            return ret;
        }

        /// <summary>
        /// The offset of the beginning of the EXE data.
        /// </summary>
        public int exe_data_start()
        {
            return header_paragraphs * 16;
        }

        public int exe_data_size()
        {
            return extra_data_start() - exe_data_start();
        }
    }
}