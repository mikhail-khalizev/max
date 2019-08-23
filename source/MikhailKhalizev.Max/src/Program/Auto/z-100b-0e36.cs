using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_0e36-5ae8c14c")]
        public void Method_100b_0e36()
        {
            ii(0x100b_0e36, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_0e3b, 5); call(Definitions.sys_check_available_stack_size, 0xb_4f12); /* call 0x10165d52 */
            ii(0x100b_0e40, 1); push(ebx);                              /* push ebx */
            ii(0x100b_0e41, 1); push(ecx);                              /* push ecx */
            ii(0x100b_0e42, 1); push(edx);                              /* push edx */
            ii(0x100b_0e43, 1); push(esi);                              /* push esi */
            ii(0x100b_0e44, 1); push(edi);                              /* push edi */
            ii(0x100b_0e45, 1); push(ebp);                              /* push ebp */
            ii(0x100b_0e46, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_0e48, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_0e4e, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_0e51, 4); mov(memb[ss, ebp - 0x8], 0x2d);         /* mov byte [ebp-0x8], 0x2d */
            ii(0x100b_0e55, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x100b_0e58, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_0e5a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_0e5b, 1); pop(edi);                               /* pop edi */
            ii(0x100b_0e5c, 1); pop(esi);                               /* pop esi */
            ii(0x100b_0e5d, 1); pop(edx);                               /* pop edx */
            ii(0x100b_0e5e, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_0e5f, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_0e60, 1); ret();                                  /* ret */
        }
    }
}
