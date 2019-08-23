using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a1a4-517402a7")]
        public void Method_1008_a1a4()
        {
            ii(0x1008_a1a4, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_a1a9, 5); call(Definitions.sys_check_available_stack_size, 0xd_bba4); /* call 0x10165d52 */
            ii(0x1008_a1ae, 1); push(ebx);                              /* push ebx */
            ii(0x1008_a1af, 1); push(ecx);                              /* push ecx */
            ii(0x1008_a1b0, 1); push(esi);                              /* push esi */
            ii(0x1008_a1b1, 1); push(edi);                              /* push edi */
            ii(0x1008_a1b2, 1); push(ebp);                              /* push ebp */
            ii(0x1008_a1b3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a1b5, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_a1bb, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_a1be, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_a1c1, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_a1c4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_a1c7, 5); call(0x1007_6d14, -0x1_34b8);           /* call 0x10076d14 */
            ii(0x1008_a1cc, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_a1cf, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1008_a1d2, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_a1d5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_a1d8, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_a1db, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_a1de, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a1e0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_a1e1, 1); pop(edi);                               /* pop edi */
            ii(0x1008_a1e2, 1); pop(esi);                               /* pop esi */
            ii(0x1008_a1e3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_a1e4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_a1e5, 1); ret();                                  /* ret */
        }
    }
}
