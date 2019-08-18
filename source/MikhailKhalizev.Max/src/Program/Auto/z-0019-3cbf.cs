using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ab8e0b1d-2223-4895-a968-b61775dbf70b")]
        public void Method_0019_3cbf()
        {
            ii(0x19_3cbf, 1); pushw(bp);                                /* push bp */
            ii(0x19_3cc0, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_3cc2, 1); pushw(si);                                /* push si */
            ii(0x19_3cc3, 1); pushw(di);                                /* push di */
            ii(0x19_3cc4, 3); mov(cx, memw_a16[ss, bp + 0x6]);          /* mov cx, [bp+0x6] */
            ii(0x19_3cc7, 3); cmp(cx, -0x18 /* 0xe8 */);                /* cmp cx, 0xffe8 */
            ii(0x19_3cca, 2); if(jaw(0x19_3d35, 0x69)) goto l_0x19_3d35; /* ja 0x3d35 */
            ii(0x19_3ccc, 1); pushw(ds);                                /* push ds */
            ii(0x19_3ccd, 3); mov(ax, memw_a16[ds, 0x3f58]);            /* mov ax, [0x3f58] */
            ii(0x19_3cd0, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_3cd2, 2); if(jzw(0x19_3d1c, 0x48)) goto l_0x19_3d1c; /* jz 0x3d1c */
            ii(0x19_3cd4, 3); mov(di, 0x4a9a);                          /* mov di, 0x4a9a */
        l_0x19_3cd7:
            ii(0x19_3cd7, 4); mov(si, memw_a16[ds, 0x3f60]);            /* mov si, [0x3f60] */
            ii(0x19_3cdb, 4); lds(bx, ds, 0x3f5a);                      /* lds bx, [0x3f5a] */
        l_0x19_3cdf:
            ii(0x19_3cdf, 1); pushw(ds);                                /* push ds */
        l_0x19_3ce0:
            ii(0x19_3ce0, 1); pushw(si);                                /* push si */
            ii(0x19_3ce1, 1); pushw(di);                                /* push di */
            ii(0x19_3ce2, 2); callw_abs(di);                            /* call di */
            ii(0x19_3ce4, 1); popw(di);                                 /* pop di */
            ii(0x19_3ce5, 1); popw(si);                                 /* pop si */
            ii(0x19_3ce6, 2); if(jaew(0x19_3d13, 0x2b)) goto l_0x19_3d13; /* jae 0x3d13 */
            ii(0x19_3ce8, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x19_3cea, 3); lds(bx, ds, bx + 0xc);                    /* lds bx, [bx+0xc] */
            ii(0x19_3ced, 2); cmp(dx, si);                              /* cmp dx, si */
            ii(0x19_3cef, 2); if(jnzw(0x19_3ce0, -0x11)) goto l_0x19_3ce0; /* jnz 0x3ce0 */
            ii(0x19_3cf1, 1); popw(ax);                                 /* pop ax */
            ii(0x19_3cf2, 1); popw(ds);                                 /* pop ds */
            ii(0x19_3cf3, 1); pushw(ds);                                /* push ds */
            ii(0x19_3cf4, 4); les(si, ds, 0x3f5a);                      /* les si, [0x3f5a] */
            ii(0x19_3cf8, 4); mov(si, memw_a16[es, si + 0x12]);         /* mov si, [es:si+0x12] */
            ii(0x19_3cfc, 4); lds(bx, ds, 0x3f56);                      /* lds bx, [0x3f56] */
            ii(0x19_3d00, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x19_3d02, 2); cmp(dx, ax);                              /* cmp dx, ax */
            ii(0x19_3d04, 2); if(jnzw(0x19_3cdf, -0x27)) goto l_0x19_3cdf; /* jnz 0x3cdf */
            ii(0x19_3d06, 1); popw(ds);                                 /* pop ds */
            ii(0x19_3d07, 1); pushw(ds);                                /* push ds */
            ii(0x19_3d08, 4); cmp(di, 0x48ac);                          /* cmp di, 0x48ac */
            ii(0x19_3d0c, 2); if(jzw(0x19_3d1c, 0xe)) goto l_0x19_3d1c; /* jz 0x3d1c */
            ii(0x19_3d0e, 3); mov(di, 0x48ac);                          /* mov di, 0x48ac */
            ii(0x19_3d11, 2); jmpw(0x19_3cd7, -0x3c); goto l_0x19_3cd7; /* jmp 0x3cd7 */
        l_0x19_3d13:
            ii(0x19_3d13, 1); popw(si);                                 /* pop si */
            ii(0x19_3d14, 4); cmp(di, 0x4a9a);                          /* cmp di, 0x4a9a */
            ii(0x19_3d18, 2); if(jzw(0x19_3d29, 0xf)) goto l_0x19_3d29; /* jz 0x3d29 */
            ii(0x19_3d1a, 2); jmpw(0x19_3d26, 0xa); goto l_0x19_3d26;   /* jmp 0x3d26 */
        l_0x19_3d1c:
            ii(0x19_3d1c, 1); popw(es);                                 /* pop es */
            ii(0x19_3d1d, 1); pushw(es);                                /* push es */
            ii(0x19_3d1e, 3); mov(di, 0x3f56);                          /* mov di, 0x3f56 */
            ii(0x19_3d21, 3); callw(0x19_3fa6, 0x282);                  /* call 0x3fa6 */
            ii(0x19_3d24, 2); if(jbw(0x19_3d34, 0xe)) goto l_0x19_3d34; /* jb 0x3d34 */
        l_0x19_3d26:
            ii(0x19_3d26, 3); callw(0x19_3f2a, 0x201);                  /* call 0x3f2a */
        l_0x19_3d29:
            ii(0x19_3d29, 1); popw(ds);                                 /* pop ds */
            ii(0x19_3d2a, 4); mov(memw_a16[ds, 0x3f5c], dx);            /* mov [0x3f5c], dx */
            ii(0x19_3d2e, 4); mov(memw_a16[ds, 0x3f5a], bx);            /* mov [0x3f5a], bx */
            ii(0x19_3d32, 2); jmpw(0x19_3d38, 0x4); goto l_0x19_3d38;   /* jmp 0x3d38 */
        l_0x19_3d34:
            ii(0x19_3d34, 1); popw(ds);                                 /* pop ds */
        l_0x19_3d35:
            ii(0x19_3d35, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_3d37, 1); cwd();                                    /* cwd */
        l_0x19_3d38:
            ii(0x19_3d38, 1); popw(di);                                 /* pop di */
            ii(0x19_3d39, 1); popw(si);                                 /* pop si */
            ii(0x19_3d3a, 1); popw(bp);                                 /* pop bp */
            ii(0x19_3d3b, 1); retfw(); return;                          /* retf */
        }
    }
}
