using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_94b6-34ee9c26")]
        public void Method_1011_94b6()
        {
            ii(0x1011_94b6, 5); push(0x24);                             /* push 0x24 */
            ii(0x1011_94bb, 5); call(Definitions.sys_check_available_stack_size, 0x4_c892); /* call 0x10165d52 */
            ii(0x1011_94c0, 1); push(ebx);                              /* push ebx */
            ii(0x1011_94c1, 1); push(ecx);                              /* push ecx */
            ii(0x1011_94c2, 1); push(edx);                              /* push edx */
            ii(0x1011_94c3, 1); push(esi);                              /* push esi */
            ii(0x1011_94c4, 1); push(edi);                              /* push edi */
            ii(0x1011_94c5, 1); push(ebp);                              /* push ebp */
            ii(0x1011_94c6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_94c8, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_94ce, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_94d1, 5); mov(eax, 0x101c_52fe);                  /* mov eax, 0x101c52fe */
            ii(0x1011_94d6, 5); call(0x1012_0d64, 0x7889);              /* call 0x10120d64 */
            ii(0x1011_94db, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_94de, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_94e1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_94e3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_94e4, 1); pop(edi);                               /* pop edi */
            ii(0x1011_94e5, 1); pop(esi);                               /* pop esi */
            ii(0x1011_94e6, 1); pop(edx);                               /* pop edx */
            ii(0x1011_94e7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_94e8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_94e9, 1); ret();                                  /* ret */
        }
    }
}
