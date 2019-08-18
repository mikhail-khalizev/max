using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_56a5-9e60fc1a")]
        public void Method_1014_56a5()
        {
            ii(0x1014_56a5, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_56aa, 5); calld(Definitions.sys_check_available_stack_size, 0x2_06a3); /* call 0x10165d52 */
            ii(0x1014_56af, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_56b0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_56b1, 1); pushd(esi);                             /* push esi */
            ii(0x1014_56b2, 1); pushd(edi);                             /* push edi */
            ii(0x1014_56b3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_56b4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_56b6, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_56bc, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_56bf, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_56c2, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_56c6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_56c9, 5); calld(0x1013_b399, -0xa335);            /* call 0x1013b399 */
            ii(0x1014_56ce, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_56d1, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_56d4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_56d7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_56da, 7); mov(memd_a32[ds, eax + 0xa], 0x101b_7204); /* mov dword [eax+0xa], 0x101b7204 */
            ii(0x1014_56e1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_56e4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_56e7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_56ea, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_56ec, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_56ed, 1); popd(edi);                              /* pop edi */
            ii(0x1014_56ee, 1); popd(esi);                              /* pop esi */
            ii(0x1014_56ef, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_56f0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_56f1, 1); retd(); return;                         /* ret */
        }
    }
}
