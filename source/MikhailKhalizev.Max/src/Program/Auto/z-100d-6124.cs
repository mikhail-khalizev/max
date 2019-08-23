using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_6124-b70b8a0f")]
        public void Method_100d_6124()
        {
            ii(0x100d_6124, 1); push(ebx);                              /* push ebx */
            ii(0x100d_6125, 1); push(ecx);                              /* push ecx */
            ii(0x100d_6126, 1); push(edx);                              /* push edx */
            ii(0x100d_6127, 1); push(esi);                              /* push esi */
            ii(0x100d_6128, 1); push(edi);                              /* push edi */
            ii(0x100d_6129, 1); push(ebp);                              /* push ebp */
            ii(0x100d_612a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_612c, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100d_6132, 4); mov(memb[ss, ebp - 0x4], 0);            /* mov byte [ebp-0x4], 0x0 */
            ii(0x100d_6136, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x100d_6139, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_613b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_613c, 1); pop(edi);                               /* pop edi */
            ii(0x100d_613d, 1); pop(esi);                               /* pop esi */
            ii(0x100d_613e, 1); pop(edx);                               /* pop edx */
            ii(0x100d_613f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_6140, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_6141, 1); ret();                                  /* ret */
        }
    }
}
