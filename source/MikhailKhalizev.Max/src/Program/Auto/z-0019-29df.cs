using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_29df-7985c489")]
        public void Method_0019_29df()
        {
        l_0x19_29df:
            ii(0x19_29df, 2); cmp(si, di);                              /* cmp si, di */
            ii(0x19_29e1, 2); if(jaew(0x19_29f1, 0xe)) goto l_0x19_29f1; /* jae 0x29f1 */
            ii(0x19_29e3, 3); sub(di, 0x4);                             /* sub di, 0x4 */
            ii(0x19_29e6, 2); mov(ax, memw_a16[ds, di]);                /* mov ax, [di] */
            ii(0x19_29e8, 3); or(ax, memw_a16[ds, di + 0x2]);           /* or ax, [di+0x2] */
            ii(0x19_29eb, 2); if(jzw(0x19_29df, -0xe)) goto l_0x19_29df; /* jz 0x29df */
            ii(0x19_29ed, 2); callw_a16_far_ind(ds, di);                /* call far word [di] */
            ii(0x19_29ef, 2); jmpw(0x19_29df, -0x12); goto l_0x19_29df; /* jmp 0x29df */
        l_0x19_29f1:
            ii(0x19_29f1, 1); retw(); return;                           /* ret */
        }
    }
}