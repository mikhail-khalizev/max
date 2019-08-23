using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xc4b1-40bab9bb")]
        public void Method_0000_c4b1()
        {
            ii(0xc4b1, 1);    push(bp);                                 /* push bp */
            ii(0xc4b2, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xc4b4, 1);    push(di);                                 /* push di */
            ii(0xc4b5, 3);    mov(cx, memw[ss, bp + 0x8]);              /* mov cx, [bp+0x8] */
            ii(0xc4b8, 2);    if(jcxz(0xc4f6, 0x3c)) goto l_0xc4f6;     /* jcxz 0xc4f6 */
            ii(0xc4ba, 3);    call(0x6040, -0x647d);                    /* call 0x6040 */
            ii(0xc4bd, 2);    push(0x8);                                /* push 0x8 */
            ii(0xc4bf, 1);    pop(es);                                  /* pop es */
            ii(0xc4c0, 3);    mov(bx, memw[ss, bp + 0x4]);              /* mov bx, [bp+0x4] */
            ii(0xc4c3, 3);    and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0xc4c6, 4);    mov(ax, memw[es, bx + 0x2]);              /* mov ax, [es:bx+0x2] */
            ii(0xc4ca, 4);    mov(memw[es, 0x62], ax);                  /* mov [es:0x62], ax */
            ii(0xc4ce, 4);    mov(al, memb[es, bx + 0x4]);              /* mov al, [es:bx+0x4] */
            ii(0xc4d2, 4);    mov(memb[es, 0x64], al);                  /* mov [es:0x64], al */
            ii(0xc4d6, 4);    mov(al, memb[es, bx + 0x7]);              /* mov al, [es:bx+0x7] */
            ii(0xc4da, 4);    mov(memb[es, 0x67], al);                  /* mov [es:0x67], al */
            ii(0xc4de, 2);    push(0x60);                               /* push 0x60 */
            ii(0xc4e0, 1);    pop(es);                                  /* pop es */
            ii(0xc4e1, 3);    mov(di, memw[ss, bp + 0x6]);              /* mov di, [bp+0x6] */
            ii(0xc4e4, 1);    cld();                                    /* cld */
            ii(0xc4e5, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0xc4e7, 3);    mov(cx, memw[ss, bp + 0x8]);              /* mov cx, [bp+0x8] */
            ii(0xc4ea, 2);    shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0xc4ec, 2);    if(jz(0xc4f0, 0x2)) goto l_0xc4f0;        /* jz 0xc4f0 */
            ii(0xc4ee, 2);    rep(() => stosw());                       /* rep stosw */
        l_0xc4f0:
            ii(0xc4f0, 2);    if(jae(0xc4f3, 0x1)) goto l_0xc4f3;       /* jae 0xc4f3 */
            ii(0xc4f2, 1);    stosb();                                  /* stosb */
        l_0xc4f3:
            ii(0xc4f3, 3);    call(0x66d9, -0x5e1d);                    /* call 0x66d9 */
        l_0xc4f6:
            ii(0xc4f6, 1);    pop(di);                                  /* pop di */
            ii(0xc4f7, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0xc4f9, 1);    pop(bp);                                  /* pop bp */
            ii(0xc4fa, 1);    sti();                                    /* sti */
            ii(0xc4fb, 1);    ret();                                    /* ret */
        }
    }
}
