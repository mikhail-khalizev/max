using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b7b4-f49f31f6")]
        public void Method_100c_b7b4()
        {
            ii(0x100c_b7b4, 5); push(0x20);                             /* push 0x20 */
            ii(0x100c_b7b9, 5); call(Definitions.sys_check_available_stack_size, 0x9_a594); /* call 0x10165d52 */
            ii(0x100c_b7be, 1); push(ebx);                              /* push ebx */
            ii(0x100c_b7bf, 1); push(ecx);                              /* push ecx */
            ii(0x100c_b7c0, 1); push(esi);                              /* push esi */
            ii(0x100c_b7c1, 1); push(edi);                              /* push edi */
            ii(0x100c_b7c2, 1); push(ebp);                              /* push ebp */
            ii(0x100c_b7c3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b7c5, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100c_b7cb, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_b7ce, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x100c_b7d1, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100c_b7d4, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_b7d7, 3); mov(memb[ds, edx + 0x23], al);          /* mov [edx+0x23], al */
            ii(0x100c_b7da, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b7dc, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_b7dd, 1); pop(edi);                               /* pop edi */
            ii(0x100c_b7de, 1); pop(esi);                               /* pop esi */
            ii(0x100c_b7df, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_b7e0, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_b7e1, 1); ret();                                  /* ret */
        }
    }
}
