using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_b5c7-35fbeb20")]
        public void Method_1013_b5c7()
        {
            ii(0x1013_b5c7, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_b5cc, 5); call(Definitions.sys_check_available_stack_size, 0x2_a781); /* call 0x10165d52 */
            ii(0x1013_b5d1, 1); push(ebx);                              /* push ebx */
            ii(0x1013_b5d2, 1); push(ecx);                              /* push ecx */
            ii(0x1013_b5d3, 1); push(esi);                              /* push esi */
            ii(0x1013_b5d4, 1); push(edi);                              /* push edi */
            ii(0x1013_b5d5, 1); push(ebp);                              /* push ebp */
            ii(0x1013_b5d6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b5d8, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_b5de, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_b5e1, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_b5e4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_b5e7, 3); mov(edx, memd[ds, eax + 4]);            /* mov edx, [eax+0x4] */
            ii(0x1013_b5ea, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_b5ed, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1013_b5f0, 5); call(Definitions.sys_strcmp, 0x3_719b); /* call 0x10172790 */
            ii(0x1013_b5f5, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_b5f8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_b5fb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b5fd, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_b5fe, 1); pop(edi);                               /* pop edi */
            ii(0x1013_b5ff, 1); pop(esi);                               /* pop esi */
            ii(0x1013_b600, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_b601, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_b602, 1); ret();                                  /* ret */
        }
    }
}
