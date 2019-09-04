using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_accb-9334574c")]
        public void Method_0018_accb()
        {
            ii(0x18_accb, 3);  shl(bx, 2);                             /* shl bx, 0x2 */
            ii(0x18_acce, 4);  cmp(cx, memw[ds, 0xc42]);               /* cmp cx, [0xc42] */
            ii(0x18_acd2, 2);  if(jz(0x18_acd9, 5)) goto l_0x18_acd9;  /* jz 0xacd9 */
            ii(0x18_acd4, 3);  cmp(cx, 0x70);                          /* cmp cx, 0x70 */
            ii(0x18_acd7, 2);  if(jnz(0x18_ace0, 7)) goto l_0x18_ace0; /* jnz 0xace0 */
        l_0x18_acd9:
            ii(0x18_acd9, 2);  xor(cx, cx);                            /* xor cx, cx */
            ii(0x18_acdb, 3);  call(0x18_acf3, 0x15);                  /* call 0xacf3 */
            ii(0x18_acde, 2);  if(jmp_func(0x18_ac85, -0x5b)) return;  /* jmp 0xac85 */
        l_0x18_ace0:
            ii(0x18_ace0, 3);  call(0x18_acf3, 0x10);                  /* call 0xacf3 */
            ii(0x18_ace3, 5);  cmp(memb[ds, 0x1181], 0);               /* cmp byte [0x1181], 0x0 */
            ii(0x18_ace8, 2);  if(jnz_func(0x18_ac98, -0x52)) return;  /* jnz 0xac98 */
            ii(0x18_acea, 3);  mov(ax, 0x1130);                        /* mov ax, 0x1130 */
            ii(0x18_aced, 4);  mov(si, memw[ds, 0x9b6]);               /* mov si, [0x9b6] */
            ii(0x18_acf1, 2);  if(jmp_func(0x18_ac8d, -0x66)) return;  /* jmp 0xac8d */
        }
    }
}
