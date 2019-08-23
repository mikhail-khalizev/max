using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_d85d-5c777950")]
        public void Method_1011_d85d()
        {
            ii(0x1011_d85d, 5); push(0x20);                             /* push 0x20 */
            ii(0x1011_d862, 5); call(Definitions.sys_check_available_stack_size, 0x4_84eb); /* call 0x10165d52 */
            ii(0x1011_d867, 1); push(ebx);                              /* push ebx */
            ii(0x1011_d868, 1); push(ecx);                              /* push ecx */
            ii(0x1011_d869, 1); push(esi);                              /* push esi */
            ii(0x1011_d86a, 1); push(edi);                              /* push edi */
            ii(0x1011_d86b, 1); push(ebp);                              /* push ebp */
            ii(0x1011_d86c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_d86e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_d874, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_d877, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_d87a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_d87d, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_d880, 4); mov(memw[ds, edx + 0x11], ax);          /* mov [edx+0x11], ax */
            ii(0x1011_d884, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_d886, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_d887, 1); pop(edi);                               /* pop edi */
            ii(0x1011_d888, 1); pop(esi);                               /* pop esi */
            ii(0x1011_d889, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_d88a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_d88b, 1); ret();                                  /* ret */
        }
    }
}
