using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("070455b0-735e-4a48-b75e-b002dcdea4c1")]
        public void Method_1008_7a88()
        {
            ii(0x1008_7a88, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1008_7a8d, 5); calld(Definitions.sys_check_available_stack_size, 0xd_e2c0); /* call 0x10165d52 */
            ii(0x1008_7a92, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_7a93, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_7a94, 1); pushd(esi);                             /* push esi */
            ii(0x1008_7a95, 1); pushd(edi);                             /* push edi */
            ii(0x1008_7a96, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_7a97, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_7a99, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_7a9f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_7aa2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_7aa5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_7aa8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_7aab, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_7aae, 5); calld(0x1008_aab4, 0x3001);             /* call 0x1008aab4 */
            ii(0x1008_7ab3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_7ab5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_7ab6, 1); popd(edi);                              /* pop edi */
            ii(0x1008_7ab7, 1); popd(esi);                              /* pop esi */
            ii(0x1008_7ab8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_7ab9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_7aba, 1); retd(); return;                         /* ret */
        }
    }
}
