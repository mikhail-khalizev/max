using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7310fafe-74e9-401b-86d8-5438688010c5")]
        public void Method_0014_a5d9()
        {
            ii(0x14_a5d9, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x14_a5dc, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x14_a5df, 2); if(jzw(0x14_a652, 0x71)) goto l_0x14_a652; /* jz 0xa652 */
            ii(0x14_a5e1, 4); mov(es, memw_a16[ds, 0xc34]);             /* mov es, [0xc34] */
            ii(0x14_a5e5, 2); shr(al, 0x1);                             /* shr al, 1 */
            ii(0x14_a5e7, 2); sbb(dl, dl);                              /* sbb dl, dl */
            ii(0x14_a5e9, 1); cbw();                                    /* cbw */
            ii(0x14_a5ea, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x14_a5ed, 3); mov(cl, memb_a16[ss, bp + 0x16]);         /* mov cl, [bp+0x16] */
            ii(0x14_a5f0, 3); and(cl, 0xc0);                            /* and cl, 0xc0 */
            ii(0x14_a5f3, 2); if(jzw(0x14_a651, 0x5c)) goto l_0x14_a651; /* jz 0xa651 */
            ii(0x14_a5f5, 2); and(dl, cl);                              /* and dl, cl */
            ii(0x14_a5f7, 2); not(cl);                                  /* not cl */
            ii(0x14_a5f9, 2); and(cl, al);                              /* and cl, al */
            ii(0x14_a5fb, 2); or(cl, dl);                               /* or cl, dl */
            ii(0x14_a5fd, 3); mov(memb_a16[es, bx], cl);                /* mov [es:bx], cl */
            ii(0x14_a600, 5); cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
            ii(0x14_a605, 2); if(jzw(0x14_a613, 0xc)) goto l_0x14_a613; /* jz 0xa613 */
            ii(0x14_a607, 5); mov(bx, memw_a16[cs, 0x44c4]);            /* mov bx, [cs:0x44c4] */
            ii(0x14_a60c, 5); test(memb_a16[cs, bx - 0x2], 0x80);       /* test byte [cs:bx-0x2], 0x80 */
            ii(0x14_a611, 2); if(jzw(0x14_a651, 0x3e)) goto l_0x14_a651; /* jz 0xa651 */
        l_0x14_a613:
            ii(0x14_a613, 1); pushw(ax);                                /* push ax */
            ii(0x14_a614, 2); and(al, 0xc0);                            /* and al, 0xc0 */
            ii(0x14_a616, 2); xor(cx, cx);                              /* xor cx, cx */
            ii(0x14_a618, 2); sub(cl, al);                              /* sub cl, al */
            ii(0x14_a61a, 2); rcr(cl, 0x1);                             /* rcr cl, 1 */
            ii(0x14_a61c, 2); sub(ch, dl);                              /* sub ch, dl */
            ii(0x14_a61e, 2); rcr(ch, 0x1);                             /* rcr ch, 1 */
            ii(0x14_a620, 2); xor(cl, ch);                              /* xor cl, ch */
            ii(0x14_a622, 2); if(jnsw(0x14_a650, 0x2c)) goto l_0x14_a650; /* jns 0xa650 */
            ii(0x14_a624, 1); pushw(cx);                                /* push cx */
            ii(0x14_a625, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x14_a628, 3); mov(ax, 0x6);                             /* mov ax, 0x6 */
            ii(0x14_a62b, 1); pushw(cs);                                /* push cs */
            ii(0x14_a62c, 3); callw(0x14_a3b9, -0x276);                 /* call 0xa3b9 */
            ii(0x14_a62f, 1); popw(ax);                                 /* pop ax */
            ii(0x14_a630, 2); if(jbw(0x14_a655, 0x23)) goto l_0x14_a655; /* jb 0xa655 */
            ii(0x14_a632, 3); lsl(di, bx);                              /* lsl di, bx */
            ii(0x14_a635, 3); cmp(cx, 0x10);                            /* cmp cx, 0x10 */
            ii(0x14_a638, 2); if(jbw(0x14_a650, 0x16)) goto l_0x14_a650; /* jb 0xa650 */
            ii(0x14_a63a, 2); mov(bx, cx);                              /* mov bx, cx */
            ii(0x14_a63c, 2); mov(cx, dx);                              /* mov cx, dx */
            ii(0x14_a63e, 2); xor(si, si);                              /* xor si, si */
            ii(0x14_a640, 2); shl(al, 0x1);                             /* shl al, 1 */
            ii(0x14_a642, 2); if(jbw(0x14_a665, 0x21)) goto l_0x14_a665; /* jb 0xa665 */
        l_0x14_a644:
            ii(0x14_a644, 1); cmc();                                    /* cmc */
            ii(0x14_a645, 3); mov(ax, 0x300);                           /* mov ax, 0x300 */
            ii(0x14_a648, 2); rcl(ax, 0x1);                             /* rcl ax, 1 */
            ii(0x14_a64a, 1); pushw(cs);                                /* push cs */
            ii(0x14_a64b, 3); callw(0x14_a3b9, -0x295);                 /* call 0xa3b9 */
            ii(0x14_a64e, 2); if(jbw(0x14_a655, 0x5)) goto l_0x14_a655; /* jb 0xa655 */
        l_0x14_a650:
            ii(0x14_a650, 1); popw(ax);                                 /* pop ax */
        l_0x14_a651:
            ii(0x14_a651, 1); retw(); return;                           /* ret */
        l_0x14_a652:
            ii(0x14_a652, 3); jmpw_func(0x14_a838, 0x1e3); return;      /* jmp 0xa838 */
        l_0x14_a655:
            ii(0x14_a655, 1); popw(ax);                                 /* pop ax */
            ii(0x14_a656, 4); mov(es, memw_a16[ds, 0xc34]);             /* mov es, [0xc34] */
            ii(0x14_a65a, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x14_a65d, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x14_a660, 3); mov(memb_a16[es, bx], al);                /* mov [es:bx], al */
            ii(0x14_a663, 2); jmpw(0x14_a652, -0x13); goto l_0x14_a652; /* jmp 0xa652 */
        l_0x14_a665:
            ii(0x14_a665, 1); pushw(bp);                                /* push bp */
            ii(0x14_a666, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x14_a668, 3); sub(sp, 0x30);                            /* sub sp, 0x30 */
            ii(0x14_a66b, 1); pushw(ax);                                /* push ax */
            ii(0x14_a66c, 2); pushd(edi);                               /* push edi */
            ii(0x14_a66e, 3); xor(edi, edi);                            /* xor edi, edi */
            ii(0x14_a671, 2); mov(di, sp);                              /* mov di, sp */
            ii(0x14_a673, 3); lea(di, di + 0x4);                        /* lea di, [di+0x4] */
            ii(0x14_a676, 1); pushw(ss);                                /* push ss */
            ii(0x14_a677, 1); popw(es);                                 /* pop es */
            ii(0x14_a678, 3); mov(ax, 0x500);                           /* mov ax, 0x500 */
            ii(0x14_a67b, 1); pushw(cs);                                /* push cs */
            ii(0x14_a67c, 3); callw(0x14_a3b9, -0x2c6);                 /* call 0xa3b9 */
            ii(0x14_a67f, 2); if(jbw(0x14_a68d, 0xc)) goto l_0x14_a68d; /* jb 0xa68d */
            ii(0x14_a681, 1); popw(ax);                                 /* pop ax */
            ii(0x14_a682, 1); pushw(ax);                                /* push ax */
            ii(0x14_a683, 3); shr(ax, 0xc);                             /* shr ax, 0xc */
            ii(0x14_a686, 3); add(ax, 0x50);                            /* add ax, 0x50 */
            ii(0x14_a689, 4); cmp(ax, memw_a16[ss, di + 0x8]);          /* cmp ax, [ss:di+0x8] */
        l_0x14_a68d:
            ii(0x14_a68d, 2); popd(edi);                                /* pop edi */
            ii(0x14_a68f, 1); popw(ax);                                 /* pop ax */
            ii(0x14_a690, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x14_a692, 1); popw(bp);                                 /* pop bp */
            ii(0x14_a693, 2); if(jaew(0x14_a655, -0x40)) goto l_0x14_a655; /* jae 0xa655 */
            ii(0x14_a695, 1); stc();                                    /* stc */
            ii(0x14_a696, 2); jmpw(0x14_a644, -0x54); goto l_0x14_a644; /* jmp 0xa644 */
        }
    }
}
