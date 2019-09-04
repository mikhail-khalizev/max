using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c5dc-3ced5c35")]
        public void Method_1009_c5dc()
        {
            ii(0x1009_c5dc, 5); push(0x28);                             /* push 0x28 */
            ii(0x1009_c5e1, 5); call(Definitions.sys_check_available_stack_size, 0xc_976c); /* call 0x10165d52 */
            ii(0x1009_c5e6, 1); push(ebx);                              /* push ebx */
            ii(0x1009_c5e7, 1); push(ecx);                              /* push ecx */
            ii(0x1009_c5e8, 1); push(esi);                              /* push esi */
            ii(0x1009_c5e9, 1); push(edi);                              /* push edi */
            ii(0x1009_c5ea, 1); push(ebp);                              /* push ebp */
            ii(0x1009_c5eb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c5ed, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1009_c5f3, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_c5f6, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1009_c5f9, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_c5fc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_c5ff, 5); call(0x1007_6d14, -0x2_58f0);           /* call 0x10076d14 */
            ii(0x1009_c604, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_c607, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1009_c60a, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1009_c60d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_c610, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1009_c613, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1009_c616, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c618, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_c619, 1); pop(edi);                               /* pop edi */
            ii(0x1009_c61a, 1); pop(esi);                               /* pop esi */
            ii(0x1009_c61b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_c61c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_c61d, 1); ret();                                  /* ret */
        }
    }
}
