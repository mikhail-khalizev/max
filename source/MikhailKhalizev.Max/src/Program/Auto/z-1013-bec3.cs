using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_bec3-2e29f5a1")]
        public void Method_1013_bec3()
        {
            ii(0x1013_bec3, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_bec8, 5); calld(Definitions.sys_check_available_stack_size, 0x2_9e85); /* call 0x10165d52 */
            ii(0x1013_becd, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_bece, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_becf, 1); pushd(esi);                             /* push esi */
            ii(0x1013_bed0, 1); pushd(edi);                             /* push edi */
            ii(0x1013_bed1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_bed2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_bed4, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_beda, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_bedd, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_bee0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_bee3, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1013_bee6, 5); calld(0x1013_c758, 0x86d);              /* call 0x1013c758 */
            ii(0x1013_beeb, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x1013_beee, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_bef1, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1013_bef4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_bef7, 5); mov(edx, StringDefinitions.Wb3);        /* mov edx, 0x101accf3 */
            ii(0x1013_befc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_beff, 5); calld(Definitions.sys_fopen, 0x3_6476); /* call 0x1017237a */
            ii(0x1013_bf04, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_bf06, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_bf09, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1013_bf0b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_bf0e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_bf11, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_bf14, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_bf16, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_bf17, 1); popd(edi);                              /* pop edi */
            ii(0x1013_bf18, 1); popd(esi);                              /* pop esi */
            ii(0x1013_bf19, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_bf1a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_bf1b, 1); retd();                                 /* ret */
        }
    }
}
