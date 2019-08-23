using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xa3fd-11d8ab56")]
        public void Method_0000_a3fd()
        {
            ii(0xa3fd, 1);    push(ss);                                 /* push ss */
            ii(0xa3fe, 1);    pop(ds);                                  /* pop ds */
            ii(0xa3ff, 2);    push(0x20);                               /* push 0x20 */
            ii(0xa401, 3);    call(0x589d, -0x4b67);                    /* call 0x589d */
            ii(0xa404, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xa406, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xa408, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xa40a, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xa40c, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xa40e, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
        }
    }
}
