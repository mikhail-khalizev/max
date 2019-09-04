using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xfb42-3a7e9928")]
        public void Method_0000_fb42()
        {
            ii(0xfb42, 3);    mov(dx, memw[ss, bp + 4]);                /* mov dx, [bp+0x4] */
            ii(0xfb45, 3);    mov(cx, memw[ss, bp + 6]);                /* mov cx, [bp+0x6] */
            ii(0xfb48, 2);    shl(dx, 1);                               /* shl dx, 1 */
            ii(0xfb4a, 2);    rcl(cx, 1);                               /* rcl cx, 1 */
            ii(0xfb4c, 2);    shl(dx, 1);                               /* shl dx, 1 */
            ii(0xfb4e, 2);    rcl(cx, 1);                               /* rcl cx, 1 */
            ii(0xfb50, 2);    shl(dx, 1);                               /* shl dx, 1 */
            ii(0xfb52, 2);    rcl(cx, 1);                               /* rcl cx, 1 */
            ii(0xfb54, 2);    shl(dx, 1);                               /* shl dx, 1 */
            ii(0xfb56, 2);    rcl(cx, 1);                               /* rcl cx, 1 */
            ii(0xfb58, 4);    mov(bx, memw[ds, 0xc38]);                 /* mov bx, [0xc38] */
            ii(0xfb5c, 3);    test(bl, 3);                              /* test bl, 0x3 */
            ii(0xfb5f, 2);    if(jnz(0xfb73, 0x12)) goto l_0xfb73;      /* jnz 0xfb73 */
            ii(0xfb61, 2);    push(8);                                  /* push 0x8 */
            ii(0xfb63, 1);    pop(ds);                                  /* pop ds */
            ii(0xfb64, 3);    mov(memw[ds, bx + 2], dx);                /* mov [bx+0x2], dx */
            ii(0xfb67, 3);    mov(memb[ds, bx + 4], cl);                /* mov [bx+0x4], cl */
            ii(0xfb6a, 3);    mov(memb[ds, bx + 7], ch);                /* mov [bx+0x7], ch */
        l_0xfb6d:
            ii(0xfb6d, 2);    mov(ds, bx);                              /* mov ds, bx */
            ii(0xfb6f, 3);    mov(bx, memw[ss, bp + 8]);                /* mov bx, [bp+0x8] */
            ii(0xfb72, 1);    ret(); return;                            /* ret */
        l_0xfb73:
            ii(0xfb73, 3);    mov(ax, 7);                               /* mov ax, 0x7 */
            ii(0xfb76, 1);    push(cs);                                 /* push cs */
            ii(0xfb77, 3);    call(0xc379, -0x3801);                    /* call 0xc379 */
            ii(0xfb7a, 2);    jmp(0xfb6d, -0xf); goto l_0xfb6d;         /* jmp 0xfb6d */
        }
    }
}
