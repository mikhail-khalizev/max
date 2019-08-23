using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_ac18-9c54e2f")]
        public void Method_1008_ac18()
        {
            ii(0x1008_ac18, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_ac1d, 5); call(Definitions.sys_check_available_stack_size, 0xd_b130); /* call 0x10165d52 */
            ii(0x1008_ac22, 1); push(ebx);                              /* push ebx */
            ii(0x1008_ac23, 1); push(ecx);                              /* push ecx */
            ii(0x1008_ac24, 1); push(esi);                              /* push esi */
            ii(0x1008_ac25, 1); push(edi);                              /* push edi */
            ii(0x1008_ac26, 1); push(ebp);                              /* push ebp */
            ii(0x1008_ac27, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_ac29, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_ac2f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_ac32, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_ac35, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_ac38, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_ac3b, 5); call(0x1013_acc5, 0xb_0085);            /* call 0x1013acc5 */
            ii(0x1008_ac40, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_ac43, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_ac46, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_ac48, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_ac49, 1); pop(edi);                               /* pop edi */
            ii(0x1008_ac4a, 1); pop(esi);                               /* pop esi */
            ii(0x1008_ac4b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_ac4c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_ac4d, 1); ret();                                  /* ret */
        }
    }
}
