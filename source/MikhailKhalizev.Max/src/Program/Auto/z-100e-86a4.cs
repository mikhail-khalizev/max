using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_86a4-c5210e30")]
        public void Method_100e_86a4()
        {
            ii(0x100e_86a4, 5); push(0x28);                             /* push 0x28 */
            ii(0x100e_86a9, 5); call(Definitions.sys_check_available_stack_size, 0x7_d6a4); /* call 0x10165d52 */
            ii(0x100e_86ae, 1); push(ebx);                              /* push ebx */
            ii(0x100e_86af, 1); push(ecx);                              /* push ecx */
            ii(0x100e_86b0, 1); push(esi);                              /* push esi */
            ii(0x100e_86b1, 1); push(edi);                              /* push edi */
            ii(0x100e_86b2, 1); push(ebp);                              /* push ebp */
            ii(0x100e_86b3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_86b5, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100e_86bb, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_86be, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100e_86c1, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100e_86c5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_86c8, 5); call(0x1013_b052, 0x5_2985);            /* call 0x1013b052 */
            ii(0x100e_86cd, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_86d0, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x100e_86d3, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100e_86d6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_86d9, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100e_86dc, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100e_86df, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_86e1, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_86e2, 1); pop(edi);                               /* pop edi */
            ii(0x100e_86e3, 1); pop(esi);                               /* pop esi */
            ii(0x100e_86e4, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_86e5, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_86e6, 1); ret();                                  /* ret */
        }
    }
}
