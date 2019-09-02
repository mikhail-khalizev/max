using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_3930-117e0782")]
        public void Method_1013_3930()
        {
            ii(0x1013_3930, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_3935, 5); call(Definitions.sys_check_available_stack_size, 0x3_2418); /* call 0x10165d52 */
            ii(0x1013_393a, 1); push(ebx);                              /* push ebx */
            ii(0x1013_393b, 1); push(ecx);                              /* push ecx */
            ii(0x1013_393c, 1); push(edx);                              /* push edx */
            ii(0x1013_393d, 1); push(esi);                              /* push esi */
            ii(0x1013_393e, 1); push(edi);                              /* push edi */
            ii(0x1013_393f, 1); push(ebp);                              /* push ebp */
            ii(0x1013_3940, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_3942, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1013_3948, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1013_394b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_394e, 4); mov(ax, memw[ds, eax + 0x1b]);          /* mov ax, [eax+0x1b] */
            ii(0x1013_3952, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_3955, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_3958, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_395a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_395b, 1); pop(edi);                               /* pop edi */
            ii(0x1013_395c, 1); pop(esi);                               /* pop esi */
            ii(0x1013_395d, 1); pop(edx);                               /* pop edx */
            ii(0x1013_395e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_395f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_3960, 1); ret();                                  /* ret */
        }
    }
}
