using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ad0a2e9f-8d24-4e5a-85b0-7bce79a80786")]
        public void Method_100b_7f74()
        {
            ii(0x100b_7f74, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_7f79, 5); calld(Definitions.sys_check_available_stack_size, 0xaddd4); /* call 0x10165d52 */
            ii(0x100b_7f7e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_7f7f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_7f80, 1); pushd(edx);                             /* push edx */
            ii(0x100b_7f81, 1); pushd(esi);                             /* push esi */
            ii(0x100b_7f82, 1); pushd(edi);                             /* push edi */
            ii(0x100b_7f83, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_7f84, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7f86, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_7f8c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_7f8f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_7f92, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_7f94, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7f97, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7f9a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7f9c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_7f9d, 1); popd(edi);                              /* pop edi */
            ii(0x100b_7f9e, 1); popd(esi);                              /* pop esi */
            ii(0x100b_7f9f, 1); popd(edx);                              /* pop edx */
            ii(0x100b_7fa0, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_7fa1, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_7fa2, 1); retd(); return;                         /* ret */
        }
    }
}