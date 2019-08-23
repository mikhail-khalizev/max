using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_ac94-eac9068b")]
        public void Method_1012_ac94()
        {
            ii(0x1012_ac94, 5); push(0x20);                             /* push 0x20 */
            ii(0x1012_ac99, 5); call(Definitions.sys_check_available_stack_size, 0x3_b0b4); /* call 0x10165d52 */
            ii(0x1012_ac9e, 1); push(ebx);                              /* push ebx */
            ii(0x1012_ac9f, 1); push(ecx);                              /* push ecx */
            ii(0x1012_aca0, 1); push(edx);                              /* push edx */
            ii(0x1012_aca1, 1); push(esi);                              /* push esi */
            ii(0x1012_aca2, 1); push(edi);                              /* push edi */
            ii(0x1012_aca3, 1); push(ebp);                              /* push ebp */
            ii(0x1012_aca4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_aca6, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_acac, 5); call(0x1012_75ed, -0x36c4);             /* call 0x101275ed */
            ii(0x1012_acb1, 6); mov(edx, memd[ds, 0x101c_59cc]);        /* mov edx, [0x101c59cc] */
            ii(0x1012_acb7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_acb9, 3); mov(al, memb[ds, edx + 0xe]);           /* mov al, [edx+0xe] */
            ii(0x1012_acbc, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_acbf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_acc2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_acc4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_acc5, 1); pop(edi);                               /* pop edi */
            ii(0x1012_acc6, 1); pop(esi);                               /* pop esi */
            ii(0x1012_acc7, 1); pop(edx);                               /* pop edx */
            ii(0x1012_acc8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_acc9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_acca, 1); ret();                                  /* ret */
        }
    }
}
