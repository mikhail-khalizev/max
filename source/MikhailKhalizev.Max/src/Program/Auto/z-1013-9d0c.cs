using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a4acf78e-0835-47de-86df-185dbae57e59")]
        public void Method_1013_9d0c()
        {
            ii(0x1013_9d0c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_9d11, 5); calld(Definitions.sys_check_available_stack_size, 0x2c03c); /* call 0x10165d52 */
            ii(0x1013_9d16, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_9d17, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_9d18, 1); pushd(esi);                             /* push esi */
            ii(0x1013_9d19, 1); pushd(edi);                             /* push edi */
            ii(0x1013_9d1a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_9d1b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_9d1d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_9d23, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_9d26, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_9d29, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_9d2b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_9d2e, 5); calld(Definitions.my_string_dtor, 0x7df7); /* call 0x10141b2a */
            ii(0x1013_9d33, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_9d36, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_9d39, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_9d3c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_9d3f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_9d41, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_9d42, 1); popd(edi);                              /* pop edi */
            ii(0x1013_9d43, 1); popd(esi);                              /* pop esi */
            ii(0x1013_9d44, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_9d45, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_9d46, 1); retd(); return;                         /* ret */
        }
    }
}
