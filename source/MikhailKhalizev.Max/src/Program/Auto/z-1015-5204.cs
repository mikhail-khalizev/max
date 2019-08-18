using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e1ebdd64-cc37-4940-9c58-dfecdac1a1c0")]
        public void Method_1015_5204()
        {
            ii(0x1015_5204, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_5209, 5); calld(Definitions.sys_check_available_stack_size, 0x1_0b44); /* call 0x10165d52 */
            ii(0x1015_520e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_520f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_5210, 1); pushd(esi);                             /* push esi */
            ii(0x1015_5211, 1); pushd(edi);                             /* push edi */
            ii(0x1015_5212, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_5213, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_5215, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_521b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_521e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_5221, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_5224, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_5227, 5); calld(0x1013_a21a, -0x1_b012);          /* call 0x1013a21a */
            ii(0x1015_522c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_522f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_5232, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_5234, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_5235, 1); popd(edi);                              /* pop edi */
            ii(0x1015_5236, 1); popd(esi);                              /* pop esi */
            ii(0x1015_5237, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_5238, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_5239, 1); retd(); return;                         /* ret */
        }
    }
}
