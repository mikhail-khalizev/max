using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7be4-3d7c06a2")]
        public void Method_100b_7be4()
        {
            ii(0x100b_7be4, 5); push(0x20);                             /* push 0x20 */
            ii(0x100b_7be9, 5); call(Definitions.sys_check_available_stack_size, 0xa_e164); /* call 0x10165d52 */
            ii(0x100b_7bee, 1); push(ebx);                              /* push ebx */
            ii(0x100b_7bef, 1); push(ecx);                              /* push ecx */
            ii(0x100b_7bf0, 1); push(esi);                              /* push esi */
            ii(0x100b_7bf1, 1); push(edi);                              /* push edi */
            ii(0x100b_7bf2, 1); push(ebp);                              /* push ebp */
            ii(0x100b_7bf3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7bf5, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_7bfb, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7bfe, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_7c01, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_7c04, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7c07, 5); call(0x1013_a5af, 0x8_29a3);            /* call 0x1013a5af */
            ii(0x100b_7c0c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7c0e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_7c0f, 1); pop(edi);                               /* pop edi */
            ii(0x100b_7c10, 1); pop(esi);                               /* pop esi */
            ii(0x100b_7c11, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_7c12, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_7c13, 1); ret();                                  /* ret */
        }
    }
}
