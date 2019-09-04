using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a96c-1a8159da")]
        public void Method_100a_a96c()
        {
            ii(0x100a_a96c, 5); push(0x28);                             /* push 0x28 */
            ii(0x100a_a971, 5); call(Definitions.sys_check_available_stack_size, 0xb_b3dc); /* call 0x10165d52 */
            ii(0x100a_a976, 1); push(ebx);                              /* push ebx */
            ii(0x100a_a977, 1); push(ecx);                              /* push ecx */
            ii(0x100a_a978, 1); push(esi);                              /* push esi */
            ii(0x100a_a979, 1); push(edi);                              /* push edi */
            ii(0x100a_a97a, 1); push(ebp);                              /* push ebp */
            ii(0x100a_a97b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a97d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_a983, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a986, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_a989, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100a_a98d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a990, 5); call(0x1013_b052, 0x9_06bd);            /* call 0x1013b052 */
            ii(0x100a_a995, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a998, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x100a_a99b, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_a99e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a9a1, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100a_a9a4, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_a9a7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a9a9, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_a9aa, 1); pop(edi);                               /* pop edi */
            ii(0x100a_a9ab, 1); pop(esi);                               /* pop esi */
            ii(0x100a_a9ac, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_a9ad, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_a9ae, 1); ret();                                  /* ret */
        }
    }
}
