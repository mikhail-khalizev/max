using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_7ca6-4715f512")]
        public void Method_1008_7ca6()
        {
            ii(0x1008_7ca6, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_7cab, 5); call(Definitions.sys_check_available_stack_size, 0xd_e0a2); /* call 0x10165d52 */
            ii(0x1008_7cb0, 1); push(ebx);                              /* push ebx */
            ii(0x1008_7cb1, 1); push(ecx);                              /* push ecx */
            ii(0x1008_7cb2, 1); push(edx);                              /* push edx */
            ii(0x1008_7cb3, 1); push(esi);                              /* push esi */
            ii(0x1008_7cb4, 1); push(edi);                              /* push edi */
            ii(0x1008_7cb5, 1); push(ebp);                              /* push ebp */
            ii(0x1008_7cb6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_7cb8, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_7cbe, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_7cc1, 4); mov(memb[ss, ebp - 0x8], 0xa);          /* mov byte [ebp-0x8], 0xa */
            ii(0x1008_7cc5, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x1008_7cc8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_7cca, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_7ccb, 1); pop(edi);                               /* pop edi */
            ii(0x1008_7ccc, 1); pop(esi);                               /* pop esi */
            ii(0x1008_7ccd, 1); pop(edx);                               /* pop edx */
            ii(0x1008_7cce, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_7ccf, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_7cd0, 1); ret();                                  /* ret */
        }
    }
}
