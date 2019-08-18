using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4c98-52b095ef")]
        public void Method_0000_4c98()
        {
            ii(0x4c98, 3);    mov(memw_a16[ds, bx + 0x1e], cs);         /* mov [bx+0x1e], cs */
            ii(0x4c9b, 1);    xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x4c9c, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x4c9e, 4);    mov(al, memb_a16[ds, bx + 0x10be]);       /* mov al, [bx+0x10be] */
            ii(0x4ca2, 2);    add(bx, bx);                              /* add bx, bx */
            ii(0x4ca4, 2);    add(bx, bx);                              /* add bx, bx */
            ii(0x4ca6, 2);    xor(cx, cx);                              /* xor cx, cx */
            ii(0x4ca8, 3);    lea(dx, bx - 0x20);                       /* lea dx, [bx-0x20] */
            ii(0x4cab, 4);    cmp(dx, 0x98);                            /* cmp dx, 0x98 */
            ii(0x4caf, 2);    if(jaw(0x4cbc, 0xb)) goto l_0x4cbc;       /* ja 0x4cbc */
            ii(0x4cb1, 2);    test(al, al);                             /* test al, al */
            ii(0x4cb3, 2);    if(jzw(0x4cbc, 0x7)) goto l_0x4cbc;       /* jz 0x4cbc */
            ii(0x4cb5, 3);    mov(cx, 0x1a2);                           /* mov cx, 0x1a2 */
            ii(0x4cb8, 4);    add(bx, 0xf6a);                           /* add bx, 0xf6a */
        l_0x4cbc:
            ii(0x4cbc, 2);    mov(es, cx);                              /* mov es, cx */
            ii(0x4cbe, 4);    mov(cx, memw_a16[es, bx + 0x2]);          /* mov cx, [es:bx+0x2] */
            ii(0x4cc2, 2);    if(jcxzw(0x4cd1, 0xd)) goto l_0x4cd1;     /* jcxz 0x4cd1 */
            ii(0x4cc4, 3);    mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x4cc7, 3);    mov(memw_a16[ss, bp + 0x16], cx);         /* mov [bp+0x16], cx */
            ii(0x4cca, 3);    mov(memw_a16[ss, bp + 0x14], ax);         /* mov [bp+0x14], ax */
            ii(0x4ccd, 1);    popw(ds);                                 /* pop ds */
            ii(0x4cce, 1);    popw(es);                                 /* pop es */
            ii(0x4ccf, 1);    popa();                                   /* popa */
            ii(0x4cd0, 1);    iretw(); return;                          /* iretw */
        l_0x4cd1:
            ii(0x4cd1, 3);    if(jmpw_func(0x3ff1, -0xce3)) return;     /* jmp 0x3ff1 */
        }
    }
}
