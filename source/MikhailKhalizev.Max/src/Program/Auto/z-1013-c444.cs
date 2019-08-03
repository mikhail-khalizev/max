using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c0182e65-abb1-46df-9177-09e754d7645d")]
        public void Method_1013_c444()
        {
            ii(0x1013_c444, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_c449, 5); calld(Definitions.sys_check_available_stack_size, 0x29904); /* call 0x10165d52 */
            ii(0x1013_c44e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_c44f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_c450, 1); pushd(esi);                             /* push esi */
            ii(0x1013_c451, 1); pushd(edi);                             /* push edi */
            ii(0x1013_c452, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_c453, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c455, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_c45b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_c45e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_c461, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_c466, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_c469, 5); calld(0x1013_b0a5, -0x13c9);            /* call 0x1013b0a5 */
            ii(0x1013_c46e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_c471, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_c474, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_c477, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_c47a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c47c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_c47d, 1); popd(edi);                              /* pop edi */
            ii(0x1013_c47e, 1); popd(esi);                              /* pop esi */
            ii(0x1013_c47f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_c480, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_c481, 1); retd(); return;                         /* ret */
        }
    }
}
