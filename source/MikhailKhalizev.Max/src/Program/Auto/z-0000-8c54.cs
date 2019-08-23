using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8c54-1339f988")]
        public void Method_0000_8c54()
        {
            ii(0x8c54, 4);    enter(0xc, 0);                            /* enter 0xc, 0x0 */
            ii(0x8c58, 2);    push(0x5);                                /* push 0x5 */
            ii(0x8c5a, 3);    lea(ax, bp - 0x8);                        /* lea ax, [bp-0x8] */
            ii(0x8c5d, 1);    push(ax);                                 /* push ax */
            ii(0x8c5e, 2);    push(0x10);                               /* push 0x10 */
            ii(0x8c60, 2);    push(0x3);                                /* push 0x3 */
            ii(0x8c62, 3);    call(0x4f8d, -0x3cd8);                    /* call 0x4f8d */
            ii(0x8c65, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x8c68, 3);    push(0xeee);                              /* push 0xeee */
            ii(0x8c6b, 3);    lea(ax, bp - 0x8);                        /* lea ax, [bp-0x8] */
            ii(0x8c6e, 1);    push(ax);                                 /* push ax */
            ii(0x8c6f, 3);    call(0x56fd, -0x3575);                    /* call 0x56fd */
            ii(0x8c72, 1);    pop(bx);                                  /* pop bx */
            ii(0x8c73, 1);    pop(bx);                                  /* pop bx */
            ii(0x8c74, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x8c76, 2);    if(jz(0x8cc8, 0x50)) goto l_0x8cc8;       /* jz 0x8cc8 */
            ii(0x8c78, 2);    push(0x2);                                /* push 0x2 */
            ii(0x8c7a, 3);    lea(ax, bp - 0xc);                        /* lea ax, [bp-0xc] */
            ii(0x8c7d, 1);    push(ax);                                 /* push ax */
            ii(0x8c7e, 2);    push(0x10);                               /* push 0x10 */
            ii(0x8c80, 2);    push(0x1e);                               /* push 0x1e */
            ii(0x8c82, 3);    call(0x4f8d, -0x3cf8);                    /* call 0x4f8d */
            ii(0x8c85, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x8c88, 3);    push(memw[ss, bp - 0xc]);                 /* push word [bp-0xc] */
            ii(0x8c8b, 3);    call(0xa4ec, 0x185e);                     /* call 0xa4ec */
            ii(0x8c8e, 1);    pop(bx);                                  /* pop bx */
            ii(0x8c8f, 3);    mov(memw[ss, bp - 0xc], ax);              /* mov [bp-0xc], ax */
            ii(0x8c92, 3);    mov(memw[ss, bp - 0xa], dx);              /* mov [bp-0xa], dx */
            ii(0x8c95, 3);    mov(ax, memw[ds, 0x98]);                  /* mov ax, [0x98] */
            ii(0x8c98, 4);    mov(dx, memw[ds, 0x9a]);                  /* mov dx, [0x9a] */
            ii(0x8c9c, 3);    cmp(memw[ss, bp - 0xa], dx);              /* cmp [bp-0xa], dx */
            ii(0x8c9f, 2);    if(jb(0x8cc8, 0x27)) goto l_0x8cc8;       /* jb 0x8cc8 */
            ii(0x8ca1, 2);    if(ja(0x8ca8, 0x5)) goto l_0x8ca8;        /* ja 0x8ca8 */
            ii(0x8ca3, 3);    cmp(memw[ss, bp - 0xc], ax);              /* cmp [bp-0xc], ax */
            ii(0x8ca6, 2);    if(jbe(0x8cc8, 0x20)) goto l_0x8cc8;      /* jbe 0x8cc8 */
        l_0x8ca8:
            ii(0x8ca8, 3);    mov(ax, memw[ds, 0x9c]);                  /* mov ax, [0x9c] */
            ii(0x8cab, 4);    mov(dx, memw[ds, 0x9e]);                  /* mov dx, [0x9e] */
            ii(0x8caf, 3);    cmp(memw[ss, bp - 0xa], dx);              /* cmp [bp-0xa], dx */
            ii(0x8cb2, 2);    if(ja(0x8cc8, 0x14)) goto l_0x8cc8;       /* ja 0x8cc8 */
            ii(0x8cb4, 2);    if(jb(0x8cbb, 0x5)) goto l_0x8cbb;        /* jb 0x8cbb */
            ii(0x8cb6, 3);    cmp(memw[ss, bp - 0xc], ax);              /* cmp [bp-0xc], ax */
            ii(0x8cb9, 2);    if(jae(0x8cc8, 0xd)) goto l_0x8cc8;       /* jae 0x8cc8 */
        l_0x8cbb:
            ii(0x8cbb, 3);    mov(ax, memw[ss, bp - 0xc]);              /* mov ax, [bp-0xc] */
            ii(0x8cbe, 3);    mov(dx, memw[ss, bp - 0xa]);              /* mov dx, [bp-0xa] */
            ii(0x8cc1, 3);    mov(memw[ds, 0x98], ax);                  /* mov [0x98], ax */
            ii(0x8cc4, 4);    mov(memw[ds, 0x9a], dx);                  /* mov [0x9a], dx */
        l_0x8cc8:
            ii(0x8cc8, 1);    leave();                                  /* leave */
            ii(0x8cc9, 1);    ret();                                    /* ret */
        }
    }
}
