using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_bb46-a28e3fbb")]
        public void Method_1013_bb46()
        {
            ii(0x1013_bb46, 5); push(0x20);                             /* push 0x20 */
            ii(0x1013_bb4b, 5); call(Definitions.sys_check_available_stack_size, 0x2_a202); /* call 0x10165d52 */
            ii(0x1013_bb50, 1); push(ebx);                              /* push ebx */
            ii(0x1013_bb51, 1); push(ecx);                              /* push ecx */
            ii(0x1013_bb52, 1); push(esi);                              /* push esi */
            ii(0x1013_bb53, 1); push(edi);                              /* push edi */
            ii(0x1013_bb54, 1); push(ebp);                              /* push ebp */
            ii(0x1013_bb55, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_bb57, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_bb5d, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_bb60, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_bb63, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_bb68, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_bb6b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_bb6e, 5); call(0x1013_ba86, -0xed);               /* call 0x1013ba86 */
            ii(0x1013_bb73, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_bb75, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_bb76, 1); pop(edi);                               /* pop edi */
            ii(0x1013_bb77, 1); pop(esi);                               /* pop esi */
            ii(0x1013_bb78, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_bb79, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_bb7a, 1); ret();                                  /* ret */
        }
    }
}
