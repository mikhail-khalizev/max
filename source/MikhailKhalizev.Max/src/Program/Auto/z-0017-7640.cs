using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_7640-6d14c029")]
        public void Method_0017_7640()
        {
            ii(0x17_7640, 4); enterw(0x22, 0);                          /* enter 0x22, 0x0 */
            ii(0x17_7644, 1); pushw(di);                                /* push di */
            ii(0x17_7645, 1); pushw(si);                                /* push si */
            ii(0x17_7646, 1); pushw(ds);                                /* push ds */
            ii(0x17_7647, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_764a, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_764c, 5); mov(memw_a16[ss, bp - 0x10], 0x1);        /* mov word [bp-0x10], 0x1 */
            ii(0x17_7651, 5); mov(memw_a16[ss, bp - 0xe], 0x70);        /* mov word [bp-0xe], 0x70 */
            ii(0x17_7656, 5); mov(memw_a16[ss, bp - 0xc], 0x10);        /* mov word [bp-0xc], 0x10 */
            ii(0x17_765b, 3); mov(ax, 0x70);                            /* mov ax, 0x70 */
            ii(0x17_765e, 3); mov(dx, 0x10);                            /* mov dx, 0x10 */
            ii(0x17_7661, 1); pushw(ds);                                /* push ds */
            ii(0x17_7662, 3); lea(di, bp - 0x1c);                       /* lea di, [bp-0x1c] */
            ii(0x17_7665, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_7667, 1); pushw(ss);                                /* push ss */
            ii(0x17_7668, 1); popw(es);                                 /* pop es */
            ii(0x17_7669, 2); mov(ds, dx);                              /* mov ds, dx */
            ii(0x17_766b, 1); movsw_a16();                              /* movsw */
            ii(0x17_766c, 1); movsw_a16();                              /* movsw */
            ii(0x17_766d, 1); movsw_a16();                              /* movsw */
            ii(0x17_766e, 1); movsw_a16();                              /* movsw */
            ii(0x17_766f, 1); popw(ds);                                 /* pop ds */
            ii(0x17_7670, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x17_7672, 3); mov(si, 0x9e);                            /* mov si, 0x9e */
            ii(0x17_7675, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x17_7677, 1); movsw_a16();                              /* movsw */
            ii(0x17_7678, 1); movsw_a16();                              /* movsw */
            ii(0x17_7679, 1); movsw_a16();                              /* movsw */
            ii(0x17_767a, 1); movsw_a16();                              /* movsw */
            ii(0x17_767b, 4); les(bx, ds, 0x1efc);                      /* les bx, [0x1efc] */
            ii(0x17_767f, 3); inc(memb_a16[es, bx]);                    /* inc byte [es:bx] */
            ii(0x17_7682, 1); nop();                                    /* nop */
            ii(0x17_7683, 1); pushw(cs);                                /* push cs */
            ii(0x17_7684, 3); callw(0x17_06b4, -0x6fd3);                /* call 0x6b4 */
            ii(0x17_7687, 1); nop();                                    /* nop */
            ii(0x17_7688, 1); pushw(cs);                                /* push cs */
            ii(0x17_7689, 3); callw(0x17_8ea2, 0x1816);                 /* call 0x8ea2 */
            ii(0x17_768c, 1); sti();                                    /* sti */
            ii(0x17_768d, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x17_7690, 4); pushw(memw_a16[es, bx + 0x22]);           /* push word [es:bx+0x22] */
            ii(0x17_7694, 4); pushw(memw_a16[es, bx + 0x20]);           /* push word [es:bx+0x20] */
            ii(0x17_7698, 4); pushw(memw_a16[es, bx + 0x4c]);           /* push word [es:bx+0x4c] */
            ii(0x17_769c, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_769f, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_76a2, 1); pushw(ds);                                /* push ds */
            ii(0x17_76a3, 3); pushw(0x8de);                             /* push 0x8de */
            ii(0x17_76a6, 1); nop();                                    /* nop */
            ii(0x17_76a7, 1); pushw(cs);                                /* push cs */
            ii(0x17_76a8, 3); callw(0x17_104f, -0x665c);                /* call 0x104f */
            ii(0x17_76ab, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x17_76ae, 5); cmp(memw_a16[ds, 0x984], 0);              /* cmp word [0x984], 0x0 */
            ii(0x17_76b3, 2); if(jzw(0x17_7713, 0x5e)) goto l_0x17_7713; /* jz 0x7713 */
            ii(0x17_76b5, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
            ii(0x17_76b9, 4); mov(memb_a16[es, bx], 0x20);              /* mov byte [es:bx], 0x20 */
            ii(0x17_76bd, 3); mov(al, memb_a16[ds, 0x5130]);            /* mov al, [0x5130] */
            ii(0x17_76c0, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
            ii(0x17_76c4, 4); mov(memb_a16[es, bx + 0x1], al);          /* mov [es:bx+0x1], al */
            ii(0x17_76c8, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_76cb, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_76ce, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
            ii(0x17_76d2, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x17_76d6, 4); mov(memw_a16[es, bx + 0x4], dx);          /* mov [es:bx+0x4], dx */
            ii(0x17_76da, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x17_76dd, 4); mov(ax, memw_a16[es, bx + 0x20]);         /* mov ax, [es:bx+0x20] */
            ii(0x17_76e1, 4); mov(dx, memw_a16[es, bx + 0x22]);         /* mov dx, [es:bx+0x22] */
            ii(0x17_76e5, 4); les(si, ds, 0x4fc4);                      /* les si, [0x4fc4] */
            ii(0x17_76e9, 4); mov(memw_a16[es, si + 0x6], ax);          /* mov [es:si+0x6], ax */
            ii(0x17_76ed, 4); mov(memw_a16[es, si + 0x8], dx);          /* mov [es:si+0x8], dx */
            ii(0x17_76f1, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x17_76f4, 4); mov(ax, memw_a16[es, bx + 0x4c]);         /* mov ax, [es:bx+0x4c] */
            ii(0x17_76f8, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
            ii(0x17_76fc, 4); mov(memw_a16[es, bx + 0xa], ax);          /* mov [es:bx+0xa], ax */
            ii(0x17_7700, 4); pushw(memw_a16[ds, 0x5167]);              /* push word [0x5167] */
            ii(0x17_7704, 4); pushw(memw_a16[ds, 0x4fc6]);              /* push word [0x4fc6] */
            ii(0x17_7708, 4); pushw(memw_a16[ds, 0x4fc4]);              /* push word [0x4fc4] */
            ii(0x17_770c, 2); pushw(0xc);                               /* push 0xc */
            ii(0x17_770e, 1); nop();                                    /* nop */
            ii(0x17_770f, 1); pushw(cs);                                /* push cs */
            ii(0x17_7710, 3); callw(0x17_0864, -0x6eaf);                /* call 0x864 */
        l_0x17_7713:
            ii(0x17_7713, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_7716, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_7719, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_771b, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_771d, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_771f, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_7721, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_7723, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_7725, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_7727, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_7729, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_772b, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_772d, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_772f, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_7731, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x17_7734, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x17_7737, 1); pushw(cs);                                /* push cs */
            ii(0x17_7738, 3); callw(0x17_7a54, 0x319);                  /* call 0x7a54 */
            ii(0x17_773b, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x17_773e, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_7741, 2); if(jnzw(0x17_7774, 0x31)) goto l_0x17_7774; /* jnz 0x7774 */
            ii(0x17_7743, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_7746, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_7749, 3); pushw(0x922);                             /* push 0x922 */
            ii(0x17_774c, 1); nop();                                    /* nop */
            ii(0x17_774d, 1); pushw(cs);                                /* push cs */
            ii(0x17_774e, 3); callw(0x17_75b4, -0x19d);                 /* call 0x75b4 */
            ii(0x17_7751, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_7754, 4); les(bx, ds, 0x1efc);                      /* les bx, [0x1efc] */
            ii(0x17_7758, 3); dec(memb_a16[es, bx]);                    /* dec byte [es:bx] */
            ii(0x17_775b, 1); pushw(ds);                                /* push ds */
            ii(0x17_775c, 3); lea(si, bp - 0x1c);                       /* lea si, [bp-0x1c] */
            ii(0x17_775f, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x17_7761, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_7763, 3); les(di, ss, bp - 0xe);                    /* les di, [bp-0xe] */
            ii(0x17_7766, 1); movsw_a16();                              /* movsw */
            ii(0x17_7767, 1); movsw_a16();                              /* movsw */
            ii(0x17_7768, 1); movsw_a16();                              /* movsw */
            ii(0x17_7769, 1); movsw_a16();                              /* movsw */
            ii(0x17_776a, 1); popw(ds);                                 /* pop ds */
            ii(0x17_776b, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x17_776e, 1); popw(ds);                                 /* pop ds */
            ii(0x17_776f, 1); popw(si);                                 /* pop si */
            ii(0x17_7770, 1); popw(di);                                 /* pop di */
            ii(0x17_7771, 1); leavew();                                 /* leave */
            ii(0x17_7772, 1); retfw(); return;                          /* retf */
        //  ii(0x17_7773, 1); Недостижимый (и не декодированный) код.
        l_0x17_7774:
            ii(0x17_7774, 1); pusha();                                  /* pusha */
            ii(0x17_7775, 1); sti();                                    /* sti */
            ii(0x17_7776, 1); nop();                                    /* nop */
            ii(0x17_7777, 1); cli();                                    /* cli */
            ii(0x17_7778, 1); popa();                                   /* popa */
            ii(0x17_7779, 1); nop();                                    /* nop */
            ii(0x17_777a, 1); pushw(cs);                                /* push cs */
            ii(0x17_777b, 3); callw(0x17_06b4, -0x70ca);                /* call 0x6b4 */
            ii(0x17_777e, 1); nop();                                    /* nop */
            ii(0x17_777f, 1); pushw(cs);                                /* push cs */
            ii(0x17_7780, 3); callw(0x17_8ea2, 0x171f);                 /* call 0x8ea2 */
            ii(0x17_7783, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_7785, 3); pushw(memw_a16[ss, bp - 0x1e]);           /* push word [bp-0x1e] */
            ii(0x17_7788, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x17_778b, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x17_778e, 1); pushw(cs);                                /* push cs */
            ii(0x17_778f, 3); callw(0x17_7dac, 0x61a);                  /* call 0x7dac */
            ii(0x17_7792, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_7795, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x17_7798, 3); mov(dx, memw_a16[ss, bp - 0x8]);          /* mov dx, [bp-0x8] */
            ii(0x17_779b, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_779e, 3); sbb(dx, 0x1);                             /* sbb dx, 0x1 */
            ii(0x17_77a1, 1); pushw(dx);                                /* push dx */
            ii(0x17_77a2, 1); pushw(ax);                                /* push ax */
            ii(0x17_77a3, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x17_77a7, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x17_77ab, 3); callw(0x17_9208, 0x1a5a);                 /* call 0x9208 */
            ii(0x17_77ae, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_77b1, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x17_77b4, 3); mov(memw_a16[ss, bp - 0x4], dx);          /* mov [bp-0x4], dx */
            ii(0x17_77b7, 1); pushw(dx);                                /* push dx */
            ii(0x17_77b8, 1); pushw(ax);                                /* push ax */
            ii(0x17_77b9, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x17_77bc, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x17_77bf, 1); pushw(cs);                                /* push cs */
            ii(0x17_77c0, 3); callw(0x17_7cfc, 0x539);                  /* call 0x7cfc */
            ii(0x17_77c3, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_77c6, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x17_77c9, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_77cb, 2); if(jzw(0x17_77ec, 0x1f)) goto l_0x17_77ec; /* jz 0x77ec */
            ii(0x17_77cd, 4); les(bx, ds, 0x1efc);                      /* les bx, [0x1efc] */
            ii(0x17_77d1, 3); dec(memb_a16[es, bx]);                    /* dec byte [es:bx] */
            ii(0x17_77d4, 1); pushw(ds);                                /* push ds */
            ii(0x17_77d5, 3); lea(si, bp - 0x1c);                       /* lea si, [bp-0x1c] */
            ii(0x17_77d8, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x17_77da, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_77dc, 3); les(di, ss, bp - 0xe);                    /* les di, [bp-0xe] */
            ii(0x17_77df, 1); movsw_a16();                              /* movsw */
            ii(0x17_77e0, 1); movsw_a16();                              /* movsw */
            ii(0x17_77e1, 1); movsw_a16();                              /* movsw */
            ii(0x17_77e2, 1); movsw_a16();                              /* movsw */
            ii(0x17_77e3, 1); popw(ds);                                 /* pop ds */
            ii(0x17_77e4, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x17_77e7, 1); popw(ds);                                 /* pop ds */
            ii(0x17_77e8, 1); popw(si);                                 /* pop si */
            ii(0x17_77e9, 1); popw(di);                                 /* pop di */
            ii(0x17_77ea, 1); leavew();                                 /* leave */
            ii(0x17_77eb, 1); retfw(); return;                          /* retf */
        l_0x17_77ec:
            ii(0x17_77ec, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x17_77ef, 4); mov(ax, memw_a16[es, bx + 0x50]);         /* mov ax, [es:bx+0x50] */
            ii(0x17_77f3, 3); mov(dx, 0x8);                             /* mov dx, 0x8 */
            ii(0x17_77f6, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x17_77f9, 3); mov(memw_a16[ss, bp - 0x12], dx);         /* mov [bp-0x12], dx */
            ii(0x17_77fc, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x17_77fe, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_7800, 4); mov(cx, memw_a16[es, bx + 0x2]);          /* mov cx, [es:bx+0x2] */
            ii(0x17_7804, 4); mov(al, memb_a16[es, bx + 0x4]);          /* mov al, [es:bx+0x4] */
            ii(0x17_7808, 4); mov(dl, memb_a16[es, bx + 0x7]);          /* mov dl, [es:bx+0x7] */
            ii(0x17_780c, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_780e, 3); shl(dx, 0x8);                             /* shl dx, 0x8 */
            ii(0x17_7811, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_7813, 2); add(dx, ax);                              /* add dx, ax */
            ii(0x17_7815, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x17_7817, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x17_7819, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x17_781c, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x17_781f, 5); test(memb_a16[es, bx + 0x6], 0x40);       /* test byte [es:bx+0x6], 0x40 */
            ii(0x17_7824, 2); if(jzw(0x17_7840, 0x1a)) goto l_0x17_7840; /* jz 0x7840 */
            ii(0x17_7826, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x17_7829, 4); add(ax, memw_a16[es, bx + 0x38]);         /* add ax, [es:bx+0x38] */
            ii(0x17_782d, 4); adc(dx, memw_a16[es, bx + 0x3a]);         /* adc dx, [es:bx+0x3a] */
            ii(0x17_7831, 3); sub(ax, 0x14);                            /* sub ax, 0x14 */
            ii(0x17_7834, 3); sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x17_7837, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x17_783a, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x17_783d, 2); jmpw(0x17_7854, 0x15); goto l_0x17_7854;  /* jmp 0x7854 */
        //    ii(0x17_783f, 1); nop();                                    /* nop */
        l_0x17_7840:
            ii(0x17_7840, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x17_7843, 4); mov(ax, memw_a16[es, bx + 0x38]);         /* mov ax, [es:bx+0x38] */
            ii(0x17_7847, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_7849, 3); sub(ax, 0x14);                            /* sub ax, 0x14 */
            ii(0x17_784c, 2); sbb(dx, dx);                              /* sbb dx, dx */
            ii(0x17_784e, 3); add(memw_a16[ss, bp - 0xa], ax);          /* add [bp-0xa], ax */
            ii(0x17_7851, 3); adc(memw_a16[ss, bp - 0x8], dx);          /* adc [bp-0x8], dx */
        l_0x17_7854:
            ii(0x17_7854, 2); pushw(0xc);                               /* push 0xc */
            ii(0x17_7856, 3); lea(ax, bp - 0xa);                        /* lea ax, [bp-0xa] */
            ii(0x17_7859, 1); pushw(ss);                                /* push ss */
            ii(0x17_785a, 1); pushw(ax);                                /* push ax */
            ii(0x17_785b, 1); nop();                                    /* nop */
            ii(0x17_785c, 1); pushw(cs);                                /* push cs */
            ii(0x17_785d, 3); callw(0x17_ddbc, 0x655c);                 /* call 0xddbc */
            ii(0x17_7860, 3); cmp(dx, 0x1);                             /* cmp dx, 0x1 */
            ii(0x17_7863, 2); if(jbw(0x17_78d5, 0x70)) goto l_0x17_78d5; /* jb 0x78d5 */
            ii(0x17_7865, 2); if(jaw(0x17_7867, 0)) goto l_0x17_7867;   /* ja 0x7867 */
        l_0x17_7867:
            ii(0x17_7867, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_786a, 3); sbb(dx, 0x1);                             /* sbb dx, 0x1 */
            ii(0x17_786d, 1); pushw(dx);                                /* push dx */
            ii(0x17_786e, 1); pushw(ax);                                /* push ax */
            ii(0x17_786f, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x17_7873, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x17_7877, 3); callw(0x17_9208, 0x198e);                 /* call 0x9208 */
            ii(0x17_787a, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_787d, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x17_7880, 3); mov(memw_a16[ss, bp - 0x4], dx);          /* mov [bp-0x4], dx */
            ii(0x17_7883, 3); mov(memw_a16[ss, bp - 0x22], ax);         /* mov [bp-0x22], ax */
            ii(0x17_7886, 3); mov(memw_a16[ss, bp - 0x20], dx);         /* mov [bp-0x20], dx */
            ii(0x17_7889, 4); test(memb_a16[ss, bp - 0x22], 0x1);       /* test byte [bp-0x22], 0x1 */
            ii(0x17_788d, 2); if(jnzw(0x17_78d5, 0x46)) goto l_0x17_78d5; /* jnz 0x78d5 */
            ii(0x17_788f, 1); pushw(cs);                                /* push cs */
            ii(0x17_7890, 3); callw(0x17_7a54, 0x1c1);                  /* call 0x7a54 */
            ii(0x17_7893, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x17_7896, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_7899, 2); if(jnzw(0x17_78ac, 0x11)) goto l_0x17_78ac; /* jnz 0x78ac */
            ii(0x17_789b, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_789e, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_78a1, 3); pushw(0x922);                             /* push 0x922 */
            ii(0x17_78a4, 1); nop();                                    /* nop */
            ii(0x17_78a5, 1); pushw(cs);                                /* push cs */
            ii(0x17_78a6, 3); callw(0x17_75b4, -0x2f5);                 /* call 0x75b4 */
            ii(0x17_78a9, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x17_78ac:
            ii(0x17_78ac, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_78ae, 3); pushw(memw_a16[ss, bp - 0x1e]);           /* push word [bp-0x1e] */
            ii(0x17_78b1, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x17_78b4, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x17_78b7, 1); pushw(cs);                                /* push cs */
            ii(0x17_78b8, 3); callw(0x17_7dac, 0x4f1);                  /* call 0x7dac */
            ii(0x17_78bb, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_78be, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x17_78c1, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x17_78c4, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x17_78c7, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x17_78ca, 1); pushw(cs);                                /* push cs */
            ii(0x17_78cb, 3); callw(0x17_7cfc, 0x42e);                  /* call 0x7cfc */
            ii(0x17_78ce, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_78d1, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_78d3, 2); if(jzw(0x17_78d5, 0)) goto l_0x17_78d5;   /* jz 0x78d5 */
        l_0x17_78d5:
            ii(0x17_78d5, 4); dec(memb_a16[ds, 0x996]);                 /* dec byte [0x996] */
            ii(0x17_78d9, 1); pushw(ds);                                /* push ds */
            ii(0x17_78da, 3); pushw(0x8f2);                             /* push 0x8f2 */
            ii(0x17_78dd, 1); nop();                                    /* nop */
            ii(0x17_78de, 1); pushw(cs);                                /* push cs */
            ii(0x17_78df, 3); callw(0x17_104f, -0x6893);                /* call 0x104f */
            ii(0x17_78e2, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_78e5, 4); les(bx, ds, 0x1efc);                      /* les bx, [0x1efc] */
            ii(0x17_78e9, 3); dec(memb_a16[es, bx]);                    /* dec byte [es:bx] */
            ii(0x17_78ec, 1); nop();                                    /* nop */
            ii(0x17_78ed, 1); pushw(cs);                                /* push cs */
            ii(0x17_78ee, 3); callw(0x17_8e97, 0x15a6);                 /* call 0x8e97 */
            ii(0x17_78f1, 1); pushw(ds);                                /* push ds */
            ii(0x17_78f2, 3); lea(si, bp - 0x1c);                       /* lea si, [bp-0x1c] */
            ii(0x17_78f5, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x17_78f7, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_78f9, 3); les(di, ss, bp - 0xe);                    /* les di, [bp-0xe] */
            ii(0x17_78fc, 1); movsw_a16();                              /* movsw */
            ii(0x17_78fd, 1); movsw_a16();                              /* movsw */
            ii(0x17_78fe, 1); movsw_a16();                              /* movsw */
            ii(0x17_78ff, 1); movsw_a16();                              /* movsw */
            ii(0x17_7900, 1); popw(ds);                                 /* pop ds */
            ii(0x17_7901, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_7903, 1); popw(ds);                                 /* pop ds */
            ii(0x17_7904, 1); popw(si);                                 /* pop si */
            ii(0x17_7905, 1); popw(di);                                 /* pop di */
            ii(0x17_7906, 1); leavew();                                 /* leave */
            ii(0x17_7907, 1); retfw(); return;                          /* retf */
        //  ii(0x17_7908, 332); Недостижимый (и не декодированный) код.
        //    ii(0x17_7a54, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
        //    ii(0x17_7a58, 1); pushw(ds);                                /* push ds */
        //    ii(0x17_7a59, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
        //    ii(0x17_7a5c, 2); mov(ds, ax);                              /* mov ds, ax */
        //    ii(0x17_7a5e, 1); nop();                                    /* nop */
        //    ii(0x17_7a5f, 1); pushw(cs);                                /* push cs */
        //    ii(0x17_7a60, 3); callw(0x17_8ff5, 0x1592);                 /* call 0x8ff5 */
        //    ii(0x17_7a63, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
        //    ii(0x17_7a66, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
        //    ii(0x17_7a69, 2); if(jnzw(0x17_7a84, 0x19)) goto l_0x17_7a84; /* jnz 0x7a84 */
        //    ii(0x17_7a6b, 1); pushw(cs);                                /* push cs */
        //    ii(0x17_7a6c, 3); callw(0x17_7aa0, 0x31);                   /* call 0x7aa0 */
        //    ii(0x17_7a6f, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
        //    ii(0x17_7a72, 2); pushw(0);                                 /* push 0x0 */
        //    ii(0x17_7a74, 1); pushw(ax);                                /* push ax */
        //    ii(0x17_7a75, 1); pushw(cs);                                /* push cs */
        //    ii(0x17_7a76, 3); callw(0x17_7bea, 0x171);                  /* call 0x7bea */
        //    ii(0x17_7a79, 3); add(sp, 0x4);                             /* add sp, 0x4 */
        //    ii(0x17_7a7c, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
        //    ii(0x17_7a7f, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
        //    ii(0x17_7a82, 2); jmpw(0x17_7a97, 0x13); goto l_0x17_7a97;  /* jmp 0x7a97 */
        l_0x17_7a84:
            ii(0x17_7a84, 3); mov(ax, memw_a16[ds, 0x1fbe]);            /* mov ax, [0x1fbe] */
            ii(0x17_7a87, 4); or(ax, memw_a16[ds, 0x1fbc]);             /* or ax, [0x1fbc] */
            ii(0x17_7a8b, 2); if(jzw(0x17_7a97, 0xa)) goto l_0x17_7a97; /* jz 0x7a97 */
            ii(0x17_7a8d, 5); sub(memw_a16[ds, 0x1fbc], 0x1);           /* sub word [0x1fbc], 0x1 */
            ii(0x17_7a92, 5); sbb(memw_a16[ds, 0x1fbe], 0);             /* sbb word [0x1fbe], 0x0 */
        l_0x17_7a97:
            ii(0x17_7a97, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x17_7a9a, 1); popw(ds);                                 /* pop ds */
            ii(0x17_7a9b, 1); leavew();                                 /* leave */
            ii(0x17_7a9c, 1); retfw(); return;                          /* retf */
        //  ii(0x17_7a9d, 3); Недостижимый (и не декодированный) код.
        //    ii(0x17_7aa0, 4); enterw(0x6, 0);                           /* enter 0x6, 0x0 */
        //    ii(0x17_7aa4, 1); pushw(di);                                /* push di */
        //    ii(0x17_7aa5, 1); pushw(si);                                /* push si */
        //    ii(0x17_7aa6, 1); pushw(ds);                                /* push ds */
        //    ii(0x17_7aa7, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
        //    ii(0x17_7aaa, 2); mov(ds, ax);                              /* mov ds, ax */
        //    ii(0x17_7aac, 5); mov(memw_a16[ss, bp - 0x6], 0);           /* mov word [bp-0x6], 0x0 */
        l_0x17_7ab1:
            ii(0x17_7ab1, 4); cmp(memw_a16[ss, bp - 0x6], 0);           /* cmp word [bp-0x6], 0x0 */
            ii(0x17_7ab5, 2); if(jnzw(0x17_7b16, 0x5f)) goto l_0x17_7b16; /* jnz 0x7b16 */
            ii(0x17_7ab7, 4); mov(bx, memw_a16[ds, 0x5198]);            /* mov bx, [0x5198] */
            ii(0x17_7abb, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x17_7abe, 4); les(si, ds, 0x4fa4);                      /* les si, [0x4fa4] */
            ii(0x17_7ac2, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
            ii(0x17_7ac5, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
            ii(0x17_7ac9, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_7acc, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x17_7acf, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x17_7ad1, 4); les(bx, ds, 0x4f9c);                      /* les bx, [0x4f9c] */
            ii(0x17_7ad5, 4); mov(si, memw_a16[ds, 0x5198]);            /* mov si, [0x5198] */
            ii(0x17_7ad9, 3); mov(cl, memb_a16[es, bx + si]);           /* mov cl, [es:bx+si] */
            ii(0x17_7adc, 2); mov(dx, cx);                              /* mov dx, cx */
            ii(0x17_7ade, 3); and(cl, 0x80);                            /* and cl, 0x80 */
            ii(0x17_7ae1, 3); cmp(cl, -0x80 /* 0x80 */);                /* cmp cl, 0x80 */
            ii(0x17_7ae4, 2); if(jzw(0x17_7afd, 0x17)) goto l_0x17_7afd; /* jz 0x7afd */
            ii(0x17_7ae6, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_7ae8, 4); les(di, ds, 0x4fa0);                      /* les di, [0x4fa0] */
            ii(0x17_7aec, 4); mov(ax, memw_a16[es, bx + di + 0x2]);     /* mov ax, [es:bx+di+0x2] */
            ii(0x17_7af0, 3); or(ax, memw_a16[es, bx + di]);            /* or ax, [es:bx+di] */
            ii(0x17_7af3, 2); if(jzw(0x17_7afd, 0x8)) goto l_0x17_7afd; /* jz 0x7afd */
            ii(0x17_7af5, 3); test(dl, 0x7f);                           /* test dl, 0x7f */
            ii(0x17_7af8, 2); if(jnzw(0x17_7afd, 0x3)) goto l_0x17_7afd; /* jnz 0x7afd */
            ii(0x17_7afa, 3); mov(memw_a16[ss, bp - 0x6], si);          /* mov [bp-0x6], si */
        l_0x17_7afd:
            ii(0x17_7afd, 2); or(si, si);                               /* or si, si */
            ii(0x17_7aff, 2); if(jzw(0x17_7b08, 0x7)) goto l_0x17_7b08; /* jz 0x7b08 */
            ii(0x17_7b01, 4); dec(memw_a16[ds, 0x5198]);                /* dec word [0x5198] */
            ii(0x17_7b05, 2); jmpw(0x17_7b13, 0xc); goto l_0x17_7b13;   /* jmp 0x7b13 */
        //    ii(0x17_7b07, 1); nop();                                    /* nop */
        l_0x17_7b08:
            ii(0x17_7b08, 3); mov(ax, memw_a16[ds, 0x50bc]);            /* mov ax, [0x50bc] */
            ii(0x17_7b0b, 1); dec(ax);                                  /* dec ax */
            ii(0x17_7b0c, 3); mov(memw_a16[ds, 0x5198], ax);            /* mov [0x5198], ax */
            ii(0x17_7b0f, 1); pushw(cs);                                /* push cs */
            ii(0x17_7b10, 3); callw(0x17_7b24, 0x11);                   /* call 0x7b24 */
        l_0x17_7b13:
            ii(0x17_7b13, 2); jmpw(0x17_7ab1, -0x64); goto l_0x17_7ab1; /* jmp 0x7ab1 */
        //    ii(0x17_7b15, 1); nop();                                    /* nop */
        l_0x17_7b16:
            ii(0x17_7b16, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x17_7b19, 1); popw(ds);                                 /* pop ds */
            ii(0x17_7b1a, 1); popw(si);                                 /* pop si */
            ii(0x17_7b1b, 1); popw(di);                                 /* pop di */
            ii(0x17_7b1c, 1); leavew();                                 /* leave */
            ii(0x17_7b1d, 1); retfw(); return;                          /* retf */
        //  ii(0x17_7b1e, 6); Недостижимый (и не декодированный) код.
        //    ii(0x17_7b24, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
        //    ii(0x17_7b28, 1); pushw(di);                                /* push di */
        //    ii(0x17_7b29, 1); pushw(si);                                /* push si */
        //    ii(0x17_7b2a, 1); pushw(ds);                                /* push ds */
        //    ii(0x17_7b2b, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
        //    ii(0x17_7b2e, 2); mov(ds, ax);                              /* mov ds, ax */
        //    ii(0x17_7b30, 5); mov(memw_a16[ss, bp - 0x6], 0);           /* mov word [bp-0x6], 0x0 */
        l_0x17_7b35:
            ii(0x17_7b35, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x17_7b38, 4); cmp(memw_a16[ds, 0x50bc], ax);            /* cmp [0x50bc], ax */
            ii(0x17_7b3c, 2); if(jaw(0x17_7b41, 0x3)) goto l_0x17_7b41; /* ja 0x7b41 */
            ii(0x17_7b3e, 3); jmpw(0x17_7be4, 0xa3); goto l_0x17_7be4;  /* jmp 0x7be4 */
        l_0x17_7b41:
            ii(0x17_7b41, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_7b43, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x17_7b46, 4); les(si, ds, 0x4fa4);                      /* les si, [0x4fa4] */
            ii(0x17_7b4a, 3); mov(cx, memw_a16[es, bx + si]);           /* mov cx, [es:bx+si] */
            ii(0x17_7b4d, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
            ii(0x17_7b51, 3); mov(memw_a16[ss, bp - 0x4], cx);          /* mov [bp-0x4], cx */
            ii(0x17_7b54, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x17_7b57, 2); mov(si, cx);                              /* mov si, cx */
            ii(0x17_7b59, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_7b5b, 2); or(dx, cx);                               /* or dx, cx */
            ii(0x17_7b5d, 2); if(jzw(0x17_7bde, 0x7f)) goto l_0x17_7bde; /* jz 0x7bde */
            ii(0x17_7b5f, 4); les(bx, ds, 0x4f9c);                      /* les bx, [0x4f9c] */
            ii(0x17_7b63, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_7b65, 3); mov(dl, memb_a16[es, bx + si]);           /* mov dl, [es:bx+si] */
            ii(0x17_7b68, 3); and(dl, 0x80);                            /* and dl, 0x80 */
            ii(0x17_7b6b, 3); cmp(dl, -0x80 /* 0x80 */);                /* cmp dl, 0x80 */
            ii(0x17_7b6e, 2); if(jzw(0x17_7bde, 0x6e)) goto l_0x17_7bde; /* jz 0x7bde */
            ii(0x17_7b70, 3); sub(cx, 0);                               /* sub cx, 0x0 */
            ii(0x17_7b73, 3); sbb(di, 0x1);                             /* sbb di, 0x1 */
            ii(0x17_7b76, 1); pushw(di);                                /* push di */
            ii(0x17_7b77, 1); pushw(cx);                                /* push cx */
            ii(0x17_7b78, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x17_7b7c, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x17_7b80, 3); callw(0x17_9208, 0x1685);                 /* call 0x9208 */
            ii(0x17_7b83, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_7b86, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x17_7b89, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x17_7b8c, 4); test(memb_a16[ss, bp - 0xa], 0x20);       /* test byte [bp-0xa], 0x20 */
            ii(0x17_7b90, 2); if(jzw(0x17_7bc2, 0x30)) goto l_0x17_7bc2; /* jz 0x7bc2 */
            ii(0x17_7b92, 4); and(memb_a16[ss, bp - 0xa], -0x21 /* 0xdf */); /* and byte [bp-0xa], 0xdf */
            ii(0x17_7b96, 1); pushw(dx);                                /* push dx */
            ii(0x17_7b97, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x17_7b9a, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x17_7b9d, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x17_7ba0, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_7ba3, 3); sbb(dx, 0x1);                             /* sbb dx, 0x1 */
            ii(0x17_7ba6, 1); pushw(dx);                                /* push dx */
            ii(0x17_7ba7, 1); pushw(ax);                                /* push ax */
            ii(0x17_7ba8, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x17_7bac, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x17_7bb0, 3); callw(0x17_9235, 0x1682);                 /* call 0x9235 */
            ii(0x17_7bb3, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x17_7bb6, 4); les(bx, ds, 0x4f9c);                      /* les bx, [0x4f9c] */
            ii(0x17_7bba, 4); or(memb_a16[es, bx + si], 0x7f);          /* or byte [es:bx+si], 0x7f */
            ii(0x17_7bbe, 2); jmpw(0x17_7bde, 0x1e); goto l_0x17_7bde;  /* jmp 0x7bde */
        //    ii(0x17_7bc0, 1); nop();                                    /* nop */
        //    ii(0x17_7bc1, 1); nop();                                    /* nop */
        l_0x17_7bc2:
            ii(0x17_7bc2, 4); les(bx, ds, 0x4f9c);                      /* les bx, [0x4f9c] */
            ii(0x17_7bc6, 3); mov(si, memw_a16[ss, bp - 0x6]);          /* mov si, [bp-0x6] */
            ii(0x17_7bc9, 4); test(memb_a16[es, bx + si], 0x7f);        /* test byte [es:bx+si], 0x7f */
            ii(0x17_7bcd, 2); if(jzw(0x17_7bde, 0xf)) goto l_0x17_7bde; /* jz 0x7bde */
            ii(0x17_7bcf, 3); mov(al, memb_a16[es, bx + si]);           /* mov al, [es:bx+si] */
            ii(0x17_7bd2, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x17_7bd4, 2); dec(al);                                  /* dec al */
            ii(0x17_7bd6, 2); xor(cl, al);                              /* xor cl, al */
            ii(0x17_7bd8, 3); and(cl, 0x7f);                            /* and cl, 0x7f */
            ii(0x17_7bdb, 3); xor(memb_a16[es, bx + si], cl);           /* xor [es:bx+si], cl */
        l_0x17_7bde:
            ii(0x17_7bde, 3); inc(memw_a16[ss, bp - 0x6]);              /* inc word [bp-0x6] */
            ii(0x17_7be1, 3); jmpw(0x17_7b35, -0xaf); goto l_0x17_7b35; /* jmp 0x7b35 */
        l_0x17_7be4:
            ii(0x17_7be4, 1); popw(ds);                                 /* pop ds */
            ii(0x17_7be5, 1); popw(si);                                 /* pop si */
            ii(0x17_7be6, 1); popw(di);                                 /* pop di */
            ii(0x17_7be7, 1); leavew();                                 /* leave */
            ii(0x17_7be8, 1); retfw(); return;                          /* retf */
        //  ii(0x17_7be9, 1); Недостижимый (и не декодированный) код.
        //    ii(0x17_7bea, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
        //    ii(0x17_7bee, 1); pushw(di);                                /* push di */
        //    ii(0x17_7bef, 1); pushw(si);                                /* push si */
        //    ii(0x17_7bf0, 1); pushw(ds);                                /* push ds */
        //    ii(0x17_7bf1, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
        //    ii(0x17_7bf4, 2); mov(ds, ax);                              /* mov ds, ax */
        //    ii(0x17_7bf6, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
        //    ii(0x17_7bf9, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
        //    ii(0x17_7bfc, 4); les(si, ds, 0x4fa0);                      /* les si, [0x4fa0] */
        //    ii(0x17_7c00, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
        //    ii(0x17_7c03, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
        //    ii(0x17_7c07, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
        //    ii(0x17_7c0a, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
        //    ii(0x17_7c0d, 4); les(si, ds, 0x4fa4);                      /* les si, [0x4fa4] */
        //    ii(0x17_7c11, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
        //    ii(0x17_7c14, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
        //    ii(0x17_7c18, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
        //    ii(0x17_7c1b, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
        //    ii(0x17_7c1e, 5); cmp(memw_a16[ds, 0x984], 0);              /* cmp word [0x984], 0x0 */
        //    ii(0x17_7c23, 2); if(jzw(0x17_7c75, 0x50)) goto l_0x17_7c75; /* jz 0x7c75 */
        //    ii(0x17_7c25, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
        //    ii(0x17_7c29, 4); mov(memb_a16[es, bx], 0x21);              /* mov byte [es:bx], 0x21 */
        //    ii(0x17_7c2d, 3); mov(al, memb_a16[ds, 0x5130]);            /* mov al, [0x5130] */
        //    ii(0x17_7c30, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
        //    ii(0x17_7c34, 4); mov(memb_a16[es, bx + 0x1], al);          /* mov [es:bx+0x1], al */
        //    ii(0x17_7c38, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
        //    ii(0x17_7c3b, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
        //    ii(0x17_7c3e, 2); mov(dh, dl);                              /* mov dh, dl */
        //    ii(0x17_7c40, 2); mov(dl, ah);                              /* mov dl, ah */
        //    ii(0x17_7c42, 2); mov(ah, al);                              /* mov ah, al */
        //    ii(0x17_7c44, 2); sub(al, al);                              /* sub al, al */
        //    ii(0x17_7c46, 2); shl(ax, 0x1);                             /* shl ax, 1 */
        //    ii(0x17_7c48, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
        //    ii(0x17_7c4a, 2); shl(ax, 0x1);                             /* shl ax, 1 */
        //    ii(0x17_7c4c, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
        //    ii(0x17_7c4e, 2); shl(ax, 0x1);                             /* shl ax, 1 */
        //    ii(0x17_7c50, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
        //    ii(0x17_7c52, 2); shl(ax, 0x1);                             /* shl ax, 1 */
        //    ii(0x17_7c54, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
        //    ii(0x17_7c56, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
        //    ii(0x17_7c5a, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
        //    ii(0x17_7c5e, 4); mov(memw_a16[es, bx + 0x4], dx);          /* mov [es:bx+0x4], dx */
        //    ii(0x17_7c62, 4); pushw(memw_a16[ds, 0x5167]);              /* push word [0x5167] */
        //    ii(0x17_7c66, 4); pushw(memw_a16[ds, 0x4fc6]);              /* push word [0x4fc6] */
        //    ii(0x17_7c6a, 4); pushw(memw_a16[ds, 0x4fc4]);              /* push word [0x4fc4] */
        //    ii(0x17_7c6e, 2); pushw(0x6);                               /* push 0x6 */
        //    ii(0x17_7c70, 1); nop();                                    /* nop */
        //    ii(0x17_7c71, 1); pushw(cs);                                /* push cs */
        //    ii(0x17_7c72, 3); callw(0x17_0864, -0x7411);                /* call 0x864 */
        l_0x17_7c75:
            ii(0x17_7c75, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x17_7c78, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x17_7c7b, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_7c7e, 3); sbb(dx, 0x1);                             /* sbb dx, 0x1 */
            ii(0x17_7c81, 1); pushw(dx);                                /* push dx */
            ii(0x17_7c82, 1); pushw(ax);                                /* push ax */
            ii(0x17_7c83, 4); pushw(memw_a16[ds, 0x1fa6]);              /* push word [0x1fa6] */
            ii(0x17_7c87, 4); pushw(memw_a16[ds, 0x1fa4]);              /* push word [0x1fa4] */
            ii(0x17_7c8b, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_7c8d, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_7c8f, 3); callw(0x17_90c4, 0x1432);                 /* call 0x90c4 */
            ii(0x17_7c92, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_7c95, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x17_7c98, 1); pushw(di);                                /* push di */
            ii(0x17_7c99, 1); pushw(si);                                /* push si */
            ii(0x17_7c9a, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x17_7c9e, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x17_7ca2, 3); callw(0x17_9208, 0x1563);                 /* call 0x9208 */
            ii(0x17_7ca5, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_7ca8, 1); pushw(dx);                                /* push dx */
            ii(0x17_7ca9, 1); pushw(ax);                                /* push ax */
            ii(0x17_7caa, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x17_7cac, 3); mov(bx, memw_a16[ss, bp - 0xa]);          /* mov bx, [bp-0xa] */
            ii(0x17_7caf, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x17_7cb2, 4); pushw(memw_a16[ds, bx + 0x2026]);         /* push word [bx+0x2026] */
            ii(0x17_7cb6, 4); pushw(memw_a16[ds, bx + 0x2024]);         /* push word [bx+0x2024] */
            ii(0x17_7cba, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x17_7cbd, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x17_7cc0, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_7cc2, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x17_7cc5, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x17_7cc8, 4); callw_a16_far_ind(ds, bx + 0x2020);       /* call far word [bx+0x2020] */
            ii(0x17_7ccc, 3); add(sp, 0x14);                            /* add sp, 0x14 */
            ii(0x17_7ccf, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_7cd1, 2); if(jzw(0x17_7cea, 0x17)) goto l_0x17_7cea; /* jz 0x7cea */
            ii(0x17_7cd3, 4); pushw(memw_a16[ds, 0x51a7]);              /* push word [0x51a7] */
            ii(0x17_7cd7, 1); pushw(di);                                /* push di */
            ii(0x17_7cd8, 1); pushw(si);                                /* push si */
            ii(0x17_7cd9, 4); pushw(memw_a16[ds, 0x1fa6]);              /* push word [0x1fa6] */
            ii(0x17_7cdd, 4); pushw(memw_a16[ds, 0x1fa4]);              /* push word [0x1fa4] */
            ii(0x17_7ce1, 3); callw(0x17_91e3, 0x14ff);                 /* call 0x91e3 */
            ii(0x17_7ce4, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_7ce7, 2); jmpw(0x17_7c75, -0x74); goto l_0x17_7c75; /* jmp 0x7c75 */
        //    ii(0x17_7ce9, 1); nop();                                    /* nop */
        l_0x17_7cea:
            ii(0x17_7cea, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x17_7ced, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x17_7cf0, 1); pushw(cs);                                /* push cs */
            ii(0x17_7cf1, 3); callw(0x17_7f8a, 0x296);                  /* call 0x7f8a */
            ii(0x17_7cf4, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_7cf7, 1); popw(ds);                                 /* pop ds */
            ii(0x17_7cf8, 1); popw(si);                                 /* pop si */
            ii(0x17_7cf9, 1); popw(di);                                 /* pop di */
            ii(0x17_7cfa, 1); leavew();                                 /* leave */
            ii(0x17_7cfb, 1); retfw(); return;                          /* retf */
        }
    }
}
