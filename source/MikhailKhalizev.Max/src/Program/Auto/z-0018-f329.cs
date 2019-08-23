using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_f329-eb3d953f")]
        public void Method_0018_f329()
        {
            ii(0x18_f329, 4); mov(ax, memw_a32[es, edi]);               /* mov ax, [es:edi] */
            ii(0x18_f32d, 4); and(ax, memw[ds, 0xdf2]);                 /* and ax, [0xdf2] */
            ii(0x18_f331, 4); cmp(ax, memw[ds, 0xdf2]);                 /* cmp ax, [0xdf2] */
            ii(0x18_f335, 2); if(jnz_func(0x18_f2c0, -0x77)) return;    /* jnz 0xf2c0 */
            ii(0x18_f337, 4); add(edi, 0x4);                            /* add edi, 0x4 */
        }
    }
}
