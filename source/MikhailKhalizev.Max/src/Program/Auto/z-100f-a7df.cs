using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e9502ae4-819b-4f8a-9698-65158108bcb0")]
        public void Method_100f_a7df()
        {
            ii(0x100f_a7df, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_a7e1, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_a7e2, 1); popd(edi);                              /* pop edi */
            ii(0x100f_a7e3, 1); popd(esi);                              /* pop esi */
            ii(0x100f_a7e4, 1); popd(edx);                              /* pop edx */
            ii(0x100f_a7e5, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_a7e6, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_a7e7, 1); retd(); return;                         /* ret */
        }
    }
}
