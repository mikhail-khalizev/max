using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_f4e8-3940350")]
        public void Method_0018_f4e8()
        {
            ii(0x18_f4e8, 3);  if(call_up(0x18_fa00, 0x515)) return;   /* call 0xfa00 */
            ii(0x18_f4eb, 1);  push(ss);                               /* push ss */
            ii(0x18_f4ec, 3);  call(0x18_fa00, 0x511);                 /* call 0xfa00 */
            ii(0x18_f4ef, 1);  pop(ss);                                /* pop ss */
            ii(0x18_f4f0, 3);  call(0x18_fa00, 0x50d);                 /* call 0xfa00 */
            ii(0x18_f4f3, 2);  sbb(al, ch);                            /* sbb al, ch */
            ii(0x18_f4f5, 2);  or(memw[ds, di], ax);                   /* or [di], ax */
            ii(0x18_f4f7, 2);  sbb(ax, bp);                            /* sbb ax, bp */
            ii(0x18_f4f9, 3);  add(ax, 0x1a05);                        /* add ax, 0x1a05 */
            ii(0x18_f4fc, 3);  call(0x18_fa00, 0x501);                 /* call 0xfa00 */
            ii(0x18_f4ff, 2);  sbb(bp, ax);                            /* sbb bp, ax */
            ii(0x18_f501, 1);  std();                                  /* std */
            ii(0x18_f502, 2);  add(al, 0x1c);                          /* add al, 0x1c */
            ii(0x18_f504, 3);  call(0x18_fa00, 0x4f9);                 /* call 0xfa00 */
            ii(0x18_f507, 3);  sbb(ax, 0xf5e8);                        /* sbb ax, 0xf5e8 */
            ii(0x18_f50a, 2);  add(al, 0x1e);                          /* add al, 0x1e */
            ii(0x18_f50c, 3);  call(0x18_fa00, 0x4f1);                 /* call 0xfa00 */
            ii(0x18_f50f, 1);  pop(ds);                                /* pop ds */
            ii(0x18_f510, 3);  call(0x18_fa00, 0x4ed);                 /* call 0xfa00 */
            ii(0x18_f513, 2);  and(al, ch);                            /* and al, ch */
            ii(0x18_f515, 3);  jmp_func(0x19_161c, 0x2104);            /* jmp 0x161c */
        }
    }
}
