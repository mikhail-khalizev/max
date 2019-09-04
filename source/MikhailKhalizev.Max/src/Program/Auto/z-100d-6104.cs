using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_6104-44b9eb0e")]
        public void Method_100d_6104()
        {
            ii(0x100d_6104, 1); push(ebx);                              /* push ebx */
            ii(0x100d_6105, 1); push(ecx);                              /* push ecx */
            ii(0x100d_6106, 1); push(edx);                              /* push edx */
            ii(0x100d_6107, 1); push(esi);                              /* push esi */
            ii(0x100d_6108, 1); push(edi);                              /* push edi */
            ii(0x100d_6109, 1); push(ebp);                              /* push ebp */
            ii(0x100d_610a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_610c, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100d_6112, 4); mov(memb[ss, ebp - 4], 1);              /* mov byte [ebp-0x4], 0x1 */
            ii(0x100d_6116, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100d_6119, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_611b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_611c, 1); pop(edi);                               /* pop edi */
            ii(0x100d_611d, 1); pop(esi);                               /* pop esi */
            ii(0x100d_611e, 1); pop(edx);                               /* pop edx */
            ii(0x100d_611f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_6120, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_6121, 1); ret();                                  /* ret */
        }
    }
}
