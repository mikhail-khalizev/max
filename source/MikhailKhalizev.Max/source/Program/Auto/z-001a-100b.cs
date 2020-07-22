using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_100b-e7ef1ef")]
        public void Method_001a_100b()
        {
            ii(0x1a_100b, 4);  enter(0, 0);                            /* enter 0x0, 0x0 */
            ii(0x1a_100f, 5);  movzx(eax, memw[ss, bp + 6]);           /* movzx eax, word [bp+0x6] */
            ii(0x1a_1014, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x1a_1016, 2);  if(jz(0x1a_1020, 8)) goto l_0x1a_1020;  /* jz 0x1020 */
            ii(0x1a_1018, 2);  xchg(bx, bx);                           /* xchg bx, bx */
            ii(0x1a_101a, 4);  lar(eax, ax);                           /* lar eax, ax */
            ii(0x1a_101e, 2);  jmp(0x1a_1020, 0); goto l_0x1a_1020;    /* jmp 0x1020 */
        l_0x1a_1020:
            ii(0x1a_1020, 3);  mov(edx, eax);                          /* mov edx, eax */
            ii(0x1a_1023, 4);  shr(edx, 0x10);                         /* shr edx, 0x10 */
            ii(0x1a_1027, 1);  leave();                                /* leave */
            ii(0x1a_1028, 1);  retf();                                 /* retf */
        }
    }
}
