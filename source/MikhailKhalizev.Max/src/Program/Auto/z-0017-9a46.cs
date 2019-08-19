using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_9a46-41ab8b1d")]
        public void Method_0017_9a46()
        {
            ii(0x17_9a46, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x17_9a4a, 1); pushw(si);                                /* push si */
            ii(0x17_9a4b, 1); pushw(ds);                                /* push ds */
            ii(0x17_9a4c, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_9a4f, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_9a51, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_9a54, 4); mov(ax, memw_a16[es, bx + 0x14]);         /* mov ax, [es:bx+0x14] */
            ii(0x17_9a58, 4); mov(cx, memw_a16[es, bx + 0x1c]);         /* mov cx, [es:bx+0x1c] */
            ii(0x17_9a5c, 3); mov(memw_a16[ss, bp - 0x14], cx);         /* mov [bp-0x14], cx */
            ii(0x17_9a5f, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x17_9a62, 5); cmp(memw_a16[ds, 0x984], 0);              /* cmp word [0x984], 0x0 */
            ii(0x17_9a67, 2); if(jzw(0x17_9a8e, 0x25)) goto l_0x17_9a8e; /* jz 0x9a8e */
            ii(0x17_9a69, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
            ii(0x17_9a6d, 4); mov(memb_a16[es, bx], 0x1);               /* mov byte [es:bx], 0x1 */
            ii(0x17_9a71, 3); mov(al, memb_a16[ds, 0x5130]);            /* mov al, [0x5130] */
            ii(0x17_9a74, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
            ii(0x17_9a78, 4); mov(memb_a16[es, bx + 0x1], al);          /* mov [es:bx+0x1], al */
            ii(0x17_9a7c, 3); mov(ax, memw_a16[ss, bp - 0x14]);         /* mov ax, [bp-0x14] */
            ii(0x17_9a7f, 3); mov(dx, memw_a16[ss, bp - 0x12]);         /* mov dx, [bp-0x12] */
            ii(0x17_9a82, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
            ii(0x17_9a86, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x17_9a8a, 4); mov(memw_a16[es, bx + 0x4], dx);          /* mov [es:bx+0x4], dx */
        l_0x17_9a8e:
            ii(0x17_9a8e, 3); mov(ax, memw_a16[ss, bp - 0x14]);         /* mov ax, [bp-0x14] */
            ii(0x17_9a91, 3); mov(dx, memw_a16[ss, bp - 0x12]);         /* mov dx, [bp-0x12] */
            ii(0x17_9a94, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_9a96, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_9a98, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_9a9a, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_9a9c, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_9a9e, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_9aa0, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_9aa2, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_9aa4, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_9aa6, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_9aa8, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_9aaa, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_9aac, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_9aaf, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x17_9ab2, 5); test(memw_a16[ss, bp - 0x14], 0xfff);     /* test word [bp-0x14], 0xfff */
            ii(0x17_9ab7, 2); if(jzw(0x17_9ac5, 0xc)) goto l_0x17_9ac5; /* jz 0x9ac5 */
            ii(0x17_9ab9, 3); add(ax, 0x1);                             /* add ax, 0x1 */
            ii(0x17_9abc, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x17_9abf, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_9ac2, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
        l_0x17_9ac5:
            ii(0x17_9ac5, 3); lea(ax, bp - 0xe);                        /* lea ax, [bp-0xe] */
            ii(0x17_9ac8, 1); pushw(ss);                                /* push ss */
            ii(0x17_9ac9, 1); pushw(ax);                                /* push ax */
            ii(0x17_9aca, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x17_9acd, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x17_9ad0, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_9ad3, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x17_9ad6, 1); pushw(dx);                                /* push dx */
            ii(0x17_9ad7, 1); pushw(ax);                                /* push ax */
            ii(0x17_9ad8, 1); pushw(cs);                                /* push cs */
            ii(0x17_9ad9, 3); callw(0x17_bcb8, 0x21dc);                 /* call 0xbcb8 */
            ii(0x17_9adc, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_9adf, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x17_9ae2, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_9ae4, 2); if(jzw(0x17_9afe, 0x18)) goto l_0x17_9afe; /* jz 0x9afe */
            ii(0x17_9ae6, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_9ae9, 4); mov(memw_a16[es, bx + 0x20], ax);         /* mov [es:bx+0x20], ax */
            ii(0x17_9aed, 6); mov(memw_a16[es, bx + 0x22], 0);          /* mov word [es:bx+0x22], 0x0 */
            ii(0x17_9af3, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_9af8, 1); popw(ds);                                 /* pop ds */
            ii(0x17_9af9, 1); popw(si);                                 /* pop si */
            ii(0x17_9afa, 1); leavew();                                 /* leave */
            ii(0x17_9afb, 1); retfw(); return;                          /* retf */
        //  ii(0x17_9afc, 2); Недостижимый код.
        l_0x17_9afe:
            ii(0x17_9afe, 3); mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0x17_9b01, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_9b04, 4); mov(memw_a16[es, bx + 0x14], ax);         /* mov [es:bx+0x14], ax */
            ii(0x17_9b08, 6); mov(memw_a16[es, bx + 0x16], 0);          /* mov word [es:bx+0x16], 0x0 */
            ii(0x17_9b0e, 3); mov(ax, memw_a16[ss, bp - 0xe]);          /* mov ax, [bp-0xe] */
            ii(0x17_9b11, 4); mov(memw_a16[es, bx + 0x1c], ax);         /* mov [es:bx+0x1c], ax */
            ii(0x17_9b15, 6); mov(memw_a16[es, bx + 0x1e], 0);          /* mov word [es:bx+0x1e], 0x0 */
            ii(0x17_9b1b, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x17_9b1e, 3); shr(ax, 0x10);                            /* shr ax, 0x10 */
            ii(0x17_9b21, 4); mov(memw_a16[es, bx + 0x8], ax);          /* mov [es:bx+0x8], ax */
            ii(0x17_9b25, 6); mov(memw_a16[es, bx + 0xa], 0);           /* mov word [es:bx+0xa], 0x0 */
            ii(0x17_9b2b, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x17_9b2e, 4); mov(memw_a16[es, bx + 0x4], ax);          /* mov [es:bx+0x4], ax */
            ii(0x17_9b32, 6); mov(memw_a16[es, bx + 0x6], 0);           /* mov word [es:bx+0x6], 0x0 */
            ii(0x17_9b38, 5); and(memb_a16[es, bx + 0x2c], -0x2 /* 0xfe */); /* and byte [es:bx+0x2c], 0xfe */
            ii(0x17_9b3d, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x17_9b40, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x17_9b43, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x17_9b46, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x17_9b49, 1); pushw(ds);                                /* push ds */
            ii(0x17_9b4a, 3); pushw(0x1332);                            /* push 0x1332 */
            ii(0x17_9b4d, 1); nop();                                    /* nop */
            ii(0x17_9b4e, 1); pushw(cs);                                /* push cs */
            ii(0x17_9b4f, 3); callw(0x18_104f, 0x74fd);                 /* call 0x104f */
            ii(0x17_9b52, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x17_9b55, 5); cmp(memw_a16[ds, 0x984], 0);              /* cmp word [0x984], 0x0 */
            ii(0x17_9b5a, 2); if(jzw(0x17_9ba7, 0x4b)) goto l_0x17_9ba7; /* jz 0x9ba7 */
            ii(0x17_9b5c, 3); mov(ax, memw_a16[ss, bp - 0xe]);          /* mov ax, [bp-0xe] */
            ii(0x17_9b5f, 3); mov(dx, memw_a16[ss, bp - 0xc]);          /* mov dx, [bp-0xc] */
            ii(0x17_9b62, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
            ii(0x17_9b66, 4); mov(memw_a16[es, bx + 0x6], ax);          /* mov [es:bx+0x6], ax */
            ii(0x17_9b6a, 4); mov(memw_a16[es, bx + 0x8], dx);          /* mov [es:bx+0x8], dx */
            ii(0x17_9b6e, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_9b71, 4); mov(ax, memw_a16[es, bx + 0x24]);         /* mov ax, [es:bx+0x24] */
            ii(0x17_9b75, 4); mov(dx, memw_a16[es, bx + 0x26]);         /* mov dx, [es:bx+0x26] */
            ii(0x17_9b79, 4); les(si, ds, 0x4fc4);                      /* les si, [0x4fc4] */
            ii(0x17_9b7d, 4); mov(memw_a16[es, si + 0xa], ax);          /* mov [es:si+0xa], ax */
            ii(0x17_9b81, 4); mov(memw_a16[es, si + 0xc], dx);          /* mov [es:si+0xc], dx */
            ii(0x17_9b85, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_9b88, 4); mov(ax, memw_a16[es, bx + 0x28]);         /* mov ax, [es:bx+0x28] */
            ii(0x17_9b8c, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
            ii(0x17_9b90, 4); mov(memw_a16[es, bx + 0xe], ax);          /* mov [es:bx+0xe], ax */
            ii(0x17_9b94, 4); pushw(memw_a16[ds, 0x5167]);              /* push word [0x5167] */
            ii(0x17_9b98, 4); pushw(memw_a16[ds, 0x4fc6]);              /* push word [0x4fc6] */
            ii(0x17_9b9c, 4); pushw(memw_a16[ds, 0x4fc4]);              /* push word [0x4fc4] */
            ii(0x17_9ba0, 2); pushw(0x10);                              /* push 0x10 */
            ii(0x17_9ba2, 1); nop();                                    /* nop */
            ii(0x17_9ba3, 1); pushw(cs);                                /* push cs */
            ii(0x17_9ba4, 3); callw(0x18_0864, 0x6cbd);                 /* call 0x864 */
        l_0x17_9ba7:
            ii(0x17_9ba7, 1); popw(ds);                                 /* pop ds */
            ii(0x17_9ba8, 1); popw(si);                                 /* pop si */
            ii(0x17_9ba9, 1); leavew();                                 /* leave */
            ii(0x17_9baa, 1); retfw(); return;                          /* retf */
        }
    }
}
