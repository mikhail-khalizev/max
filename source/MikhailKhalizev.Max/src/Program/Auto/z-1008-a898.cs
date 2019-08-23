using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a898-4129f851")]
        public void Method_1008_a898()
        {
            ii(0x1008_a898, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_a89d, 5); call(Definitions.sys_check_available_stack_size, 0xd_b4b0); /* call 0x10165d52 */
            ii(0x1008_a8a2, 1); push(ebx);                              /* push ebx */
            ii(0x1008_a8a3, 1); push(ecx);                              /* push ecx */
            ii(0x1008_a8a4, 1); push(esi);                              /* push esi */
            ii(0x1008_a8a5, 1); push(edi);                              /* push edi */
            ii(0x1008_a8a6, 1); push(ebp);                              /* push ebp */
            ii(0x1008_a8a7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a8a9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_a8af, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_a8b2, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_a8b5, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_a8b8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_a8bb, 5); call(0x1013_ac7d, 0xb_03bd);            /* call 0x1013ac7d */
            ii(0x1008_a8c0, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_a8c3, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_a8c6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a8c8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_a8c9, 1); pop(edi);                               /* pop edi */
            ii(0x1008_a8ca, 1); pop(esi);                               /* pop esi */
            ii(0x1008_a8cb, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_a8cc, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_a8cd, 1); ret();                                  /* ret */
        }
    }
}
