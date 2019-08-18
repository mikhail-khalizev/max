using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7d34-71b0fe30")]
        public void Method_100b_7d34()
        {
            ii(0x100b_7d34, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_7d39, 5); calld(Definitions.sys_check_available_stack_size, 0xa_e014); /* call 0x10165d52 */
            ii(0x100b_7d3e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_7d3f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_7d40, 1); pushd(esi);                             /* push esi */
            ii(0x100b_7d41, 1); pushd(edi);                             /* push edi */
            ii(0x100b_7d42, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_7d43, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7d45, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_7d4b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7d4e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_7d51, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_7d54, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7d57, 3); add(eax, 0x28);                         /* add eax, 0x28 */
            ii(0x100b_7d5a, 5); calld(0x1008_8b44, -0x2_f21b);          /* call 0x10088b44 */
            ii(0x100b_7d5f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7d61, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_7d62, 1); popd(edi);                              /* pop edi */
            ii(0x100b_7d63, 1); popd(esi);                              /* pop esi */
            ii(0x100b_7d64, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_7d65, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_7d66, 1); retd(); return;                         /* ret */
        }
    }
}
