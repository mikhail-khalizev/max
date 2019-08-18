using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7b7cb911-6ca2-4891-be5a-77e28acdc9c1")]
        public void Method_0018_aa98()
        {
            ii(0x18_aa98, 4); cmp(memb_a16[ss, bp + 0x12], -0x1 /* 0xff */); /* cmp byte [bp+0x12], 0xff */
            ii(0x18_aa9c, 2); if(jnzw_func(0x18_aa7b, -0x23)) return;   /* jnz 0xaa7b */
            ii(0x18_aa9e, 3); callw(0x18_a8bf, -0x1e2);                 /* call 0xa8bf */
            ii(0x18_aaa1, 3); callw(0x18_aa7e, -0x26);                  /* call 0xaa7e */
            ii(0x18_aaa4, 2); if(jnzw(0x18_aaad, 0x7)) goto l_0x18_aaad; /* jnz 0xaaad */
            ii(0x18_aaa6, 4); or(memb_a16[ds, bx + 0x26], 0x40);        /* or byte [bx+0x26], 0x40 */
        l_0x18_aaaa:
            ii(0x18_aaaa, 3); if(jmpw_func(0x18_b03d, 0x590)) return;   /* jmp 0xb03d */
        l_0x18_aaad:
            ii(0x18_aaad, 3); callw(0x18_a893, -0x21d);                 /* call 0xa893 */
            ii(0x18_aab0, 4); test(memb_a16[ds, bx + 0x26], 0x40);      /* test byte [bx+0x26], 0x40 */
            ii(0x18_aab4, 2); if(jnzw(0x18_aaaa, -0xc)) goto l_0x18_aaaa; /* jnz 0xaaaa */
            ii(0x18_aab6, 4); dec(memb_a16[ds, 0x10ed]);                /* dec byte [0x10ed] */
            ii(0x18_aaba, 2); jmpw(0x18_aaaa, -0x12); goto l_0x18_aaaa; /* jmp 0xaaaa */
        }
    }
}
