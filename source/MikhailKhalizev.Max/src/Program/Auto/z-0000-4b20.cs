using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4b20-8a8ddfb4")]
        public void Method_0000_4b20()
        {
            ii(0x4b20, 1);    push(bp);                                 /* push bp */
            ii(0x4b21, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x4b23, 2);    mov(cx, ds);                              /* mov cx, ds */
            ii(0x4b25, 3);    mov(ax, 8);                               /* mov ax, 0x8 */
            ii(0x4b28, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x4b2a, 3);    mov(bx, memw[ss, bp + 4]);                /* mov bx, [bp+0x4] */
            ii(0x4b2d, 3);    call(0x4b02, -0x2e);                      /* call 0x4b02 */
            ii(0x4b30, 2);    if(jnz(0x4b4c, 0x1a)) goto l_0x4b4c;      /* jnz 0x4b4c */
            ii(0x4b32, 1);    xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x4b33, 2);    mov(bx, cx);                              /* mov bx, cx */
            ii(0x4b35, 3);    call(0x4b02, -0x36);                      /* call 0x4b02 */
            ii(0x4b38, 1);    push(bx);                                 /* push bx */
            ii(0x4b39, 2);    mov(bx, ss);                              /* mov bx, ss */
            ii(0x4b3b, 3);    call(0x4b02, -0x3c);                      /* call 0x4b02 */
            ii(0x4b3e, 2);    if(jnz(0x4b4c, 0xc)) goto l_0x4b4c;       /* jnz 0x4b4c */
            ii(0x4b40, 3);    xchg(memw[ss, bp + 4], ax);               /* xchg [bp+0x4], ax */
            ii(0x4b43, 2);    push(0x20);                               /* push 0x20 */
            ii(0x4b45, 1);    pop(ds);                                  /* pop ds */
            ii(0x4b46, 3);    call(0x46d1, -0x478);                     /* call 0x46d1 */
            ii(0x4b49, 1);    pop(ds);                                  /* pop ds */
            ii(0x4b4a, 1);    pop(bp);                                  /* pop bp */
            ii(0x4b4b, 1);    retf(); return;                           /* retf */
        l_0x4b4c:
            ii(0x4b4c, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x4b4e, 2);    mov(ds, cx);                              /* mov ds, cx */
            ii(0x4b50, 1);    leave();                                  /* leave */
            ii(0x4b51, 1);    retf();                                   /* retf */
        }
    }
}
