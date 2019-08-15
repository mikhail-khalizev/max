using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("16637dd7-e815-4007-abc4-e51986744658")]
        public void Method_100a_36c9()
        {
            ii(0x100a_36c9, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_36ce, 5); calld(Definitions.sys_check_available_stack_size, 0xc_267f); /* call 0x10165d52 */
            ii(0x100a_36d3, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_36d4, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_36d5, 1); pushd(esi);                             /* push esi */
            ii(0x100a_36d6, 1); pushd(edi);                             /* push edi */
            ii(0x100a_36d7, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_36d8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_36da, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_36e0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_36e3, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_36e6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_36e9, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_4f44); /* mov dword [eax+0x2], 0x101b4f44 */
            ii(0x100a_36f0, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_36f5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_36f8, 5); calld(0x1013_ab27, 0x9_742a);           /* call 0x1013ab27 */
            ii(0x100a_36fd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_3700, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3703, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_3706, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_3709, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_370b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_370c, 1); popd(edi);                              /* pop edi */
            ii(0x100a_370d, 1); popd(esi);                              /* pop esi */
            ii(0x100a_370e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_370f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_3710, 1); retd(); return;                         /* ret */
        }
    }
}
