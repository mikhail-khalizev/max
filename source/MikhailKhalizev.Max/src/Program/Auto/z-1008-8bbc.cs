using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_8bbc-bc0b148b")]
        public void Method_1008_8bbc()
        {
            ii(0x1008_8bbc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_8bc1, 5); calld(Definitions.sys_check_available_stack_size, 0xd_d18c); /* call 0x10165d52 */
            ii(0x1008_8bc6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_8bc7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_8bc8, 1); pushd(esi);                             /* push esi */
            ii(0x1008_8bc9, 1); pushd(edi);                             /* push edi */
            ii(0x1008_8bca, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_8bcb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8bcd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8bd3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8bd6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_8bd9, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_8bde, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8be1, 5); calld(0x1007_5e24, -0x1_2dc2);          /* call 0x10075e24 */
            ii(0x1008_8be6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8be9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8bec, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_8bef, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_8bf2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8bf4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_8bf5, 1); popd(edi);                              /* pop edi */
            ii(0x1008_8bf6, 1); popd(esi);                              /* pop esi */
            ii(0x1008_8bf7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_8bf8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_8bf9, 1); retd(); return;                         /* ret */
        }
    }
}
