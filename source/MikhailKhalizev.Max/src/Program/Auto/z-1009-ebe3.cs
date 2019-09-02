using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_ebe3-27d0b524")]
        public void Method_1009_ebe3()
        {
            ii(0x1009_ebe3, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_ebe8, 5); call(Definitions.sys_check_available_stack_size, 0xc_7165); /* call 0x10165d52 */
            ii(0x1009_ebed, 1); push(ebx);                              /* push ebx */
            ii(0x1009_ebee, 1); push(ecx);                              /* push ecx */
            ii(0x1009_ebef, 1); push(edx);                              /* push edx */
            ii(0x1009_ebf0, 1); push(esi);                              /* push esi */
            ii(0x1009_ebf1, 1); push(edi);                              /* push edi */
            ii(0x1009_ebf2, 1); push(ebp);                              /* push ebp */
            ii(0x1009_ebf3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_ebf5, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1009_ebfb, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_ebfe, 4); mov(memb[ss, ebp - 8], 0xb);            /* mov byte [ebp-0x8], 0xb */
            ii(0x1009_ec02, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1009_ec05, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_ec07, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_ec08, 1); pop(edi);                               /* pop edi */
            ii(0x1009_ec09, 1); pop(esi);                               /* pop esi */
            ii(0x1009_ec0a, 1); pop(edx);                               /* pop edx */
            ii(0x1009_ec0b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_ec0c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_ec0d, 1); ret();                                  /* ret */
        }
    }
}
