using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_527c-2f7dd9d8")]
        public void Method_100d_527c()
        {
            ii(0x100d_527c, 1); push(ebx);                              /* push ebx */
            ii(0x100d_527d, 1); push(ecx);                              /* push ecx */
            ii(0x100d_527e, 1); push(edx);                              /* push edx */
            ii(0x100d_527f, 1); push(esi);                              /* push esi */
            ii(0x100d_5280, 1); push(edi);                              /* push edi */
            ii(0x100d_5281, 1); push(ebp);                              /* push ebp */
            ii(0x100d_5282, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_5284, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100d_528a, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_528d, 5); mov(edx, 0x101c_35a4);                  /* mov edx, 0x101c35a4 */
            ii(0x100d_5292, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_5295, 5); call(0x100d_4d78, -0x522);              /* call 0x100d4d78 */
            ii(0x100d_529a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_529d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_529f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_52a0, 1); pop(edi);                               /* pop edi */
            ii(0x100d_52a1, 1); pop(esi);                               /* pop esi */
            ii(0x100d_52a2, 1); pop(edx);                               /* pop edx */
            ii(0x100d_52a3, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_52a4, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_52a5, 1); ret();                                  /* ret */
        }
    }
}
