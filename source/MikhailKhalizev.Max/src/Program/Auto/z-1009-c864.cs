using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c864-cde3e3a3")]
        public void Method_1009_c864()
        {
            ii(0x1009_c864, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_c869, 5); call(Definitions.sys_check_available_stack_size, 0xc_94e4); /* call 0x10165d52 */
            ii(0x1009_c86e, 1); push(ebx);                              /* push ebx */
            ii(0x1009_c86f, 1); push(ecx);                              /* push ecx */
            ii(0x1009_c870, 1); push(edx);                              /* push edx */
            ii(0x1009_c871, 1); push(esi);                              /* push esi */
            ii(0x1009_c872, 1); push(edi);                              /* push edi */
            ii(0x1009_c873, 1); push(ebp);                              /* push ebp */
            ii(0x1009_c874, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c876, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_c87c, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_c87f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_c882, 3); add(eax, 0x77);                         /* add eax, 0x77 */
            ii(0x1009_c885, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c888, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c88b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c88d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_c88e, 1); pop(edi);                               /* pop edi */
            ii(0x1009_c88f, 1); pop(esi);                               /* pop esi */
            ii(0x1009_c890, 1); pop(edx);                               /* pop edx */
            ii(0x1009_c891, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_c892, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_c893, 1); ret();                                  /* ret */
        }
    }
}
