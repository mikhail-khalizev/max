using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_ee80-14de11")]
        public void /* sys_mve */ Method_1018_ee80()
        {
            ii(0x1018_ee80, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
        }
    }
}
