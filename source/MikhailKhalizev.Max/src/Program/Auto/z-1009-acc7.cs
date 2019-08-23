using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_acc7-7ec931c8")]
        public void Method_1009_acc7()
        {
            ii(0x1009_acc7, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_accc, 5); call(Definitions.sys_check_available_stack_size, 0xc_b081); /* call 0x10165d52 */
            ii(0x1009_acd1, 1); push(ebx);                              /* push ebx */
            ii(0x1009_acd2, 1); push(ecx);                              /* push ecx */
            ii(0x1009_acd3, 1); push(edx);                              /* push edx */
            ii(0x1009_acd4, 1); push(esi);                              /* push esi */
            ii(0x1009_acd5, 1); push(edi);                              /* push edi */
            ii(0x1009_acd6, 1); push(ebp);                              /* push ebp */
            ii(0x1009_acd7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_acd9, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_acdf, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_ace2, 4); mov(memb[ss, ebp - 0x8], 0x22);         /* mov byte [ebp-0x8], 0x22 */
            ii(0x1009_ace6, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x1009_ace9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_aceb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_acec, 1); pop(edi);                               /* pop edi */
            ii(0x1009_aced, 1); pop(esi);                               /* pop esi */
            ii(0x1009_acee, 1); pop(edx);                               /* pop edx */
            ii(0x1009_acef, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_acf0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_acf1, 1); ret();                                  /* ret */
        }
    }
}
