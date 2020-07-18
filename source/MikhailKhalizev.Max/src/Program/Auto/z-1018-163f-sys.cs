using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_163f-4b4ec8bc")]
        public void /* sys */ Method_1018_163f()
        {
            ii(0x1018_163f, 1);  popd(es);                             /* pop es */
            ii(0x1018_1640, 1);  pop(edi);                             /* pop edi */
            ii(0x1018_1641, 1);  pop(esi);                             /* pop esi */
            ii(0x1018_1642, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1018_1643, 1);  ret();                                /* ret */
        }
    }
}
