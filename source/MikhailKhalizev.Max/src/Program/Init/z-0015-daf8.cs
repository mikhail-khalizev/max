using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("387bf49c-7d53-47c9-8a24-72f9279020f0")]
        public void Method_0015_daf8()
        {
            ii(0x15_daf8, 4); enterw(0xc, 0);                           /* enter 0xc, 0x0 */
            ii(0x15_dafc, 1); pushw(di);                                /* push di */
            ii(0x15_dafd, 1); pushw(si);                                /* push si */
            ii(0x15_dafe, 4); mov(es, memw_a16[ds, 0x3fc6]);            /* mov es, [0x3fc6] */
            ii(0x15_db02, 4); mov(ax, memw_a16[es, 0x3b7c]);            /* mov ax, [es:0x3b7c] */
            ii(0x15_db06, 5); mov(memw_a16[ss, bp - 0x8], 0);           /* mov word [bp-0x8], 0x0 */
            ii(0x15_db0b, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x15_db0e, 5); cmp(memb_a16[ds, 0x2b9e], 0);             /* cmp byte [0x2b9e], 0x0 */
            ii(0x15_db13, 2); if(jzw(0x15_db1e, 0x9)) goto l_0x15_db1e; /* jz 0xdb1e */
        l_0x15_db15:
            ii(0x15_db15, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_db18, 3); jmpw(0x15_dc73, 0x158); goto l_0x15_dc73; /* jmp 0xdc73 */
        l_0x15_db1b:
            ii(0x15_db1b, 3); inc(memw_a16[ss, bp - 0x8]);              /* inc word [bp-0x8] */
        l_0x15_db1e:
            ii(0x15_db1e, 3); les(bx, ss, bp - 0x8);                    /* les bx, [bp-0x8] */
            ii(0x15_db21, 4); cmp(memw_a16[es, bx], 0);                 /* cmp word [es:bx], 0x0 */
            ii(0x15_db25, 2); if(jnzw(0x15_db1b, -0xc)) goto l_0x15_db1b; /* jnz 0xdb1b */
            ii(0x15_db27, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x15_db29, 1); inc(ax);                                  /* inc ax */
            ii(0x15_db2a, 1); inc(ax);                                  /* inc ax */
            ii(0x15_db2b, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x15_db2e, 5); mov(memw_a16[ss, bp - 0x8], 0);           /* mov word [bp-0x8], 0x0 */
            ii(0x15_db33, 3); add(ax, 0x4a6);                           /* add ax, 0x4a6 */
            ii(0x15_db36, 1); pushw(ds);                                /* push ds */
            ii(0x15_db37, 3); pushw(0x2be6);                            /* push 0x2be6 */
            ii(0x15_db3a, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_db3c, 1); pushw(dx);                                /* push dx */
            ii(0x15_db3d, 1); pushw(ax);                                /* push ax */
            ii(0x15_db3e, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x15_db40, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x15_db42, 1); nop();                                    /* nop */
            ii(0x15_db43, 1); pushw(cs);                                /* push cs */
            ii(0x15_db44, 3); callw(0x15_d52d, -0x61a);                 /* call 0xd52d */
            ii(0x15_db47, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_db4a, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_db4d, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x15_db50, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_db52, 2); if(jnzw(0x15_db57, 0x3)) goto l_0x15_db57; /* jnz 0xdb57 */
            ii(0x15_db54, 3); jmpw(0x15_dc71, 0x11a); goto l_0x15_dc71; /* jmp 0xdc71 */
        l_0x15_db57:
            ii(0x15_db57, 4); pushw(memw_a16[ds, 0x2b9c]);              /* push word [0x2b9c] */
            ii(0x15_db5b, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x15_db5e, 1); pushw(ax);                                /* push ax */
            ii(0x15_db5f, 1); pushw(di);                                /* push di */
            ii(0x15_db60, 1); pushw(si);                                /* push si */
            ii(0x15_db61, 3); pushw(0x92);                              /* push 0x92 */
            ii(0x15_db64, 3); callw(0x15_cc1a, -0xf4d);                 /* call 0xcc1a */
            ii(0x15_db67, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x15_db6a, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x15_db6d, 1); pushw(di);                                /* push di */
            ii(0x15_db6e, 1); pushw(si);                                /* push si */
            ii(0x15_db6f, 3); callw(0x15_fb9f, 0x202d);                 /* call 0xfb9f */
            ii(0x15_db72, 3); mov(ax, memw_a16[ds, 0x2b9c]);            /* mov ax, [0x2b9c] */
            ii(0x15_db75, 4); les(bx, ds, 0x2b9a);                      /* les bx, [0x2b9a] */
            ii(0x15_db79, 5); mov(memw_a16[es, bx + 0x244], ax);        /* mov [es:bx+0x244], ax */
            ii(0x15_db7e, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_db80, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x15_db84, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x15_db87, 4); mov(memw_a16[es, bx + 0x6], ax);          /* mov [es:bx+0x6], ax */
            ii(0x15_db8b, 4); mov(memw_a16[es, bx + 0x4], ax);          /* mov [es:bx+0x4], ax */
            ii(0x15_db8f, 4); mov(memw_a16[es, bx + 0xa], ax);          /* mov [es:bx+0xa], ax */
            ii(0x15_db93, 4); mov(memw_a16[es, bx + 0x8], ax);          /* mov [es:bx+0x8], ax */
            ii(0x15_db97, 3); lea(ax, bx + 0x18);                       /* lea ax, [bx+0x18] */
            ii(0x15_db9a, 1); pushw(es);                                /* push es */
            ii(0x15_db9b, 1); pushw(ax);                                /* push ax */
            ii(0x15_db9c, 3); callw(0x15_d9f4, -0x1ab);                 /* call 0xd9f4 */
            ii(0x15_db9f, 4); les(bx, ds, 0x2b9a);                      /* les bx, [0x2b9a] */
            ii(0x15_dba3, 4); mov(memw_a16[es, bx + 0xc], ax);          /* mov [es:bx+0xc], ax */
            ii(0x15_dba7, 4); mov(memw_a16[es, bx + 0xe], dx);          /* mov [es:bx+0xe], dx */
            ii(0x15_dbab, 4); les(bx, ds, 0x2b9a);                      /* les bx, [0x2b9a] */
            ii(0x15_dbaf, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_dbb1, 4); mov(memw_a16[es, bx + 0x12], ax);         /* mov [es:bx+0x12], ax */
            ii(0x15_dbb5, 4); mov(memw_a16[es, bx + 0x10], ax);         /* mov [es:bx+0x10], ax */
            ii(0x15_dbb9, 6); mov(memw_a16[es, bx + 0x1c], 0xa);        /* mov word [es:bx+0x1c], 0xa */
            ii(0x15_dbbf, 4); mov(memw_a16[es, bx + 0x1e], ax);         /* mov [es:bx+0x1e], ax */
            ii(0x15_dbc3, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_dbc6, 1); cwd();                                    /* cwd */
            ii(0x15_dbc7, 4); mov(memw_a16[es, bx + 0x14], ax);         /* mov [es:bx+0x14], ax */
            ii(0x15_dbcb, 4); mov(memw_a16[es, bx + 0x16], dx);         /* mov [es:bx+0x16], dx */
            ii(0x15_dbcf, 4); mov(memw_a16[es, bx + 0x18], ax);         /* mov [es:bx+0x18], ax */
            ii(0x15_dbd3, 4); mov(memw_a16[es, bx + 0x1a], dx);         /* mov [es:bx+0x1a], dx */
            ii(0x15_dbd7, 4); mov(memw_a16[es, bx + 0x20], ax);         /* mov [es:bx+0x20], ax */
            ii(0x15_dbdb, 4); mov(memw_a16[es, bx + 0x22], dx);         /* mov [es:bx+0x22], dx */
            ii(0x15_dbdf, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_dbe1, 4); mov(memw_a16[es, bx + 0x24], ax);         /* mov [es:bx+0x24], ax */
            ii(0x15_dbe5, 4); mov(memw_a16[es, bx + 0x26], ax);         /* mov [es:bx+0x26], ax */
            ii(0x15_dbe9, 3); mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0x15_dbec, 3); mov(dx, memw_a16[ss, bp - 0xa]);          /* mov dx, [bp-0xa] */
            ii(0x15_dbef, 3); add(ax, 0x2a2);                           /* add ax, 0x2a2 */
            ii(0x15_dbf2, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x15_dbf5, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_dbf8, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x15_dbfb, 4); sub(ax, memw_a16[ds, 0x19ea]);            /* sub ax, [0x19ea] */
            ii(0x15_dbff, 4); sbb(dx, memw_a16[ds, 0x19ec]);            /* sbb dx, [0x19ec] */
            ii(0x15_dc03, 4); mov(memw_a16[es, bx + 0x38], ax);         /* mov [es:bx+0x38], ax */
            ii(0x15_dc07, 4); mov(memw_a16[es, bx + 0x3a], dx);         /* mov [es:bx+0x3a], dx */
            ii(0x15_dc0b, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x15_dc0e, 3); add(ax, 0x3);                             /* add ax, 0x3 */
            ii(0x15_dc11, 2); and(al, 0xfc);                            /* and al, 0xfc */
            ii(0x15_dc13, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_dc15, 3); add(memw_a16[ss, bp - 0xc], ax);          /* add [bp-0xc], ax */
            ii(0x15_dc18, 3); adc(memw_a16[ss, bp - 0xa], dx);          /* adc [bp-0xa], dx */
            ii(0x15_dc1b, 3); mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0x15_dc1e, 3); mov(dx, memw_a16[ss, bp - 0xa]);          /* mov dx, [bp-0xa] */
            ii(0x15_dc21, 4); sub(ax, memw_a16[ds, 0x19ea]);            /* sub ax, [0x19ea] */
            ii(0x15_dc25, 4); sbb(dx, memw_a16[ds, 0x19ec]);            /* sbb dx, [0x19ec] */
            ii(0x15_dc29, 4); mov(memw_a16[es, bx + 0x34], ax);         /* mov [es:bx+0x34], ax */
            ii(0x15_dc2d, 4); mov(memw_a16[es, bx + 0x36], dx);         /* mov [es:bx+0x36], dx */
            ii(0x15_dc31, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_dc34, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x15_dc37, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x15_dc3a, 4); lea(ax, bx + 0x2a2);                      /* lea ax, [bx+0x2a2] */
            ii(0x15_dc3e, 1); pushw(es);                                /* push es */
            ii(0x15_dc3f, 1); pushw(ax);                                /* push ax */
            ii(0x15_dc40, 1); nop();                                    /* nop */
            ii(0x15_dc41, 1); pushw(cs);                                /* push cs */
            ii(0x15_dc42, 3); callw(0x16_0f5f, 0x331a);                 /* call 0xf5f */
            ii(0x15_dc45, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x15_dc48, 2); pushw(0x5a);                              /* push 0x5a */
            ii(0x15_dc4a, 4); mov(es, memw_a16[ds, 0x3fc6]);            /* mov es, [0x3fc6] */
            ii(0x15_dc4e, 4); mov(ax, memw_a16[es, 0x3b78]);            /* mov ax, [es:0x3b78] */
            ii(0x15_dc52, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x15_dc54, 1); pushw(ax);                                /* push ax */
            ii(0x15_dc55, 1); pushw(cx);                                /* push cx */
            ii(0x15_dc56, 3); mov(ax, memw_a16[ds, 0x2b9a]);            /* mov ax, [0x2b9a] */
            ii(0x15_dc59, 4); mov(dx, memw_a16[ds, 0x2b9c]);            /* mov dx, [0x2b9c] */
            ii(0x15_dc5d, 3); add(ax, 0x248);                           /* add ax, 0x248 */
            ii(0x15_dc60, 1); pushw(dx);                                /* push dx */
            ii(0x15_dc61, 1); pushw(ax);                                /* push ax */
            ii(0x15_dc62, 1); nop();                                    /* nop */
            ii(0x15_dc63, 1); pushw(cs);                                /* push cs */
            ii(0x15_dc64, 3); callw(0x16_0f5f, 0x32f8);                 /* call 0xf5f */
            ii(0x15_dc67, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x15_dc6a, 4); inc(memb_a16[ds, 0x2b9e]);                /* inc byte [0x2b9e] */
            ii(0x15_dc6e, 3); jmpw(0x15_db15, -0x15c); goto l_0x15_db15; /* jmp 0xdb15 */
        l_0x15_dc71:
            ii(0x15_dc71, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x15_dc73:
            ii(0x15_dc73, 1); popw(si);                                 /* pop si */
            ii(0x15_dc74, 1); popw(di);                                 /* pop di */
            ii(0x15_dc75, 1); leavew();                                 /* leave */
            ii(0x15_dc76, 1); retfw(); return;                          /* retf */
        }
    }
}
