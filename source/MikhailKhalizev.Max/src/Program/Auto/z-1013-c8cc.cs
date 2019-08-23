using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c8cc-4b296440")]
        public void Method_1013_c8cc()
        {
            ii(0x1013_c8cc, 5); push(0x20);                             /* push 0x20 */
            ii(0x1013_c8d1, 5); call(Definitions.sys_check_available_stack_size, 0x2_947c); /* call 0x10165d52 */
            ii(0x1013_c8d6, 1); push(ebx);                              /* push ebx */
            ii(0x1013_c8d7, 1); push(ecx);                              /* push ecx */
            ii(0x1013_c8d8, 1); push(esi);                              /* push esi */
            ii(0x1013_c8d9, 1); push(edi);                              /* push edi */
            ii(0x1013_c8da, 1); push(ebp);                              /* push ebp */
            ii(0x1013_c8db, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c8dd, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_c8e3, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_c8e6, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_c8e9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_c8ec, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_c8ef, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1013_c8f2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c8f4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_c8f5, 1); pop(edi);                               /* pop edi */
            ii(0x1013_c8f6, 1); pop(esi);                               /* pop esi */
            ii(0x1013_c8f7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_c8f8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_c8f9, 1); ret();                                  /* ret */
        }
    }
}
