using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d8fc1faf-180a-444b-b722-2999807fdbd7")]
        public void /* sys */ Method_1019_394d()
        {
            ii(0x1019_394d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_394e, 3); add(esi, memd_a32[ss, ebp - 0x18]);     /* add esi, [ebp-0x18] */
            ii(0x1019_3951, 3); add(edi, memd_a32[ss, ebp - 0x1c]);     /* add edi, [ebp-0x1c] */
            ii(0x1019_3954, 3); add(edi, memd_a32[ss, ebp - 0x20]);     /* add edi, [ebp-0x20] */
            ii(0x1019_3957, 2); loopd_a32_func(0x1019_393a, -0x1f);     /* loop 0x10193d8d */
            ii(0x1019_3959, 1); popd(esi);                              /* pop esi */
            ii(0x1019_395a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_395b, 6); add(esi, memd_a32[ds, 0x1020_9cd0]);    /* add esi, [0x10209cd0] */
            ii(0x1019_3961, 3); inc(memd_a32[ss, ebp + 0x24]);          /* inc dword [ebp+0x24] */
            ii(0x1019_3964, 2); dec(cl);                                /* dec cl */
            ii(0x1019_3966, 2); jnzd_func(0x1019_38f6, -0x72);          /* jnz 0x10193d49 */
            ii(0x1019_3968, 5); jmpd_func(0x1019_3ca9, 0x33c); return;  /* jmp 0x101940fc */
        }
    }
}
