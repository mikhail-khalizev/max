using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_9e7c-2404de3a")]
        public void Method_1013_9e7c()
        {
            ii(0x1013_9e7c, 5); push(0x20);                             /* push 0x20 */
            ii(0x1013_9e81, 5); call(Definitions.sys_check_available_stack_size, 0x2_becc); /* call 0x10165d52 */
            ii(0x1013_9e86, 1); push(ebx);                              /* push ebx */
            ii(0x1013_9e87, 1); push(ecx);                              /* push ecx */
            ii(0x1013_9e88, 1); push(esi);                              /* push esi */
            ii(0x1013_9e89, 1); push(edi);                              /* push edi */
            ii(0x1013_9e8a, 1); push(ebp);                              /* push ebp */
            ii(0x1013_9e8b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_9e8d, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1013_9e93, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_9e96, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_9e99, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1013_9e9c, 3); add(edx, 0xe);                          /* add edx, 0xe */
            ii(0x1013_9e9f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_9ea2, 5); call(0x100e_06dc, -0x5_97cb);           /* call 0x100e06dc */
            ii(0x1013_9ea7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_9eaa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_9eac, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_9ead, 1); pop(edi);                               /* pop edi */
            ii(0x1013_9eae, 1); pop(esi);                               /* pop esi */
            ii(0x1013_9eaf, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_9eb0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_9eb1, 1); ret();                                  /* ret */
        }
    }
}
