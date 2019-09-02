using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c668-2f6e6af0")]
        public void Method_1013_c668()
        {
            ii(0x1013_c668, 5); push(0x28);                             /* push 0x28 */
            ii(0x1013_c66d, 5); call(Definitions.sys_check_available_stack_size, 0x2_96e0); /* call 0x10165d52 */
            ii(0x1013_c672, 1); push(ebx);                              /* push ebx */
            ii(0x1013_c673, 1); push(ecx);                              /* push ecx */
            ii(0x1013_c674, 1); push(esi);                              /* push esi */
            ii(0x1013_c675, 1); push(edi);                              /* push edi */
            ii(0x1013_c676, 1); push(ebp);                              /* push ebp */
            ii(0x1013_c677, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c679, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_c67f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_c682, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_c685, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1013_c689, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c68c, 5); call(0x1013_b052, -0x163f);             /* call 0x1013b052 */
            ii(0x1013_c691, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_c694, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1013_c697, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_c69a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c69d, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_c6a0, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_c6a3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c6a5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_c6a6, 1); pop(edi);                               /* pop edi */
            ii(0x1013_c6a7, 1); pop(esi);                               /* pop esi */
            ii(0x1013_c6a8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_c6a9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_c6aa, 1); ret();                                  /* ret */
        }
    }
}
