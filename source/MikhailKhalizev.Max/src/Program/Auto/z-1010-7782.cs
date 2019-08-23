using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_7782-f3942328")]
        public void Method_1010_7782()
        {
            ii(0x1010_7782, 5); push(0x20);                             /* push 0x20 */
            ii(0x1010_7787, 5); call(Definitions.sys_check_available_stack_size, 0x5_e5c6); /* call 0x10165d52 */
            ii(0x1010_778c, 1); push(ebx);                              /* push ebx */
            ii(0x1010_778d, 1); push(ecx);                              /* push ecx */
            ii(0x1010_778e, 1); push(edx);                              /* push edx */
            ii(0x1010_778f, 1); push(esi);                              /* push esi */
            ii(0x1010_7790, 1); push(edi);                              /* push edi */
            ii(0x1010_7791, 1); push(ebp);                              /* push ebp */
            ii(0x1010_7792, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_7794, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_779a, 7); mov(memd[ss, ebp - 0x4], 0x101c_4da0);  /* mov dword [ebp-0x4], 0x101c4da0 */
            ii(0x1010_77a1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_77a4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_77a6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_77a7, 1); pop(edi);                               /* pop edi */
            ii(0x1010_77a8, 1); pop(esi);                               /* pop esi */
            ii(0x1010_77a9, 1); pop(edx);                               /* pop edx */
            ii(0x1010_77aa, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_77ab, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_77ac, 1); ret();                                  /* ret */
        }
    }
}
