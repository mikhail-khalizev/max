using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6e2b77b3-5301-4918-80fd-0239c09c22ce")]
        public void Method_0000_a3fd()
        {
            ii(0xa3fd, 1);    pushw(ss);                                /* push ss */
            ii(0xa3fe, 1);    popw(ds);                                 /* pop ds */
            ii(0xa3ff, 2);    pushw(0x20);                              /* push 0x20 */
            ii(0xa401, 3);    callw(0x589d, -0x4b67);                   /* call 0x589d */
            ii(0xa404, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa406, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa408, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa40a, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa40c, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa40e, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
        }
    }
}
