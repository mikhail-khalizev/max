using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_bcc1-69485d42")]
        public void Method_1015_bcc1()
        {
            ii(0x1015_bcc1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_bcc3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_bcc4, 1); popd(edi);                              /* pop edi */
            ii(0x1015_bcc5, 1); popd(esi);                              /* pop esi */
            ii(0x1015_bcc6, 1); popd(edx);                              /* pop edx */
            ii(0x1015_bcc7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_bcc8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_bcc9, 1); retd(); return;                         /* ret */
        }
    }
}
