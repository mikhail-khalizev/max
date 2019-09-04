using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a838-e0620288")]
        public void Method_1008_a838()
        {
            ii(0x1008_a838, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_a83d, 5); call(Definitions.sys_check_available_stack_size, 0xd_b510); /* call 0x10165d52 */
            ii(0x1008_a842, 1); push(ebx);                              /* push ebx */
            ii(0x1008_a843, 1); push(ecx);                              /* push ecx */
            ii(0x1008_a844, 1); push(edx);                              /* push edx */
            ii(0x1008_a845, 1); push(esi);                              /* push esi */
            ii(0x1008_a846, 1); push(edi);                              /* push edi */
            ii(0x1008_a847, 1); push(ebp);                              /* push ebp */
            ii(0x1008_a848, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a84a, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1008_a850, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_a853, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_a856, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1008_a858, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_a85b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_a85e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a860, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_a861, 1); pop(edi);                               /* pop edi */
            ii(0x1008_a862, 1); pop(esi);                               /* pop esi */
            ii(0x1008_a863, 1); pop(edx);                               /* pop edx */
            ii(0x1008_a864, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_a865, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_a866, 1); ret();                                  /* ret */
        }
    }
}
