using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("43a3a2a9-de60-47ea-94eb-5593f9a3c825")]
        public void Method_1008_9d3c()
        {
            ii(0x1008_9d3c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_9d41, 5); calld(Definitions.sys_check_available_stack_size, 0xd_c00c); /* call 0x10165d52 */
            ii(0x1008_9d46, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9d47, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9d48, 1); pushd(edx);                             /* push edx */
            ii(0x1008_9d49, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9d4a, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9d4b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9d4c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9d4e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_9d54, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_9d57, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_9d5a, 5); calld(0x1013_a0af, 0xb_0350);           /* call 0x1013a0af */
            ii(0x1008_9d5f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_9d62, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1008_9d65, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9d68, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_9d6b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_9d6e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_9d71, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9d73, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9d74, 1); popd(edi);                              /* pop edi */
            ii(0x1008_9d75, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9d76, 1); popd(edx);                              /* pop edx */
            ii(0x1008_9d77, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9d78, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9d79, 1); retd(); return;                         /* ret */
        }
    }
}
