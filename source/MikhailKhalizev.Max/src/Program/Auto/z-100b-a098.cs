using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_a098-7777aa89")]
        public void Method_100b_a098()
        {
            ii(0x100b_a098, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_a09d, 5); call(Definitions.sys_check_available_stack_size, 0xa_bcb0); /* call 0x10165d52 */
            ii(0x100b_a0a2, 1); push(ebx);                              /* push ebx */
            ii(0x100b_a0a3, 1); push(ecx);                              /* push ecx */
            ii(0x100b_a0a4, 1); push(edx);                              /* push edx */
            ii(0x100b_a0a5, 1); push(esi);                              /* push esi */
            ii(0x100b_a0a6, 1); push(edi);                              /* push edi */
            ii(0x100b_a0a7, 1); push(ebp);                              /* push ebp */
            ii(0x100b_a0a8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_a0aa, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100b_a0b0, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100b_a0b3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_a0b6, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100b_a0b9, 5); call(0x100c_b000, 0x1_0f42);            /* call 0x100cb000 */
            ii(0x100b_a0be, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_a0c1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_a0c4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_a0c6, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_a0c7, 1); pop(edi);                               /* pop edi */
            ii(0x100b_a0c8, 1); pop(esi);                               /* pop esi */
            ii(0x100b_a0c9, 1); pop(edx);                               /* pop edx */
            ii(0x100b_a0ca, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_a0cb, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_a0cc, 1); ret();                                  /* ret */
        }
    }
}
