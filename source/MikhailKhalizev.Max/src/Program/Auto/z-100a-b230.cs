using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b230-7fa5c32a")]
        public void Method_100a_b230()
        {
            ii(0x100a_b230, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_b235, 5); call(Definitions.sys_check_available_stack_size, 0xb_ab18); /* call 0x10165d52 */
            ii(0x100a_b23a, 1); push(ebx);                              /* push ebx */
            ii(0x100a_b23b, 1); push(ecx);                              /* push ecx */
            ii(0x100a_b23c, 1); push(esi);                              /* push esi */
            ii(0x100a_b23d, 1); push(edi);                              /* push edi */
            ii(0x100a_b23e, 1); push(ebp);                              /* push ebp */
            ii(0x100a_b23f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b241, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_b247, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_b24a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_b24d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_b250, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_b253, 5); call(0x1013_acc5, 0x8_fa6d);            /* call 0x1013acc5 */
            ii(0x100a_b258, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_b25b, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_b25e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b260, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_b261, 1); pop(edi);                               /* pop edi */
            ii(0x100a_b262, 1); pop(esi);                               /* pop esi */
            ii(0x100a_b263, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_b264, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_b265, 1); ret();                                  /* ret */
        }
    }
}
