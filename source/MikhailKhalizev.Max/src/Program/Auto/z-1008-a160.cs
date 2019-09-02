using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a160-ca4f76eb")]
        public void Method_1008_a160()
        {
            ii(0x1008_a160, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_a165, 5); call(Definitions.sys_check_available_stack_size, 0xd_bbe8); /* call 0x10165d52 */
            ii(0x1008_a16a, 1); push(ebx);                              /* push ebx */
            ii(0x1008_a16b, 1); push(ecx);                              /* push ecx */
            ii(0x1008_a16c, 1); push(esi);                              /* push esi */
            ii(0x1008_a16d, 1); push(edi);                              /* push edi */
            ii(0x1008_a16e, 1); push(ebp);                              /* push ebp */
            ii(0x1008_a16f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a171, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_a177, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_a17a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_a17d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_a180, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_a183, 5); call(0x1007_6cd0, -0x1_34b8);           /* call 0x10076cd0 */
            ii(0x1008_a188, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_a18b, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1008_a18e, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_a191, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_a194, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1008_a197, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1008_a19a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a19c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_a19d, 1); pop(edi);                               /* pop edi */
            ii(0x1008_a19e, 1); pop(esi);                               /* pop esi */
            ii(0x1008_a19f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_a1a0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_a1a1, 1); ret();                                  /* ret */
        }
    }
}
