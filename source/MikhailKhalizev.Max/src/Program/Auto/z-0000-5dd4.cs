using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5dd4-fdc856c0")]
        public void Method_0000_5dd4()
        {
            ii(0x5dd4, 3);    mov(memb[ds, 0xcf0], al);                 /* mov [0xcf0], al */
            ii(0x5dd7, 2);    or(ah, ah);                               /* or ah, ah */
            ii(0x5dd9, 2);    if(jnz(0x5dfd, 0x22)) goto l_0x5dfd;      /* jnz 0x5dfd */
            ii(0x5ddb, 5);    cmp(memb[ds, 0xcee], 3);                  /* cmp byte [0xcee], 0x3 */
            ii(0x5de0, 2);    if(jb(0x5dee, 0xc)) goto l_0x5dee;        /* jb 0x5dee */
            ii(0x5de2, 2);    cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x5de4, 2);    if(jae(0x5df2, 0xc)) goto l_0x5df2;       /* jae 0x5df2 */
            ii(0x5de6, 2);    cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x5de8, 2);    if(jb(0x5dee, 4)) goto l_0x5dee;          /* jb 0x5dee */
            ii(0x5dea, 2);    mov(al, 5);                               /* mov al, 0x5 */
            ii(0x5dec, 2);    jmp(0x5df4, 6); goto l_0x5df4;            /* jmp 0x5df4 */
        l_0x5dee:
            ii(0x5dee, 2);    cmp(al, 0x13);                            /* cmp al, 0x13 */
            ii(0x5df0, 2);    if(jbe(0x5df4, 2)) goto l_0x5df4;         /* jbe 0x5df4 */
        l_0x5df2:
            ii(0x5df2, 2);    mov(al, 0x13);                            /* mov al, 0x13 */
        l_0x5df4:
            ii(0x5df4, 3);    mov(bx, 0xd12);                           /* mov bx, 0xd12 */
            ii(0x5df7, 1);    xlatb();                                  /* xlatb */
        l_0x5df8:
            ii(0x5df8, 1);    cbw();                                    /* cbw */
            ii(0x5df9, 3);    mov(memw[ds, 0xce8], ax);                 /* mov [0xce8], ax */
            ii(0x5dfc, 1);    ret(); return;                            /* ret */
        l_0x5dfd:
            ii(0x5dfd, 2);    mov(al, ah);                              /* mov al, ah */
            ii(0x5dff, 2);    jmp(0x5df8, -9); goto l_0x5df8;           /* jmp 0x5df8 */
        }
    }
}
