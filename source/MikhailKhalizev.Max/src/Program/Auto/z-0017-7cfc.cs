using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_7cfc-c32d09a8")]
        public void Method_0017_7cfc()
        {
            ii(0x17_7cfc, 4); enter(2, 0);                              /* enter 0x2, 0x0 */
            ii(0x17_7d00, 1); push(ds);                                 /* push ds */
            ii(0x17_7d01, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_7d04, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_7d06, 5); cmp(memw[ds, 0x984], 0);                  /* cmp word [0x984], 0x0 */
            ii(0x17_7d0b, 2); if(jz(0x17_7d5d, 0x50)) goto l_0x17_7d5d; /* jz 0x7d5d */
            ii(0x17_7d0d, 4); les(bx, memw[ds, 0x4fc4]);                /* les bx, [0x4fc4] */
            ii(0x17_7d11, 4); mov(memb[es, bx], 0x22);                  /* mov byte [es:bx], 0x22 */
            ii(0x17_7d15, 3); mov(al, memb[ds, 0x5130]);                /* mov al, [0x5130] */
            ii(0x17_7d18, 4); les(bx, memw[ds, 0x4fc4]);                /* les bx, [0x4fc4] */
            ii(0x17_7d1c, 4); mov(memb[es, bx + 1], al);                /* mov [es:bx+0x1], al */
            ii(0x17_7d20, 3); mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x17_7d23, 3); mov(dx, memw[ss, bp + 8]);                /* mov dx, [bp+0x8] */
            ii(0x17_7d26, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_7d28, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_7d2a, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_7d2c, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_7d2e, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_7d30, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_7d32, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_7d34, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_7d36, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_7d38, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_7d3a, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_7d3c, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_7d3e, 4); les(bx, memw[ds, 0x4fc4]);                /* les bx, [0x4fc4] */
            ii(0x17_7d42, 4); mov(memw[es, bx + 2], ax);                /* mov [es:bx+0x2], ax */
            ii(0x17_7d46, 4); mov(memw[es, bx + 4], dx);                /* mov [es:bx+0x4], dx */
            ii(0x17_7d4a, 4); push(memw[ds, 0x5167]);                   /* push word [0x5167] */
            ii(0x17_7d4e, 4); push(memw[ds, 0x4fc6]);                   /* push word [0x4fc6] */
            ii(0x17_7d52, 4); push(memw[ds, 0x4fc4]);                   /* push word [0x4fc4] */
            ii(0x17_7d56, 2); push(6);                                  /* push 0x6 */
            ii(0x17_7d58, 1); nop();                                    /* nop */
            ii(0x17_7d59, 1); push(cs);                                 /* push cs */
            ii(0x17_7d5a, 3); call(0x17_0864, -0x74f9);                 /* call 0x864 */
        l_0x17_7d5d:
            ii(0x17_7d5d, 3); mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x17_7d60, 3); mov(dx, memw[ss, bp + 8]);                /* mov dx, [bp+0x8] */
            ii(0x17_7d63, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_7d66, 3); sbb(dx, 1);                               /* sbb dx, 0x1 */
            ii(0x17_7d69, 1); push(dx);                                 /* push dx */
            ii(0x17_7d6a, 1); push(ax);                                 /* push ax */
            ii(0x17_7d6b, 4); push(memw[ds, 0x1fa6]);                   /* push word [0x1fa6] */
            ii(0x17_7d6f, 4); push(memw[ds, 0x1fa4]);                   /* push word [0x1fa4] */
            ii(0x17_7d73, 3); call(0x17_90c4, 0x134e);                  /* call 0x90c4 */
            ii(0x17_7d76, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_7d79, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x17_7d7c, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x17_7d7f, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x17_7d82, 2); push(0);                                  /* push 0x0 */
            ii(0x17_7d84, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_7d86, 3); shl(bx, 3);                               /* shl bx, 0x3 */
            ii(0x17_7d89, 4); push(memw[ds, bx + 0x2026]);              /* push word [bx+0x2026] */
            ii(0x17_7d8d, 4); push(memw[ds, bx + 0x2024]);              /* push word [bx+0x2024] */
            ii(0x17_7d91, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x17_7d94, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x17_7d97, 2); push(0);                                  /* push 0x0 */
            ii(0x17_7d99, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x17_7d9c, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x17_7d9f, 4); call_far_ind(memw[ds, bx + 0x2020]);      /* call far word [bx+0x2020] */
            ii(0x17_7da3, 3); add(sp, 0x14);                            /* add sp, 0x14 */
            ii(0x17_7da6, 1); pop(ds);                                  /* pop ds */
            ii(0x17_7da7, 1); leave();                                  /* leave */
            ii(0x17_7da8, 1); retf();                                   /* retf */
        }
    }
}
