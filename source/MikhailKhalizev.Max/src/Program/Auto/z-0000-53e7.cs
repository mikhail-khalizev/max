using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4cd11424-2b20-4d33-9469-571370100abb")]
        public void Method_0000_53e7()
        {
            ii(0x53e7, 3);    mov(bx, 0x10);                            /* mov bx, 0x10 */
        l_0x53ea:
            ii(0x53ea, 1);    dec(bx);                                  /* dec bx */
            ii(0x53eb, 1);    dec(bx);                                  /* dec bx */
            ii(0x53ec, 2);    if(jsw(0x540c, 0x1e)) goto l_0x540c;      /* js 0x540c */
            ii(0x53ee, 4);    mov(dx, memw_a16[ds, bx + 0xadc]);        /* mov dx, [bx+0xadc] */
            ii(0x53f2, 2);    or(dx, dx);                               /* or dx, dx */
            ii(0x53f4, 2);    if(jzw(0x53ea, -0xc)) goto l_0x53ea;      /* jz 0x53ea */
            ii(0x53f6, 1);    pushw(bx);                                /* push bx */
            ii(0x53f7, 2);    mov(ah, 0xd);                             /* mov ah, 0xd */
            ii(0x53f9, 4);    callw_a16_far_ind(ds, 0xaec);             /* call far word [0xaec] */
            ii(0x53fd, 2);    mov(ah, 0xa);                             /* mov ah, 0xa */
            ii(0x53ff, 4);    callw_a16_far_ind(ds, 0xaec);             /* call far word [0xaec] */
            ii(0x5403, 1);    popw(bx);                                 /* pop bx */
            ii(0x5404, 6);    mov(memw_a16[ds, bx + 0xadc], 0);         /* mov word [bx+0xadc], 0x0 */
            ii(0x540a, 2);    jmpw(0x53ea, -0x22); goto l_0x53ea;       /* jmp 0x53ea */
        l_0x540c:
            ii(0x540c, 1);    retw(); return;                           /* ret */
        }
    }
}
