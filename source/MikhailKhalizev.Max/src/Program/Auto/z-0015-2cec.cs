using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2d44744a-7b7c-4c1a-bde7-8c5179220107")]
        public void Method_0015_2cec()
        {
            ii(0x15_2cec, 3); mov(memb_a16[ds, 0x3c1d], al);            /* mov [0x3c1d], al */
            ii(0x15_2cef, 2); or(ah, ah);                               /* or ah, ah */
            ii(0x15_2cf1, 2); if(jnzw(0x15_2d15, 0x22)) goto l_0x15_2d15; /* jnz 0x2d15 */
            ii(0x15_2cf3, 5); cmp(memb_a16[ds, 0x3c1a], 0x3);           /* cmp byte [0x3c1a], 0x3 */
            ii(0x15_2cf8, 2); if(jbw(0x15_2d06, 0xc)) goto l_0x15_2d06; /* jb 0x2d06 */
            ii(0x15_2cfa, 2); cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x15_2cfc, 2); if(jaew(0x15_2d0a, 0xc)) goto l_0x15_2d0a; /* jae 0x2d0a */
            ii(0x15_2cfe, 2); cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x15_2d00, 2); if(jbw(0x15_2d06, 0x4)) goto l_0x15_2d06; /* jb 0x2d06 */
            ii(0x15_2d02, 2); mov(al, 0x5);                             /* mov al, 0x5 */
            ii(0x15_2d04, 2); jmpw(0x15_2d0c, 0x6); goto l_0x15_2d0c;   /* jmp 0x2d0c */
        l_0x15_2d06:
            ii(0x15_2d06, 2); cmp(al, 0x13);                            /* cmp al, 0x13 */
            ii(0x15_2d08, 2); if(jbew(0x15_2d0c, 0x2)) goto l_0x15_2d0c; /* jbe 0x2d0c */
        l_0x15_2d0a:
            ii(0x15_2d0a, 2); mov(al, 0x13);                            /* mov al, 0x13 */
        l_0x15_2d0c:
            ii(0x15_2d0c, 3); mov(bx, 0x3c54);                          /* mov bx, 0x3c54 */
            ii(0x15_2d0f, 1); xlatb_a16();                              /* xlatb */
        l_0x15_2d10:
            ii(0x15_2d10, 1); cbw();                                    /* cbw */
            ii(0x15_2d11, 3); mov(memw_a16[ds, 0x3c12], ax);            /* mov [0x3c12], ax */
            ii(0x15_2d14, 1); retw(); return;                           /* ret */
        l_0x15_2d15:
            ii(0x15_2d15, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x15_2d17, 2); jmpw(0x15_2d10, -0x9); goto l_0x15_2d10;  /* jmp 0x2d10 */
        }
    }
}
