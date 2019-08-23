using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0244-7435de9a")]
        public void Method_100e_0244()
        {
            ii(0x100e_0244, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_0249, 5); call(Definitions.sys_check_available_stack_size, 0x8_5b04); /* call 0x10165d52 */
            ii(0x100e_024e, 1); push(ebx);                              /* push ebx */
            ii(0x100e_024f, 1); push(ecx);                              /* push ecx */
            ii(0x100e_0250, 1); push(esi);                              /* push esi */
            ii(0x100e_0251, 1); push(edi);                              /* push edi */
            ii(0x100e_0252, 1); push(ebp);                              /* push ebp */
            ii(0x100e_0253, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0255, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_025b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_025e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_0261, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_0266, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_0269, 5); call(0x1008_8a84, -0x5_77ea);           /* call 0x10088a84 */
            ii(0x100e_026e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_0271, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_0274, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_0277, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_027a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_027c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_027d, 1); pop(edi);                               /* pop edi */
            ii(0x100e_027e, 1); pop(esi);                               /* pop esi */
            ii(0x100e_027f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_0280, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_0281, 1); ret();                                  /* ret */
        }
    }
}
