using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_28ae-afe2ff5d")]
        public void Method_100a_28ae()
        {
            ii(0x100a_28ae, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_28b3, 5); call(Definitions.sys_check_available_stack_size, 0xc_349a); /* call 0x10165d52 */
            ii(0x100a_28b8, 1); push(ebx);                              /* push ebx */
            ii(0x100a_28b9, 1); push(ecx);                              /* push ecx */
            ii(0x100a_28ba, 1); push(esi);                              /* push esi */
            ii(0x100a_28bb, 1); push(edi);                              /* push edi */
            ii(0x100a_28bc, 1); push(ebp);                              /* push ebp */
            ii(0x100a_28bd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_28bf, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_28c5, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_28c8, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_28cb, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_28cf, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100a_28d2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_28d4, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_28d5, 1); pop(edi);                               /* pop edi */
            ii(0x100a_28d6, 1); pop(esi);                               /* pop esi */
            ii(0x100a_28d7, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_28d8, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_28d9, 1); ret();                                  /* ret */
        }
    }
}
