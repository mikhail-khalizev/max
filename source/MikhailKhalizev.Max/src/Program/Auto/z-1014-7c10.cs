using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7c10-c22bf6c9")]
        public void Method_1014_7c10()
        {
            ii(0x1014_7c10, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_7c15, 5); call(Definitions.sys_check_available_stack_size, 0x1_e138); /* call 0x10165d52 */
            ii(0x1014_7c1a, 1); push(ebx);                              /* push ebx */
            ii(0x1014_7c1b, 1); push(ecx);                              /* push ecx */
            ii(0x1014_7c1c, 1); push(edx);                              /* push edx */
            ii(0x1014_7c1d, 1); push(esi);                              /* push esi */
            ii(0x1014_7c1e, 1); push(edi);                              /* push edi */
            ii(0x1014_7c1f, 1); push(ebp);                              /* push ebp */
            ii(0x1014_7c20, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7c22, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1014_7c28, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_7c2b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_7c2e, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1014_7c31, 5); call(0x1014_8170, 0x53a);               /* call 0x10148170 */
            ii(0x1014_7c36, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_7c39, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_7c3c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7c3e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_7c3f, 1); pop(edi);                               /* pop edi */
            ii(0x1014_7c40, 1); pop(esi);                               /* pop esi */
            ii(0x1014_7c41, 1); pop(edx);                               /* pop edx */
            ii(0x1014_7c42, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_7c43, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_7c44, 1); ret();                                  /* ret */
        }
    }
}
