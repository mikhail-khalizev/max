using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2107dcf5-210b-4a2c-a74c-93bac9878658")]
        public void Method_0013_9c18()
        {
            ii(0x13_9c18, 4); enterw(0xc, 0);                           /* enter 0xc, 0x0 */
            ii(0x13_9c1c, 1); pushw(ds);                                /* push ds */
            ii(0x13_9c1d, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_9c20, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_9c22, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_9c25, 5); cmp(memw_a16[es, bx + 0x8], 0);           /* cmp word [es:bx+0x8], 0x0 */
            ii(0x13_9c2a, 2); if(jzw(0x13_9c40, 0x14)) goto l_0x13_9c40; /* jz 0x9c40 */
            ii(0x13_9c2c, 6); mov(memw_a16[es, bx + 0x20], 0x8023);     /* mov word [es:bx+0x20], 0x8023 */
            ii(0x13_9c32, 6); mov(memw_a16[es, bx + 0x22], 0);          /* mov word [es:bx+0x22], 0x0 */
            ii(0x13_9c38, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x13_9c3d, 1); popw(ds);                                 /* pop ds */
            ii(0x13_9c3e, 1); leavew();                                 /* leave */
            ii(0x13_9c3f, 1); retfw(); return;                          /* retf */
        l_0x13_9c40:
            ii(0x13_9c40, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x13_9c44, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x13_9c47, 4); mov(dx, memw_a16[es, bx + 0x14]);         /* mov dx, [es:bx+0x14] */
            ii(0x13_9c4b, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_9c4d, 4); mov(cx, memw_a16[es, bx + 0x1c]);         /* mov cx, [es:bx+0x1c] */
            ii(0x13_9c51, 2); add(ax, cx);                              /* add ax, cx */
            ii(0x13_9c53, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x13_9c56, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_9c58, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_9c5a, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_9c5c, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_9c5e, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_9c60, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_9c62, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_9c64, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_9c66, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_9c68, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_9c6a, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_9c6c, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_9c6e, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x13_9c71, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x13_9c74, 4); test(cx, 0xfff);                          /* test cx, 0xfff */
            ii(0x13_9c78, 2); if(jzw(0x13_9c86, 0xc)) goto l_0x13_9c86; /* jz 0x9c86 */
            ii(0x13_9c7a, 3); add(ax, 0x1);                             /* add ax, 0x1 */
            ii(0x13_9c7d, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x13_9c80, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x13_9c83, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
        l_0x13_9c86:
            ii(0x13_9c86, 3); lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x13_9c89, 1); pushw(ss);                                /* push ss */
            ii(0x13_9c8a, 1); pushw(ax);                                /* push ax */
            ii(0x13_9c8b, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x13_9c8e, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x13_9c91, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x13_9c94, 1); pushw(cs);                                /* push cs */
            ii(0x13_9c95, 3); callw(0x13_bef2, 0x225a);                 /* call 0xbef2 */
            ii(0x13_9c98, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x13_9c9b, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x13_9c9e, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_9ca0, 2); if(jzw(0x13_9cba, 0x18)) goto l_0x13_9cba; /* jz 0x9cba */
            ii(0x13_9ca2, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_9ca5, 4); mov(memw_a16[es, bx + 0x20], ax);         /* mov [es:bx+0x20], ax */
            ii(0x13_9ca9, 6); mov(memw_a16[es, bx + 0x22], 0);          /* mov word [es:bx+0x22], 0x0 */
            ii(0x13_9caf, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x13_9cb4, 1); popw(ds);                                 /* pop ds */
            ii(0x13_9cb5, 1); leavew();                                 /* leave */
            ii(0x13_9cb6, 1); retfw(); return;                          /* retf */
        //  ii(0x13_9cb7, 3); Недостижимый код.
l_0x13_9cba:
            ii(0x13_9cba, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x13_9cbd, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_9cc0, 4); mov(memw_a16[es, bx + 0x14], ax);         /* mov [es:bx+0x14], ax */
            ii(0x13_9cc4, 6); mov(memw_a16[es, bx + 0x16], 0);          /* mov word [es:bx+0x16], 0x0 */
            ii(0x13_9cca, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_9ccd, 4); mov(memw_a16[es, bx + 0x1c], ax);         /* mov [es:bx+0x1c], ax */
            ii(0x13_9cd1, 6); mov(memw_a16[es, bx + 0x1e], 0);          /* mov word [es:bx+0x1e], 0x0 */
            ii(0x13_9cd7, 5); and(memb_a16[es, bx + 0x2c], -0x2 /* 0xfe */); /* and byte [es:bx+0x2c], 0xfe */
            ii(0x13_9cdc, 1); popw(ds);                                 /* pop ds */
            ii(0x13_9cdd, 1); leavew();                                 /* leave */
            ii(0x13_9cde, 1); retfw(); return;                          /* retf */
        }
    }
}