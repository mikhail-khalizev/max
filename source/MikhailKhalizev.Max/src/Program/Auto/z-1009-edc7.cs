using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("02328856-a18d-4a95-afe3-88535866568d")]
        public void Method_1009_edc7()
        {
            ii(0x1009_edc7, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_edcc, 5); calld(Definitions.sys_check_available_stack_size, 0xc_6f81); /* call 0x10165d52 */
            ii(0x1009_edd1, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_edd2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_edd3, 1); pushd(esi);                             /* push esi */
            ii(0x1009_edd4, 1); pushd(edi);                             /* push edi */
            ii(0x1009_edd5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_edd6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_edd8, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_edde, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_ede1, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_ede4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_ede7, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1009_edea, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_eded, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1009_edf0, 4); mov(memb_a32[ds, eax + 0x23], 0);       /* mov byte [eax+0x23], 0x0 */
            ii(0x1009_edf4, 5); calld(0x1008_a79c, -0x1_465d);          /* call 0x1008a79c */
            ii(0x1009_edf9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_edfb, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1009_edfd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_ee00, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_ee05, 5); calld(0x100a_53ac, 0x65a2);             /* call 0x100a53ac */
            ii(0x1009_ee0a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_ee0c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_ee0d, 1); popd(edi);                              /* pop edi */
            ii(0x1009_ee0e, 1); popd(esi);                              /* pop esi */
            ii(0x1009_ee0f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_ee10, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_ee11, 1); retd(); return;                         /* ret */
        }
    }
}
