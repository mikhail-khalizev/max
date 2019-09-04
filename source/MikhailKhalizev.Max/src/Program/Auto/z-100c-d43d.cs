using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_d43d-6bec56b8")]
        public void Method_100c_d43d()
        {
            ii(0x100c_d43d, 5); push(0x20);                             /* push 0x20 */
            ii(0x100c_d442, 5); call(Definitions.sys_check_available_stack_size, 0x9_890b); /* call 0x10165d52 */
            ii(0x100c_d447, 1); push(ebx);                              /* push ebx */
            ii(0x100c_d448, 1); push(ecx);                              /* push ecx */
            ii(0x100c_d449, 1); push(edx);                              /* push edx */
            ii(0x100c_d44a, 1); push(esi);                              /* push esi */
            ii(0x100c_d44b, 1); push(edi);                              /* push edi */
            ii(0x100c_d44c, 1); push(ebp);                              /* push ebp */
            ii(0x100c_d44d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_d44f, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100c_d455, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_d458, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_d45a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_d45b, 1); pop(edi);                               /* pop edi */
            ii(0x100c_d45c, 1); pop(esi);                               /* pop esi */
            ii(0x100c_d45d, 1); pop(edx);                               /* pop edx */
            ii(0x100c_d45e, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_d45f, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_d460, 1); ret();                                  /* ret */
        }
    }
}
