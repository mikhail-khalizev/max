using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9e54-996c8a75")]
        public void Method_1009_9e54()
        {
            ii(0x1009_9e54, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_9e59, 5); call(Definitions.sys_check_available_stack_size, 0xc_bef4); /* call 0x10165d52 */
            ii(0x1009_9e5e, 1); push(ebx);                              /* push ebx */
            ii(0x1009_9e5f, 1); push(ecx);                              /* push ecx */
            ii(0x1009_9e60, 1); push(edx);                              /* push edx */
            ii(0x1009_9e61, 1); push(esi);                              /* push esi */
            ii(0x1009_9e62, 1); push(edi);                              /* push edi */
            ii(0x1009_9e63, 1); push(ebp);                              /* push ebp */
            ii(0x1009_9e64, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9e66, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1009_9e6c, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_9e6f, 7); mov(memd[ss, ebp - 8], 4);              /* mov dword [ebp-0x8], 0x4 */
            ii(0x1009_9e76, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_9e79, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_9e7b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_9e7c, 1); pop(edi);                               /* pop edi */
            ii(0x1009_9e7d, 1); pop(esi);                               /* pop esi */
            ii(0x1009_9e7e, 1); pop(edx);                               /* pop edx */
            ii(0x1009_9e7f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_9e80, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_9e81, 1); ret();                                  /* ret */
        }
    }
}
