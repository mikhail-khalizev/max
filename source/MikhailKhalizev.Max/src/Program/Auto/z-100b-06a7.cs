using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_06a7-719cea9b")]
        public void Method_100b_06a7()
        {
            ii(0x100b_06a7, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_06ac, 5); call(Definitions.sys_check_available_stack_size, 0xb_56a1); /* call 0x10165d52 */
            ii(0x100b_06b1, 1); push(ebx);                              /* push ebx */
            ii(0x100b_06b2, 1); push(ecx);                              /* push ecx */
            ii(0x100b_06b3, 1); push(esi);                              /* push esi */
            ii(0x100b_06b4, 1); push(edi);                              /* push edi */
            ii(0x100b_06b5, 1); push(ebp);                              /* push ebp */
            ii(0x100b_06b6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_06b8, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_06be, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_06c1, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_06c4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_06c7, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100b_06ca, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_06cd, 5); call(0x100b_06da, 8);                   /* call 0x100b06da */
            ii(0x100b_06d2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_06d4, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_06d5, 1); pop(edi);                               /* pop edi */
            ii(0x100b_06d6, 1); pop(esi);                               /* pop esi */
            ii(0x100b_06d7, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_06d8, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_06d9, 1); ret();                                  /* ret */
        }
    }
}
