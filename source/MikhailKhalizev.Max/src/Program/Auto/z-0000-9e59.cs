using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9e59-9b52587e")]
        public void Method_0000_9e59()
        {
            ii(0x9e59, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x9e5b, 3);    mov(dx, memw[ds, bx + 4]);                /* mov dx, [bx+0x4] */
            ii(0x9e5e, 3);    mov(bx, memw[ds, bx + 2]);                /* mov bx, [bx+0x2] */
            ii(0x9e61, 1);    push(si);                                 /* push si */
            ii(0x9e62, 1);    push(di);                                 /* push di */
            ii(0x9e63, 1);    push(cs);                                 /* push cs */
            ii(0x9e64, 1);    pop(ds);                                  /* pop ds */
            ii(0x9e65, 3);    mov(cx, 0x2c);                            /* mov cx, 0x2c */
            ii(0x9e68, 3);    mov(si, 0x6761);                          /* mov si, 0x6761 */
            ii(0x9e6b, 2);    jmp(0x9e6d, 0); goto l_0x9e6d;            /* jmp 0x9e6d */
        l_0x9e6d:
            ii(0x9e6d, 1);    lodsw();                                  /* lodsw */
            ii(0x9e6e, 1);    xchg(di, ax);                             /* xchg di, ax */
            ii(0x9e6f, 1);    lodsw();                                  /* lodsw */
            ii(0x9e70, 2);    cmp(ax, dx);                              /* cmp ax, dx */
            ii(0x9e72, 1);    lodsb();                                  /* lodsb */
            ii(0x9e73, 2);    if(jnz(0x9e79, 4)) goto l_0x9e79;         /* jnz 0x9e79 */
            ii(0x9e75, 2);    cmp(di, bx);                              /* cmp di, bx */
            ii(0x9e77, 2);    if(jz(0x9e81, 8)) goto l_0x9e81;          /* jz 0x9e81 */
        l_0x9e79:
            ii(0x9e79, 2);    if(loop(0x9e6d, -0xe)) goto l_0x9e6d;     /* loop 0x9e6d */
            ii(0x9e7b, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x9e7d, 2);    xor(dx, dx);                              /* xor dx, dx */
            ii(0x9e7f, 2);    jmp(0x9e89, 8); goto l_0x9e89;            /* jmp 0x9e89 */
        l_0x9e81:
            ii(0x9e81, 2);    xor(ah, ah);                              /* xor ah, ah */
            ii(0x9e83, 2);    mov(dx, ax);                              /* mov dx, ax */
            ii(0x9e85, 1);    lodsb();                                  /* lodsb */
            ii(0x9e86, 3);    shl(ax, 4);                               /* shl ax, 0x4 */
        l_0x9e89:
            ii(0x9e89, 1);    push(ss);                                 /* push ss */
            ii(0x9e8a, 1);    pop(ds);                                  /* pop ds */
            ii(0x9e8b, 1);    pop(di);                                  /* pop di */
            ii(0x9e8c, 1);    pop(si);                                  /* pop si */
            ii(0x9e8d, 1);    ret();                                    /* ret */
        }
    }
}
