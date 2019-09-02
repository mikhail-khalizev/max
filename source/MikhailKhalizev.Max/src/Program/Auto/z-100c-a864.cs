using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a864-f9a37d59")]
        public void Method_100c_a864()
        {
            ii(0x100c_a864, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_a869, 5); call(Definitions.sys_check_available_stack_size, 0x9_b4e4); /* call 0x10165d52 */
            ii(0x100c_a86e, 1); push(ebx);                              /* push ebx */
            ii(0x100c_a86f, 1); push(ecx);                              /* push ecx */
            ii(0x100c_a870, 1); push(edx);                              /* push edx */
            ii(0x100c_a871, 1); push(esi);                              /* push esi */
            ii(0x100c_a872, 1); push(edi);                              /* push edi */
            ii(0x100c_a873, 1); push(ebp);                              /* push ebp */
            ii(0x100c_a874, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a876, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100c_a87c, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_a87f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_a882, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_a884, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_a887, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a88a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a88c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_a88d, 1); pop(edi);                               /* pop edi */
            ii(0x100c_a88e, 1); pop(esi);                               /* pop esi */
            ii(0x100c_a88f, 1); pop(edx);                               /* pop edx */
            ii(0x100c_a890, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_a891, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_a892, 1); ret();                                  /* ret */
        }
    }
}
