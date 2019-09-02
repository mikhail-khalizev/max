using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7d48-df9432a1")]
        public void Method_1014_7d48()
        {
            ii(0x1014_7d48, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_7d4d, 5); call(Definitions.sys_check_available_stack_size, 0x1_e000); /* call 0x10165d52 */
            ii(0x1014_7d52, 1); push(ebx);                              /* push ebx */
            ii(0x1014_7d53, 1); push(ecx);                              /* push ecx */
            ii(0x1014_7d54, 1); push(edx);                              /* push edx */
            ii(0x1014_7d55, 1); push(esi);                              /* push esi */
            ii(0x1014_7d56, 1); push(edi);                              /* push edi */
            ii(0x1014_7d57, 1); push(ebp);                              /* push ebp */
            ii(0x1014_7d58, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7d5a, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1014_7d60, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_7d63, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_7d66, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_7d68, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_7d6b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_7d6e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7d70, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_7d71, 1); pop(edi);                               /* pop edi */
            ii(0x1014_7d72, 1); pop(esi);                               /* pop esi */
            ii(0x1014_7d73, 1); pop(edx);                               /* pop edx */
            ii(0x1014_7d74, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_7d75, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_7d76, 1); ret();                                  /* ret */
        }
    }
}
