using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("856f19fa-7dd3-41d1-b61d-87063ba4b6ad")]
        public void Method_0000_ea68()
        {
            ii(0xea68, 4);    cmp(memb_a16[ss, bp + 0x12], -0x1 /* 0xff */); /* cmp byte [bp+0x12], 0xff */
            ii(0xea6c, 2);    if(jnzw_func(0xea4b, -0x23)) return;      /* jnz 0xea4b */
            ii(0xea6e, 3);    callw(0xe88f, -0x1e2);                    /* call 0xe88f */
            ii(0xea71, 3);    callw(0xea4e, -0x26);                     /* call 0xea4e */
            ii(0xea74, 2);    if(jnzw(0xea7d, 0x7)) goto l_0xea7d;      /* jnz 0xea7d */
            ii(0xea76, 4);    or(memb_a16[ds, bx + 0x26], 0x40);        /* or byte [bx+0x26], 0x40 */
        l_0xea7a:
            ii(0xea7a, 3);    if(jmpw_func(0xf00d, 0x590)) return;      /* jmp 0xf00d */
        l_0xea7d:
            ii(0xea7d, 3);    callw(0xe863, -0x21d);                    /* call 0xe863 */
            ii(0xea80, 4);    test(memb_a16[ds, bx + 0x26], 0x40);      /* test byte [bx+0x26], 0x40 */
            ii(0xea84, 2);    if(jnzw(0xea7a, -0xc)) goto l_0xea7a;     /* jnz 0xea7a */
            ii(0xea86, 4);    dec(memb_a16[ds, 0x10ed]);                /* dec byte [0x10ed] */
            ii(0xea8a, 2);    jmpw(0xea7a, -0x12); goto l_0xea7a;       /* jmp 0xea7a */
        }
    }
}
