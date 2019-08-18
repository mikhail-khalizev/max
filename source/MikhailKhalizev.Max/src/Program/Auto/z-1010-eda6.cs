using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bd621132-1751-4d5b-aed4-562a4fd05e71")]
        public void Method_1010_eda6()
        {
            ii(0x1010_eda6, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_edab, 5); calld(Definitions.sys_check_available_stack_size, 0x5_6fa2); /* call 0x10165d52 */
            ii(0x1010_edb0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_edb1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_edb2, 1); pushd(edx);                             /* push edx */
            ii(0x1010_edb3, 1); pushd(esi);                             /* push esi */
            ii(0x1010_edb4, 1); pushd(edi);                             /* push edi */
            ii(0x1010_edb5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_edb6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_edb8, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_edbe, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_edc1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_edc4, 1); pushd(eax);                             /* push eax */
            ii(0x1010_edc5, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_edc7, 5); mov(ebx, 0xca);                         /* mov ebx, 0xca */
            ii(0x1010_edcc, 5); mov(edx, 0x156);                        /* mov edx, 0x156 */
            ii(0x1010_edd1, 5); mov(eax, 0x22c);                        /* mov eax, 0x22c */
            ii(0x1010_edd6, 5); calld(0x100e_8ef1, -0x2_5eea);          /* call 0x100e8ef1 */
            ii(0x1010_eddb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_edde, 1); pushd(eax);                             /* push eax */
            ii(0x1010_eddf, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_ede1, 5); mov(ebx, 0xca);                         /* mov ebx, 0xca */
            ii(0x1010_ede6, 5); mov(edx, 0x1e2);                        /* mov edx, 0x1e2 */
            ii(0x1010_edeb, 5); mov(eax, 0x22d);                        /* mov eax, 0x22d */
            ii(0x1010_edf0, 5); calld(0x100e_8ef1, -0x2_5f04);          /* call 0x100e8ef1 */
            ii(0x1010_edf5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_edf7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_edf8, 1); popd(edi);                              /* pop edi */
            ii(0x1010_edf9, 1); popd(esi);                              /* pop esi */
            ii(0x1010_edfa, 1); popd(edx);                              /* pop edx */
            ii(0x1010_edfb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_edfc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_edfd, 1); retd(); return;                         /* ret */
        }
    }
}
