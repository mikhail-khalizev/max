using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_1029-3bdc515c")]
        public void Method_001a_1029()
        {
            ii(0x1a_1029, 4); enter(0, 0);                              /* enter 0x0, 0x0 */
            ii(0x1a_102d, 5); movzx(eax, memw[ss, bp + 0x6]);           /* movzx eax, word [bp+0x6] */
            ii(0x1a_1032, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x1a_1034, 2); if(jz(0x1a_103c, 0x6)) goto l_0x1a_103c;  /* jz 0x103c */
            ii(0x1a_1036, 4); lsl(eax, ax);                             /* lsl eax, ax */
            ii(0x1a_103a, 2); jmp(0x1a_103c, 0); goto l_0x1a_103c;      /* jmp 0x103c */
        l_0x1a_103c:
            ii(0x1a_103c, 3); mov(edx, eax);                            /* mov edx, eax */
            ii(0x1a_103f, 4); shr(edx, 0x10);                           /* shr edx, 0x10 */
            ii(0x1a_1043, 1); leave();                                  /* leave */
            ii(0x1a_1044, 1); retf();                                   /* retf */
        }
    }
}
