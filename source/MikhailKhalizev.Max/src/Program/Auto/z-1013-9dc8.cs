using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_9dc8-a9c1d182")]
        public void Method_1013_9dc8()
        {
            ii(0x1013_9dc8, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_9dcd, 5); call(Definitions.sys_check_available_stack_size, 0x2_bf80); /* call 0x10165d52 */
            ii(0x1013_9dd2, 1); push(ebx);                              /* push ebx */
            ii(0x1013_9dd3, 1); push(ecx);                              /* push ecx */
            ii(0x1013_9dd4, 1); push(esi);                              /* push esi */
            ii(0x1013_9dd5, 1); push(edi);                              /* push edi */
            ii(0x1013_9dd6, 1); push(ebp);                              /* push ebp */
            ii(0x1013_9dd7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_9dd9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_9ddf, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_9de2, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_9de5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_9de7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_9dea, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1013_9ded, 5); call(0x1013_9d88, -0x6a);               /* call 0x10139d88 */
            ii(0x1013_9df2, 3); sub(eax, 0xe);                          /* sub eax, 0xe */
            ii(0x1013_9df5, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_9df8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_9dfa, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_9dfd, 5); call(0x1013_9d48, -0xba);               /* call 0x10139d48 */
            ii(0x1013_9e02, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_9e05, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_9e08, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_9e0b, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_9e0e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_9e10, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_9e11, 1); pop(edi);                               /* pop edi */
            ii(0x1013_9e12, 1); pop(esi);                               /* pop esi */
            ii(0x1013_9e13, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_9e14, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_9e15, 1); ret();                                  /* ret */
        }
    }
}
