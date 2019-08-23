using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_4550-79dfaf42")]
        public void Method_100a_4550()
        {
            ii(0x100a_4550, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_4555, 5); call(Definitions.sys_check_available_stack_size, 0xc_17f8); /* call 0x10165d52 */
            ii(0x100a_455a, 1); push(ebx);                              /* push ebx */
            ii(0x100a_455b, 1); push(ecx);                              /* push ecx */
            ii(0x100a_455c, 1); push(esi);                              /* push esi */
            ii(0x100a_455d, 1); push(edi);                              /* push edi */
            ii(0x100a_455e, 1); push(ebp);                              /* push ebp */
            ii(0x100a_455f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_4561, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_4567, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_456a, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_456d, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_4570, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_4573, 3); add(eax, 0x28);                         /* add eax, 0x28 */
            ii(0x100a_4576, 5); call(0x1008_ab1c, -0x1_9a5f);           /* call 0x1008ab1c */
            ii(0x100a_457b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_457d, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_457e, 1); pop(edi);                               /* pop edi */
            ii(0x100a_457f, 1); pop(esi);                               /* pop esi */
            ii(0x100a_4580, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_4581, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_4582, 1); ret();                                  /* ret */
        }
    }
}
