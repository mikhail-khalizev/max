using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_ba44-a291077c")]
        public void Method_100c_ba44()
        {
            ii(0x100c_ba44, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_ba49, 5); call(Definitions.sys_check_available_stack_size, 0x9_a304); /* call 0x10165d52 */
            ii(0x100c_ba4e, 1); push(ebx);                              /* push ebx */
            ii(0x100c_ba4f, 1); push(ecx);                              /* push ecx */
            ii(0x100c_ba50, 1); push(edx);                              /* push edx */
            ii(0x100c_ba51, 1); push(esi);                              /* push esi */
            ii(0x100c_ba52, 1); push(edi);                              /* push edi */
            ii(0x100c_ba53, 1); push(ebp);                              /* push ebp */
            ii(0x100c_ba54, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_ba56, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_ba5c, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_ba5f, 4); mov(memb[ss, ebp - 0x8], 0x25);         /* mov byte [ebp-0x8], 0x25 */
            ii(0x100c_ba63, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x100c_ba66, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ba68, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_ba69, 1); pop(edi);                               /* pop edi */
            ii(0x100c_ba6a, 1); pop(esi);                               /* pop esi */
            ii(0x100c_ba6b, 1); pop(edx);                               /* pop edx */
            ii(0x100c_ba6c, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_ba6d, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_ba6e, 1); ret();                                  /* ret */
        }
    }
}
