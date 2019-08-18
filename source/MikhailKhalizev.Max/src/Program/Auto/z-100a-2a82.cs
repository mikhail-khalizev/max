using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2a82-4997ab4f")]
        public void Method_100a_2a82()
        {
            ii(0x100a_2a82, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_2a87, 5); calld(Definitions.sys_check_available_stack_size, 0xc_32c6); /* call 0x10165d52 */
            ii(0x100a_2a8c, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_2a8d, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_2a8e, 1); pushd(edx);                             /* push edx */
            ii(0x100a_2a8f, 1); pushd(esi);                             /* push esi */
            ii(0x100a_2a90, 1); pushd(edi);                             /* push edi */
            ii(0x100a_2a91, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_2a92, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2a94, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_2a9a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_2a9d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_2aa2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_2aa5, 5); calld(0x100a_2a04, -0xa6);              /* call 0x100a2a04 */
            ii(0x100a_2aaa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2aac, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_2aad, 1); popd(edi);                              /* pop edi */
            ii(0x100a_2aae, 1); popd(esi);                              /* pop esi */
            ii(0x100a_2aaf, 1); popd(edx);                              /* pop edx */
            ii(0x100a_2ab0, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_2ab1, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_2ab2, 1); retd(); return;                         /* ret */
        }
    }
}
