using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8ea1-fd711370")]
        public void Method_100b_8ea1()
        {
            ii(0x100b_8ea1, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_8ea6, 5); calld(Definitions.sys_check_available_stack_size, 0xa_cea7); /* call 0x10165d52 */
            ii(0x100b_8eab, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_8eac, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_8ead, 1); pushd(edx);                             /* push edx */
            ii(0x100b_8eae, 1); pushd(esi);                             /* push esi */
            ii(0x100b_8eaf, 1); pushd(edi);                             /* push edi */
            ii(0x100b_8eb0, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_8eb1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8eb3, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_8eb9, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_8ebc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8ebf, 5); calld(0x100b_8f63, 0x9f);               /* call 0x100b8f63 */
            ii(0x100b_8ec4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8ec7, 4); mov(ax, memw_a32[ds, eax + 0x10]);      /* mov ax, [eax+0x10] */
            ii(0x100b_8ecb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_8ece, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8ed1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_8ed3, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_8ed4, 1); popd(edi);                              /* pop edi */
            ii(0x100b_8ed5, 1); popd(esi);                              /* pop esi */
            ii(0x100b_8ed6, 1); popd(edx);                              /* pop edx */
            ii(0x100b_8ed7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_8ed8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_8ed9, 1); retd(); return;                         /* ret */
        }
    }
}
