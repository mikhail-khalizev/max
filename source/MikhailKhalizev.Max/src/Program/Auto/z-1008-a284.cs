using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a284-8f87b473")]
        public void Method_1008_a284()
        {
            ii(0x1008_a284, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_a289, 5); call(Definitions.sys_check_available_stack_size, 0xd_bac4); /* call 0x10165d52 */
            ii(0x1008_a28e, 1); push(ebx);                              /* push ebx */
            ii(0x1008_a28f, 1); push(ecx);                              /* push ecx */
            ii(0x1008_a290, 1); push(edx);                              /* push edx */
            ii(0x1008_a291, 1); push(esi);                              /* push esi */
            ii(0x1008_a292, 1); push(edi);                              /* push edi */
            ii(0x1008_a293, 1); push(ebp);                              /* push ebp */
            ii(0x1008_a294, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a296, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_a29c, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_a29f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_a2a2, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1008_a2a4, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_a2a7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_a2aa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a2ac, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_a2ad, 1); pop(edi);                               /* pop edi */
            ii(0x1008_a2ae, 1); pop(esi);                               /* pop esi */
            ii(0x1008_a2af, 1); pop(edx);                               /* pop edx */
            ii(0x1008_a2b0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_a2b1, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_a2b2, 1); ret();                                  /* ret */
        }
    }
}
