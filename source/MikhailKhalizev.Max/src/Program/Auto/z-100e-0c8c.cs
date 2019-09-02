using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0c8c-55bfd39")]
        public void Method_100e_0c8c()
        {
            ii(0x100e_0c8c, 5); push(0x20);                             /* push 0x20 */
            ii(0x100e_0c91, 5); call(Definitions.sys_check_available_stack_size, 0x8_50bc); /* call 0x10165d52 */
            ii(0x100e_0c96, 1); push(ecx);                              /* push ecx */
            ii(0x100e_0c97, 1); push(esi);                              /* push esi */
            ii(0x100e_0c98, 1); push(edi);                              /* push edi */
            ii(0x100e_0c99, 1); push(ebp);                              /* push ebp */
            ii(0x100e_0c9a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0c9c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_0ca2, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100e_0ca5, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100e_0ca8, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100e_0cab, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x100e_0cae, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100e_0cb1, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_0cb4, 5); call(0x1013_a427, 0x5_976e);            /* call 0x1013a427 */
            ii(0x100e_0cb9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0cbb, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_0cbc, 1); pop(edi);                               /* pop edi */
            ii(0x100e_0cbd, 1); pop(esi);                               /* pop esi */
            ii(0x100e_0cbe, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_0cbf, 1); ret();                                  /* ret */
        }
    }
}
