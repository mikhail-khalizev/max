using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("99b8e15f-153a-4c96-a8ce-688febfb50ff")]
        public void Method_0016_06c5()
        {
            ii(0x16_06c5, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x16_06c9, 1); pushw(si);                                /* push si */
            ii(0x16_06ca, 1); pushw(ds);                                /* push ds */
            ii(0x16_06cb, 3); pushw(0x375f);                            /* push 0x375f */
            ii(0x16_06ce, 5); callw_far_abs(0x80, 0x5ba0);              /* call word 0x80:0x5ba0 */
            ii(0x16_06d3, 1); popw(bx);                                 /* pop bx */
            ii(0x16_06d4, 1); popw(bx);                                 /* pop bx */
            ii(0x16_06d5, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x16_06d7, 2); if(jzw(0x16_073a, 0x61)) goto l_0x16_073a; /* jz 0x73a */
            ii(0x16_06d9, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x16_06dc, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x16_06df, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x16_06e2, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x16_06e5, 1); pushw(ds);                                /* push ds */
            ii(0x16_06e6, 3); pushw(0x3768);                            /* push 0x3768 */
            ii(0x16_06e9, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x16_06ec, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x16_06ef, 5); callw_far_abs(0x90, 0x684);               /* call word 0x90:0x684 */
            ii(0x16_06f4, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x16_06f7, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x16_06fa, 1); pushw(cs);                                /* push cs */
            ii(0x16_06fb, 3); callw(0x16_0409, -0x2f5);                 /* call 0x409 */
            ii(0x16_06fe, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x16_0701, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x16_0704, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x16_0706, 3); or(ax, memw_a16[ss, bp - 0x8]);           /* or ax, [bp-0x8] */
            ii(0x16_0709, 2); if(jnzw(0x16_070e, 0x3)) goto l_0x16_070e; /* jnz 0x70e */
            ii(0x16_070b, 3); jmpw(0x16_0806, 0xf8); goto l_0x16_0806;  /* jmp 0x806 */
        l_0x16_070e:
            ii(0x16_070e, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x16_0711, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x16_0714, 1); pushw(ds);                                /* push ds */
            ii(0x16_0715, 3); pushw(0x376a);                            /* push 0x376a */
            ii(0x16_0718, 3); callw(0x15_ff4a, -0x7d1);                 /* call 0xff4a */
            ii(0x16_071b, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x16_071e, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x16_0721, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x16_0724, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x16_0727, 3); callw(0x15_ff4a, -0x7e0);                 /* call 0xff4a */
            ii(0x16_072a, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x16_072d, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x16_0730, 5); callw_far_abs(0x80, 0x4508);              /* call word 0x80:0x4508 */
            ii(0x16_0735, 1); popw(bx);                                 /* pop bx */
            ii(0x16_0736, 1); popw(bx);                                 /* pop bx */
            ii(0x16_0737, 1); popw(si);                                 /* pop si */
            ii(0x16_0738, 1); leavew();                                 /* leave */
            ii(0x16_0739, 1); retfw(); return;                          /* retf */
        l_0x16_073a:
            ii(0x16_073a, 3); mov(ax, memw_a16[ds, 0x32aa]);            /* mov ax, [0x32aa] */
            ii(0x16_073d, 4); or(ax, memw_a16[ds, 0x32a8]);             /* or ax, [0x32a8] */
            ii(0x16_0741, 2); if(jzw(0x16_0774, 0x31)) goto l_0x16_0774; /* jz 0x774 */
            ii(0x16_0743, 3); lea(ax, bp - 0x8);                        /* lea ax, [bp-0x8] */
            ii(0x16_0746, 1); pushw(ss);                                /* push ss */
            ii(0x16_0747, 1); pushw(ax);                                /* push ax */
            ii(0x16_0748, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x16_074b, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x16_074e, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x16_0751, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x16_0754, 4); callw_a16_far_ind(ds, 0x32a8);            /* call far word [0x32a8] */
            ii(0x16_0758, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x16_075b, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x16_075d, 2); if(jzw(0x16_0774, 0x15)) goto l_0x16_0774; /* jz 0x774 */
            ii(0x16_075f, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x16_0762, 3); or(ax, memw_a16[ss, bp - 0x8]);           /* or ax, [bp-0x8] */
            ii(0x16_0765, 2); if(jzw(0x16_0774, 0xd)) goto l_0x16_0774; /* jz 0x774 */
            ii(0x16_0767, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x16_076a, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x16_076d, 3); callw(0x15_ff2f, -0x841);                 /* call 0xff2f */
            ii(0x16_0770, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x16_0772, 2); if(jnzw(0x16_0784, 0x10)) goto l_0x16_0784; /* jnz 0x784 */
        l_0x16_0774:
            ii(0x16_0774, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x16_0777, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x16_077a, 1); pushw(cs);                                /* push cs */
            ii(0x16_077b, 3); callw(0x16_0409, -0x375);                 /* call 0x409 */
            ii(0x16_077e, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x16_0781, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
        l_0x16_0784:
            ii(0x16_0784, 3); les(bx, ss, bp + 0xe);                    /* les bx, [bp+0xe] */
            ii(0x16_0787, 4); mov(memb_a16[es, bx], 0x2e);              /* mov byte [es:bx], 0x2e */
            ii(0x16_078b, 5); mov(memb_a16[es, bx + 0x1], 0);           /* mov byte [es:bx+0x1], 0x0 */
            ii(0x16_0790, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x16_0793, 3); or(ax, memw_a16[ss, bp - 0x8]);           /* or ax, [bp-0x8] */
            ii(0x16_0796, 2); if(jzw(0x16_07ca, 0x32)) goto l_0x16_07ca; /* jz 0x7ca */
            ii(0x16_0798, 1); pushw(es);                                /* push es */
            ii(0x16_0799, 1); pushw(bx);                                /* push bx */
            ii(0x16_079a, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x16_079d, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x16_07a0, 3); callw(0x15_ff6c, -0x837);                 /* call 0xff6c */
            ii(0x16_07a3, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x16_07a6, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x16_07a9, 3); callw(0x15_ff2f, -0x87d);                 /* call 0xff2f */
            ii(0x16_07ac, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x16_07ae, 3); les(bx, ss, bp + 0xe);                    /* les bx, [bp+0xe] */
            ii(0x16_07b1, 5); cmp(memb_a16[es, bx + si - 0x1], 0x5c);   /* cmp byte [es:bx+si-0x1], 0x5c */
            ii(0x16_07b6, 2); if(jnzw(0x16_0806, 0x4e)) goto l_0x16_0806; /* jnz 0x806 */
            ii(0x16_07b8, 1); pushw(es);                                /* push es */
            ii(0x16_07b9, 1); pushw(bx);                                /* push bx */
            ii(0x16_07ba, 3); callw(0x15_ff2f, -0x88e);                 /* call 0xff2f */
            ii(0x16_07bd, 3); les(bx, ss, bp + 0xe);                    /* les bx, [bp+0xe] */
            ii(0x16_07c0, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x16_07c2, 5); mov(memb_a16[es, bx + si - 0x1], 0);      /* mov byte [es:bx+si-0x1], 0x0 */
            ii(0x16_07c7, 1); popw(si);                                 /* pop si */
            ii(0x16_07c8, 1); leavew();                                 /* leave */
            ii(0x16_07c9, 1); retfw(); return;                          /* retf */
        l_0x16_07ca:
            ii(0x16_07ca, 1); pushw(ds);                                /* push ds */
            ii(0x16_07cb, 3); pushw(0x3779);                            /* push 0x3779 */
            ii(0x16_07ce, 1); pushw(ds);                                /* push ds */
            ii(0x16_07cf, 3); pushw(0x376c);                            /* push 0x376c */
            ii(0x16_07d2, 3); callw(0x15_fcad, -0xb28);                 /* call 0xfcad */
            ii(0x16_07d5, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x16_07d8, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x16_07db, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x16_07dd, 2); if(jzw(0x16_07ee, 0xf)) goto l_0x16_07ee; /* jz 0x7ee */
            ii(0x16_07df, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x16_07e2, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x16_07e5, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x16_07e8, 1); pushw(ax);                                /* push ax */
            ii(0x16_07e9, 3); callw(0x15_ff6c, -0x880);                 /* call 0xff6c */
            ii(0x16_07ec, 2); jmpw(0x16_07f7, 0x9); goto l_0x16_07f7;   /* jmp 0x7f7 */
        l_0x16_07ee:
            ii(0x16_07ee, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x16_07f1, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x16_07f4, 3); callw(0x16_060a, -0x1ed);                 /* call 0x60a */
        l_0x16_07f7:
            ii(0x16_07f7, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x16_07fa, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x16_07fd, 3); pushw(memw_a16[ss, bp + 0x14]);           /* push word [bp+0x14] */
            ii(0x16_0800, 3); pushw(memw_a16[ss, bp + 0x12]);           /* push word [bp+0x12] */
            ii(0x16_0803, 3); callw(0x15_ff4a, -0x8bc);                 /* call 0xff4a */
        l_0x16_0806:
            ii(0x16_0806, 1); popw(si);                                 /* pop si */
            ii(0x16_0807, 1); leavew();                                 /* leave */
            ii(0x16_0808, 1); retfw(); return;                          /* retf */
        }
    }
}
