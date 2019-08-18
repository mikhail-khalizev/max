using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6b628257-a57d-4b44-a71f-2253980f1084")]
        public void Method_0000_5b97()
        {
            ii(0x5b97, 3);    mov(bx, 0x10);                            /* mov bx, 0x10 */
        l_0x5b9a:
            ii(0x5b9a, 1);    dec(bx);                                  /* dec bx */
            ii(0x5b9b, 1);    dec(bx);                                  /* dec bx */
            ii(0x5b9c, 2);    if(jsw(0x5bbc, 0x1e)) goto l_0x5bbc;      /* js 0x5bbc */
            ii(0x5b9e, 4);    mov(dx, memw_a16[ds, bx + 0xadc]);        /* mov dx, [bx+0xadc] */
            ii(0x5ba2, 2);    or(dx, dx);                               /* or dx, dx */
            ii(0x5ba4, 2);    if(jzw(0x5b9a, -0xc)) goto l_0x5b9a;      /* jz 0x5b9a */
            ii(0x5ba6, 1);    pushw(bx);                                /* push bx */
            ii(0x5ba7, 2);    mov(ah, 0xd);                             /* mov ah, 0xd */
            ii(0x5ba9, 4);    callw_a16_far_ind(ds, 0xaec);             /* call far word [0xaec] */
            ii(0x5bad, 2);    mov(ah, 0xa);                             /* mov ah, 0xa */
            ii(0x5baf, 4);    callw_a16_far_ind(ds, 0xaec);             /* call far word [0xaec] */
            ii(0x5bb3, 1);    popw(bx);                                 /* pop bx */
            ii(0x5bb4, 6);    mov(memw_a16[ds, bx + 0xadc], 0);         /* mov word [bx+0xadc], 0x0 */
            ii(0x5bba, 2);    jmpw(0x5b9a, -0x22); goto l_0x5b9a;       /* jmp 0x5b9a */
        l_0x5bbc:
            ii(0x5bbc, 1);    retw(); return;                           /* ret */
        }
    }
}
