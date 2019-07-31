using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a6d15bd0-2bcb-4ba0-a968-3113f6b6ec12")]
        public void Method_0000_46cc()
        {
            ii(0x46cc, 1);    wait();                                   /* wait */
            ii(0x46cd, 4);    jmpw_abs(memw_a16[ds, 0x9bc]); return;    /* jmp word [0x9bc] */
        }
    }
}
