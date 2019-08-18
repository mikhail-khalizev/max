using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a9ad7d5e-ed16-4464-aef2-5eb7cfb7ede8")]
        public void Method_0000_8594()
        {
            ii(0x8594, 3);    mov(memb_a16[ds, 0xcf0], al);             /* mov [0xcf0], al */
            ii(0x8597, 2);    or(ah, ah);                               /* or ah, ah */
            ii(0x8599, 2);    if(jnzw(0x85bd, 0x22)) goto l_0x85bd;     /* jnz 0x85bd */
            ii(0x859b, 5);    cmp(memb_a16[ds, 0xcee], 0x3);            /* cmp byte [0xcee], 0x3 */
            ii(0x85a0, 2);    if(jbw(0x85ae, 0xc)) goto l_0x85ae;       /* jb 0x85ae */
            ii(0x85a2, 2);    cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x85a4, 2);    if(jaew(0x85b2, 0xc)) goto l_0x85b2;      /* jae 0x85b2 */
            ii(0x85a6, 2);    cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x85a8, 2);    if(jbw(0x85ae, 0x4)) goto l_0x85ae;       /* jb 0x85ae */
            ii(0x85aa, 2);    mov(al, 0x5);                             /* mov al, 0x5 */
            ii(0x85ac, 2);    jmpw(0x85b4, 0x6); goto l_0x85b4;         /* jmp 0x85b4 */
        l_0x85ae:
            ii(0x85ae, 2);    cmp(al, 0x13);                            /* cmp al, 0x13 */
            ii(0x85b0, 2);    if(jbew(0x85b4, 0x2)) goto l_0x85b4;      /* jbe 0x85b4 */
        l_0x85b2:
            ii(0x85b2, 2);    mov(al, 0x13);                            /* mov al, 0x13 */
        l_0x85b4:
            ii(0x85b4, 3);    mov(bx, 0xd12);                           /* mov bx, 0xd12 */
            ii(0x85b7, 1);    xlatb_a16();                              /* xlatb */
        l_0x85b8:
            ii(0x85b8, 1);    cbw();                                    /* cbw */
            ii(0x85b9, 3);    mov(memw_a16[ds, 0xce8], ax);             /* mov [0xce8], ax */
            ii(0x85bc, 1);    retw(); return;                           /* ret */
        l_0x85bd:
            ii(0x85bd, 2);    mov(al, ah);                              /* mov al, ah */
            ii(0x85bf, 2);    jmpw(0x85b8, -0x9); goto l_0x85b8;        /* jmp 0x85b8 */
        }
    }
}
