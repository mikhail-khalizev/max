using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c698-916a125c")]
        public void Method_1009_c698()
        {
            ii(0x1009_c698, 5); push(0x20);                             /* push 0x20 */
            ii(0x1009_c69d, 5); call(Definitions.sys_check_available_stack_size, 0xc_96b0); /* call 0x10165d52 */
            ii(0x1009_c6a2, 1); push(ebx);                              /* push ebx */
            ii(0x1009_c6a3, 1); push(ecx);                              /* push ecx */
            ii(0x1009_c6a4, 1); push(esi);                              /* push esi */
            ii(0x1009_c6a5, 1); push(edi);                              /* push edi */
            ii(0x1009_c6a6, 1); push(ebp);                              /* push ebp */
            ii(0x1009_c6a7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c6a9, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_c6af, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c6b2, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_c6b5, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_c6b8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c6bb, 5); call(0x1013_a2ab, 0x9_dbeb);            /* call 0x1013a2ab */
            ii(0x1009_c6c0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c6c2, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_c6c3, 1); pop(edi);                               /* pop edi */
            ii(0x1009_c6c4, 1); pop(esi);                               /* pop esi */
            ii(0x1009_c6c5, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_c6c6, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_c6c7, 1); ret();                                  /* ret */
        }
    }
}
