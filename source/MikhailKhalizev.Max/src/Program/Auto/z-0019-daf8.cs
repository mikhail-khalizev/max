using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_daf8-1dec7ca8")]
        public void Method_0019_daf8()
        {
            ii(0x19_daf8, 4); enter(0xc, 0);                            /* enter 0xc, 0x0 */
            ii(0x19_dafc, 1); push(di);                                 /* push di */
            ii(0x19_dafd, 1); push(si);                                 /* push si */
            ii(0x19_dafe, 4); mov(es, memw[ds, 0x3fc6]);                /* mov es, [0x3fc6] */
            ii(0x19_db02, 4); mov(ax, memw[es, 0x3b7c]);                /* mov ax, [es:0x3b7c] */
            ii(0x19_db06, 5); mov(memw[ss, bp - 8], 0);                 /* mov word [bp-0x8], 0x0 */
            ii(0x19_db0b, 3); mov(memw[ss, bp - 6], ax);                /* mov [bp-0x6], ax */
            ii(0x19_db0e, 5); cmp(memb[ds, 0x2b9e], 0);                 /* cmp byte [0x2b9e], 0x0 */
            ii(0x19_db13, 2); if(jz(0x19_db1e, 9)) goto l_0x19_db1e;    /* jz 0xdb1e */
        l_0x19_db15:
            ii(0x19_db15, 3); mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x19_db18, 3); jmp(0x19_dc73, 0x158); goto l_0x19_dc73;  /* jmp 0xdc73 */
        l_0x19_db1b:
            ii(0x19_db1b, 3); inc(memw[ss, bp - 8]);                    /* inc word [bp-0x8] */
        l_0x19_db1e:
            ii(0x19_db1e, 3); les(bx, memw[ss, bp - 8]);                /* les bx, [bp-0x8] */
            ii(0x19_db21, 4); cmp(memw[es, bx], 0);                     /* cmp word [es:bx], 0x0 */
            ii(0x19_db25, 2); if(jnz(0x19_db1b, -0xc)) goto l_0x19_db1b; /* jnz 0xdb1b */
            ii(0x19_db27, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x19_db29, 1); inc(ax);                                  /* inc ax */
            ii(0x19_db2a, 1); inc(ax);                                  /* inc ax */
            ii(0x19_db2b, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x19_db2e, 5); mov(memw[ss, bp - 8], 0);                 /* mov word [bp-0x8], 0x0 */
            ii(0x19_db33, 3); add(ax, 0x4a6);                           /* add ax, 0x4a6 */
            ii(0x19_db36, 1); push(ds);                                 /* push ds */
            ii(0x19_db37, 3); push(0x2be6);                             /* push 0x2be6 */
            ii(0x19_db3a, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x19_db3c, 1); push(dx);                                 /* push dx */
            ii(0x19_db3d, 1); push(ax);                                 /* push ax */
            ii(0x19_db3e, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x19_db40, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x19_db42, 1); nop();                                    /* nop */
            ii(0x19_db43, 1); push(cs);                                 /* push cs */
            ii(0x19_db44, 3); call(0x19_d52d, -0x61a);                  /* call 0xd52d */
            ii(0x19_db47, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_db4a, 3); mov(memw[ss, bp - 0xc], ax);              /* mov [bp-0xc], ax */
            ii(0x19_db4d, 3); mov(memw[ss, bp - 0xa], dx);              /* mov [bp-0xa], dx */
            ii(0x19_db50, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_db52, 2); if(jnz(0x19_db57, 3)) goto l_0x19_db57;   /* jnz 0xdb57 */
            ii(0x19_db54, 3); jmp(0x19_dc71, 0x11a); goto l_0x19_dc71;  /* jmp 0xdc71 */
        l_0x19_db57:
            ii(0x19_db57, 4); push(memw[ds, 0x2b9c]);                   /* push word [0x2b9c] */
            ii(0x19_db5b, 3); push(memw[ss, bp - 0xa]);                 /* push word [bp-0xa] */
            ii(0x19_db5e, 1); push(ax);                                 /* push ax */
            ii(0x19_db5f, 1); push(di);                                 /* push di */
            ii(0x19_db60, 1); push(si);                                 /* push si */
            ii(0x19_db61, 3); push(0x92);                               /* push 0x92 */
            ii(0x19_db64, 3); call(0x19_cc1a, -0xf4d);                  /* call 0xcc1a */
            ii(0x19_db67, 3); push(memw[ss, bp - 0xa]);                 /* push word [bp-0xa] */
            ii(0x19_db6a, 3); push(memw[ss, bp - 0xc]);                 /* push word [bp-0xc] */
            ii(0x19_db6d, 1); push(di);                                 /* push di */
            ii(0x19_db6e, 1); push(si);                                 /* push si */
            ii(0x19_db6f, 3); call(0x19_fb9f, 0x202d);                  /* call 0xfb9f */
            ii(0x19_db72, 3); mov(ax, memw[ds, 0x2b9c]);                /* mov ax, [0x2b9c] */
            ii(0x19_db75, 4); les(bx, memw[ds, 0x2b9a]);                /* les bx, [0x2b9a] */
            ii(0x19_db79, 5); mov(memw[es, bx + 0x244], ax);            /* mov [es:bx+0x244], ax */
            ii(0x19_db7e, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_db80, 4); mov(memw[es, bx + 2], ax);                /* mov [es:bx+0x2], ax */
            ii(0x19_db84, 3); mov(memw[es, bx], ax);                    /* mov [es:bx], ax */
            ii(0x19_db87, 4); mov(memw[es, bx + 6], ax);                /* mov [es:bx+0x6], ax */
            ii(0x19_db8b, 4); mov(memw[es, bx + 4], ax);                /* mov [es:bx+0x4], ax */
            ii(0x19_db8f, 4); mov(memw[es, bx + 0xa], ax);              /* mov [es:bx+0xa], ax */
            ii(0x19_db93, 4); mov(memw[es, bx + 8], ax);                /* mov [es:bx+0x8], ax */
            ii(0x19_db97, 3); lea(ax, memw[ds, bx + 0x18]);             /* lea ax, [bx+0x18] */
            ii(0x19_db9a, 1); push(es);                                 /* push es */
            ii(0x19_db9b, 1); push(ax);                                 /* push ax */
            ii(0x19_db9c, 3); call(0x19_d9f4, -0x1ab);                  /* call 0xd9f4 */
            ii(0x19_db9f, 4); les(bx, memw[ds, 0x2b9a]);                /* les bx, [0x2b9a] */
            ii(0x19_dba3, 4); mov(memw[es, bx + 0xc], ax);              /* mov [es:bx+0xc], ax */
            ii(0x19_dba7, 4); mov(memw[es, bx + 0xe], dx);              /* mov [es:bx+0xe], dx */
            ii(0x19_dbab, 4); les(bx, memw[ds, 0x2b9a]);                /* les bx, [0x2b9a] */
            ii(0x19_dbaf, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_dbb1, 4); mov(memw[es, bx + 0x12], ax);             /* mov [es:bx+0x12], ax */
            ii(0x19_dbb5, 4); mov(memw[es, bx + 0x10], ax);             /* mov [es:bx+0x10], ax */
            ii(0x19_dbb9, 6); mov(memw[es, bx + 0x1c], 0xa);            /* mov word [es:bx+0x1c], 0xa */
            ii(0x19_dbbf, 4); mov(memw[es, bx + 0x1e], ax);             /* mov [es:bx+0x1e], ax */
            ii(0x19_dbc3, 3); mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x19_dbc6, 1); cwd();                                    /* cwd */
            ii(0x19_dbc7, 4); mov(memw[es, bx + 0x14], ax);             /* mov [es:bx+0x14], ax */
            ii(0x19_dbcb, 4); mov(memw[es, bx + 0x16], dx);             /* mov [es:bx+0x16], dx */
            ii(0x19_dbcf, 4); mov(memw[es, bx + 0x18], ax);             /* mov [es:bx+0x18], ax */
            ii(0x19_dbd3, 4); mov(memw[es, bx + 0x1a], dx);             /* mov [es:bx+0x1a], dx */
            ii(0x19_dbd7, 4); mov(memw[es, bx + 0x20], ax);             /* mov [es:bx+0x20], ax */
            ii(0x19_dbdb, 4); mov(memw[es, bx + 0x22], dx);             /* mov [es:bx+0x22], dx */
            ii(0x19_dbdf, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_dbe1, 4); mov(memw[es, bx + 0x24], ax);             /* mov [es:bx+0x24], ax */
            ii(0x19_dbe5, 4); mov(memw[es, bx + 0x26], ax);             /* mov [es:bx+0x26], ax */
            ii(0x19_dbe9, 3); mov(ax, memw[ss, bp - 0xc]);              /* mov ax, [bp-0xc] */
            ii(0x19_dbec, 3); mov(dx, memw[ss, bp - 0xa]);              /* mov dx, [bp-0xa] */
            ii(0x19_dbef, 3); add(ax, 0x2a2);                           /* add ax, 0x2a2 */
            ii(0x19_dbf2, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x19_dbf5, 3); mov(memw[ss, bp - 0xc], ax);              /* mov [bp-0xc], ax */
            ii(0x19_dbf8, 3); mov(memw[ss, bp - 0xa], dx);              /* mov [bp-0xa], dx */
            ii(0x19_dbfb, 4); sub(ax, memw[ds, 0x19ea]);                /* sub ax, [0x19ea] */
            ii(0x19_dbff, 4); sbb(dx, memw[ds, 0x19ec]);                /* sbb dx, [0x19ec] */
            ii(0x19_dc03, 4); mov(memw[es, bx + 0x38], ax);             /* mov [es:bx+0x38], ax */
            ii(0x19_dc07, 4); mov(memw[es, bx + 0x3a], dx);             /* mov [es:bx+0x3a], dx */
            ii(0x19_dc0b, 3); mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x19_dc0e, 3); add(ax, 3);                               /* add ax, 0x3 */
            ii(0x19_dc11, 2); and(al, 0xfc);                            /* and al, 0xfc */
            ii(0x19_dc13, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x19_dc15, 3); add(memw[ss, bp - 0xc], ax);              /* add [bp-0xc], ax */
            ii(0x19_dc18, 3); adc(memw[ss, bp - 0xa], dx);              /* adc [bp-0xa], dx */
            ii(0x19_dc1b, 3); mov(ax, memw[ss, bp - 0xc]);              /* mov ax, [bp-0xc] */
            ii(0x19_dc1e, 3); mov(dx, memw[ss, bp - 0xa]);              /* mov dx, [bp-0xa] */
            ii(0x19_dc21, 4); sub(ax, memw[ds, 0x19ea]);                /* sub ax, [0x19ea] */
            ii(0x19_dc25, 4); sbb(dx, memw[ds, 0x19ec]);                /* sbb dx, [0x19ec] */
            ii(0x19_dc29, 4); mov(memw[es, bx + 0x34], ax);             /* mov [es:bx+0x34], ax */
            ii(0x19_dc2d, 4); mov(memw[es, bx + 0x36], dx);             /* mov [es:bx+0x36], dx */
            ii(0x19_dc31, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x19_dc34, 3); push(memw[ss, bp - 6]);                   /* push word [bp-0x6] */
            ii(0x19_dc37, 3); push(memw[ss, bp - 8]);                   /* push word [bp-0x8] */
            ii(0x19_dc3a, 4); lea(ax, memw[ds, bx + 0x2a2]);            /* lea ax, [bx+0x2a2] */
            ii(0x19_dc3e, 1); push(es);                                 /* push es */
            ii(0x19_dc3f, 1); push(ax);                                 /* push ax */
            ii(0x19_dc40, 1); nop();                                    /* nop */
            ii(0x19_dc41, 1); push(cs);                                 /* push cs */
            ii(0x19_dc42, 3); call(0x1a_0f5f, 0x331a);                  /* call 0xf5f */
            ii(0x19_dc45, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_dc48, 2); push(0x5a);                               /* push 0x5a */
            ii(0x19_dc4a, 4); mov(es, memw[ds, 0x3fc6]);                /* mov es, [0x3fc6] */
            ii(0x19_dc4e, 4); mov(ax, memw[es, 0x3b78]);                /* mov ax, [es:0x3b78] */
            ii(0x19_dc52, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x19_dc54, 1); push(ax);                                 /* push ax */
            ii(0x19_dc55, 1); push(cx);                                 /* push cx */
            ii(0x19_dc56, 3); mov(ax, memw[ds, 0x2b9a]);                /* mov ax, [0x2b9a] */
            ii(0x19_dc59, 4); mov(dx, memw[ds, 0x2b9c]);                /* mov dx, [0x2b9c] */
            ii(0x19_dc5d, 3); add(ax, 0x248);                           /* add ax, 0x248 */
            ii(0x19_dc60, 1); push(dx);                                 /* push dx */
            ii(0x19_dc61, 1); push(ax);                                 /* push ax */
            ii(0x19_dc62, 1); nop();                                    /* nop */
            ii(0x19_dc63, 1); push(cs);                                 /* push cs */
            ii(0x19_dc64, 3); call(0x1a_0f5f, 0x32f8);                  /* call 0xf5f */
            ii(0x19_dc67, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_dc6a, 4); inc(memb[ds, 0x2b9e]);                    /* inc byte [0x2b9e] */
            ii(0x19_dc6e, 3); jmp(0x19_db15, -0x15c); goto l_0x19_db15; /* jmp 0xdb15 */
        l_0x19_dc71:
            ii(0x19_dc71, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_dc73:
            ii(0x19_dc73, 1); pop(si);                                  /* pop si */
            ii(0x19_dc74, 1); pop(di);                                  /* pop di */
            ii(0x19_dc75, 1); leave();                                  /* leave */
            ii(0x19_dc76, 1); retf();                                   /* retf */
        }
    }
}
