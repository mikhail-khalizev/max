using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_12e9-eb3d953f")]
        public void Method_0001_12e9()
        {
            ii(0x1_12e9, 4);  mov(ax, memw_a32[es, edi]);              /* mov ax, [es:edi] */
            ii(0x1_12ed, 4);  and(ax, memw[ds, 0xdf2]);                /* and ax, [0xdf2] */
            ii(0x1_12f1, 4);  cmp(ax, memw[ds, 0xdf2]);                /* cmp ax, [0xdf2] */
            ii(0x1_12f5, 2);  if(jnz_func(0x1_1280, -0x77)) return;    /* jnz 0x1280 */
            ii(0x1_12f7, 4);  add(edi, 4);                             /* add edi, 0x4 */
        }
    }
}
