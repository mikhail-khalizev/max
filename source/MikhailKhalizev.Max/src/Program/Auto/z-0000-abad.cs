using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1bf3093b-3e7f-4d24-a64f-2c1124f4e316")]
        public void Method_0000_abad()
        {
            ii(0xabad, 1);    pushw(ss);                                /* push ss */
            ii(0xabae, 1);    popw(ds);                                 /* pop ds */
            ii(0xabaf, 2);    pushw(0x20);                              /* push 0x20 */
            ii(0xabb1, 3);    callw(0x604d, -0x4b67);                   /* call 0x604d */
            ii(0xabb4, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xabb6, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xabb8, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xabba, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xabbc, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xabbe, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
        }
    }
}
