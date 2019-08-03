using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1e03151b-53f3-4c5a-a24a-0174494644a0")]
        public void Method_1013_bac1()
        {
            ii(0x1013_bac1, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_bac6, 5); calld(Definitions.sys_check_available_stack_size, 0x2a287); /* call 0x10165d52 */
            ii(0x1013_bacb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_bacc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_bacd, 1); pushd(esi);                             /* push esi */
            ii(0x1013_bace, 1); pushd(edi);                             /* push edi */
            ii(0x1013_bacf, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_bad0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_bad2, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_bad8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_badb, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_bade, 5); calld(0x1013_c6ac, 0xbc9);              /* call 0x1013c6ac */
            ii(0x1013_bae3, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1013_bae6, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_bae9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_baec, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1013_baef, 5); calld(0x1013_c5c0, 0xacc);              /* call 0x1013c5c0 */
            ii(0x1013_baf4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_baf7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_bafa, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_bafd, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1013_bb00, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_bb03, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_bb06, 3); calld_abs(memd_a32[ds, ebx + 0x8]);     /* call dword [ebx+0x8] */
            ii(0x1013_bb09, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_bb0b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_bb0c, 1); popd(edi);                              /* pop edi */
            ii(0x1013_bb0d, 1); popd(esi);                              /* pop esi */
            ii(0x1013_bb0e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_bb0f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_bb10, 1); retd(); return;                         /* ret */
        }
    }
}