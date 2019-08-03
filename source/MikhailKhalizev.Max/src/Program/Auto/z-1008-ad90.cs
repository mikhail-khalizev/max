using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3b0e7bc3-85eb-47d3-b8c0-2370cc10ed3b")]
        public void Method_1008_ad90()
        {
            ii(0x1008_ad90, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_ad95, 5); calld(Definitions.sys_check_available_stack_size, 0xdafb8); /* call 0x10165d52 */
            ii(0x1008_ad9a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_ad9b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_ad9c, 1); pushd(edx);                             /* push edx */
            ii(0x1008_ad9d, 1); pushd(esi);                             /* push esi */
            ii(0x1008_ad9e, 1); pushd(edi);                             /* push edi */
            ii(0x1008_ad9f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_ada0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_ada2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_ada8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_adab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_adae, 4); mov(ax, memw_a32[ds, eax + 0x9]);       /* mov ax, [eax+0x9] */
            ii(0x1008_adb2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_adb5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_adb8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_adba, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_adbb, 1); popd(edi);                              /* pop edi */
            ii(0x1008_adbc, 1); popd(esi);                              /* pop esi */
            ii(0x1008_adbd, 1); popd(edx);                              /* pop edx */
            ii(0x1008_adbe, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_adbf, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_adc0, 1); retd(); return;                         /* ret */
        }
    }
}
