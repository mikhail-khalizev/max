using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_7bea-9651e79c")]
        public void Method_0017_7bea()
        {
            ii(0x17_7bea, 4); enter(0xa, 0);                            /* enter 0xa, 0x0 */
            ii(0x17_7bee, 1); push(di);                                 /* push di */
            ii(0x17_7bef, 1); push(si);                                 /* push si */
            ii(0x17_7bf0, 1); push(ds);                                 /* push ds */
            ii(0x17_7bf1, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_7bf4, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_7bf6, 3); mov(bx, memw[ss, bp + 6]);                /* mov bx, [bp+0x6] */
            ii(0x17_7bf9, 3); shl(bx, 2);                               /* shl bx, 0x2 */
            ii(0x17_7bfc, 4); les(si, memw[ds, 0x4fa0]);                /* les si, [0x4fa0] */
            ii(0x17_7c00, 3); mov(ax, memw[es, bx + si]);               /* mov ax, [es:bx+si] */
            ii(0x17_7c03, 4); mov(dx, memw[es, bx + si + 2]);           /* mov dx, [es:bx+si+0x2] */
            ii(0x17_7c07, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x17_7c0a, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x17_7c0d, 4); les(si, memw[ds, 0x4fa4]);                /* les si, [0x4fa4] */
            ii(0x17_7c11, 3); mov(ax, memw[es, bx + si]);               /* mov ax, [es:bx+si] */
            ii(0x17_7c14, 4); mov(dx, memw[es, bx + si + 2]);           /* mov dx, [es:bx+si+0x2] */
            ii(0x17_7c18, 3); mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0x17_7c1b, 3); mov(memw[ss, bp - 6], dx);                /* mov [bp-0x6], dx */
            ii(0x17_7c1e, 5); cmp(memw[ds, 0x984], 0);                  /* cmp word [0x984], 0x0 */
            ii(0x17_7c23, 2); if(jz(0x17_7c75, 0x50)) goto l_0x17_7c75; /* jz 0x7c75 */
            ii(0x17_7c25, 4); les(bx, memw[ds, 0x4fc4]);                /* les bx, [0x4fc4] */
            ii(0x17_7c29, 4); mov(memb[es, bx], 0x21);                  /* mov byte [es:bx], 0x21 */
            ii(0x17_7c2d, 3); mov(al, memb[ds, 0x5130]);                /* mov al, [0x5130] */
            ii(0x17_7c30, 4); les(bx, memw[ds, 0x4fc4]);                /* les bx, [0x4fc4] */
            ii(0x17_7c34, 4); mov(memb[es, bx + 1], al);                /* mov [es:bx+0x1], al */
            ii(0x17_7c38, 3); mov(ax, memw[ss, bp - 8]);                /* mov ax, [bp-0x8] */
            ii(0x17_7c3b, 3); mov(dx, memw[ss, bp - 6]);                /* mov dx, [bp-0x6] */
            ii(0x17_7c3e, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_7c40, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_7c42, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_7c44, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_7c46, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_7c48, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_7c4a, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_7c4c, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_7c4e, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_7c50, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_7c52, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_7c54, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_7c56, 4); les(bx, memw[ds, 0x4fc4]);                /* les bx, [0x4fc4] */
            ii(0x17_7c5a, 4); mov(memw[es, bx + 2], ax);                /* mov [es:bx+0x2], ax */
            ii(0x17_7c5e, 4); mov(memw[es, bx + 4], dx);                /* mov [es:bx+0x4], dx */
            ii(0x17_7c62, 4); push(memw[ds, 0x5167]);                   /* push word [0x5167] */
            ii(0x17_7c66, 4); push(memw[ds, 0x4fc6]);                   /* push word [0x4fc6] */
            ii(0x17_7c6a, 4); push(memw[ds, 0x4fc4]);                   /* push word [0x4fc4] */
            ii(0x17_7c6e, 2); push(6);                                  /* push 0x6 */
            ii(0x17_7c70, 1); nop();                                    /* nop */
            ii(0x17_7c71, 1); push(cs);                                 /* push cs */
            ii(0x17_7c72, 3); call(0x17_0864, -0x7411);                 /* call 0x864 */
        l_0x17_7c75:
            ii(0x17_7c75, 3); mov(ax, memw[ss, bp - 8]);                /* mov ax, [bp-0x8] */
            ii(0x17_7c78, 3); mov(dx, memw[ss, bp - 6]);                /* mov dx, [bp-0x6] */
            ii(0x17_7c7b, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_7c7e, 3); sbb(dx, 1);                               /* sbb dx, 0x1 */
            ii(0x17_7c81, 1); push(dx);                                 /* push dx */
            ii(0x17_7c82, 1); push(ax);                                 /* push ax */
            ii(0x17_7c83, 4); push(memw[ds, 0x1fa6]);                   /* push word [0x1fa6] */
            ii(0x17_7c87, 4); push(memw[ds, 0x1fa4]);                   /* push word [0x1fa4] */
            ii(0x17_7c8b, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_7c8d, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_7c8f, 3); call(0x17_90c4, 0x1432);                  /* call 0x90c4 */
            ii(0x17_7c92, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_7c95, 3); mov(memw[ss, bp - 10], ax);               /* mov [bp-0xa], ax */
            ii(0x17_7c98, 1); push(di);                                 /* push di */
            ii(0x17_7c99, 1); push(si);                                 /* push si */
            ii(0x17_7c9a, 4); push(memw[ds, 0x4f8e]);                   /* push word [0x4f8e] */
            ii(0x17_7c9e, 4); push(memw[ds, 0x4f8c]);                   /* push word [0x4f8c] */
            ii(0x17_7ca2, 3); call(0x17_9208, 0x1563);                  /* call 0x9208 */
            ii(0x17_7ca5, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_7ca8, 1); push(dx);                                 /* push dx */
            ii(0x17_7ca9, 1); push(ax);                                 /* push ax */
            ii(0x17_7caa, 2); push(1);                                  /* push 0x1 */
            ii(0x17_7cac, 3); mov(bx, memw[ss, bp - 10]);               /* mov bx, [bp-0xa] */
            ii(0x17_7caf, 3); shl(bx, 3);                               /* shl bx, 0x3 */
            ii(0x17_7cb2, 4); push(memw[ds, bx + 0x2026]);              /* push word [bx+0x2026] */
            ii(0x17_7cb6, 4); push(memw[ds, bx + 0x2024]);              /* push word [bx+0x2024] */
            ii(0x17_7cba, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x17_7cbd, 3); push(memw[ss, bp - 4]);                   /* push word [bp-0x4] */
            ii(0x17_7cc0, 2); push(0);                                  /* push 0x0 */
            ii(0x17_7cc2, 3); push(memw[ss, bp - 6]);                   /* push word [bp-0x6] */
            ii(0x17_7cc5, 3); push(memw[ss, bp - 8]);                   /* push word [bp-0x8] */
            ii(0x17_7cc8, 4); call_far_ind(memw[ds, bx + 0x2020]);      /* call far word [bx+0x2020] */
            ii(0x17_7ccc, 3); add(sp, 0x14);                            /* add sp, 0x14 */
            ii(0x17_7ccf, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_7cd1, 2); if(jz(0x17_7cea, 0x17)) goto l_0x17_7cea; /* jz 0x7cea */
            ii(0x17_7cd3, 4); push(memw[ds, 0x51a7]);                   /* push word [0x51a7] */
            ii(0x17_7cd7, 1); push(di);                                 /* push di */
            ii(0x17_7cd8, 1); push(si);                                 /* push si */
            ii(0x17_7cd9, 4); push(memw[ds, 0x1fa6]);                   /* push word [0x1fa6] */
            ii(0x17_7cdd, 4); push(memw[ds, 0x1fa4]);                   /* push word [0x1fa4] */
            ii(0x17_7ce1, 3); call(0x17_91e3, 0x14ff);                  /* call 0x91e3 */
            ii(0x17_7ce4, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_7ce7, 2); jmp(0x17_7c75, -0x74); goto l_0x17_7c75;  /* jmp 0x7c75 */
        //  ii(0x17_7ce9, 1); nop();                                    /* nop */
        l_0x17_7cea:
            ii(0x17_7cea, 3); push(memw[ss, bp - 6]);                   /* push word [bp-0x6] */
            ii(0x17_7ced, 3); push(memw[ss, bp - 8]);                   /* push word [bp-0x8] */
            ii(0x17_7cf0, 1); push(cs);                                 /* push cs */
            ii(0x17_7cf1, 3); call(0x17_7f8a, 0x296);                   /* call 0x7f8a */
            ii(0x17_7cf4, 3); add(sp, 4);                               /* add sp, 0x4 */
            ii(0x17_7cf7, 1); pop(ds);                                  /* pop ds */
            ii(0x17_7cf8, 1); pop(si);                                  /* pop si */
            ii(0x17_7cf9, 1); pop(di);                                  /* pop di */
            ii(0x17_7cfa, 1); leave();                                  /* leave */
            ii(0x17_7cfb, 1); retf();                                   /* retf */
        }
    }
}
