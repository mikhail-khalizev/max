using System.Linq;
using Kaitai;

namespace MikhailKhalizev.Max.Dos
{
    public partial class DosMz
    {
        public DosMz(byte[] exeBytes)
            : this(new KaitaiStream(exeBytes))
        { }
        
        public int ExeDataStart => Hdr.HeaderSize * 16;

        public int ExeDataLength => ExtraDataStart - ExeDataStart;

        public int ExtraDataStart
        {
            get
            {
                var ret = Hdr.NumPages * 512;

                if (Hdr.LastPageExtraBytes != 0)
                    ret = ret - 512 + Hdr.LastPageExtraBytes;

                return ret;
            }
        }

        public bool IsCorrect => Hdr.Magic.SequenceEqual(new byte[] { 0x4d, 0x5a }) && Hdr.LastPageExtraBytes < 512;
    }
}