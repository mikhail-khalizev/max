using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c80ff4ae-70ae-434d-9250-76464aa39500")]
        public void Method_0013_d8ce()
        {
            ii(0x13_d8ce, 3); mov(memb_a16[ds, 0x1c59], al);            /* mov [0x1c59], al */
            ii(0x13_d8d1, 2); or(ah, ah);                               /* or ah, ah */
            ii(0x13_d8d3, 2); if(jnzw(0x13_d8f7, 0x22)) goto l_0x13_d8f7; /* jnz 0xd8f7 */
            ii(0x13_d8d5, 5); cmp(memb_a16[ds, 0x1c56], 0x3);           /* cmp byte [0x1c56], 0x3 */
            ii(0x13_d8da, 2); if(jbw(0x13_d8e8, 0xc)) goto l_0x13_d8e8; /* jb 0xd8e8 */
            ii(0x13_d8dc, 2); cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x13_d8de, 2); if(jaew(0x13_d8ec, 0xc)) goto l_0x13_d8ec; /* jae 0xd8ec */
            ii(0x13_d8e0, 2); cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x13_d8e2, 2); if(jbw(0x13_d8e8, 0x4)) goto l_0x13_d8e8; /* jb 0xd8e8 */
            ii(0x13_d8e4, 2); mov(al, 0x5);                             /* mov al, 0x5 */
            ii(0x13_d8e6, 2); jmpw(0x13_d8ee, 0x6); goto l_0x13_d8ee;   /* jmp 0xd8ee */
        l_0x13_d8e8:
            ii(0x13_d8e8, 2); cmp(al, 0x13);                            /* cmp al, 0x13 */
            ii(0x13_d8ea, 2); if(jbew(0x13_d8ee, 0x2)) goto l_0x13_d8ee; /* jbe 0xd8ee */
        l_0x13_d8ec:
            ii(0x13_d8ec, 2); mov(al, 0x13);                            /* mov al, 0x13 */
        l_0x13_d8ee:
            ii(0x13_d8ee, 3); mov(bx, 0x1c8c);                          /* mov bx, 0x1c8c */
            ii(0x13_d8f1, 1); xlatb_a16();                              /* xlatb */
        l_0x13_d8f2:
            ii(0x13_d8f2, 1); cbw();                                    /* cbw */
            ii(0x13_d8f3, 3); mov(memw_a16[ds, 0x1c4e], ax);            /* mov [0x1c4e], ax */
            ii(0x13_d8f6, 1); retw(); return;                           /* ret */
        l_0x13_d8f7:
            ii(0x13_d8f7, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_d8f9, 2); jmpw(0x13_d8f2, -0x9); goto l_0x13_d8f2;  /* jmp 0xd8f2 */
        }
    }
}
