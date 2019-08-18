using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("34ac3d72-fbfb-458d-90ef-1b25989e4c3e")]
        public void Method_1009_abbe()
        {
            ii(0x1009_abbe, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1009_abc3, 5); calld(Definitions.sys_check_available_stack_size, 0xc_b18a); /* call 0x10165d52 */
            ii(0x1009_abc8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_abc9, 1); pushd(esi);                             /* push esi */
            ii(0x1009_abca, 1); pushd(edi);                             /* push edi */
            ii(0x1009_abcb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_abcc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_abce, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1009_abd4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_abd7, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1009_abda, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1009_abdd, 5); mov(ecx, 0x100);                        /* mov ecx, 0x100 */
            ii(0x1009_abe2, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_abe5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_abe8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_abeb, 5); calld(0x1009_a085, -0xb6b);             /* call 0x1009a085 */
            ii(0x1009_abf0, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_abf3, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1009_abf6, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_abf9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_abfc, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_4258); /* mov dword [eax+0x2], 0x101b4258 */
            ii(0x1009_ac03, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_ac06, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_ac09, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_ac0c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_ac0e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_ac0f, 1); popd(edi);                              /* pop edi */
            ii(0x1009_ac10, 1); popd(esi);                              /* pop esi */
            ii(0x1009_ac11, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_ac12, 1); retd(); return;                         /* ret */
        }
    }
}
