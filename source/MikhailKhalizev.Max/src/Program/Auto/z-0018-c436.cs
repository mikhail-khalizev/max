using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b37cea7a-9ff0-4a85-85f4-278d3ad6e6f0")]
        public void Method_0018_c436()
        {
            ii(0x18_c436, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x18_c43a, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_c43c, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x18_c43e, 3); callw(0x18_bddb, -0x666);                 /* call 0xbddb */
            ii(0x18_c441, 1); popw(bx);                                 /* pop bx */
            ii(0x18_c442, 1); popw(bx);                                 /* pop bx */
            ii(0x18_c443, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x18_c446, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x18_c449, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x18_c44b, 2); if(jnzw(0x18_c451, 0x4)) goto l_0x18_c451; /* jnz 0xc451 */
            ii(0x18_c44d, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x18_c44f, 2); jmpw(0x18_c4b5, 0x64); goto l_0x18_c4b5;  /* jmp 0xc4b5 */
        l_0x18_c451:
            ii(0x18_c451, 1); cli();                                    /* cli */
            ii(0x18_c452, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x18_c455, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x18_c458, 2); pushw(0x8);                               /* push 0x8 */
            ii(0x18_c45a, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x18_c45d, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x18_c460, 3); callw(0x18_db67, 0x1704);                 /* call 0xdb67 */
            ii(0x18_c463, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x18_c466, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x18_c469, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x18_c46c, 2); pushw(0xc);                               /* push 0xc */
            ii(0x18_c46e, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x18_c471, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x18_c474, 3); callw(0x18_db67, 0x16f0);                 /* call 0xdb67 */
            ii(0x18_c477, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x18_c47a, 3); pushw(0xdead);                            /* push 0xdead */
            ii(0x18_c47d, 3); pushw(0xdead);                            /* push 0xdead */
            ii(0x18_c480, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x18_c482, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x18_c485, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x18_c488, 3); callw(0x18_db67, 0x16dc);                 /* call 0xdb67 */
            ii(0x18_c48b, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x18_c48e, 4); pushw(memw_a16[ds, 0xc12]);               /* push word [0xc12] */
            ii(0x18_c492, 4); pushw(memw_a16[ds, 0xc10]);               /* push word [0xc10] */
            ii(0x18_c496, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_c498, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x18_c49b, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x18_c49e, 3); callw(0x18_db67, 0x16c6);                 /* call 0xdb67 */
            ii(0x18_c4a1, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x18_c4a4, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x18_c4a7, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x18_c4aa, 3); mov(memw_a16[ds, 0xc10], ax);             /* mov [0xc10], ax */
            ii(0x18_c4ad, 4); mov(memw_a16[ds, 0xc12], dx);             /* mov [0xc12], dx */
            ii(0x18_c4b1, 1); sti();                                    /* sti */
            ii(0x18_c4b2, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
        l_0x18_c4b5:
            ii(0x18_c4b5, 1); leavew();                                 /* leave */
            ii(0x18_c4b6, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}
