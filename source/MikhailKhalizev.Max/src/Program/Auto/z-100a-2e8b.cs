using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2e8b-7c947a08")]
        public void Method_100a_2e8b()
        {
            ii(0x100a_2e8b, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_2e90, 5); call(Definitions.sys_check_available_stack_size, 0xc_2ebd); /* call 0x10165d52 */
            ii(0x100a_2e95, 1); push(ebx);                              /* push ebx */
            ii(0x100a_2e96, 1); push(ecx);                              /* push ecx */
            ii(0x100a_2e97, 1); push(edx);                              /* push edx */
            ii(0x100a_2e98, 1); push(esi);                              /* push esi */
            ii(0x100a_2e99, 1); push(edi);                              /* push edi */
            ii(0x100a_2e9a, 1); push(ebp);                              /* push ebp */
            ii(0x100a_2e9b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2e9d, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100a_2ea3, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_2ea6, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_2eaa, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100a_2ead, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2eaf, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_2eb0, 1); pop(edi);                               /* pop edi */
            ii(0x100a_2eb1, 1); pop(esi);                               /* pop esi */
            ii(0x100a_2eb2, 1); pop(edx);                               /* pop edx */
            ii(0x100a_2eb3, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_2eb4, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_2eb5, 1); ret();                                  /* ret */
        }
    }
}
