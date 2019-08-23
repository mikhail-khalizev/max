using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_9e88-4fde38b1")]
        public void Method_100a_9e88()
        {
            ii(0x100a_9e88, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_9e8d, 5); call(Definitions.sys_check_available_stack_size, 0xb_bec0); /* call 0x10165d52 */
            ii(0x100a_9e92, 1); push(ebx);                              /* push ebx */
            ii(0x100a_9e93, 1); push(ecx);                              /* push ecx */
            ii(0x100a_9e94, 1); push(edx);                              /* push edx */
            ii(0x100a_9e95, 1); push(esi);                              /* push esi */
            ii(0x100a_9e96, 1); push(edi);                              /* push edi */
            ii(0x100a_9e97, 1); push(ebp);                              /* push ebp */
            ii(0x100a_9e98, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_9e9a, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_9ea0, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_9ea3, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_9ea6, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_9eab, 5); call(0x100a_432c, -0x5b84);             /* call 0x100a432c */
            ii(0x100a_9eb0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_9eb2, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_9eb3, 1); pop(edi);                               /* pop edi */
            ii(0x100a_9eb4, 1); pop(esi);                               /* pop esi */
            ii(0x100a_9eb5, 1); pop(edx);                               /* pop edx */
            ii(0x100a_9eb6, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_9eb7, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_9eb8, 1); ret();                                  /* ret */
        }
    }
}
