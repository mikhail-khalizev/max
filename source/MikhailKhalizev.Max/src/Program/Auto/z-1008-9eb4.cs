using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9eb4-6bbc8cf0")]
        public void Method_1008_9eb4()
        {
            ii(0x1008_9eb4, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_9eb9, 5); call(Definitions.sys_check_available_stack_size, 0xd_be94); /* call 0x10165d52 */
            ii(0x1008_9ebe, 1); push(ebx);                              /* push ebx */
            ii(0x1008_9ebf, 1); push(ecx);                              /* push ecx */
            ii(0x1008_9ec0, 1); push(esi);                              /* push esi */
            ii(0x1008_9ec1, 1); push(edi);                              /* push edi */
            ii(0x1008_9ec2, 1); push(ebp);                              /* push ebp */
            ii(0x1008_9ec3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9ec5, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_9ecb, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_9ece, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_9ed1, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_9ed4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_9ed7, 5); call(0x1013_abc3, 0xb_0ce7);            /* call 0x1013abc3 */
            ii(0x1008_9edc, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_9edf, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1008_9ee2, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_9ee5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_9ee8, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_9eeb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_9eee, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9ef0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_9ef1, 1); pop(edi);                               /* pop edi */
            ii(0x1008_9ef2, 1); pop(esi);                               /* pop esi */
            ii(0x1008_9ef3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_9ef4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_9ef5, 1); ret();                                  /* ret */
        }
    }
}
