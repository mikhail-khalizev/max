using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("869ecff3-d448-49d7-bb61-6db74bba6714")]
        public void Method_0017_b934()
        {
            ii(0x17_b934, 4); enterw(0x12, 0);                          /* enter 0x12, 0x0 */
            ii(0x17_b938, 1); pushw(di);                                /* push di */
            ii(0x17_b939, 1); pushw(si);                                /* push si */
            ii(0x17_b93a, 1); pushw(ds);                                /* push ds */
            ii(0x17_b93b, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_b93e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_b940, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_b943, 4); mov(ax, memw_a16[es, bx + 0x14]);         /* mov ax, [es:bx+0x14] */
            ii(0x17_b947, 4); mov(cx, memw_a16[es, bx + 0x1c]);         /* mov cx, [es:bx+0x1c] */
            ii(0x17_b94b, 3); mov(memw_a16[ss, bp - 0xe], cx);          /* mov [bp-0xe], cx */
            ii(0x17_b94e, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x17_b951, 4); les(si, ds, 0x992);                       /* les si, [0x992] */
            ii(0x17_b955, 6); test(memb_a16[es, si + 0xf00], 0x1);      /* test byte [es:si+0xf00], 0x1 */
            ii(0x17_b95b, 2); if(jnzw(0x17_b976, 0x19)) goto l_0x17_b976; /* jnz 0xb976 */
            ii(0x17_b95d, 3); mov(es, memw_a16[ss, bp + 0x8]);          /* mov es, [bp+0x8] */
            ii(0x17_b960, 6); mov(memw_a16[es, bx + 0x20], 0x8025);     /* mov word [es:bx+0x20], 0x8025 */
            ii(0x17_b966, 6); mov(memw_a16[es, bx + 0x22], 0);          /* mov word [es:bx+0x22], 0x0 */
            ii(0x17_b96c, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_b971, 1); popw(ds);                                 /* pop ds */
            ii(0x17_b972, 1); popw(si);                                 /* pop si */
            ii(0x17_b973, 1); popw(di);                                 /* pop di */
            ii(0x17_b974, 1); leavew();                                 /* leave */
            ii(0x17_b975, 1); retfw(); return;                          /* retf */
        l_0x17_b976:
            ii(0x17_b976, 3); cmp(ax, 0xf000);                          /* cmp ax, 0xf000 */
            ii(0x17_b979, 2); if(jbw(0x17_b988, 0xd)) goto l_0x17_b988; /* jb 0xb988 */
            ii(0x17_b97b, 2); if(jaw(0x17_b97d, 0)) goto l_0x17_b97d;   /* ja 0xb97d */
        l_0x17_b97d:
            ii(0x17_b97d, 3); cmp(ax, 0xf000);                          /* cmp ax, 0xf000 */
            ii(0x17_b980, 2); if(jbw(0x17_b9a2, 0x20)) goto l_0x17_b9a2; /* jb 0xb9a2 */
            ii(0x17_b982, 2); if(jaw(0x17_b988, 0x4)) goto l_0x17_b988; /* ja 0xb988 */
            ii(0x17_b984, 2); or(cx, cx);                               /* or cx, cx */
            ii(0x17_b986, 2); if(jzw(0x17_b9a2, 0x1a)) goto l_0x17_b9a2; /* jz 0xb9a2 */
        l_0x17_b988:
            ii(0x17_b988, 3); mov(es, memw_a16[ss, bp + 0x8]);          /* mov es, [bp+0x8] */
            ii(0x17_b98b, 6); mov(memw_a16[es, bx + 0x20], 0x8025);     /* mov word [es:bx+0x20], 0x8025 */
            ii(0x17_b991, 6); mov(memw_a16[es, bx + 0x22], 0);          /* mov word [es:bx+0x22], 0x0 */
            ii(0x17_b997, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_b99c, 1); popw(ds);                                 /* pop ds */
            ii(0x17_b99d, 1); popw(si);                                 /* pop si */
            ii(0x17_b99e, 1); popw(di);                                 /* pop di */
            ii(0x17_b99f, 1); leavew();                                 /* leave */
            ii(0x17_b9a0, 1); retfw(); return;                          /* retf */
        //  ii(0x17_b9a1, 1); Недостижимый (и не декодированный) код.
        l_0x17_b9a2:
            ii(0x17_b9a2, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x17_b9a4, 3); mov(dx, memw_a16[ss, bp - 0xc]);          /* mov dx, [bp-0xc] */
            ii(0x17_b9a7, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_b9a9, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_b9ab, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_b9ad, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_b9af, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b9b1, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b9b3, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b9b5, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b9b7, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b9b9, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b9bb, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b9bd, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b9bf, 3); and(ah, 0x3);                             /* and ah, 0x3 */
            ii(0x17_b9c2, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x17_b9c5, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_b9c7, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_b9ca, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x17_b9cd, 2); jmpw(0x17_b9d8, 0x9); goto l_0x17_b9d8;   /* jmp 0xb9d8 */
        //    ii(0x17_b9cf, 1); nop();                                    /* nop */
        l_0x17_b9d0:
            ii(0x17_b9d0, 4); add(memw_a16[ss, bp - 0xa], 0x1);         /* add word [bp-0xa], 0x1 */
            ii(0x17_b9d4, 4); adc(memw_a16[ss, bp - 0x8], 0);           /* adc word [bp-0x8], 0x0 */
        l_0x17_b9d8:
            ii(0x17_b9d8, 4); cmp(memw_a16[ss, bp - 0x8], 0);           /* cmp word [bp-0x8], 0x0 */
            ii(0x17_b9dc, 2); if(jzw(0x17_b9e1, 0x3)) goto l_0x17_b9e1; /* jz 0xb9e1 */
            ii(0x17_b9de, 3); jmpw(0x17_bad0, 0xef); goto l_0x17_bad0;  /* jmp 0xbad0 */
        l_0x17_b9e1:
            ii(0x17_b9e1, 4); cmp(memw_a16[ss, bp - 0xa], 0x14);        /* cmp word [bp-0xa], 0x14 */
            ii(0x17_b9e5, 2); if(jbw(0x17_b9ea, 0x3)) goto l_0x17_b9ea; /* jb 0xb9ea */
            ii(0x17_b9e7, 3); jmpw(0x17_bad0, 0xe6); goto l_0x17_bad0;  /* jmp 0xbad0 */
        l_0x17_b9ea:
            ii(0x17_b9ea, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x17_b9ed, 3); mov(bx, memw_a16[ss, bp - 0xa]);          /* mov bx, [bp-0xa] */
            ii(0x17_b9f0, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x17_b9f3, 4); cmp(memw_a16[ds, bx + 0x12ca], ax);       /* cmp [bx+0x12ca], ax */
            ii(0x17_b9f7, 2); if(jzw(0x17_b9fc, 0x3)) goto l_0x17_b9fc; /* jz 0xb9fc */
            ii(0x17_b9f9, 3); jmpw(0x17_bacc, 0xd0); goto l_0x17_bacc;  /* jmp 0xbacc */
        l_0x17_b9fc:
            ii(0x17_b9fc, 5); cmp(memw_a16[ds, bx + 0x12cc], 0);        /* cmp word [bx+0x12cc], 0x0 */
            ii(0x17_ba01, 2); if(jnzw(0x17_ba06, 0x3)) goto l_0x17_ba06; /* jnz 0xba06 */
            ii(0x17_ba03, 3); jmpw(0x17_bacc, 0xc6); goto l_0x17_bacc;  /* jmp 0xbacc */
        l_0x17_ba06:
            ii(0x17_ba06, 4); les(si, ds, 0x992);                       /* les si, [0x992] */
            ii(0x17_ba0a, 5); mov(ax, memw_a16[es, si + 0xf00]);        /* mov ax, [es:si+0xf00] */
            ii(0x17_ba0f, 2); mov(cx, es);                              /* mov cx, es */
            ii(0x17_ba11, 4); les(di, ds, 0x4fec);                      /* les di, [0x4fec] */
            ii(0x17_ba15, 3); xor(ax, memw_a16[es, di]);                /* xor ax, [es:di] */
            ii(0x17_ba18, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x17_ba1b, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_ba1d, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x17_ba1f, 5); xor(ax, memw_a16[es, si + 0xf00]);        /* xor ax, [es:si+0xf00] */
            ii(0x17_ba24, 5); xor(dx, memw_a16[es, si + 0xf02]);        /* xor dx, [es:si+0xf02] */
            ii(0x17_ba29, 4); les(si, ds, 0x4fec);                      /* les si, [0x4fec] */
            ii(0x17_ba2d, 3); mov(memw_a16[es, si], ax);                /* mov [es:si], ax */
            ii(0x17_ba30, 4); mov(memw_a16[es, si + 0x2], dx);          /* mov [es:si+0x2], dx */
            ii(0x17_ba34, 4); les(si, ds, 0x4fec);                      /* les si, [0x4fec] */
            ii(0x17_ba38, 4); or(memb_a16[es, si], 0x1);                /* or byte [es:si], 0x1 */
            ii(0x17_ba3c, 4); les(si, ds, 0x4fec);                      /* les si, [0x4fec] */
            ii(0x17_ba40, 4); or(memb_a16[es, si], 0x4);                /* or byte [es:si], 0x4 */
            ii(0x17_ba44, 4); les(si, ds, 0x4fec);                      /* les si, [0x4fec] */
            ii(0x17_ba48, 4); or(memb_a16[es, si], 0x2);                /* or byte [es:si], 0x2 */
            ii(0x17_ba4c, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x17_ba4e, 1); nop();                                    /* nop */
            ii(0x17_ba4f, 1); pushw(cs);                                /* push cs */
            ii(0x17_ba50, 3); callw(0x17_8e97, -0x2bbc);                /* call 0x8e97 */
            ii(0x17_ba53, 3); pushw(0x1000);                            /* push 0x1000 */
            ii(0x17_ba56, 3); pushw(0xff00);                            /* push 0xff00 */
            ii(0x17_ba59, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_ba5b, 1); nop();                                    /* nop */
            ii(0x17_ba5c, 1); pushw(cs);                                /* push cs */
            ii(0x17_ba5d, 3); callw(0x17_e96a, 0x2f0a);                 /* call 0xe96a */
            ii(0x17_ba60, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_ba63, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_ba66, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x17_ba69, 4); mov(ax, memw_a16[ds, si + 0x12cc]);       /* mov ax, [si+0x12cc] */
            ii(0x17_ba6d, 1); cwd();                                    /* cwd */
            ii(0x17_ba6e, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x17_ba71, 3); mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
            ii(0x17_ba74, 2); jmpw(0x17_ba81, 0xb); goto l_0x17_ba81;   /* jmp 0xba81 */
        l_0x17_ba76:
            ii(0x17_ba76, 4); sub(memw_a16[ss, bp - 0x12], 0x1);        /* sub word [bp-0x12], 0x1 */
            ii(0x17_ba7a, 4); sbb(memw_a16[ss, bp - 0x10], 0);          /* sbb word [bp-0x10], 0x0 */
            ii(0x17_ba7e, 3); inc(memw_a16[ss, bp - 0x6]);              /* inc word [bp-0x6] */
        l_0x17_ba81:
            ii(0x17_ba81, 4); cmp(memw_a16[ss, bp - 0x10], 0);          /* cmp word [bp-0x10], 0x0 */
            ii(0x17_ba85, 2); if(jnzw(0x17_ba8d, 0x6)) goto l_0x17_ba8d; /* jnz 0xba8d */
            ii(0x17_ba87, 4); cmp(memw_a16[ss, bp - 0x12], 0);          /* cmp word [bp-0x12], 0x0 */
            ii(0x17_ba8b, 2); if(jzw(0x17_bab0, 0x23)) goto l_0x17_bab0; /* jz 0xbab0 */
        l_0x17_ba8d:
            ii(0x17_ba8d, 3); mov(bx, memw_a16[ss, bp - 0x6]);          /* mov bx, [bp-0x6] */
            ii(0x17_ba90, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x17_ba93, 3); les(si, ss, bp - 0x4);                    /* les si, [bp-0x4] */
            ii(0x17_ba96, 4); and(memb_a16[es, bx + si], -0x2 /* 0xfe */); /* and byte [es:bx+si], 0xfe */
            ii(0x17_ba9a, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
            ii(0x17_ba9d, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x17_baa0, 3); mov(memw_a16[es, bx + si], ax);           /* mov [es:bx+si], ax */
            ii(0x17_baa3, 6); mov(memw_a16[es, bx + si + 0x2], 0);      /* mov word [es:bx+si+0x2], 0x0 */
            ii(0x17_baa9, 4); and(memb_a16[es, bx + si], -0x7 /* 0xf9 */); /* and byte [es:bx+si], 0xf9 */
            ii(0x17_baad, 2); jmpw(0x17_ba76, -0x39); goto l_0x17_ba76; /* jmp 0xba76 */
        //    ii(0x17_baaf, 1); nop();                                    /* nop */
        l_0x17_bab0:
            ii(0x17_bab0, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x17_bab3, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x17_bab6, 1); nop();                                    /* nop */
            ii(0x17_bab7, 1); pushw(cs);                                /* push cs */
            ii(0x17_bab8, 3); callw(0x17_e758, 0x2c9d);                 /* call 0xe758 */
            ii(0x17_babb, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_babe, 3); mov(bx, memw_a16[ss, bp - 0xa]);          /* mov bx, [bp-0xa] */
            ii(0x17_bac1, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x17_bac4, 6); mov(memw_a16[ds, bx + 0x12cc], 0);        /* mov word [bx+0x12cc], 0x0 */
            ii(0x17_baca, 2); jmpw(0x17_bad0, 0x4); goto l_0x17_bad0;   /* jmp 0xbad0 */
        l_0x17_bacc:
            ii(0x17_bacc, 3); jmpw(0x17_b9d0, -0xff); goto l_0x17_b9d0; /* jmp 0xb9d0 */
        //    ii(0x17_bacf, 1); nop();                                    /* nop */
        l_0x17_bad0:
            ii(0x17_bad0, 4); cmp(memw_a16[ss, bp - 0xa], 0x14);        /* cmp word [bp-0xa], 0x14 */
            ii(0x17_bad4, 2); if(jnzw(0x17_bafa, 0x24)) goto l_0x17_bafa; /* jnz 0xbafa */
            ii(0x17_bad6, 4); cmp(memw_a16[ss, bp - 0x8], 0);           /* cmp word [bp-0x8], 0x0 */
            ii(0x17_bada, 2); if(jnzw(0x17_bafa, 0x1e)) goto l_0x17_bafa; /* jnz 0xbafa */
            ii(0x17_badc, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_badf, 6); mov(memw_a16[es, bx + 0x20], 0x8025);     /* mov word [es:bx+0x20], 0x8025 */
            ii(0x17_bae5, 6); mov(memw_a16[es, bx + 0x22], 0);          /* mov word [es:bx+0x22], 0x0 */
            ii(0x17_baeb, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_baf0, 1); popw(ds);                                 /* pop ds */
            ii(0x17_baf1, 1); popw(si);                                 /* pop si */
            ii(0x17_baf2, 1); popw(di);                                 /* pop di */
            ii(0x17_baf3, 1); leavew();                                 /* leave */
            ii(0x17_baf4, 1); retfw(); return;                          /* retf */
        //  ii(0x17_baf5, 5); Недостижимый (и не декодированный) код.
        l_0x17_bafa:
            ii(0x17_bafa, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_bafd, 5); and(memb_a16[es, bx + 0x2c], -0x2 /* 0xfe */); /* and byte [es:bx+0x2c], 0xfe */
            ii(0x17_bb02, 1); popw(ds);                                 /* pop ds */
            ii(0x17_bb03, 1); popw(si);                                 /* pop si */
            ii(0x17_bb04, 1); popw(di);                                 /* pop di */
            ii(0x17_bb05, 1); leavew();                                 /* leave */
            ii(0x17_bb06, 1); retfw(); return;                          /* retf */
        }
    }
}
