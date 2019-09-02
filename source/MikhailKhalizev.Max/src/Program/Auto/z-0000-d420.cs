using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xd420-c7bde7dc")]
        public void Method_0000_d420()
        {
            ii(0xd420, 3);    mov(al, memb[ds, 0x47]);                  /* mov al, [0x47] */
            ii(0xd423, 3);    mov(dx, 0x2cf2);                          /* mov dx, 0x2cf2 */
            ii(0xd426, 5);    cmp(memb[ds, 0x2e], 0xb);                 /* cmp byte [0x2e], 0xb */
            ii(0xd42b, 2);    if(jnz(0xd443, 0x16)) goto l_0xd443;      /* jnz 0xd443 */
            ii(0xd42d, 2);    test(al, 0x80);                           /* test al, 0x80 */
            ii(0xd42f, 2);    if(jz(0xd434, 3)) goto l_0xd434;          /* jz 0xd434 */
        l_0xd431:
            ii(0xd431, 3);    mov(dx, 0x2cf9);                          /* mov dx, 0x2cf9 */
        l_0xd434:
            ii(0xd434, 3);    mov(bx, 0xf7d);                           /* mov bx, 0xf7d */
            ii(0xd437, 5);    mov(memb[cs, bx - 3], 0xe9);              /* mov byte [cs:bx-0x3], 0xe9 */
            ii(0xd43c, 2);    sub(dx, bx);                              /* sub dx, bx */
            ii(0xd43e, 4);    mov(memw[cs, bx - 2], dx);                /* mov [cs:bx-0x2], dx */
        l_0xd442:
            ii(0xd442, 1);    ret(); return;                            /* ret */
        l_0xd443:
            ii(0xd443, 2);    test(al, 0x80);                           /* test al, 0x80 */
            ii(0xd445, 2);    if(jz(0xd442, -5)) goto l_0xd442;         /* jz 0xd442 */
            ii(0xd447, 3);    mov(bx, 0x2d0a);                          /* mov bx, 0x2d0a */
            ii(0xd44a, 5);    mov(memb[cs, bx - 3], 0xe9);              /* mov byte [cs:bx-0x3], 0xe9 */
            ii(0xd44f, 3);    mov(dx, 0xf7f);                           /* mov dx, 0xf7f */
            ii(0xd452, 2);    sub(dx, bx);                              /* sub dx, bx */
            ii(0xd454, 4);    mov(memw[cs, bx - 2], dx);                /* mov [cs:bx-0x2], dx */
            ii(0xd458, 2);    jmp(0xd431, -0x29); goto l_0xd431;        /* jmp 0xd431 */
        }
    }
}
