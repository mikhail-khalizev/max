using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_1ce1-58c742ed")]
        public void /* sys */ Method_1018_1ce1()
        {
            ii(0x1018_1ce1, 4); mov(memb[ds, eax + 8], 0);              /* mov byte [eax+0x8], 0x0 */
            ii(0x1018_1ce5, 1); ret();                                  /* ret */
        }
    }
}
