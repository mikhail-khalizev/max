using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b1c8-bbe83605")]
        public void Method_100a_b1c8()
        {
            ii(0x100a_b1c8, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_b1cd, 5); call(Definitions.sys_check_available_stack_size, 0xb_ab80); /* call 0x10165d52 */
            ii(0x100a_b1d2, 1); push(ebx);                              /* push ebx */
            ii(0x100a_b1d3, 1); push(ecx);                              /* push ecx */
            ii(0x100a_b1d4, 1); push(esi);                              /* push esi */
            ii(0x100a_b1d5, 1); push(edi);                              /* push edi */
            ii(0x100a_b1d6, 1); push(ebp);                              /* push ebp */
            ii(0x100a_b1d7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b1d9, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_b1df, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_b1e2, 3); mov(memb[ss, ebp - 0x4], dl);           /* mov [ebp-0x4], dl */
            ii(0x100a_b1e5, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x100a_b1e8, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_b1eb, 3); mov(memb[ds, edx + 0x8], al);           /* mov [edx+0x8], al */
            ii(0x100a_b1ee, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b1f0, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_b1f1, 1); pop(edi);                               /* pop edi */
            ii(0x100a_b1f2, 1); pop(esi);                               /* pop esi */
            ii(0x100a_b1f3, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_b1f4, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_b1f5, 1); ret();                                  /* ret */
        }
    }
}
