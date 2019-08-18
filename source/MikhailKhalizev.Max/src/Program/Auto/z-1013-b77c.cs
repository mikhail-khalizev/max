using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_b77c-9198de29")]
        public void Method_1013_b77c()
        {
            ii(0x1013_b77c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_b781, 5); calld(Definitions.sys_check_available_stack_size, 0x2_a5cc); /* call 0x10165d52 */
            ii(0x1013_b786, 1); pushd(esi);                             /* push esi */
            ii(0x1013_b787, 1); pushd(edi);                             /* push edi */
            ii(0x1013_b788, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_b789, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b78b, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1013_b791, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_b794, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1013_b797, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1013_b79a, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1013_b79d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_b7a0, 5); calld(0x1013_aaa8, -0xcfd);             /* call 0x1013aaa8 */
            ii(0x1013_b7a5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_b7a8, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1013_b7ab, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_b7ae, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1013_b7b1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_b7b4, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1013_b7b7, 5); calld(0x1013_b57c, -0x240);             /* call 0x1013b57c */
            ii(0x1013_b7bc, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x1013_b7bf, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_b7c2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_b7c5, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1013_b7c8, 3); mov(memd_a32[ds, edx + 0xe], eax);      /* mov [edx+0xe], eax */
            ii(0x1013_b7cb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b7ce, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1013_b7d1, 3); mov(memd_a32[ds, edx + 0x12], eax);     /* mov [edx+0x12], eax */
            ii(0x1013_b7d4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_b7d7, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_6f20); /* mov dword [eax+0x2], 0x101b6f20 */
            ii(0x1013_b7de, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_b7e1, 5); calld(0x1013_bdc8, 0x5e2);              /* call 0x1013bdc8 */
            ii(0x1013_b7e6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_b7e9, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1013_b7ec, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_b7ef, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b7f1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_b7f2, 1); popd(edi);                              /* pop edi */
            ii(0x1013_b7f3, 1); popd(esi);                              /* pop esi */
            ii(0x1013_b7f4, 1); retd(); return;                         /* ret */
        }
    }
}
