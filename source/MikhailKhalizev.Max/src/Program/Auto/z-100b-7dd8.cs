using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7dd8-919f77e5")]
        public void Method_100b_7dd8()
        {
            ii(0x100b_7dd8, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_7ddd, 5); call(Definitions.sys_check_available_stack_size, 0xa_df70); /* call 0x10165d52 */
            ii(0x100b_7de2, 1); push(ebx);                              /* push ebx */
            ii(0x100b_7de3, 1); push(ecx);                              /* push ecx */
            ii(0x100b_7de4, 1); push(edx);                              /* push edx */
            ii(0x100b_7de5, 1); push(esi);                              /* push esi */
            ii(0x100b_7de6, 1); push(edi);                              /* push edi */
            ii(0x100b_7de7, 1); push(ebp);                              /* push ebp */
            ii(0x100b_7de8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7dea, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_7df0, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_7df3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_7df6, 4); mov(ax, memw[ds, eax + 0x26]);          /* mov ax, [eax+0x26] */
            ii(0x100b_7dfa, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7dfd, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7e00, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7e02, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_7e03, 1); pop(edi);                               /* pop edi */
            ii(0x100b_7e04, 1); pop(esi);                               /* pop esi */
            ii(0x100b_7e05, 1); pop(edx);                               /* pop edx */
            ii(0x100b_7e06, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_7e07, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_7e08, 1); ret();                                  /* ret */
        }
    }
}
