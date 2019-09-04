using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_96e0-641bac30")]
        public void Method_1008_96e0()
        {
            ii(0x1008_96e0, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_96e5, 5); call(Definitions.sys_check_available_stack_size, 0xd_c668); /* call 0x10165d52 */
            ii(0x1008_96ea, 1); push(ebx);                              /* push ebx */
            ii(0x1008_96eb, 1); push(ecx);                              /* push ecx */
            ii(0x1008_96ec, 1); push(esi);                              /* push esi */
            ii(0x1008_96ed, 1); push(edi);                              /* push edi */
            ii(0x1008_96ee, 1); push(ebp);                              /* push ebp */
            ii(0x1008_96ef, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_96f1, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_96f7, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_96fa, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_96fd, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_9700, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_9703, 5); call(0x1013_abc3, 0xb_14bb);            /* call 0x1013abc3 */
            ii(0x1008_9708, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_970b, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1008_970e, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_9711, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_9714, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1008_9717, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1008_971a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_971c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_971d, 1); pop(edi);                               /* pop edi */
            ii(0x1008_971e, 1); pop(esi);                               /* pop esi */
            ii(0x1008_971f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_9720, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_9721, 1); ret();                                  /* ret */
        }
    }
}
