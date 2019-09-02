using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9ffc-e0e05299")]
        public void Method_1008_9ffc()
        {
            ii(0x1008_9ffc, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_a001, 5); call(Definitions.sys_check_available_stack_size, 0xd_bd4c); /* call 0x10165d52 */
            ii(0x1008_a006, 1); push(ebx);                              /* push ebx */
            ii(0x1008_a007, 1); push(ecx);                              /* push ecx */
            ii(0x1008_a008, 1); push(edx);                              /* push edx */
            ii(0x1008_a009, 1); push(esi);                              /* push esi */
            ii(0x1008_a00a, 1); push(edi);                              /* push edi */
            ii(0x1008_a00b, 1); push(ebp);                              /* push ebp */
            ii(0x1008_a00c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a00e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1008_a014, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_a017, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_a01a, 4); mov(ax, memw[ds, eax + 0x23]);          /* mov ax, [eax+0x23] */
            ii(0x1008_a01e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_a021, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_a024, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a026, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_a027, 1); pop(edi);                               /* pop edi */
            ii(0x1008_a028, 1); pop(esi);                               /* pop esi */
            ii(0x1008_a029, 1); pop(edx);                               /* pop edx */
            ii(0x1008_a02a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_a02b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_a02c, 1); ret();                                  /* ret */
        }
    }
}
