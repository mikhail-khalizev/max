using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x84a4-1339f988")]
        public void Method_0000_84a4()
        {
            ii(0x84a4, 4);    enter(0xc, 0);                            /* enter 0xc, 0x0 */
            ii(0x84a8, 2);    push(5);                                  /* push 0x5 */
            ii(0x84aa, 3);    lea(ax, memw[ss, bp - 8]);                /* lea ax, [bp-0x8] */
            ii(0x84ad, 1);    push(ax);                                 /* push ax */
            ii(0x84ae, 2);    push(0x10);                               /* push 0x10 */
            ii(0x84b0, 2);    push(3);                                  /* push 0x3 */
            ii(0x84b2, 3);    call(0x47dd, -0x3cd8);                    /* call 0x47dd */
            ii(0x84b5, 3);    add(sp, 8);                               /* add sp, 0x8 */
            ii(0x84b8, 3);    push(0xeee);                              /* push 0xeee */
            ii(0x84bb, 3);    lea(ax, memw[ss, bp - 8]);                /* lea ax, [bp-0x8] */
            ii(0x84be, 1);    push(ax);                                 /* push ax */
            ii(0x84bf, 3);    call(0x4f4d, -0x3575);                    /* call 0x4f4d */
            ii(0x84c2, 1);    pop(bx);                                  /* pop bx */
            ii(0x84c3, 1);    pop(bx);                                  /* pop bx */
            ii(0x84c4, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x84c6, 2);    if(jz(0x8518, 0x50)) goto l_0x8518;       /* jz 0x8518 */
            ii(0x84c8, 2);    push(2);                                  /* push 0x2 */
            ii(0x84ca, 3);    lea(ax, memw[ss, bp - 0xc]);              /* lea ax, [bp-0xc] */
            ii(0x84cd, 1);    push(ax);                                 /* push ax */
            ii(0x84ce, 2);    push(0x10);                               /* push 0x10 */
            ii(0x84d0, 2);    push(0x1e);                               /* push 0x1e */
            ii(0x84d2, 3);    call(0x47dd, -0x3cf8);                    /* call 0x47dd */
            ii(0x84d5, 3);    add(sp, 8);                               /* add sp, 0x8 */
            ii(0x84d8, 3);    push(memw[ss, bp - 0xc]);                 /* push word [bp-0xc] */
            ii(0x84db, 3);    call(0x9d3c, 0x185e);                     /* call 0x9d3c */
            ii(0x84de, 1);    pop(bx);                                  /* pop bx */
            ii(0x84df, 3);    mov(memw[ss, bp - 0xc], ax);              /* mov [bp-0xc], ax */
            ii(0x84e2, 3);    mov(memw[ss, bp - 0xa], dx);              /* mov [bp-0xa], dx */
            ii(0x84e5, 3);    mov(ax, memw[ds, 0x98]);                  /* mov ax, [0x98] */
            ii(0x84e8, 4);    mov(dx, memw[ds, 0x9a]);                  /* mov dx, [0x9a] */
            ii(0x84ec, 3);    cmp(memw[ss, bp - 0xa], dx);              /* cmp [bp-0xa], dx */
            ii(0x84ef, 2);    if(jb(0x8518, 0x27)) goto l_0x8518;       /* jb 0x8518 */
            ii(0x84f1, 2);    if(ja(0x84f8, 5)) goto l_0x84f8;          /* ja 0x84f8 */
            ii(0x84f3, 3);    cmp(memw[ss, bp - 0xc], ax);              /* cmp [bp-0xc], ax */
            ii(0x84f6, 2);    if(jbe(0x8518, 0x20)) goto l_0x8518;      /* jbe 0x8518 */
        l_0x84f8:
            ii(0x84f8, 3);    mov(ax, memw[ds, 0x9c]);                  /* mov ax, [0x9c] */
            ii(0x84fb, 4);    mov(dx, memw[ds, 0x9e]);                  /* mov dx, [0x9e] */
            ii(0x84ff, 3);    cmp(memw[ss, bp - 0xa], dx);              /* cmp [bp-0xa], dx */
            ii(0x8502, 2);    if(ja(0x8518, 0x14)) goto l_0x8518;       /* ja 0x8518 */
            ii(0x8504, 2);    if(jb(0x850b, 5)) goto l_0x850b;          /* jb 0x850b */
            ii(0x8506, 3);    cmp(memw[ss, bp - 0xc], ax);              /* cmp [bp-0xc], ax */
            ii(0x8509, 2);    if(jae(0x8518, 0xd)) goto l_0x8518;       /* jae 0x8518 */
        l_0x850b:
            ii(0x850b, 3);    mov(ax, memw[ss, bp - 0xc]);              /* mov ax, [bp-0xc] */
            ii(0x850e, 3);    mov(dx, memw[ss, bp - 0xa]);              /* mov dx, [bp-0xa] */
            ii(0x8511, 3);    mov(memw[ds, 0x98], ax);                  /* mov [0x98], ax */
            ii(0x8514, 4);    mov(memw[ds, 0x9a], dx);                  /* mov [0x9a], dx */
        l_0x8518:
            ii(0x8518, 1);    leave();                                  /* leave */
            ii(0x8519, 1);    ret();                                    /* ret */
        }
    }
}
