using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_5104-6875a841")]
        public void Method_100d_5104()
        {
            ii(0x100d_5104, 5); push(0x24);                             /* push 0x24 */
            ii(0x100d_5109, 5); call(Definitions.sys_check_available_stack_size, 0x9_0c44); /* call 0x10165d52 */
            ii(0x100d_510e, 1); push(ebx);                              /* push ebx */
            ii(0x100d_510f, 1); push(ecx);                              /* push ecx */
            ii(0x100d_5110, 1); push(edx);                              /* push edx */
            ii(0x100d_5111, 1); push(esi);                              /* push esi */
            ii(0x100d_5112, 1); push(edi);                              /* push edi */
            ii(0x100d_5113, 1); push(ebp);                              /* push ebp */
            ii(0x100d_5114, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_5116, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_511c, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_511f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_5122, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100d_5124, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_5127, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_512a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_512c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_512d, 1); pop(edi);                               /* pop edi */
            ii(0x100d_512e, 1); pop(esi);                               /* pop esi */
            ii(0x100d_512f, 1); pop(edx);                               /* pop edx */
            ii(0x100d_5130, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_5131, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_5132, 1); ret();                                  /* ret */
        }
    }
}
