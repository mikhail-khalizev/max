using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_aae7-d0b0f1b3")]
        public void Method_1013_aae7()
        {
            ii(0x1013_aae7, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_aaec, 5); call(Definitions.sys_check_available_stack_size, 0x2_b261); /* call 0x10165d52 */
            ii(0x1013_aaf1, 1); push(ebx);                              /* push ebx */
            ii(0x1013_aaf2, 1); push(ecx);                              /* push ecx */
            ii(0x1013_aaf3, 1); push(esi);                              /* push esi */
            ii(0x1013_aaf4, 1); push(edi);                              /* push edi */
            ii(0x1013_aaf5, 1); push(ebp);                              /* push ebp */
            ii(0x1013_aaf6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_aaf8, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_aafe, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_ab01, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_ab04, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_ab07, 7); mov(memd[ds, eax + 2], 0x101b_6ec4);    /* mov dword [eax+0x2], 0x101b6ec4 */
            ii(0x1013_ab0e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_ab11, 5); mov(memw[ds, eax], 0);                  /* mov word [eax], 0x0 */
            ii(0x1013_ab16, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_ab19, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_ab1c, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_ab1f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_ab21, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_ab22, 1); pop(edi);                               /* pop edi */
            ii(0x1013_ab23, 1); pop(esi);                               /* pop esi */
            ii(0x1013_ab24, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_ab25, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_ab26, 1); ret();                                  /* ret */
        }
    }
}
