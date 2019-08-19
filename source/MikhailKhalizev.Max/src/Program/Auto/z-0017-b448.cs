using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_b448-c6d0ee66")]
        public void Method_0017_b448()
        {
            ii(0x17_b448, 4); enterw(0x2a, 0);                          /* enter 0x2a, 0x0 */
            ii(0x17_b44c, 1); pushw(di);                                /* push di */
            ii(0x17_b44d, 1); pushw(si);                                /* push si */
            ii(0x17_b44e, 1); pushw(ds);                                /* push ds */
            ii(0x17_b44f, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_b452, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_b454, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_b456, 3); mov(memw_a16[ss, bp - 0x24], ax);         /* mov [bp-0x24], ax */
            ii(0x17_b459, 3); mov(memw_a16[ss, bp - 0x26], ax);         /* mov [bp-0x26], ax */
            ii(0x17_b45c, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x17_b45f, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x17_b462, 3); mov(memw_a16[ss, bp - 0x22], ax);         /* mov [bp-0x22], ax */
            ii(0x17_b465, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_b468, 4); mov(ax, memw_a16[es, bx + 0x8]);          /* mov ax, [es:bx+0x8] */
            ii(0x17_b46c, 4); mov(cx, memw_a16[es, bx + 0x4]);          /* mov cx, [es:bx+0x4] */
            ii(0x17_b470, 2); mov(dx, ax);                              /* mov dx, ax */
            ii(0x17_b472, 3); mov(memw_a16[ss, bp - 0xe], cx);          /* mov [bp-0xe], cx */
            ii(0x17_b475, 3); mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
            ii(0x17_b478, 4); and(cx, 0xf000);                          /* and cx, 0xf000 */
            ii(0x17_b47c, 4); cmp(dx, 0xfff);                           /* cmp dx, 0xfff */
            ii(0x17_b480, 2); if(jbw(0x17_b49e, 0x1c)) goto l_0x17_b49e; /* jb 0xb49e */
            ii(0x17_b482, 2); if(jaw(0x17_b48a, 0x6)) goto l_0x17_b48a; /* ja 0xb48a */
            ii(0x17_b484, 4); cmp(cx, 0xf000);                          /* cmp cx, 0xf000 */
            ii(0x17_b488, 2); if(jbew(0x17_b49e, 0x14)) goto l_0x17_b49e; /* jbe 0xb49e */
        l_0x17_b48a:
            ii(0x17_b48a, 6); mov(memw_a16[es, bx + 0x20], 0x8003);     /* mov word [es:bx+0x20], 0x8003 */
            ii(0x17_b490, 6); mov(memw_a16[es, bx + 0x22], 0);          /* mov word [es:bx+0x22], 0x0 */
            ii(0x17_b496, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_b49b, 3); jmpw(0x17_b92e, 0x490); goto l_0x17_b92e; /* jmp 0xb92e */
        l_0x17_b49e:
            ii(0x17_b49e, 3); mov(ax, memw_a16[ss, bp - 0xe]);          /* mov ax, [bp-0xe] */
            ii(0x17_b4a1, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_b4a3, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_b4a5, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_b4a7, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_b4a9, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b4ab, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b4ad, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b4af, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b4b1, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b4b3, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b4b5, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b4b7, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b4b9, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x17_b4bc, 6); test(memw_a16[es, bx + 0x4], 0xfff);      /* test word [es:bx+0x4], 0xfff */
            ii(0x17_b4c2, 2); if(jzw(0x17_b4c8, 0x4)) goto l_0x17_b4c8; /* jz 0xb4c8 */
            ii(0x17_b4c4, 1); inc(ax);                                  /* inc ax */
            ii(0x17_b4c5, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
        l_0x17_b4c8:
            ii(0x17_b4c8, 4); mov(ax, memw_a16[es, bx + 0x14]);         /* mov ax, [es:bx+0x14] */
            ii(0x17_b4cc, 4); mov(cx, memw_a16[es, bx + 0x1c]);         /* mov cx, [es:bx+0x1c] */
            ii(0x17_b4d0, 3); mov(memw_a16[ss, bp - 0x20], cx);         /* mov [bp-0x20], cx */
            ii(0x17_b4d3, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x17_b4d6, 4); les(si, ds, 0x992);                       /* les si, [0x992] */
            ii(0x17_b4da, 6); test(memb_a16[es, si + 0xf00], 0x1);      /* test byte [es:si+0xf00], 0x1 */
            ii(0x17_b4e0, 2); if(jzw(0x17_b4e5, 0x3)) goto l_0x17_b4e5; /* jz 0xb4e5 */
            ii(0x17_b4e2, 3); jmpw(0x17_b60c, 0x127); goto l_0x17_b60c; /* jmp 0xb60c */
        l_0x17_b4e5:
            ii(0x17_b4e5, 1); nop();                                    /* nop */
            ii(0x17_b4e6, 1); pushw(cs);                                /* push cs */
            ii(0x17_b4e7, 3); callw(0x17_7a54, -0x3a96);                /* call 0x7a54 */
            ii(0x17_b4ea, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x17_b4ed, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_b4f0, 2); if(jnzw(0x17_b510, 0x1e)) goto l_0x17_b510; /* jnz 0xb510 */
            ii(0x17_b4f2, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_b4f4, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_b4f7, 4); mov(memw_a16[es, bx + 0x14], ax);         /* mov [es:bx+0x14], ax */
            ii(0x17_b4fb, 4); mov(memw_a16[es, bx + 0x16], dx);         /* mov [es:bx+0x16], dx */
            ii(0x17_b4ff, 4); mov(memw_a16[es, bx + 0x1c], ax);         /* mov [es:bx+0x1c], ax */
            ii(0x17_b503, 4); mov(memw_a16[es, bx + 0x1e], dx);         /* mov [es:bx+0x1e], dx */
            ii(0x17_b507, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_b50c, 3); jmpw(0x17_b92e, 0x41f); goto l_0x17_b92e; /* jmp 0xb92e */
        //  ii(0x17_b50f, 1); nop();                                    /* nop */
        l_0x17_b510:
            ii(0x17_b510, 4); les(bx, ds, 0x4f9c);                      /* les bx, [0x4f9c] */
            ii(0x17_b514, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_b516, 4); or(memb_a16[es, bx + si], -0x80 /* 0x80 */); /* or byte [es:bx+si], 0x80 */
            ii(0x17_b51a, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_b51c, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x17_b51f, 4); les(si, ds, 0x4fa4);                      /* les si, [0x4fa4] */
            ii(0x17_b523, 5); mov(memw_a16[es, bx + si], 0);            /* mov word [es:bx+si], 0x0 */
            ii(0x17_b528, 6); mov(memw_a16[es, bx + si + 0x2], 0xf);    /* mov word [es:bx+si+0x2], 0xf */
            ii(0x17_b52e, 4); les(si, ds, 0x4fa0);                      /* les si, [0x4fa0] */
            ii(0x17_b532, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
            ii(0x17_b535, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
            ii(0x17_b539, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_b53b, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_b53d, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_b53f, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_b541, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_b543, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_b545, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_b547, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_b549, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_b54b, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_b54d, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_b54f, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_b551, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x17_b553, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x17_b555, 4); les(si, ds, 0x992);                       /* les si, [0x992] */
            ii(0x17_b559, 5); xor(ax, memw_a16[es, si + 0xf00]);        /* xor ax, [es:si+0xf00] */
            ii(0x17_b55e, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x17_b561, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_b563, 2); xor(cx, ax);                              /* xor cx, ax */
            ii(0x17_b565, 2); xor(bx, dx);                              /* xor bx, dx */
            ii(0x17_b567, 5); mov(memw_a16[es, si + 0xf00], cx);        /* mov [es:si+0xf00], cx */
            ii(0x17_b56c, 5); mov(memw_a16[es, si + 0xf02], bx);        /* mov [es:si+0xf02], bx */
            ii(0x17_b571, 4); les(bx, ds, 0x992);                       /* les bx, [0x992] */
            ii(0x17_b575, 6); or(memb_a16[es, bx + 0xf00], 0x1);        /* or byte [es:bx+0xf00], 0x1 */
            ii(0x17_b57b, 4); les(bx, ds, 0x992);                       /* les bx, [0x992] */
            ii(0x17_b57f, 6); or(memb_a16[es, bx + 0xf00], 0x4);        /* or byte [es:bx+0xf00], 0x4 */
            ii(0x17_b585, 4); les(bx, ds, 0x992);                       /* les bx, [0x992] */
            ii(0x17_b589, 6); or(memb_a16[es, bx + 0xf00], 0x2);        /* or byte [es:bx+0xf00], 0x2 */
            ii(0x17_b58f, 4); les(bx, ds, 0x992);                       /* les bx, [0x992] */
            ii(0x17_b593, 5); mov(ax, memw_a16[es, bx + 0xf00]);        /* mov ax, [es:bx+0xf00] */
            ii(0x17_b598, 2); mov(cx, es);                              /* mov cx, es */
            ii(0x17_b59a, 4); les(si, ds, 0x4fec);                      /* les si, [0x4fec] */
            ii(0x17_b59e, 3); xor(ax, memw_a16[es, si]);                /* xor ax, [es:si] */
            ii(0x17_b5a1, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x17_b5a4, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x17_b5a6, 5); xor(ax, memw_a16[es, bx + 0xf00]);        /* xor ax, [es:bx+0xf00] */
            ii(0x17_b5ab, 5); xor(dx, memw_a16[es, bx + 0xf02]);        /* xor dx, [es:bx+0xf02] */
            ii(0x17_b5b0, 4); les(bx, ds, 0x4fec);                      /* les bx, [0x4fec] */
            ii(0x17_b5b4, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x17_b5b7, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
            ii(0x17_b5bb, 4); les(bx, ds, 0x4fec);                      /* les bx, [0x4fec] */
            ii(0x17_b5bf, 4); or(memb_a16[es, bx], 0x1);                /* or byte [es:bx], 0x1 */
            ii(0x17_b5c3, 4); les(bx, ds, 0x4fec);                      /* les bx, [0x4fec] */
            ii(0x17_b5c7, 4); or(memb_a16[es, bx], 0x4);                /* or byte [es:bx], 0x4 */
            ii(0x17_b5cb, 4); les(bx, ds, 0x4fec);                      /* les bx, [0x4fec] */
            ii(0x17_b5cf, 4); or(memb_a16[es, bx], 0x2);                /* or byte [es:bx], 0x2 */
            ii(0x17_b5d3, 1); nop();                                    /* nop */
            ii(0x17_b5d4, 1); pushw(cs);                                /* push cs */
            ii(0x17_b5d5, 3); callw(0x17_8e97, -0x2741);                /* call 0x8e97 */
            ii(0x17_b5d8, 3); pushw(0x1000);                            /* push 0x1000 */
            ii(0x17_b5db, 3); pushw(0x1000);                            /* push 0x1000 */
            ii(0x17_b5de, 3); pushw(0xff00);                            /* push 0xff00 */
            ii(0x17_b5e1, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_b5e3, 1); nop();                                    /* nop */
            ii(0x17_b5e4, 1); pushw(cs);                                /* push cs */
            ii(0x17_b5e5, 3); callw(0x17_e96a, 0x3382);                 /* call 0xe96a */
            ii(0x17_b5e8, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_b5eb, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x17_b5ee, 3); mov(memw_a16[ss, bp - 0x18], dx);         /* mov [bp-0x18], dx */
            ii(0x17_b5f1, 1); pushw(dx);                                /* push dx */
            ii(0x17_b5f2, 1); pushw(ax);                                /* push ax */
            ii(0x17_b5f3, 1); nop();                                    /* nop */
            ii(0x17_b5f4, 1); pushw(cs);                                /* push cs */
            ii(0x17_b5f5, 3); callw(0x17_8ed0, -0x2728);                /* call 0x8ed0 */
            ii(0x17_b5f8, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_b5fb, 3); pushw(memw_a16[ss, bp - 0x18]);           /* push word [bp-0x18] */
            ii(0x17_b5fe, 3); pushw(memw_a16[ss, bp - 0x1a]);           /* push word [bp-0x1a] */
            ii(0x17_b601, 1); nop();                                    /* nop */
            ii(0x17_b602, 1); pushw(cs);                                /* push cs */
            ii(0x17_b603, 3); callw(0x17_e758, 0x3152);                 /* call 0xe758 */
            ii(0x17_b606, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_b609, 2); jmpw(0x17_b655, 0x4a); goto l_0x17_b655;  /* jmp 0xb655 */
        //  ii(0x17_b60b, 1); nop();                                    /* nop */
        l_0x17_b60c:
            ii(0x17_b60c, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x17_b60e, 5); mov(ax, memw_a16[es, bx + 0xf00]);        /* mov ax, [es:bx+0xf00] */
            ii(0x17_b613, 2); mov(cx, es);                              /* mov cx, es */
            ii(0x17_b615, 4); les(si, ds, 0x4fec);                      /* les si, [0x4fec] */
            ii(0x17_b619, 3); xor(ax, memw_a16[es, si]);                /* xor ax, [es:si] */
            ii(0x17_b61c, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x17_b61f, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_b621, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x17_b623, 5); xor(ax, memw_a16[es, bx + 0xf00]);        /* xor ax, [es:bx+0xf00] */
            ii(0x17_b628, 5); xor(dx, memw_a16[es, bx + 0xf02]);        /* xor dx, [es:bx+0xf02] */
            ii(0x17_b62d, 4); les(bx, ds, 0x4fec);                      /* les bx, [0x4fec] */
            ii(0x17_b631, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x17_b634, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
            ii(0x17_b638, 4); les(bx, ds, 0x4fec);                      /* les bx, [0x4fec] */
            ii(0x17_b63c, 4); or(memb_a16[es, bx], 0x1);                /* or byte [es:bx], 0x1 */
            ii(0x17_b640, 4); les(bx, ds, 0x4fec);                      /* les bx, [0x4fec] */
            ii(0x17_b644, 4); or(memb_a16[es, bx], 0x4);                /* or byte [es:bx], 0x4 */
            ii(0x17_b648, 4); les(bx, ds, 0x4fec);                      /* les bx, [0x4fec] */
            ii(0x17_b64c, 4); or(memb_a16[es, bx], 0x2);                /* or byte [es:bx], 0x2 */
            ii(0x17_b650, 1); nop();                                    /* nop */
            ii(0x17_b651, 1); pushw(cs);                                /* push cs */
            ii(0x17_b652, 3); callw(0x17_8e97, -0x27be);                /* call 0x8e97 */
        l_0x17_b655:
            ii(0x17_b655, 3); pushw(0x1000);                            /* push 0x1000 */
            ii(0x17_b658, 3); pushw(0xff00);                            /* push 0xff00 */
            ii(0x17_b65b, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_b65d, 1); nop();                                    /* nop */
            ii(0x17_b65e, 1); pushw(cs);                                /* push cs */
            ii(0x17_b65f, 3); callw(0x17_e96a, 0x3308);                 /* call 0xe96a */
            ii(0x17_b662, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_b665, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_b668, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
        l_0x17_b66b:
            ii(0x17_b66b, 4); cmp(memw_a16[ss, bp - 0x22], 0);          /* cmp word [bp-0x22], 0x0 */
            ii(0x17_b66f, 2); if(jzw(0x17_b674, 0x3)) goto l_0x17_b674; /* jz 0xb674 */
            ii(0x17_b671, 3); jmpw(0x17_b74a, 0xd6); goto l_0x17_b74a;  /* jmp 0xb74a */
        l_0x17_b674:
            ii(0x17_b674, 3); mov(bx, memw_a16[ss, bp - 0x26]);         /* mov bx, [bp-0x26] */
            ii(0x17_b677, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x17_b67a, 3); les(si, ss, bp - 0x4);                    /* les si, [bp-0x4] */
            ii(0x17_b67d, 4); test(memb_a16[es, bx + si], 0x1);         /* test byte [es:bx+si], 0x1 */
            ii(0x17_b681, 2); if(jzw(0x17_b6c4, 0x41)) goto l_0x17_b6c4; /* jz 0xb6c4 */
            ii(0x17_b683, 3); mov(ax, memw_a16[ss, bp - 0x26]);         /* mov ax, [bp-0x26] */
            ii(0x17_b686, 3); mov(dx, memw_a16[ss, bp - 0x24]);         /* mov dx, [bp-0x24] */
            ii(0x17_b689, 3); mov(memw_a16[ss, bp - 0x2a], ax);         /* mov [bp-0x2a], ax */
            ii(0x17_b68c, 3); mov(memw_a16[ss, bp - 0x28], dx);         /* mov [bp-0x28], dx */
            ii(0x17_b68f, 4); add(memw_a16[ss, bp - 0x26], 0x1);        /* add word [bp-0x26], 0x1 */
            ii(0x17_b693, 4); adc(memw_a16[ss, bp - 0x24], 0);          /* adc word [bp-0x24], 0x0 */
            ii(0x17_b697, 2); or(dx, dx);                               /* or dx, dx */
            ii(0x17_b699, 2); if(jnzw(0x17_b6a0, 0x5)) goto l_0x17_b6a0; /* jnz 0xb6a0 */
            ii(0x17_b69b, 3); cmp(ax, 0x400);                           /* cmp ax, 0x400 */
            ii(0x17_b69e, 2); if(jbw(0x17_b6c2, 0x22)) goto l_0x17_b6c2; /* jb 0xb6c2 */
        l_0x17_b6a0:
            ii(0x17_b6a0, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x17_b6a3, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_b6a5, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_b6a8, 4); mov(memw_a16[es, bx + 0x14], ax);         /* mov [es:bx+0x14], ax */
            ii(0x17_b6ac, 4); mov(memw_a16[es, bx + 0x16], dx);         /* mov [es:bx+0x16], dx */
            ii(0x17_b6b0, 4); mov(memw_a16[es, bx + 0x1c], ax);         /* mov [es:bx+0x1c], ax */
            ii(0x17_b6b4, 4); mov(memw_a16[es, bx + 0x1e], dx);         /* mov [es:bx+0x1e], dx */
            ii(0x17_b6b8, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_b6bd, 1); popw(ds);                                 /* pop ds */
            ii(0x17_b6be, 1); popw(si);                                 /* pop si */
            ii(0x17_b6bf, 1); popw(di);                                 /* pop di */
            ii(0x17_b6c0, 1); leavew();                                 /* leave */
            ii(0x17_b6c1, 1); retfw(); return;                          /* retf */
        l_0x17_b6c2:
            ii(0x17_b6c2, 2); jmpw(0x17_b674, -0x50); goto l_0x17_b674; /* jmp 0xb674 */
        l_0x17_b6c4:
            ii(0x17_b6c4, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_b6c6, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x17_b6c9, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x17_b6cc, 2); jmpw(0x17_b6d6, 0x8); goto l_0x17_b6d6;   /* jmp 0xb6d6 */
        l_0x17_b6ce:
            ii(0x17_b6ce, 4); add(memw_a16[ss, bp - 0x16], 0x1);        /* add word [bp-0x16], 0x1 */
            ii(0x17_b6d2, 4); adc(memw_a16[ss, bp - 0x14], 0);          /* adc word [bp-0x14], 0x0 */
        l_0x17_b6d6:
            ii(0x17_b6d6, 3); mov(ax, memw_a16[ss, bp - 0x1c]);         /* mov ax, [bp-0x1c] */
            ii(0x17_b6d9, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_b6db, 3); cmp(dx, memw_a16[ss, bp - 0x14]);         /* cmp dx, [bp-0x14] */
            ii(0x17_b6de, 2); if(jbw(0x17_b734, 0x54)) goto l_0x17_b734; /* jb 0xb734 */
            ii(0x17_b6e0, 2); if(jaw(0x17_b6e7, 0x5)) goto l_0x17_b6e7; /* ja 0xb6e7 */
            ii(0x17_b6e2, 3); cmp(ax, memw_a16[ss, bp - 0x16]);         /* cmp ax, [bp-0x16] */
            ii(0x17_b6e5, 2); if(jbew(0x17_b734, 0x4d)) goto l_0x17_b734; /* jbe 0xb734 */
        l_0x17_b6e7:
            ii(0x17_b6e7, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x17_b6ea, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x17_b6ed, 3); add(ax, memw_a16[ss, bp - 0x26]);         /* add ax, [bp-0x26] */
            ii(0x17_b6f0, 3); adc(dx, memw_a16[ss, bp - 0x24]);         /* adc dx, [bp-0x24] */
            ii(0x17_b6f3, 2); or(dx, dx);                               /* or dx, dx */
            ii(0x17_b6f5, 2); if(jnzw(0x17_b6fc, 0x5)) goto l_0x17_b6fc; /* jnz 0xb6fc */
            ii(0x17_b6f7, 3); cmp(ax, 0x400);                           /* cmp ax, 0x400 */
            ii(0x17_b6fa, 2); if(jbw(0x17_b71e, 0x22)) goto l_0x17_b71e; /* jb 0xb71e */
        l_0x17_b6fc:
            ii(0x17_b6fc, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x17_b6ff, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_b701, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_b704, 4); mov(memw_a16[es, bx + 0x14], ax);         /* mov [es:bx+0x14], ax */
            ii(0x17_b708, 4); mov(memw_a16[es, bx + 0x16], dx);         /* mov [es:bx+0x16], dx */
            ii(0x17_b70c, 4); mov(memw_a16[es, bx + 0x1c], ax);         /* mov [es:bx+0x1c], ax */
            ii(0x17_b710, 4); mov(memw_a16[es, bx + 0x1e], dx);         /* mov [es:bx+0x1e], dx */
            ii(0x17_b714, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_b719, 1); popw(ds);                                 /* pop ds */
            ii(0x17_b71a, 1); popw(si);                                 /* pop si */
            ii(0x17_b71b, 1); popw(di);                                 /* pop di */
            ii(0x17_b71c, 1); leavew();                                 /* leave */
            ii(0x17_b71d, 1); retfw(); return;                          /* retf */
        l_0x17_b71e:
            ii(0x17_b71e, 3); mov(bx, memw_a16[ss, bp - 0x16]);         /* mov bx, [bp-0x16] */
            ii(0x17_b721, 3); add(bx, memw_a16[ss, bp - 0x26]);         /* add bx, [bp-0x26] */
            ii(0x17_b724, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x17_b727, 3); les(si, ss, bp - 0x4);                    /* les si, [bp-0x4] */
            ii(0x17_b72a, 4); test(memb_a16[es, bx + si], 0x1);         /* test byte [es:bx+si], 0x1 */
            ii(0x17_b72e, 2); if(jzw(0x17_b732, 0x2)) goto l_0x17_b732; /* jz 0xb732 */
            ii(0x17_b730, 2); jmpw(0x17_b734, 0x2); goto l_0x17_b734;   /* jmp 0xb734 */
        l_0x17_b732:
            ii(0x17_b732, 2); jmpw(0x17_b6ce, -0x66); goto l_0x17_b6ce; /* jmp 0xb6ce */
        l_0x17_b734:
            ii(0x17_b734, 3); mov(ax, memw_a16[ss, bp - 0x1c]);         /* mov ax, [bp-0x1c] */
            ii(0x17_b737, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_b739, 3); cmp(ax, memw_a16[ss, bp - 0x16]);         /* cmp ax, [bp-0x16] */
            ii(0x17_b73c, 2); if(jnzw(0x17_b746, 0x8)) goto l_0x17_b746; /* jnz 0xb746 */
            ii(0x17_b73e, 3); cmp(dx, memw_a16[ss, bp - 0x14]);         /* cmp dx, [bp-0x14] */
            ii(0x17_b741, 2); if(jnzw(0x17_b746, 0x3)) goto l_0x17_b746; /* jnz 0xb746 */
            ii(0x17_b743, 3); inc(memw_a16[ss, bp - 0x22]);             /* inc word [bp-0x22] */
        l_0x17_b746:
            ii(0x17_b746, 3); jmpw(0x17_b66b, -0xde); goto l_0x17_b66b; /* jmp 0xb66b */
        //  ii(0x17_b749, 1); nop();                                    /* nop */
        l_0x17_b74a:
            ii(0x17_b74a, 4); cmp(memw_a16[ss, bp - 0x22], 0);          /* cmp word [bp-0x22], 0x0 */
            ii(0x17_b74e, 2); if(jnzw(0x17_b772, 0x22)) goto l_0x17_b772; /* jnz 0xb772 */
            ii(0x17_b750, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x17_b753, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_b755, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_b758, 4); mov(memw_a16[es, bx + 0x14], ax);         /* mov [es:bx+0x14], ax */
            ii(0x17_b75c, 4); mov(memw_a16[es, bx + 0x16], dx);         /* mov [es:bx+0x16], dx */
            ii(0x17_b760, 4); mov(memw_a16[es, bx + 0x1c], ax);         /* mov [es:bx+0x1c], ax */
            ii(0x17_b764, 4); mov(memw_a16[es, bx + 0x1e], dx);         /* mov [es:bx+0x1e], dx */
            ii(0x17_b768, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_b76d, 1); popw(ds);                                 /* pop ds */
            ii(0x17_b76e, 1); popw(si);                                 /* pop si */
            ii(0x17_b76f, 1); popw(di);                                 /* pop di */
            ii(0x17_b770, 1); leavew();                                 /* leave */
            ii(0x17_b771, 1); retfw(); return;                          /* retf */
        l_0x17_b772:
            ii(0x17_b772, 3); mov(ax, memw_a16[ss, bp - 0x26]);         /* mov ax, [bp-0x26] */
            ii(0x17_b775, 3); mov(dx, memw_a16[ss, bp - 0x24]);         /* mov dx, [bp-0x24] */
            ii(0x17_b778, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_b77b, 3); sbb(dx, 0x1);                             /* sbb dx, 0x1 */
            ii(0x17_b77e, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_b780, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_b782, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_b784, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_b786, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_b788, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_b78a, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_b78c, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_b78e, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_b790, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_b792, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_b794, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_b796, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x17_b799, 3); mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
            ii(0x17_b79c, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_b79e, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_b7a0, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_b7a2, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_b7a4, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b7a6, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b7a8, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b7aa, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b7ac, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b7ae, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b7b0, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b7b2, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b7b4, 3); and(ah, 0x3);                             /* and ah, 0x3 */
            ii(0x17_b7b7, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x17_b7ba, 3); mov(ax, memw_a16[ss, bp - 0x20]);         /* mov ax, [bp-0x20] */
            ii(0x17_b7bd, 3); mov(dx, memw_a16[ss, bp - 0x1e]);         /* mov dx, [bp-0x1e] */
            ii(0x17_b7c0, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_b7c2, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_b7c4, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_b7c6, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_b7c8, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b7ca, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b7cc, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b7ce, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b7d0, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b7d2, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b7d4, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b7d6, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b7d8, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x17_b7db, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x17_b7de, 5); mov(memw_a16[ss, bp - 0x22], 0);          /* mov word [bp-0x22], 0x0 */
            ii(0x17_b7e3, 2); jmpw(0x17_b7e9, 0x4); goto l_0x17_b7e9;   /* jmp 0xb7e9 */
        //  ii(0x17_b7e5, 1); nop();                                    /* nop */
        l_0x17_b7e6:
            ii(0x17_b7e6, 3); inc(memw_a16[ss, bp - 0x22]);             /* inc word [bp-0x22] */
        l_0x17_b7e9:
            ii(0x17_b7e9, 4); cmp(memw_a16[ss, bp - 0x22], 0x14);       /* cmp word [bp-0x22], 0x14 */
            ii(0x17_b7ed, 2); if(jaew(0x17_b800, 0x11)) goto l_0x17_b800; /* jae 0xb800 */
            ii(0x17_b7ef, 3); mov(bx, memw_a16[ss, bp - 0x22]);         /* mov bx, [bp-0x22] */
            ii(0x17_b7f2, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x17_b7f5, 5); cmp(memw_a16[ds, bx + 0x12cc], 0);        /* cmp word [bx+0x12cc], 0x0 */
            ii(0x17_b7fa, 2); if(jnzw(0x17_b7fe, 0x2)) goto l_0x17_b7fe; /* jnz 0xb7fe */
            ii(0x17_b7fc, 2); jmpw(0x17_b800, 0x2); goto l_0x17_b800;   /* jmp 0xb800 */
        l_0x17_b7fe:
            ii(0x17_b7fe, 2); jmpw(0x17_b7e6, -0x1a); goto l_0x17_b7e6; /* jmp 0xb7e6 */
        l_0x17_b800:
            ii(0x17_b800, 4); cmp(memw_a16[ss, bp - 0x22], 0x14);       /* cmp word [bp-0x22], 0x14 */
            ii(0x17_b804, 2); if(jnzw(0x17_b828, 0x22)) goto l_0x17_b828; /* jnz 0xb828 */
            ii(0x17_b806, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x17_b809, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_b80b, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_b80e, 4); mov(memw_a16[es, bx + 0x14], ax);         /* mov [es:bx+0x14], ax */
            ii(0x17_b812, 4); mov(memw_a16[es, bx + 0x16], dx);         /* mov [es:bx+0x16], dx */
            ii(0x17_b816, 4); mov(memw_a16[es, bx + 0x1c], ax);         /* mov [es:bx+0x1c], ax */
            ii(0x17_b81a, 4); mov(memw_a16[es, bx + 0x1e], dx);         /* mov [es:bx+0x1e], dx */
            ii(0x17_b81e, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_b823, 1); popw(ds);                                 /* pop ds */
            ii(0x17_b824, 1); popw(si);                                 /* pop si */
            ii(0x17_b825, 1); popw(di);                                 /* pop di */
            ii(0x17_b826, 1); leavew();                                 /* leave */
            ii(0x17_b827, 1); retfw(); return;                          /* retf */
        l_0x17_b828:
            ii(0x17_b828, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x17_b82b, 3); mov(bx, memw_a16[ss, bp - 0x22]);         /* mov bx, [bp-0x22] */
            ii(0x17_b82e, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x17_b831, 4); mov(memw_a16[ds, bx + 0x12ca], ax);       /* mov [bx+0x12ca], ax */
            ii(0x17_b835, 3); mov(ax, memw_a16[ss, bp - 0x1c]);         /* mov ax, [bp-0x1c] */
            ii(0x17_b838, 4); mov(memw_a16[ds, bx + 0x12cc], ax);       /* mov [bx+0x12cc], ax */
            ii(0x17_b83c, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_b83e, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x17_b841, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x17_b844, 2); jmpw(0x17_b859, 0x13); goto l_0x17_b859;  /* jmp 0xb859 */
        l_0x17_b846:
            ii(0x17_b846, 4); add(memw_a16[ss, bp - 0x16], 0x1);        /* add word [bp-0x16], 0x1 */
            ii(0x17_b84a, 4); adc(memw_a16[ss, bp - 0x14], 0);          /* adc word [bp-0x14], 0x0 */
            ii(0x17_b84e, 3); inc(memw_a16[ss, bp - 0x6]);              /* inc word [bp-0x6] */
            ii(0x17_b851, 4); add(memw_a16[ss, bp - 0xa], 0x1);         /* add word [bp-0xa], 0x1 */
            ii(0x17_b855, 4); adc(memw_a16[ss, bp - 0x8], 0);           /* adc word [bp-0x8], 0x0 */
        l_0x17_b859:
            ii(0x17_b859, 3); mov(ax, memw_a16[ss, bp - 0x1c]);         /* mov ax, [bp-0x1c] */
            ii(0x17_b85c, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_b85e, 3); cmp(dx, memw_a16[ss, bp - 0x14]);         /* cmp dx, [bp-0x14] */
            ii(0x17_b861, 2); if(jaew(0x17_b866, 0x3)) goto l_0x17_b866; /* jae 0xb866 */
            ii(0x17_b863, 3); jmpw(0x17_b8f0, 0x8a); goto l_0x17_b8f0;  /* jmp 0xb8f0 */
        l_0x17_b866:
            ii(0x17_b866, 2); if(jaw(0x17_b870, 0x8)) goto l_0x17_b870; /* ja 0xb870 */
            ii(0x17_b868, 3); cmp(ax, memw_a16[ss, bp - 0x16]);         /* cmp ax, [bp-0x16] */
            ii(0x17_b86b, 2); if(jaw(0x17_b870, 0x3)) goto l_0x17_b870; /* ja 0xb870 */
            ii(0x17_b86d, 3); jmpw(0x17_b8f0, 0x80); goto l_0x17_b8f0;  /* jmp 0xb8f0 */
        l_0x17_b870:
            ii(0x17_b870, 5); cmp(memw_a16[ss, bp - 0x6], 0x400);       /* cmp word [bp-0x6], 0x400 */
            ii(0x17_b875, 2); if(jaew(0x17_b889, 0x12)) goto l_0x17_b889; /* jae 0xb889 */
            ii(0x17_b877, 3); mov(bx, memw_a16[ss, bp - 0x6]);          /* mov bx, [bp-0x6] */
            ii(0x17_b87a, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x17_b87d, 3); les(si, ss, bp - 0x4);                    /* les si, [bp-0x4] */
            ii(0x17_b880, 3); mov(al, memb_a16[es, bx + si]);           /* mov al, [es:bx+si] */
            ii(0x17_b883, 2); and(al, 0x1);                             /* and al, 0x1 */
            ii(0x17_b885, 2); cmp(al, 0x1);                             /* cmp al, 0x1 */
            ii(0x17_b887, 2); if(jnzw(0x17_b8aa, 0x21)) goto l_0x17_b8aa; /* jnz 0xb8aa */
        l_0x17_b889:
            ii(0x17_b889, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x17_b88c, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_b88f, 4); mov(memw_a16[es, bx + 0x14], ax);         /* mov [es:bx+0x14], ax */
            ii(0x17_b893, 4); mov(memw_a16[es, bx + 0x16], dx);         /* mov [es:bx+0x16], dx */
            ii(0x17_b897, 4); mov(memw_a16[es, bx + 0x1c], ax);         /* mov [es:bx+0x1c], ax */
            ii(0x17_b89b, 4); mov(memw_a16[es, bx + 0x1e], dx);         /* mov [es:bx+0x1e], dx */
            ii(0x17_b89f, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_b8a4, 1); popw(ds);                                 /* pop ds */
            ii(0x17_b8a5, 1); popw(si);                                 /* pop si */
            ii(0x17_b8a6, 1); popw(di);                                 /* pop di */
            ii(0x17_b8a7, 1); leavew();                                 /* leave */
            ii(0x17_b8a8, 1); retfw(); return;                          /* retf */
        //  ii(0x17_b8a9, 1); Недостижимый код.
        l_0x17_b8aa:
            ii(0x17_b8aa, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x17_b8ad, 3); mov(dx, memw_a16[ss, bp - 0x8]);          /* mov dx, [bp-0x8] */
            ii(0x17_b8b0, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_b8b2, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_b8b4, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_b8b6, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_b8b8, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_b8ba, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_b8bc, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_b8be, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_b8c0, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_b8c2, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_b8c4, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_b8c6, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_b8c8, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x17_b8ca, 3); mov(bx, memw_a16[ss, bp - 0x6]);          /* mov bx, [bp-0x6] */
            ii(0x17_b8cd, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x17_b8d0, 4); or(memb_a16[es, bx + si], 0x1);           /* or byte [es:bx+si], 0x1 */
            ii(0x17_b8d4, 3); xor(ax, memw_a16[es, bx + si]);           /* xor ax, [es:bx+si] */
            ii(0x17_b8d7, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x17_b8da, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_b8dc, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_b8de, 2); xor(cx, ax);                              /* xor cx, ax */
            ii(0x17_b8e0, 2); xor(di, dx);                              /* xor di, dx */
            ii(0x17_b8e2, 3); mov(memw_a16[es, bx + si], cx);           /* mov [es:bx+si], cx */
            ii(0x17_b8e5, 4); mov(memw_a16[es, bx + si + 0x2], di);     /* mov [es:bx+si+0x2], di */
            ii(0x17_b8e9, 4); or(memb_a16[es, bx + si], 0x1e);          /* or byte [es:bx+si], 0x1e */
            ii(0x17_b8ed, 3); jmpw(0x17_b846, -0xaa); goto l_0x17_b846; /* jmp 0xb846 */
        l_0x17_b8f0:
            ii(0x17_b8f0, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x17_b8f3, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x17_b8f6, 1); nop();                                    /* nop */
            ii(0x17_b8f7, 1); pushw(cs);                                /* push cs */
            ii(0x17_b8f8, 3); callw(0x17_e758, 0x2e5d);                 /* call 0xe758 */
            ii(0x17_b8fb, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_b8fe, 3); mov(ax, memw_a16[ss, bp - 0x20]);         /* mov ax, [bp-0x20] */
            ii(0x17_b901, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x17_b904, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_b906, 3); add(memw_a16[ss, bp - 0x12], ax);         /* add [bp-0x12], ax */
            ii(0x17_b909, 3); adc(memw_a16[ss, bp - 0x10], dx);         /* adc [bp-0x10], dx */
            ii(0x17_b90c, 3); mov(dx, memw_a16[ss, bp - 0x10]);         /* mov dx, [bp-0x10] */
            ii(0x17_b90f, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_b912, 4); mov(memw_a16[es, bx + 0x14], dx);         /* mov [es:bx+0x14], dx */
            ii(0x17_b916, 6); mov(memw_a16[es, bx + 0x16], 0);          /* mov word [es:bx+0x16], 0x0 */
            ii(0x17_b91c, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x17_b91f, 4); mov(memw_a16[es, bx + 0x1c], ax);         /* mov [es:bx+0x1c], ax */
            ii(0x17_b923, 6); mov(memw_a16[es, bx + 0x1e], 0);          /* mov word [es:bx+0x1e], 0x0 */
            ii(0x17_b929, 5); and(memb_a16[es, bx + 0x2c], -0x2 /* 0xfe */); /* and byte [es:bx+0x2c], 0xfe */
        l_0x17_b92e:
            ii(0x17_b92e, 1); popw(ds);                                 /* pop ds */
            ii(0x17_b92f, 1); popw(si);                                 /* pop si */
            ii(0x17_b930, 1); popw(di);                                 /* pop di */
            ii(0x17_b931, 1); leavew();                                 /* leave */
            ii(0x17_b932, 1); retfw(); return;                          /* retf */
        }
    }
}
