using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_5094-44b9eb0e")]
        public void Method_100d_5094()
        {
            ii(0x100d_5094, 1); push(ebx);                              /* push ebx */
            ii(0x100d_5095, 1); push(ecx);                              /* push ecx */
            ii(0x100d_5096, 1); push(edx);                              /* push edx */
            ii(0x100d_5097, 1); push(esi);                              /* push esi */
            ii(0x100d_5098, 1); push(edi);                              /* push edi */
            ii(0x100d_5099, 1); push(ebp);                              /* push ebp */
            ii(0x100d_509a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_509c, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100d_50a2, 4); mov(memb[ss, ebp - 0x4], 0x1);          /* mov byte [ebp-0x4], 0x1 */
            ii(0x100d_50a6, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x100d_50a9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_50ab, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_50ac, 1); pop(edi);                               /* pop edi */
            ii(0x100d_50ad, 1); pop(esi);                               /* pop esi */
            ii(0x100d_50ae, 1); pop(edx);                               /* pop edx */
            ii(0x100d_50af, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_50b0, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_50b1, 1); ret();                                  /* ret */
        }
    }
}
