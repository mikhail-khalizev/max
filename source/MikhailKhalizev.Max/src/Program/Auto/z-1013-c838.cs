using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c838-45599015")]
        public void Method_1013_c838()
        {
            ii(0x1013_c838, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_c83d, 5); call(Definitions.sys_check_available_stack_size, 0x2_9510); /* call 0x10165d52 */
            ii(0x1013_c842, 1); push(ebx);                              /* push ebx */
            ii(0x1013_c843, 1); push(ecx);                              /* push ecx */
            ii(0x1013_c844, 1); push(edx);                              /* push edx */
            ii(0x1013_c845, 1); push(esi);                              /* push esi */
            ii(0x1013_c846, 1); push(edi);                              /* push edi */
            ii(0x1013_c847, 1); push(ebp);                              /* push ebp */
            ii(0x1013_c848, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c84a, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1013_c850, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1013_c853, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c856, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1013_c859, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_c85c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c85f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c861, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_c862, 1); pop(edi);                               /* pop edi */
            ii(0x1013_c863, 1); pop(esi);                               /* pop esi */
            ii(0x1013_c864, 1); pop(edx);                               /* pop edx */
            ii(0x1013_c865, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_c866, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_c867, 1); ret();                                  /* ret */
        }
    }
}
