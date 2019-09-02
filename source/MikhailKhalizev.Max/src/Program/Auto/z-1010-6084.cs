using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_6084-bf902802")]
        public void Method_1010_6084()
        {
            ii(0x1010_6084, 5); push(0x24);                             /* push 0x24 */
            ii(0x1010_6089, 5); call(Definitions.sys_check_available_stack_size, 0x5_fcc4); /* call 0x10165d52 */
            ii(0x1010_608e, 1); push(ebx);                              /* push ebx */
            ii(0x1010_608f, 1); push(ecx);                              /* push ecx */
            ii(0x1010_6090, 1); push(edx);                              /* push edx */
            ii(0x1010_6091, 1); push(esi);                              /* push esi */
            ii(0x1010_6092, 1); push(edi);                              /* push edi */
            ii(0x1010_6093, 1); push(ebp);                              /* push ebp */
            ii(0x1010_6094, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_6096, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1010_609c, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1010_609f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_60a2, 1); push(eax);                              /* push eax */
            ii(0x1010_60a3, 5); call(0x1012_361d, 0x1_d575);            /* call 0x1012361d */
            ii(0x1010_60a8, 3); add(esp, 4);                            /* add esp, 0x4 */
            ii(0x1010_60ab, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_60ad, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_60ae, 1); pop(edi);                               /* pop edi */
            ii(0x1010_60af, 1); pop(esi);                               /* pop esi */
            ii(0x1010_60b0, 1); pop(edx);                               /* pop edx */
            ii(0x1010_60b1, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_60b2, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_60b3, 1); ret();                                  /* ret */
        }
    }
}
