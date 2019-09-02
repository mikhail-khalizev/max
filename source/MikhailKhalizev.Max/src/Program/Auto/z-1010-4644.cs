using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_4644-ac5a9338")]
        public void Method_1010_4644()
        {
            ii(0x1010_4644, 5); push(0x20);                             /* push 0x20 */
            ii(0x1010_4649, 5); call(Definitions.sys_check_available_stack_size, 0x6_1704); /* call 0x10165d52 */
            ii(0x1010_464e, 1); push(ebx);                              /* push ebx */
            ii(0x1010_464f, 1); push(ecx);                              /* push ecx */
            ii(0x1010_4650, 1); push(esi);                              /* push esi */
            ii(0x1010_4651, 1); push(edi);                              /* push edi */
            ii(0x1010_4652, 1); push(ebp);                              /* push ebp */
            ii(0x1010_4653, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_4655, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1010_465b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_465e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1010_4661, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1010_4664, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_4667, 5); call(0x1013_a369, 0x3_5cfd);            /* call 0x1013a369 */
            ii(0x1010_466c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_466e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_466f, 1); pop(edi);                               /* pop edi */
            ii(0x1010_4670, 1); pop(esi);                               /* pop esi */
            ii(0x1010_4671, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_4672, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_4673, 1); ret();                                  /* ret */
        }
    }
}
