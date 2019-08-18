using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1876eaad-0edb-45af-b4b6-e8120c2a7a46")]
        public void Method_0001_01f1()
        {
            ii(0x1_01f1, 3);  callw(0x1_0030, -0x1c4);                  /* call 0x30 */
            ii(0x1_01f4, 2);  if(jcxzw_func(0x1_0273, 0x7d)) return;    /* jcxz 0x273 */
            ii(0x1_01f6, 3);  mov(ax, memw_a16[ds, bx + 0x2]);          /* mov ax, [bx+0x2] */
            ii(0x1_01f9, 4);  mov(memw_a32[ss, ebp + 0x18], ax);        /* mov [ebp+0x18], ax */
            ii(0x1_01fd, 3);  mov(al, memb_a16[ds, bx + 0x4]);          /* mov al, [bx+0x4] */
            ii(0x1_0200, 3);  mov(ah, memb_a16[ds, bx + 0x7]);          /* mov ah, [bx+0x7] */
            ii(0x1_0203, 4);  mov(memw_a32[ss, ebp + 0x1c], ax);        /* mov [ebp+0x1c], ax */
            ii(0x1_0207, 3);  if(jmpw_func(0x1_0027, -0x1e3)) return;   /* jmp 0x27 */
        }
    }
}
