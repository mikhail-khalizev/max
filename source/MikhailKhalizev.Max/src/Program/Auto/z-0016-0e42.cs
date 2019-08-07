using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d5ca1c20-1972-447a-844f-ad4b6a1580d9")]
        public void Method_0016_0e42()
        {
            ii(0x16_0e42, 4); enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x16_0e46, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x16_0e49, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x16_0e4c, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x16_0e4f, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x16_0e52, 3); add(ax, memw_a16[ss, bp + 0xa]);          /* add ax, [bp+0xa] */
            ii(0x16_0e55, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x16_0e58, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x16_0e5b, 2); jmpw(0x16_0e7a, 0x1d); goto l_0x16_0e7a;  /* jmp 0xe7a */
        l_0x16_0e5d:
            ii(0x16_0e5d, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x16_0e60, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x16_0e63, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x16_0e66, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x16_0e69, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x16_0e6c, 1); nop();                                    /* nop */
            ii(0x16_0e6d, 1); pushw(cs);                                /* push cs */
            ii(0x16_0e6e, 3); callw(0x16_0f5f, 0xee);                   /* call 0xf5f */
            ii(0x16_0e71, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x16_0e74, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x16_0e77, 3); add(memw_a16[ss, bp - 0x8], ax);          /* add [bp-0x8], ax */
        l_0x16_0e7a:
            ii(0x16_0e7a, 3); dec(memw_a16[ss, bp + 0xc]);              /* dec word [bp+0xc] */
            ii(0x16_0e7d, 2); if(jnzw(0x16_0e5d, -0x22)) goto l_0x16_0e5d; /* jnz 0xe5d */
            ii(0x16_0e7f, 1); leavew();                                 /* leave */
            ii(0x16_0e80, 1); retfw(); return;                          /* retf */
        }
    }
}
