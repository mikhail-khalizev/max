using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c47600b2-afd6-47af-89f7-d20cd12c1b99")]
        public void Method_0014_ee44()
        {
            ii(0x14_ee44, 1); popw(ds);                                 /* pop ds */
            ii(0x14_ee45, 1); popw(dx);                                 /* pop dx */
            ii(0x14_ee46, 1); popw(ax);                                 /* pop ax */
            ii(0x14_ee47, 1); retw(); return;                           /* ret */
        }
    }
}
