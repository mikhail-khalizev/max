using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c898-e5aba9e6")]
        public void Method_1013_c898()
        {
            ii(0x1013_c898, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_c89d, 5); call(Definitions.sys_check_available_stack_size, 0x2_94b0); /* call 0x10165d52 */
            ii(0x1013_c8a2, 1); push(ebx);                              /* push ebx */
            ii(0x1013_c8a3, 1); push(ecx);                              /* push ecx */
            ii(0x1013_c8a4, 1); push(edx);                              /* push edx */
            ii(0x1013_c8a5, 1); push(esi);                              /* push esi */
            ii(0x1013_c8a6, 1); push(edi);                              /* push edi */
            ii(0x1013_c8a7, 1); push(ebp);                              /* push ebp */
            ii(0x1013_c8a8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c8aa, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_c8b0, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_c8b3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_c8b6, 4); mov(ax, memw[ds, eax + 0x6]);           /* mov ax, [eax+0x6] */
            ii(0x1013_c8ba, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_c8bd, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_c8c0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c8c2, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_c8c3, 1); pop(edi);                               /* pop edi */
            ii(0x1013_c8c4, 1); pop(esi);                               /* pop esi */
            ii(0x1013_c8c5, 1); pop(edx);                               /* pop edx */
            ii(0x1013_c8c6, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_c8c7, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_c8c8, 1); ret();                                  /* ret */
        }
    }
}
