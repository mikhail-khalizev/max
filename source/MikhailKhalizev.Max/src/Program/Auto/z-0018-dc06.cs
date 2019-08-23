using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_dc06-8efff696")]
        public void Method_0018_dc06()
        {
            ii(0x18_dc06, 1); cli();                                    /* cli */
            ii(0x18_dc07, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x18_dc0a, 1); stosw_a16();                              /* stosw */
            ii(0x18_dc0b, 3); mov(ax, memw_a16[ss, bp + 0]);            /* mov ax, [bp] */
            ii(0x18_dc0e, 1); stosw_a16();                              /* stosw */
            ii(0x18_dc0f, 3); mov(al, memb_a16[ss, bp + 0x2]);          /* mov al, [bp+0x2] */
            ii(0x18_dc12, 3); mov(ah, memb_a16[ss, bp + 0x8]);          /* mov ah, [bp+0x8] */
            ii(0x18_dc15, 1); stosw_a16();                              /* stosw */
            ii(0x18_dc16, 3); mov(al, memb_a16[ss, bp + 0x9]);          /* mov al, [bp+0x9] */
            ii(0x18_dc19, 2); and(al, 0xf0);                            /* and al, 0xf0 */
            ii(0x18_dc1b, 3); mov(ah, memb_a16[ss, bp + 0x6]);          /* mov ah, [bp+0x6] */
            ii(0x18_dc1e, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x18_dc21, 2); or(al, ah);                               /* or al, ah */
            ii(0x18_dc23, 3); mov(ah, memb_a16[ss, bp + 0x3]);          /* mov ah, [bp+0x3] */
            ii(0x18_dc26, 1); stosw_a16();                              /* stosw */
            ii(0x18_dc27, 1); retw();                                   /* ret */
        }
    }
}
