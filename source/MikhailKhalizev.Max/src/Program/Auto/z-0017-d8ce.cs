using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_d8ce-57e40608")]
        public void Method_0017_d8ce()
        {
            ii(0x17_d8ce, 3); mov(memb[ds, 0x1c59], al);                /* mov [0x1c59], al */
            ii(0x17_d8d1, 2); or(ah, ah);                               /* or ah, ah */
            ii(0x17_d8d3, 2); if(jnz(0x17_d8f7, 0x22)) goto l_0x17_d8f7; /* jnz 0xd8f7 */
            ii(0x17_d8d5, 5); cmp(memb[ds, 0x1c56], 3);                 /* cmp byte [0x1c56], 0x3 */
            ii(0x17_d8da, 2); if(jb(0x17_d8e8, 0xc)) goto l_0x17_d8e8;  /* jb 0xd8e8 */
            ii(0x17_d8dc, 2); cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x17_d8de, 2); if(jae(0x17_d8ec, 0xc)) goto l_0x17_d8ec; /* jae 0xd8ec */
            ii(0x17_d8e0, 2); cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x17_d8e2, 2); if(jb(0x17_d8e8, 4)) goto l_0x17_d8e8;    /* jb 0xd8e8 */
            ii(0x17_d8e4, 2); mov(al, 5);                               /* mov al, 0x5 */
            ii(0x17_d8e6, 2); jmp(0x17_d8ee, 6); goto l_0x17_d8ee;      /* jmp 0xd8ee */
        l_0x17_d8e8:
            ii(0x17_d8e8, 2); cmp(al, 0x13);                            /* cmp al, 0x13 */
            ii(0x17_d8ea, 2); if(jbe(0x17_d8ee, 2)) goto l_0x17_d8ee;   /* jbe 0xd8ee */
        l_0x17_d8ec:
            ii(0x17_d8ec, 2); mov(al, 0x13);                            /* mov al, 0x13 */
        l_0x17_d8ee:
            ii(0x17_d8ee, 3); mov(bx, 0x1c8c);                          /* mov bx, 0x1c8c */
            ii(0x17_d8f1, 1); xlatb();                                  /* xlatb */
        l_0x17_d8f2:
            ii(0x17_d8f2, 1); cbw();                                    /* cbw */
            ii(0x17_d8f3, 3); mov(memw[ds, 0x1c4e], ax);                /* mov [0x1c4e], ax */
            ii(0x17_d8f6, 1); ret(); return;                            /* ret */
        l_0x17_d8f7:
            ii(0x17_d8f7, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_d8f9, 2); jmp(0x17_d8f2, -9); goto l_0x17_d8f2;     /* jmp 0xd8f2 */
        }
    }
}
