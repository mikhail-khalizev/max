using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8c828dbd-4ba5-4e50-8c43-15aa52d61050")]
        public void Method_100a_3e6e()
        {
            ii(0x100a_3e6e, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_3e73, 5); calld(Definitions.sys_check_available_stack_size, 0xc_1eda); /* call 0x10165d52 */
            ii(0x100a_3e78, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_3e79, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_3e7a, 1); pushd(edx);                             /* push edx */
            ii(0x100a_3e7b, 1); pushd(esi);                             /* push esi */
            ii(0x100a_3e7c, 1); pushd(edi);                             /* push edi */
            ii(0x100a_3e7d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_3e7e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_3e80, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_3e86, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_3e89, 7); mov(memd_a32[ss, ebp - 0x8], 0x4);      /* mov dword [ebp-0x8], 0x4 */
            ii(0x100a_3e90, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3e93, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_3e95, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_3e96, 1); popd(edi);                              /* pop edi */
            ii(0x100a_3e97, 1); popd(esi);                              /* pop esi */
            ii(0x100a_3e98, 1); popd(edx);                              /* pop edx */
            ii(0x100a_3e99, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_3e9a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_3e9b, 1); retd(); return;                         /* ret */
        }
    }
}
