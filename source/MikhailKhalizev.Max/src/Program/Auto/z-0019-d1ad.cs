using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_d1ad-c1945e04")]
        public void Method_0019_d1ad()
        {
            ii(0x19_d1ad, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x19_d1b1, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_d1b3, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x19_d1b6, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x19_d1b9, 1); pushw(ds);                                /* push ds */
            ii(0x19_d1ba, 3); pushw(0x296e);                            /* push 0x296e */
            ii(0x19_d1bd, 5); callw_far_abs(0x80, 0x2289);              /* call word 0x80:0x2289 */
            ii(0x19_d1c2, 1); popw(bx);                                 /* pop bx */
            ii(0x19_d1c3, 1); popw(bx);                                 /* pop bx */
            ii(0x19_d1c4, 1); pushw(ds);                                /* push ds */
            ii(0x19_d1c5, 3); pushw(0x299d);                            /* push 0x299d */
            ii(0x19_d1c8, 1); pushw(ds);                                /* push ds */
            ii(0x19_d1c9, 3); pushw(0x298b);                            /* push 0x298b */
            ii(0x19_d1cc, 3); callw(0x19_fcad, 0x2ade);                 /* call 0xfcad */
            ii(0x19_d1cf, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_d1d2, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x19_d1d5, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_d1d7, 2); if(jzw(0x19_d1f0, 0x17)) goto l_0x19_d1f0; /* jz 0xd1f0 */
            ii(0x19_d1d9, 3); lea(ax, bp - 0xa);                        /* lea ax, [bp-0xa] */
            ii(0x19_d1dc, 1); pushw(ss);                                /* push ss */
            ii(0x19_d1dd, 1); pushw(ax);                                /* push ax */
            ii(0x19_d1de, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x19_d1e1, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x19_d1e4, 3); callw_a16_far_ind(ss, bp - 0x4);          /* call far word [bp-0x4] */
            ii(0x19_d1e7, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_d1ea, 4); cmp(memw_a16[ss, bp - 0xa], -0x1 /* 0xff */); /* cmp word [bp-0xa], 0xffff */
            ii(0x19_d1ee, 2); if(jnzw(0x19_d1f2, 0x2)) goto l_0x19_d1f2; /* jnz 0xd1f2 */
        l_0x19_d1f0:
            ii(0x19_d1f0, 2); jmpw(0x19_d26a, 0x78); goto l_0x19_d26a;  /* jmp 0xd26a */
        l_0x19_d1f2:
            ii(0x19_d1f2, 3); mov(ax, memw_a16[ss, bp + 0xc]);          /* mov ax, [bp+0xc] */
            ii(0x19_d1f5, 3); or(ax, memw_a16[ss, bp + 0xa]);           /* or ax, [bp+0xa] */
            ii(0x19_d1f8, 2); if(jnzw(0x19_d1ff, 0x5)) goto l_0x19_d1ff; /* jnz 0xd1ff */
        l_0x19_d1fa:
            ii(0x19_d1fa, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_d1fd, 2); jmpw(0x19_d26c, 0x6d); goto l_0x19_d26c;  /* jmp 0xd26c */
        l_0x19_d1ff:
            ii(0x19_d1ff, 1); pushw(ds);                                /* push ds */
            ii(0x19_d200, 3); pushw(0x29be);                            /* push 0x29be */
            ii(0x19_d203, 1); pushw(ds);                                /* push ds */
            ii(0x19_d204, 3); pushw(0x29ab);                            /* push 0x29ab */
            ii(0x19_d207, 3); callw(0x19_fcad, 0x2aa3);                 /* call 0xfcad */
            ii(0x19_d20a, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_d20d, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x19_d210, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_d212, 2); if(jzw(0x19_d22a, 0x16)) goto l_0x19_d22a; /* jz 0xd22a */
            ii(0x19_d214, 3); lea(ax, bp - 0x8);                        /* lea ax, [bp-0x8] */
            ii(0x19_d217, 1); pushw(ss);                                /* push ss */
            ii(0x19_d218, 1); pushw(ax);                                /* push ax */
            ii(0x19_d219, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x19_d21c, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_d21f, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_d221, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x19_d224, 3); callw_a16_far_ind(ss, bp - 0x4);          /* call far word [bp-0x4] */
            ii(0x19_d227, 3); add(sp, 0xc);                             /* add sp, 0xc */
        l_0x19_d22a:
            ii(0x19_d22a, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x19_d22d, 3); or(ax, memw_a16[ss, bp - 0x8]);           /* or ax, [bp-0x8] */
            ii(0x19_d230, 2); if(jzw(0x19_d26a, 0x38)) goto l_0x19_d26a; /* jz 0xd26a */
            ii(0x19_d232, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x19_d235, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_d238, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x19_d23b, 4); cmp(memb_a16[ss, bp + 0x4], 0);           /* cmp byte [bp+0x4], 0x0 */
            ii(0x19_d23f, 2); if(jzw(0x19_d250, 0xf)) goto l_0x19_d250; /* jz 0xd250 */
            ii(0x19_d241, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x19_d244, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x19_d248, 6); mov(memw_a16[es, bx + 0x4], 0);           /* mov word [es:bx+0x4], 0x0 */
            ii(0x19_d24e, 2); jmpw(0x19_d1fa, -0x56); goto l_0x19_d1fa; /* jmp 0xd1fa */
        l_0x19_d250:
            ii(0x19_d250, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x19_d253, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x19_d256, 5); callw_far_abs(0x80, 0x55dc);              /* call word 0x80:0x55dc */
            ii(0x19_d25b, 1); popw(bx);                                 /* pop bx */
            ii(0x19_d25c, 1); popw(bx);                                 /* pop bx */
            ii(0x19_d25d, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_d260, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x19_d264, 4); mov(memw_a16[es, bx + 0x4], dx);          /* mov [es:bx+0x4], dx */
            ii(0x19_d268, 2); jmpw(0x19_d1fa, -0x70); goto l_0x19_d1fa; /* jmp 0xd1fa */
        l_0x19_d26a:
            ii(0x19_d26a, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_d26c:
            ii(0x19_d26c, 1); leavew();                                 /* leave */
            ii(0x19_d26d, 3); retw(0xe);                                /* ret 0xe */
        }
    }
}
