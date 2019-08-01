using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("eabe3b18-c4f0-45c8-8346-377505a3cbc9")]
        public void Method_0014_a4be()
        {
            ii(0x14_a4be, 3); mov(ax, memw_a16[ds, 0x14]);              /* mov ax, [0x14] */
            ii(0x14_a4c1, 3); and(ax, 0x8);                             /* and ax, 0x8 */
            ii(0x14_a4c4, 2); jzw_func(0x14_a49e, -0x28);               /* jz 0xa49e */
            ii(0x14_a4c6, 3); mov(ax, memw_a16[ss, bp + 0x10]);         /* mov ax, [bp+0x10] */
            ii(0x14_a4c9, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x14_a4cb, 2); or(cx, cx);                               /* or cx, cx */
            ii(0x14_a4cd, 2); if(jlw(0x14_a4d3, 0x4)) goto l_0x14_a4d3; /* jl 0xa4d3 */
            ii(0x14_a4cf, 1); inc(cx);                                  /* inc cx */
            ii(0x14_a4d0, 3); mov(memw_a16[ds, 0xe70], ax);             /* mov [0xe70], ax */
        l_0x14_a4d3:
            ii(0x14_a4d3, 3); mov(memw_a16[ds, bx + 0xe], sp);          /* mov [bx+0xe], sp */
            ii(0x14_a4d6, 4); mov(ss, memw_a16[ds, 0xc28]);             /* mov ss, [0xc28] */
            ii(0x14_a4da, 4); mov(sp, memw_a16[ds, 0xf50]);             /* mov sp, [0xf50] */
            ii(0x14_a4de, 5); cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
            ii(0x14_a4e3, 2); if(jzw(0x14_a51a, 0x35)) goto l_0x14_a51a; /* jz 0xa51a */
            ii(0x14_a4e5, 3); sub(sp, 0x2a);                            /* sub sp, 0x2a */
            ii(0x14_a4e8, 3); mov(memw_a16[ds, bx + 0xa], sp);          /* mov [bx+0xa], sp */
            ii(0x14_a4eb, 1); pushw(es);                                /* push es */
            ii(0x14_a4ec, 1); pushw(ds);                                /* push ds */
            ii(0x14_a4ed, 1); pushw(ss);                                /* push ss */
            ii(0x14_a4ee, 2); pushw(0x18);                              /* push 0x18 */
            ii(0x14_a4f0, 3); pushw(memw_a16[ds, bx + 0xa]);            /* push word [bx+0xa] */
            ii(0x14_a4f3, 1); pushw(cx);                                /* push cx */
            ii(0x14_a4f4, 1); pushw(bx);                                /* push bx */
            ii(0x14_a4f5, 5); jmpw_far_abs(0x18, 0x10f2); return;       /* jmp word 0x18:0x10f2 */
        //  ii(0x14_a4fa, 32); Недостижимый код.
l_0x14_a51a:
            ii(0x14_a51a, 4); inc(memb_a16[ds, 0x1182]);                /* inc byte [0x1182] */
            ii(0x14_a51e, 3); pushw(memw_a16[ds, bx + 0x6]);            /* push word [bx+0x6] */
            ii(0x14_a521, 3); pushw(memw_a16[ds, bx + 0x8]);            /* push word [bx+0x8] */
            ii(0x14_a524, 1); pushw(cx);                                /* push cx */
            ii(0x14_a525, 1); pushw(cs);                                /* push cs */
            ii(0x14_a526, 3); pushw(0xa11);                             /* push 0xa11 */
            ii(0x14_a529, 4); pushw(memw_a16[ds, 0xc26]);               /* push word [0xc26] */
            ii(0x14_a52d, 3); pushw(0x47b2);                            /* push 0x47b2 */
            ii(0x14_a530, 1); retfw(); return;                          /* retf */
        }
    }
}
