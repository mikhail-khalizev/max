using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb410-c7bde7dc")]
        public void Method_0000_b410()
        {
            ii(0xb410, 3);    mov(al, memb_a16[ds, 0x47]);              /* mov al, [0x47] */
            ii(0xb413, 3);    mov(dx, 0x2cf2);                          /* mov dx, 0x2cf2 */
            ii(0xb416, 5);    cmp(memb_a16[ds, 0x2e], 0xb);             /* cmp byte [0x2e], 0xb */
            ii(0xb41b, 2);    if(jnzw(0xb433, 0x16)) goto l_0xb433;     /* jnz 0xb433 */
            ii(0xb41d, 2);    test(al, 0x80);                           /* test al, 0x80 */
            ii(0xb41f, 2);    if(jzw(0xb424, 0x3)) goto l_0xb424;       /* jz 0xb424 */
        l_0xb421:
            ii(0xb421, 3);    mov(dx, 0x2cf9);                          /* mov dx, 0x2cf9 */
        l_0xb424:
            ii(0xb424, 3);    mov(bx, 0xf7d);                           /* mov bx, 0xf7d */
            ii(0xb427, 5);    mov(memb_a16[cs, bx - 0x3], 0xe9);        /* mov byte [cs:bx-0x3], 0xe9 */
            ii(0xb42c, 2);    sub(dx, bx);                              /* sub dx, bx */
            ii(0xb42e, 4);    mov(memw_a16[cs, bx - 0x2], dx);          /* mov [cs:bx-0x2], dx */
        l_0xb432:
            ii(0xb432, 1);    retw(); return;                           /* ret */
        l_0xb433:
            ii(0xb433, 2);    test(al, 0x80);                           /* test al, 0x80 */
            ii(0xb435, 2);    if(jzw(0xb432, -0x5)) goto l_0xb432;      /* jz 0xb432 */
            ii(0xb437, 3);    mov(bx, 0x2d0a);                          /* mov bx, 0x2d0a */
            ii(0xb43a, 5);    mov(memb_a16[cs, bx - 0x3], 0xe9);        /* mov byte [cs:bx-0x3], 0xe9 */
            ii(0xb43f, 3);    mov(dx, 0xf7f);                           /* mov dx, 0xf7f */
            ii(0xb442, 2);    sub(dx, bx);                              /* sub dx, bx */
            ii(0xb444, 4);    mov(memw_a16[cs, bx - 0x2], dx);          /* mov [cs:bx-0x2], dx */
            ii(0xb448, 2);    jmpw(0xb421, -0x29); goto l_0xb421;       /* jmp 0xb421 */
        }
    }
}
