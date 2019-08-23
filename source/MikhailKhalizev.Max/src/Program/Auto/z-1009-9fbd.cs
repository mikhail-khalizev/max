using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9fbd-e213e77f")]
        public void Method_1009_9fbd()
        {
            ii(0x1009_9fbd, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_9fc2, 5); call(Definitions.sys_check_available_stack_size, 0xc_bd8b); /* call 0x10165d52 */
            ii(0x1009_9fc7, 1); push(ebx);                              /* push ebx */
            ii(0x1009_9fc8, 1); push(ecx);                              /* push ecx */
            ii(0x1009_9fc9, 1); push(esi);                              /* push esi */
            ii(0x1009_9fca, 1); push(edi);                              /* push edi */
            ii(0x1009_9fcb, 1); push(ebp);                              /* push ebp */
            ii(0x1009_9fcc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9fce, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_9fd4, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_9fd7, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_9fda, 5); mov(edx, StringDefinitions.ConnectionAssistant); /* mov edx, 0x101a06b0 */
            ii(0x1009_9fdf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9fe2, 5); call(Definitions.sys_strcpy, 0xc_bee8); /* call 0x10165ecf */
            ii(0x1009_9fe7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9fea, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_9fed, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_9ff0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_9ff2, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_9ff3, 1); pop(edi);                               /* pop edi */
            ii(0x1009_9ff4, 1); pop(esi);                               /* pop esi */
            ii(0x1009_9ff5, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_9ff6, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_9ff7, 1); ret();                                  /* ret */
        }
    }
}
