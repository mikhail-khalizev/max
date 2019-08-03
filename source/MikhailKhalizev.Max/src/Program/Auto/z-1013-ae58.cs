using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8d144405-9578-4bf1-bda4-3cd3595c6020")]
        public void Method_1013_ae58()
        {
            ii(0x1013_ae58, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1013_ae5d, 5); calld(Definitions.sys_check_available_stack_size, 0x2aef0); /* call 0x10165d52 */
            ii(0x1013_ae62, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_ae63, 1); pushd(esi);                             /* push esi */
            ii(0x1013_ae64, 1); pushd(edi);                             /* push edi */
            ii(0x1013_ae65, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_ae66, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_ae68, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1013_ae6e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_ae71, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1013_ae74, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1013_ae77, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ae7a, 5); calld(0x1013_aaa8, -0x3d7);             /* call 0x1013aaa8 */
            ii(0x1013_ae7f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_ae82, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1013_ae85, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_ae88, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1013_ae8c, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1013_ae90, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ae93, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1013_ae96, 5); calld(0x100c_d7e8, -0x6d6b3);           /* call 0x100cd7e8 */
            ii(0x1013_ae9b, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x1013_ae9e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_aea1, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1013_aea4, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_aea7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_aeaa, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_6f04); /* mov dword [eax+0x2], 0x101b6f04 */
            ii(0x1013_aeb1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_aeb4, 7); mov(memd_a32[ds, eax + 0x12], 0x101b_6f00); /* mov dword [eax+0x12], 0x101b6f00 */
            ii(0x1013_aebb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_aebe, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1013_aec1, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_aec4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_aec6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_aec7, 1); popd(edi);                              /* pop edi */
            ii(0x1013_aec8, 1); popd(esi);                              /* pop esi */
            ii(0x1013_aec9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_aeca, 1); retd(); return;                         /* ret */
        }
    }
}
