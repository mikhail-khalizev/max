using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9a5d-43e09c6e")]
        public void Method_1009_9a5d()
        {
            ii(0x1009_9a5d, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_9a62, 5); call(Definitions.sys_check_available_stack_size, 0xc_c2eb); /* call 0x10165d52 */
            ii(0x1009_9a67, 1); push(ebx);                              /* push ebx */
            ii(0x1009_9a68, 1); push(ecx);                              /* push ecx */
            ii(0x1009_9a69, 1); push(edx);                              /* push edx */
            ii(0x1009_9a6a, 1); push(esi);                              /* push esi */
            ii(0x1009_9a6b, 1); push(edi);                              /* push edi */
            ii(0x1009_9a6c, 1); push(ebp);                              /* push ebp */
            ii(0x1009_9a6d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9a6f, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1009_9a75, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_9a78, 4); mov(memb[ss, ebp - 8], 0x1c);           /* mov byte [ebp-0x8], 0x1c */
            ii(0x1009_9a7c, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1009_9a7f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_9a81, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_9a82, 1); pop(edi);                               /* pop edi */
            ii(0x1009_9a83, 1); pop(esi);                               /* pop esi */
            ii(0x1009_9a84, 1); pop(edx);                               /* pop edx */
            ii(0x1009_9a85, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_9a86, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_9a87, 1); ret();                                  /* ret */
        }
    }
}
