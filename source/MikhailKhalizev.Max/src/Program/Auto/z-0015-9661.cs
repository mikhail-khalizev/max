using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("02df7054-7562-4e50-b3f9-dcdcb80409b4")]
        public void Method_0015_9661()
        {
            ii(0x15_9661, 4); enterw(0x28, 0);                          /* enter 0x28, 0x0 */
            ii(0x15_9665, 1); pushw(ds);                                /* push ds */
            ii(0x15_9666, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_9669, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_966b, 4); mov(es, memw_a16[ds, 0x3fbc]);            /* mov es, [0x3fbc] */
            ii(0x15_966f, 4); mov(ax, memw_a16[es, 0x3b78]);            /* mov ax, [es:0x3b78] */
            ii(0x15_9673, 5); mov(memw_a16[ss, bp - 0x28], 0);          /* mov word [bp-0x28], 0x0 */
            ii(0x15_9678, 3); mov(memw_a16[ss, bp - 0x26], ax);         /* mov [bp-0x26], ax */
            ii(0x15_967b, 5); cmp(memb_a16[ds, 0x1a02], 0);             /* cmp byte [0x1a02], 0x0 */
            ii(0x15_9680, 2); if(jzw(0x15_9689, 0x7)) goto l_0x15_9689; /* jz 0x9689 */
        l_0x15_9682:
            ii(0x15_9682, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x15_9684:
            ii(0x15_9684, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_9686, 1); popw(ds);                                 /* pop ds */
            ii(0x15_9687, 1); leavew();                                 /* leave */
            ii(0x15_9688, 1); retfw(); return;                          /* retf */
        l_0x15_9689:
            ii(0x15_9689, 1); pushw(ds);                                /* push ds */
            ii(0x15_968a, 3); pushw(0x1b7b);                            /* push 0x1b7b */
            ii(0x15_968d, 5); callw_far_abs(0x80, 0x20cc);              /* call word 0x80:0x20cc */
            ii(0x15_9692, 3); callw(0x15_8bd0, -0xac5);                 /* call 0x8bd0 */
            ii(0x15_9695, 1); nop();                                    /* nop */
            ii(0x15_9696, 1); pushw(cs);                                /* push cs */
            ii(0x15_9697, 3); callw(0x16_0016, 0x697c);                 /* call 0x16 */
            ii(0x15_969a, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_969c, 2); if(jnzw(0x15_96a1, 0x3)) goto l_0x15_96a1; /* jnz 0x96a1 */
            ii(0x15_969e, 3); jmpw(0x15_9818, 0x177); goto l_0x15_9818; /* jmp 0x9818 */
        l_0x15_96a1:
            ii(0x15_96a1, 1); pushw(ds);                                /* push ds */
            ii(0x15_96a2, 3); pushw(0x1b82);                            /* push 0x1b82 */
            ii(0x15_96a5, 1); pushw(ds);                                /* push ds */
            ii(0x15_96a6, 3); pushw(0x36f6);                            /* push 0x36f6 */
            ii(0x15_96a9, 1); nop();                                    /* nop */
            ii(0x15_96aa, 1); pushw(cs);                                /* push cs */
            ii(0x15_96ab, 3); callw(0x16_0475, 0x6dc7);                 /* call 0x475 */
            ii(0x15_96ae, 1); nop();                                    /* nop */
            ii(0x15_96af, 1); pushw(cs);                                /* push cs */
            ii(0x15_96b0, 3); callw(0x16_0809, 0x7156);                 /* call 0x809 */
            ii(0x15_96b3, 1); pushw(ds);                                /* push ds */
            ii(0x15_96b4, 3); pushw(0x1b89);                            /* push 0x1b89 */
            ii(0x15_96b7, 5); callw_far_abs(0x80, 0x5ba0);              /* call word 0x80:0x5ba0 */
            ii(0x15_96bc, 1); popw(bx);                                 /* pop bx */
            ii(0x15_96bd, 1); popw(bx);                                 /* pop bx */
            ii(0x15_96be, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_96c1, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_96c4, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_96c6, 2); if(jnzw(0x15_96cb, 0x3)) goto l_0x15_96cb; /* jnz 0x96cb */
            ii(0x15_96c8, 3); jmpw(0x15_97fe, 0x133); goto l_0x15_97fe; /* jmp 0x97fe */
        l_0x15_96cb:
            ii(0x15_96cb, 3); les(bx, ss, bp - 0x28);                   /* les bx, [bp-0x28] */
            ii(0x15_96ce, 5); test(memb_a16[es, bx + 0x47], 0x80);      /* test byte [es:bx+0x47], 0x80 */
            ii(0x15_96d3, 2); if(jnzw(0x15_96e4, 0xf)) goto l_0x15_96e4; /* jnz 0x96e4 */
            ii(0x15_96d5, 1); pushw(ds);                                /* push ds */
            ii(0x15_96d6, 3); pushw(0x1b8f);                            /* push 0x1b8f */
            ii(0x15_96d9, 5); callw_far_abs(0x80, 0x5ba0);              /* call word 0x80:0x5ba0 */
            ii(0x15_96de, 1); popw(bx);                                 /* pop bx */
            ii(0x15_96df, 1); popw(bx);                                 /* pop bx */
            ii(0x15_96e0, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_96e2, 2); if(jzw(0x15_96f7, 0x13)) goto l_0x15_96f7; /* jz 0x96f7 */
        l_0x15_96e4:
            ii(0x15_96e4, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_96e6, 1); pushw(ds);                                /* push ds */
            ii(0x15_96e7, 3); pushw(0x1b98);                            /* push 0x1b98 */
            ii(0x15_96ea, 1); nop();                                    /* nop */
            ii(0x15_96eb, 1); pushw(cs);                                /* push cs */
            ii(0x15_96ec, 3); callw(0x15_cd5c, 0x366d);                 /* call 0xcd5c */
            ii(0x15_96ef, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_96f2, 3); mov(memb_a16[ds, 0x19f5], al);            /* mov [0x19f5], al */
            ii(0x15_96f5, 2); jmpw(0x15_972b, 0x34); goto l_0x15_972b;  /* jmp 0x972b */
        l_0x15_96f7:
            ii(0x15_96f7, 5); mov(memb_a16[ds, 0x19f5], 0x1);           /* mov byte [0x19f5], 0x1 */
            ii(0x15_96fc, 1); pushw(ds);                                /* push ds */
            ii(0x15_96fd, 3); pushw(0x1ba8);                            /* push 0x1ba8 */
            ii(0x15_9700, 1); pushw(ds);                                /* push ds */
            ii(0x15_9701, 3); pushw(0x1ba3);                            /* push 0x1ba3 */
            ii(0x15_9704, 3); callw(0x15_fcad, 0x65a6);                 /* call 0xfcad */
            ii(0x15_9707, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x15_970a, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x15_970d, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_970f, 2); if(jzw(0x15_972b, 0x1a)) goto l_0x15_972b; /* jz 0x972b */
            ii(0x15_9711, 1); pushw(ds);                                /* push ds */
            ii(0x15_9712, 3); pushw(0x1bb3);                            /* push 0x1bb3 */
            ii(0x15_9715, 3); callw_a16_far_ind(ss, bp - 0x8);          /* call far word [bp-0x8] */
            ii(0x15_9718, 1); pushw(dx);                                /* push dx */
            ii(0x15_9719, 1); pushw(ax);                                /* push ax */
            ii(0x15_971a, 5); callw_far_abs(0x80, 0x3fc4);              /* call word 0x80:0x3fc4 */
            ii(0x15_971f, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_9722, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_9724, 2); if(jzw(0x15_972b, 0x5)) goto l_0x15_972b; /* jz 0x972b */
            ii(0x15_9726, 5); mov(memb_a16[ds, 0x19f5], 0);             /* mov byte [0x19f5], 0x0 */
        l_0x15_972b:
            ii(0x15_972b, 5); cmp(memb_a16[ds, 0x19f5], 0);             /* cmp byte [0x19f5], 0x0 */
            ii(0x15_9730, 2); if(jnzw(0x15_9735, 0x3)) goto l_0x15_9735; /* jnz 0x9735 */
            ii(0x15_9732, 3); jmpw(0x15_97f0, 0xbb); goto l_0x15_97f0;  /* jmp 0x97f0 */
        l_0x15_9735:
            ii(0x15_9735, 1); pushw(ds);                                /* push ds */
            ii(0x15_9736, 3); pushw(0x1bbd);                            /* push 0x1bbd */
            ii(0x15_9739, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_973c, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_973f, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x15_9744, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_9747, 3); mov(memw_a16[ds, 0x1a04], ax);            /* mov [0x1a04], ax */
            ii(0x15_974a, 4); mov(memw_a16[ds, 0x1a06], dx);            /* mov [0x1a06], dx */
            ii(0x15_974e, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x15_9750, 4); or(ax, memw_a16[ds, 0x1a04]);             /* or ax, [0x1a04] */
            ii(0x15_9754, 2); if(jnzw(0x15_9759, 0x3)) goto l_0x15_9759; /* jnz 0x9759 */
            ii(0x15_9756, 3); jmpw(0x15_97f0, 0x97); goto l_0x15_97f0;  /* jmp 0x97f0 */
        l_0x15_9759:
            ii(0x15_9759, 1); pushw(ds);                                /* push ds */
            ii(0x15_975a, 3); pushw(0x1bc6);                            /* push 0x1bc6 */
            ii(0x15_975d, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_9760, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_9763, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x15_9768, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_976b, 3); mov(memw_a16[ds, 0x1a10], ax);            /* mov [0x1a10], ax */
            ii(0x15_976e, 4); mov(memw_a16[ds, 0x1a12], dx);            /* mov [0x1a12], dx */
            ii(0x15_9772, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x15_9774, 4); or(ax, memw_a16[ds, 0x1a10]);             /* or ax, [0x1a10] */
            ii(0x15_9778, 2); if(jzw(0x15_97f0, 0x76)) goto l_0x15_97f0; /* jz 0x97f0 */
            ii(0x15_977a, 1); pushw(ds);                                /* push ds */
            ii(0x15_977b, 3); pushw(0x1bcc);                            /* push 0x1bcc */
            ii(0x15_977e, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_9781, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_9784, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x15_9789, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_978c, 3); mov(memw_a16[ds, 0x1a08], ax);            /* mov [0x1a08], ax */
            ii(0x15_978f, 4); mov(memw_a16[ds, 0x1a0a], dx);            /* mov [0x1a0a], dx */
            ii(0x15_9793, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x15_9795, 4); or(ax, memw_a16[ds, 0x1a08]);             /* or ax, [0x1a08] */
            ii(0x15_9799, 2); if(jzw(0x15_97f0, 0x55)) goto l_0x15_97f0; /* jz 0x97f0 */
            ii(0x15_979b, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_979d, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_979f, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_97a1, 5); callw_far_abs(0x80, 0x562c);              /* call word 0x80:0x562c */
            ii(0x15_97a6, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_97a9, 3); mov(memw_a16[ds, 0x19f6], ax);            /* mov [0x19f6], ax */
            ii(0x15_97ac, 4); mov(memw_a16[ds, 0x19f8], dx);            /* mov [0x19f8], dx */
            ii(0x15_97b0, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_97b2, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_97b4, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_97b6, 5); callw_far_abs(0x80, 0x562c);              /* call word 0x80:0x562c */
            ii(0x15_97bb, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_97be, 3); mov(memw_a16[ds, 0x19fa], ax);            /* mov [0x19fa], ax */
            ii(0x15_97c1, 4); mov(memw_a16[ds, 0x19fc], dx);            /* mov [0x19fc], dx */
            ii(0x15_97c5, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_97c7, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_97c9, 3); pushw(0x88);                              /* push 0x88 */
            ii(0x15_97cc, 3); pushw(0x8be1);                            /* push 0x8be1 */
            ii(0x15_97cf, 4); callw_a16_far_ind(ds, 0x1a10);            /* call far word [0x1a10] */
            ii(0x15_97d3, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_97d6, 3); mov(memw_a16[ds, 0x19fe], ax);            /* mov [0x19fe], ax */
            ii(0x15_97d9, 4); mov(memw_a16[ds, 0x1a00], dx);            /* mov [0x1a00], dx */
            ii(0x15_97dd, 1); pushw(dx);                                /* push dx */
            ii(0x15_97de, 1); pushw(ax);                                /* push ax */
            ii(0x15_97df, 1); pushw(ds);                                /* push ds */
            ii(0x15_97e0, 3); pushw(0x1bd5);                            /* push 0x1bd5 */
            ii(0x15_97e3, 3); callw(0x16_1066, 0x7880);                 /* call 0x1066 */
            ii(0x15_97e6, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_97e9, 5); mov(memb_a16[ds, 0x19f4], 0x1);           /* mov byte [0x19f4], 0x1 */
            ii(0x15_97ee, 2); jmpw(0x15_97fe, 0xe); goto l_0x15_97fe;   /* jmp 0x97fe */
        l_0x15_97f0:
            ii(0x15_97f0, 1); pushw(ds);                                /* push ds */
            ii(0x15_97f1, 3); pushw(0x1c07);                            /* push 0x1c07 */
            ii(0x15_97f4, 3); callw(0x16_1066, 0x786f);                 /* call 0x1066 */
            ii(0x15_97f7, 1); popw(bx);                                 /* pop bx */
            ii(0x15_97f8, 1); popw(bx);                                 /* pop bx */
            ii(0x15_97f9, 5); mov(memb_a16[ds, 0x19f4], 0x2);           /* mov byte [0x19f4], 0x2 */
        l_0x15_97fe:
            ii(0x15_97fe, 1); pushw(ds);                                /* push ds */
            ii(0x15_97ff, 3); pushw(0x1c48);                            /* push 0x1c48 */
            ii(0x15_9802, 1); pushw(ds);                                /* push ds */
            ii(0x15_9803, 3); pushw(0x1c3a);                            /* push 0x1c3a */
            ii(0x15_9806, 3); callw(0x15_fcad, 0x64a4);                 /* call 0xfcad */
            ii(0x15_9809, 3); mov(memw_a16[ds, 0x1a0c], ax);            /* mov [0x1a0c], ax */
            ii(0x15_980c, 4); mov(memw_a16[ds, 0x1a0e], dx);            /* mov [0x1a0e], dx */
            ii(0x15_9810, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x15_9812, 4); or(ax, memw_a16[ds, 0x1a0c]);             /* or ax, [0x1a0c] */
            ii(0x15_9816, 2); if(jnzw(0x15_9821, 0x9)) goto l_0x15_9821; /* jnz 0x9821 */
        l_0x15_9818:
            ii(0x15_9818, 3); callw(0x15_8bea, -0xc31);                 /* call 0x8bea */
            ii(0x15_981b, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_981e, 3); jmpw(0x15_9684, -0x19d); goto l_0x15_9684; /* jmp 0x9684 */
        l_0x15_9821:
            ii(0x15_9821, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_9823, 1); pushw(ds);                                /* push ds */
            ii(0x15_9824, 3); pushw(0x1c51);                            /* push 0x1c51 */
            ii(0x15_9827, 1); nop();                                    /* nop */
            ii(0x15_9828, 1); pushw(cs);                                /* push cs */
            ii(0x15_9829, 3); callw(0x15_cd5c, 0x3530);                 /* call 0xcd5c */
            ii(0x15_982c, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_982f, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_9831, 2); if(jzw(0x15_9855, 0x22)) goto l_0x15_9855; /* jz 0x9855 */
            ii(0x15_9833, 1); pushw(ds);                                /* push ds */
            ii(0x15_9834, 3); pushw(0x1c58);                            /* push 0x1c58 */
            ii(0x15_9837, 3); callw(0x16_1066, 0x782c);                 /* call 0x1066 */
            ii(0x15_983a, 1); popw(bx);                                 /* pop bx */
            ii(0x15_983b, 1); popw(bx);                                 /* pop bx */
            ii(0x15_983c, 5); mov(memb_a16[ds, 0x19f3], 0x2);           /* mov byte [0x19f3], 0x2 */
            ii(0x15_9841, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_9843, 3); mov(memw_a16[ds, 0x19ec], ax);            /* mov [0x19ec], ax */
            ii(0x15_9846, 3); mov(memw_a16[ds, 0x19ea], ax);            /* mov [0x19ea], ax */
            ii(0x15_9849, 6); mov(memw_a16[ds, 0x19ee], 0xffff);        /* mov word [0x19ee], 0xffff */
            ii(0x15_984f, 6); mov(memw_a16[ds, 0x19f0], 0xffff);        /* mov word [0x19f0], 0xffff */
        l_0x15_9855:
            ii(0x15_9855, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_9857, 1); pushw(ds);                                /* push ds */
            ii(0x15_9858, 3); pushw(0x1c8f);                            /* push 0x1c8f */
            ii(0x15_985b, 1); nop();                                    /* nop */
            ii(0x15_985c, 1); pushw(cs);                                /* push cs */
            ii(0x15_985d, 3); callw(0x15_cd5c, 0x34fc);                 /* call 0xcd5c */
            ii(0x15_9860, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_9863, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_9865, 2); if(jzw(0x15_986c, 0x5)) goto l_0x15_986c; /* jz 0x986c */
            ii(0x15_9867, 5); mov(memb_a16[ds, 0x1a03], 0x1);           /* mov byte [0x1a03], 0x1 */
        l_0x15_986c:
            ii(0x15_986c, 5); callw_far_abs(0x90, 0x729);               /* call word 0x90:0x729 */
            ii(0x15_9871, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_9873, 2); if(jzw(0x15_98b1, 0x3c)) goto l_0x15_98b1; /* jz 0x98b1 */
            ii(0x15_9875, 1); pushw(ds);                                /* push ds */
            ii(0x15_9876, 3); pushw(0x1c95);                            /* push 0x1c95 */
            ii(0x15_9879, 3); callw(0x16_105e, 0x77e2);                 /* call 0x105e */
            ii(0x15_987c, 1); popw(bx);                                 /* pop bx */
            ii(0x15_987d, 1); popw(bx);                                 /* pop bx */
            ii(0x15_987e, 5); cmp(memb_a16[ds, 0x19f5], 0);             /* cmp byte [0x19f5], 0x0 */
            ii(0x15_9883, 2); if(jzw(0x15_988a, 0x5)) goto l_0x15_988a; /* jz 0x988a */
            ii(0x15_9885, 3); mov(ax, 0x1cab);                          /* mov ax, 0x1cab */
            ii(0x15_9888, 2); jmpw(0x15_988d, 0x3); goto l_0x15_988d;   /* jmp 0x988d */
        l_0x15_988a:
            ii(0x15_988a, 3); mov(ax, 0x1caf);                          /* mov ax, 0x1caf */
        l_0x15_988d:
            ii(0x15_988d, 1); pushw(ds);                                /* push ds */
            ii(0x15_988e, 1); pushw(ax);                                /* push ax */
            ii(0x15_988f, 1); pushw(ds);                                /* push ds */
            ii(0x15_9890, 3); pushw(0x1cb2);                            /* push 0x1cb2 */
            ii(0x15_9893, 1); pushw(ds);                                /* push ds */
            ii(0x15_9894, 3); pushw(0x1cbd);                            /* push 0x1cbd */
            ii(0x15_9897, 3); callw(0x16_105e, 0x77c4);                 /* call 0x105e */
            ii(0x15_989a, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_989d, 3); pushw(0xa8);                              /* push 0xa8 */
            ii(0x15_98a0, 3); pushw(0x34b4);                            /* push 0x34b4 */
            ii(0x15_98a3, 1); pushw(ds);                                /* push ds */
            ii(0x15_98a4, 3); pushw(0x1cc8);                            /* push 0x1cc8 */
            ii(0x15_98a7, 1); pushw(ds);                                /* push ds */
            ii(0x15_98a8, 3); pushw(0x1cd2);                            /* push 0x1cd2 */
            ii(0x15_98ab, 3); callw(0x16_105e, 0x77b0);                 /* call 0x105e */
            ii(0x15_98ae, 3); add(sp, 0xc);                             /* add sp, 0xc */
        l_0x15_98b1:
            ii(0x15_98b1, 3); callw(0x15_9db8, 0x504);                  /* call 0x9db8 */
            ii(0x15_98b4, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_98b6, 2); if(jnzw(0x15_98bb, 0x3)) goto l_0x15_98bb; /* jnz 0x98bb */
            ii(0x15_98b8, 3); jmpw(0x15_9818, -0xa3); goto l_0x15_9818; /* jmp 0x9818 */
        l_0x15_98bb:
            ii(0x15_98bb, 4); inc(memb_a16[ds, 0x1a02]);                /* inc byte [0x1a02] */
            ii(0x15_98bf, 3); callw(0x15_8bea, -0xcd8);                 /* call 0x8bea */
            ii(0x15_98c2, 3); jmpw(0x15_9682, -0x243); goto l_0x15_9682; /* jmp 0x9682 */
        }
    }
}
