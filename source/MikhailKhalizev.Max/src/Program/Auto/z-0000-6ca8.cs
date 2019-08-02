using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e8ff0220-4099-47b1-9872-0b11273368aa")]
        public void Method_0000_6ca8()
        {
            ii(0x6ca8, 3);    mov(memw_a16[ds, bx + 0x1e], cs);         /* mov [bx+0x1e], cs */
            ii(0x6cab, 1);    xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x6cac, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x6cae, 4);    mov(al, memb_a16[ds, bx + 0x10be]);       /* mov al, [bx+0x10be] */
            ii(0x6cb2, 2);    add(bx, bx);                              /* add bx, bx */
            ii(0x6cb4, 2);    add(bx, bx);                              /* add bx, bx */
            ii(0x6cb6, 2);    xor(cx, cx);                              /* xor cx, cx */
            ii(0x6cb8, 3);    lea(dx, bx - 0x20);                       /* lea dx, [bx-0x20] */
            ii(0x6cbb, 4);    cmp(dx, 0x98);                            /* cmp dx, 0x98 */
            ii(0x6cbf, 2);    if(jaw(0x6ccc, 0xb)) goto l_0x6ccc;       /* ja 0x6ccc */
            ii(0x6cc1, 2);    test(al, al);                             /* test al, al */
            ii(0x6cc3, 2);    if(jzw(0x6ccc, 0x7)) goto l_0x6ccc;       /* jz 0x6ccc */
            ii(0x6cc5, 3);    mov(cx, 0x1a2);                           /* mov cx, 0x1a2 */
            ii(0x6cc8, 4);    add(bx, 0xf6a);                           /* add bx, 0xf6a */
        l_0x6ccc:
            ii(0x6ccc, 2);    mov(es, cx);                              /* mov es, cx */
            ii(0x6cce, 4);    mov(cx, memw_a16[es, bx + 0x2]);          /* mov cx, [es:bx+0x2] */
            ii(0x6cd2, 2);    if(jcxzw(0x6ce1, 0xd)) goto l_0x6ce1;     /* jcxz 0x6ce1 */
            ii(0x6cd4, 3);    mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x6cd7, 3);    mov(memw_a16[ss, bp + 0x16], cx);         /* mov [bp+0x16], cx */
            ii(0x6cda, 3);    mov(memw_a16[ss, bp + 0x14], ax);         /* mov [bp+0x14], ax */
            ii(0x6cdd, 1);    popw(ds);                                 /* pop ds */
            ii(0x6cde, 1);    popw(es);                                 /* pop es */
            ii(0x6cdf, 1);    popa();                                   /* popa */
            ii(0x6ce0, 1);    iretw(); return;                          /* iretw */
        l_0x6ce1:
            ii(0x6ce1, 3);    jmpw_func(0x6001, -0xce3); return;        /* jmp 0x6001 */
        }
    }
}