using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_4e68-44edcb47")]
        public void Method_0019_4e68()
        {
            ii(0x19_4e68, 1); pushw(bp);                                /* push bp */
            ii(0x19_4e69, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_4e6b, 1); pushw(si);                                /* push si */
            ii(0x19_4e6c, 2); jmpw(0x19_4e8d, 0x1f); goto l_0x19_4e8d;  /* jmp 0x4e8d */
        l_0x19_4e6e:
            ii(0x19_4e6e, 2); mov(ax, es);                              /* mov ax, es */
            ii(0x19_4e70, 3); les(si, ss, bp + 0xa);                    /* les si, [bp+0xa] */
            ii(0x19_4e73, 4); cmp(memb_a16[es, si], 0);                 /* cmp byte [es:si], 0x0 */
            ii(0x19_4e77, 2); if(jzw(0x19_4e96, 0x1d)) goto l_0x19_4e96; /* jz 0x4e96 */
            ii(0x19_4e79, 2); mov(cx, es);                              /* mov cx, es */
            ii(0x19_4e7b, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x19_4e7d, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x19_4e80, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x19_4e82, 3); cmp(memb_a16[es, si], al);                /* cmp [es:si], al */
            ii(0x19_4e85, 2); if(jnzw(0x19_4e96, 0xf)) goto l_0x19_4e96; /* jnz 0x4e96 */
            ii(0x19_4e87, 3); inc(memw_a16[ss, bp + 0x6]);              /* inc word [bp+0x6] */
            ii(0x19_4e8a, 3); inc(memw_a16[ss, bp + 0xa]);              /* inc word [bp+0xa] */
        l_0x19_4e8d:
            ii(0x19_4e8d, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_4e90, 4); cmp(memb_a16[es, bx], 0);                 /* cmp byte [es:bx], 0x0 */
            ii(0x19_4e94, 2); if(jnzw(0x19_4e6e, -0x28)) goto l_0x19_4e6e; /* jnz 0x4e6e */
        l_0x19_4e96:
            ii(0x19_4e96, 3); mov(es, memw_a16[ss, bp + 0x8]);          /* mov es, [bp+0x8] */
            ii(0x19_4e99, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x19_4e9c, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x19_4e9f, 3); cmp(memb_a16[es, bx], al);                /* cmp [es:bx], al */
            ii(0x19_4ea2, 2); if(jnzw(0x19_4eaa, 0x6)) goto l_0x19_4eaa; /* jnz 0x4eaa */
            ii(0x19_4ea4, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_4ea7, 1); popw(si);                                 /* pop si */
            ii(0x19_4ea8, 1); leavew();                                 /* leave */
            ii(0x19_4ea9, 1); retfw(); return;                          /* retf */
        l_0x19_4eaa:
            ii(0x19_4eaa, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_4eac, 1); popw(si);                                 /* pop si */
            ii(0x19_4ead, 1); leavew();                                 /* leave */
            ii(0x19_4eae, 1); retfw(); return;                          /* retf */
        }
    }
}
