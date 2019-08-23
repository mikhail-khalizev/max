using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_d254-5bde7fc1")]
        public void Method_100c_d254()
        {
            ii(0x100c_d254, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_d259, 5); calld(Definitions.sys_check_available_stack_size, 0x9_8af4); /* call 0x10165d52 */
            ii(0x100c_d25e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_d25f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_d260, 1); pushd(edx);                             /* push edx */
            ii(0x100c_d261, 1); pushd(esi);                             /* push esi */
            ii(0x100c_d262, 1); pushd(edi);                             /* push edi */
            ii(0x100c_d263, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_d264, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_d266, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_d26c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_d26f, 7); mov(memd_a32[ss, ebp - 0x8], 0x1);      /* mov dword [ebp-0x8], 0x1 */
            ii(0x100c_d276, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d279, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_d27b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_d27c, 1); popd(edi);                              /* pop edi */
            ii(0x100c_d27d, 1); popd(esi);                              /* pop esi */
            ii(0x100c_d27e, 1); popd(edx);                              /* pop edx */
            ii(0x100c_d27f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_d280, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_d281, 1); retd();                                 /* ret */
        }
    }
}
