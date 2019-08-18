using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_85f9-69485d42")]
        public void Method_1012_85f9()
        {
            ii(0x1012_85f9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_85fb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_85fc, 1); popd(edi);                              /* pop edi */
            ii(0x1012_85fd, 1); popd(esi);                              /* pop esi */
            ii(0x1012_85fe, 1); popd(edx);                              /* pop edx */
            ii(0x1012_85ff, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_8600, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_8601, 1); retd(); return;                         /* ret */
        }
    }
}
