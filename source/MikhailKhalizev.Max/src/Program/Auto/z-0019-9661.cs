using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_9661-53d28ba")]
        public void Method_0019_9661()
        {
            ii(0x19_9661, 4); enter(0x28, 0);                           /* enter 0x28, 0x0 */
            ii(0x19_9665, 1); push(ds);                                 /* push ds */
            ii(0x19_9666, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_9669, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_966b, 4); mov(es, memw[ds, 0x3fbc]);                /* mov es, [0x3fbc] */
            ii(0x19_966f, 4); mov(ax, memw[es, 0x3b78]);                /* mov ax, [es:0x3b78] */
            ii(0x19_9673, 5); mov(memw[ss, bp - 0x28], 0);              /* mov word [bp-0x28], 0x0 */
            ii(0x19_9678, 3); mov(memw[ss, bp - 0x26], ax);             /* mov [bp-0x26], ax */
            ii(0x19_967b, 5); cmp(memb[ds, 0x1a02], 0);                 /* cmp byte [0x1a02], 0x0 */
            ii(0x19_9680, 2); if(jz(0x19_9689, 0x7)) goto l_0x19_9689;  /* jz 0x9689 */
        l_0x19_9682:
            ii(0x19_9682, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_9684:
            ii(0x19_9684, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x19_9686, 1); pop(ds);                                  /* pop ds */
            ii(0x19_9687, 1); leave();                                  /* leave */
            ii(0x19_9688, 1); retf(); return;                           /* retf */
        l_0x19_9689:
            ii(0x19_9689, 1); push(ds);                                 /* push ds */
            ii(0x19_968a, 3); push(0x1b7b);                             /* push 0x1b7b */
            ii(0x19_968d, 5); call_far_abs(0x80, 0x20cc);               /* call word 0x80:0x20cc */
            ii(0x19_9692, 3); call(0x19_8bd0, -0xac5);                  /* call 0x8bd0 */
            ii(0x19_9695, 1); nop();                                    /* nop */
            ii(0x19_9696, 1); push(cs);                                 /* push cs */
            ii(0x19_9697, 3); call(0x1a_0016, 0x697c);                  /* call 0x16 */
            ii(0x19_969a, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_969c, 2); if(jnz(0x19_96a1, 0x3)) goto l_0x19_96a1; /* jnz 0x96a1 */
            ii(0x19_969e, 3); jmp(0x19_9818, 0x177); goto l_0x19_9818;  /* jmp 0x9818 */
        l_0x19_96a1:
            ii(0x19_96a1, 1); push(ds);                                 /* push ds */
            ii(0x19_96a2, 3); push(0x1b82);                             /* push 0x1b82 */
            ii(0x19_96a5, 1); push(ds);                                 /* push ds */
            ii(0x19_96a6, 3); push(0x36f6);                             /* push 0x36f6 */
            ii(0x19_96a9, 1); nop();                                    /* nop */
            ii(0x19_96aa, 1); push(cs);                                 /* push cs */
            ii(0x19_96ab, 3); call(0x1a_0475, 0x6dc7);                  /* call 0x475 */
            ii(0x19_96ae, 1); nop();                                    /* nop */
            ii(0x19_96af, 1); push(cs);                                 /* push cs */
            ii(0x19_96b0, 3); call(0x1a_0809, 0x7156);                  /* call 0x809 */
            ii(0x19_96b3, 1); push(ds);                                 /* push ds */
            ii(0x19_96b4, 3); push(0x1b89);                             /* push 0x1b89 */
            ii(0x19_96b7, 5); call_far_abs(0x80, 0x5ba0);               /* call word 0x80:0x5ba0 */
            ii(0x19_96bc, 1); pop(bx);                                  /* pop bx */
            ii(0x19_96bd, 1); pop(bx);                                  /* pop bx */
            ii(0x19_96be, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_96c1, 3); mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x19_96c4, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_96c6, 2); if(jnz(0x19_96cb, 0x3)) goto l_0x19_96cb; /* jnz 0x96cb */
            ii(0x19_96c8, 3); jmp(0x19_97fe, 0x133); goto l_0x19_97fe;  /* jmp 0x97fe */
        l_0x19_96cb:
            ii(0x19_96cb, 3); les(bx, memw[ss, bp - 0x28]);             /* les bx, [bp-0x28] */
            ii(0x19_96ce, 5); test(memb[es, bx + 0x47], 0x80);          /* test byte [es:bx+0x47], 0x80 */
            ii(0x19_96d3, 2); if(jnz(0x19_96e4, 0xf)) goto l_0x19_96e4; /* jnz 0x96e4 */
            ii(0x19_96d5, 1); push(ds);                                 /* push ds */
            ii(0x19_96d6, 3); push(0x1b8f);                             /* push 0x1b8f */
            ii(0x19_96d9, 5); call_far_abs(0x80, 0x5ba0);               /* call word 0x80:0x5ba0 */
            ii(0x19_96de, 1); pop(bx);                                  /* pop bx */
            ii(0x19_96df, 1); pop(bx);                                  /* pop bx */
            ii(0x19_96e0, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_96e2, 2); if(jz(0x19_96f7, 0x13)) goto l_0x19_96f7; /* jz 0x96f7 */
        l_0x19_96e4:
            ii(0x19_96e4, 2); push(0x1);                                /* push 0x1 */
            ii(0x19_96e6, 1); push(ds);                                 /* push ds */
            ii(0x19_96e7, 3); push(0x1b98);                             /* push 0x1b98 */
            ii(0x19_96ea, 1); nop();                                    /* nop */
            ii(0x19_96eb, 1); push(cs);                                 /* push cs */
            ii(0x19_96ec, 3); call(0x19_cd5c, 0x366d);                  /* call 0xcd5c */
            ii(0x19_96ef, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_96f2, 3); mov(memb[ds, 0x19f5], al);                /* mov [0x19f5], al */
            ii(0x19_96f5, 2); jmp(0x19_972b, 0x34); goto l_0x19_972b;   /* jmp 0x972b */
        l_0x19_96f7:
            ii(0x19_96f7, 5); mov(memb[ds, 0x19f5], 0x1);               /* mov byte [0x19f5], 0x1 */
            ii(0x19_96fc, 1); push(ds);                                 /* push ds */
            ii(0x19_96fd, 3); push(0x1ba8);                             /* push 0x1ba8 */
            ii(0x19_9700, 1); push(ds);                                 /* push ds */
            ii(0x19_9701, 3); push(0x1ba3);                             /* push 0x1ba3 */
            ii(0x19_9704, 3); call(0x19_fcad, 0x65a6);                  /* call 0xfcad */
            ii(0x19_9707, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0x19_970a, 3); mov(memw[ss, bp - 0x6], dx);              /* mov [bp-0x6], dx */
            ii(0x19_970d, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_970f, 2); if(jz(0x19_972b, 0x1a)) goto l_0x19_972b; /* jz 0x972b */
            ii(0x19_9711, 1); push(ds);                                 /* push ds */
            ii(0x19_9712, 3); push(0x1bb3);                             /* push 0x1bb3 */
            ii(0x19_9715, 3); call_far_ind(ss, bp - 0x8);               /* call far word [bp-0x8] */
            ii(0x19_9718, 1); push(dx);                                 /* push dx */
            ii(0x19_9719, 1); push(ax);                                 /* push ax */
            ii(0x19_971a, 5); call_far_abs(0x80, 0x3fc4);               /* call word 0x80:0x3fc4 */
            ii(0x19_971f, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_9722, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_9724, 2); if(jz(0x19_972b, 0x5)) goto l_0x19_972b;  /* jz 0x972b */
            ii(0x19_9726, 5); mov(memb[ds, 0x19f5], 0);                 /* mov byte [0x19f5], 0x0 */
        l_0x19_972b:
            ii(0x19_972b, 5); cmp(memb[ds, 0x19f5], 0);                 /* cmp byte [0x19f5], 0x0 */
            ii(0x19_9730, 2); if(jnz(0x19_9735, 0x3)) goto l_0x19_9735; /* jnz 0x9735 */
            ii(0x19_9732, 3); jmp(0x19_97f0, 0xbb); goto l_0x19_97f0;   /* jmp 0x97f0 */
        l_0x19_9735:
            ii(0x19_9735, 1); push(ds);                                 /* push ds */
            ii(0x19_9736, 3); push(0x1bbd);                             /* push 0x1bbd */
            ii(0x19_9739, 3); push(memw[ss, bp - 0x2]);                 /* push word [bp-0x2] */
            ii(0x19_973c, 3); push(memw[ss, bp - 0x4]);                 /* push word [bp-0x4] */
            ii(0x19_973f, 5); call_far_abs(0x80, 0x5a20);               /* call word 0x80:0x5a20 */
            ii(0x19_9744, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_9747, 3); mov(memw[ds, 0x1a04], ax);                /* mov [0x1a04], ax */
            ii(0x19_974a, 4); mov(memw[ds, 0x1a06], dx);                /* mov [0x1a06], dx */
            ii(0x19_974e, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x19_9750, 4); or(ax, memw[ds, 0x1a04]);                 /* or ax, [0x1a04] */
            ii(0x19_9754, 2); if(jnz(0x19_9759, 0x3)) goto l_0x19_9759; /* jnz 0x9759 */
            ii(0x19_9756, 3); jmp(0x19_97f0, 0x97); goto l_0x19_97f0;   /* jmp 0x97f0 */
        l_0x19_9759:
            ii(0x19_9759, 1); push(ds);                                 /* push ds */
            ii(0x19_975a, 3); push(0x1bc6);                             /* push 0x1bc6 */
            ii(0x19_975d, 3); push(memw[ss, bp - 0x2]);                 /* push word [bp-0x2] */
            ii(0x19_9760, 3); push(memw[ss, bp - 0x4]);                 /* push word [bp-0x4] */
            ii(0x19_9763, 5); call_far_abs(0x80, 0x5a20);               /* call word 0x80:0x5a20 */
            ii(0x19_9768, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_976b, 3); mov(memw[ds, 0x1a10], ax);                /* mov [0x1a10], ax */
            ii(0x19_976e, 4); mov(memw[ds, 0x1a12], dx);                /* mov [0x1a12], dx */
            ii(0x19_9772, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x19_9774, 4); or(ax, memw[ds, 0x1a10]);                 /* or ax, [0x1a10] */
            ii(0x19_9778, 2); if(jz(0x19_97f0, 0x76)) goto l_0x19_97f0; /* jz 0x97f0 */
            ii(0x19_977a, 1); push(ds);                                 /* push ds */
            ii(0x19_977b, 3); push(0x1bcc);                             /* push 0x1bcc */
            ii(0x19_977e, 3); push(memw[ss, bp - 0x2]);                 /* push word [bp-0x2] */
            ii(0x19_9781, 3); push(memw[ss, bp - 0x4]);                 /* push word [bp-0x4] */
            ii(0x19_9784, 5); call_far_abs(0x80, 0x5a20);               /* call word 0x80:0x5a20 */
            ii(0x19_9789, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_978c, 3); mov(memw[ds, 0x1a08], ax);                /* mov [0x1a08], ax */
            ii(0x19_978f, 4); mov(memw[ds, 0x1a0a], dx);                /* mov [0x1a0a], dx */
            ii(0x19_9793, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x19_9795, 4); or(ax, memw[ds, 0x1a08]);                 /* or ax, [0x1a08] */
            ii(0x19_9799, 2); if(jz(0x19_97f0, 0x55)) goto l_0x19_97f0; /* jz 0x97f0 */
            ii(0x19_979b, 2); push(0);                                  /* push 0x0 */
            ii(0x19_979d, 2); push(0);                                  /* push 0x0 */
            ii(0x19_979f, 2); push(0);                                  /* push 0x0 */
            ii(0x19_97a1, 5); call_far_abs(0x80, 0x562c);               /* call word 0x80:0x562c */
            ii(0x19_97a6, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_97a9, 3); mov(memw[ds, 0x19f6], ax);                /* mov [0x19f6], ax */
            ii(0x19_97ac, 4); mov(memw[ds, 0x19f8], dx);                /* mov [0x19f8], dx */
            ii(0x19_97b0, 2); push(0);                                  /* push 0x0 */
            ii(0x19_97b2, 2); push(0);                                  /* push 0x0 */
            ii(0x19_97b4, 2); push(0);                                  /* push 0x0 */
            ii(0x19_97b6, 5); call_far_abs(0x80, 0x562c);               /* call word 0x80:0x562c */
            ii(0x19_97bb, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_97be, 3); mov(memw[ds, 0x19fa], ax);                /* mov [0x19fa], ax */
            ii(0x19_97c1, 4); mov(memw[ds, 0x19fc], dx);                /* mov [0x19fc], dx */
            ii(0x19_97c5, 2); push(0);                                  /* push 0x0 */
            ii(0x19_97c7, 2); push(0);                                  /* push 0x0 */
            ii(0x19_97c9, 3); push(0x88);                               /* push 0x88 */
            ii(0x19_97cc, 3); push(0x8be1);                             /* push 0x8be1 */
            ii(0x19_97cf, 4); call_far_ind(ds, 0x1a10);                 /* call far word [0x1a10] */
            ii(0x19_97d3, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_97d6, 3); mov(memw[ds, 0x19fe], ax);                /* mov [0x19fe], ax */
            ii(0x19_97d9, 4); mov(memw[ds, 0x1a00], dx);                /* mov [0x1a00], dx */
            ii(0x19_97dd, 1); push(dx);                                 /* push dx */
            ii(0x19_97de, 1); push(ax);                                 /* push ax */
            ii(0x19_97df, 1); push(ds);                                 /* push ds */
            ii(0x19_97e0, 3); push(0x1bd5);                             /* push 0x1bd5 */
            ii(0x19_97e3, 3); call(0x1a_1066, 0x7880);                  /* call 0x1066 */
            ii(0x19_97e6, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_97e9, 5); mov(memb[ds, 0x19f4], 0x1);               /* mov byte [0x19f4], 0x1 */
            ii(0x19_97ee, 2); jmp(0x19_97fe, 0xe); goto l_0x19_97fe;    /* jmp 0x97fe */
        l_0x19_97f0:
            ii(0x19_97f0, 1); push(ds);                                 /* push ds */
            ii(0x19_97f1, 3); push(0x1c07);                             /* push 0x1c07 */
            ii(0x19_97f4, 3); call(0x1a_1066, 0x786f);                  /* call 0x1066 */
            ii(0x19_97f7, 1); pop(bx);                                  /* pop bx */
            ii(0x19_97f8, 1); pop(bx);                                  /* pop bx */
            ii(0x19_97f9, 5); mov(memb[ds, 0x19f4], 0x2);               /* mov byte [0x19f4], 0x2 */
        l_0x19_97fe:
            ii(0x19_97fe, 1); push(ds);                                 /* push ds */
            ii(0x19_97ff, 3); push(0x1c48);                             /* push 0x1c48 */
            ii(0x19_9802, 1); push(ds);                                 /* push ds */
            ii(0x19_9803, 3); push(0x1c3a);                             /* push 0x1c3a */
            ii(0x19_9806, 3); call(0x19_fcad, 0x64a4);                  /* call 0xfcad */
            ii(0x19_9809, 3); mov(memw[ds, 0x1a0c], ax);                /* mov [0x1a0c], ax */
            ii(0x19_980c, 4); mov(memw[ds, 0x1a0e], dx);                /* mov [0x1a0e], dx */
            ii(0x19_9810, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x19_9812, 4); or(ax, memw[ds, 0x1a0c]);                 /* or ax, [0x1a0c] */
            ii(0x19_9816, 2); if(jnz(0x19_9821, 0x9)) goto l_0x19_9821; /* jnz 0x9821 */
        l_0x19_9818:
            ii(0x19_9818, 3); call(0x19_8bea, -0xc31);                  /* call 0x8bea */
            ii(0x19_981b, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_981e, 3); jmp(0x19_9684, -0x19d); goto l_0x19_9684; /* jmp 0x9684 */
        l_0x19_9821:
            ii(0x19_9821, 2); push(0);                                  /* push 0x0 */
            ii(0x19_9823, 1); push(ds);                                 /* push ds */
            ii(0x19_9824, 3); push(0x1c51);                             /* push 0x1c51 */
            ii(0x19_9827, 1); nop();                                    /* nop */
            ii(0x19_9828, 1); push(cs);                                 /* push cs */
            ii(0x19_9829, 3); call(0x19_cd5c, 0x3530);                  /* call 0xcd5c */
            ii(0x19_982c, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_982f, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_9831, 2); if(jz(0x19_9855, 0x22)) goto l_0x19_9855; /* jz 0x9855 */
            ii(0x19_9833, 1); push(ds);                                 /* push ds */
            ii(0x19_9834, 3); push(0x1c58);                             /* push 0x1c58 */
            ii(0x19_9837, 3); call(0x1a_1066, 0x782c);                  /* call 0x1066 */
            ii(0x19_983a, 1); pop(bx);                                  /* pop bx */
            ii(0x19_983b, 1); pop(bx);                                  /* pop bx */
            ii(0x19_983c, 5); mov(memb[ds, 0x19f3], 0x2);               /* mov byte [0x19f3], 0x2 */
            ii(0x19_9841, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_9843, 3); mov(memw[ds, 0x19ec], ax);                /* mov [0x19ec], ax */
            ii(0x19_9846, 3); mov(memw[ds, 0x19ea], ax);                /* mov [0x19ea], ax */
            ii(0x19_9849, 6); mov(memw[ds, 0x19ee], 0xffff);            /* mov word [0x19ee], 0xffff */
            ii(0x19_984f, 6); mov(memw[ds, 0x19f0], 0xffff);            /* mov word [0x19f0], 0xffff */
        l_0x19_9855:
            ii(0x19_9855, 2); push(0);                                  /* push 0x0 */
            ii(0x19_9857, 1); push(ds);                                 /* push ds */
            ii(0x19_9858, 3); push(0x1c8f);                             /* push 0x1c8f */
            ii(0x19_985b, 1); nop();                                    /* nop */
            ii(0x19_985c, 1); push(cs);                                 /* push cs */
            ii(0x19_985d, 3); call(0x19_cd5c, 0x34fc);                  /* call 0xcd5c */
            ii(0x19_9860, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_9863, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_9865, 2); if(jz(0x19_986c, 0x5)) goto l_0x19_986c;  /* jz 0x986c */
            ii(0x19_9867, 5); mov(memb[ds, 0x1a03], 0x1);               /* mov byte [0x1a03], 0x1 */
        l_0x19_986c:
            ii(0x19_986c, 5); call_far_abs(0x90, 0x729);                /* call word 0x90:0x729 */
            ii(0x19_9871, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_9873, 2); if(jz(0x19_98b1, 0x3c)) goto l_0x19_98b1; /* jz 0x98b1 */
            ii(0x19_9875, 1); push(ds);                                 /* push ds */
            ii(0x19_9876, 3); push(0x1c95);                             /* push 0x1c95 */
            ii(0x19_9879, 3); call(0x1a_105e, 0x77e2);                  /* call 0x105e */
            ii(0x19_987c, 1); pop(bx);                                  /* pop bx */
            ii(0x19_987d, 1); pop(bx);                                  /* pop bx */
            ii(0x19_987e, 5); cmp(memb[ds, 0x19f5], 0);                 /* cmp byte [0x19f5], 0x0 */
            ii(0x19_9883, 2); if(jz(0x19_988a, 0x5)) goto l_0x19_988a;  /* jz 0x988a */
            ii(0x19_9885, 3); mov(ax, 0x1cab);                          /* mov ax, 0x1cab */
            ii(0x19_9888, 2); jmp(0x19_988d, 0x3); goto l_0x19_988d;    /* jmp 0x988d */
        l_0x19_988a:
            ii(0x19_988a, 3); mov(ax, 0x1caf);                          /* mov ax, 0x1caf */
        l_0x19_988d:
            ii(0x19_988d, 1); push(ds);                                 /* push ds */
            ii(0x19_988e, 1); push(ax);                                 /* push ax */
            ii(0x19_988f, 1); push(ds);                                 /* push ds */
            ii(0x19_9890, 3); push(0x1cb2);                             /* push 0x1cb2 */
            ii(0x19_9893, 1); push(ds);                                 /* push ds */
            ii(0x19_9894, 3); push(0x1cbd);                             /* push 0x1cbd */
            ii(0x19_9897, 3); call(0x1a_105e, 0x77c4);                  /* call 0x105e */
            ii(0x19_989a, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x19_989d, 3); push(0xa8);                               /* push 0xa8 */
            ii(0x19_98a0, 3); push(0x34b4);                             /* push 0x34b4 */
            ii(0x19_98a3, 1); push(ds);                                 /* push ds */
            ii(0x19_98a4, 3); push(0x1cc8);                             /* push 0x1cc8 */
            ii(0x19_98a7, 1); push(ds);                                 /* push ds */
            ii(0x19_98a8, 3); push(0x1cd2);                             /* push 0x1cd2 */
            ii(0x19_98ab, 3); call(0x1a_105e, 0x77b0);                  /* call 0x105e */
            ii(0x19_98ae, 3); add(sp, 0xc);                             /* add sp, 0xc */
        l_0x19_98b1:
            ii(0x19_98b1, 3); call(0x19_9db8, 0x504);                   /* call 0x9db8 */
            ii(0x19_98b4, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_98b6, 2); if(jnz(0x19_98bb, 0x3)) goto l_0x19_98bb; /* jnz 0x98bb */
            ii(0x19_98b8, 3); jmp(0x19_9818, -0xa3); goto l_0x19_9818;  /* jmp 0x9818 */
        l_0x19_98bb:
            ii(0x19_98bb, 4); inc(memb[ds, 0x1a02]);                    /* inc byte [0x1a02] */
            ii(0x19_98bf, 3); call(0x19_8bea, -0xcd8);                  /* call 0x8bea */
            ii(0x19_98c2, 3); jmp(0x19_9682, -0x243); goto l_0x19_9682; /* jmp 0x9682 */
        }
    }
}
