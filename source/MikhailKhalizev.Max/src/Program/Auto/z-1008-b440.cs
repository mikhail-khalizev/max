using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_b440-a79cb9b6")]
        public void Method_1008_b440()
        {
            ii(0x1008_b440, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_b445, 5); call(Definitions.sys_check_available_stack_size, 0xd_a908); /* call 0x10165d52 */
            ii(0x1008_b44a, 1); push(ebx);                              /* push ebx */
            ii(0x1008_b44b, 1); push(ecx);                              /* push ecx */
            ii(0x1008_b44c, 1); push(esi);                              /* push esi */
            ii(0x1008_b44d, 1); push(edi);                              /* push edi */
            ii(0x1008_b44e, 1); push(ebp);                              /* push ebp */
            ii(0x1008_b44f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b451, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_b457, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_b45a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_b45d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_b460, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1008_b463, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1008_b467, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1008_b46a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_b46d, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x1008_b470, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_b472, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_b475, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_b478, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b47a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_b47b, 1); pop(edi);                               /* pop edi */
            ii(0x1008_b47c, 1); pop(esi);                               /* pop esi */
            ii(0x1008_b47d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_b47e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_b47f, 1); ret();                                  /* ret */
        }
    }
}
