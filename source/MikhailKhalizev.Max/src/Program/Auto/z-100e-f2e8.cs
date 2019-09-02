using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_f2e8-53f06772")]
        public void Method_100e_f2e8()
        {
            ii(0x100e_f2e8, 5); push(0x20);                             /* push 0x20 */
            ii(0x100e_f2ed, 5); call(Definitions.sys_check_available_stack_size, 0x7_6a60); /* call 0x10165d52 */
            ii(0x100e_f2f2, 1); push(ebx);                              /* push ebx */
            ii(0x100e_f2f3, 1); push(ecx);                              /* push ecx */
            ii(0x100e_f2f4, 1); push(esi);                              /* push esi */
            ii(0x100e_f2f5, 1); push(edi);                              /* push edi */
            ii(0x100e_f2f6, 1); push(ebp);                              /* push ebp */
            ii(0x100e_f2f7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_f2f9, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100e_f2ff, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_f302, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x100e_f305, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100e_f308, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100e_f30b, 3); mov(memb[ds, edx + 0x12], al);          /* mov [edx+0x12], al */
            ii(0x100e_f30e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_f310, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_f311, 1); pop(edi);                               /* pop edi */
            ii(0x100e_f312, 1); pop(esi);                               /* pop esi */
            ii(0x100e_f313, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_f314, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_f315, 1); ret();                                  /* ret */
        }
    }
}
