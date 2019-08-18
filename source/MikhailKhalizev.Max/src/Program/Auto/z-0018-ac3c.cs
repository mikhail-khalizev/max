using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_ac3c-f1f2be05")]
        public void Method_0018_ac3c()
        {
            ii(0x18_ac3c, 2); shr(bx, 0x1);                             /* shr bx, 1 */
            ii(0x18_ac3e, 3); lea(ax, bx - 0x20);                       /* lea ax, [bx-0x20] */
            ii(0x18_ac41, 3); cmp(ax, 0x9c);                            /* cmp ax, 0x9c */
            ii(0x18_ac44, 1); nop();                                    /* nop */
            ii(0x18_ac45, 2); if(jaew_func(0x18_ac98, 0x51)) return;    /* jae 0xac98 */
            ii(0x18_ac47, 4); cmp(bx, 0x84);                            /* cmp bx, 0x84 */
            ii(0x18_ac4b, 2); if(jzw_func(0x18_ac98, 0x4b)) return;     /* jz 0xac98 */
            ii(0x18_ac4d, 1); pushw(cx);                                /* push cx */
            ii(0x18_ac4e, 2); mov(cl, 0x1);                             /* mov cl, 0x1 */
            ii(0x18_ac50, 4); xchg(memb_a16[ds, di + 0x10be], cl);      /* xchg [di+0x10be], cl */
            ii(0x18_ac54, 2); or(cl, cl);                               /* or cl, cl */
            ii(0x18_ac56, 2); if(jnzw(0x18_ac6d, 0x15)) goto l_0x18_ac6d; /* jnz 0xac6d */
            ii(0x18_ac58, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x18_ac5a, 4); mov(es, memw_a16[ds, 0xc2e]);             /* mov es, [0xc2e] */
            ii(0x18_ac5e, 3); mov(cx, memw_a16[es, bx]);                /* mov cx, [es:bx] */
            ii(0x18_ac61, 4); mov(memw_a16[ds, si + 0xf8a], cx);        /* mov [si+0xf8a], cx */
            ii(0x18_ac65, 4); mov(cx, memw_a16[es, bx + 0x2]);          /* mov cx, [es:bx+0x2] */
            ii(0x18_ac69, 4); mov(memw_a16[ds, si + 0xf8c], cx);        /* mov [si+0xf8c], cx */
        l_0x18_ac6d:
            ii(0x18_ac6d, 1); popw(cx);                                 /* pop cx */
            ii(0x18_ac6e, 3); add(ax, 0x111c);                          /* add ax, 0x111c */
            ii(0x18_ac71, 4); mov(si, memw_a16[ds, 0x9b6]);             /* mov si, [0x9b6] */
            ii(0x18_ac75, 3); cmp(cx, 0x70);                            /* cmp cx, 0x70 */
            ii(0x18_ac78, 2); if(jzw(0x18_ac80, 0x6)) goto l_0x18_ac80; /* jz 0xac80 */
            ii(0x18_ac7a, 4); cmp(cx, memw_a16[ds, 0xc42]);             /* cmp cx, [0xc42] */
            ii(0x18_ac7e, 2); if(jnzw_func(0x18_ac8d, 0xd)) return;     /* jnz 0xac8d */
        l_0x18_ac80:
            ii(0x18_ac80, 5); mov(memb_a16[ds, di + 0x10be], 0);        /* mov byte [di+0x10be], 0x0 */
        }
    }
}
