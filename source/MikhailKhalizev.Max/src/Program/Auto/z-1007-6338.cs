using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6338-1315113d")]
        public void Method_1007_6338()
        {
            ii(0x1007_6338, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_633d, 5); call(Definitions.sys_check_available_stack_size, 0xe_fa10); /* call 0x10165d52 */
            ii(0x1007_6342, 1); push(ebx);                              /* push ebx */
            ii(0x1007_6343, 1); push(ecx);                              /* push ecx */
            ii(0x1007_6344, 1); push(edx);                              /* push edx */
            ii(0x1007_6345, 1); push(esi);                              /* push esi */
            ii(0x1007_6346, 1); push(edi);                              /* push edi */
            ii(0x1007_6347, 1); push(ebp);                              /* push ebp */
            ii(0x1007_6348, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_634a, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1007_6350, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_6353, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_6356, 5); call(0x1007_6b58, 0x7fd);               /* call 0x10076b58 */
            ii(0x1007_635b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_635e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_6361, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6363, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_6364, 1); pop(edi);                               /* pop edi */
            ii(0x1007_6365, 1); pop(esi);                               /* pop esi */
            ii(0x1007_6366, 1); pop(edx);                               /* pop edx */
            ii(0x1007_6367, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_6368, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_6369, 1); ret();                                  /* ret */
        }
    }
}
