using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_32f9-eb3d953f")]
        public void Method_0001_32f9()
        {
            ii(0x1_32f9, 4);  mov(ax, memw_a32[es, edi]);              /* mov ax, [es:edi] */
            ii(0x1_32fd, 4);  and(ax, memw[ds, 0xdf2]);                /* and ax, [0xdf2] */
            ii(0x1_3301, 4);  cmp(ax, memw[ds, 0xdf2]);                /* cmp ax, [0xdf2] */
            ii(0x1_3305, 2);  if(jnz_func(0x1_3290, -0x77)) return;    /* jnz 0x3290 */
            ii(0x1_3307, 4);  add(edi, 4);                             /* add edi, 0x4 */
        }
    }
}
