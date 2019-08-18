using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_e793-df28a334")]
        public void Method_100c_e793()
        {
            ii(0x100c_e793, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_e798, 5); calld(Definitions.sys_check_available_stack_size, 0x9_75b5); /* call 0x10165d52 */
            ii(0x100c_e79d, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_e79e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_e79f, 1); pushd(esi);                             /* push esi */
            ii(0x100c_e7a0, 1); pushd(edi);                             /* push edi */
            ii(0x100c_e7a1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_e7a2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_e7a4, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_e7aa, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_e7ad, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_e7b0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_e7b3, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100c_e7b6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_e7b9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e7bc, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x100c_e7be, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_e7c1, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x100c_e7c4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_e7c7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e7ca, 3); mov(memd_a32[ds, eax + 0x4], edx);      /* mov [eax+0x4], edx */
            ii(0x100c_e7cd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_e7d0, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100c_e7d3, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_e7d6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_e7d9, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x100c_e7dc, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_e7df, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e7e2, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x100c_e7e4, 3); mov(memd_a32[ds, eax + 0x8], ebx);      /* mov [eax+0x8], ebx */
            ii(0x100c_e7e7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_e7ea, 3); mov(ebx, memd_a32[ds, eax + 0x4]);      /* mov ebx, [eax+0x4] */
            ii(0x100c_e7ed, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_e7f0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_e7f3, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x100c_e7f6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_e7f9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e7fc, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x100c_e7fe, 3); mov(memd_a32[ds, eax + 0xc], ebx);      /* mov [eax+0xc], ebx */
            ii(0x100c_e801, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_e803, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_e804, 1); popd(edi);                              /* pop edi */
            ii(0x100c_e805, 1); popd(esi);                              /* pop esi */
            ii(0x100c_e806, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_e807, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_e808, 1); retd(); return;                         /* ret */
        }
    }
}
