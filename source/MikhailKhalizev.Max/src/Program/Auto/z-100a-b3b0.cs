using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b3b0-58f34479")]
        public void Method_100a_b3b0()
        {
            ii(0x100a_b3b0, 5); push(0x28);                             /* push 0x28 */
            ii(0x100a_b3b5, 5); call(Definitions.sys_check_available_stack_size, 0xb_a998); /* call 0x10165d52 */
            ii(0x100a_b3ba, 1); push(ebx);                              /* push ebx */
            ii(0x100a_b3bb, 1); push(ecx);                              /* push ecx */
            ii(0x100a_b3bc, 1); push(esi);                              /* push esi */
            ii(0x100a_b3bd, 1); push(edi);                              /* push edi */
            ii(0x100a_b3be, 1); push(ebp);                              /* push ebp */
            ii(0x100a_b3bf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b3c1, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_b3c7, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_b3ca, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_b3cd, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_b3d0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_b3d3, 5); call(0x1013_abc3, 0x8_f7eb);            /* call 0x1013abc3 */
            ii(0x100a_b3d8, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_b3db, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x100a_b3de, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_b3e1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_b3e4, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_b3e7, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_b3ea, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b3ec, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_b3ed, 1); pop(edi);                               /* pop edi */
            ii(0x100a_b3ee, 1); pop(esi);                               /* pop esi */
            ii(0x100a_b3ef, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_b3f0, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_b3f1, 1); ret();                                  /* ret */
        }
    }
}
