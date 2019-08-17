using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c4b25a2b-0000-47d7-8dfc-c1d914da2c9e")]
        public void Method_0013_587e()
        {
            ii(0x13_587e, 5); cmp(memb_a16[ds, 0x39], 0);               /* cmp byte [0x39], 0x0 */
            ii(0x13_5883, 2); if(jzw(0x13_5890, 0xb)) goto l_0x13_5890; /* jz 0x5890 */
            ii(0x13_5885, 3); pushw(0x3c);                              /* push 0x3c */
            ii(0x13_5888, 1); nop();                                    /* nop */
            ii(0x13_5889, 1); pushw(cs);                                /* push cs */
            ii(0x13_588a, 3); callw(0x12_dd6c, -0x7b21);                /* call 0xdd6c */
            ii(0x13_588d, 3); add(sp, 0x2);                             /* add sp, 0x2 */
        l_0x13_5890:
            ii(0x13_5890, 5); cmp(memw_a16[ds, 0x51a0], 0);             /* cmp word [0x51a0], 0x0 */
            ii(0x13_5895, 2); if(jnzw(0x13_589a, 0x3)) goto l_0x13_589a; /* jnz 0x589a */
            ii(0x13_5897, 3); jmpw(0x13_5944, 0xaa); goto l_0x13_5944;  /* jmp 0x5944 */
        l_0x13_589a:
            ii(0x13_589a, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
        l_0x13_589f:
            ii(0x13_589f, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x13_58a2, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x13_58a5, 5); cmp(memw_a16[ds, bx + 0xb8], 0);          /* cmp word [bx+0xb8], 0x0 */
            ii(0x13_58aa, 2); if(jzw(0x13_58d2, 0x26)) goto l_0x13_58d2; /* jz 0x58d2 */
            ii(0x13_58ac, 4); pushw(memw_a16[ds, bx + 0xb8]);           /* push word [bx+0xb8] */
            ii(0x13_58b0, 4); pushw(memw_a16[ds, bx + 0xbc]);           /* push word [bx+0xbc] */
            ii(0x13_58b4, 4); pushw(memw_a16[ds, bx + 0xba]);           /* push word [bx+0xba] */
            ii(0x13_58b8, 1); pushw(cs);                                /* push cs */
            ii(0x13_58b9, 3); callw(0x13_751a, 0x1c5e);                 /* call 0x751a */
            ii(0x13_58bc, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_58bf, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x13_58c2, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x13_58c5, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
            ii(0x13_58c8, 3); cmp(ax, 0x4);                             /* cmp ax, 0x4 */
            ii(0x13_58cb, 2); if(jbw(0x13_58d0, 0x3)) goto l_0x13_58d0; /* jb 0x58d0 */
            ii(0x13_58cd, 2); jmpw(0x13_58d2, 0x3); goto l_0x13_58d2;   /* jmp 0x58d2 */
        //    ii(0x13_58cf, 1); nop();                                    /* nop */
        l_0x13_58d0:
            ii(0x13_58d0, 2); jmpw(0x13_589f, -0x33); goto l_0x13_589f; /* jmp 0x589f */
        l_0x13_58d2:
            ii(0x13_58d2, 1); cli();                                    /* cli */
            ii(0x13_58d3, 3); mov(ax, memw_a16[ds, 0x994]);             /* mov ax, [0x994] */
            ii(0x13_58d6, 4); or(ax, memw_a16[ds, 0x992]);              /* or ax, [0x992] */
            ii(0x13_58da, 2); if(jzw(0x13_5918, 0x3c)) goto l_0x13_5918; /* jz 0x5918 */
            ii(0x13_58dc, 5); mov(memw_a16[ss, bp - 0xa], 0x40);        /* mov word [bp-0xa], 0x40 */
            ii(0x13_58e1, 5); mov(memw_a16[ss, bp - 0x8], 0);           /* mov word [bp-0x8], 0x0 */
            ii(0x13_58e6, 2); jmpw(0x13_58f0, 0x8); goto l_0x13_58f0;   /* jmp 0x58f0 */
        l_0x13_58e8:
            ii(0x13_58e8, 4); add(memw_a16[ss, bp - 0xa], 0x1);         /* add word [bp-0xa], 0x1 */
            ii(0x13_58ec, 4); adc(memw_a16[ss, bp - 0x8], 0);           /* adc word [bp-0x8], 0x0 */
        l_0x13_58f0:
            ii(0x13_58f0, 4); cmp(memw_a16[ss, bp - 0x8], 0);           /* cmp word [bp-0x8], 0x0 */
            ii(0x13_58f4, 2); if(jnzw(0x13_5918, 0x22)) goto l_0x13_5918; /* jnz 0x5918 */
            ii(0x13_58f6, 5); cmp(memw_a16[ss, bp - 0xa], 0x400);       /* cmp word [bp-0xa], 0x400 */
            ii(0x13_58fb, 2); if(jaew(0x13_5918, 0x1b)) goto l_0x13_5918; /* jae 0x5918 */
            ii(0x13_58fd, 3); mov(bx, memw_a16[ss, bp - 0xa]);          /* mov bx, [bp-0xa] */
            ii(0x13_5900, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x13_5903, 4); mov(ax, memw_a16[ds, bx + 0x3f60]);       /* mov ax, [bx+0x3f60] */
            ii(0x13_5907, 4); mov(dx, memw_a16[ds, bx + 0x3f62]);       /* mov dx, [bx+0x3f62] */
            ii(0x13_590b, 4); les(si, ds, 0x992);                       /* les si, [0x992] */
            ii(0x13_590f, 3); mov(memw_a16[es, bx + si], ax);           /* mov [es:bx+si], ax */
            ii(0x13_5912, 4); mov(memw_a16[es, bx + si + 0x2], dx);     /* mov [es:bx+si+0x2], dx */
            ii(0x13_5916, 2); jmpw(0x13_58e8, -0x30); goto l_0x13_58e8; /* jmp 0x58e8 */
        l_0x13_5918:
            ii(0x13_5918, 1); nop();                                    /* nop */
            ii(0x13_5919, 1); pushw(cs);                                /* push cs */
            ii(0x13_591a, 3); callw(0x13_8e97, 0x357a);                 /* call 0x8e97 */
            ii(0x13_591d, 3); mov(al, memb_a16[ds, 0x519d]);            /* mov al, [0x519d] */
            ii(0x13_5920, 3); shr(al, 0x2);                             /* shr al, 0x2 */
            ii(0x13_5923, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x13_5925, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x13_5928, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_592a, 2); if(jnzw(0x13_5930, 0x4)) goto l_0x13_5930; /* jnz 0x5930 */
            ii(0x13_592c, 1); inc(ax);                                  /* inc ax */
            ii(0x13_592d, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
        l_0x13_5930:
            ii(0x13_5930, 1); pushw(ax);                                /* push ax */
            ii(0x13_5931, 4); pushw(memw_a16[ds, 0x4fe6]);              /* push word [0x4fe6] */
            ii(0x13_5935, 4); pushw(memw_a16[ds, 0x4fe4]);              /* push word [0x4fe4] */
            ii(0x13_5939, 1); pushw(cs);                                /* push cs */
            ii(0x13_593a, 3); callw(0x13_751a, 0x1bdd);                 /* call 0x751a */
            ii(0x13_593d, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_5940, 3); jmpw(0x13_5a0c, 0xc9); goto l_0x13_5a0c;  /* jmp 0x5a0c */
        //    ii(0x13_5943, 1); nop();                                    /* nop */
        l_0x13_5944:
            ii(0x13_5944, 1); nop();                                    /* nop */
            ii(0x13_5945, 1); pushw(cs);                                /* push cs */
            ii(0x13_5946, 3); callw(0x13_908b, 0x3742);                 /* call 0x908b */
            ii(0x13_5949, 5); mov(memw_a16[ss, bp - 0xc], 0);           /* mov word [bp-0xc], 0x0 */
            ii(0x13_594e, 2); jmpw(0x13_5953, 0x3); goto l_0x13_5953;   /* jmp 0x5953 */
        l_0x13_5950:
            ii(0x13_5950, 3); inc(memw_a16[ss, bp - 0xc]);              /* inc word [bp-0xc] */
        l_0x13_5953:
            ii(0x13_5953, 3); mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0x13_5956, 4); cmp(memw_a16[ds, 0x519e], ax);            /* cmp [0x519e], ax */
            ii(0x13_595a, 2); if(jbew(0x13_59a0, 0x44)) goto l_0x13_59a0; /* jbe 0x59a0 */
            ii(0x13_595c, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_595e, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x13_5961, 4); les(si, ds, 0x4fa0);                      /* les si, [0x4fa0] */
            ii(0x13_5965, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
            ii(0x13_5968, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
            ii(0x13_596c, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_596e, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_5970, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_5972, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_5974, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5976, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5978, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_597a, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_597c, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_597e, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5980, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5982, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5984, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x13_5987, 3); mov(memw_a16[ss, bp - 0x4], dx);          /* mov [bp-0x4], dx */
            ii(0x13_598a, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x13_598c, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x13_598e, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x13_5990, 2); if(jzw(0x13_599d, 0xb)) goto l_0x13_599d; /* jz 0x599d */
            ii(0x13_5992, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x13_5994, 1); pushw(bx);                                /* push bx */
            ii(0x13_5995, 1); pushw(cx);                                /* push cx */
            ii(0x13_5996, 1); pushw(cs);                                /* push cs */
            ii(0x13_5997, 3); callw(0x13_751a, 0x1b80);                 /* call 0x751a */
            ii(0x13_599a, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x13_599d:
            ii(0x13_599d, 2); jmpw(0x13_5950, -0x4f); goto l_0x13_5950; /* jmp 0x5950 */
        //    ii(0x13_599f, 1); nop();                                    /* nop */
        l_0x13_59a0:
            ii(0x13_59a0, 3); mov(ax, memw_a16[ds, 0x994]);             /* mov ax, [0x994] */
            ii(0x13_59a3, 4); or(ax, memw_a16[ds, 0x992]);              /* or ax, [0x992] */
            ii(0x13_59a7, 2); if(jzw(0x13_5a0c, 0x63)) goto l_0x13_5a0c; /* jz 0x5a0c */
            ii(0x13_59a9, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x13_59ae, 2); jmpw(0x13_59b3, 0x3); goto l_0x13_59b3;   /* jmp 0x59b3 */
        l_0x13_59b0:
            ii(0x13_59b0, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x13_59b3:
            ii(0x13_59b3, 5); cmp(memw_a16[ss, bp - 0x2], 0x400);       /* cmp word [bp-0x2], 0x400 */
            ii(0x13_59b8, 2); if(jaew(0x13_5a0c, 0x52)) goto l_0x13_5a0c; /* jae 0x5a0c */
            ii(0x13_59ba, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x13_59bd, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x13_59c0, 4); les(si, ds, 0x992);                       /* les si, [0x992] */
            ii(0x13_59c4, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
            ii(0x13_59c7, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x13_59c9, 2); if(jzw(0x13_5a0a, 0x3f)) goto l_0x13_5a0a; /* jz 0x5a0a */
            ii(0x13_59cb, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x13_59cd, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
            ii(0x13_59d1, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_59d3, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_59d5, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_59d7, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_59d9, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_59db, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_59dd, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_59df, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_59e1, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_59e3, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_59e5, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_59e7, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_59e9, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_59eb, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_59ed, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_59ef, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_59f1, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_59f3, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_59f5, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_59f7, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_59f9, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_59fb, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_59fd, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_59ff, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5a01, 1); pushw(dx);                                /* push dx */
            ii(0x13_5a02, 1); pushw(ax);                                /* push ax */
            ii(0x13_5a03, 1); pushw(cs);                                /* push cs */
            ii(0x13_5a04, 3); callw(0x13_751a, 0x1b13);                 /* call 0x751a */
            ii(0x13_5a07, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x13_5a0a:
            ii(0x13_5a0a, 2); jmpw(0x13_59b0, -0x5c); goto l_0x13_59b0; /* jmp 0x59b0 */
        l_0x13_5a0c:
            ii(0x13_5a0c, 4); pushw(memw_a16[ds, 0x4f82]);              /* push word [0x4f82] */
            ii(0x13_5a10, 4); pushw(memw_a16[ds, 0x4f80]);              /* push word [0x4f80] */
            ii(0x13_5a14, 1); nop();                                    /* nop */
            ii(0x13_5a15, 1); pushw(cs);                                /* push cs */
            ii(0x13_5a16, 3); callw(0x12_e7ea, -0x722f);                /* call 0xe7ea */
            ii(0x13_5a19, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_5a1c, 4); pushw(memw_a16[ds, 0x4fc6]);              /* push word [0x4fc6] */
            ii(0x13_5a20, 4); pushw(memw_a16[ds, 0x4fc4]);              /* push word [0x4fc4] */
            ii(0x13_5a24, 1); nop();                                    /* nop */
            ii(0x13_5a25, 1); pushw(cs);                                /* push cs */
            ii(0x13_5a26, 3); callw(0x12_e7ea, -0x723f);                /* call 0xe7ea */
            ii(0x13_5a29, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_5a2c, 4); pushw(memw_a16[ds, 0x1efa]);              /* push word [0x1efa] */
            ii(0x13_5a30, 4); pushw(memw_a16[ds, 0x1ef8]);              /* push word [0x1ef8] */
            ii(0x13_5a34, 1); nop();                                    /* nop */
            ii(0x13_5a35, 1); pushw(cs);                                /* push cs */
            ii(0x13_5a36, 3); callw(0x12_e7ea, -0x724f);                /* call 0xe7ea */
            ii(0x13_5a39, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_5a3c, 5); cmp(memw_a16[ds, 0x984], 0);              /* cmp word [0x984], 0x0 */
            ii(0x13_5a41, 2); if(jzw(0x13_5a4c, 0x9)) goto l_0x13_5a4c; /* jz 0x5a4c */
            ii(0x13_5a43, 4); pushw(memw_a16[ds, 0x5167]);              /* push word [0x5167] */
            ii(0x13_5a47, 1); nop();                                    /* nop */
            ii(0x13_5a48, 1); pushw(cs);                                /* push cs */
            ii(0x13_5a49, 3); callw(0x13_0791, -0x52bb);                /* call 0x791 */
        l_0x13_5a4c:
            ii(0x13_5a4c, 1); pushw(cs);                                /* push cs */
            ii(0x13_5a4d, 3); callw(0x13_7458, 0x1a08);                 /* call 0x7458 */
            ii(0x13_5a50, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_5a52, 2); if(jnzw(0x13_5a87, 0x33)) goto l_0x13_5a87; /* jnz 0x5a87 */
            ii(0x13_5a54, 3); mov(ax, memw_a16[ds, 0xb0]);              /* mov ax, [0xb0] */
            ii(0x13_5a57, 4); or(ax, memw_a16[ds, 0xae]);               /* or ax, [0xae] */
            ii(0x13_5a5b, 2); if(jzw(0x13_5a6d, 0x10)) goto l_0x13_5a6d; /* jz 0x5a6d */
            ii(0x13_5a5d, 4); pushw(memw_a16[ds, 0xb0]);                /* push word [0xb0] */
            ii(0x13_5a61, 4); pushw(memw_a16[ds, 0xae]);                /* push word [0xae] */
            ii(0x13_5a65, 1); nop();                                    /* nop */
            ii(0x13_5a66, 1); pushw(cs);                                /* push cs */
            ii(0x13_5a67, 3); callw(0x13_909e, 0x3634);                 /* call 0x909e */
            ii(0x13_5a6a, 3); add(sp, 0x4);                             /* add sp, 0x4 */
        l_0x13_5a6d:
            ii(0x13_5a6d, 3); mov(ax, memw_a16[ds, 0x4f86]);            /* mov ax, [0x4f86] */
            ii(0x13_5a70, 4); or(ax, memw_a16[ds, 0x4f84]);             /* or ax, [0x4f84] */
            ii(0x13_5a74, 2); if(jzw(0x13_5a87, 0x11)) goto l_0x13_5a87; /* jz 0x5a87 */
            ii(0x13_5a76, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x13_5a78, 4); pushw(memw_a16[ds, 0x4f86]);              /* push word [0x4f86] */
            ii(0x13_5a7c, 4); pushw(memw_a16[ds, 0x4f84]);              /* push word [0x4f84] */
            ii(0x13_5a80, 1); pushw(cs);                                /* push cs */
            ii(0x13_5a81, 3); callw(0x13_751a, 0x1a96);                 /* call 0x751a */
            ii(0x13_5a84, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x13_5a87:
            ii(0x13_5a87, 5); test(memb_a16[ds, 0x19a2], 0x1);          /* test byte [0x19a2], 0x1 */
            ii(0x13_5a8c, 2); if(jzw(0x13_5aa6, 0x18)) goto l_0x13_5aa6; /* jz 0x5aa6 */
            ii(0x13_5a8e, 3); mov(ax, 0xe3e);                           /* mov ax, 0xe3e */
            ii(0x13_5a91, 3); mov(bx, 0);                               /* mov bx, 0x0 */
            ii(0x13_5a94, 2); @int(0x10);                               /* int 0x10 */
            ii(0x13_5a96, 3); mov(ax, 0xe0d);                           /* mov ax, 0xe0d */
            ii(0x13_5a99, 3); mov(bx, 0);                               /* mov bx, 0x0 */
            ii(0x13_5a9c, 2); @int(0x10);                               /* int 0x10 */
            ii(0x13_5a9e, 3); mov(ax, 0xe0a);                           /* mov ax, 0xe0a */
            ii(0x13_5aa1, 3); mov(bx, 0);                               /* mov bx, 0x0 */
            ii(0x13_5aa4, 2); @int(0x10);                               /* int 0x10 */
        l_0x13_5aa6:
            ii(0x13_5aa6, 1); popw(ds);                                 /* pop ds */
            ii(0x13_5aa7, 1); popw(si);                                 /* pop si */
            ii(0x13_5aa8, 1); leavew();                                 /* leave */
            ii(0x13_5aa9, 1); retfw(); return;                          /* retf */
        }
    }
}