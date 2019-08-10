using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c1774b60-0c1a-416b-85a7-a130523c3e73")]
        public void Method_0000_ef8b()
        {
            ii(0xef8b, 5);    test(memb_a16[ds, 0x15], 0x1);            /* test byte [0x15], 0x1 */
            ii(0xef90, 2);    if(jnzw_func(0xef68, -0x2a)) return;      /* jnz 0xaf98 */
            ii(0xef92, 5);    cmp(memb_a16[ds, 0x34], 0x15);            /* cmp byte [0x34], 0x15 */
            ii(0xef97, 2);    if(jnzw_func(0xef68, -0x31)) return;      /* jnz 0xaf98 */
            ii(0xef99, 3);    callw(0xe88f, -0x70d);                    /* call 0xa8bf */
            ii(0xef9c, 2);    pushw(0x40);                              /* push 0x40 */
            ii(0xef9e, 1);    popw(es);                                 /* pop es */
            ii(0xef9f, 5);    mov(bx, memw_a16[es, 0x6e]);              /* mov bx, [es:0x6e] */
            ii(0xefa4, 3);    mov(ax, 0x16);                            /* mov ax, 0x16 */
            ii(0xefa7, 2);    mul(bx);                                  /* mul bx */
            ii(0xefa9, 3);    mov(cx, 0x3);                             /* mov cx, 0x3 */
            ii(0xefac, 2);    div(cx);                                  /* div cx */
            ii(0xefae, 5);    mov(cx, memw_a16[es, 0x6c]);              /* mov cx, [es:0x6c] */
            ii(0xefb3, 3);    shr(cx, 0xd);                             /* shr cx, 0xd */
            ii(0xefb6, 2);    add(cx, ax);                              /* add cx, ax */
            ii(0xefb8, 4);    mov(ax, memw_a16[es, 0x6c]);              /* mov ax, [es:0x6c] */
            ii(0xefbc, 2);    sub(ax, cx);                              /* sub ax, cx */
            ii(0xefbe, 3);    sbb(bl, 0);                               /* sbb bl, 0x0 */
            ii(0xefc1, 3);    mov(cx, 0xcfb);                           /* mov cx, 0xcfb */
            ii(0xefc4, 2);    mul(cx);                                  /* mul cx */
            ii(0xefc6, 3);    mov(cx, 0xec54);                          /* mov cx, 0xec54 */
            ii(0xefc9, 2);    div(cx);                                  /* div cx */
            ii(0xefcb, 2);    mov(ch, 0x3c);                            /* mov ch, 0x3c */
            ii(0xefcd, 2);    div(ch);                                  /* div ch */
            ii(0xefcf, 2);    xchg(bl, ah);                             /* xchg bl, ah */
            ii(0xefd1, 3);    mov(memw_a16[ss, bp + 0x14], ax);         /* mov [bp+0x14], ax */
            ii(0xefd4, 1);    xchg(dx, ax);                             /* xchg dx, ax */
            ii(0xefd5, 2);    xor(dx, dx);                              /* xor dx, dx */
            ii(0xefd7, 3);    mov(cx, 0x25d);                           /* mov cx, 0x25d */
            ii(0xefda, 2);    div(cx);                                  /* div cx */
            ii(0xefdc, 2);    mov(ah, bl);                              /* mov ah, bl */
            ii(0xefde, 3);    mov(memw_a16[ss, bp + 0x12], ax);         /* mov [bp+0x12], ax */
            ii(0xefe1, 2);    if(jmpw_func(0xef65, -0x7e)) return;      /* jmp 0xaf95 */
        }
    }
}
