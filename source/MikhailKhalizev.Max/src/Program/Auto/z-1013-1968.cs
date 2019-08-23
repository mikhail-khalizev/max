using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_1968-f1f69d5b")]
        public void Method_1013_1968()
        {
            ii(0x1013_1968, 5); push(0x28);                             /* push 0x28 */
            ii(0x1013_196d, 5); call(Definitions.sys_check_available_stack_size, 0x3_43e0); /* call 0x10165d52 */
            ii(0x1013_1972, 1); push(ebx);                              /* push ebx */
            ii(0x1013_1973, 1); push(ecx);                              /* push ecx */
            ii(0x1013_1974, 1); push(esi);                              /* push esi */
            ii(0x1013_1975, 1); push(edi);                              /* push edi */
            ii(0x1013_1976, 1); push(ebp);                              /* push ebp */
            ii(0x1013_1977, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1979, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_197f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_1982, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_1985, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_1989, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_198c, 5); call(0x1013_b052, 0x96c1);              /* call 0x1013b052 */
            ii(0x1013_1991, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_1994, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1013_1997, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_199a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_199d, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_19a0, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_19a3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_19a5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_19a6, 1); pop(edi);                               /* pop edi */
            ii(0x1013_19a7, 1); pop(esi);                               /* pop esi */
            ii(0x1013_19a8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_19a9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_19aa, 1); ret();                                  /* ret */
        }
    }
}
