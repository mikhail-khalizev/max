using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b2a8-fd19bd90")]
        public void Method_100a_b2a8()
        {
            ii(0x100a_b2a8, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_b2ad, 5); call(Definitions.sys_check_available_stack_size, 0xb_aaa0); /* call 0x10165d52 */
            ii(0x100a_b2b2, 1); push(ebx);                              /* push ebx */
            ii(0x100a_b2b3, 1); push(ecx);                              /* push ecx */
            ii(0x100a_b2b4, 1); push(esi);                              /* push esi */
            ii(0x100a_b2b5, 1); push(edi);                              /* push edi */
            ii(0x100a_b2b6, 1); push(ebp);                              /* push ebp */
            ii(0x100a_b2b7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b2b9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_b2bf, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_b2c2, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_b2c5, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_b2c8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_b2cb, 5); call(0x1013_ac7d, 0x8_f9ad);            /* call 0x1013ac7d */
            ii(0x100a_b2d0, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_b2d3, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_b2d6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b2d8, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_b2d9, 1); pop(edi);                               /* pop edi */
            ii(0x100a_b2da, 1); pop(esi);                               /* pop esi */
            ii(0x100a_b2db, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_b2dc, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_b2dd, 1); ret();                                  /* ret */
        }
    }
}
