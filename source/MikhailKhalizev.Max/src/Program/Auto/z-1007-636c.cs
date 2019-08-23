using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_636c-c7196141")]
        public void Method_1007_636c()
        {
            ii(0x1007_636c, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_6371, 5); call(Definitions.sys_check_available_stack_size, 0xe_f9dc); /* call 0x10165d52 */
            ii(0x1007_6376, 1); push(ebx);                              /* push ebx */
            ii(0x1007_6377, 1); push(ecx);                              /* push ecx */
            ii(0x1007_6378, 1); push(edx);                              /* push edx */
            ii(0x1007_6379, 1); push(esi);                              /* push esi */
            ii(0x1007_637a, 1); push(edi);                              /* push edi */
            ii(0x1007_637b, 1); push(ebp);                              /* push ebp */
            ii(0x1007_637c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_637e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_6384, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_6387, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_638a, 5); call(0x1007_6c30, 0x8a1);               /* call 0x10076c30 */
            ii(0x1007_638f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_6392, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_6395, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6397, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_6398, 1); pop(edi);                               /* pop edi */
            ii(0x1007_6399, 1); pop(esi);                               /* pop esi */
            ii(0x1007_639a, 1); pop(edx);                               /* pop edx */
            ii(0x1007_639b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_639c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_639d, 1); ret();                                  /* ret */
        }
    }
}
