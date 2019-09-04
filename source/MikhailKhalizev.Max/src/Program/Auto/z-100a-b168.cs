using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b168-dc585a6b")]
        public void Method_100a_b168()
        {
            ii(0x100a_b168, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_b16d, 5); call(Definitions.sys_check_available_stack_size, 0xb_abe0); /* call 0x10165d52 */
            ii(0x100a_b172, 1); push(ebx);                              /* push ebx */
            ii(0x100a_b173, 1); push(ecx);                              /* push ecx */
            ii(0x100a_b174, 1); push(esi);                              /* push esi */
            ii(0x100a_b175, 1); push(edi);                              /* push edi */
            ii(0x100a_b176, 1); push(ebp);                              /* push ebp */
            ii(0x100a_b177, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b179, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100a_b17f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_b182, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x100a_b185, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100a_b188, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_b18b, 3); mov(memb[ds, edx + 6], al);             /* mov [edx+0x6], al */
            ii(0x100a_b18e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b190, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_b191, 1); pop(edi);                               /* pop edi */
            ii(0x100a_b192, 1); pop(esi);                               /* pop esi */
            ii(0x100a_b193, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_b194, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_b195, 1); ret();                                  /* ret */
        }
    }
}
