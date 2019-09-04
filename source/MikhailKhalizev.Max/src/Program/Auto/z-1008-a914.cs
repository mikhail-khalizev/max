using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a914-2d3fc0b4")]
        public void Method_1008_a914()
        {
            ii(0x1008_a914, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_a919, 5); call(Definitions.sys_check_available_stack_size, 0xd_b434); /* call 0x10165d52 */
            ii(0x1008_a91e, 1); push(ebx);                              /* push ebx */
            ii(0x1008_a91f, 1); push(ecx);                              /* push ecx */
            ii(0x1008_a920, 1); push(esi);                              /* push esi */
            ii(0x1008_a921, 1); push(edi);                              /* push edi */
            ii(0x1008_a922, 1); push(ebp);                              /* push ebp */
            ii(0x1008_a923, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a925, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_a92b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_a92e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_a931, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_a934, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_a937, 5); call(0x1013_abc3, 0xb_0287);            /* call 0x1013abc3 */
            ii(0x1008_a93c, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_a93f, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1008_a942, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_a945, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_a948, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1008_a94b, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1008_a94e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a950, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_a951, 1); pop(edi);                               /* pop edi */
            ii(0x1008_a952, 1); pop(esi);                               /* pop esi */
            ii(0x1008_a953, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_a954, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_a955, 1); ret();                                  /* ret */
        }
    }
}
