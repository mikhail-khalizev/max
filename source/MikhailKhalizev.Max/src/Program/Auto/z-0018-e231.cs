using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e231-1a3cc667")]
        public void Method_0018_e231()
        {
            ii(0x18_e231, 3); callw(0x18_e070, -0x1c4);                 /* call 0xe070 */
            ii(0x18_e234, 2); if(jcxzw_func(0x18_e2b3, 0x7d)) return;   /* jcxz 0xe2b3 */
            ii(0x18_e236, 3); mov(ax, memw_a16[ds, bx + 0x2]);          /* mov ax, [bx+0x2] */
            ii(0x18_e239, 4); mov(memw_a32[ss, ebp + 0x18], ax);        /* mov [ebp+0x18], ax */
            ii(0x18_e23d, 3); mov(al, memb_a16[ds, bx + 0x4]);          /* mov al, [bx+0x4] */
            ii(0x18_e240, 3); mov(ah, memb_a16[ds, bx + 0x7]);          /* mov ah, [bx+0x7] */
            ii(0x18_e243, 4); mov(memw_a32[ss, ebp + 0x1c], ax);        /* mov [ebp+0x1c], ax */
            ii(0x18_e247, 3); if(jmpw_func(0x18_e067, -0x1e3)) return;  /* jmp 0xe067 */
        }
    }
}
