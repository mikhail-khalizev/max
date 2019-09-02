using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_4e8c-a8aabf3b")]
        public void Method_100d_4e8c()
        {
            ii(0x100d_4e8c, 5); push(0x24);                             /* push 0x24 */
            ii(0x100d_4e91, 5); call(Definitions.sys_check_available_stack_size, 0x9_0ebc); /* call 0x10165d52 */
            ii(0x100d_4e96, 1); push(ebx);                              /* push ebx */
            ii(0x100d_4e97, 1); push(ecx);                              /* push ecx */
            ii(0x100d_4e98, 1); push(edx);                              /* push edx */
            ii(0x100d_4e99, 1); push(esi);                              /* push esi */
            ii(0x100d_4e9a, 1); push(edi);                              /* push edi */
            ii(0x100d_4e9b, 1); push(ebp);                              /* push ebp */
            ii(0x100d_4e9c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_4e9e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100d_4ea4, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100d_4ea7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_4eaa, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100d_4eac, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_4eaf, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_4eb2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_4eb4, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_4eb5, 1); pop(edi);                               /* pop edi */
            ii(0x100d_4eb6, 1); pop(esi);                               /* pop esi */
            ii(0x100d_4eb7, 1); pop(edx);                               /* pop edx */
            ii(0x100d_4eb8, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_4eb9, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_4eba, 1); ret();                                  /* ret */
        }
    }
}
