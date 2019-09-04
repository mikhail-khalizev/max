using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_b084-973886b7")]
        public void Method_0018_b084()
        {
            ii(0x18_b084, 4);  or(memb[ss, bp + 38], 1);               /* or byte [bp+0x26], 0x1 */
            ii(0x18_b088, 1);  push(ss);                               /* push ss */
            ii(0x18_b089, 1);  push(bp);                               /* push bp */
            ii(0x18_b08a, 1);  sti();                                  /* sti */
            ii(0x18_b08b, 3);  call(0x18_ccf7, 0x1c69);                /* call 0xccf7 */
            ii(0x18_b08e, 5);  test(memw[ss, bp + 38], 1);             /* test word [bp+0x26], 0x1 */
            ii(0x18_b093, 2);  if(jnz(0x18_b0ad, 0x18)) goto l_0x18_b0ad;/* jnz 0xb0ad */
            ii(0x18_b095, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x18_b097, 3);  mov(bx, memw[ss, bp + 6]);              /* mov bx, [bp+0x6] */
            ii(0x18_b09a, 3);  mov(cx, memw[ss, bp + 4]);              /* mov cx, [bp+0x4] */
            ii(0x18_b09d, 3);  mov(memw[ss, bp + 6], ax);              /* mov [bp+0x6], ax */
            ii(0x18_b0a0, 3);  shr(bx, 3);                             /* shr bx, 0x3 */
            ii(0x18_b0a3, 3);  shr(cx, 3);                             /* shr cx, 0x3 */
            ii(0x18_b0a6, 2);  cmp(cx, bx);                            /* cmp cx, bx */
            ii(0x18_b0a8, 2);  if(jnz(0x18_b0ad, 3)) goto l_0x18_b0ad; /* jnz 0xb0ad */
            ii(0x18_b0aa, 3);  mov(memw[ss, bp + 4], ax);              /* mov [bp+0x4], ax */
        l_0x18_b0ad:
            ii(0x18_b0ad, 2);  if(jmp_func(0x18_b053, -0x5c)) return;  /* jmp 0xb053 */
        }
    }
}
