using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_3b6e-26c5984")]
        public void Method_100a_3b6e()
        {
            ii(0x100a_3b6e, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_3b73, 5); call(Definitions.sys_check_available_stack_size, 0xc_21da); /* call 0x10165d52 */
            ii(0x100a_3b78, 1); push(ebx);                              /* push ebx */
            ii(0x100a_3b79, 1); push(ecx);                              /* push ecx */
            ii(0x100a_3b7a, 1); push(edx);                              /* push edx */
            ii(0x100a_3b7b, 1); push(esi);                              /* push esi */
            ii(0x100a_3b7c, 1); push(edi);                              /* push edi */
            ii(0x100a_3b7d, 1); push(ebp);                              /* push ebp */
            ii(0x100a_3b7e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_3b80, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100a_3b86, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_3b89, 7); mov(memd[ss, ebp - 8], 4);              /* mov dword [ebp-0x8], 0x4 */
            ii(0x100a_3b90, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_3b93, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_3b95, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_3b96, 1); pop(edi);                               /* pop edi */
            ii(0x100a_3b97, 1); pop(esi);                               /* pop esi */
            ii(0x100a_3b98, 1); pop(edx);                               /* pop edx */
            ii(0x100a_3b99, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_3b9a, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_3b9b, 1); ret();                                  /* ret */
        }
    }
}
