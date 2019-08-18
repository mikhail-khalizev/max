using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5081e2cd-adf0-4587-a9a3-7007e12e1bde")]
        public void Method_100b_7a7c()
        {
            ii(0x100b_7a7c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_7a81, 5); calld(Definitions.sys_check_available_stack_size, 0xa_e2cc); /* call 0x10165d52 */
            ii(0x100b_7a86, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_7a87, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_7a88, 1); pushd(edx);                             /* push edx */
            ii(0x100b_7a89, 1); pushd(esi);                             /* push esi */
            ii(0x100b_7a8a, 1); pushd(edi);                             /* push edi */
            ii(0x100b_7a8b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_7a8c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7a8e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_7a94, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_7a97, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_7a9a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_7a9c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7a9f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7aa2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7aa4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_7aa5, 1); popd(edi);                              /* pop edi */
            ii(0x100b_7aa6, 1); popd(esi);                              /* pop esi */
            ii(0x100b_7aa7, 1); popd(edx);                              /* pop edx */
            ii(0x100b_7aa8, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_7aa9, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_7aaa, 1); retd(); return;                         /* ret */
        }
    }
}
