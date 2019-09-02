using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_319e-366a4bbb")]
        public void Method_1013_319e()
        {
            ii(0x1013_319e, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_31a3, 5); call(Definitions.sys_check_available_stack_size, 0x3_2baa); /* call 0x10165d52 */
            ii(0x1013_31a8, 1); push(ebx);                              /* push ebx */
            ii(0x1013_31a9, 1); push(ecx);                              /* push ecx */
            ii(0x1013_31aa, 1); push(esi);                              /* push esi */
            ii(0x1013_31ab, 1); push(edi);                              /* push edi */
            ii(0x1013_31ac, 1); push(ebp);                              /* push ebp */
            ii(0x1013_31ad, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_31af, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_31b5, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_31b8, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_31bb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_31be, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_31c1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_31c4, 4); mov(memb[ds, eax + 0x1d], 1);           /* mov byte [eax+0x1d], 0x1 */
            ii(0x1013_31c8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_31ca, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_31cb, 1); pop(edi);                               /* pop edi */
            ii(0x1013_31cc, 1); pop(esi);                               /* pop esi */
            ii(0x1013_31cd, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_31ce, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_31cf, 1); ret();                                  /* ret */
        }
    }
}
