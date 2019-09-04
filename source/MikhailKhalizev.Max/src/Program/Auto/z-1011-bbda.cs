using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_bbda-555f1d78")]
        public void Method_1011_bbda()
        {
            ii(0x1011_bbda, 5); push(0x20);                             /* push 0x20 */
            ii(0x1011_bbdf, 5); call(Definitions.sys_check_available_stack_size, 0x4_a16e); /* call 0x10165d52 */
            ii(0x1011_bbe4, 1); push(ebx);                              /* push ebx */
            ii(0x1011_bbe5, 1); push(ecx);                              /* push ecx */
            ii(0x1011_bbe6, 1); push(esi);                              /* push esi */
            ii(0x1011_bbe7, 1); push(edi);                              /* push edi */
            ii(0x1011_bbe8, 1); push(ebp);                              /* push ebp */
            ii(0x1011_bbe9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_bbeb, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1011_bbf1, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1011_bbf4, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1011_bbf7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_bbf9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_bbfa, 1); pop(edi);                               /* pop edi */
            ii(0x1011_bbfb, 1); pop(esi);                               /* pop esi */
            ii(0x1011_bbfc, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_bbfd, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_bbfe, 1); ret();                                  /* ret */
        }
    }
}
