using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7a2a4621-0c08-4bad-b80d-45a124a4aaab")]
        public void Method_0014_efd2()
        {
            ii(0x14_efd2, 5); add(memw_a32[ss, ebp + 0x24], -0xd /* 0xf3 */); /* add word [ebp+0x24], 0xfff3 */
            ii(0x14_efd7, 5); test(memb_a16[cs, si - 0x5], 0x20);       /* test byte [cs:si-0x5], 0x20 */
            ii(0x14_efdc, 1); popw(es);                                 /* pop es */
            ii(0x14_efdd, 1); popw(ds);                                 /* pop ds */
            ii(0x14_efde, 2); popad();                                  /* popad */
            ii(0x14_efe0, 2); if(jzw(0x14_efe5, 0x3)) goto l_0x14_efe5; /* jz 0xefe5 */
            ii(0x14_efe2, 3); retw(0x6); return;                        /* ret 0x6 */
        l_0x14_efe5:
            ii(0x14_efe5, 3); retw(0x2); return;                        /* ret 0x2 */
        }
    }
}
