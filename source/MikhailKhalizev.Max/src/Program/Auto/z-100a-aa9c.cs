using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_aa9c-81e75ae5")]
        public void Method_100a_aa9c()
        {
            ii(0x100a_aa9c, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_aaa1, 5); call(Definitions.sys_check_available_stack_size, 0xb_b2ac); /* call 0x10165d52 */
            ii(0x100a_aaa6, 1); push(ecx);                              /* push ecx */
            ii(0x100a_aaa7, 1); push(esi);                              /* push esi */
            ii(0x100a_aaa8, 1); push(edi);                              /* push edi */
            ii(0x100a_aaa9, 1); push(ebp);                              /* push ebp */
            ii(0x100a_aaaa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_aaac, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_aab2, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_aab5, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100a_aab8, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100a_aabb, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x100a_aabf, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_aac2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_aac5, 5); call(0x100c_d990, 0x2_2ec6);            /* call 0x100cd990 */
            ii(0x100a_aaca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_aacc, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_aacd, 1); pop(edi);                               /* pop edi */
            ii(0x100a_aace, 1); pop(esi);                               /* pop esi */
            ii(0x100a_aacf, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_aad0, 1); ret();                                  /* ret */
        }
    }
}
