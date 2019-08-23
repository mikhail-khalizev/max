using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x53e7-13c80901")]
        public void Method_0000_53e7()
        {
            ii(0x53e7, 3);    mov(bx, 0x10);                            /* mov bx, 0x10 */
        l_0x53ea:
            ii(0x53ea, 1);    dec(bx);                                  /* dec bx */
            ii(0x53eb, 1);    dec(bx);                                  /* dec bx */
            ii(0x53ec, 2);    if(js(0x540c, 0x1e)) goto l_0x540c;       /* js 0x540c */
            ii(0x53ee, 4);    mov(dx, memw[ds, bx + 0xadc]);            /* mov dx, [bx+0xadc] */
            ii(0x53f2, 2);    or(dx, dx);                               /* or dx, dx */
            ii(0x53f4, 2);    if(jz(0x53ea, -0xc)) goto l_0x53ea;       /* jz 0x53ea */
            ii(0x53f6, 1);    push(bx);                                 /* push bx */
            ii(0x53f7, 2);    mov(ah, 0xd);                             /* mov ah, 0xd */
            ii(0x53f9, 4);    call_far_ind(ds, 0xaec);                  /* call far word [0xaec] */
            ii(0x53fd, 2);    mov(ah, 0xa);                             /* mov ah, 0xa */
            ii(0x53ff, 4);    call_far_ind(ds, 0xaec);                  /* call far word [0xaec] */
            ii(0x5403, 1);    pop(bx);                                  /* pop bx */
            ii(0x5404, 6);    mov(memw[ds, bx + 0xadc], 0);             /* mov word [bx+0xadc], 0x0 */
            ii(0x540a, 2);    jmp(0x53ea, -0x22); goto l_0x53ea;        /* jmp 0x53ea */
        l_0x540c:
            ii(0x540c, 1);    ret();                                    /* ret */
        }
    }
}
