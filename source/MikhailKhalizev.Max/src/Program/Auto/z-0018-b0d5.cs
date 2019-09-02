using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_b0d5-48cdea05")]
        public void Method_0018_b0d5()
        {
            ii(0x18_b0d5, 1); push(bp);                                 /* push bp */
            ii(0x18_b0d6, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_b0d8, 3); mov(bp, memw[ss, bp + 4]);                /* mov bp, [bp+0x4] */
            ii(0x18_b0db, 4); mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x18_b0df, 1); push(di);                                 /* push di */
            ii(0x18_b0e0, 3); call(0x18_ab22, -0x5c1);                  /* call 0xab22 */
            ii(0x18_b0e3, 1); pop(di);                                  /* pop di */
            ii(0x18_b0e4, 2); if(jae(0x18_b0ec, 6)) goto l_0x18_b0ec;   /* jae 0xb0ec */
            ii(0x18_b0e6, 3); call(0x18_a893, -0x856);                  /* call 0xa893 */
            ii(0x18_b0e9, 3); if(jmp_func(0x18_b069, -0x83)) return;    /* jmp 0xb069 */
        l_0x18_b0ec:
            ii(0x18_b0ec, 1); int3();                                   /* int3 */
            ii(0x18_b0ed, 4); cmp(memb[ss, bp + 0x16], 0);              /* cmp byte [bp+0x16], 0x0 */
            ii(0x18_b0f1, 2); if(jz(0x18_b0ff, 0xc)) goto l_0x18_b0ff;  /* jz 0xb0ff */
            ii(0x18_b0f3, 5); mov(memw[ss, bp + 0x16], 1);              /* mov word [bp+0x16], 0x1 */
            ii(0x18_b0f8, 4); or(memb[ss, bp + 0x26], 1);               /* or byte [bp+0x26], 0x1 */
            ii(0x18_b0fc, 3); if(jmp_func(0x18_a838, -0x8c7)) return;   /* jmp 0xa838 */
        l_0x18_b0ff:
            ii(0x18_b0ff, 4); mov(di, memw[ds, 0xa]);                   /* mov di, [0xa] */
            ii(0x18_b103, 1); push(di);                                 /* push di */
            ii(0x18_b104, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x18_b106, 4); mov(cx, memw[ds, 0xe]);                   /* mov cx, [0xe] */
            ii(0x18_b10a, 2); shr(cx, 1);                               /* shr cx, 1 */
            ii(0x18_b10c, 2); rep(() => stosw());                       /* rep stosw */
            ii(0x18_b10e, 3); call(0x18_a8f3, -0x81e);                  /* call 0xa8f3 */
            ii(0x18_b111, 1); pop(di);                                  /* pop di */
            ii(0x18_b112, 4); add(di, 0x80);                            /* add di, 0x80 */
            ii(0x18_b116, 3); mov(memw[ds, bx + 0x10], di);             /* mov [bx+0x10], di */
            ii(0x18_b119, 3); mov(si, memw[ss, bp + 0x10]);             /* mov si, [bp+0x10] */
            ii(0x18_b11c, 3); mov(ds, memw[ss, bp + 6]);                /* mov ds, [bp+0x6] */
            ii(0x18_b11f, 3); mov(cx, 7);                               /* mov cx, 0x7 */
            ii(0x18_b122, 2); rep(() => movsw());                       /* rep movsw */
            ii(0x18_b124, 5); mov(bx, memw[es, 0xa]);                   /* mov bx, [es:0xa] */
            ii(0x18_b129, 4); lea(di, memw[ds, bx + 0x90]);             /* lea di, [bx+0x90] */
            ii(0x18_b12d, 5); lds(si, memw[es, bx + 0x86]);             /* lds si, [es:bx+0x86] */
            ii(0x18_b132, 2); mov(cx, ds);                              /* mov cx, ds */
            ii(0x18_b134, 1); inc(cx);                                  /* inc cx */
            ii(0x18_b135, 2); if(loop(0x18_b13b, 4)) goto l_0x18_b13b;  /* loop 0xb13b */
            ii(0x18_b137, 1); push(es);                                 /* push es */
            ii(0x18_b138, 1); pop(ds);                                  /* pop ds */
            ii(0x18_b139, 2); mov(si, di);                              /* mov si, di */
        l_0x18_b13b:
            ii(0x18_b13b, 3); mov(cx, 8);                               /* mov cx, 0x8 */
            ii(0x18_b13e, 2); rep(() => movsw());                       /* rep movsw */
            ii(0x18_b140, 5); lds(si, memw[es, bx + 0x8a]);             /* lds si, [es:bx+0x8a] */
            ii(0x18_b145, 2); mov(cx, ds);                              /* mov cx, ds */
            ii(0x18_b147, 1); inc(cx);                                  /* inc cx */
            ii(0x18_b148, 2); if(loop(0x18_b14e, 4)) goto l_0x18_b14e;  /* loop 0xb14e */
            ii(0x18_b14a, 1); push(es);                                 /* push es */
            ii(0x18_b14b, 1); pop(ds);                                  /* pop ds */
            ii(0x18_b14c, 2); mov(si, di);                              /* mov si, di */
        l_0x18_b14e:
            ii(0x18_b14e, 3); mov(cx, 8);                               /* mov cx, 0x8 */
            ii(0x18_b151, 2); rep(() => movsw());                       /* rep movsw */
            ii(0x18_b153, 1); push(di);                                 /* push di */
            ii(0x18_b154, 5); lds(si, memw[es, bx + 0x82]);             /* lds si, [es:bx+0x82] */
            ii(0x18_b159, 3); mov(dx, 0x80);                            /* mov dx, 0x80 */
            ii(0x18_b15c, 2); mov(cx, ds);                              /* mov cx, ds */
            ii(0x18_b15e, 3); lsl(cx, cx);                              /* lsl cx, cx */
            ii(0x18_b161, 2); sub(cx, si);                              /* sub cx, si */
            ii(0x18_b163, 2); cmp(cx, dx);                              /* cmp cx, dx */
            ii(0x18_b165, 2); if(jb(0x18_b169, 2)) goto l_0x18_b169;    /* jb 0xb169 */
            ii(0x18_b167, 2); mov(cx, dx);                              /* mov cx, dx */
        l_0x18_b169:
            ii(0x18_b169, 2); rep(() => movsb());                       /* rep movsb */
            ii(0x18_b16b, 1); pop(di);                                  /* pop di */
            ii(0x18_b16c, 4); add(di, 0x80);                            /* add di, 0x80 */
            ii(0x18_b170, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x18_b172, 5); xchg(memw[es, bx + 0x80], ax);            /* xchg [es:bx+0x80], ax */
            ii(0x18_b177, 3); cmp(ax, 0x30);                            /* cmp ax, 0x30 */
            ii(0x18_b17a, 2); if(jbe(0x18_b1a8, 0x2c)) goto l_0x18_b1a8; /* jbe 0xb1a8 */
            ii(0x18_b17c, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x18_b17e, 2); xor(si, si);                              /* xor si, si */
            ii(0x18_b180, 3); lsl(cx, ax);                              /* lsl cx, ax */
            ii(0x18_b183, 5); mov(dx, memw[es, 0xe]);                   /* mov dx, [es:0xe] */
            ii(0x18_b188, 4); sub(dx, 0x130);                           /* sub dx, 0x130 */
            ii(0x18_b18c, 2); cmp(cx, dx);                              /* cmp cx, dx */
            ii(0x18_b18e, 2); if(jb(0x18_b192, 2)) goto l_0x18_b192;    /* jb 0xb192 */
            ii(0x18_b190, 2); mov(cx, dx);                              /* mov cx, dx */
        l_0x18_b192:
            ii(0x18_b192, 2); shr(cx, 1);                               /* shr cx, 1 */
            ii(0x18_b194, 2); rep(() => movsw());                       /* rep movsw */
            ii(0x18_b196, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x18_b198, 3); shr(ax, 4);                               /* shr ax, 0x4 */
            ii(0x18_b19b, 5); add(ax, memw[es, 0x9b4]);                 /* add ax, [es:0x9b4] */
            ii(0x18_b1a0, 3); add(ax, 0x13);                            /* add ax, 0x13 */
            ii(0x18_b1a3, 5); mov(memw[es, bx + 0x80], ax);             /* mov [es:bx+0x80], ax */
        l_0x18_b1a8:
            ii(0x18_b1a8, 1); push(es);                                 /* push es */
            ii(0x18_b1a9, 1); pop(ds);                                  /* pop ds */
            ii(0x18_b1aa, 4); mov(dx, memw[ds, 0x9b4]);                 /* mov dx, [0x9b4] */
            ii(0x18_b1ae, 4); lea(di, memw[ds, bx + 0x82]);             /* lea di, [bx+0x82] */
            ii(0x18_b1b2, 4); lea(ax, memw[ds, bx + 0xb0]);             /* lea ax, [bx+0xb0] */
            ii(0x18_b1b6, 1); stosw();                                  /* stosw */
            ii(0x18_b1b7, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x18_b1b9, 1); stosw();                                  /* stosw */
            ii(0x18_b1ba, 4); lea(ax, memw[ds, bx + 0x90]);             /* lea ax, [bx+0x90] */
            ii(0x18_b1be, 1); stosw();                                  /* stosw */
            ii(0x18_b1bf, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x18_b1c1, 1); stosw();                                  /* stosw */
            ii(0x18_b1c2, 4); lea(ax, memw[ds, bx + 0xa0]);             /* lea ax, [bx+0xa0] */
            ii(0x18_b1c6, 1); stosw();                                  /* stosw */
            ii(0x18_b1c7, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x18_b1c9, 1); stosw();                                  /* stosw */
            ii(0x18_b1ca, 4); inc(memb[ds, 0x1182]);                    /* inc byte [0x1182] */
            ii(0x18_b1ce, 5); cmp(memb[ds, 0x2e], 0);                   /* cmp byte [0x2e], 0x0 */
            ii(0x18_b1d3, 2); if(jnz(0x18_b22e, 0x59)) goto l_0x18_b22e; /* jnz 0xb22e */
            ii(0x18_b1d5, 1); push(ax);                                 /* push ax */
            ii(0x18_b1d6, 1); push(es);                                 /* push es */
            ii(0x18_b1d7, 2); mov(dl, 0);                               /* mov dl, 0x0 */
            ii(0x18_b1d9, 4); xchg(memb[ds, 0x980], dl);                /* xchg [0x980], dl */
            ii(0x18_b1dd, 3); mov(bx, 0xad);                            /* mov bx, 0xad */
            ii(0x18_b1e0, 2); mov(ah, 0x48);                            /* mov ah, 0x48 */
            ii(0x18_b1e2, 2); @int(0x21);                               /* int 0x21 */
            ii(0x18_b1e4, 2); if(jae(0x18_b1f0, 0xa)) goto l_0x18_b1f0; /* jae 0xb1f0 */
            ii(0x18_b1e6, 4); dec(memb[ds, 0x1182]);                    /* dec byte [0x1182] */
            ii(0x18_b1ea, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x18_b1ed, 3); if(jmp_func(0x18_a838, -0x9b8)) return;   /* jmp 0xa838 */
        l_0x18_b1f0:
            ii(0x18_b1f0, 3); mov(memw[ds, 0x1183], ax);                /* mov [0x1183], ax */
            ii(0x18_b1f3, 4); mov(memb[ds, 0x980], dl);                 /* mov [0x980], dl */
            ii(0x18_b1f7, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x18_b1f9, 2); xor(di, di);                              /* xor di, di */
            ii(0x18_b1fb, 1); push(cs);                                 /* push cs */
            ii(0x18_b1fc, 3); push(0x16e7);                             /* push 0x16e7 */
            ii(0x18_b1ff, 4); push(memw[ds, 0xc26]);                    /* push word [0xc26] */
            ii(0x18_b203, 3); push(0x7591);                             /* push 0x7591 */
            ii(0x18_b206, 1); retf(); return;                           /* retf */
        //  ii(0x18_b207, 39); Недостижимый код.
        l_0x18_b22e:
            ii(0x18_b22e, 4); mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x18_b232, 3); mov(memw[ds, bx + 6], ax);                /* mov [bx+0x6], ax */
            ii(0x18_b235, 3); call(0x18_ad38, -0x500);                  /* call 0xad38 */
            ii(0x18_b238, 3); mov(ax, memw[ds, 0x36]);                  /* mov ax, [0x36] */
            ii(0x18_b23b, 1); push(ax);                                 /* push ax */
            ii(0x18_b23c, 2); xchg(ah, al);                             /* xchg ah, al */
            ii(0x18_b23e, 2); mov(ah, 0x80);                            /* mov ah, 0x80 */
            ii(0x18_b240, 3); mov(memw[ds, 0x35], ax);                  /* mov [0x35], ax */
            ii(0x18_b243, 3); call(0x18_a893, -0x9b3);                  /* call 0xa893 */
            ii(0x18_b246, 1); pop(ax);                                  /* pop ax */
            ii(0x18_b247, 4); mov(ah, memb[ds, 0x35]);                  /* mov ah, [0x35] */
            ii(0x18_b24b, 3); mov(memw[ds, 0x36], ax);                  /* mov [0x36], ax */
            ii(0x18_b24e, 5); cmp(memb[ds, 0x2e], 0);                   /* cmp byte [0x2e], 0x0 */
            ii(0x18_b253, 2); if(jnz(0x18_b27c, 0x27)) goto l_0x18_b27c; /* jnz 0xb27c */
            ii(0x18_b255, 1); push(bx);                                 /* push bx */
            ii(0x18_b256, 4); mov(es, memw[ds, 0x1183]);                /* mov es, [0x1183] */
            ii(0x18_b25a, 3); mov(di, 0x400);                           /* mov di, 0x400 */
            ii(0x18_b25d, 1); push(cs);                                 /* push cs */
            ii(0x18_b25e, 3); push(0x1749);                             /* push 0x1749 */
            ii(0x18_b261, 4); push(memw[ds, 0xc26]);                    /* push word [0xc26] */
            ii(0x18_b265, 3); push(0x7639);                             /* push 0x7639 */
            ii(0x18_b268, 1); retf(); return;                           /* retf */
        //  ii(0x18_b269, 19); Недостижимый код.
        l_0x18_b27c:
            ii(0x18_b27c, 1); push(ds);                                 /* push ds */
            ii(0x18_b27d, 2); mov(ah, 0x1a);                            /* mov ah, 0x1a */
            ii(0x18_b27f, 4); lds(dx, memw[ds, 0x9b0]);                 /* lds dx, [0x9b0] */
            ii(0x18_b283, 1); push(cs);                                 /* push cs */
            ii(0x18_b284, 3); call(0x18_a366, -0xf21);                  /* call 0xa366 */
            ii(0x18_b287, 1); pop(ds);                                  /* pop ds */
            ii(0x18_b288, 4); dec(memb[ds, 0x1182]);                    /* dec byte [0x1182] */
            ii(0x18_b28c, 4); mov(es, memw[ds, 0xc2a]);                 /* mov es, [0xc2a] */
            ii(0x18_b290, 3); mov(ax, memw[ds, 0xc2c]);                 /* mov ax, [0xc2c] */
            ii(0x18_b293, 4); mov(memw[es, 0x2c], ax);                  /* mov [es:0x2c], ax */
            ii(0x18_b297, 3); if(jmp_func(0x18_b03d, -0x25d)) return;   /* jmp 0xb03d */
        }
    }
}
