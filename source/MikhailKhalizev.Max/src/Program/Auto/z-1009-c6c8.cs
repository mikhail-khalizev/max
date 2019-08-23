using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c6c8-311d1c72")]
        public void Method_1009_c6c8()
        {
            ii(0x1009_c6c8, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_c6cd, 5); call(Definitions.sys_check_available_stack_size, 0xc_9680); /* call 0x10165d52 */
            ii(0x1009_c6d2, 1); push(ebx);                              /* push ebx */
            ii(0x1009_c6d3, 1); push(ecx);                              /* push ecx */
            ii(0x1009_c6d4, 1); push(edx);                              /* push edx */
            ii(0x1009_c6d5, 1); push(esi);                              /* push esi */
            ii(0x1009_c6d6, 1); push(edi);                              /* push edi */
            ii(0x1009_c6d7, 1); push(ebp);                              /* push ebp */
            ii(0x1009_c6d8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c6da, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_c6e0, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_c6e3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_c6e6, 5); call(0x1007_6b58, -0x2_5b93);           /* call 0x10076b58 */
            ii(0x1009_c6eb, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c6ee, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c6f1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c6f3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_c6f4, 1); pop(edi);                               /* pop edi */
            ii(0x1009_c6f5, 1); pop(esi);                               /* pop esi */
            ii(0x1009_c6f6, 1); pop(edx);                               /* pop edx */
            ii(0x1009_c6f7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_c6f8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_c6f9, 1); ret();                                  /* ret */
        }
    }
}
