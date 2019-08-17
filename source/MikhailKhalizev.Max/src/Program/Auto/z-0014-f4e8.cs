using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0e350242-8a65-4e16-99dd-093078a2392c")]
        public void Method_0014_f4e8()
        {
            ii(0x14_f4e8, 3); if(callw_up(0x14_fa00, 0x515)) return;    /* call 0xfa00 */
            ii(0x14_f4eb, 1); pushw(ss);                                /* push ss */
            ii(0x14_f4ec, 3); callw(0x14_fa00, 0x511);                  /* call 0xfa00 */
            ii(0x14_f4ef, 1); popw(ss);                                 /* pop ss */
            ii(0x14_f4f0, 3); callw(0x14_fa00, 0x50d);                  /* call 0xfa00 */
            ii(0x14_f4f3, 2); sbb(al, ch);                              /* sbb al, ch */
            ii(0x14_f4f5, 2); or(memw_a16[ds, di], ax);                 /* or [di], ax */
            ii(0x14_f4f7, 2); sbb(ax, bp);                              /* sbb ax, bp */
            ii(0x14_f4f9, 3); add(ax, 0x1a05);                          /* add ax, 0x1a05 */
            ii(0x14_f4fc, 3); callw(0x14_fa00, 0x501);                  /* call 0xfa00 */
            ii(0x14_f4ff, 2); sbb(bp, ax);                              /* sbb bp, ax */
            ii(0x14_f501, 1); std();                                    /* std */
            ii(0x14_f502, 2); add(al, 0x1c);                            /* add al, 0x1c */
            ii(0x14_f504, 3); callw(0x14_fa00, 0x4f9);                  /* call 0xfa00 */
            ii(0x14_f507, 3); sbb(ax, 0xf5e8);                          /* sbb ax, 0xf5e8 */
            ii(0x14_f50a, 2); add(al, 0x1e);                            /* add al, 0x1e */
            ii(0x14_f50c, 3); callw(0x14_fa00, 0x4f1);                  /* call 0xfa00 */
            ii(0x14_f50f, 1); popw(ds);                                 /* pop ds */
            ii(0x14_f510, 3); callw(0x14_fa00, 0x4ed);                  /* call 0xfa00 */
            ii(0x14_f513, 2); and(al, ch);                              /* and al, ch */
            ii(0x14_f515, 3); if(jmpw_func(0x15_161c, 0x2104)) return;  /* jmp 0x161c */
        }
    }
}
