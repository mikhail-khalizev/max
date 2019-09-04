using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_a239-4f96afeb")]
        public void Method_1009_a239()
        {
            ii(0x1009_a239, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_a23e, 5); call(Definitions.sys_check_available_stack_size, 0xc_bb0f); /* call 0x10165d52 */
            ii(0x1009_a243, 1); push(ebx);                              /* push ebx */
            ii(0x1009_a244, 1); push(ecx);                              /* push ecx */
            ii(0x1009_a245, 1); push(edx);                              /* push edx */
            ii(0x1009_a246, 1); push(esi);                              /* push esi */
            ii(0x1009_a247, 1); push(edi);                              /* push edi */
            ii(0x1009_a248, 1); push(ebp);                              /* push ebp */
            ii(0x1009_a249, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_a24b, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1009_a251, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_a254, 7); mov(memd[ss, ebp - 8], 4);              /* mov dword [ebp-0x8], 0x4 */
            ii(0x1009_a25b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_a25e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_a260, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_a261, 1); pop(edi);                               /* pop edi */
            ii(0x1009_a262, 1); pop(esi);                               /* pop esi */
            ii(0x1009_a263, 1); pop(edx);                               /* pop edx */
            ii(0x1009_a264, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_a265, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_a266, 1); ret();                                  /* ret */
        }
    }
}
