using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_bb11-b39031f5")]
        public void Method_1013_bb11()
        {
            ii(0x1013_bb11, 5); push(0x20);                             /* push 0x20 */
            ii(0x1013_bb16, 5); call(Definitions.sys_check_available_stack_size, 0x2_a237); /* call 0x10165d52 */
            ii(0x1013_bb1b, 1); push(ebx);                              /* push ebx */
            ii(0x1013_bb1c, 1); push(ecx);                              /* push ecx */
            ii(0x1013_bb1d, 1); push(esi);                              /* push esi */
            ii(0x1013_bb1e, 1); push(edi);                              /* push edi */
            ii(0x1013_bb1f, 1); push(ebp);                              /* push ebp */
            ii(0x1013_bb20, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_bb22, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_bb28, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_bb2b, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_bb2e, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_bb33, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_bb36, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_bb39, 5); call(0x1013_ba86, -0xb8);               /* call 0x1013ba86 */
            ii(0x1013_bb3e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_bb40, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_bb41, 1); pop(edi);                               /* pop edi */
            ii(0x1013_bb42, 1); pop(esi);                               /* pop esi */
            ii(0x1013_bb43, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_bb44, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_bb45, 1); ret();                                  /* ret */
        }
    }
}
