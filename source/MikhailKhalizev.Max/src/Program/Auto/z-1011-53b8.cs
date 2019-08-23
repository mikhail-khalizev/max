using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_53b8-402324e6")]
        public void Method_1011_53b8()
        {
            ii(0x1011_53b8, 5); push(0x18);                             /* push 0x18 */
            ii(0x1011_53bd, 5); call(Definitions.sys_check_available_stack_size, 0x5_0990); /* call 0x10165d52 */
            ii(0x1011_53c2, 1); push(ebx);                              /* push ebx */
            ii(0x1011_53c3, 1); push(esi);                              /* push esi */
            ii(0x1011_53c4, 1); push(edi);                              /* push edi */
            ii(0x1011_53c5, 1); push(ebp);                              /* push ebp */
            ii(0x1011_53c6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_53c8, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_53ce, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1011_53d1, 5); call(Definitions.sys_malloc, 0x5_5c08); /* call 0x1016afde */
            ii(0x1011_53d6, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_53d9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_53dc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_53de, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_53df, 1); pop(edi);                               /* pop edi */
            ii(0x1011_53e0, 1); pop(esi);                               /* pop esi */
            ii(0x1011_53e1, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_53e2, 1); ret();                                  /* ret */
        }
    }
}
