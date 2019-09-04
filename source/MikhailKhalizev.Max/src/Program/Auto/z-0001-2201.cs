using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_2201-1a3cc667")]
        public void Method_0001_2201()
        {
            ii(0x1_2201, 3);  call(0x1_2040, -0x1c4);                  /* call 0x2040 */
            ii(0x1_2204, 2);  if(jcxz_func(0x1_2283, 0x7d)) return;    /* jcxz 0x2283 */
            ii(0x1_2206, 3);  mov(ax, memw[ds, bx + 2]);               /* mov ax, [bx+0x2] */
            ii(0x1_2209, 4);  mov(memw_a32[ss, ebp + 24], ax);         /* mov [ebp+0x18], ax */
            ii(0x1_220d, 3);  mov(al, memb[ds, bx + 4]);               /* mov al, [bx+0x4] */
            ii(0x1_2210, 3);  mov(ah, memb[ds, bx + 7]);               /* mov ah, [bx+0x7] */
            ii(0x1_2213, 4);  mov(memw_a32[ss, ebp + 28], ax);         /* mov [ebp+0x1c], ax */
            ii(0x1_2217, 3);  if(jmp_func(0x1_2037, -0x1e3)) return;   /* jmp 0x2037 */
        }
    }
}
