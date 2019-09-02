using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_3031-53bdf869")]
        public void Method_100a_3031()
        {
            ii(0x100a_3031, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_3036, 5); call(Definitions.sys_check_available_stack_size, 0xc_2d17); /* call 0x10165d52 */
            ii(0x100a_303b, 1); push(ecx);                              /* push ecx */
            ii(0x100a_303c, 1); push(esi);                              /* push esi */
            ii(0x100a_303d, 1); push(edi);                              /* push edi */
            ii(0x100a_303e, 1); push(ebp);                              /* push ebp */
            ii(0x100a_303f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_3041, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_3047, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_304a, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100a_304d, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100a_3050, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_3052, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_3053, 1); pop(edi);                               /* pop edi */
            ii(0x100a_3054, 1); pop(esi);                               /* pop esi */
            ii(0x100a_3055, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_3056, 1); ret();                                  /* ret */
        }
    }
}
