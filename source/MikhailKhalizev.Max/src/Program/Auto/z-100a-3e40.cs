using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_3e40-9115c68")]
        public void Method_100a_3e40()
        {
            ii(0x100a_3e40, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_3e45, 5); calld(Definitions.sys_check_available_stack_size, 0xc_1f08); /* call 0x10165d52 */
            ii(0x100a_3e4a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_3e4b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_3e4c, 1); pushd(edx);                             /* push edx */
            ii(0x100a_3e4d, 1); pushd(esi);                             /* push esi */
            ii(0x100a_3e4e, 1); pushd(edi);                             /* push edi */
            ii(0x100a_3e4f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_3e50, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_3e52, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_3e58, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_3e5b, 7); mov(memd_a32[ss, ebp - 0x8], 0x4);      /* mov dword [ebp-0x8], 0x4 */
            ii(0x100a_3e62, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3e65, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_3e67, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_3e68, 1); popd(edi);                              /* pop edi */
            ii(0x100a_3e69, 1); popd(esi);                              /* pop esi */
            ii(0x100a_3e6a, 1); popd(edx);                              /* pop edx */
            ii(0x100a_3e6b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_3e6c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_3e6d, 1); retd(); return;                         /* ret */
        }
    }
}
