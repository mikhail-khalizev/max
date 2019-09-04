using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c4c4-a8e8897f")]
        public void Method_1013_c4c4()
        {
            ii(0x1013_c4c4, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_c4c9, 5); call(Definitions.sys_check_available_stack_size, 0x2_9884); /* call 0x10165d52 */
            ii(0x1013_c4ce, 1); push(ebx);                              /* push ebx */
            ii(0x1013_c4cf, 1); push(ecx);                              /* push ecx */
            ii(0x1013_c4d0, 1); push(edx);                              /* push edx */
            ii(0x1013_c4d1, 1); push(esi);                              /* push esi */
            ii(0x1013_c4d2, 1); push(edi);                              /* push edi */
            ii(0x1013_c4d3, 1); push(ebp);                              /* push ebp */
            ii(0x1013_c4d4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c4d6, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1013_c4dc, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1013_c4df, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c4e2, 5); call(0x1007_6c30, -0xc_58b7);           /* call 0x10076c30 */
            ii(0x1013_c4e7, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_c4ea, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c4ed, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c4ef, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_c4f0, 1); pop(edi);                               /* pop edi */
            ii(0x1013_c4f1, 1); pop(esi);                               /* pop esi */
            ii(0x1013_c4f2, 1); pop(edx);                               /* pop edx */
            ii(0x1013_c4f3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_c4f4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_c4f5, 1); ret();                                  /* ret */
        }
    }
}
