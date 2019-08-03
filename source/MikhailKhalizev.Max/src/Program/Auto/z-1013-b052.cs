using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("95d770d3-6e86-42d5-926d-ca8eb190fd96")]
        public void Method_1013_b052()
        {
            ii(0x1013_b052, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_b057, 5); calld(Definitions.sys_check_available_stack_size, 0x2acf6); /* call 0x10165d52 */
            ii(0x1013_b05c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_b05d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_b05e, 1); pushd(esi);                             /* push esi */
            ii(0x1013_b05f, 1); pushd(edi);                             /* push edi */
            ii(0x1013_b060, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_b061, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b063, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_b069, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_b06c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_b06f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b072, 5); mov(memw_a32[ds, eax], 0);              /* mov word [eax], 0x0 */
            ii(0x1013_b077, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b07a, 6); mov(memw_a32[ds, eax + 0x4], 0);        /* mov word [eax+0x4], 0x0 */
            ii(0x1013_b080, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_b083, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_b086, 4); mov(memw_a32[ds, edx + 0x2], ax);       /* mov [edx+0x2], ax */
            ii(0x1013_b08a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b08d, 7); mov(memd_a32[ds, eax + 0x6], 0);        /* mov dword [eax+0x6], 0x0 */
            ii(0x1013_b094, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b097, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_b09a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_b09d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b09f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_b0a0, 1); popd(edi);                              /* pop edi */
            ii(0x1013_b0a1, 1); popd(esi);                              /* pop esi */
            ii(0x1013_b0a2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_b0a3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_b0a4, 1); retd(); return;                         /* ret */
        }
    }
}
