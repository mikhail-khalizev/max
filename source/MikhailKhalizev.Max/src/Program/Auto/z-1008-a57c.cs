using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a57c-2bf2096")]
        public void Method_1008_a57c()
        {
            ii(0x1008_a57c, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_a581, 5); call(Definitions.sys_check_available_stack_size, 0xd_b7cc); /* call 0x10165d52 */
            ii(0x1008_a586, 1); push(ebx);                              /* push ebx */
            ii(0x1008_a587, 1); push(ecx);                              /* push ecx */
            ii(0x1008_a588, 1); push(edx);                              /* push edx */
            ii(0x1008_a589, 1); push(esi);                              /* push esi */
            ii(0x1008_a58a, 1); push(edi);                              /* push edi */
            ii(0x1008_a58b, 1); push(ebp);                              /* push ebp */
            ii(0x1008_a58c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a58e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1008_a594, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_a597, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_a59a, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1008_a59c, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_a59f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_a5a2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a5a4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_a5a5, 1); pop(edi);                               /* pop edi */
            ii(0x1008_a5a6, 1); pop(esi);                               /* pop esi */
            ii(0x1008_a5a7, 1); pop(edx);                               /* pop edx */
            ii(0x1008_a5a8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_a5a9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_a5aa, 1); ret();                                  /* ret */
        }
    }
}
