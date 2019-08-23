using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_ee9a-25a2c09")]
        public void /* sys_mve */ Method_1018_ee9a()
        {
            ii(0x1018_ee9a, 4); mov(cx, memw[ds, eax + 0xc]);           /* mov cx, [eax+0xc] */
        }
    }
}
