using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("53e00a62-e518-43dc-b27b-de8cdcd8aa40")]
        public void Method_0014_b0d5()
        {
            ii(0x14_b0d5, 1); pushw(bp);                                /* push bp */
            ii(0x14_b0d6, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x14_b0d8, 3); mov(bp, memw_a16[ss, bp + 0x4]);          /* mov bp, [bp+0x4] */
            ii(0x14_b0db, 4); mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x14_b0df, 1); pushw(di);                                /* push di */
            ii(0x14_b0e0, 3); callw(0x14_ab22, -0x5c1);                 /* call 0xab22 */
            ii(0x14_b0e3, 1); popw(di);                                 /* pop di */
            ii(0x14_b0e4, 2); if(jaew(0x14_b0ec, 0x6)) goto l_0x14_b0ec; /* jae 0xb0ec */
            ii(0x14_b0e6, 3); callw(0x14_a893, -0x856);                 /* call 0xa893 */
            ii(0x14_b0e9, 3); if(jmpw_func(0x14_b069, -0x83)) return;   /* jmp 0xb069 */
        l_0x14_b0ec:
            ii(0x14_b0ec, 1); int3();                                   /* int3 */
            ii(0x14_b0ed, 4); cmp(memb_a16[ss, bp + 0x16], 0);          /* cmp byte [bp+0x16], 0x0 */
            ii(0x14_b0f1, 2); if(jzw(0x14_b0ff, 0xc)) goto l_0x14_b0ff; /* jz 0xb0ff */
            ii(0x14_b0f3, 5); mov(memw_a16[ss, bp + 0x16], 0x1);        /* mov word [bp+0x16], 0x1 */
            ii(0x14_b0f8, 4); or(memb_a16[ss, bp + 0x26], 0x1);         /* or byte [bp+0x26], 0x1 */
            ii(0x14_b0fc, 3); if(jmpw_func(0x14_a838, -0x8c7)) return;  /* jmp 0xa838 */
        l_0x14_b0ff:
            ii(0x14_b0ff, 4); mov(di, memw_a16[ds, 0xa]);               /* mov di, [0xa] */
            ii(0x14_b103, 1); pushw(di);                                /* push di */
            ii(0x14_b104, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x14_b106, 4); mov(cx, memw_a16[ds, 0xe]);               /* mov cx, [0xe] */
            ii(0x14_b10a, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x14_b10c, 2); rep_a16(() => stosw_a16());               /* rep stosw */
            ii(0x14_b10e, 3); callw(0x14_a8f3, -0x81e);                 /* call 0xa8f3 */
            ii(0x14_b111, 1); popw(di);                                 /* pop di */
            ii(0x14_b112, 4); add(di, 0x80);                            /* add di, 0x80 */
            ii(0x14_b116, 3); mov(memw_a16[ds, bx + 0x10], di);         /* mov [bx+0x10], di */
            ii(0x14_b119, 3); mov(si, memw_a16[ss, bp + 0x10]);         /* mov si, [bp+0x10] */
            ii(0x14_b11c, 3); mov(ds, memw_a16[ss, bp + 0x6]);          /* mov ds, [bp+0x6] */
            ii(0x14_b11f, 3); mov(cx, 0x7);                             /* mov cx, 0x7 */
            ii(0x14_b122, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x14_b124, 5); mov(bx, memw_a16[es, 0xa]);               /* mov bx, [es:0xa] */
            ii(0x14_b129, 4); lea(di, bx + 0x90);                       /* lea di, [bx+0x90] */
            ii(0x14_b12d, 5); lds(si, es, bx + 0x86);                   /* lds si, [es:bx+0x86] */
            ii(0x14_b132, 2); mov(cx, ds);                              /* mov cx, ds */
            ii(0x14_b134, 1); inc(cx);                                  /* inc cx */
            ii(0x14_b135, 2); if(loopw_a16(0x14_b13b, 0x4)) goto l_0x14_b13b; /* loop 0xb13b */
            ii(0x14_b137, 1); pushw(es);                                /* push es */
            ii(0x14_b138, 1); popw(ds);                                 /* pop ds */
            ii(0x14_b139, 2); mov(si, di);                              /* mov si, di */
        l_0x14_b13b:
            ii(0x14_b13b, 3); mov(cx, 0x8);                             /* mov cx, 0x8 */
            ii(0x14_b13e, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x14_b140, 5); lds(si, es, bx + 0x8a);                   /* lds si, [es:bx+0x8a] */
            ii(0x14_b145, 2); mov(cx, ds);                              /* mov cx, ds */
            ii(0x14_b147, 1); inc(cx);                                  /* inc cx */
            ii(0x14_b148, 2); if(loopw_a16(0x14_b14e, 0x4)) goto l_0x14_b14e; /* loop 0xb14e */
            ii(0x14_b14a, 1); pushw(es);                                /* push es */
            ii(0x14_b14b, 1); popw(ds);                                 /* pop ds */
            ii(0x14_b14c, 2); mov(si, di);                              /* mov si, di */
        l_0x14_b14e:
            ii(0x14_b14e, 3); mov(cx, 0x8);                             /* mov cx, 0x8 */
            ii(0x14_b151, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x14_b153, 1); pushw(di);                                /* push di */
            ii(0x14_b154, 5); lds(si, es, bx + 0x82);                   /* lds si, [es:bx+0x82] */
            ii(0x14_b159, 3); mov(dx, 0x80);                            /* mov dx, 0x80 */
            ii(0x14_b15c, 2); mov(cx, ds);                              /* mov cx, ds */
            ii(0x14_b15e, 3); lsl(cx, cx);                              /* lsl cx, cx */
            ii(0x14_b161, 2); sub(cx, si);                              /* sub cx, si */
            ii(0x14_b163, 2); cmp(cx, dx);                              /* cmp cx, dx */
            ii(0x14_b165, 2); if(jbw(0x14_b169, 0x2)) goto l_0x14_b169; /* jb 0xb169 */
            ii(0x14_b167, 2); mov(cx, dx);                              /* mov cx, dx */
        l_0x14_b169:
            ii(0x14_b169, 2); rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x14_b16b, 1); popw(di);                                 /* pop di */
            ii(0x14_b16c, 4); add(di, 0x80);                            /* add di, 0x80 */
            ii(0x14_b170, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x14_b172, 5); xchg(memw_a16[es, bx + 0x80], ax);        /* xchg [es:bx+0x80], ax */
            ii(0x14_b177, 3); cmp(ax, 0x30);                            /* cmp ax, 0x30 */
            ii(0x14_b17a, 2); if(jbew(0x14_b1a8, 0x2c)) goto l_0x14_b1a8; /* jbe 0xb1a8 */
            ii(0x14_b17c, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x14_b17e, 2); xor(si, si);                              /* xor si, si */
            ii(0x14_b180, 3); lsl(cx, ax);                              /* lsl cx, ax */
            ii(0x14_b183, 5); mov(dx, memw_a16[es, 0xe]);               /* mov dx, [es:0xe] */
            ii(0x14_b188, 4); sub(dx, 0x130);                           /* sub dx, 0x130 */
            ii(0x14_b18c, 2); cmp(cx, dx);                              /* cmp cx, dx */
            ii(0x14_b18e, 2); if(jbw(0x14_b192, 0x2)) goto l_0x14_b192; /* jb 0xb192 */
            ii(0x14_b190, 2); mov(cx, dx);                              /* mov cx, dx */
        l_0x14_b192:
            ii(0x14_b192, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x14_b194, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x14_b196, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x14_b198, 3); shr(ax, 0x4);                             /* shr ax, 0x4 */
            ii(0x14_b19b, 5); add(ax, memw_a16[es, 0x9b4]);             /* add ax, [es:0x9b4] */
            ii(0x14_b1a0, 3); add(ax, 0x13);                            /* add ax, 0x13 */
            ii(0x14_b1a3, 5); mov(memw_a16[es, bx + 0x80], ax);         /* mov [es:bx+0x80], ax */
        l_0x14_b1a8:
            ii(0x14_b1a8, 1); pushw(es);                                /* push es */
            ii(0x14_b1a9, 1); popw(ds);                                 /* pop ds */
            ii(0x14_b1aa, 4); mov(dx, memw_a16[ds, 0x9b4]);             /* mov dx, [0x9b4] */
            ii(0x14_b1ae, 4); lea(di, bx + 0x82);                       /* lea di, [bx+0x82] */
            ii(0x14_b1b2, 4); lea(ax, bx + 0xb0);                       /* lea ax, [bx+0xb0] */
            ii(0x14_b1b6, 1); stosw_a16();                              /* stosw */
            ii(0x14_b1b7, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x14_b1b9, 1); stosw_a16();                              /* stosw */
            ii(0x14_b1ba, 4); lea(ax, bx + 0x90);                       /* lea ax, [bx+0x90] */
            ii(0x14_b1be, 1); stosw_a16();                              /* stosw */
            ii(0x14_b1bf, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x14_b1c1, 1); stosw_a16();                              /* stosw */
            ii(0x14_b1c2, 4); lea(ax, bx + 0xa0);                       /* lea ax, [bx+0xa0] */
            ii(0x14_b1c6, 1); stosw_a16();                              /* stosw */
            ii(0x14_b1c7, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x14_b1c9, 1); stosw_a16();                              /* stosw */
            ii(0x14_b1ca, 4); inc(memb_a16[ds, 0x1182]);                /* inc byte [0x1182] */
            ii(0x14_b1ce, 5); cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
            ii(0x14_b1d3, 2); if(jnzw(0x14_b22e, 0x59)) goto l_0x14_b22e; /* jnz 0xb22e */
            ii(0x14_b1d5, 1); pushw(ax);                                /* push ax */
            ii(0x14_b1d6, 1); pushw(es);                                /* push es */
            ii(0x14_b1d7, 2); mov(dl, 0);                               /* mov dl, 0x0 */
            ii(0x14_b1d9, 4); xchg(memb_a16[ds, 0x980], dl);            /* xchg [0x980], dl */
            ii(0x14_b1dd, 3); mov(bx, 0xad);                            /* mov bx, 0xad */
            ii(0x14_b1e0, 2); mov(ah, 0x48);                            /* mov ah, 0x48 */
            ii(0x14_b1e2, 2); @int(0x21);                               /* int 0x21 */
            ii(0x14_b1e4, 2); if(jaew(0x14_b1f0, 0xa)) goto l_0x14_b1f0; /* jae 0xb1f0 */
            ii(0x14_b1e6, 4); dec(memb_a16[ds, 0x1182]);                /* dec byte [0x1182] */
            ii(0x14_b1ea, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x14_b1ed, 3); if(jmpw_func(0x14_a838, -0x9b8)) return;  /* jmp 0xa838 */
        l_0x14_b1f0:
            ii(0x14_b1f0, 3); mov(memw_a16[ds, 0x1183], ax);            /* mov [0x1183], ax */
            ii(0x14_b1f3, 4); mov(memb_a16[ds, 0x980], dl);             /* mov [0x980], dl */
            ii(0x14_b1f7, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x14_b1f9, 2); xor(di, di);                              /* xor di, di */
            ii(0x14_b1fb, 1); pushw(cs);                                /* push cs */
            ii(0x14_b1fc, 3); pushw(0x16e7);                            /* push 0x16e7 */
            ii(0x14_b1ff, 4); pushw(memw_a16[ds, 0xc26]);               /* push word [0xc26] */
            ii(0x14_b203, 3); pushw(0x7591);                            /* push 0x7591 */
            ii(0x14_b206, 1); retfw(); return;                          /* retf */
        //    ii(0x14_b207, 3); mov(di, 0x400);                           /* mov di, 0x400 */
        //    ii(0x14_b20a, 1); pushw(cs);                                /* push cs */
        //    ii(0x14_b20b, 3); pushw(0x16f6);                            /* push 0x16f6 */
        //    ii(0x14_b20e, 4); pushw(memw_a16[ds, 0xc26]);               /* push word [0xc26] */
        //    ii(0x14_b212, 3); pushw(0x7606);                            /* push 0x7606 */
        //    ii(0x14_b215, 1); retfw(); return;                          /* retf */
        //    ii(0x14_b216, 1); popw(es);                                 /* pop es */
        //    ii(0x14_b217, 1); pushw(ds);                                /* push ds */
        //    ii(0x14_b218, 4); mov(ds, memw_a16[ds, 0xc32]);             /* mov ds, [0xc32] */
        //    ii(0x14_b21c, 5); mov(edx, memd_a16[ds, 0x6d66]);           /* mov edx, [0x6d66] */
        //    ii(0x14_b221, 4); mov(cx, memw_a16[ds, 0x6d6a]);            /* mov cx, [0x6d6a] */
        //    ii(0x14_b225, 2); mov(bl, 0x21);                            /* mov bl, 0x21 */
        //    ii(0x14_b227, 3); mov(ax, 0x205);                           /* mov ax, 0x205 */
        //    ii(0x14_b22a, 2); @int(0x31);                               /* int 0x31 */
        //    ii(0x14_b22c, 1); popw(ds);                                 /* pop ds */
        //    ii(0x14_b22d, 1); popw(ax);                                 /* pop ax */
        l_0x14_b22e:
            ii(0x14_b22e, 4); mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x14_b232, 3); mov(memw_a16[ds, bx + 0x6], ax);          /* mov [bx+0x6], ax */
            ii(0x14_b235, 3); callw(0x14_ad38, -0x500);                 /* call 0xad38 */
            ii(0x14_b238, 3); mov(ax, memw_a16[ds, 0x36]);              /* mov ax, [0x36] */
            ii(0x14_b23b, 1); pushw(ax);                                /* push ax */
            ii(0x14_b23c, 2); xchg(ah, al);                             /* xchg ah, al */
            ii(0x14_b23e, 2); mov(ah, 0x80);                            /* mov ah, 0x80 */
            ii(0x14_b240, 3); mov(memw_a16[ds, 0x35], ax);              /* mov [0x35], ax */
            ii(0x14_b243, 3); callw(0x14_a893, -0x9b3);                 /* call 0xa893 */
            ii(0x14_b246, 1); popw(ax);                                 /* pop ax */
            ii(0x14_b247, 4); mov(ah, memb_a16[ds, 0x35]);              /* mov ah, [0x35] */
            ii(0x14_b24b, 3); mov(memw_a16[ds, 0x36], ax);              /* mov [0x36], ax */
            ii(0x14_b24e, 5); cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
            ii(0x14_b253, 2); if(jnzw(0x14_b27c, 0x27)) goto l_0x14_b27c; /* jnz 0xb27c */
            ii(0x14_b255, 1); pushw(bx);                                /* push bx */
            ii(0x14_b256, 4); mov(es, memw_a16[ds, 0x1183]);            /* mov es, [0x1183] */
            ii(0x14_b25a, 3); mov(di, 0x400);                           /* mov di, 0x400 */
            ii(0x14_b25d, 1); pushw(cs);                                /* push cs */
            ii(0x14_b25e, 3); pushw(0x1749);                            /* push 0x1749 */
            ii(0x14_b261, 4); pushw(memw_a16[ds, 0xc26]);               /* push word [0xc26] */
            ii(0x14_b265, 3); pushw(0x7639);                            /* push 0x7639 */
            ii(0x14_b268, 1); retfw(); return;                          /* retf */
        //    ii(0x14_b269, 2); xor(di, di);                              /* xor di, di */
        //    ii(0x14_b26b, 1); pushw(cs);                                /* push cs */
        //    ii(0x14_b26c, 3); pushw(0x1757);                            /* push 0x1757 */
        //    ii(0x14_b26f, 4); pushw(memw_a16[ds, 0xc26]);               /* push word [0xc26] */
        //    ii(0x14_b273, 3); pushw(0x75c6);                            /* push 0x75c6 */
        //    ii(0x14_b276, 1); retfw(); return;                          /* retf */
        //    ii(0x14_b277, 2); mov(ah, 0x49);                            /* mov ah, 0x49 */
        //    ii(0x14_b279, 2); @int(0x21);                               /* int 0x21 */
        //    ii(0x14_b27b, 1); popw(bx);                                 /* pop bx */
        l_0x14_b27c:
            ii(0x14_b27c, 1); pushw(ds);                                /* push ds */
            ii(0x14_b27d, 2); mov(ah, 0x1a);                            /* mov ah, 0x1a */
            ii(0x14_b27f, 4); lds(dx, ds, 0x9b0);                       /* lds dx, [0x9b0] */
            ii(0x14_b283, 1); pushw(cs);                                /* push cs */
            ii(0x14_b284, 3); callw(0x14_a366, -0xf21);                 /* call 0xa366 */
            ii(0x14_b287, 1); popw(ds);                                 /* pop ds */
            ii(0x14_b288, 4); dec(memb_a16[ds, 0x1182]);                /* dec byte [0x1182] */
            ii(0x14_b28c, 4); mov(es, memw_a16[ds, 0xc2a]);             /* mov es, [0xc2a] */
            ii(0x14_b290, 3); mov(ax, memw_a16[ds, 0xc2c]);             /* mov ax, [0xc2c] */
            ii(0x14_b293, 4); mov(memw_a16[es, 0x2c], ax);              /* mov [es:0x2c], ax */
            ii(0x14_b297, 3); if(jmpw_func(0x14_b03d, -0x25d)) return;  /* jmp 0xb03d */
        }
    }
}
