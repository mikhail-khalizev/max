using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4370-8a8ddfb4")]
        public void Method_0000_4370()
        {
            ii(0x4370, 1);    push(bp);                                 /* push bp */
            ii(0x4371, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x4373, 2);    mov(cx, ds);                              /* mov cx, ds */
            ii(0x4375, 3);    mov(ax, 8);                               /* mov ax, 0x8 */
            ii(0x4378, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x437a, 3);    mov(bx, memw[ss, bp + 4]);                /* mov bx, [bp+0x4] */
            ii(0x437d, 3);    call(0x4352, -0x2e);                      /* call 0x4352 */
            ii(0x4380, 2);    if(jnz(0x439c, 0x1a)) goto l_0x439c;      /* jnz 0x439c */
            ii(0x4382, 1);    xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x4383, 2);    mov(bx, cx);                              /* mov bx, cx */
            ii(0x4385, 3);    call(0x4352, -0x36);                      /* call 0x4352 */
            ii(0x4388, 1);    push(bx);                                 /* push bx */
            ii(0x4389, 2);    mov(bx, ss);                              /* mov bx, ss */
            ii(0x438b, 3);    call(0x4352, -0x3c);                      /* call 0x4352 */
            ii(0x438e, 2);    if(jnz(0x439c, 0xc)) goto l_0x439c;       /* jnz 0x439c */
            ii(0x4390, 3);    xchg(memw[ss, bp + 4], ax);               /* xchg [bp+0x4], ax */
            ii(0x4393, 2);    push(0x20);                               /* push 0x20 */
            ii(0x4395, 1);    pop(ds);                                  /* pop ds */
            ii(0x4396, 3);    call(0x3f21, -0x478);                     /* call 0x3f21 */
            ii(0x4399, 1);    pop(ds);                                  /* pop ds */
            ii(0x439a, 1);    pop(bp);                                  /* pop bp */
            ii(0x439b, 1);    retf(); return;                           /* retf */
        l_0x439c:
            ii(0x439c, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x439e, 2);    mov(ds, cx);                              /* mov ds, cx */
            ii(0x43a0, 1);    leave();                                  /* leave */
            ii(0x43a1, 1);    retf();                                   /* retf */
        }
    }
}
