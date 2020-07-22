using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6b30-8a8ddfb4")]
        public void Method_0000_6b30()
        {
            ii(0x6b30, 1);  push(bp);                                  /* push bp */
            ii(0x6b31, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x6b33, 2);  mov(cx, ds);                               /* mov cx, ds */
            ii(0x6b35, 3);  mov(ax, 8);                                /* mov ax, 0x8 */
            ii(0x6b38, 2);  mov(ds, ax);                               /* mov ds, ax */
            ii(0x6b3a, 3);  mov(bx, memw[ss, bp + 4]);                 /* mov bx, [bp+0x4] */
            ii(0x6b3d, 3);  call(0x6b12, -0x2e);                       /* call 0x6b12 */
            ii(0x6b40, 2);  if(jnz(0x6b5c, 0x1a)) goto l_0x6b5c;       /* jnz 0x6b5c */
            ii(0x6b42, 1);  xchg(bx, ax);                              /* xchg bx, ax */
            ii(0x6b43, 2);  mov(bx, cx);                               /* mov bx, cx */
            ii(0x6b45, 3);  call(0x6b12, -0x36);                       /* call 0x6b12 */
            ii(0x6b48, 1);  push(bx);                                  /* push bx */
            ii(0x6b49, 2);  mov(bx, ss);                               /* mov bx, ss */
            ii(0x6b4b, 3);  call(0x6b12, -0x3c);                       /* call 0x6b12 */
            ii(0x6b4e, 2);  if(jnz(0x6b5c, 0xc)) goto l_0x6b5c;        /* jnz 0x6b5c */
            ii(0x6b50, 3);  xchg(memw[ss, bp + 4], ax);                /* xchg [bp+0x4], ax */
            ii(0x6b53, 2);  push(0x20);                                /* push 0x20 */
            ii(0x6b55, 1);  pop(ds);                                   /* pop ds */
            ii(0x6b56, 3);  call(0x66e1, -0x478);                      /* call 0x66e1 */
            ii(0x6b59, 1);  pop(ds);                                   /* pop ds */
            ii(0x6b5a, 1);  pop(bp);                                   /* pop bp */
            ii(0x6b5b, 1);  retf(); return;                            /* retf */
        l_0x6b5c:
            ii(0x6b5c, 2);  xor(ax, ax);                               /* xor ax, ax */
            ii(0x6b5e, 2);  mov(ds, cx);                               /* mov ds, cx */
            ii(0x6b60, 1);  leave();                                   /* leave */
            ii(0x6b61, 1);  retf();                                    /* retf */
        }
    }
}
