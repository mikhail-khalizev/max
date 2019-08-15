using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("46518b2f-a51f-4f94-80ef-7f73770229be")]
        public void Method_1011_8282()
        {
            ii(0x1011_8282, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_8287, 5); calld(Definitions.sys_check_available_stack_size, 0x4_dac6); /* call 0x10165d52 */
            ii(0x1011_828c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_828d, 1); pushd(esi);                             /* push esi */
            ii(0x1011_828e, 1); pushd(edi);                             /* push edi */
            ii(0x1011_828f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_8290, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_8292, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_8298, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_829b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_829e, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1011_82a1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_82a3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_82a4, 1); popd(edi);                              /* pop edi */
            ii(0x1011_82a5, 1); popd(esi);                              /* pop esi */
            ii(0x1011_82a6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_82a7, 1); retd(); return;                         /* ret */
        }
    }
}
