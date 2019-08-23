using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_f01e-f48d290d")]
        public void Method_0019_f01e()
        {
            ii(0x19_f01e, 4); enter(0, 0);                              /* enter 0x0, 0x0 */
            ii(0x19_f022, 1); push(di);                                 /* push di */
            ii(0x19_f023, 1); push(si);                                 /* push si */
            ii(0x19_f024, 2); push(0x6c);                               /* push 0x6c */
            ii(0x19_f026, 2); push(0);                                  /* push 0x0 */
            ii(0x19_f028, 1); push(ds);                                 /* push ds */
            ii(0x19_f029, 3); push(0x2e3c);                             /* push 0x2e3c */
            ii(0x19_f02c, 5); call_far_abs(0x80, 0x408a);               /* call word 0x80:0x408a */
            ii(0x19_f031, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_f034, 1); pop(si);                                  /* pop si */
            ii(0x19_f035, 1); pop(di);                                  /* pop di */
            ii(0x19_f036, 1); leave();                                  /* leave */
            ii(0x19_f037, 1); retf();                                   /* retf */
        }
    }
}
