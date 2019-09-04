using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_07bc-e1a9421c")]
        public void Method_100e_07bc()
        {
            ii(0x100e_07bc, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_07c1, 5); call(Definitions.sys_check_available_stack_size, 0x8_558c); /* call 0x10165d52 */
            ii(0x100e_07c6, 1); push(ebx);                              /* push ebx */
            ii(0x100e_07c7, 1); push(ecx);                              /* push ecx */
            ii(0x100e_07c8, 1); push(esi);                              /* push esi */
            ii(0x100e_07c9, 1); push(edi);                              /* push edi */
            ii(0x100e_07ca, 1); push(ebp);                              /* push ebp */
            ii(0x100e_07cb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_07cd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_07d3, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_07d6, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100e_07d9, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100e_07dc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_07df, 5); call(0x1013_acc5, 0x5_a4e1);            /* call 0x1013acc5 */
            ii(0x100e_07e4, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100e_07e7, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_07ea, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_07ec, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_07ed, 1); pop(edi);                               /* pop edi */
            ii(0x100e_07ee, 1); pop(esi);                               /* pop esi */
            ii(0x100e_07ef, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_07f0, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_07f1, 1); ret();                                  /* ret */
        }
    }
}
