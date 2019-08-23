using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_5766-91ba4bdf")]
        public void Method_1014_5766()
        {
            ii(0x1014_5766, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_576b, 5); call(Definitions.sys_check_available_stack_size, 0x2_05e2); /* call 0x10165d52 */
            ii(0x1014_5770, 1); push(ebx);                              /* push ebx */
            ii(0x1014_5771, 1); push(ecx);                              /* push ecx */
            ii(0x1014_5772, 1); push(esi);                              /* push esi */
            ii(0x1014_5773, 1); push(edi);                              /* push edi */
            ii(0x1014_5774, 1); push(ebp);                              /* push ebp */
            ii(0x1014_5775, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5777, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_577d, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_5780, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_5783, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_5786, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_5789, 5); call(0x1013_b518, -0xa276);             /* call 0x1013b518 */
            ii(0x1014_578e, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_5791, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_5794, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_5796, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_5797, 1); pop(edi);                               /* pop edi */
            ii(0x1014_5798, 1); pop(esi);                               /* pop esi */
            ii(0x1014_5799, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_579a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_579b, 1); ret();                                  /* ret */
        }
    }
}
