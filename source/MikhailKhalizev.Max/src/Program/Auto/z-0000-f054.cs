using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xf054-973886b7")]
        public void Method_0000_f054()
        {
            ii(0xf054, 4);    or(memb[ss, bp + 0x26], 1);               /* or byte [bp+0x26], 0x1 */
            ii(0xf058, 1);    push(ss);                                 /* push ss */
            ii(0xf059, 1);    push(bp);                                 /* push bp */
            ii(0xf05a, 1);    sti();                                    /* sti */
            ii(0xf05b, 3);    call(0x1_0cc7, 0x1c69);                   /* call 0xcc7 */
            ii(0xf05e, 5);    test(memw[ss, bp + 0x26], 1);             /* test word [bp+0x26], 0x1 */
            ii(0xf063, 2);    if(jnz(0xf07d, 0x18)) goto l_0xf07d;      /* jnz 0xf07d */
            ii(0xf065, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0xf067, 3);    mov(bx, memw[ss, bp + 6]);                /* mov bx, [bp+0x6] */
            ii(0xf06a, 3);    mov(cx, memw[ss, bp + 4]);                /* mov cx, [bp+0x4] */
            ii(0xf06d, 3);    mov(memw[ss, bp + 6], ax);                /* mov [bp+0x6], ax */
            ii(0xf070, 3);    shr(bx, 3);                               /* shr bx, 0x3 */
            ii(0xf073, 3);    shr(cx, 3);                               /* shr cx, 0x3 */
            ii(0xf076, 2);    cmp(cx, bx);                              /* cmp cx, bx */
            ii(0xf078, 2);    if(jnz(0xf07d, 3)) goto l_0xf07d;         /* jnz 0xf07d */
            ii(0xf07a, 3);    mov(memw[ss, bp + 4], ax);                /* mov [bp+0x4], ax */
        l_0xf07d:
            ii(0xf07d, 2);    if(jmp_func(0xf023, -0x5c)) return;       /* jmp 0xf023 */
        }
    }
}
