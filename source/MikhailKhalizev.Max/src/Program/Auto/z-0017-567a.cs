using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_567a-d16352a0")]
        public void Method_0017_567a()
        {
            ii(0x17_567a, 4); enter(0x10, 0);                           /* enter 0x10, 0x0 */
            ii(0x17_567e, 1); push(si);                                 /* push si */
            ii(0x17_567f, 1); push(ds);                                 /* push ds */
            ii(0x17_5680, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_5683, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_5685, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x17_5688, 3); mov(dx, memw[ss, bp + 0x8]);              /* mov dx, [bp+0x8] */
            ii(0x17_568b, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_568e, 3); mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x17_5691, 5); cmp(memw[ds, 0x356], 0);                  /* cmp word [0x356], 0x0 */
            ii(0x17_5696, 2); if(jnz(0x17_56b1, 0x19)) goto l_0x17_56b1; /* jnz 0x56b1 */
            ii(0x17_5698, 2); push(0);                                  /* push 0x0 */
            ii(0x17_569a, 2); push(0);                                  /* push 0x0 */
            ii(0x17_569c, 2); push(0);                                  /* push 0x0 */
            ii(0x17_569e, 1); nop();                                    /* nop */
            ii(0x17_569f, 1); push(cs);                                 /* push cs */
            ii(0x17_56a0, 3); call(0x16_e96a, -0x6d39);                 /* call 0xe96a */
            ii(0x17_56a3, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_56a6, 3); mov(memw[ss, bp - 0x10], ax);             /* mov [bp-0x10], ax */
            ii(0x17_56a9, 3); mov(memw[ss, bp - 0xe], dx);              /* mov [bp-0xe], dx */
            ii(0x17_56ac, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x17_56ae, 3); mov(memw[ds, 0x356], ax);                 /* mov [0x356], ax */
        l_0x17_56b1:
            ii(0x17_56b1, 3); mov(ax, memw[ds, 0x356]);                 /* mov ax, [0x356] */
            ii(0x17_56b4, 5); mov(memw[ss, bp - 0xc], 0);               /* mov word [bp-0xc], 0x0 */
            ii(0x17_56b9, 3); mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x17_56bc, 5); cmp(memw[ds, 0x51a0], 0);                 /* cmp word [0x51a0], 0x0 */
            ii(0x17_56c1, 2); if(jnz(0x17_570e, 0x4b)) goto l_0x17_570e; /* jnz 0x570e */
            ii(0x17_56c3, 4); les(bx, ds, 0x992);                       /* les bx, [0x992] */
            ii(0x17_56c7, 3); mov(cx, memw[es, bx]);                    /* mov cx, [es:bx] */
            ii(0x17_56ca, 4); mov(dx, memw[es, bx + 0x2]);              /* mov dx, [es:bx+0x2] */
            ii(0x17_56ce, 4); and(cx, 0xf000);                          /* and cx, 0xf000 */
            ii(0x17_56d2, 1); push(dx);                                 /* push dx */
            ii(0x17_56d3, 1); push(cx);                                 /* push cx */
            ii(0x17_56d4, 1); push(ax);                                 /* push ax */
            ii(0x17_56d5, 1); nop();                                    /* nop */
            ii(0x17_56d6, 1); push(cs);                                 /* push cs */
            ii(0x17_56d7, 3); call(0x17_89bc, 0x32e2);                  /* call 0x89bc */
            ii(0x17_56da, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_56dd, 3); mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x17_56e0, 3); mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0x17_56e3, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_56e5, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_56e7, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_56e9, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_56eb, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_56ed, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_56ef, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_56f1, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_56f3, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_56f5, 3); and(bl, 0xfc);                            /* and bl, 0xfc */
            ii(0x17_56f8, 3); les(si, ss, bp - 0xc);                    /* les si, [bp-0xc] */
            ii(0x17_56fb, 3); mov(ax, memw[es, bx + si]);               /* mov ax, [es:bx+si] */
            ii(0x17_56fe, 4); mov(dx, memw[es, bx + si + 0x2]);         /* mov dx, [es:bx+si+0x2] */
            ii(0x17_5702, 3); and(ax, 0xf000);                          /* and ax, 0xf000 */
            ii(0x17_5705, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_5708, 3); mov(memw[ss, bp - 0x6], dx);              /* mov [bp-0x6], dx */
            ii(0x17_570b, 3); jmp(0x17_5839, 0x12b); goto l_0x17_5839;  /* jmp 0x5839 */
        l_0x17_570e:
            ii(0x17_570e, 4); mov(es, memw[ds, 0x1dc8]);                /* mov es, [0x1dc8] */
            ii(0x17_5712, 6); test(memb[es, 0x15], 0x20);               /* test byte [es:0x15], 0x20 */
            ii(0x17_5718, 2); if(jnz(0x17_571d, 0x3)) goto l_0x17_571d; /* jnz 0x571d */
            ii(0x17_571a, 3); jmp(0x17_57de, 0xc1); goto l_0x17_57de;   /* jmp 0x57de */
        l_0x17_571d:
            ii(0x17_571d, 4); les(bx, ds, 0x2018);                      /* les bx, [0x2018] */
            ii(0x17_5721, 5); cmp(memw[es, bx + 0x2], 0x4);             /* cmp word [es:bx+0x2], 0x4 */
            ii(0x17_5726, 2); if(jae(0x17_572b, 0x3)) goto l_0x17_572b; /* jae 0x572b */
            ii(0x17_5728, 3); jmp(0x17_57de, 0xb3); goto l_0x17_57de;   /* jmp 0x57de */
        l_0x17_572b:
            ii(0x17_572b, 2); if(ja(0x17_5736, 0x9)) goto l_0x17_5736;  /* ja 0x5736 */
            ii(0x17_572d, 4); cmp(memw[es, bx], 0);                     /* cmp word [es:bx], 0x0 */
            ii(0x17_5731, 2); if(jnz(0x17_5736, 0x3)) goto l_0x17_5736; /* jnz 0x5736 */
            ii(0x17_5733, 3); jmp(0x17_57de, 0xa8); goto l_0x17_57de;   /* jmp 0x57de */
        l_0x17_5736:
            ii(0x17_5736, 4); cmp(memw[ss, bp + 0x8], 0x40);            /* cmp word [bp+0x8], 0x40 */
            ii(0x17_573a, 2); if(ja(0x17_579a, 0x5e)) goto l_0x17_579a; /* ja 0x579a */
            ii(0x17_573c, 2); if(jb(0x17_5740, 0x2)) goto l_0x17_5740;  /* jb 0x5740 */
            ii(0x17_573e, 2); jmp(0x17_579a, 0x5a); goto l_0x17_579a;   /* jmp 0x579a */
        l_0x17_5740:
            ii(0x17_5740, 4); mov(ax, memw[es, bx + 0x12]);             /* mov ax, [es:bx+0x12] */
            ii(0x17_5744, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_5746, 3); add(ax, 0x100);                           /* add ax, 0x100 */
            ii(0x17_5749, 2); adc(dx, dx);                              /* adc dx, dx */
            ii(0x17_574b, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_574d, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_574f, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_5751, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_5753, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_5755, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_5757, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_5759, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_575b, 1); push(dx);                                 /* push dx */
            ii(0x17_575c, 1); push(ax);                                 /* push ax */
            ii(0x17_575d, 4); push(memw[ds, 0x356]);                    /* push word [0x356] */
            ii(0x17_5761, 1); nop();                                    /* nop */
            ii(0x17_5762, 1); push(cs);                                 /* push cs */
            ii(0x17_5763, 3); call(0x17_89bc, 0x3256);                  /* call 0x89bc */
            ii(0x17_5766, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_5769, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x17_576c, 3); mov(dx, memw[ss, bp + 0x8]);              /* mov dx, [bp+0x8] */
            ii(0x17_576f, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_5771, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_5773, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_5775, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_5777, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_5779, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_577b, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_577d, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_577f, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_5781, 3); and(bl, 0xfc);                            /* and bl, 0xfc */
            ii(0x17_5784, 3); les(si, ss, bp - 0xc);                    /* les si, [bp-0xc] */
            ii(0x17_5787, 3); mov(ax, memw[es, bx + si]);               /* mov ax, [es:bx+si] */
            ii(0x17_578a, 4); mov(dx, memw[es, bx + si + 0x2]);         /* mov dx, [es:bx+si+0x2] */
            ii(0x17_578e, 3); and(ax, 0xf000);                          /* and ax, 0xf000 */
            ii(0x17_5791, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_5794, 3); mov(memw[ss, bp - 0x6], dx);              /* mov [bp-0x6], dx */
            ii(0x17_5797, 2); jmp(0x17_57db, 0x42); goto l_0x17_57db;   /* jmp 0x57db */
        //  ii(0x17_5799, 1); nop();                                    /* nop */
        l_0x17_579a:
            ii(0x17_579a, 2); push(0x40);                               /* push 0x40 */
            ii(0x17_579c, 2); push(0);                                  /* push 0x0 */
            ii(0x17_579e, 1); push(ax);                                 /* push ax */
            ii(0x17_579f, 1); nop();                                    /* nop */
            ii(0x17_57a0, 1); push(cs);                                 /* push cs */
            ii(0x17_57a1, 3); call(0x17_89bc, 0x3218);                  /* call 0x89bc */
            ii(0x17_57a4, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_57a7, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x17_57aa, 3); mov(dx, memw[ss, bp + 0x8]);              /* mov dx, [bp+0x8] */
            ii(0x17_57ad, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_57b0, 3); sbb(dx, 0x40);                            /* sbb dx, 0x40 */
            ii(0x17_57b3, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_57b5, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_57b7, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_57b9, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_57bb, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_57bd, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_57bf, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_57c1, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_57c3, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_57c5, 3); and(bl, 0xfc);                            /* and bl, 0xfc */
            ii(0x17_57c8, 3); les(si, ss, bp - 0xc);                    /* les si, [bp-0xc] */
            ii(0x17_57cb, 3); mov(ax, memw[es, bx + si]);               /* mov ax, [es:bx+si] */
            ii(0x17_57ce, 4); mov(dx, memw[es, bx + si + 0x2]);         /* mov dx, [es:bx+si+0x2] */
            ii(0x17_57d2, 3); and(ax, 0xf000);                          /* and ax, 0xf000 */
            ii(0x17_57d5, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_57d8, 3); mov(memw[ss, bp - 0x6], dx);              /* mov [bp-0x6], dx */
        l_0x17_57db:
            ii(0x17_57db, 2); jmp(0x17_5839, 0x5c); goto l_0x17_5839;   /* jmp 0x5839 */
        //  ii(0x17_57dd, 1); nop();                                    /* nop */
        l_0x17_57de:
            ii(0x17_57de, 4); les(bx, ds, 0x2018);                      /* les bx, [0x2018] */
            ii(0x17_57e2, 4); mov(ax, memw[es, bx + 0x12]);             /* mov ax, [es:bx+0x12] */
            ii(0x17_57e6, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_57e8, 3); add(ax, 0x100);                           /* add ax, 0x100 */
            ii(0x17_57eb, 2); adc(dx, dx);                              /* adc dx, dx */
            ii(0x17_57ed, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_57ef, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_57f1, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_57f3, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_57f5, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_57f7, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_57f9, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_57fb, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_57fd, 1); push(dx);                                 /* push dx */
            ii(0x17_57fe, 1); push(ax);                                 /* push ax */
            ii(0x17_57ff, 4); push(memw[ds, 0x356]);                    /* push word [0x356] */
            ii(0x17_5803, 1); nop();                                    /* nop */
            ii(0x17_5804, 1); push(cs);                                 /* push cs */
            ii(0x17_5805, 3); call(0x17_89bc, 0x31b4);                  /* call 0x89bc */
            ii(0x17_5808, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_580b, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x17_580e, 3); mov(dx, memw[ss, bp + 0x8]);              /* mov dx, [bp+0x8] */
            ii(0x17_5811, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_5813, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_5815, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_5817, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_5819, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_581b, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_581d, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_581f, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_5821, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_5823, 3); and(bl, 0xfc);                            /* and bl, 0xfc */
            ii(0x17_5826, 3); les(si, ss, bp - 0xc);                    /* les si, [bp-0xc] */
            ii(0x17_5829, 3); mov(ax, memw[es, bx + si]);               /* mov ax, [es:bx+si] */
            ii(0x17_582c, 4); mov(dx, memw[es, bx + si + 0x2]);         /* mov dx, [es:bx+si+0x2] */
            ii(0x17_5830, 3); and(ax, 0xf000);                          /* and ax, 0xf000 */
            ii(0x17_5833, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_5836, 3); mov(memw[ss, bp - 0x6], dx);              /* mov [bp-0x6], dx */
        l_0x17_5839:
            ii(0x17_5839, 3); mov(ax, memw[ss, bp - 0x8]);              /* mov ax, [bp-0x8] */
            ii(0x17_583c, 3); mov(dx, memw[ss, bp - 0x6]);              /* mov dx, [bp-0x6] */
            ii(0x17_583f, 1); pop(ds);                                  /* pop ds */
            ii(0x17_5840, 1); pop(si);                                  /* pop si */
            ii(0x17_5841, 1); leave();                                  /* leave */
            ii(0x17_5842, 1); retf();                                   /* retf */
        }
    }
}
