using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_1b6c-752e7073")]
        public void Method_1013_1b6c()
        {
            ii(0x1013_1b6c, 5); push(0x28);                             /* push 0x28 */
            ii(0x1013_1b71, 5); call(Definitions.sys_check_available_stack_size, 0x3_41dc); /* call 0x10165d52 */
            ii(0x1013_1b76, 1); push(ebx);                              /* push ebx */
            ii(0x1013_1b77, 1); push(ecx);                              /* push ecx */
            ii(0x1013_1b78, 1); push(esi);                              /* push esi */
            ii(0x1013_1b79, 1); push(edi);                              /* push edi */
            ii(0x1013_1b7a, 1); push(ebp);                              /* push ebp */
            ii(0x1013_1b7b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1b7d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_1b83, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_1b86, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_1b89, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_1b8c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_1b8f, 5); call(0x1007_6d14, -0xb_ae80);           /* call 0x10076d14 */
            ii(0x1013_1b94, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_1b97, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1013_1b9a, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_1b9d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_1ba0, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_1ba3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_1ba6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_1ba8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_1ba9, 1); pop(edi);                               /* pop edi */
            ii(0x1013_1baa, 1); pop(esi);                               /* pop esi */
            ii(0x1013_1bab, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_1bac, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_1bad, 1); ret();                                  /* ret */
        }
    }
}
