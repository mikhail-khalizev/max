using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3f9674ff-989f-463f-8ae6-7c21e338660e")]
        public void Method_0015_f01e()
        {
            ii(0x15_f01e, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x15_f022, 1); pushw(di);                                /* push di */
            ii(0x15_f023, 1); pushw(si);                                /* push si */
            ii(0x15_f024, 2); pushw(0x6c);                              /* push 0x6c */
            ii(0x15_f026, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_f028, 1); pushw(ds);                                /* push ds */
            ii(0x15_f029, 3); pushw(0x2e3c);                            /* push 0x2e3c */
            ii(0x15_f02c, 5); callw_far_abs(0x80, 0x408a);              /* call word 0x80:0x408a */
            ii(0x15_f031, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_f034, 1); popw(si);                                 /* pop si */
            ii(0x15_f035, 1); popw(di);                                 /* pop di */
            ii(0x15_f036, 1); leavew();                                 /* leave */
            ii(0x15_f037, 1); retfw(); return;                          /* retf */
        }
    }
}
