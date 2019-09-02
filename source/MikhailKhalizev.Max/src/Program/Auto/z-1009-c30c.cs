using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c30c-3b44c313")]
        public void Method_1009_c30c()
        {
            ii(0x1009_c30c, 5); push(0x28);                             /* push 0x28 */
            ii(0x1009_c311, 5); call(Definitions.sys_check_available_stack_size, 0xc_9a3c); /* call 0x10165d52 */
            ii(0x1009_c316, 1); push(ebx);                              /* push ebx */
            ii(0x1009_c317, 1); push(ecx);                              /* push ecx */
            ii(0x1009_c318, 1); push(esi);                              /* push esi */
            ii(0x1009_c319, 1); push(edi);                              /* push edi */
            ii(0x1009_c31a, 1); push(ebp);                              /* push ebp */
            ii(0x1009_c31b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c31d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1009_c323, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_c326, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1009_c329, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_c32c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_c32f, 5); call(0x1013_ac03, 0x9_e8cf);            /* call 0x1013ac03 */
            ii(0x1009_c334, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_c337, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1009_c33a, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_c33d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_c340, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_c343, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_c346, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c348, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_c349, 1); pop(edi);                               /* pop edi */
            ii(0x1009_c34a, 1); pop(esi);                               /* pop esi */
            ii(0x1009_c34b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_c34c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_c34d, 1); ret();                                  /* ret */
        }
    }
}
