using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_561a-4b34f026")]
        public void Method_0019_561a()
        {
            ii(0x19_561a, 4); enterw(0xf0, 0);                          /* enter 0xf0, 0x0 */
            ii(0x19_561e, 1); pushw(di);                                /* push di */
            ii(0x19_561f, 1); pushw(si);                                /* push si */
            ii(0x19_5620, 5); mov(memw_a16[ss, bp - 0x3e], 0x1);        /* mov word [bp-0x3e], 0x1 */
            ii(0x19_5625, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_5627, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x19_562a, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x19_562d, 4); mov(memb_a16[ss, bp - 0x66], 0);          /* mov byte [bp-0x66], 0x0 */
            ii(0x19_5631, 4); mov(memb_a16[ss, bp - 0x60], 0);          /* mov byte [bp-0x60], 0x0 */
            ii(0x19_5635, 1); pushw(ds);                                /* push ds */
            ii(0x19_5636, 3); pushw(0xe11);                             /* push 0xe11 */
            ii(0x19_5639, 5); callw_far_abs(0x80, 0x27c3);              /* call word 0x80:0x27c3 */
            ii(0x19_563e, 1); pushw(ds);                                /* push ds */
            ii(0x19_563f, 3); pushw(0xe26);                             /* push 0xe26 */
            ii(0x19_5642, 5); callw_far_abs(0x80, 0x20cc);              /* call word 0x80:0x20cc */
            ii(0x19_5647, 4); mov(es, memw_a16[ds, 0x3f8a]);            /* mov es, [0x3f8a] */
            ii(0x19_564b, 4); mov(al, memb_a16[es, 0x47]);              /* mov al, [es:0x47] */
            ii(0x19_564f, 2); and(al, 0x1);                             /* and al, 0x1 */
            ii(0x19_5651, 1); cbw();                                    /* cbw */
            ii(0x19_5652, 3); mov(memw_a16[ss, bp - 0x3e], ax);         /* mov [bp-0x3e], ax */
            ii(0x19_5655, 3); pushw(0x88);                              /* push 0x88 */
            ii(0x19_5658, 3); pushw(0x1fa);                             /* push 0x1fa */
            ii(0x19_565b, 3); callw(0x18_fa6b, -0x5bf3);                /* call 0xfa6b */
            ii(0x19_565e, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_5661, 2); if(jnzw(0x19_5666, 0x3)) goto l_0x19_5666; /* jnz 0x5666 */
            ii(0x19_5663, 3); jmpw(0x19_5676, 0x10); goto l_0x19_5676;  /* jmp 0x5676 */
        l_0x19_5666:
            ii(0x19_5666, 3); lea(ax, bp + 0x6);                        /* lea ax, [bp+0x6] */
            ii(0x19_5669, 1); pushw(ss);                                /* push ss */
            ii(0x19_566a, 1); pushw(ax);                                /* push ax */
            ii(0x19_566b, 3); callw(0x18_fa6b, -0x5c03);                /* call 0xfa6b */
            ii(0x19_566e, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_5671, 2); if(jzw(0x19_5676, 0x3)) goto l_0x19_5676; /* jz 0x5676 */
            ii(0x19_5673, 3); jmpw(0x19_5683, 0xd); goto l_0x19_5683;   /* jmp 0x5683 */
        l_0x19_5676:
            ii(0x19_5676, 1); pushw(ds);                                /* push ds */
            ii(0x19_5677, 3); pushw(0xe2d);                             /* push 0xe2d */
            ii(0x19_567a, 3); pushw(0x3eb);                             /* push 0x3eb */
            ii(0x19_567d, 3); callw(0x19_1046, -0x463a);                /* call 0x1046 */
            ii(0x19_5680, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x19_5683:
            ii(0x19_5683, 1); pushw(ds);                                /* push ds */
            ii(0x19_5684, 3); pushw(0xe53);                             /* push 0xe53 */
            ii(0x19_5687, 5); callw_far_abs(0x80, 0x3e14);              /* call word 0x80:0x3e14 */
            ii(0x19_568c, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_568f, 3); mov(memw_a16[ds, 0x40ec], ax);            /* mov [0x40ec], ax */
            ii(0x19_5692, 4); mov(memw_a16[ds, 0x40ee], dx);            /* mov [0x40ee], dx */
            ii(0x19_5696, 3); mov(ax, memw_a16[ds, 0x40ee]);            /* mov ax, [0x40ee] */
            ii(0x19_5699, 4); or(ax, memw_a16[ds, 0x40ec]);             /* or ax, [0x40ec] */
            ii(0x19_569d, 2); if(jzw(0x19_56a2, 0x3)) goto l_0x19_56a2; /* jz 0x56a2 */
            ii(0x19_569f, 3); jmpw(0x19_56ac, 0xa); goto l_0x19_56ac;   /* jmp 0x56ac */
        l_0x19_56a2:
            ii(0x19_56a2, 6); mov(memw_a16[ds, 0x40ec], 0xe59);         /* mov word [0x40ec], 0xe59 */
            ii(0x19_56a8, 4); mov(memw_a16[ds, 0x40ee], ds);            /* mov [0x40ee], ds */
        l_0x19_56ac:
            ii(0x19_56ac, 1); nop();                                    /* nop */
            ii(0x19_56ad, 1); pushw(cs);                                /* push cs */
            ii(0x19_56ae, 3); callw(0x19_9b84, 0x44d3);                 /* call 0x9b84 */
            ii(0x19_56b1, 5); callw_far_abs(0x80, 0x1090);              /* call word 0x80:0x1090 */
            ii(0x19_56b6, 1); pushw(ds);                                /* push ds */
            ii(0x19_56b7, 3); pushw(0xe5a);                             /* push 0xe5a */
            ii(0x19_56ba, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_56bc, 3); callw(0x19_5539, -0x186);                 /* call 0x5539 */
            ii(0x19_56bf, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_56c2, 2); if(jnzw(0x19_56c7, 0x3)) goto l_0x19_56c7; /* jnz 0x56c7 */
            ii(0x19_56c4, 3); jmpw(0x19_56d7, 0x10); goto l_0x19_56d7;  /* jmp 0x56d7 */
        l_0x19_56c7:
            ii(0x19_56c7, 5); or(memw_a16[ds, 0x36f6], 0x1);            /* or word [0x36f6], 0x1 */
            ii(0x19_56cc, 4); mov(es, memw_a16[ds, 0x3f8c]);            /* mov es, [0x3f8c] */
            ii(0x19_56d0, 7); mov(memw_a16[es, 0xa70], 0);              /* mov word [es:0xa70], 0x0 */
        l_0x19_56d7:
            ii(0x19_56d7, 1); pushw(ds);                                /* push ds */
            ii(0x19_56d8, 3); pushw(0xe62);                             /* push 0xe62 */
            ii(0x19_56db, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_56dd, 3); callw(0x19_5539, -0x1a7);                 /* call 0x5539 */
            ii(0x19_56e0, 3); mov(memb_a16[ds, 0xd7e], al);             /* mov [0xd7e], al */
            ii(0x19_56e3, 1); pushw(ds);                                /* push ds */
            ii(0x19_56e4, 3); pushw(0xe68);                             /* push 0xe68 */
            ii(0x19_56e7, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_56e9, 3); callw(0x19_5539, -0x1b3);                 /* call 0x5539 */
            ii(0x19_56ec, 3); mov(memb_a16[ds, 0xd7f], al);             /* mov [0xd7f], al */
            ii(0x19_56ef, 1); pushw(ds);                                /* push ds */
            ii(0x19_56f0, 3); pushw(0xe6f);                             /* push 0xe6f */
            ii(0x19_56f3, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_56f5, 3); callw(0x19_5539, -0x1bf);                 /* call 0x5539 */
            ii(0x19_56f8, 3); mov(memb_a16[ds, 0xd81], al);             /* mov [0xd81], al */
            ii(0x19_56fb, 1); pushw(ds);                                /* push ds */
            ii(0x19_56fc, 3); pushw(0xe78);                             /* push 0xe78 */
            ii(0x19_56ff, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_5701, 3); callw(0x19_5539, -0x1cb);                 /* call 0x5539 */
            ii(0x19_5704, 3); mov(memb_a16[ds, 0xd83], al);             /* mov [0xd83], al */
            ii(0x19_5707, 1); pushw(ds);                                /* push ds */
            ii(0x19_5708, 3); pushw(0xe7b);                             /* push 0xe7b */
            ii(0x19_570b, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_570d, 3); callw(0x19_5539, -0x1d7);                 /* call 0x5539 */
            ii(0x19_5710, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_5713, 2); if(jzw(0x19_5718, 0x3)) goto l_0x19_5718; /* jz 0x5718 */
            ii(0x19_5715, 3); jmpw(0x19_577e, 0x66); goto l_0x19_577e;  /* jmp 0x577e */
        l_0x19_5718:
            ii(0x19_5718, 4); mov(es, memw_a16[ds, 0x3f88]);            /* mov es, [0x3f88] */
            ii(0x19_571c, 4); mov(ax, memw_a16[es, 0x3b78]);            /* mov ax, [es:0x3b78] */
            ii(0x19_5720, 2); sub(bx, bx);                              /* sub bx, bx */
            ii(0x19_5722, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x19_5724, 5); test(memb_a16[es, bx + 0x47], 0x40);      /* test byte [es:bx+0x47], 0x40 */
            ii(0x19_5729, 2); if(jzw(0x19_572e, 0x3)) goto l_0x19_572e; /* jz 0x572e */
            ii(0x19_572b, 3); jmpw(0x19_577e, 0x50); goto l_0x19_577e;  /* jmp 0x577e */
        l_0x19_572e:
            ii(0x19_572e, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_5730, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x19_5732, 5); callw_far_abs(0x80, 0x22d7);              /* call word 0x80:0x22d7 */
            ii(0x19_5737, 4); mov(memw_a16[ss, bp - 0xf0], ax);         /* mov [bp-0xf0], ax */
            ii(0x19_573b, 1); pushw(ds);                                /* push ds */
            ii(0x19_573c, 3); pushw(0xb2e);                             /* push 0xb2e */
            ii(0x19_573f, 1); pushw(ds);                                /* push ds */
            ii(0x19_5740, 3); pushw(0xaba);                             /* push 0xaba */
            ii(0x19_5743, 1); pushw(ds);                                /* push ds */
            ii(0x19_5744, 3); pushw(0xe81);                             /* push 0xe81 */
            ii(0x19_5747, 3); callw(0x19_105e, -0x46ec);                /* call 0x105e */
            ii(0x19_574a, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x19_574d, 5); test(memb_a16[ds, 0x36f6], 0x1);          /* test byte [0x36f6], 0x1 */
            ii(0x19_5752, 2); if(jnzw(0x19_5757, 0x3)) goto l_0x19_5757; /* jnz 0x5757 */
            ii(0x19_5754, 3); jmpw(0x19_5765, 0xe); goto l_0x19_5765;   /* jmp 0x5765 */
        l_0x19_5757:
            ii(0x19_5757, 1); pushw(ds);                                /* push ds */
            ii(0x19_5758, 3); pushw(0xb18);                             /* push 0xb18 */
            ii(0x19_575b, 1); pushw(ds);                                /* push ds */
            ii(0x19_575c, 3); pushw(0xe90);                             /* push 0xe90 */
            ii(0x19_575f, 3); callw(0x19_105e, -0x4704);                /* call 0x105e */
            ii(0x19_5762, 3); add(sp, 0x8);                             /* add sp, 0x8 */
        l_0x19_5765:
            ii(0x19_5765, 1); pushw(ds);                                /* push ds */
            ii(0x19_5766, 3); pushw(0xae8);                             /* push 0xae8 */
            ii(0x19_5769, 1); pushw(ds);                                /* push ds */
            ii(0x19_576a, 3); pushw(0xe96);                             /* push 0xe96 */
            ii(0x19_576d, 3); callw(0x19_105e, -0x4712);                /* call 0x105e */
            ii(0x19_5770, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_5773, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_5775, 4); pushw(memw_a16[ss, bp - 0xf0]);           /* push word [bp-0xf0] */
            ii(0x19_5779, 5); callw_far_abs(0x80, 0x22d7);              /* call word 0x80:0x22d7 */
        l_0x19_577e:
            ii(0x19_577e, 1); pushw(ds);                                /* push ds */
            ii(0x19_577f, 3); pushw(0xe9b);                             /* push 0xe9b */
            ii(0x19_5782, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_5784, 3); callw(0x19_5539, -0x24e);                 /* call 0x5539 */
            ii(0x19_5787, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_578a, 2); if(jnzw(0x19_578f, 0x3)) goto l_0x19_578f; /* jnz 0x578f */
            ii(0x19_578c, 3); jmpw(0x19_5798, 0x9); goto l_0x19_5798;   /* jmp 0x5798 */
        l_0x19_578f:
            ii(0x19_578f, 2); pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0x19_5791, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x19_5793, 5); callw_far_abs(0x80, 0x22d7);              /* call word 0x80:0x22d7 */
        l_0x19_5798:
            ii(0x19_5798, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_579b, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x19_579f, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x19_57a2, 1); nop();                                    /* nop */
            ii(0x19_57a3, 1); pushw(cs);                                /* push cs */
            ii(0x19_57a4, 3); callw(0x18_e596, -0x7211);                /* call 0xe596 */
            ii(0x19_57a7, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_57aa, 4); cmp(memw_a16[ss, bp + 0x6], 0x2);         /* cmp word [bp+0x6], 0x2 */
            ii(0x19_57ae, 2); if(jlw(0x19_57b3, 0x3)) goto l_0x19_57b3; /* jl 0x57b3 */
            ii(0x19_57b0, 3); jmpw(0x19_57da, 0x27); goto l_0x19_57da;  /* jmp 0x57da */
        l_0x19_57b3:
            ii(0x19_57b3, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_57b6, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x19_57ba, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x19_57bd, 1); nop();                                    /* nop */
            ii(0x19_57be, 1); pushw(cs);                                /* push cs */
            ii(0x19_57bf, 3); callw(0x18_e402, -0x73c0);                /* call 0xe402 */
            ii(0x19_57c2, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_57c5, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_57c8, 2); if(jnzw(0x19_57cd, 0x3)) goto l_0x19_57cd; /* jnz 0x57cd */
            ii(0x19_57ca, 3); jmpw(0x19_57da, 0xd); goto l_0x19_57da;   /* jmp 0x57da */
        l_0x19_57cd:
            ii(0x19_57cd, 1); pushw(ds);                                /* push ds */
            ii(0x19_57ce, 3); pushw(0xea2);                             /* push 0xea2 */
            ii(0x19_57d1, 3); pushw(0x3ec);                             /* push 0x3ec */
            ii(0x19_57d4, 3); callw(0x19_1046, -0x4791);                /* call 0x1046 */
            ii(0x19_57d7, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x19_57da:
            ii(0x19_57da, 4); cmp(memw_a16[ss, bp + 0x6], 0x2);         /* cmp word [bp+0x6], 0x2 */
            ii(0x19_57de, 2); if(jgew(0x19_57e3, 0x3)) goto l_0x19_57e3; /* jge 0x57e3 */
            ii(0x19_57e0, 3); jmpw(0x19_580a, 0x27); goto l_0x19_580a;  /* jmp 0x580a */
        l_0x19_57e3:
            ii(0x19_57e3, 5); cmp(memb_a16[ds, 0xd83], 0);              /* cmp byte [0xd83], 0x0 */
            ii(0x19_57e8, 2); if(jzw(0x19_57ed, 0x3)) goto l_0x19_57ed; /* jz 0x57ed */
            ii(0x19_57ea, 3); jmpw(0x19_580a, 0x1d); goto l_0x19_580a;  /* jmp 0x580a */
        l_0x19_57ed:
            ii(0x19_57ed, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_57f0, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x19_57f4, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x19_57f7, 1); nop();                                    /* nop */
            ii(0x19_57f8, 1); pushw(cs);                                /* push cs */
            ii(0x19_57f9, 3); callw(0x18_e402, -0x73fa);                /* call 0xe402 */
            ii(0x19_57fc, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_57ff, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_5802, 2); if(jnzw(0x19_5807, 0x3)) goto l_0x19_5807; /* jnz 0x5807 */
            ii(0x19_5804, 3); jmpw(0x19_580a, 0x3); goto l_0x19_580a;   /* jmp 0x580a */
        l_0x19_5807:
            ii(0x19_5807, 3); inc(memb_a16[ss, bp - 0x60]);             /* inc byte [bp-0x60] */
        l_0x19_580a:
            ii(0x19_580a, 1); nop();                                    /* nop */
            ii(0x19_580b, 1); pushw(cs);                                /* push cs */
            ii(0x19_580c, 3); callw(0x19_5d72, 0x563);                  /* call 0x5d72 */
            ii(0x19_580f, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_5812, 2); if(jnzw(0x19_5817, 0x3)) goto l_0x19_5817; /* jnz 0x5817 */
            ii(0x19_5814, 3); jmpw(0x19_5827, 0x10); goto l_0x19_5827;  /* jmp 0x5827 */
        l_0x19_5817:
            ii(0x19_5817, 1); pushw(ds);                                /* push ds */
            ii(0x19_5818, 3); pushw(0xec5);                             /* push 0xec5 */
            ii(0x19_581b, 3); callw(0x19_1066, -0x47b8);                /* call 0x1066 */
            ii(0x19_581e, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_5821, 6); mov(memw_a16[ds, 0xd86], 0);              /* mov word [0xd86], 0x0 */
        l_0x19_5827:
            ii(0x19_5827, 3); lea(ax, bp - 0xc);                        /* lea ax, [bp-0xc] */
            ii(0x19_582a, 1); pushw(ss);                                /* push ss */
            ii(0x19_582b, 1); pushw(ax);                                /* push ax */
            ii(0x19_582c, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_582f, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_5832, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_5835, 1); nop();                                    /* nop */
            ii(0x19_5836, 1); pushw(cs);                                /* push cs */
            ii(0x19_5837, 3); callw(0x18_e49a, -0x73a0);                /* call 0xe49a */
            ii(0x19_583a, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_583d, 3); mov(memw_a16[ss, bp - 0x64], ax);         /* mov [bp-0x64], ax */
            ii(0x19_5840, 3); mov(memw_a16[ss, bp - 0x62], dx);         /* mov [bp-0x62], dx */
            ii(0x19_5843, 3); callw(0x19_552f, -0x317);                 /* call 0x552f */
            ii(0x19_5846, 1); pushw(ds);                                /* push ds */
            ii(0x19_5847, 3); pushw(0xee5);                             /* push 0xee5 */
            ii(0x19_584a, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_584c, 3); callw(0x19_5539, -0x316);                 /* call 0x5539 */
            ii(0x19_584f, 3); mov(memw_a16[ds, 0xd88], ax);             /* mov [0xd88], ax */
            ii(0x19_5852, 5); cmp(memw_a16[ds, 0xd88], 0);              /* cmp word [0xd88], 0x0 */
            ii(0x19_5857, 2); if(jzw(0x19_585c, 0x3)) goto l_0x19_585c; /* jz 0x585c */
            ii(0x19_5859, 3); jmpw(0x19_5860, 0x4); goto l_0x19_5860;   /* jmp 0x5860 */
        l_0x19_585c:
            ii(0x19_585c, 4); dec(memw_a16[ds, 0xd78]);                 /* dec word [0xd78] */
        l_0x19_5860:
            ii(0x19_5860, 1); pushw(ds);                                /* push ds */
            ii(0x19_5861, 3); pushw(0xd68);                             /* push 0xd68 */
            ii(0x19_5864, 5); callw_far_abs(0x80, 0x5aca);              /* call word 0x80:0x5aca */
            ii(0x19_5869, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_586c, 3); callw(0x19_559c, -0x2d3);                 /* call 0x559c */
            ii(0x19_586f, 1); nop();                                    /* nop */
            ii(0x19_5870, 1); pushw(cs);                                /* push cs */
            ii(0x19_5871, 3); callw(0x19_7b4f, 0x22db);                 /* call 0x7b4f */
            ii(0x19_5874, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_5877, 2); if(jzw(0x19_587c, 0x3)) goto l_0x19_587c; /* jz 0x587c */
            ii(0x19_5879, 3); jmpw(0x19_5889, 0xd); goto l_0x19_5889;   /* jmp 0x5889 */
        l_0x19_587c:
            ii(0x19_587c, 1); pushw(ds);                                /* push ds */
            ii(0x19_587d, 3); pushw(0xeeb);                             /* push 0xeeb */
            ii(0x19_5880, 3); pushw(0x3ed);                             /* push 0x3ed */
            ii(0x19_5883, 3); callw(0x19_1046, -0x4840);                /* call 0x1046 */
            ii(0x19_5886, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x19_5889:
            ii(0x19_5889, 4); pushw(memw_a16[ds, 0xd86]);               /* push word [0xd86] */
            ii(0x19_588d, 5); callw_far_abs(0x80, 0x9d5);               /* call word 0x80:0x9d5 */
            ii(0x19_5892, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x19_5895, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_5898, 2); if(jzw(0x19_589d, 0x3)) goto l_0x19_589d; /* jz 0x589d */
            ii(0x19_589a, 3); jmpw(0x19_58aa, 0xd); goto l_0x19_58aa;   /* jmp 0x58aa */
        l_0x19_589d:
            ii(0x19_589d, 1); pushw(ds);                                /* push ds */
            ii(0x19_589e, 3); pushw(0xf12);                             /* push 0xf12 */
            ii(0x19_58a1, 3); pushw(0x3e8);                             /* push 0x3e8 */
            ii(0x19_58a4, 3); callw(0x19_1046, -0x4861);                /* call 0x1046 */
            ii(0x19_58a7, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x19_58aa:
            ii(0x19_58aa, 1); nop();                                    /* nop */
            ii(0x19_58ab, 1); pushw(cs);                                /* push cs */
            ii(0x19_58ac, 3); callw(0x19_7e4a, 0x259b);                 /* call 0x7e4a */
            ii(0x19_58af, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_58b1, 1); nop();                                    /* nop */
            ii(0x19_58b2, 1); pushw(cs);                                /* push cs */
            ii(0x19_58b3, 3); callw(0x18_eac2, -0x6df4);                /* call 0xeac2 */
            ii(0x19_58b6, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x19_58b9, 4); mov(memw_a16[ss, bp - 0xee], ax);         /* mov [bp-0xee], ax */
            ii(0x19_58bd, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_58c0, 2); if(jnzw(0x19_58c5, 0x3)) goto l_0x19_58c5; /* jnz 0x58c5 */
            ii(0x19_58c2, 3); jmpw(0x19_58d3, 0xe); goto l_0x19_58d3;   /* jmp 0x58d3 */
        l_0x19_58c5:
            ii(0x19_58c5, 4); pushw(memw_a16[ss, bp - 0xee]);           /* push word [bp-0xee] */
            ii(0x19_58c9, 1); pushw(ds);                                /* push ds */
            ii(0x19_58ca, 3); pushw(0xf29);                             /* push 0xf29 */
            ii(0x19_58cd, 3); callw(0x19_1066, -0x486a);                /* call 0x1066 */
            ii(0x19_58d0, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x19_58d3:
            ii(0x19_58d3, 5); callw_far_abs(0x80, 0x115b);              /* call word 0x80:0x115b */
            ii(0x19_58d8, 1); nop();                                    /* nop */
            ii(0x19_58d9, 1); pushw(cs);                                /* push cs */
            ii(0x19_58da, 3); callw(0x19_5f8c, 0x6af);                  /* call 0x5f8c */
            ii(0x19_58dd, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x19_58df, 1); nop();                                    /* nop */
            ii(0x19_58e0, 1); pushw(cs);                                /* push cs */
            ii(0x19_58e1, 3); callw(0x18_f850, -0x6094);                /* call 0xf850 */
            ii(0x19_58e4, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x19_58e7, 4); cmp(memw_a16[ss, bp - 0x3e], 0);          /* cmp word [bp-0x3e], 0x0 */
            ii(0x19_58eb, 2); if(jnzw(0x19_58f0, 0x3)) goto l_0x19_58f0; /* jnz 0x58f0 */
            ii(0x19_58ed, 3); jmpw(0x19_590f, 0x1f); goto l_0x19_590f;  /* jmp 0x590f */
        l_0x19_58f0:
            ii(0x19_58f0, 5); callw_far_abs(0x90, 0x516);               /* call word 0x90:0x516 */
            ii(0x19_58f5, 4); mov(memw_a16[ss, bp - 0xee], ax);         /* mov [bp-0xee], ax */
            ii(0x19_58f9, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_58fc, 2); if(jnzw(0x19_5901, 0x3)) goto l_0x19_5901; /* jnz 0x5901 */
            ii(0x19_58fe, 3); jmpw(0x19_590f, 0xe); goto l_0x19_590f;   /* jmp 0x590f */
        l_0x19_5901:
            ii(0x19_5901, 4); pushw(memw_a16[ss, bp - 0xee]);           /* push word [bp-0xee] */
            ii(0x19_5905, 1); pushw(ds);                                /* push ds */
            ii(0x19_5906, 3); pushw(0xf47);                             /* push 0xf47 */
            ii(0x19_5909, 3); callw(0x19_1066, -0x48a6);                /* call 0x1066 */
            ii(0x19_590c, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x19_590f:
            ii(0x19_590f, 1); nop();                                    /* nop */
            ii(0x19_5910, 1); pushw(cs);                                /* push cs */
            ii(0x19_5911, 3); callw(0x18_f76f, -0x61a5);                /* call 0xf76f */
            ii(0x19_5914, 1); nop();                                    /* nop */
            ii(0x19_5915, 1); pushw(cs);                                /* push cs */
            ii(0x19_5916, 3); callw(0x18_ea66, -0x6eb3);                /* call 0xea66 */
            ii(0x19_5919, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_591b, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x19_591d, 1); pushw(ds);                                /* push ds */
            ii(0x19_591e, 3); pushw(0xf65);                             /* push 0xf65 */
            ii(0x19_5921, 1); nop();                                    /* nop */
            ii(0x19_5922, 1); pushw(cs);                                /* push cs */
            ii(0x19_5923, 3); callw(0x18_f9ac, -0x5f7a);                /* call 0xf9ac */
            ii(0x19_5926, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_5929, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_592b, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x19_592e, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x19_5931, 3); pushw(memw_a16[ss, bp - 0x62]);           /* push word [bp-0x62] */
            ii(0x19_5934, 3); pushw(memw_a16[ss, bp - 0x64]);           /* push word [bp-0x64] */
            ii(0x19_5937, 3); pushw(0x8000);                            /* push 0x8000 */
            ii(0x19_593a, 1); nop();                                    /* nop */
            ii(0x19_593b, 1); pushw(cs);                                /* push cs */
            ii(0x19_593c, 3); callw(0x19_106e, -0x48d1);                /* call 0x106e */
            ii(0x19_593f, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x19_5942, 4); cmp(memw_a16[ss, bp - 0x10], 0);          /* cmp word [bp-0x10], 0x0 */
            ii(0x19_5946, 2); if(jlw(0x19_594b, 0x3)) goto l_0x19_594b; /* jl 0x594b */
            ii(0x19_5948, 3); jmpw(0x19_595e, 0x13); goto l_0x19_595e;  /* jmp 0x595e */
        l_0x19_594b:
            ii(0x19_594b, 3); pushw(memw_a16[ss, bp - 0x62]);           /* push word [bp-0x62] */
            ii(0x19_594e, 3); pushw(memw_a16[ss, bp - 0x64]);           /* push word [bp-0x64] */
            ii(0x19_5951, 1); pushw(ds);                                /* push ds */
            ii(0x19_5952, 3); pushw(0xf77);                             /* push 0xf77 */
            ii(0x19_5955, 3); pushw(0x3ef);                             /* push 0x3ef */
            ii(0x19_5958, 3); callw(0x19_1046, -0x4915);                /* call 0x1046 */
            ii(0x19_595b, 3); add(sp, 0xa);                             /* add sp, 0xa */
        l_0x19_595e:
            ii(0x19_595e, 1); pushw(ds);                                /* push ds */
            ii(0x19_595f, 3); pushw(0xd90);                             /* push 0xd90 */
            ii(0x19_5962, 3); pushw(memw_a16[ss, bp - 0x62]);           /* push word [bp-0x62] */
            ii(0x19_5965, 3); pushw(memw_a16[ss, bp - 0x64]);           /* push word [bp-0x64] */
            ii(0x19_5968, 3); callw(0x18_ff6c, -0x59ff);                /* call 0xff6c */
            ii(0x19_596b, 3); lea(ax, bp - 0x3c);                       /* lea ax, [bp-0x3c] */
            ii(0x19_596e, 1); pushw(ss);                                /* push ss */
            ii(0x19_596f, 1); pushw(ax);                                /* push ax */
            ii(0x19_5970, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x19_5973, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x19_5976, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x19_5979, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x19_597c, 1); nop();                                    /* nop */
            ii(0x19_597d, 1); pushw(cs);                                /* push cs */
            ii(0x19_597e, 3); callw(0x18_e949, -0x7038);                /* call 0xe949 */
            ii(0x19_5981, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x19_5984, 4); mov(memw_a16[ss, bp - 0xee], ax);         /* mov [bp-0xee], ax */
            ii(0x19_5988, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_598b, 2); if(jnzw(0x19_5990, 0x3)) goto l_0x19_5990; /* jnz 0x5990 */
            ii(0x19_598d, 3); jmpw(0x19_59aa, 0x1a); goto l_0x19_59aa;  /* jmp 0x59aa */
        l_0x19_5990:
            ii(0x19_5990, 4); mov(ax, memw_a16[ss, bp - 0xee]);         /* mov ax, [bp-0xee] */
            ii(0x19_5994, 1); cwd();                                    /* cwd */
            ii(0x19_5995, 1); pushw(dx);                                /* push dx */
            ii(0x19_5996, 1); pushw(ax);                                /* push ax */
            ii(0x19_5997, 3); pushw(memw_a16[ss, bp - 0x62]);           /* push word [bp-0x62] */
            ii(0x19_599a, 3); pushw(memw_a16[ss, bp - 0x64]);           /* push word [bp-0x64] */
            ii(0x19_599d, 1); pushw(ds);                                /* push ds */
            ii(0x19_599e, 3); pushw(0xf93);                             /* push 0xf93 */
            ii(0x19_59a1, 3); pushw(0x3f0);                             /* push 0x3f0 */
            ii(0x19_59a4, 3); callw(0x19_1046, -0x4961);                /* call 0x1046 */
            ii(0x19_59a7, 3); add(sp, 0xe);                             /* add sp, 0xe */
        l_0x19_59aa:
            ii(0x19_59aa, 3); lea(ax, bp - 0x5e);                       /* lea ax, [bp-0x5e] */
            ii(0x19_59ad, 1); pushw(ss);                                /* push ss */
            ii(0x19_59ae, 1); pushw(ax);                                /* push ax */
            ii(0x19_59af, 3); les(bx, ss, bp - 0x3c);                   /* les bx, [bp-0x3c] */
            ii(0x19_59b2, 4); pushw(memw_a16[es, bx + 0x6]);            /* push word [es:bx+0x6] */
            ii(0x19_59b6, 4); pushw(memw_a16[es, bx + 0x4]);            /* push word [es:bx+0x4] */
            ii(0x19_59ba, 1); nop();                                    /* nop */
            ii(0x19_59bb, 1); pushw(cs);                                /* push cs */
            ii(0x19_59bc, 3); callw(0x19_1212, -0x47ad);                /* call 0x1212 */
            ii(0x19_59bf, 1); pushw(ds);                                /* push ds */
            ii(0x19_59c0, 3); pushw(0xfc3);                             /* push 0xfc3 */
            ii(0x19_59c3, 3); lea(ax, bp - 0x5e);                       /* lea ax, [bp-0x5e] */
            ii(0x19_59c6, 1); pushw(ss);                                /* push ss */
            ii(0x19_59c7, 1); pushw(ax);                                /* push ax */
            ii(0x19_59c8, 5); callw_far_abs(0x80, 0x4438);              /* call word 0x80:0x4438 */
            ii(0x19_59cd, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_59d0, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_59d3, 2); if(jzw(0x19_59d8, 0x3)) goto l_0x19_59d8; /* jz 0x59d8 */
            ii(0x19_59d5, 3); jmpw(0x19_5a2d, 0x55); goto l_0x19_5a2d;  /* jmp 0x5a2d */
        l_0x19_59d8:
            ii(0x19_59d8, 3); inc(memb_a16[ss, bp - 0x66]);             /* inc byte [bp-0x66] */
            ii(0x19_59db, 1); pushw(ds);                                /* push ds */
            ii(0x19_59dc, 3); pushw(0xd90);                             /* push 0xd90 */
            ii(0x19_59df, 5); callw_far_abs(0x80, 0x4508);              /* call word 0x80:0x4508 */
            ii(0x19_59e4, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_59e7, 1); pushw(ds);                                /* push ds */
            ii(0x19_59e8, 3); pushw(0xd90);                             /* push 0xd90 */
            ii(0x19_59eb, 1); pushw(ds);                                /* push ds */
            ii(0x19_59ec, 3); pushw(0xfce);                             /* push 0xfce */
            ii(0x19_59ef, 3); callw(0x18_ffd5, -0x5a1d);                /* call 0xffd5 */
            ii(0x19_59f2, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_59f4, 2); if(jzw(0x19_59f9, 0x3)) goto l_0x19_59f9; /* jz 0x59f9 */
            ii(0x19_59f6, 3); jmpw(0x19_5a2a, 0x31); goto l_0x19_5a2a;  /* jmp 0x5a2a */
        l_0x19_59f9:
            ii(0x19_59f9, 1); pushw(ds);                                /* push ds */
            ii(0x19_59fa, 3); pushw(0xd90);                             /* push 0xd90 */
            ii(0x19_59fd, 1); pushw(ds);                                /* push ds */
            ii(0x19_59fe, 3); pushw(0xfd6);                             /* push 0xfd6 */
            ii(0x19_5a01, 3); callw(0x18_ffd5, -0x5a2f);                /* call 0xffd5 */
            ii(0x19_5a04, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_5a06, 2); if(jzw(0x19_5a0b, 0x3)) goto l_0x19_5a0b; /* jz 0x5a0b */
            ii(0x19_5a08, 3); jmpw(0x19_5a2a, 0x1f); goto l_0x19_5a2a;  /* jmp 0x5a2a */
        l_0x19_5a0b:
            ii(0x19_5a0b, 1); pushw(ds);                                /* push ds */
            ii(0x19_5a0c, 3); pushw(0xd90);                             /* push 0xd90 */
            ii(0x19_5a0f, 1); pushw(ds);                                /* push ds */
            ii(0x19_5a10, 3); pushw(0xfdf);                             /* push 0xfdf */
            ii(0x19_5a13, 3); callw(0x18_ffd5, -0x5a41);                /* call 0xffd5 */
            ii(0x19_5a16, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_5a18, 2); if(jzw(0x19_5a1d, 0x3)) goto l_0x19_5a1d; /* jz 0x5a1d */
            ii(0x19_5a1a, 3); jmpw(0x19_5a2a, 0xd); goto l_0x19_5a2a;   /* jmp 0x5a2a */
        l_0x19_5a1d:
            ii(0x19_5a1d, 5); cmp(memb_a16[ds, 0xd83], 0);              /* cmp byte [0xd83], 0x0 */
            ii(0x19_5a22, 2); if(jzw(0x19_5a27, 0x3)) goto l_0x19_5a27; /* jz 0x5a27 */
            ii(0x19_5a24, 3); jmpw(0x19_5a2a, 0x3); goto l_0x19_5a2a;   /* jmp 0x5a2a */
        l_0x19_5a27:
            ii(0x19_5a27, 3); jmpw(0x19_5990, -0x9a); goto l_0x19_5990; /* jmp 0x5990 */
        l_0x19_5a2a:
            ii(0x19_5a2a, 3); jmpw(0x19_5a49, 0x1c); goto l_0x19_5a49;  /* jmp 0x5a49 */
        l_0x19_5a2d:
            ii(0x19_5a2d, 4); cmp(memb_a16[ss, bp - 0x60], 0);          /* cmp byte [bp-0x60], 0x0 */
            ii(0x19_5a31, 2); if(jnzw(0x19_5a36, 0x3)) goto l_0x19_5a36; /* jnz 0x5a36 */
            ii(0x19_5a33, 3); jmpw(0x19_5a49, 0x13); goto l_0x19_5a49;  /* jmp 0x5a49 */
        l_0x19_5a36:
            ii(0x19_5a36, 3); pushw(memw_a16[ss, bp - 0x62]);           /* push word [bp-0x62] */
            ii(0x19_5a39, 3); pushw(memw_a16[ss, bp - 0x64]);           /* push word [bp-0x64] */
            ii(0x19_5a3c, 1); pushw(ds);                                /* push ds */
            ii(0x19_5a3d, 3); pushw(0xfe3);                             /* push 0xfe3 */
            ii(0x19_5a40, 3); pushw(0x3f1);                             /* push 0x3f1 */
            ii(0x19_5a43, 3); callw(0x19_1046, -0x4a00);                /* call 0x1046 */
            ii(0x19_5a46, 3); add(sp, 0xa);                             /* add sp, 0xa */
        l_0x19_5a49:
            ii(0x19_5a49, 3); lea(ax, bp - 0x5e);                       /* lea ax, [bp-0x5e] */
            ii(0x19_5a4c, 1); pushw(ss);                                /* push ss */
            ii(0x19_5a4d, 1); pushw(ax);                                /* push ax */
            ii(0x19_5a4e, 1); pushw(ds);                                /* push ds */
            ii(0x19_5a4f, 3); pushw(0xffc);                             /* push 0xffc */
            ii(0x19_5a52, 3); callw(0x19_1066, -0x49ef);                /* call 0x1066 */
            ii(0x19_5a55, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_5a58, 3); callw_a16_far_ind(ss, bp - 0x38);         /* call far word [bp-0x38] */
            ii(0x19_5a5b, 4); mov(memw_a16[ss, bp - 0xee], ax);         /* mov [bp-0xee], ax */
            ii(0x19_5a5f, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_5a62, 2); if(jnzw(0x19_5a67, 0x3)) goto l_0x19_5a67; /* jnz 0x5a67 */
            ii(0x19_5a64, 3); jmpw(0x19_5a80, 0x19); goto l_0x19_5a80;  /* jmp 0x5a80 */
        l_0x19_5a67:
            ii(0x19_5a67, 4); mov(ax, memw_a16[ss, bp - 0xee]);         /* mov ax, [bp-0xee] */
            ii(0x19_5a6b, 1); cwd();                                    /* cwd */
            ii(0x19_5a6c, 1); pushw(dx);                                /* push dx */
            ii(0x19_5a6d, 1); pushw(ax);                                /* push ax */
            ii(0x19_5a6e, 3); lea(ax, bp - 0x5e);                       /* lea ax, [bp-0x5e] */
            ii(0x19_5a71, 1); pushw(ss);                                /* push ss */
            ii(0x19_5a72, 1); pushw(ax);                                /* push ax */
            ii(0x19_5a73, 1); pushw(ds);                                /* push ds */
            ii(0x19_5a74, 3); pushw(0x100d);                            /* push 0x100d */
            ii(0x19_5a77, 3); pushw(0x3f2);                             /* push 0x3f2 */
            ii(0x19_5a7a, 3); callw(0x19_1046, -0x4a37);                /* call 0x1046 */
            ii(0x19_5a7d, 3); add(sp, 0xe);                             /* add sp, 0xe */
        l_0x19_5a80:
            ii(0x19_5a80, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_5a83, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_5a86, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_5a89, 4); lea(ax, bp - 0xec);                       /* lea ax, [bp-0xec] */
            ii(0x19_5a8d, 1); pushw(ss);                                /* push ss */
            ii(0x19_5a8e, 1); pushw(ax);                                /* push ax */
            ii(0x19_5a8f, 3); callw(0x19_54b6, -0x5dc);                 /* call 0x54b6 */
            ii(0x19_5a92, 4); lea(ax, bp - 0xec);                       /* lea ax, [bp-0xec] */
            ii(0x19_5a96, 1); pushw(ss);                                /* push ss */
            ii(0x19_5a97, 1); pushw(ax);                                /* push ax */
            ii(0x19_5a98, 3); lea(cx, bp - 0x6a);                       /* lea cx, [bp-0x6a] */
            ii(0x19_5a9b, 1); pushw(ss);                                /* push ss */
            ii(0x19_5a9c, 1); pushw(cx);                                /* push cx */
            ii(0x19_5a9d, 1); pushw(ds);                                /* push ds */
            ii(0x19_5a9e, 3); pushw(0xa7c);                             /* push 0xa7c */
            ii(0x19_5aa1, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x19_5aa4, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x19_5aa7, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x19_5aaa, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x19_5aad, 3); callw_a16_far_ind(ss, bp - 0x34);         /* call far word [bp-0x34] */
            ii(0x19_5ab0, 3); add(sp, 0x14);                            /* add sp, 0x14 */
            ii(0x19_5ab3, 4); mov(memw_a16[ss, bp - 0xee], ax);         /* mov [bp-0xee], ax */
            ii(0x19_5ab7, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_5aba, 2); if(jnzw(0x19_5abf, 0x3)) goto l_0x19_5abf; /* jnz 0x5abf */
            ii(0x19_5abc, 3); jmpw(0x19_5b03, 0x44); goto l_0x19_5b03;  /* jmp 0x5b03 */
        l_0x19_5abf:
            ii(0x19_5abf, 4); lea(ax, bp - 0xec);                       /* lea ax, [bp-0xec] */
            ii(0x19_5ac3, 1); pushw(ss);                                /* push ss */
            ii(0x19_5ac4, 1); pushw(ax);                                /* push ax */
            ii(0x19_5ac5, 3); lea(cx, bp - 0x5e);                       /* lea cx, [bp-0x5e] */
            ii(0x19_5ac8, 1); pushw(ss);                                /* push ss */
            ii(0x19_5ac9, 1); pushw(cx);                                /* push cx */
            ii(0x19_5aca, 3); callw(0x18_ff6c, -0x5b61);                /* call 0xff6c */
            ii(0x19_5acd, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x19_5ad0, 3); or(ax, memw_a16[ss, bp - 0x14]);          /* or ax, [bp-0x14] */
            ii(0x19_5ad3, 2); if(jnzw(0x19_5ad8, 0x3)) goto l_0x19_5ad8; /* jnz 0x5ad8 */
            ii(0x19_5ad5, 3); jmpw(0x19_5aef, 0x17); goto l_0x19_5aef;  /* jmp 0x5aef */
        l_0x19_5ad8:
            ii(0x19_5ad8, 4); lea(ax, bp - 0xec);                       /* lea ax, [bp-0xec] */
            ii(0x19_5adc, 1); pushw(ss);                                /* push ss */
            ii(0x19_5add, 1); pushw(ax);                                /* push ax */
            ii(0x19_5ade, 4); mov(ax, memw_a16[ss, bp - 0xee]);         /* mov ax, [bp-0xee] */
            ii(0x19_5ae2, 1); cwd();                                    /* cwd */
            ii(0x19_5ae3, 1); pushw(dx);                                /* push dx */
            ii(0x19_5ae4, 1); pushw(ax);                                /* push ax */
            ii(0x19_5ae5, 3); callw_a16_far_ind(ss, bp - 0x14);         /* call far word [bp-0x14] */
            ii(0x19_5ae8, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_5aeb, 4); mov(memw_a16[ss, bp - 0xee], ax);         /* mov [bp-0xee], ax */
        l_0x19_5aef:
            ii(0x19_5aef, 4); lea(ax, bp - 0xec);                       /* lea ax, [bp-0xec] */
            ii(0x19_5af3, 1); pushw(ss);                                /* push ss */
            ii(0x19_5af4, 1); pushw(ax);                                /* push ax */
            ii(0x19_5af5, 1); pushw(ds);                                /* push ds */
            ii(0x19_5af6, 3); pushw(0x102f);                            /* push 0x102f */
            ii(0x19_5af9, 4); pushw(memw_a16[ss, bp - 0xee]);           /* push word [bp-0xee] */
            ii(0x19_5afd, 3); callw(0x19_1046, -0x4aba);                /* call 0x1046 */
            ii(0x19_5b00, 3); add(sp, 0xa);                             /* add sp, 0xa */
        l_0x19_5b03:
            ii(0x19_5b03, 3); lea(ax, bp - 0x3c);                       /* lea ax, [bp-0x3c] */
            ii(0x19_5b06, 4); mov(es, memw_a16[ds, 0x3f8e]);            /* mov es, [0x3f8e] */
            ii(0x19_5b0a, 4); mov(memw_a16[es, 0x17ba], ax);            /* mov [es:0x17ba], ax */
            ii(0x19_5b0e, 5); mov(memw_a16[es, 0x17bc], ss);            /* mov [es:0x17bc], ss */
            ii(0x19_5b13, 3); mov(ax, memw_a16[ss, bp - 0x6a]);         /* mov ax, [bp-0x6a] */
            ii(0x19_5b16, 3); mov(dx, memw_a16[ss, bp - 0x68]);         /* mov dx, [bp-0x68] */
            ii(0x19_5b19, 4); mov(es, memw_a16[ds, 0x3f90]);            /* mov es, [0x3f90] */
            ii(0x19_5b1d, 4); mov(memw_a16[es, 0x17be], ax);            /* mov [es:0x17be], ax */
            ii(0x19_5b21, 5); mov(memw_a16[es, 0x17c0], dx);            /* mov [es:0x17c0], dx */
            ii(0x19_5b26, 6); mov(memw_a16[ds, 0xab6], 0x200);          /* mov word [0xab6], 0x200 */
            ii(0x19_5b2c, 6); mov(memw_a16[ds, 0xab8], 0);              /* mov word [0xab8], 0x0 */
            ii(0x19_5b32, 4); cmp(memb_a16[ss, bp - 0x66], 0);          /* cmp byte [bp-0x66], 0x0 */
            ii(0x19_5b36, 2); if(jnzw(0x19_5b3b, 0x3)) goto l_0x19_5b3b; /* jnz 0x5b3b */
            ii(0x19_5b38, 3); jmpw(0x19_5b4c, 0x11); goto l_0x19_5b4c;  /* jmp 0x5b4c */
        l_0x19_5b3b:
            ii(0x19_5b3b, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_5b3d, 3); pushw(memw_a16[ss, bp - 0x62]);           /* push word [bp-0x62] */
            ii(0x19_5b40, 3); pushw(memw_a16[ss, bp - 0x64]);           /* push word [bp-0x64] */
            ii(0x19_5b43, 4); pushw(memw_a16[ds, 0xa8c]);               /* push word [0xa8c] */
            ii(0x19_5b47, 1); nop();                                    /* nop */
            ii(0x19_5b48, 1); pushw(cs);                                /* push cs */
            ii(0x19_5b49, 3); callw(0x19_0d27, -0x4e25);                /* call 0xd27 */
        l_0x19_5b4c:
            ii(0x19_5b4c, 4); cmp(memb_a16[ss, bp - 0x66], 0);          /* cmp byte [bp-0x66], 0x0 */
            ii(0x19_5b50, 2); if(jzw(0x19_5b55, 0x3)) goto l_0x19_5b55; /* jz 0x5b55 */
            ii(0x19_5b52, 3); jmpw(0x19_5b84, 0x2f); goto l_0x19_5b84;  /* jmp 0x5b84 */
        l_0x19_5b55:
            ii(0x19_5b55, 4); pushw(memw_a16[ds, 0xab0]);               /* push word [0xab0] */
            ii(0x19_5b59, 4); pushw(memw_a16[ds, 0xaae]);               /* push word [0xaae] */
            ii(0x19_5b5d, 4); pushw(memw_a16[ds, 0xab2]);               /* push word [0xab2] */
            ii(0x19_5b61, 1); nop();                                    /* nop */
            ii(0x19_5b62, 1); pushw(cs);                                /* push cs */
            ii(0x19_5b63, 3); callw(0x19_5da2, 0x23c);                  /* call 0x5da2 */
            ii(0x19_5b66, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_5b69, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_5b6c, 2); if(jzw(0x19_5b71, 0x3)) goto l_0x19_5b71; /* jz 0x5b71 */
            ii(0x19_5b6e, 3); jmpw(0x19_5b84, 0x13); goto l_0x19_5b84;  /* jmp 0x5b84 */
        l_0x19_5b71:
            ii(0x19_5b71, 3); pushw(memw_a16[ss, bp - 0x62]);           /* push word [bp-0x62] */
            ii(0x19_5b74, 3); pushw(memw_a16[ss, bp - 0x64]);           /* push word [bp-0x64] */
            ii(0x19_5b77, 1); pushw(ds);                                /* push ds */
            ii(0x19_5b78, 3); pushw(0x1033);                            /* push 0x1033 */
            ii(0x19_5b7b, 3); pushw(0x3f4);                             /* push 0x3f4 */
            ii(0x19_5b7e, 3); callw(0x19_1046, -0x4b3b);                /* call 0x1046 */
            ii(0x19_5b81, 3); add(sp, 0xa);                             /* add sp, 0xa */
        l_0x19_5b84:
            ii(0x19_5b84, 4); pushw(memw_a16[ds, 0xab2]);               /* push word [0xab2] */
            ii(0x19_5b88, 4); pushw(memw_a16[ds, 0xaae]);               /* push word [0xaae] */
            ii(0x19_5b8c, 1); nop();                                    /* nop */
            ii(0x19_5b8d, 1); pushw(cs);                                /* push cs */
            ii(0x19_5b8e, 3); callw(0x19_0de7, -0x4daa);                /* call 0xde7 */
            ii(0x19_5b91, 5); test(memb_a16[ds, 0x36f6], 0x1);          /* test byte [0x36f6], 0x1 */
            ii(0x19_5b96, 2); if(jnzw(0x19_5b9b, 0x3)) goto l_0x19_5b9b; /* jnz 0x5b9b */
            ii(0x19_5b98, 3); jmpw(0x19_5be3, 0x48); goto l_0x19_5be3;  /* jmp 0x5be3 */
        l_0x19_5b9b:
            ii(0x19_5b9b, 3); pushw(memw_a16[ss, bp - 0x62]);           /* push word [bp-0x62] */
            ii(0x19_5b9e, 3); pushw(memw_a16[ss, bp - 0x64]);           /* push word [bp-0x64] */
            ii(0x19_5ba1, 1); pushw(ds);                                /* push ds */
            ii(0x19_5ba2, 3); pushw(0x104f);                            /* push 0x104f */
            ii(0x19_5ba5, 3); callw(0x19_105e, -0x4b4a);                /* call 0x105e */
            ii(0x19_5ba8, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_5bab, 1); pushw(ds);                                /* push ds */
            ii(0x19_5bac, 3); pushw(0xa7c);                             /* push 0xa7c */
            ii(0x19_5baf, 1); nop();                                    /* nop */
            ii(0x19_5bb0, 1); pushw(cs);                                /* push cs */
            ii(0x19_5bb1, 3); callw(0x18_f8ec, -0x62c8);                /* call 0xf8ec */
            ii(0x19_5bb4, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_5bb7, 1); pushw(ds);                                /* push ds */
            ii(0x19_5bb8, 3); pushw(0x1074);                            /* push 0x1074 */
            ii(0x19_5bbb, 4); pushw(memw_a16[ds, 0xab2]);               /* push word [0xab2] */
            ii(0x19_5bbf, 3); callw(0x19_5c7a, 0xb8);                   /* call 0x5c7a */
            ii(0x19_5bc2, 1); pushw(ds);                                /* push ds */
            ii(0x19_5bc3, 3); pushw(0x1077);                            /* push 0x1077 */
            ii(0x19_5bc6, 4); pushw(memw_a16[ds, 0xa80]);               /* push word [0xa80] */
            ii(0x19_5bca, 3); callw(0x19_5c7a, 0xad);                   /* call 0x5c7a */
            ii(0x19_5bcd, 1); pushw(ds);                                /* push ds */
            ii(0x19_5bce, 3); pushw(0x107a);                            /* push 0x107a */
            ii(0x19_5bd1, 4); pushw(memw_a16[ds, 0xa82]);               /* push word [0xa82] */
            ii(0x19_5bd5, 3); callw(0x19_5c7a, 0xa2);                   /* call 0x5c7a */
            ii(0x19_5bd8, 1); pushw(ds);                                /* push ds */
            ii(0x19_5bd9, 3); pushw(0x107d);                            /* push 0x107d */
            ii(0x19_5bdc, 4); pushw(memw_a16[ds, 0xa7e]);               /* push word [0xa7e] */
            ii(0x19_5be0, 3); callw(0x19_5c7a, 0x97);                   /* call 0x5c7a */
        l_0x19_5be3:
            ii(0x19_5be3, 1); nop();                                    /* nop */
            ii(0x19_5be4, 1); pushw(cs);                                /* push cs */
            ii(0x19_5be5, 3); callw(0x18_f01e, -0x6bca);                /* call 0xf01e */
            ii(0x19_5be8, 5); cmp(memw_a16[ds, 0xd88], 0);              /* cmp word [0xd88], 0x0 */
            ii(0x19_5bed, 2); if(jnzw(0x19_5bf2, 0x3)) goto l_0x19_5bf2; /* jnz 0x5bf2 */
            ii(0x19_5bef, 3); jmpw(0x19_5c6a, 0x78); goto l_0x19_5c6a;  /* jmp 0x5c6a */
        l_0x19_5bf2:
            ii(0x19_5bf2, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x19_5bf4, 4); mov(es, memw_a16[ds, 0x3f88]);            /* mov es, [0x3f88] */
            ii(0x19_5bf8, 4); mov(ax, memw_a16[es, 0x3b7e]);            /* mov ax, [es:0x3b7e] */
            ii(0x19_5bfc, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x19_5bfe, 1); pushw(ax);                                /* push ax */
            ii(0x19_5bff, 1); pushw(cx);                                /* push cx */
            ii(0x19_5c00, 1); nop();                                    /* nop */
            ii(0x19_5c01, 1); pushw(cs);                                /* push cs */
            ii(0x19_5c02, 3); callw(0x18_f038, -0x6bcd);                /* call 0xf038 */
            ii(0x19_5c05, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_5c08, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x19_5c0a, 4); mov(es, memw_a16[ds, 0x3f88]);            /* mov es, [0x3f88] */
            ii(0x19_5c0e, 3); mov(ax, 0x4);                             /* mov ax, 0x4 */
            ii(0x19_5c11, 5); mov(dx, memw_a16[es, 0x3b7e]);            /* mov dx, [es:0x3b7e] */
            ii(0x19_5c16, 1); pushw(dx);                                /* push dx */
            ii(0x19_5c17, 1); pushw(ax);                                /* push ax */
            ii(0x19_5c18, 1); nop();                                    /* nop */
            ii(0x19_5c19, 1); pushw(cs);                                /* push cs */
            ii(0x19_5c1a, 3); callw(0x18_f038, -0x6be5);                /* call 0xf038 */
            ii(0x19_5c1d, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_5c20, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x19_5c22, 4); mov(es, memw_a16[ds, 0x3f88]);            /* mov es, [0x3f88] */
            ii(0x19_5c26, 3); mov(ax, 0x8);                             /* mov ax, 0x8 */
            ii(0x19_5c29, 5); mov(dx, memw_a16[es, 0x3b7e]);            /* mov dx, [es:0x3b7e] */
            ii(0x19_5c2e, 1); pushw(dx);                                /* push dx */
            ii(0x19_5c2f, 1); pushw(ax);                                /* push ax */
            ii(0x19_5c30, 1); nop();                                    /* nop */
            ii(0x19_5c31, 1); pushw(cs);                                /* push cs */
            ii(0x19_5c32, 3); callw(0x18_f038, -0x6bfd);                /* call 0xf038 */
            ii(0x19_5c35, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_5c38, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x19_5c3a, 4); mov(es, memw_a16[ds, 0x3f88]);            /* mov es, [0x3f88] */
            ii(0x19_5c3e, 3); mov(ax, 0xc);                             /* mov ax, 0xc */
            ii(0x19_5c41, 5); mov(dx, memw_a16[es, 0x3b7e]);            /* mov dx, [es:0x3b7e] */
            ii(0x19_5c46, 1); pushw(dx);                                /* push dx */
            ii(0x19_5c47, 1); pushw(ax);                                /* push ax */
            ii(0x19_5c48, 1); nop();                                    /* nop */
            ii(0x19_5c49, 1); pushw(cs);                                /* push cs */
            ii(0x19_5c4a, 3); callw(0x18_f038, -0x6c15);                /* call 0xf038 */
            ii(0x19_5c4d, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_5c50, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x19_5c52, 1); nop();                                    /* nop */
            ii(0x19_5c53, 1); pushw(cs);                                /* push cs */
            ii(0x19_5c54, 3); callw(0x18_f57c, -0x66db);                /* call 0xf57c */
            ii(0x19_5c57, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x19_5c5a, 4); mov(es, memw_a16[ds, 0x3f92]);            /* mov es, [0x3f92] */
            ii(0x19_5c5e, 7); mov(memw_a16[es, 0x1670], 0x1080);        /* mov word [es:0x1670], 0x1080 */
            ii(0x19_5c65, 5); mov(memw_a16[es, 0x1672], ds);            /* mov [es:0x1672], ds */
        l_0x19_5c6a:
            ii(0x19_5c6a, 1); pushw(ds);                                /* push ds */
            ii(0x19_5c6b, 3); pushw(0xa7c);                             /* push 0xa7c */
            ii(0x19_5c6e, 5); callw_far_abs(0x80, 0x4ce);               /* call word 0x80:0x4ce */
            ii(0x19_5c73, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_5c76, 1); popw(si);                                 /* pop si */
            ii(0x19_5c77, 1); popw(di);                                 /* pop di */
            ii(0x19_5c78, 1); leavew();                                 /* leave */
            ii(0x19_5c79, 1); retfw();                                  /* retf */
        }
    }
}
