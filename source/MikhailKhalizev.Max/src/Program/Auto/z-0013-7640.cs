using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1af6e757-ff5f-4c60-a67e-d1859f59f27c")]
        public void Method_0013_7640()
        {
            ii(0x13_7640, 4); enterw(0x22, 0);                          /* enter 0x22, 0x0 */
            ii(0x13_7644, 1); pushw(di);                                /* push di */
            ii(0x13_7645, 1); pushw(si);                                /* push si */
            ii(0x13_7646, 1); pushw(ds);                                /* push ds */
            ii(0x13_7647, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_764a, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_764c, 5); mov(memw_a16[ss, bp - 0x10], 0x1);        /* mov word [bp-0x10], 0x1 */
            ii(0x13_7651, 5); mov(memw_a16[ss, bp - 0xe], 0x70);        /* mov word [bp-0xe], 0x70 */
            ii(0x13_7656, 5); mov(memw_a16[ss, bp - 0xc], 0x10);        /* mov word [bp-0xc], 0x10 */
            ii(0x13_765b, 3); mov(ax, 0x70);                            /* mov ax, 0x70 */
            ii(0x13_765e, 3); mov(dx, 0x10);                            /* mov dx, 0x10 */
            ii(0x13_7661, 1); pushw(ds);                                /* push ds */
            ii(0x13_7662, 3); lea(di, bp - 0x1c);                       /* lea di, [bp-0x1c] */
            ii(0x13_7665, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x13_7667, 1); pushw(ss);                                /* push ss */
            ii(0x13_7668, 1); popw(es);                                 /* pop es */
            ii(0x13_7669, 2); mov(ds, dx);                              /* mov ds, dx */
            ii(0x13_766b, 1); movsw_a16();                              /* movsw */
            ii(0x13_766c, 1); movsw_a16();                              /* movsw */
            ii(0x13_766d, 1); movsw_a16();                              /* movsw */
            ii(0x13_766e, 1); movsw_a16();                              /* movsw */
            ii(0x13_766f, 1); popw(ds);                                 /* pop ds */
            ii(0x13_7670, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x13_7672, 3); mov(si, 0x9e);                            /* mov si, 0x9e */
            ii(0x13_7675, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x13_7677, 1); movsw_a16();                              /* movsw */
            ii(0x13_7678, 1); movsw_a16();                              /* movsw */
            ii(0x13_7679, 1); movsw_a16();                              /* movsw */
            ii(0x13_767a, 1); movsw_a16();                              /* movsw */
            ii(0x13_767b, 4); les(bx, ds, 0x1efc);                      /* les bx, [0x1efc] */
            ii(0x13_767f, 3); inc(memb_a16[es, bx]);                    /* inc byte [es:bx] */
            ii(0x13_7682, 1); nop();                                    /* nop */
            ii(0x13_7683, 1); pushw(cs);                                /* push cs */
            ii(0x13_7684, 3); callw(0x13_06b4, -0x6fd3);                /* call 0x6b4 */
            ii(0x13_7687, 1); nop();                                    /* nop */
            ii(0x13_7688, 1); pushw(cs);                                /* push cs */
            ii(0x13_7689, 3); callw(0x13_8ea2, 0x1816);                 /* call 0x8ea2 */
            ii(0x13_768c, 1); sti();                                    /* sti */
            ii(0x13_768d, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x13_7690, 4); pushw(memw_a16[es, bx + 0x22]);           /* push word [es:bx+0x22] */
            ii(0x13_7694, 4); pushw(memw_a16[es, bx + 0x20]);           /* push word [es:bx+0x20] */
            ii(0x13_7698, 4); pushw(memw_a16[es, bx + 0x4c]);           /* push word [es:bx+0x4c] */
            ii(0x13_769c, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_769f, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_76a2, 1); pushw(ds);                                /* push ds */
            ii(0x13_76a3, 3); pushw(0x8de);                             /* push 0x8de */
            ii(0x13_76a6, 1); nop();                                    /* nop */
            ii(0x13_76a7, 1); pushw(cs);                                /* push cs */
            ii(0x13_76a8, 3); callw(0x13_104f, -0x665c);                /* call 0x104f */
            ii(0x13_76ab, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x13_76ae, 5); cmp(memw_a16[ds, 0x984], 0);              /* cmp word [0x984], 0x0 */
            ii(0x13_76b3, 2); if(jzw(0x13_7713, 0x5e)) goto l_0x13_7713; /* jz 0x7713 */
            ii(0x13_76b5, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
            ii(0x13_76b9, 4); mov(memb_a16[es, bx], 0x20);              /* mov byte [es:bx], 0x20 */
            ii(0x13_76bd, 3); mov(al, memb_a16[ds, 0x5130]);            /* mov al, [0x5130] */
            ii(0x13_76c0, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
            ii(0x13_76c4, 4); mov(memb_a16[es, bx + 0x1], al);          /* mov [es:bx+0x1], al */
            ii(0x13_76c8, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_76cb, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x13_76ce, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
            ii(0x13_76d2, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x13_76d6, 4); mov(memw_a16[es, bx + 0x4], dx);          /* mov [es:bx+0x4], dx */
            ii(0x13_76da, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x13_76dd, 4); mov(ax, memw_a16[es, bx + 0x20]);         /* mov ax, [es:bx+0x20] */
            ii(0x13_76e1, 4); mov(dx, memw_a16[es, bx + 0x22]);         /* mov dx, [es:bx+0x22] */
            ii(0x13_76e5, 4); les(si, ds, 0x4fc4);                      /* les si, [0x4fc4] */
            ii(0x13_76e9, 4); mov(memw_a16[es, si + 0x6], ax);          /* mov [es:si+0x6], ax */
            ii(0x13_76ed, 4); mov(memw_a16[es, si + 0x8], dx);          /* mov [es:si+0x8], dx */
            ii(0x13_76f1, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x13_76f4, 4); mov(ax, memw_a16[es, bx + 0x4c]);         /* mov ax, [es:bx+0x4c] */
            ii(0x13_76f8, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
            ii(0x13_76fc, 4); mov(memw_a16[es, bx + 0xa], ax);          /* mov [es:bx+0xa], ax */
            ii(0x13_7700, 4); pushw(memw_a16[ds, 0x5167]);              /* push word [0x5167] */
            ii(0x13_7704, 4); pushw(memw_a16[ds, 0x4fc6]);              /* push word [0x4fc6] */
            ii(0x13_7708, 4); pushw(memw_a16[ds, 0x4fc4]);              /* push word [0x4fc4] */
            ii(0x13_770c, 2); pushw(0xc);                               /* push 0xc */
            ii(0x13_770e, 1); nop();                                    /* nop */
            ii(0x13_770f, 1); pushw(cs);                                /* push cs */
            ii(0x13_7710, 3); callw(0x13_0864, -0x6eaf);                /* call 0x864 */
        l_0x13_7713:
            ii(0x13_7713, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_7716, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x13_7719, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_771b, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_771d, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_771f, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_7721, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_7723, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_7725, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_7727, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_7729, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_772b, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_772d, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_772f, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_7731, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x13_7734, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x13_7737, 1); pushw(cs);                                /* push cs */
            ii(0x13_7738, 3); callw(0x13_7a54, 0x319);                  /* call 0x7a54 */
            ii(0x13_773b, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x13_773e, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x13_7741, 2); if(jnzw(0x13_7774, 0x31)) goto l_0x13_7774; /* jnz 0x7774 */
            ii(0x13_7743, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_7746, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_7749, 3); pushw(0x922);                             /* push 0x922 */
            ii(0x13_774c, 1); nop();                                    /* nop */
            ii(0x13_774d, 1); pushw(cs);                                /* push cs */
            ii(0x13_774e, 3); callw(0x13_75b4, -0x19d);                 /* call 0x75b4 */
            ii(0x13_7751, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_7754, 4); les(bx, ds, 0x1efc);                      /* les bx, [0x1efc] */
            ii(0x13_7758, 3); dec(memb_a16[es, bx]);                    /* dec byte [es:bx] */
            ii(0x13_775b, 1); pushw(ds);                                /* push ds */
            ii(0x13_775c, 3); lea(si, bp - 0x1c);                       /* lea si, [bp-0x1c] */
            ii(0x13_775f, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x13_7761, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_7763, 3); les(di, ss, bp - 0xe);                    /* les di, [bp-0xe] */
            ii(0x13_7766, 1); movsw_a16();                              /* movsw */
            ii(0x13_7767, 1); movsw_a16();                              /* movsw */
            ii(0x13_7768, 1); movsw_a16();                              /* movsw */
            ii(0x13_7769, 1); movsw_a16();                              /* movsw */
            ii(0x13_776a, 1); popw(ds);                                 /* pop ds */
            ii(0x13_776b, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x13_776e, 1); popw(ds);                                 /* pop ds */
            ii(0x13_776f, 1); popw(si);                                 /* pop si */
            ii(0x13_7770, 1); popw(di);                                 /* pop di */
            ii(0x13_7771, 1); leavew();                                 /* leave */
            ii(0x13_7772, 1); retfw(); return;                          /* retf */
        //    ii(0x13_7773, 1); nop();                                    /* nop */
        l_0x13_7774:
            ii(0x13_7774, 1); pusha();                                  /* pusha */
            ii(0x13_7775, 1); sti();                                    /* sti */
            ii(0x13_7776, 1); nop();                                    /* nop */
            ii(0x13_7777, 1); cli();                                    /* cli */
            ii(0x13_7778, 1); popa();                                   /* popa */
            ii(0x13_7779, 1); nop();                                    /* nop */
            ii(0x13_777a, 1); pushw(cs);                                /* push cs */
            ii(0x13_777b, 3); callw(0x13_06b4, -0x70ca);                /* call 0x6b4 */
            ii(0x13_777e, 1); nop();                                    /* nop */
            ii(0x13_777f, 1); pushw(cs);                                /* push cs */
            ii(0x13_7780, 3); callw(0x13_8ea2, 0x171f);                 /* call 0x8ea2 */
            ii(0x13_7783, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_7785, 3); pushw(memw_a16[ss, bp - 0x1e]);           /* push word [bp-0x1e] */
            ii(0x13_7788, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x13_778b, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x13_778e, 1); pushw(cs);                                /* push cs */
            ii(0x13_778f, 3); callw(0x13_7dac, 0x61a);                  /* call 0x7dac */
            ii(0x13_7792, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_7795, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x13_7798, 3); mov(dx, memw_a16[ss, bp - 0x8]);          /* mov dx, [bp-0x8] */
            ii(0x13_779b, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x13_779e, 3); sbb(dx, 0x1);                             /* sbb dx, 0x1 */
            ii(0x13_77a1, 1); pushw(dx);                                /* push dx */
            ii(0x13_77a2, 1); pushw(ax);                                /* push ax */
            ii(0x13_77a3, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x13_77a7, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x13_77ab, 3); callw(0x13_9208, 0x1a5a);                 /* call 0x9208 */
            ii(0x13_77ae, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_77b1, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x13_77b4, 3); mov(memw_a16[ss, bp - 0x4], dx);          /* mov [bp-0x4], dx */
            ii(0x13_77b7, 1); pushw(dx);                                /* push dx */
            ii(0x13_77b8, 1); pushw(ax);                                /* push ax */
            ii(0x13_77b9, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x13_77bc, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x13_77bf, 1); pushw(cs);                                /* push cs */
            ii(0x13_77c0, 3); callw(0x13_7cfc, 0x539);                  /* call 0x7cfc */
            ii(0x13_77c3, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_77c6, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x13_77c9, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_77cb, 2); if(jzw(0x13_77ec, 0x1f)) goto l_0x13_77ec; /* jz 0x77ec */
            ii(0x13_77cd, 4); les(bx, ds, 0x1efc);                      /* les bx, [0x1efc] */
            ii(0x13_77d1, 3); dec(memb_a16[es, bx]);                    /* dec byte [es:bx] */
            ii(0x13_77d4, 1); pushw(ds);                                /* push ds */
            ii(0x13_77d5, 3); lea(si, bp - 0x1c);                       /* lea si, [bp-0x1c] */
            ii(0x13_77d8, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x13_77da, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_77dc, 3); les(di, ss, bp - 0xe);                    /* les di, [bp-0xe] */
            ii(0x13_77df, 1); movsw_a16();                              /* movsw */
            ii(0x13_77e0, 1); movsw_a16();                              /* movsw */
            ii(0x13_77e1, 1); movsw_a16();                              /* movsw */
            ii(0x13_77e2, 1); movsw_a16();                              /* movsw */
            ii(0x13_77e3, 1); popw(ds);                                 /* pop ds */
            ii(0x13_77e4, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x13_77e7, 1); popw(ds);                                 /* pop ds */
            ii(0x13_77e8, 1); popw(si);                                 /* pop si */
            ii(0x13_77e9, 1); popw(di);                                 /* pop di */
            ii(0x13_77ea, 1); leavew();                                 /* leave */
            ii(0x13_77eb, 1); retfw(); return;                          /* retf */
        l_0x13_77ec:
            ii(0x13_77ec, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x13_77ef, 4); mov(ax, memw_a16[es, bx + 0x50]);         /* mov ax, [es:bx+0x50] */
            ii(0x13_77f3, 3); mov(dx, 0x8);                             /* mov dx, 0x8 */
            ii(0x13_77f6, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x13_77f9, 3); mov(memw_a16[ss, bp - 0x12], dx);         /* mov [bp-0x12], dx */
            ii(0x13_77fc, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x13_77fe, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_7800, 4); mov(cx, memw_a16[es, bx + 0x2]);          /* mov cx, [es:bx+0x2] */
            ii(0x13_7804, 4); mov(al, memb_a16[es, bx + 0x4]);          /* mov al, [es:bx+0x4] */
            ii(0x13_7808, 4); mov(dl, memb_a16[es, bx + 0x7]);          /* mov dl, [es:bx+0x7] */
            ii(0x13_780c, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_780e, 3); shl(dx, 0x8);                             /* shl dx, 0x8 */
            ii(0x13_7811, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x13_7813, 2); add(dx, ax);                              /* add dx, ax */
            ii(0x13_7815, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x13_7817, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x13_7819, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x13_781c, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x13_781f, 5); test(memb_a16[es, bx + 0x6], 0x40);       /* test byte [es:bx+0x6], 0x40 */
            ii(0x13_7824, 2); if(jzw(0x13_7840, 0x1a)) goto l_0x13_7840; /* jz 0x7840 */
            ii(0x13_7826, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x13_7829, 4); add(ax, memw_a16[es, bx + 0x38]);         /* add ax, [es:bx+0x38] */
            ii(0x13_782d, 4); adc(dx, memw_a16[es, bx + 0x3a]);         /* adc dx, [es:bx+0x3a] */
            ii(0x13_7831, 3); sub(ax, 0x14);                            /* sub ax, 0x14 */
            ii(0x13_7834, 3); sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x13_7837, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x13_783a, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x13_783d, 2); jmpw(0x13_7854, 0x15); goto l_0x13_7854;  /* jmp 0x7854 */
        //    ii(0x13_783f, 1); nop();                                    /* nop */
        l_0x13_7840:
            ii(0x13_7840, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x13_7843, 4); mov(ax, memw_a16[es, bx + 0x38]);         /* mov ax, [es:bx+0x38] */
            ii(0x13_7847, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x13_7849, 3); sub(ax, 0x14);                            /* sub ax, 0x14 */
            ii(0x13_784c, 2); sbb(dx, dx);                              /* sbb dx, dx */
            ii(0x13_784e, 3); add(memw_a16[ss, bp - 0xa], ax);          /* add [bp-0xa], ax */
            ii(0x13_7851, 3); adc(memw_a16[ss, bp - 0x8], dx);          /* adc [bp-0x8], dx */
        l_0x13_7854:
            ii(0x13_7854, 2); pushw(0xc);                               /* push 0xc */
            ii(0x13_7856, 3); lea(ax, bp - 0xa);                        /* lea ax, [bp-0xa] */
            ii(0x13_7859, 1); pushw(ss);                                /* push ss */
            ii(0x13_785a, 1); pushw(ax);                                /* push ax */
            ii(0x13_785b, 1); nop();                                    /* nop */
            ii(0x13_785c, 1); pushw(cs);                                /* push cs */
            ii(0x13_785d, 3); callw(0x13_ddbc, 0x655c);                 /* call 0xddbc */
            ii(0x13_7860, 3); cmp(dx, 0x1);                             /* cmp dx, 0x1 */
            ii(0x13_7863, 2); if(jbw(0x13_78d5, 0x70)) goto l_0x13_78d5; /* jb 0x78d5 */
            ii(0x13_7865, 2); if(jaw(0x13_7867, 0)) goto l_0x13_7867;   /* ja 0x7867 */
        l_0x13_7867:
            ii(0x13_7867, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x13_786a, 3); sbb(dx, 0x1);                             /* sbb dx, 0x1 */
            ii(0x13_786d, 1); pushw(dx);                                /* push dx */
            ii(0x13_786e, 1); pushw(ax);                                /* push ax */
            ii(0x13_786f, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x13_7873, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x13_7877, 3); callw(0x13_9208, 0x198e);                 /* call 0x9208 */
            ii(0x13_787a, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_787d, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x13_7880, 3); mov(memw_a16[ss, bp - 0x4], dx);          /* mov [bp-0x4], dx */
            ii(0x13_7883, 3); mov(memw_a16[ss, bp - 0x22], ax);         /* mov [bp-0x22], ax */
            ii(0x13_7886, 3); mov(memw_a16[ss, bp - 0x20], dx);         /* mov [bp-0x20], dx */
            ii(0x13_7889, 4); test(memb_a16[ss, bp - 0x22], 0x1);       /* test byte [bp-0x22], 0x1 */
            ii(0x13_788d, 2); if(jnzw(0x13_78d5, 0x46)) goto l_0x13_78d5; /* jnz 0x78d5 */
            ii(0x13_788f, 1); pushw(cs);                                /* push cs */
            ii(0x13_7890, 3); callw(0x13_7a54, 0x1c1);                  /* call 0x7a54 */
            ii(0x13_7893, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x13_7896, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x13_7899, 2); if(jnzw(0x13_78ac, 0x11)) goto l_0x13_78ac; /* jnz 0x78ac */
            ii(0x13_789b, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_789e, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_78a1, 3); pushw(0x922);                             /* push 0x922 */
            ii(0x13_78a4, 1); nop();                                    /* nop */
            ii(0x13_78a5, 1); pushw(cs);                                /* push cs */
            ii(0x13_78a6, 3); callw(0x13_75b4, -0x2f5);                 /* call 0x75b4 */
            ii(0x13_78a9, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x13_78ac:
            ii(0x13_78ac, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_78ae, 3); pushw(memw_a16[ss, bp - 0x1e]);           /* push word [bp-0x1e] */
            ii(0x13_78b1, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x13_78b4, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x13_78b7, 1); pushw(cs);                                /* push cs */
            ii(0x13_78b8, 3); callw(0x13_7dac, 0x4f1);                  /* call 0x7dac */
            ii(0x13_78bb, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_78be, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_78c1, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x13_78c4, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x13_78c7, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x13_78ca, 1); pushw(cs);                                /* push cs */
            ii(0x13_78cb, 3); callw(0x13_7cfc, 0x42e);                  /* call 0x7cfc */
            ii(0x13_78ce, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_78d1, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_78d3, 2); if(jzw(0x13_78d5, 0)) goto l_0x13_78d5;   /* jz 0x78d5 */
        l_0x13_78d5:
            ii(0x13_78d5, 4); dec(memb_a16[ds, 0x996]);                 /* dec byte [0x996] */
            ii(0x13_78d9, 1); pushw(ds);                                /* push ds */
            ii(0x13_78da, 3); pushw(0x8f2);                             /* push 0x8f2 */
            ii(0x13_78dd, 1); nop();                                    /* nop */
            ii(0x13_78de, 1); pushw(cs);                                /* push cs */
            ii(0x13_78df, 3); callw(0x13_104f, -0x6893);                /* call 0x104f */
            ii(0x13_78e2, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_78e5, 4); les(bx, ds, 0x1efc);                      /* les bx, [0x1efc] */
            ii(0x13_78e9, 3); dec(memb_a16[es, bx]);                    /* dec byte [es:bx] */
            ii(0x13_78ec, 1); nop();                                    /* nop */
            ii(0x13_78ed, 1); pushw(cs);                                /* push cs */
            ii(0x13_78ee, 3); callw(0x13_8e97, 0x15a6);                 /* call 0x8e97 */
            ii(0x13_78f1, 1); pushw(ds);                                /* push ds */
            ii(0x13_78f2, 3); lea(si, bp - 0x1c);                       /* lea si, [bp-0x1c] */
            ii(0x13_78f5, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x13_78f7, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_78f9, 3); les(di, ss, bp - 0xe);                    /* les di, [bp-0xe] */
            ii(0x13_78fc, 1); movsw_a16();                              /* movsw */
            ii(0x13_78fd, 1); movsw_a16();                              /* movsw */
            ii(0x13_78fe, 1); movsw_a16();                              /* movsw */
            ii(0x13_78ff, 1); movsw_a16();                              /* movsw */
            ii(0x13_7900, 1); popw(ds);                                 /* pop ds */
            ii(0x13_7901, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_7903, 1); popw(ds);                                 /* pop ds */
            ii(0x13_7904, 1); popw(si);                                 /* pop si */
            ii(0x13_7905, 1); popw(di);                                 /* pop di */
            ii(0x13_7906, 1); leavew();                                 /* leave */
            ii(0x13_7907, 1); retfw(); return;                          /* retf */
        }
    }
}
