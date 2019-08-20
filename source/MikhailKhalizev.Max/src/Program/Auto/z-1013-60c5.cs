using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_60c5-4f7af337")]
        public void Method_1013_60c5()
        {
            ii(0x1013_60c5, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1013_60c9, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1013_60cc, 2); if(jged(0x1013_60e0, 0x12)) goto l_0x1013_60e0; /* jge 0x101360e0 */
            ii(0x1013_60ce, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1013_60d1, 2); add(al, 0x6b);                          /* add al, 0x6b */
            ii(0x1013_60d3, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x1013_60d6, 5); calld(0x1007_5fdc, -0xc_00ff);          /* call 0x10075fdc */
            ii(0x1013_60db, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_60de, 2); jmpd(0x1013_60e7, 0x7); goto l_0x1013_60e7; /* jmp 0x101360e7 */
        l_0x1013_60e0:
            ii(0x1013_60e0, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
        l_0x1013_60e7:
            ii(0x1013_60e7, 5); cmp(memw_a32[ss, ebp - 0xc], 0);        /* cmp word [ebp-0xc], 0x0 */
            ii(0x1013_60ec, 2); if(jnzd_func(0x1013_610e, 0x20)) return; /* jnz 0x1013610e */
            ii(0x1013_60ee, 5); calld(/* sys */ 0x1016_5e9b, 0x2_fda8); /* call 0x10165e9b */
            ii(0x1013_60f3, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1013_60f6, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x1013_60f9, 1); inc(eax);                               /* inc eax */
            ii(0x1013_60fa, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        }
    }
}
