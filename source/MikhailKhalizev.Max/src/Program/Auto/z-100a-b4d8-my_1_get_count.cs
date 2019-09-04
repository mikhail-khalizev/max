using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b4d8-19c69791")]
        public void my_1_get_count()
        {
            ii(0x100a_b4d8, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_b4dd, 5); call(Definitions.sys_check_available_stack_size, 0xb_a870); /* call 0x10165d52 */
            ii(0x100a_b4e2, 1); push(ebx);                              /* push ebx */
            ii(0x100a_b4e3, 1); push(ecx);                              /* push ecx */
            ii(0x100a_b4e4, 1); push(edx);                              /* push edx */
            ii(0x100a_b4e5, 1); push(esi);                              /* push esi */
            ii(0x100a_b4e6, 1); push(edi);                              /* push edi */
            ii(0x100a_b4e7, 1); push(ebp);                              /* push ebp */
            ii(0x100a_b4e8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b4ea, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100a_b4f0, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_b4f3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_b4f6, 4); mov(ax, memw[ds, eax + 4]);             /* mov ax, [eax+0x4] */
            ii(0x100a_b4fa, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_b4fd, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_b500, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b502, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_b503, 1); pop(edi);                               /* pop edi */
            ii(0x100a_b504, 1); pop(esi);                               /* pop esi */
            ii(0x100a_b505, 1); pop(edx);                               /* pop edx */
            ii(0x100a_b506, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_b507, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_b508, 1); ret();                                  /* ret */
        }
    }
}
