using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b74c-e625f070")]
        public void Method_100c_b74c()
        {
            ii(0x100c_b74c, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_b751, 5); call(Definitions.sys_check_available_stack_size, 0x9_a5fc); /* call 0x10165d52 */
            ii(0x100c_b756, 1); push(ebx);                              /* push ebx */
            ii(0x100c_b757, 1); push(ecx);                              /* push ecx */
            ii(0x100c_b758, 1); push(edx);                              /* push edx */
            ii(0x100c_b759, 1); push(esi);                              /* push esi */
            ii(0x100c_b75a, 1); push(edi);                              /* push edi */
            ii(0x100c_b75b, 1); push(ebp);                              /* push ebp */
            ii(0x100c_b75c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b75e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100c_b764, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_b767, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_b76a, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_b76c, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_b76f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_b772, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b774, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_b775, 1); pop(edi);                               /* pop edi */
            ii(0x100c_b776, 1); pop(esi);                               /* pop esi */
            ii(0x100c_b777, 1); pop(edx);                               /* pop edx */
            ii(0x100c_b778, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_b779, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_b77a, 1); ret();                                  /* ret */
        }
    }
}
