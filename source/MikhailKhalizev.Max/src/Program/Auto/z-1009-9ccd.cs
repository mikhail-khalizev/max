using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9ccd-ad343bb")]
        public void Method_1009_9ccd()
        {
            ii(0x1009_9ccd, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_9cd2, 5); call(Definitions.sys_check_available_stack_size, 0xc_c07b); /* call 0x10165d52 */
            ii(0x1009_9cd7, 1); push(ebx);                              /* push ebx */
            ii(0x1009_9cd8, 1); push(ecx);                              /* push ecx */
            ii(0x1009_9cd9, 1); push(edx);                              /* push edx */
            ii(0x1009_9cda, 1); push(esi);                              /* push esi */
            ii(0x1009_9cdb, 1); push(edi);                              /* push edi */
            ii(0x1009_9cdc, 1); push(ebp);                              /* push ebp */
            ii(0x1009_9cdd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9cdf, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_9ce5, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_9ce8, 4); mov(memb[ss, ebp - 0x8], 0x1b);         /* mov byte [ebp-0x8], 0x1b */
            ii(0x1009_9cec, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x1009_9cef, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_9cf1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_9cf2, 1); pop(edi);                               /* pop edi */
            ii(0x1009_9cf3, 1); pop(esi);                               /* pop esi */
            ii(0x1009_9cf4, 1); pop(edx);                               /* pop edx */
            ii(0x1009_9cf5, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_9cf6, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_9cf7, 1); ret();                                  /* ret */
        }
    }
}
