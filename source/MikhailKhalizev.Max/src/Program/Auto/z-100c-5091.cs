using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("15723862-0785-4bee-bbfc-f47107d229c7")]
        public void Method_100c_5091()
        {
            ii(0x100c_5091, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_5094, 3); mov(edx, memd_a32[ds, eax + 0xe]);      /* mov edx, [eax+0xe] */
            ii(0x100c_5097, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_509a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_509d, 5); calld(0x100c_7824, 0x2782);             /* call 0x100c7824 */
            ii(0x100c_50a2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_50a4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_50a5, 1); popd(edi);                              /* pop edi */
            ii(0x100c_50a6, 1); popd(esi);                              /* pop esi */
            ii(0x100c_50a7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_50a8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_50a9, 1); retd(); return;                         /* ret */
        }
    }
}
