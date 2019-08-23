using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a974-c6a05896")]
        public void Method_100c_a974()
        {
            ii(0x100c_a974, 5); push(0x28);                             /* push 0x28 */
            ii(0x100c_a979, 5); call(Definitions.sys_check_available_stack_size, 0x9_b3d4); /* call 0x10165d52 */
            ii(0x100c_a97e, 1); push(ebx);                              /* push ebx */
            ii(0x100c_a97f, 1); push(ecx);                              /* push ecx */
            ii(0x100c_a980, 1); push(esi);                              /* push esi */
            ii(0x100c_a981, 1); push(edi);                              /* push edi */
            ii(0x100c_a982, 1); push(ebp);                              /* push ebp */
            ii(0x100c_a983, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a985, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100c_a98b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_a98e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_a991, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100c_a995, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a998, 5); call(0x1013_b052, 0x7_06b5);            /* call 0x1013b052 */
            ii(0x100c_a99d, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_a9a0, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100c_a9a3, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_a9a6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a9a9, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_a9ac, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_a9af, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a9b1, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_a9b2, 1); pop(edi);                               /* pop edi */
            ii(0x100c_a9b3, 1); pop(esi);                               /* pop esi */
            ii(0x100c_a9b4, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_a9b5, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_a9b6, 1); ret();                                  /* ret */
        }
    }
}
