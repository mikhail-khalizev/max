using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7ea0-ed9beac1")]
        public void Method_100b_7ea0()
        {
            ii(0x100b_7ea0, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_7ea5, 5); call(Definitions.sys_check_available_stack_size, 0xa_dea8); /* call 0x10165d52 */
            ii(0x100b_7eaa, 1); push(ebx);                              /* push ebx */
            ii(0x100b_7eab, 1); push(ecx);                              /* push ecx */
            ii(0x100b_7eac, 1); push(esi);                              /* push esi */
            ii(0x100b_7ead, 1); push(edi);                              /* push edi */
            ii(0x100b_7eae, 1); push(ebp);                              /* push ebp */
            ii(0x100b_7eaf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7eb1, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_7eb7, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_7eba, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_7ebd, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100b_7ec0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_7ec3, 5); call(0x1013_ac7d, 0x8_2db5);            /* call 0x1013ac7d */
            ii(0x100b_7ec8, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100b_7ecb, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_7ece, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7ed0, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_7ed1, 1); pop(edi);                               /* pop edi */
            ii(0x100b_7ed2, 1); pop(esi);                               /* pop esi */
            ii(0x100b_7ed3, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_7ed4, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_7ed5, 1); ret();                                  /* ret */
        }
    }
}
