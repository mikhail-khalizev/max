using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1eb742af-6363-44cf-9b60-c52a9a628082")]
        public void Method_0018_f329()
        {
            ii(0x18_f329, 4); mov(ax, memw_a32[es, edi]);               /* mov ax, [es:edi] */
            ii(0x18_f32d, 4); and(ax, memw_a16[ds, 0xdf2]);             /* and ax, [0xdf2] */
            ii(0x18_f331, 4); cmp(ax, memw_a16[ds, 0xdf2]);             /* cmp ax, [0xdf2] */
            ii(0x18_f335, 2); if(jnzw_func(0x18_f2c0, -0x77)) return;   /* jnz 0xf2c0 */
            ii(0x18_f337, 4); add(edi, 0x4);                            /* add edi, 0x4 */
        }
    }
}
