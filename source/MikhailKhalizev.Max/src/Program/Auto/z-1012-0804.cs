using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0804-1b783545")]
        public void Method_1012_0804()
        {
            ii(0x1012_0804, 5); push(0x20);                             /* push 0x20 */
            ii(0x1012_0809, 5); call(Definitions.sys_check_available_stack_size, 0x4_5544); /* call 0x10165d52 */
            ii(0x1012_080e, 1); push(ebx);                              /* push ebx */
            ii(0x1012_080f, 1); push(ecx);                              /* push ecx */
            ii(0x1012_0810, 1); push(esi);                              /* push esi */
            ii(0x1012_0811, 1); push(edi);                              /* push edi */
            ii(0x1012_0812, 1); push(ebp);                              /* push ebp */
            ii(0x1012_0813, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0815, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_081b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_081e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_0821, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_0824, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_0827, 5); call(0x1013_a5af, 0x1_9d83);            /* call 0x1013a5af */
            ii(0x1012_082c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_082e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_082f, 1); pop(edi);                               /* pop edi */
            ii(0x1012_0830, 1); pop(esi);                               /* pop esi */
            ii(0x1012_0831, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_0832, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_0833, 1); ret();                                  /* ret */
        }
    }
}
