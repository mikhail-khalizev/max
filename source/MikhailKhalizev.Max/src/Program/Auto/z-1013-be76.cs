using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1b990f9f-384a-405f-9a22-286f9becce19")]
        public void Method_1013_be76()
        {
            ii(0x1013_be76, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_be7b, 5); calld(Definitions.sys_check_available_stack_size, 0x29ed2); /* call 0x10165d52 */
            ii(0x1013_be80, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_be81, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_be82, 1); pushd(edx);                             /* push edx */
            ii(0x1013_be83, 1); pushd(esi);                             /* push esi */
            ii(0x1013_be84, 1); pushd(edi);                             /* push edi */
            ii(0x1013_be85, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_be86, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_be88, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_be8e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_be91, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_be94, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1013_be97, 5); calld(0x1013_c758, 0x8bc);              /* call 0x1013c758 */
            ii(0x1013_be9c, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x1013_be9f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_bea2, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1013_bea5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_bea8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_beab, 6); mov(memd_a32[ds, eax], 0);              /* mov dword [eax], 0x0 */
            ii(0x1013_beb1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_beb4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_beb7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_beba, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_bebc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_bebd, 1); popd(edi);                              /* pop edi */
            ii(0x1013_bebe, 1); popd(esi);                              /* pop esi */
            ii(0x1013_bebf, 1); popd(edx);                              /* pop edx */
            ii(0x1013_bec0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_bec1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_bec2, 1); retd(); return;                         /* ret */
        }
    }
}