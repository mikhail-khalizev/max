using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_ab4c-8efef147")]
        public void Method_100a_ab4c()
        {
            ii(0x100a_ab4c, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_ab51, 5); call(Definitions.sys_check_available_stack_size, 0xb_b1fc); /* call 0x10165d52 */
            ii(0x100a_ab56, 1); push(ebx);                              /* push ebx */
            ii(0x100a_ab57, 1); push(ecx);                              /* push ecx */
            ii(0x100a_ab58, 1); push(edx);                              /* push edx */
            ii(0x100a_ab59, 1); push(esi);                              /* push esi */
            ii(0x100a_ab5a, 1); push(edi);                              /* push edi */
            ii(0x100a_ab5b, 1); push(ebp);                              /* push ebp */
            ii(0x100a_ab5c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ab5e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_ab64, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_ab67, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_ab6a, 5); call(0x1007_6c30, -0x3_3f3f);           /* call 0x10076c30 */
            ii(0x100a_ab6f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_ab72, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_ab75, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_ab77, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_ab78, 1); pop(edi);                               /* pop edi */
            ii(0x100a_ab79, 1); pop(esi);                               /* pop esi */
            ii(0x100a_ab7a, 1); pop(edx);                               /* pop edx */
            ii(0x100a_ab7b, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_ab7c, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_ab7d, 1); ret();                                  /* ret */
        }
    }
}
