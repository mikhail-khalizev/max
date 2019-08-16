using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4e0ad828-d5eb-475c-8ae2-e51bad1f6712")]
        public void Method_1007_ca7c()
        {
            ii(0x1007_ca7c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_ca81, 5); calld(Definitions.sys_check_available_stack_size, 0xe_92cc); /* call 0x10165d52 */
            ii(0x1007_ca86, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_ca87, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_ca88, 1); pushd(esi);                             /* push esi */
            ii(0x1007_ca89, 1); pushd(edi);                             /* push edi */
            ii(0x1007_ca8a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_ca8b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_ca8d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_ca93, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_ca96, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_ca99, 5); mov(edx, StringDefinitions.AdvanceToAttackNearbyEnemies); /* mov edx, 0x101a0186 */
            ii(0x1007_ca9e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_caa1, 5); calld(Definitions.sys_strcpy, 0xe_9429); /* call 0x10165ecf */
            ii(0x1007_caa6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_caa9, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_caac, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_caaf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_cab1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_cab2, 1); popd(edi);                              /* pop edi */
            ii(0x1007_cab3, 1); popd(esi);                              /* pop esi */
            ii(0x1007_cab4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_cab5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_cab6, 1); retd(); return;                         /* ret */
        }
    }
}