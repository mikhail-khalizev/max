using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_b32c-3c5bcbad")]
        public void Method_1008_b32c()
        {
            ii(0x1008_b32c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1008_b331, 5); calld(Definitions.sys_check_available_stack_size, 0xd_aa1c); /* call 0x10165d52 */
            ii(0x1008_b336, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_b337, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_b338, 1); pushd(esi);                             /* push esi */
            ii(0x1008_b339, 1); pushd(edi);                             /* push edi */
            ii(0x1008_b33a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_b33b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b33d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_b343, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_b346, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_b349, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1008_b34d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_b350, 5); calld(0x1008_b410, 0xbb);               /* call 0x1008b410 */
            ii(0x1008_b355, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1008_b358, 5); calld(0x100c_db14, 0x4_27b7);           /* call 0x100cdb14 */
            ii(0x1008_b35d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b35f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_b360, 1); popd(edi);                              /* pop edi */
            ii(0x1008_b361, 1); popd(esi);                              /* pop esi */
            ii(0x1008_b362, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_b363, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_b364, 1); retd(); return;                         /* ret */
        }
    }
}
