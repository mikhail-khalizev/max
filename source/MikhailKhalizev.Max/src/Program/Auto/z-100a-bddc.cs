using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_bddc-2808faeb")]
        public void Method_100a_bddc()
        {
            ii(0x100a_bddc, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_bde1, 5); call(Definitions.sys_check_available_stack_size, 0xb_9f6c); /* call 0x10165d52 */
            ii(0x100a_bde6, 1); push(ebx);                              /* push ebx */
            ii(0x100a_bde7, 1); push(ecx);                              /* push ecx */
            ii(0x100a_bde8, 1); push(edx);                              /* push edx */
            ii(0x100a_bde9, 1); push(esi);                              /* push esi */
            ii(0x100a_bdea, 1); push(edi);                              /* push edi */
            ii(0x100a_bdeb, 1); push(ebp);                              /* push ebp */
            ii(0x100a_bdec, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_bdee, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_bdf4, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_bdf7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_bdf9, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_bdfa, 1); pop(edi);                               /* pop edi */
            ii(0x100a_bdfb, 1); pop(esi);                               /* pop esi */
            ii(0x100a_bdfc, 1); pop(edx);                               /* pop edx */
            ii(0x100a_bdfd, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_bdfe, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_bdff, 1); ret();                                  /* ret */
        }
    }
}
