using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fb498eff-14ce-4656-9bc6-ea3d6eca0145")]
        public void Method_1010_485c()
        {
            ii(0x1010_485c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_4861, 5); calld(Definitions.sys_check_available_stack_size, 0x614ec); /* call 0x10165d52 */
            ii(0x1010_4866, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_4867, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_4868, 1); pushd(esi);                             /* push esi */
            ii(0x1010_4869, 1); pushd(edi);                             /* push edi */
            ii(0x1010_486a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_486b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_486d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_4873, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_4876, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_4879, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_487c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_487f, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1010_4882, 5); calld(0x1010_4890, 0x9);                /* call 0x10104890 */
            ii(0x1010_4887, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_4889, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_488a, 1); popd(edi);                              /* pop edi */
            ii(0x1010_488b, 1); popd(esi);                              /* pop esi */
            ii(0x1010_488c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_488d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_488e, 1); retd(); return;                         /* ret */
        }
    }
}
