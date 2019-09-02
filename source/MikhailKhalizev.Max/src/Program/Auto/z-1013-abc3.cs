using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_abc3-2402f58f")]
        public void Method_1013_abc3()
        {
            ii(0x1013_abc3, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_abc8, 5); call(Definitions.sys_check_available_stack_size, 0x2_b185); /* call 0x10165d52 */
            ii(0x1013_abcd, 1); push(ebx);                              /* push ebx */
            ii(0x1013_abce, 1); push(ecx);                              /* push ecx */
            ii(0x1013_abcf, 1); push(esi);                              /* push esi */
            ii(0x1013_abd0, 1); push(edi);                              /* push edi */
            ii(0x1013_abd1, 1); push(ebp);                              /* push ebp */
            ii(0x1013_abd2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_abd4, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_abda, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_abdd, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_abe0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_abe3, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1013_abe6, 2); mov(memd[ds, edx], eax);                /* mov [edx], eax */
            ii(0x1013_abe8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_abeb, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1013_abed, 5); call(0x1013_ae28, 0x236);               /* call 0x1013ae28 */
            ii(0x1013_abf2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_abf5, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_abf8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_abfb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_abfd, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_abfe, 1); pop(edi);                               /* pop edi */
            ii(0x1013_abff, 1); pop(esi);                               /* pop esi */
            ii(0x1013_ac00, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_ac01, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_ac02, 1); ret();                                  /* ret */
        }
    }
}
