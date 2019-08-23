using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6584-fdc856c0")]
        public void Method_0000_6584()
        {
            ii(0x6584, 3);    mov(memb[ds, 0xcf0], al);                 /* mov [0xcf0], al */
            ii(0x6587, 2);    or(ah, ah);                               /* or ah, ah */
            ii(0x6589, 2);    if(jnz(0x65ad, 0x22)) goto l_0x65ad;      /* jnz 0x65ad */
            ii(0x658b, 5);    cmp(memb[ds, 0xcee], 0x3);                /* cmp byte [0xcee], 0x3 */
            ii(0x6590, 2);    if(jb(0x659e, 0xc)) goto l_0x659e;        /* jb 0x659e */
            ii(0x6592, 2);    cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x6594, 2);    if(jae(0x65a2, 0xc)) goto l_0x65a2;       /* jae 0x65a2 */
            ii(0x6596, 2);    cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x6598, 2);    if(jb(0x659e, 0x4)) goto l_0x659e;        /* jb 0x659e */
            ii(0x659a, 2);    mov(al, 0x5);                             /* mov al, 0x5 */
            ii(0x659c, 2);    jmp(0x65a4, 0x6); goto l_0x65a4;          /* jmp 0x65a4 */
        l_0x659e:
            ii(0x659e, 2);    cmp(al, 0x13);                            /* cmp al, 0x13 */
            ii(0x65a0, 2);    if(jbe(0x65a4, 0x2)) goto l_0x65a4;       /* jbe 0x65a4 */
        l_0x65a2:
            ii(0x65a2, 2);    mov(al, 0x13);                            /* mov al, 0x13 */
        l_0x65a4:
            ii(0x65a4, 3);    mov(bx, 0xd12);                           /* mov bx, 0xd12 */
            ii(0x65a7, 1);    xlatb();                                  /* xlatb */
        l_0x65a8:
            ii(0x65a8, 1);    cbw();                                    /* cbw */
            ii(0x65a9, 3);    mov(memw[ds, 0xce8], ax);                 /* mov [0xce8], ax */
            ii(0x65ac, 1);    ret(); return;                            /* ret */
        l_0x65ad:
            ii(0x65ad, 2);    mov(al, ah);                              /* mov al, ah */
            ii(0x65af, 2);    jmp(0x65a8, -0x9); goto l_0x65a8;         /* jmp 0x65a8 */
        }
    }
}
