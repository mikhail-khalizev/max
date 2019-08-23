using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0118-585dc15b")]
        public void Method_100e_0118()
        {
            ii(0x100e_0118, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_011d, 5); call(Definitions.sys_check_available_stack_size, 0x8_5c30); /* call 0x10165d52 */
            ii(0x100e_0122, 1); push(ebx);                              /* push ebx */
            ii(0x100e_0123, 1); push(ecx);                              /* push ecx */
            ii(0x100e_0124, 1); push(esi);                              /* push esi */
            ii(0x100e_0125, 1); push(edi);                              /* push edi */
            ii(0x100e_0126, 1); push(ebp);                              /* push ebp */
            ii(0x100e_0127, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0129, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_012f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_0132, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_0135, 5); mov(ebx, 0x101b_38d0);                  /* mov ebx, 0x101b38d0 */
            ii(0x100e_013a, 5); mov(edx, 0x5d);                         /* mov edx, 0x5d */
            ii(0x100e_013f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_0142, 5); call(Definitions.sys_call_dtor_arr_v2, 0x8_5e99); /* call 0x10165fe0 */
            ii(0x100e_0147, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_014a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_014d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_014f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_0150, 1); pop(edi);                               /* pop edi */
            ii(0x100e_0151, 1); pop(esi);                               /* pop esi */
            ii(0x100e_0152, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_0153, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_0154, 1); ret();                                  /* ret */
        }
    }
}
