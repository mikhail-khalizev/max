using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_0a2a-5fff0d6e")]
        public void Method_1008_0a2a()
        {
            ii(0x1008_0a2a, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_0a2f, 5); call(Definitions.sys_check_available_stack_size, 0xe_531e); /* call 0x10165d52 */
            ii(0x1008_0a34, 1); push(ebx);                              /* push ebx */
            ii(0x1008_0a35, 1); push(ecx);                              /* push ecx */
            ii(0x1008_0a36, 1); push(edx);                              /* push edx */
            ii(0x1008_0a37, 1); push(esi);                              /* push esi */
            ii(0x1008_0a38, 1); push(edi);                              /* push edi */
            ii(0x1008_0a39, 1); push(ebp);                              /* push ebp */
            ii(0x1008_0a3a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_0a3c, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_0a42, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_0a45, 4); mov(memb[ss, ebp - 0x8], 0x1a);         /* mov byte [ebp-0x8], 0x1a */
            ii(0x1008_0a49, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x1008_0a4c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_0a4e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_0a4f, 1); pop(edi);                               /* pop edi */
            ii(0x1008_0a50, 1); pop(esi);                               /* pop esi */
            ii(0x1008_0a51, 1); pop(edx);                               /* pop edx */
            ii(0x1008_0a52, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_0a53, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_0a54, 1); ret();                                  /* ret */
        }
    }
}
