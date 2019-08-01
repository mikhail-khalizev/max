using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f738fbbf-cc7a-4815-95c9-8e45c45e85b1")]
        public void Method_0001_1354()
        {
            ii(0x1_1354, 1);  popw(ax);                                 /* pop ax */
            ii(0x1_1355, 1);  pushw(cs);                                /* push cs */
            ii(0x1_1356, 1);  pushw(ax);                                /* push ax */
            ii(0x1_1357, 5);  jmpw_far_abs(0x18, 0x2b47); return;       /* jmp word 0x18:0x2b47 */
        }
    }
}
