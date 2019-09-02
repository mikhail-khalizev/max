using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c79c-803962b0")]
        public void Method_1009_c79c()
        {
            ii(0x1009_c79c, 5); push(0x28);                             /* push 0x28 */
            ii(0x1009_c7a1, 5); call(Definitions.sys_check_available_stack_size, 0xc_95ac); /* call 0x10165d52 */
            ii(0x1009_c7a6, 1); push(ebx);                              /* push ebx */
            ii(0x1009_c7a7, 1); push(ecx);                              /* push ecx */
            ii(0x1009_c7a8, 1); push(esi);                              /* push esi */
            ii(0x1009_c7a9, 1); push(edi);                              /* push edi */
            ii(0x1009_c7aa, 1); push(ebp);                              /* push ebp */
            ii(0x1009_c7ab, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c7ad, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1009_c7b3, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_c7b6, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1009_c7b9, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_c7bc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_c7bf, 5); call(0x1013_ac03, 0x9_e43f);            /* call 0x1013ac03 */
            ii(0x1009_c7c4, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_c7c7, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1009_c7ca, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_c7cd, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_c7d0, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_c7d3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_c7d6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c7d8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_c7d9, 1); pop(edi);                               /* pop edi */
            ii(0x1009_c7da, 1); pop(esi);                               /* pop esi */
            ii(0x1009_c7db, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_c7dc, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_c7dd, 1); ret();                                  /* ret */
        }
    }
}
