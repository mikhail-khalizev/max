using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_b228-eb505085")]
        public void Method_1008_b228()
        {
            ii(0x1008_b228, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_b22d, 5); call(Definitions.sys_check_available_stack_size, 0xd_ab20); /* call 0x10165d52 */
            ii(0x1008_b232, 1); push(ebx);                              /* push ebx */
            ii(0x1008_b233, 1); push(ecx);                              /* push ecx */
            ii(0x1008_b234, 1); push(esi);                              /* push esi */
            ii(0x1008_b235, 1); push(edi);                              /* push edi */
            ii(0x1008_b236, 1); push(ebp);                              /* push ebp */
            ii(0x1008_b237, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b239, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_b23f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_b242, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_b245, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1008_b249, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_b24c, 5); call(0x1008_b410, 0x1bf);               /* call 0x1008b410 */
            ii(0x1008_b251, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x1008_b254, 5); call(0x1008_b440, 0x1e7);               /* call 0x1008b440 */
            ii(0x1008_b259, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_b25c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_b25f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b261, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_b262, 1); pop(edi);                               /* pop edi */
            ii(0x1008_b263, 1); pop(esi);                               /* pop esi */
            ii(0x1008_b264, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_b265, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_b266, 1); ret();                                  /* ret */
        }
    }
}
