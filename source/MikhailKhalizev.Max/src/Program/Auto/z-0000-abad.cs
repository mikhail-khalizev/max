using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xabad-11d8ab56")]
        public void Method_0000_abad()
        {
            ii(0xabad, 1);    push(ss);                                 /* push ss */
            ii(0xabae, 1);    pop(ds);                                  /* pop ds */
            ii(0xabaf, 2);    push(0x20);                               /* push 0x20 */
            ii(0xabb1, 3);    call(0x604d, -0x4b67);                    /* call 0x604d */
            ii(0xabb4, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xabb6, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xabb8, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xabba, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xabbc, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xabbe, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
        }
    }
}
