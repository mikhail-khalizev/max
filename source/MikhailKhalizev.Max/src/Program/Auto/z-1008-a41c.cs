using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a41c-63d101a2")]
        public void Method_1008_a41c()
        {
            ii(0x1008_a41c, 5); push(0x20);                             /* push 0x20 */
            ii(0x1008_a421, 5); call(Definitions.sys_check_available_stack_size, 0xd_b92c); /* call 0x10165d52 */
            ii(0x1008_a426, 1); push(ebx);                              /* push ebx */
            ii(0x1008_a427, 1); push(ecx);                              /* push ecx */
            ii(0x1008_a428, 1); push(esi);                              /* push esi */
            ii(0x1008_a429, 1); push(edi);                              /* push edi */
            ii(0x1008_a42a, 1); push(ebp);                              /* push ebp */
            ii(0x1008_a42b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a42d, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1008_a433, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_a436, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_a439, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_a43c, 5); call(0x1008_b410, 0xfcf);               /* call 0x1008b410 */
            ii(0x1008_a441, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x1008_a444, 5); call(Definitions.my_3_get_count, 0x1037); /* call 0x1008b480 */
            ii(0x1008_a449, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1008_a44c, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_a44f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_a452, 5); call(0x1008_a460, 9);                   /* call 0x1008a460 */
            ii(0x1008_a457, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a459, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_a45a, 1); pop(edi);                               /* pop edi */
            ii(0x1008_a45b, 1); pop(esi);                               /* pop esi */
            ii(0x1008_a45c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_a45d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_a45e, 1); ret();                                  /* ret */
        }
    }
}
