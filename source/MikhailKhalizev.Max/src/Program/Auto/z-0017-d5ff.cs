using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_d5ff-7985c489")]
        public void Method_0017_d5ff()
        {
        l_0x17_d5ff:
            ii(0x17_d5ff, 2); cmp(si, di);                              /* cmp si, di */
            ii(0x17_d601, 2); if(jae(0x17_d611, 0xe)) goto l_0x17_d611; /* jae 0xd611 */
            ii(0x17_d603, 3); sub(di, 4);                               /* sub di, 0x4 */
            ii(0x17_d606, 2); mov(ax, memw[ds, di]);                    /* mov ax, [di] */
            ii(0x17_d608, 3); or(ax, memw[ds, di + 2]);                 /* or ax, [di+0x2] */
            ii(0x17_d60b, 2); if(jz(0x17_d5ff, -0xe)) goto l_0x17_d5ff; /* jz 0xd5ff */
            ii(0x17_d60d, 2); call_far_ind(memw[ds, di]);               /* call far word [di] */
            ii(0x17_d60f, 2); jmp(0x17_d5ff, -0x12); goto l_0x17_d5ff;  /* jmp 0xd5ff */
        l_0x17_d611:
            ii(0x17_d611, 1); ret();                                    /* ret */
        }
    }
}
