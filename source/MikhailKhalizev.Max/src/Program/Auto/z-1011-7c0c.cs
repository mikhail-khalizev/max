using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_7c0c-1c843fa6")]
        public void Method_1011_7c0c()
        {
            ii(0x1011_7c0c, 5); push(0x20);                             /* push 0x20 */
            ii(0x1011_7c11, 5); call(Definitions.sys_check_available_stack_size, 0x4_e13c); /* call 0x10165d52 */
            ii(0x1011_7c16, 1); push(ebx);                              /* push ebx */
            ii(0x1011_7c17, 1); push(ecx);                              /* push ecx */
            ii(0x1011_7c18, 1); push(esi);                              /* push esi */
            ii(0x1011_7c19, 1); push(edi);                              /* push edi */
            ii(0x1011_7c1a, 1); push(ebp);                              /* push ebp */
            ii(0x1011_7c1b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_7c1d, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1011_7c23, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1011_7c26, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1011_7c29, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1011_7c2c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_7c2f, 5); call(0x1013_a5af, 0x2_297b);            /* call 0x1013a5af */
            ii(0x1011_7c34, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_7c36, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_7c37, 1); pop(edi);                               /* pop edi */
            ii(0x1011_7c38, 1); pop(esi);                               /* pop esi */
            ii(0x1011_7c39, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_7c3a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_7c3b, 1); ret();                                  /* ret */
        }
    }
}
