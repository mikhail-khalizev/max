using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_01f1-1a3cc667")]
        public void Method_0001_01f1()
        {
            ii(0x1_01f1, 3);  call(0x1_0030, -0x1c4);                  /* call 0x30 */
            ii(0x1_01f4, 2);  if(jcxz_func(0x1_0273, 0x7d)) return;    /* jcxz 0x273 */
            ii(0x1_01f6, 3);  mov(ax, memw[ds, bx + 2]);               /* mov ax, [bx+0x2] */
            ii(0x1_01f9, 4);  mov(memw_a32[ss, ebp + 24], ax);         /* mov [ebp+0x18], ax */
            ii(0x1_01fd, 3);  mov(al, memb[ds, bx + 4]);               /* mov al, [bx+0x4] */
            ii(0x1_0200, 3);  mov(ah, memb[ds, bx + 7]);               /* mov ah, [bx+0x7] */
            ii(0x1_0203, 4);  mov(memw_a32[ss, ebp + 28], ax);         /* mov [ebp+0x1c], ax */
            ii(0x1_0207, 3);  jmp_func(0x1_0027, -0x1e3);              /* jmp 0x27 */
        }
    }
}
