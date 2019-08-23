using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_8b04-9c52ff24")]
        public void Method_1008_8b04()
        {
            ii(0x1008_8b04, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_8b09, 5); calld(Definitions.sys_check_available_stack_size, 0xd_d244); /* call 0x10165d52 */
            ii(0x1008_8b0e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_8b0f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_8b10, 1); pushd(esi);                             /* push esi */
            ii(0x1008_8b11, 1); pushd(edi);                             /* push edi */
            ii(0x1008_8b12, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_8b13, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8b15, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8b1b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8b1e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_8b21, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_8b26, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8b29, 5); calld(0x1008_8ac4, -0x6a);              /* call 0x10088ac4 */
            ii(0x1008_8b2e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8b31, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8b34, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_8b37, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_8b3a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8b3c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_8b3d, 1); popd(edi);                              /* pop edi */
            ii(0x1008_8b3e, 1); popd(esi);                              /* pop esi */
            ii(0x1008_8b3f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_8b40, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_8b41, 1); retd();                                 /* ret */
        }
    }
}
