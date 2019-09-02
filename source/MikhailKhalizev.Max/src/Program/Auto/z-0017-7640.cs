using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_7640-f2d058ce")]
        public void Method_0017_7640()
        {
            ii(0x17_7640, 4); enter(0x22, 0);                           /* enter 0x22, 0x0 */
            ii(0x17_7644, 1); push(di);                                 /* push di */
            ii(0x17_7645, 1); push(si);                                 /* push si */
            ii(0x17_7646, 1); push(ds);                                 /* push ds */
            ii(0x17_7647, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_764a, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_764c, 5); mov(memw[ss, bp - 0x10], 1);              /* mov word [bp-0x10], 0x1 */
            ii(0x17_7651, 5); mov(memw[ss, bp - 0xe], 0x70);            /* mov word [bp-0xe], 0x70 */
            ii(0x17_7656, 5); mov(memw[ss, bp - 0xc], 0x10);            /* mov word [bp-0xc], 0x10 */
            ii(0x17_765b, 3); mov(ax, 0x70);                            /* mov ax, 0x70 */
            ii(0x17_765e, 3); mov(dx, 0x10);                            /* mov dx, 0x10 */
            ii(0x17_7661, 1); push(ds);                                 /* push ds */
            ii(0x17_7662, 3); lea(di, memw[ss, bp - 0x1c]);             /* lea di, [bp-0x1c] */
            ii(0x17_7665, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_7667, 1); push(ss);                                 /* push ss */
            ii(0x17_7668, 1); pop(es);                                  /* pop es */
            ii(0x17_7669, 2); mov(ds, dx);                              /* mov ds, dx */
            ii(0x17_766b, 1); movsw();                                  /* movsw */
            ii(0x17_766c, 1); movsw();                                  /* movsw */
            ii(0x17_766d, 1); movsw();                                  /* movsw */
            ii(0x17_766e, 1); movsw();                                  /* movsw */
            ii(0x17_766f, 1); pop(ds);                                  /* pop ds */
            ii(0x17_7670, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x17_7672, 3); mov(si, 0x9e);                            /* mov si, 0x9e */
            ii(0x17_7675, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x17_7677, 1); movsw();                                  /* movsw */
            ii(0x17_7678, 1); movsw();                                  /* movsw */
            ii(0x17_7679, 1); movsw();                                  /* movsw */
            ii(0x17_767a, 1); movsw();                                  /* movsw */
            ii(0x17_767b, 4); les(bx, memw[ds, 0x1efc]);                /* les bx, [0x1efc] */
            ii(0x17_767f, 3); inc(memb[es, bx]);                        /* inc byte [es:bx] */
            ii(0x17_7682, 1); nop();                                    /* nop */
            ii(0x17_7683, 1); push(cs);                                 /* push cs */
            ii(0x17_7684, 3); call(0x17_06b4, -0x6fd3);                 /* call 0x6b4 */
            ii(0x17_7687, 1); nop();                                    /* nop */
            ii(0x17_7688, 1); push(cs);                                 /* push cs */
            ii(0x17_7689, 3); call(0x17_8ea2, 0x1816);                  /* call 0x8ea2 */
            ii(0x17_768c, 1); sti();                                    /* sti */
            ii(0x17_768d, 3); les(bx, memw[ss, bp + 0xa]);              /* les bx, [bp+0xa] */
            ii(0x17_7690, 4); push(memw[es, bx + 0x22]);                /* push word [es:bx+0x22] */
            ii(0x17_7694, 4); push(memw[es, bx + 0x20]);                /* push word [es:bx+0x20] */
            ii(0x17_7698, 4); push(memw[es, bx + 0x4c]);                /* push word [es:bx+0x4c] */
            ii(0x17_769c, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x17_769f, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x17_76a2, 1); push(ds);                                 /* push ds */
            ii(0x17_76a3, 3); push(0x8de);                              /* push 0x8de */
            ii(0x17_76a6, 1); nop();                                    /* nop */
            ii(0x17_76a7, 1); push(cs);                                 /* push cs */
            ii(0x17_76a8, 3); call(0x17_104f, -0x665c);                 /* call 0x104f */
            ii(0x17_76ab, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x17_76ae, 5); cmp(memw[ds, 0x984], 0);                  /* cmp word [0x984], 0x0 */
            ii(0x17_76b3, 2); if(jz(0x17_7713, 0x5e)) goto l_0x17_7713; /* jz 0x7713 */
            ii(0x17_76b5, 4); les(bx, memw[ds, 0x4fc4]);                /* les bx, [0x4fc4] */
            ii(0x17_76b9, 4); mov(memb[es, bx], 0x20);                  /* mov byte [es:bx], 0x20 */
            ii(0x17_76bd, 3); mov(al, memb[ds, 0x5130]);                /* mov al, [0x5130] */
            ii(0x17_76c0, 4); les(bx, memw[ds, 0x4fc4]);                /* les bx, [0x4fc4] */
            ii(0x17_76c4, 4); mov(memb[es, bx + 1], al);                /* mov [es:bx+0x1], al */
            ii(0x17_76c8, 3); mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x17_76cb, 3); mov(dx, memw[ss, bp + 8]);                /* mov dx, [bp+0x8] */
            ii(0x17_76ce, 4); les(bx, memw[ds, 0x4fc4]);                /* les bx, [0x4fc4] */
            ii(0x17_76d2, 4); mov(memw[es, bx + 2], ax);                /* mov [es:bx+0x2], ax */
            ii(0x17_76d6, 4); mov(memw[es, bx + 4], dx);                /* mov [es:bx+0x4], dx */
            ii(0x17_76da, 3); les(bx, memw[ss, bp + 0xa]);              /* les bx, [bp+0xa] */
            ii(0x17_76dd, 4); mov(ax, memw[es, bx + 0x20]);             /* mov ax, [es:bx+0x20] */
            ii(0x17_76e1, 4); mov(dx, memw[es, bx + 0x22]);             /* mov dx, [es:bx+0x22] */
            ii(0x17_76e5, 4); les(si, memw[ds, 0x4fc4]);                /* les si, [0x4fc4] */
            ii(0x17_76e9, 4); mov(memw[es, si + 6], ax);                /* mov [es:si+0x6], ax */
            ii(0x17_76ed, 4); mov(memw[es, si + 8], dx);                /* mov [es:si+0x8], dx */
            ii(0x17_76f1, 3); les(bx, memw[ss, bp + 0xa]);              /* les bx, [bp+0xa] */
            ii(0x17_76f4, 4); mov(ax, memw[es, bx + 0x4c]);             /* mov ax, [es:bx+0x4c] */
            ii(0x17_76f8, 4); les(bx, memw[ds, 0x4fc4]);                /* les bx, [0x4fc4] */
            ii(0x17_76fc, 4); mov(memw[es, bx + 0xa], ax);              /* mov [es:bx+0xa], ax */
            ii(0x17_7700, 4); push(memw[ds, 0x5167]);                   /* push word [0x5167] */
            ii(0x17_7704, 4); push(memw[ds, 0x4fc6]);                   /* push word [0x4fc6] */
            ii(0x17_7708, 4); push(memw[ds, 0x4fc4]);                   /* push word [0x4fc4] */
            ii(0x17_770c, 2); push(0xc);                                /* push 0xc */
            ii(0x17_770e, 1); nop();                                    /* nop */
            ii(0x17_770f, 1); push(cs);                                 /* push cs */
            ii(0x17_7710, 3); call(0x17_0864, -0x6eaf);                 /* call 0x864 */
        l_0x17_7713:
            ii(0x17_7713, 3); mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x17_7716, 3); mov(dx, memw[ss, bp + 8]);                /* mov dx, [bp+0x8] */
            ii(0x17_7719, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_771b, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_771d, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_771f, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_7721, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_7723, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_7725, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_7727, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_7729, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_772b, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_772d, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_772f, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_7731, 3); mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x17_7734, 3); mov(memw[ss, bp - 8], dx);                /* mov [bp-0x8], dx */
            ii(0x17_7737, 1); push(cs);                                 /* push cs */
            ii(0x17_7738, 3); call(0x17_7a54, 0x319);                   /* call 0x7a54 */
            ii(0x17_773b, 3); mov(memw[ss, bp - 0x1e], ax);             /* mov [bp-0x1e], ax */
            ii(0x17_773e, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_7741, 2); if(jnz(0x17_7774, 0x31)) goto l_0x17_7774; /* jnz 0x7774 */
            ii(0x17_7743, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x17_7746, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x17_7749, 3); push(0x922);                              /* push 0x922 */
            ii(0x17_774c, 1); nop();                                    /* nop */
            ii(0x17_774d, 1); push(cs);                                 /* push cs */
            ii(0x17_774e, 3); call(0x17_75b4, -0x19d);                  /* call 0x75b4 */
            ii(0x17_7751, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x17_7754, 4); les(bx, memw[ds, 0x1efc]);                /* les bx, [0x1efc] */
            ii(0x17_7758, 3); dec(memb[es, bx]);                        /* dec byte [es:bx] */
            ii(0x17_775b, 1); push(ds);                                 /* push ds */
            ii(0x17_775c, 3); lea(si, memw[ss, bp - 0x1c]);             /* lea si, [bp-0x1c] */
            ii(0x17_775f, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x17_7761, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_7763, 3); les(di, memw[ss, bp - 0xe]);              /* les di, [bp-0xe] */
            ii(0x17_7766, 1); movsw();                                  /* movsw */
            ii(0x17_7767, 1); movsw();                                  /* movsw */
            ii(0x17_7768, 1); movsw();                                  /* movsw */
            ii(0x17_7769, 1); movsw();                                  /* movsw */
            ii(0x17_776a, 1); pop(ds);                                  /* pop ds */
            ii(0x17_776b, 3); mov(ax, memw[ss, bp - 0x10]);             /* mov ax, [bp-0x10] */
            ii(0x17_776e, 1); pop(ds);                                  /* pop ds */
            ii(0x17_776f, 1); pop(si);                                  /* pop si */
            ii(0x17_7770, 1); pop(di);                                  /* pop di */
            ii(0x17_7771, 1); leave();                                  /* leave */
            ii(0x17_7772, 1); retf(); return;                           /* retf */
        //  ii(0x17_7773, 1); Недостижимый код.
        l_0x17_7774:
            ii(0x17_7774, 1); pusha();                                  /* pusha */
            ii(0x17_7775, 1); sti();                                    /* sti */
            ii(0x17_7776, 1); nop();                                    /* nop */
            ii(0x17_7777, 1); cli();                                    /* cli */
            ii(0x17_7778, 1); popa();                                   /* popa */
            ii(0x17_7779, 1); nop();                                    /* nop */
            ii(0x17_777a, 1); push(cs);                                 /* push cs */
            ii(0x17_777b, 3); call(0x17_06b4, -0x70ca);                 /* call 0x6b4 */
            ii(0x17_777e, 1); nop();                                    /* nop */
            ii(0x17_777f, 1); push(cs);                                 /* push cs */
            ii(0x17_7780, 3); call(0x17_8ea2, 0x171f);                  /* call 0x8ea2 */
            ii(0x17_7783, 2); push(0);                                  /* push 0x0 */
            ii(0x17_7785, 3); push(memw[ss, bp - 0x1e]);                /* push word [bp-0x1e] */
            ii(0x17_7788, 3); push(memw[ss, bp - 8]);                   /* push word [bp-0x8] */
            ii(0x17_778b, 3); push(memw[ss, bp - 0xa]);                 /* push word [bp-0xa] */
            ii(0x17_778e, 1); push(cs);                                 /* push cs */
            ii(0x17_778f, 3); call(0x17_7dac, 0x61a);                   /* call 0x7dac */
            ii(0x17_7792, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_7795, 3); mov(ax, memw[ss, bp - 0xa]);              /* mov ax, [bp-0xa] */
            ii(0x17_7798, 3); mov(dx, memw[ss, bp - 8]);                /* mov dx, [bp-0x8] */
            ii(0x17_779b, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_779e, 3); sbb(dx, 1);                               /* sbb dx, 0x1 */
            ii(0x17_77a1, 1); push(dx);                                 /* push dx */
            ii(0x17_77a2, 1); push(ax);                                 /* push ax */
            ii(0x17_77a3, 4); push(memw[ds, 0x4f8e]);                   /* push word [0x4f8e] */
            ii(0x17_77a7, 4); push(memw[ds, 0x4f8c]);                   /* push word [0x4f8c] */
            ii(0x17_77ab, 3); call(0x17_9208, 0x1a5a);                  /* call 0x9208 */
            ii(0x17_77ae, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_77b1, 3); mov(memw[ss, bp - 6], ax);                /* mov [bp-0x6], ax */
            ii(0x17_77b4, 3); mov(memw[ss, bp - 4], dx);                /* mov [bp-0x4], dx */
            ii(0x17_77b7, 1); push(dx);                                 /* push dx */
            ii(0x17_77b8, 1); push(ax);                                 /* push ax */
            ii(0x17_77b9, 3); push(memw[ss, bp - 8]);                   /* push word [bp-0x8] */
            ii(0x17_77bc, 3); push(memw[ss, bp - 0xa]);                 /* push word [bp-0xa] */
            ii(0x17_77bf, 1); push(cs);                                 /* push cs */
            ii(0x17_77c0, 3); call(0x17_7cfc, 0x539);                   /* call 0x7cfc */
            ii(0x17_77c3, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_77c6, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x17_77c9, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_77cb, 2); if(jz(0x17_77ec, 0x1f)) goto l_0x17_77ec; /* jz 0x77ec */
            ii(0x17_77cd, 4); les(bx, memw[ds, 0x1efc]);                /* les bx, [0x1efc] */
            ii(0x17_77d1, 3); dec(memb[es, bx]);                        /* dec byte [es:bx] */
            ii(0x17_77d4, 1); push(ds);                                 /* push ds */
            ii(0x17_77d5, 3); lea(si, memw[ss, bp - 0x1c]);             /* lea si, [bp-0x1c] */
            ii(0x17_77d8, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x17_77da, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_77dc, 3); les(di, memw[ss, bp - 0xe]);              /* les di, [bp-0xe] */
            ii(0x17_77df, 1); movsw();                                  /* movsw */
            ii(0x17_77e0, 1); movsw();                                  /* movsw */
            ii(0x17_77e1, 1); movsw();                                  /* movsw */
            ii(0x17_77e2, 1); movsw();                                  /* movsw */
            ii(0x17_77e3, 1); pop(ds);                                  /* pop ds */
            ii(0x17_77e4, 3); mov(ax, memw[ss, bp - 0x10]);             /* mov ax, [bp-0x10] */
            ii(0x17_77e7, 1); pop(ds);                                  /* pop ds */
            ii(0x17_77e8, 1); pop(si);                                  /* pop si */
            ii(0x17_77e9, 1); pop(di);                                  /* pop di */
            ii(0x17_77ea, 1); leave();                                  /* leave */
            ii(0x17_77eb, 1); retf(); return;                           /* retf */
        l_0x17_77ec:
            ii(0x17_77ec, 3); les(bx, memw[ss, bp + 0xa]);              /* les bx, [bp+0xa] */
            ii(0x17_77ef, 4); mov(ax, memw[es, bx + 0x50]);             /* mov ax, [es:bx+0x50] */
            ii(0x17_77f3, 3); mov(dx, 8);                               /* mov dx, 0x8 */
            ii(0x17_77f6, 3); mov(memw[ss, bp - 0x14], ax);             /* mov [bp-0x14], ax */
            ii(0x17_77f9, 3); mov(memw[ss, bp - 0x12], dx);             /* mov [bp-0x12], dx */
            ii(0x17_77fc, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x17_77fe, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_7800, 4); mov(cx, memw[es, bx + 2]);                /* mov cx, [es:bx+0x2] */
            ii(0x17_7804, 4); mov(al, memb[es, bx + 4]);                /* mov al, [es:bx+0x4] */
            ii(0x17_7808, 4); mov(dl, memb[es, bx + 7]);                /* mov dl, [es:bx+0x7] */
            ii(0x17_780c, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_780e, 3); shl(dx, 8);                               /* shl dx, 0x8 */
            ii(0x17_7811, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_7813, 2); add(dx, ax);                              /* add dx, ax */
            ii(0x17_7815, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x17_7817, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x17_7819, 3); mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x17_781c, 3); mov(memw[ss, bp - 8], dx);                /* mov [bp-0x8], dx */
            ii(0x17_781f, 5); test(memb[es, bx + 6], 0x40);             /* test byte [es:bx+0x6], 0x40 */
            ii(0x17_7824, 2); if(jz(0x17_7840, 0x1a)) goto l_0x17_7840; /* jz 0x7840 */
            ii(0x17_7826, 3); les(bx, memw[ss, bp + 0xa]);              /* les bx, [bp+0xa] */
            ii(0x17_7829, 4); add(ax, memw[es, bx + 0x38]);             /* add ax, [es:bx+0x38] */
            ii(0x17_782d, 4); adc(dx, memw[es, bx + 0x3a]);             /* adc dx, [es:bx+0x3a] */
            ii(0x17_7831, 3); sub(ax, 0x14);                            /* sub ax, 0x14 */
            ii(0x17_7834, 3); sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x17_7837, 3); mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x17_783a, 3); mov(memw[ss, bp - 8], dx);                /* mov [bp-0x8], dx */
            ii(0x17_783d, 2); jmp(0x17_7854, 0x15); goto l_0x17_7854;   /* jmp 0x7854 */
        //  ii(0x17_783f, 1); nop();                                    /* nop */
        l_0x17_7840:
            ii(0x17_7840, 3); les(bx, memw[ss, bp + 0xa]);              /* les bx, [bp+0xa] */
            ii(0x17_7843, 4); mov(ax, memw[es, bx + 0x38]);             /* mov ax, [es:bx+0x38] */
            ii(0x17_7847, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_7849, 3); sub(ax, 0x14);                            /* sub ax, 0x14 */
            ii(0x17_784c, 2); sbb(dx, dx);                              /* sbb dx, dx */
            ii(0x17_784e, 3); add(memw[ss, bp - 0xa], ax);              /* add [bp-0xa], ax */
            ii(0x17_7851, 3); adc(memw[ss, bp - 8], dx);                /* adc [bp-0x8], dx */
        l_0x17_7854:
            ii(0x17_7854, 2); push(0xc);                                /* push 0xc */
            ii(0x17_7856, 3); lea(ax, memw[ss, bp - 0xa]);              /* lea ax, [bp-0xa] */
            ii(0x17_7859, 1); push(ss);                                 /* push ss */
            ii(0x17_785a, 1); push(ax);                                 /* push ax */
            ii(0x17_785b, 1); nop();                                    /* nop */
            ii(0x17_785c, 1); push(cs);                                 /* push cs */
            ii(0x17_785d, 3); call(0x17_ddbc, 0x655c);                  /* call 0xddbc */
            ii(0x17_7860, 3); cmp(dx, 1);                               /* cmp dx, 0x1 */
            ii(0x17_7863, 2); if(jb(0x17_78d5, 0x70)) goto l_0x17_78d5; /* jb 0x78d5 */
            ii(0x17_7865, 2); if(ja(0x17_7867, 0)) goto l_0x17_7867;    /* ja 0x7867 */
        l_0x17_7867:
            ii(0x17_7867, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_786a, 3); sbb(dx, 1);                               /* sbb dx, 0x1 */
            ii(0x17_786d, 1); push(dx);                                 /* push dx */
            ii(0x17_786e, 1); push(ax);                                 /* push ax */
            ii(0x17_786f, 4); push(memw[ds, 0x4f8e]);                   /* push word [0x4f8e] */
            ii(0x17_7873, 4); push(memw[ds, 0x4f8c]);                   /* push word [0x4f8c] */
            ii(0x17_7877, 3); call(0x17_9208, 0x198e);                  /* call 0x9208 */
            ii(0x17_787a, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_787d, 3); mov(memw[ss, bp - 6], ax);                /* mov [bp-0x6], ax */
            ii(0x17_7880, 3); mov(memw[ss, bp - 4], dx);                /* mov [bp-0x4], dx */
            ii(0x17_7883, 3); mov(memw[ss, bp - 0x22], ax);             /* mov [bp-0x22], ax */
            ii(0x17_7886, 3); mov(memw[ss, bp - 0x20], dx);             /* mov [bp-0x20], dx */
            ii(0x17_7889, 4); test(memb[ss, bp - 0x22], 1);             /* test byte [bp-0x22], 0x1 */
            ii(0x17_788d, 2); if(jnz(0x17_78d5, 0x46)) goto l_0x17_78d5; /* jnz 0x78d5 */
            ii(0x17_788f, 1); push(cs);                                 /* push cs */
            ii(0x17_7890, 3); call(0x17_7a54, 0x1c1);                   /* call 0x7a54 */
            ii(0x17_7893, 3); mov(memw[ss, bp - 0x1e], ax);             /* mov [bp-0x1e], ax */
            ii(0x17_7896, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_7899, 2); if(jnz(0x17_78ac, 0x11)) goto l_0x17_78ac; /* jnz 0x78ac */
            ii(0x17_789b, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x17_789e, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x17_78a1, 3); push(0x922);                              /* push 0x922 */
            ii(0x17_78a4, 1); nop();                                    /* nop */
            ii(0x17_78a5, 1); push(cs);                                 /* push cs */
            ii(0x17_78a6, 3); call(0x17_75b4, -0x2f5);                  /* call 0x75b4 */
            ii(0x17_78a9, 3); add(sp, 6);                               /* add sp, 0x6 */
        l_0x17_78ac:
            ii(0x17_78ac, 2); push(0);                                  /* push 0x0 */
            ii(0x17_78ae, 3); push(memw[ss, bp - 0x1e]);                /* push word [bp-0x1e] */
            ii(0x17_78b1, 3); push(memw[ss, bp - 8]);                   /* push word [bp-0x8] */
            ii(0x17_78b4, 3); push(memw[ss, bp - 0xa]);                 /* push word [bp-0xa] */
            ii(0x17_78b7, 1); push(cs);                                 /* push cs */
            ii(0x17_78b8, 3); call(0x17_7dac, 0x4f1);                   /* call 0x7dac */
            ii(0x17_78bb, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_78be, 3); push(memw[ss, bp - 4]);                   /* push word [bp-0x4] */
            ii(0x17_78c1, 3); push(memw[ss, bp - 6]);                   /* push word [bp-0x6] */
            ii(0x17_78c4, 3); push(memw[ss, bp - 8]);                   /* push word [bp-0x8] */
            ii(0x17_78c7, 3); push(memw[ss, bp - 0xa]);                 /* push word [bp-0xa] */
            ii(0x17_78ca, 1); push(cs);                                 /* push cs */
            ii(0x17_78cb, 3); call(0x17_7cfc, 0x42e);                   /* call 0x7cfc */
            ii(0x17_78ce, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_78d1, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_78d3, 2); if(jz(0x17_78d5, 0)) goto l_0x17_78d5;    /* jz 0x78d5 */
        l_0x17_78d5:
            ii(0x17_78d5, 4); dec(memb[ds, 0x996]);                     /* dec byte [0x996] */
            ii(0x17_78d9, 1); push(ds);                                 /* push ds */
            ii(0x17_78da, 3); push(0x8f2);                              /* push 0x8f2 */
            ii(0x17_78dd, 1); nop();                                    /* nop */
            ii(0x17_78de, 1); push(cs);                                 /* push cs */
            ii(0x17_78df, 3); call(0x17_104f, -0x6893);                 /* call 0x104f */
            ii(0x17_78e2, 3); add(sp, 4);                               /* add sp, 0x4 */
            ii(0x17_78e5, 4); les(bx, memw[ds, 0x1efc]);                /* les bx, [0x1efc] */
            ii(0x17_78e9, 3); dec(memb[es, bx]);                        /* dec byte [es:bx] */
            ii(0x17_78ec, 1); nop();                                    /* nop */
            ii(0x17_78ed, 1); push(cs);                                 /* push cs */
            ii(0x17_78ee, 3); call(0x17_8e97, 0x15a6);                  /* call 0x8e97 */
            ii(0x17_78f1, 1); push(ds);                                 /* push ds */
            ii(0x17_78f2, 3); lea(si, memw[ss, bp - 0x1c]);             /* lea si, [bp-0x1c] */
            ii(0x17_78f5, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x17_78f7, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_78f9, 3); les(di, memw[ss, bp - 0xe]);              /* les di, [bp-0xe] */
            ii(0x17_78fc, 1); movsw();                                  /* movsw */
            ii(0x17_78fd, 1); movsw();                                  /* movsw */
            ii(0x17_78fe, 1); movsw();                                  /* movsw */
            ii(0x17_78ff, 1); movsw();                                  /* movsw */
            ii(0x17_7900, 1); pop(ds);                                  /* pop ds */
            ii(0x17_7901, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_7903, 1); pop(ds);                                  /* pop ds */
            ii(0x17_7904, 1); pop(si);                                  /* pop si */
            ii(0x17_7905, 1); pop(di);                                  /* pop di */
            ii(0x17_7906, 1); leave();                                  /* leave */
            ii(0x17_7907, 1); retf();                                   /* retf */
        }
    }
}
