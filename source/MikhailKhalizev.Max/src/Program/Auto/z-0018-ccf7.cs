using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_ccf7-224b69f2")]
        public void Method_0018_ccf7()
        {
            ii(0x18_ccf7, 4); enter(0x10, 0);                           /* enter 0x10, 0x0 */
            ii(0x18_ccfb, 1); push(si);                                 /* push si */
            ii(0x18_ccfc, 5); mov(memw[ss, bp - 0x4], 0);               /* mov word [bp-0x4], 0x0 */
            ii(0x18_cd01, 3); les(bx, memw[ss, bp + 0x4]);              /* les bx, [bp+0x4] */
            ii(0x18_cd04, 6); mov(memw[es, bx + 0x16], 0x1);            /* mov word [es:bx+0x16], 0x1 */
            ii(0x18_cd0a, 4); mov(ax, memw[es, bx + 0x6]);              /* mov ax, [es:bx+0x6] */
            ii(0x18_cd0e, 3); mov(memw[ds, 0x38], ax);                  /* mov [0x38], ax */
            ii(0x18_cd11, 3); mov(memw[ss, bp - 0x2], ax);              /* mov [bp-0x2], ax */
        l_0x18_cd14:
            ii(0x18_cd14, 3); lea(ax, memw[ss, bp - 0x10]);             /* lea ax, [bp-0x10] */
            ii(0x18_cd17, 1); push(ax);                                 /* push ax */
            ii(0x18_cd18, 3); push(memw[ss, bp - 0x2]);                 /* push word [bp-0x2] */
            ii(0x18_cd1b, 3); call(0x18_dc8e, 0xf70);                   /* call 0xdc8e */
            ii(0x18_cd1e, 1); pop(bx);                                  /* pop bx */
            ii(0x18_cd1f, 1); pop(bx);                                  /* pop bx */
            ii(0x18_cd20, 4); test(memb[ss, bp - 0x8], 0x10);           /* test byte [bp-0x8], 0x10 */
            ii(0x18_cd24, 2); if(jz(0x18_cd41, 0x1b)) goto l_0x18_cd41; /* jz 0xcd41 */
            ii(0x18_cd26, 3); mov(ax, memw[ss, bp - 0x2]);              /* mov ax, [bp-0x2] */
            ii(0x18_cd29, 3); les(bx, memw[ss, bp + 0x4]);              /* les bx, [bp+0x4] */
            ii(0x18_cd2c, 4); cmp(memw[es, bx + 0x2], ax);              /* cmp [es:bx+0x2], ax */
            ii(0x18_cd30, 2); if(jz(0x18_cd41, 0xf)) goto l_0x18_cd41;  /* jz 0xcd41 */
            ii(0x18_cd32, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x18_cd34, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x18_cd37, 4); les(si, memw[ds, 0xaa0]);                 /* les si, [0xaa0] */
            ii(0x18_cd3b, 4); test(memb[es, bx + si], 0x1);             /* test byte [es:bx+si], 0x1 */
            ii(0x18_cd3f, 2); if(jnz(0x18_cd44, 0x3)) goto l_0x18_cd44; /* jnz 0xcd44 */
        l_0x18_cd41:
            ii(0x18_cd41, 3); jmp(0x18_ce26, 0xe2); goto l_0x18_ce26;   /* jmp 0xce26 */
        l_0x18_cd44:
            ii(0x18_cd44, 4); cmp(memw[ss, bp - 0xe], 0x10);            /* cmp word [bp-0xe], 0x10 */
            ii(0x18_cd48, 2); if(ja(0x18_cd4c, 0x2)) goto l_0x18_cd4c;  /* ja 0xcd4c */
            ii(0x18_cd4a, 2); if(jb(0x18_cdad, 0x61)) goto l_0x18_cdad; /* jb 0xcdad */
        l_0x18_cd4c:
            ii(0x18_cd4c, 3); push(memw[ss, bp - 0xc]);                 /* push word [bp-0xc] */
            ii(0x18_cd4f, 3); call(0x18_daf7, 0xda5);                   /* call 0xdaf7 */
            ii(0x18_cd52, 1); pop(bx);                                  /* pop bx */
            ii(0x18_cd53, 2); push(0);                                  /* push 0x0 */
            ii(0x18_cd55, 1); push(ax);                                 /* push ax */
            ii(0x18_cd56, 3); push(memw[ss, bp - 0xe]);                 /* push word [bp-0xe] */
            ii(0x18_cd59, 3); push(memw[ss, bp - 0x10]);                /* push word [bp-0x10] */
            ii(0x18_cd5c, 3); call(0x18_dbbc, 0xe5d);                   /* call 0xdbbc */
            ii(0x18_cd5f, 1); pop(bx);                                  /* pop bx */
            ii(0x18_cd60, 1); pop(bx);                                  /* pop bx */
            ii(0x18_cd61, 1); push(dx);                                 /* push dx */
            ii(0x18_cd62, 1); push(ax);                                 /* push ax */
            ii(0x18_cd63, 3); call(0x18_c010, -0xd56);                  /* call 0xc010 */
            ii(0x18_cd66, 3); add(sp, 0x8);                             /* add sp, 0x8 */
        l_0x18_cd69:
            ii(0x18_cd69, 3); mov(bx, memw[ss, bp - 0x2]);              /* mov bx, [bp-0x2] */
            ii(0x18_cd6c, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x18_cd6f, 4); les(si, memw[ds, 0xaa0]);                 /* les si, [0xaa0] */
            ii(0x18_cd73, 3); mov(al, memb[es, bx + si]);               /* mov al, [es:bx+si] */
            ii(0x18_cd76, 1); cbw();                                    /* cbw */
            ii(0x18_cd77, 3); mov(memw[ss, bp - 0x6], ax);              /* mov [bp-0x6], ax */
            ii(0x18_cd7a, 3); push(memw[ss, bp - 0x2]);                 /* push word [bp-0x2] */
            ii(0x18_cd7d, 3); call(0x18_dd01, 0xf81);                   /* call 0xdd01 */
            ii(0x18_cd80, 1); pop(bx);                                  /* pop bx */
            ii(0x18_cd81, 4); test(memb[ss, bp - 0x6], 0x10);           /* test byte [bp-0x6], 0x10 */
            ii(0x18_cd85, 2); if(jz(0x18_cda0, 0x19)) goto l_0x18_cda0; /* jz 0xcda0 */
            ii(0x18_cd87, 5); test(memb[ds, 0x15], 0x4);                /* test byte [0x15], 0x4 */
            ii(0x18_cd8c, 2); if(jnz(0x18_cda0, 0x12)) goto l_0x18_cda0; /* jnz 0xcda0 */
            ii(0x18_cd8e, 3); push(memw[ss, bp - 0xc]);                 /* push word [bp-0xc] */
            ii(0x18_cd91, 3); push(memw[ss, bp - 0xe]);                 /* push word [bp-0xe] */
            ii(0x18_cd94, 3); push(memw[ss, bp - 0x10]);                /* push word [bp-0x10] */
            ii(0x18_cd97, 3); push(memw[ss, bp - 0x2]);                 /* push word [bp-0x2] */
            ii(0x18_cd9a, 3); call(0x18_d619, 0x87c);                   /* call 0xd619 */
            ii(0x18_cd9d, 3); add(sp, 0x8);                             /* add sp, 0x8 */
        l_0x18_cda0:
            ii(0x18_cda0, 4); test(memb[ss, bp - 0x6], 0x2);            /* test byte [bp-0x6], 0x2 */
            ii(0x18_cda4, 2); if(jz(0x18_cdfb, 0x55)) goto l_0x18_cdfb; /* jz 0xcdfb */
            ii(0x18_cda6, 4); add(memw[ss, bp - 0x2], 0x8);             /* add word [bp-0x2], 0x8 */
            ii(0x18_cdaa, 3); jmp(0x18_cd14, -0x99); goto l_0x18_cd14;  /* jmp 0xcd14 */
        l_0x18_cdad:
            ii(0x18_cdad, 3); push(memw[ss, bp - 0xe]);                 /* push word [bp-0xe] */
            ii(0x18_cdb0, 3); push(memw[ss, bp - 0x10]);                /* push word [bp-0x10] */
            ii(0x18_cdb3, 3); call(0x18_dbbc, 0xe06);                   /* call 0xdbbc */
            ii(0x18_cdb6, 1); pop(bx);                                  /* pop bx */
            ii(0x18_cdb7, 1); pop(bx);                                  /* pop bx */
            ii(0x18_cdb8, 4); mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x18_cdbc, 3); mov(memw[ds, bx + 0x6], ax);              /* mov [bx+0x6], ax */
            ii(0x18_cdbf, 3); mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x18_cdc2, 4); mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x18_cdc6, 3); cmp(memw[ds, bx + 0x6], ax);              /* cmp [bx+0x6], ax */
            ii(0x18_cdc9, 2); if(jz(0x18_cde7, 0x1c)) goto l_0x18_cde7; /* jz 0xcde7 */
            ii(0x18_cdcb, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x18_cdce, 3); call(0x18_b0af, -0x1d22);                 /* call 0xb0af */
            ii(0x18_cdd1, 1); pop(bx);                                  /* pop bx */
            ii(0x18_cdd2, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_cdd4, 2); if(jz(0x18_cde7, 0x11)) goto l_0x18_cde7; /* jz 0xcde7 */
            ii(0x18_cdd6, 4); mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x18_cdda, 3); mov(ax, memw[ds, bx + 0x16]);             /* mov ax, [bx+0x16] */
            ii(0x18_cddd, 3); les(bx, memw[ss, bp + 0x4]);              /* les bx, [bp+0x4] */
            ii(0x18_cde0, 4); mov(memw[es, bx + 0x16], ax);             /* mov [es:bx+0x16], ax */
            ii(0x18_cde4, 1); pop(si);                                  /* pop si */
            ii(0x18_cde5, 1); leave();                                  /* leave */
            ii(0x18_cde6, 1); ret(); return;                            /* ret */
        l_0x18_cde7:
            ii(0x18_cde7, 3); push(memw[ss, bp - 0xc]);                 /* push word [bp-0xc] */
            ii(0x18_cdea, 3); call(0x18_daf7, 0xd0a);                   /* call 0xdaf7 */
            ii(0x18_cded, 1); pop(bx);                                  /* pop bx */
            ii(0x18_cdee, 4); mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x18_cdf2, 3); add(ax, memw[ds, bx + 0x6]);              /* add ax, [bx+0x6] */
            ii(0x18_cdf5, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x18_cdf8, 3); jmp(0x18_cd69, -0x92); goto l_0x18_cd69;  /* jmp 0xcd69 */
        l_0x18_cdfb:
            ii(0x18_cdfb, 3); les(bx, memw[ss, bp + 0x4]);              /* les bx, [bp+0x4] */
            ii(0x18_cdfe, 5); and(memb[es, bx + 0x26], -0x2 /* 0xfe */); /* and byte [es:bx+0x26], 0xfe */
            ii(0x18_ce03, 4); mov(ax, memw[es, bx + 0x6]);              /* mov ax, [es:bx+0x6] */
            ii(0x18_ce07, 4); mov(memw[es, bx + 0x16], ax);             /* mov [es:bx+0x16], ax */
            ii(0x18_ce0b, 6); mov(memw[es, bx + 0x6], 0);               /* mov word [es:bx+0x6], 0x0 */
            ii(0x18_ce11, 3); mov(ax, memw[ds, 0x38]);                  /* mov ax, [0x38] */
            ii(0x18_ce14, 4); cmp(memw[es, bx + 0x4], ax);              /* cmp [es:bx+0x4], ax */
            ii(0x18_ce18, 2); if(jnz(0x18_ce20, 0x6)) goto l_0x18_ce20; /* jnz 0xce20 */
            ii(0x18_ce1a, 6); mov(memw[es, bx + 0x4], 0);               /* mov word [es:bx+0x4], 0x0 */
        l_0x18_ce20:
            ii(0x18_ce20, 2); push(0x1);                                /* push 0x1 */
            ii(0x18_ce22, 3); call(0x18_a5a9, -0x287c);                 /* call 0xa5a9 */
            ii(0x18_ce25, 1); pop(bx);                                  /* pop bx */
        l_0x18_ce26:
            ii(0x18_ce26, 1); pop(si);                                  /* pop si */
            ii(0x18_ce27, 1); leave();                                  /* leave */
            ii(0x18_ce28, 1); ret();                                    /* ret */
        }
    }
}
