using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5944f422-9e46-4626-91c9-fcdff272b9a1")]
        public void Method_1009_f50b()
        {
            ii(0x1009_f50b, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1009_f510, 5); calld(Definitions.sys_check_available_stack_size, 0xc_683d); /* call 0x10165d52 */
            ii(0x1009_f515, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_f516, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_f517, 1); pushd(esi);                             /* push esi */
            ii(0x1009_f518, 1); pushd(edi);                             /* push edi */
            ii(0x1009_f519, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_f51a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_f51c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_f522, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_f525, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_f528, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f52b, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x1009_f52e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_f531, 1); pushd(eax);                             /* push eax */
            ii(0x1009_f532, 5); mov(eax, StringDefinitions.AutoSurveyRadiusI); /* mov eax, 0x101a07d1 */
            ii(0x1009_f537, 1); pushd(eax);                             /* push eax */
            ii(0x1009_f538, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_f53b, 1); pushd(eax);                             /* push eax */
            ii(0x1009_f53c, 5); calld(Definitions.sys_sprintf, 0xc_69c0); /* call 0x10165f01 */
            ii(0x1009_f541, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1009_f544, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_f547, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_f54a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_f54d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_f54f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_f550, 1); popd(edi);                              /* pop edi */
            ii(0x1009_f551, 1); popd(esi);                              /* pop esi */
            ii(0x1009_f552, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_f553, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_f554, 1); retd(); return;                         /* ret */
        }
    }
}
