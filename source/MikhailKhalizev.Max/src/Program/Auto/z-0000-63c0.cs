using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x63c0-a41b77d2")]
        public void Method_0000_63c0()
        {
            ii(0x63c0, 1);    push(bp);                                 /* push bp */
            ii(0x63c1, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x63c3, 2);    mov(dx, di);                              /* mov dx, di */
            ii(0x63c5, 2);    mov(ax, ds);                              /* mov ax, ds */
            ii(0x63c7, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x63c9, 3);    mov(di, memw[ss, bp + 0x4]);              /* mov di, [bp+0x4] */
            ii(0x63cc, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x63ce, 3);    mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x63d1, 2);    repne(() => scasb());                     /* repne scasb */
            ii(0x63d3, 2);    not(cx);                                  /* not cx */
            ii(0x63d5, 1);    dec(cx);                                  /* dec cx */
            ii(0x63d6, 1);    xchg(cx, ax);                             /* xchg cx, ax */
            ii(0x63d7, 2);    mov(di, dx);                              /* mov di, dx */
            ii(0x63d9, 1);    pop(bp);                                  /* pop bp */
            ii(0x63da, 1);    ret();                                    /* ret */
        }
    }
}
