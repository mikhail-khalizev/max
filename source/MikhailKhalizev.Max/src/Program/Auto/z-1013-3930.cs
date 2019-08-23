using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_3930-117e0782")]
        public void Method_1013_3930()
        {
            ii(0x1013_3930, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_3935, 5); calld(Definitions.sys_check_available_stack_size, 0x3_2418); /* call 0x10165d52 */
            ii(0x1013_393a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_393b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_393c, 1); pushd(edx);                             /* push edx */
            ii(0x1013_393d, 1); pushd(esi);                             /* push esi */
            ii(0x1013_393e, 1); pushd(edi);                             /* push edi */
            ii(0x1013_393f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_3940, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_3942, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_3948, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_394b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_394e, 4); mov(ax, memw_a32[ds, eax + 0x1b]);      /* mov ax, [eax+0x1b] */
            ii(0x1013_3952, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_3955, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_3958, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_395a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_395b, 1); popd(edi);                              /* pop edi */
            ii(0x1013_395c, 1); popd(esi);                              /* pop esi */
            ii(0x1013_395d, 1); popd(edx);                              /* pop edx */
            ii(0x1013_395e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_395f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_3960, 1); retd();                                 /* ret */
        }
    }
}
