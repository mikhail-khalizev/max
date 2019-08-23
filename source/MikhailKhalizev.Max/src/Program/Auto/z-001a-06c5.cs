using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_06c5-b6bc0e76")]
        public void Method_001a_06c5()
        {
            ii(0x1a_06c5, 4); enter(0xa, 0);                            /* enter 0xa, 0x0 */
            ii(0x1a_06c9, 1); push(si);                                 /* push si */
            ii(0x1a_06ca, 1); push(ds);                                 /* push ds */
            ii(0x1a_06cb, 3); push(0x375f);                             /* push 0x375f */
            ii(0x1a_06ce, 5); call_far_abs(0x80, 0x5ba0);               /* call word 0x80:0x5ba0 */
            ii(0x1a_06d3, 1); pop(bx);                                  /* pop bx */
            ii(0x1a_06d4, 1); pop(bx);                                  /* pop bx */
            ii(0x1a_06d5, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x1a_06d7, 2); if(jz(0x1a_073a, 0x61)) goto l_0x1a_073a; /* jz 0x73a */
            ii(0x1a_06d9, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x1a_06dc, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x1a_06df, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x1a_06e2, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x1a_06e5, 1); push(ds);                                 /* push ds */
            ii(0x1a_06e6, 3); push(0x3768);                             /* push 0x3768 */
            ii(0x1a_06e9, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x1a_06ec, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x1a_06ef, 5); call_far_abs(0x90, 0x684);                /* call word 0x90:0x684 */
            ii(0x1a_06f4, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x1a_06f7, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x1a_06fa, 1); push(cs);                                 /* push cs */
            ii(0x1a_06fb, 3); call(0x1a_0409, -0x2f5);                  /* call 0x409 */
            ii(0x1a_06fe, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0x1a_0701, 3); mov(memw[ss, bp - 0x6], dx);              /* mov [bp-0x6], dx */
            ii(0x1a_0704, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x1a_0706, 3); or(ax, memw[ss, bp - 0x8]);               /* or ax, [bp-0x8] */
            ii(0x1a_0709, 2); if(jnz(0x1a_070e, 0x3)) goto l_0x1a_070e; /* jnz 0x70e */
            ii(0x1a_070b, 3); jmp(0x1a_0806, 0xf8); goto l_0x1a_0806;   /* jmp 0x806 */
        l_0x1a_070e:
            ii(0x1a_070e, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x1a_0711, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x1a_0714, 1); push(ds);                                 /* push ds */
            ii(0x1a_0715, 3); push(0x376a);                             /* push 0x376a */
            ii(0x1a_0718, 3); call(0x19_ff4a, -0x7d1);                  /* call 0xff4a */
            ii(0x1a_071b, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x1a_071e, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x1a_0721, 3); push(memw[ss, bp - 0x6]);                 /* push word [bp-0x6] */
            ii(0x1a_0724, 3); push(memw[ss, bp - 0x8]);                 /* push word [bp-0x8] */
            ii(0x1a_0727, 3); call(0x19_ff4a, -0x7e0);                  /* call 0xff4a */
            ii(0x1a_072a, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x1a_072d, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x1a_0730, 5); call_far_abs(0x80, 0x4508);               /* call word 0x80:0x4508 */
            ii(0x1a_0735, 1); pop(bx);                                  /* pop bx */
            ii(0x1a_0736, 1); pop(bx);                                  /* pop bx */
            ii(0x1a_0737, 1); pop(si);                                  /* pop si */
            ii(0x1a_0738, 1); leave();                                  /* leave */
            ii(0x1a_0739, 1); retf(); return;                           /* retf */
        l_0x1a_073a:
            ii(0x1a_073a, 3); mov(ax, memw[ds, 0x32aa]);                /* mov ax, [0x32aa] */
            ii(0x1a_073d, 4); or(ax, memw[ds, 0x32a8]);                 /* or ax, [0x32a8] */
            ii(0x1a_0741, 2); if(jz(0x1a_0774, 0x31)) goto l_0x1a_0774; /* jz 0x774 */
            ii(0x1a_0743, 3); lea(ax, memw[ss, bp - 0x8]);              /* lea ax, [bp-0x8] */
            ii(0x1a_0746, 1); push(ss);                                 /* push ss */
            ii(0x1a_0747, 1); push(ax);                                 /* push ax */
            ii(0x1a_0748, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x1a_074b, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x1a_074e, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x1a_0751, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x1a_0754, 4); call_far_ind(ds, 0x32a8);                 /* call far word [0x32a8] */
            ii(0x1a_0758, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x1a_075b, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x1a_075d, 2); if(jz(0x1a_0774, 0x15)) goto l_0x1a_0774; /* jz 0x774 */
            ii(0x1a_075f, 3); mov(ax, memw[ss, bp - 0x6]);              /* mov ax, [bp-0x6] */
            ii(0x1a_0762, 3); or(ax, memw[ss, bp - 0x8]);               /* or ax, [bp-0x8] */
            ii(0x1a_0765, 2); if(jz(0x1a_0774, 0xd)) goto l_0x1a_0774;  /* jz 0x774 */
            ii(0x1a_0767, 3); push(memw[ss, bp - 0x6]);                 /* push word [bp-0x6] */
            ii(0x1a_076a, 3); push(memw[ss, bp - 0x8]);                 /* push word [bp-0x8] */
            ii(0x1a_076d, 3); call(0x19_ff2f, -0x841);                  /* call 0xff2f */
            ii(0x1a_0770, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x1a_0772, 2); if(jnz(0x1a_0784, 0x10)) goto l_0x1a_0784; /* jnz 0x784 */
        l_0x1a_0774:
            ii(0x1a_0774, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x1a_0777, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x1a_077a, 1); push(cs);                                 /* push cs */
            ii(0x1a_077b, 3); call(0x1a_0409, -0x375);                  /* call 0x409 */
            ii(0x1a_077e, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0x1a_0781, 3); mov(memw[ss, bp - 0x6], dx);              /* mov [bp-0x6], dx */
        l_0x1a_0784:
            ii(0x1a_0784, 3); les(bx, memw[ss, bp + 0xe]);              /* les bx, [bp+0xe] */
            ii(0x1a_0787, 4); mov(memb[es, bx], 0x2e);                  /* mov byte [es:bx], 0x2e */
            ii(0x1a_078b, 5); mov(memb[es, bx + 0x1], 0);               /* mov byte [es:bx+0x1], 0x0 */
            ii(0x1a_0790, 3); mov(ax, memw[ss, bp - 0x6]);              /* mov ax, [bp-0x6] */
            ii(0x1a_0793, 3); or(ax, memw[ss, bp - 0x8]);               /* or ax, [bp-0x8] */
            ii(0x1a_0796, 2); if(jz(0x1a_07ca, 0x32)) goto l_0x1a_07ca; /* jz 0x7ca */
            ii(0x1a_0798, 1); push(es);                                 /* push es */
            ii(0x1a_0799, 1); push(bx);                                 /* push bx */
            ii(0x1a_079a, 3); push(memw[ss, bp - 0x6]);                 /* push word [bp-0x6] */
            ii(0x1a_079d, 3); push(memw[ss, bp - 0x8]);                 /* push word [bp-0x8] */
            ii(0x1a_07a0, 3); call(0x19_ff6c, -0x837);                  /* call 0xff6c */
            ii(0x1a_07a3, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x1a_07a6, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x1a_07a9, 3); call(0x19_ff2f, -0x87d);                  /* call 0xff2f */
            ii(0x1a_07ac, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x1a_07ae, 3); les(bx, memw[ss, bp + 0xe]);              /* les bx, [bp+0xe] */
            ii(0x1a_07b1, 5); cmp(memb[es, bx + si - 0x1], 0x5c);       /* cmp byte [es:bx+si-0x1], 0x5c */
            ii(0x1a_07b6, 2); if(jnz(0x1a_0806, 0x4e)) goto l_0x1a_0806; /* jnz 0x806 */
            ii(0x1a_07b8, 1); push(es);                                 /* push es */
            ii(0x1a_07b9, 1); push(bx);                                 /* push bx */
            ii(0x1a_07ba, 3); call(0x19_ff2f, -0x88e);                  /* call 0xff2f */
            ii(0x1a_07bd, 3); les(bx, memw[ss, bp + 0xe]);              /* les bx, [bp+0xe] */
            ii(0x1a_07c0, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x1a_07c2, 5); mov(memb[es, bx + si - 0x1], 0);          /* mov byte [es:bx+si-0x1], 0x0 */
            ii(0x1a_07c7, 1); pop(si);                                  /* pop si */
            ii(0x1a_07c8, 1); leave();                                  /* leave */
            ii(0x1a_07c9, 1); retf(); return;                           /* retf */
        l_0x1a_07ca:
            ii(0x1a_07ca, 1); push(ds);                                 /* push ds */
            ii(0x1a_07cb, 3); push(0x3779);                             /* push 0x3779 */
            ii(0x1a_07ce, 1); push(ds);                                 /* push ds */
            ii(0x1a_07cf, 3); push(0x376c);                             /* push 0x376c */
            ii(0x1a_07d2, 3); call(0x19_fcad, -0xb28);                  /* call 0xfcad */
            ii(0x1a_07d5, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0x1a_07d8, 3); mov(memw[ss, bp - 0x6], dx);              /* mov [bp-0x6], dx */
            ii(0x1a_07db, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x1a_07dd, 2); if(jz(0x1a_07ee, 0xf)) goto l_0x1a_07ee;  /* jz 0x7ee */
            ii(0x1a_07df, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x1a_07e2, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x1a_07e5, 3); push(memw[ss, bp - 0x6]);                 /* push word [bp-0x6] */
            ii(0x1a_07e8, 1); push(ax);                                 /* push ax */
            ii(0x1a_07e9, 3); call(0x19_ff6c, -0x880);                  /* call 0xff6c */
            ii(0x1a_07ec, 2); jmp(0x1a_07f7, 0x9); goto l_0x1a_07f7;    /* jmp 0x7f7 */
        l_0x1a_07ee:
            ii(0x1a_07ee, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x1a_07f1, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x1a_07f4, 3); call(0x1a_060a, -0x1ed);                  /* call 0x60a */
        l_0x1a_07f7:
            ii(0x1a_07f7, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x1a_07fa, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x1a_07fd, 3); push(memw[ss, bp + 0x14]);                /* push word [bp+0x14] */
            ii(0x1a_0800, 3); push(memw[ss, bp + 0x12]);                /* push word [bp+0x12] */
            ii(0x1a_0803, 3); call(0x19_ff4a, -0x8bc);                  /* call 0xff4a */
        l_0x1a_0806:
            ii(0x1a_0806, 1); pop(si);                                  /* pop si */
            ii(0x1a_0807, 1); leave();                                  /* leave */
            ii(0x1a_0808, 1); retf();                                   /* retf */
        }
    }
}
