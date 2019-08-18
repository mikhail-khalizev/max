using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e843bba4-4cfc-448d-8b2b-1d46001749c3")]
        public void Method_0019_c975()
        {
            ii(0x19_c975, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x19_c979, 1); pushw(si);                                /* push si */
            ii(0x19_c97a, 5); cmp(memw_a16[ds, 0x2162], 0);             /* cmp word [0x2162], 0x0 */
            ii(0x19_c97f, 2); if(jnzw(0x19_c998, 0x17)) goto l_0x19_c998; /* jnz 0xc998 */
            ii(0x19_c981, 6); cmp(memw_a16[ds, 0x2160], 0x80);          /* cmp word [0x2160], 0x80 */
            ii(0x19_c987, 2); if(jaew(0x19_c998, 0xf)) goto l_0x19_c998; /* jae 0xc998 */
            ii(0x19_c989, 3); mov(ax, memw_a16[ds, 0x2160]);            /* mov ax, [0x2160] */
            ii(0x19_c98c, 5); add(memw_a16[ds, 0x2160], 0x1);           /* add word [0x2160], 0x1 */
            ii(0x19_c991, 5); adc(memw_a16[ds, 0x2162], 0);             /* adc word [0x2162], 0x0 */
            ii(0x19_c996, 2); jmpw(0x19_c9aa, 0x12); goto l_0x19_c9aa;  /* jmp 0xc9aa */
        l_0x19_c998:
            ii(0x19_c998, 1); pushw(ds);                                /* push ds */
            ii(0x19_c999, 3); pushw(0x2829);                            /* push 0x2829 */
            ii(0x19_c99c, 3); pushw(0x8ff);                             /* push 0x8ff */
            ii(0x19_c99f, 3); callw(0x1a_104e, 0x46ac);                 /* call 0x104e */
            ii(0x19_c9a2, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_c9a5, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_c9a7, 1); cwd();                                    /* cwd */
            ii(0x19_c9a8, 2); jmpw(0x19_c9e2, 0x38); goto l_0x19_c9e2;  /* jmp 0xc9e2 */
        l_0x19_c9aa:
            ii(0x19_c9aa, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x19_c9ad, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x19_c9b0, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_c9b3, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_c9b6, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_c9b9, 3); imul(ax, ax, 0xc);                        /* imul ax, ax, 0xc */
            ii(0x19_c9bc, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x19_c9be, 3); add(ax, 0x2164);                          /* add ax, 0x2164 */
            ii(0x19_c9c1, 1); pushw(ds);                                /* push ds */
            ii(0x19_c9c2, 1); pushw(ax);                                /* push ax */
            ii(0x19_c9c3, 2); mov(si, cx);                              /* mov si, cx */
            ii(0x19_c9c5, 3); callw(0x19_c860, -0x168);                 /* call 0xc860 */
            ii(0x19_c9c8, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x19_c9cb, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x19_c9ce, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x19_c9d1, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x19_c9d4, 4); mov(memw_a16[ds, si + 0x2168], ax);       /* mov [si+0x2168], ax */
            ii(0x19_c9d8, 4); mov(memw_a16[ds, si + 0x216a], dx);       /* mov [si+0x216a], dx */
            ii(0x19_c9dc, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x19_c9df, 3); mov(dx, memw_a16[ss, bp - 0x8]);          /* mov dx, [bp-0x8] */
        l_0x19_c9e2:
            ii(0x19_c9e2, 1); popw(si);                                 /* pop si */
            ii(0x19_c9e3, 1); leavew();                                 /* leave */
            ii(0x19_c9e4, 3); retw(0xc); return;                        /* ret 0xc */
        }
    }
}
