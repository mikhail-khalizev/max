using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_f9dc-894fbeaa")]
        public void Method_0018_f9dc()
        {
            ii(0x18_f9dc, 3);  shl(bx, 3);                             /* shl bx, 0x3 */
            ii(0x18_f9df, 4);  add(bx, 0x142);                         /* add bx, 0x142 */
            ii(0x18_f9e3, 4);  push(memd[ds, bx + 4]);                 /* push dword [bx+0x4] */
            ii(0x18_f9e7, 3);  push(memd[ds, bx]);                     /* push dword [bx] */
            ii(0x18_f9ea, 4);  mov(ds, memw_a32[ss, ebp - 6]);         /* mov ds, [ebp-0x6] */
            ii(0x18_f9ee, 5);  mov(ebx, memd_a32[ss, ebp - 4]);        /* mov ebx, [ebp-0x4] */
            ii(0x18_f9f3, 5);  mov(ebp, memd_a32[ss, ebp]);            /* mov ebp, [ebp] */
            ii(0x18_f9f8, 4);  retfd(0x10);                            /* o32 retf 0x10 */
        }
    }
}
