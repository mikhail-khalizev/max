using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a0c8-32eae4d2")]
        public void Method_1008_a0c8()
        {
            ii(0x1008_a0c8, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_a0cd, 5); call(Definitions.sys_check_available_stack_size, 0xd_bc80); /* call 0x10165d52 */
            ii(0x1008_a0d2, 1); push(ebx);                              /* push ebx */
            ii(0x1008_a0d3, 1); push(ecx);                              /* push ecx */
            ii(0x1008_a0d4, 1); push(edx);                              /* push edx */
            ii(0x1008_a0d5, 1); push(esi);                              /* push esi */
            ii(0x1008_a0d6, 1); push(edi);                              /* push edi */
            ii(0x1008_a0d7, 1); push(ebp);                              /* push ebp */
            ii(0x1008_a0d8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a0da, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_a0e0, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_a0e3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_a0e6, 3); mov(eax, memd[ds, eax + 0x63]);         /* mov eax, [eax+0x63] */
            ii(0x1008_a0e9, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_a0ec, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_a0ef, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a0f1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_a0f2, 1); pop(edi);                               /* pop edi */
            ii(0x1008_a0f3, 1); pop(esi);                               /* pop esi */
            ii(0x1008_a0f4, 1); pop(edx);                               /* pop edx */
            ii(0x1008_a0f5, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_a0f6, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_a0f7, 1); ret();                                  /* ret */
        }
    }
}
