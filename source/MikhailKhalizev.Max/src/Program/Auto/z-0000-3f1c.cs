using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b34d0d17-2d73-4065-a41c-23ad585d817b")]
        public void Method_0000_3f1c()
        {
        //    ii(0x3f1c, 1);    nop();                                    /* nop */
            ii(0x3f1d, 4);    jmpw_abs(memw_a16[ds, 0x9bc]);            /* jmp word [0x9bc] */
        }
    }
}
