using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9a2f-d3d5eb05")]
        public void Method_1009_9a2f()
        {
            ii(0x1009_9a2f, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_9a34, 5); call(Definitions.sys_check_available_stack_size, 0xc_c319); /* call 0x10165d52 */
            ii(0x1009_9a39, 1); push(ebx);                              /* push ebx */
            ii(0x1009_9a3a, 1); push(ecx);                              /* push ecx */
            ii(0x1009_9a3b, 1); push(edx);                              /* push edx */
            ii(0x1009_9a3c, 1); push(esi);                              /* push esi */
            ii(0x1009_9a3d, 1); push(edi);                              /* push edi */
            ii(0x1009_9a3e, 1); push(ebp);                              /* push ebp */
            ii(0x1009_9a3f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9a41, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1009_9a47, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_9a4a, 7); mov(memd[ss, ebp - 8], 4);              /* mov dword [ebp-0x8], 0x4 */
            ii(0x1009_9a51, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_9a54, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_9a56, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_9a57, 1); pop(edi);                               /* pop edi */
            ii(0x1009_9a58, 1); pop(esi);                               /* pop esi */
            ii(0x1009_9a59, 1); pop(edx);                               /* pop edx */
            ii(0x1009_9a5a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_9a5b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_9a5c, 1); ret();                                  /* ret */
        }
    }
}
