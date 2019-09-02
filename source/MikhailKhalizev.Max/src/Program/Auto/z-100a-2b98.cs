using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2b98-3fb02ef2")]
        public void Method_100a_2b98()
        {
            ii(0x100a_2b98, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_2b9d, 5); call(Definitions.sys_check_available_stack_size, 0xc_31b0); /* call 0x10165d52 */
            ii(0x100a_2ba2, 1); push(ebx);                              /* push ebx */
            ii(0x100a_2ba3, 1); push(ecx);                              /* push ecx */
            ii(0x100a_2ba4, 1); push(esi);                              /* push esi */
            ii(0x100a_2ba5, 1); push(edi);                              /* push edi */
            ii(0x100a_2ba6, 1); push(ebp);                              /* push ebp */
            ii(0x100a_2ba7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2ba9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_2baf, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_2bb2, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_2bb5, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_2bb9, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x100a_2bbc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2bbe, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_2bbf, 1); pop(edi);                               /* pop edi */
            ii(0x100a_2bc0, 1); pop(esi);                               /* pop esi */
            ii(0x100a_2bc1, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_2bc2, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_2bc3, 1); ret();                                  /* ret */
        }
    }
}
