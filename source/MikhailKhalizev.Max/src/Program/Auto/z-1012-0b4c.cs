using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f0672d30-ce9d-47c9-bc87-0d2fcce9d2e0")]
        public void Method_1012_0b4c()
        {
            ii(0x1012_0b4c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1012_0b51, 5); calld(Definitions.sys_check_available_stack_size, 0x4_51fc); /* call 0x10165d52 */
            ii(0x1012_0b56, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_0b57, 1); pushd(esi);                             /* push esi */
            ii(0x1012_0b58, 1); pushd(edi);                             /* push edi */
            ii(0x1012_0b59, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_0b5a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0b5c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_0b62, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_0b65, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1012_0b68, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1012_0b6b, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1012_0b6f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_0b72, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_0b75, 5); calld(0x1008_b410, -0x9_576a);          /* call 0x1008b410 */
            ii(0x1012_0b7a, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1012_0b7d, 5); calld(0x100c_d990, -0x5_31f2);          /* call 0x100cd990 */
            ii(0x1012_0b82, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0b84, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_0b85, 1); popd(edi);                              /* pop edi */
            ii(0x1012_0b86, 1); popd(esi);                              /* pop esi */
            ii(0x1012_0b87, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0b88, 1); retd(); return;                         /* ret */
        }
    }
}
