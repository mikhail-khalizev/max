using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_3844-ed6c89cb")]
        public void Method_100b_3844()
        {
            ii(0x100b_3844, 5); push(0x20);                             /* push 0x20 */
            ii(0x100b_3849, 5); call(Definitions.sys_check_available_stack_size, 0xb_2504); /* call 0x10165d52 */
            ii(0x100b_384e, 1); push(ebx);                              /* push ebx */
            ii(0x100b_384f, 1); push(ecx);                              /* push ecx */
            ii(0x100b_3850, 1); push(esi);                              /* push esi */
            ii(0x100b_3851, 1); push(edi);                              /* push edi */
            ii(0x100b_3852, 1); push(ebp);                              /* push ebp */
            ii(0x100b_3853, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_3855, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100b_385b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_385e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_3861, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_3864, 5); call(0x100b_375b, -0x10e);              /* call 0x100b375b */
            ii(0x100b_3869, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_386b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_386c, 1); pop(edi);                               /* pop edi */
            ii(0x100b_386d, 1); pop(esi);                               /* pop esi */
            ii(0x100b_386e, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_386f, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_3870, 1); ret();                                  /* ret */
        }
    }
}
