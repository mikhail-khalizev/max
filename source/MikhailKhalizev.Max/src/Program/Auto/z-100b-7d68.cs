using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3e738e71-333a-4b6b-b7ca-a695c1ca5317")]
        public void Method_100b_7d68()
        {
            ii(0x100b_7d68, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_7d6d, 5); calld(Definitions.sys_check_available_stack_size, 0xa_dfe0); /* call 0x10165d52 */
            ii(0x100b_7d72, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_7d73, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_7d74, 1); pushd(edx);                             /* push edx */
            ii(0x100b_7d75, 1); pushd(esi);                             /* push esi */
            ii(0x100b_7d76, 1); pushd(edi);                             /* push edi */
            ii(0x100b_7d77, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_7d78, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7d7a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_7d80, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_7d83, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_7d86, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_7d89, 5); calld(0x1007_65d0, -0x4_17be);          /* call 0x100765d0 */
            ii(0x100b_7d8e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7d91, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7d94, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7d96, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_7d97, 1); popd(edi);                              /* pop edi */
            ii(0x100b_7d98, 1); popd(esi);                              /* pop esi */
            ii(0x100b_7d99, 1); popd(edx);                              /* pop edx */
            ii(0x100b_7d9a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_7d9b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_7d9c, 1); retd(); return;                         /* ret */
        }
    }
}
