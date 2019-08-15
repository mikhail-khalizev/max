using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e776bdfa-243e-45dc-b5b0-1f2d99b652ec")]
        public void Method_100a_284c()
        {
            ii(0x100a_284c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_2851, 5); calld(Definitions.sys_check_available_stack_size, 0xc_34fc); /* call 0x10165d52 */
            ii(0x100a_2856, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_2857, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_2858, 1); pushd(esi);                             /* push esi */
            ii(0x100a_2859, 1); pushd(edi);                             /* push edi */
            ii(0x100a_285a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_285b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_285d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_2863, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_2866, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_2869, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_286c, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_4f54); /* mov dword [eax+0x2], 0x101b4f54 */
            ii(0x100a_2873, 7); dec(memw_a32[ds, 0x101c_31b6]);         /* dec word [0x101c31b6] */
            ii(0x100a_287a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_287c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_287f, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_2882, 5); calld(0x1008_8b7c, -0x1_9d0b);          /* call 0x10088b7c */
            ii(0x100a_2887, 3); sub(eax, 0xf);                          /* sub eax, 0xf */
            ii(0x100a_288a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_288d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_2892, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_2895, 5); calld(0x1013_ab27, 0x9_828d);           /* call 0x1013ab27 */
            ii(0x100a_289a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_289d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_28a0, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_28a3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_28a6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_28a8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_28a9, 1); popd(edi);                              /* pop edi */
            ii(0x100a_28aa, 1); popd(esi);                              /* pop esi */
            ii(0x100a_28ab, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_28ac, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_28ad, 1); retd(); return;                         /* ret */
        }
    }
}
