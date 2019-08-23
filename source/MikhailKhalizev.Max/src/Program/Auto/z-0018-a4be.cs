using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a4be-9379cc0d")]
        public void Method_0018_a4be()
        {
            ii(0x18_a4be, 3); mov(ax, memw[ds, 0x14]);                  /* mov ax, [0x14] */
            ii(0x18_a4c1, 3); and(ax, 0x8);                             /* and ax, 0x8 */
            ii(0x18_a4c4, 2); if(jz_func(0x18_a49e, -0x28)) return;     /* jz 0xa49e */
            ii(0x18_a4c6, 3); mov(ax, memw[ss, bp + 0x10]);             /* mov ax, [bp+0x10] */
            ii(0x18_a4c9, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x18_a4cb, 2); or(cx, cx);                               /* or cx, cx */
            ii(0x18_a4cd, 2); if(jl(0x18_a4d3, 0x4)) goto l_0x18_a4d3;  /* jl 0xa4d3 */
            ii(0x18_a4cf, 1); inc(cx);                                  /* inc cx */
            ii(0x18_a4d0, 3); mov(memw[ds, 0xe70], ax);                 /* mov [0xe70], ax */
        l_0x18_a4d3:
            ii(0x18_a4d3, 3); mov(memw[ds, bx + 0xe], sp);              /* mov [bx+0xe], sp */
            ii(0x18_a4d6, 4); mov(ss, memw[ds, 0xc28]);                 /* mov ss, [0xc28] */
            ii(0x18_a4da, 4); mov(sp, memw[ds, 0xf50]);                 /* mov sp, [0xf50] */
            ii(0x18_a4de, 5); cmp(memb[ds, 0x2e], 0);                   /* cmp byte [0x2e], 0x0 */
            ii(0x18_a4e3, 2); if(jz(0x18_a51a, 0x35)) goto l_0x18_a51a; /* jz 0xa51a */
            ii(0x18_a4e5, 3); sub(sp, 0x2a);                            /* sub sp, 0x2a */
            ii(0x18_a4e8, 3); mov(memw[ds, bx + 0xa], sp);              /* mov [bx+0xa], sp */
            ii(0x18_a4eb, 1); push(es);                                 /* push es */
            ii(0x18_a4ec, 1); push(ds);                                 /* push ds */
            ii(0x18_a4ed, 1); push(ss);                                 /* push ss */
            ii(0x18_a4ee, 2); push(0x18);                               /* push 0x18 */
            ii(0x18_a4f0, 3); push(memw[ds, bx + 0xa]);                 /* push word [bx+0xa] */
            ii(0x18_a4f3, 1); push(cx);                                 /* push cx */
            ii(0x18_a4f4, 1); push(bx);                                 /* push bx */
            ii(0x18_a4f5, 5); if(jmp_far_abs(0x18, 0x10f2)) return;     /* jmp word 0x18:0x10f2 */
            ii(0x18_a4fa, 4); mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x18_a4fe, 3); mov(ss, memw[ds, bx + 0x2]);              /* mov ss, [bx+0x2] */
            ii(0x18_a501, 3); mov(sp, memw[ds, bx + 0xe]);              /* mov sp, [bx+0xe] */
            ii(0x18_a504, 3); mov(es, memw[ss, bp + 0x6]);              /* mov es, [bp+0x6] */
            ii(0x18_a507, 3); mov(di, memw[ds, bx + 0x8]);              /* mov di, [bx+0x8] */
            ii(0x18_a50a, 3); mov(si, memw[ds, bx + 0xa]);              /* mov si, [bx+0xa] */
            ii(0x18_a50d, 3); push(memw[ds, si + 0x4]);                 /* push word [si+0x4] */
            ii(0x18_a510, 3); mov(cx, 0x15);                            /* mov cx, 0x15 */
            ii(0x18_a513, 1); cld();                                    /* cld */
            ii(0x18_a514, 2); rep(() => movsw());                       /* rep movsw */
            ii(0x18_a516, 1); pop(cx);                                  /* pop cx */
            ii(0x18_a517, 2); if(jcxz(0x18_a56b, 0x52)) goto l_0x18_a56b; /* jcxz 0xa56b */
            ii(0x18_a519, 1); ret(); return;                            /* ret */
        l_0x18_a51a:
            ii(0x18_a51a, 4); inc(memb[ds, 0x1182]);                    /* inc byte [0x1182] */
            ii(0x18_a51e, 3); push(memw[ds, bx + 0x6]);                 /* push word [bx+0x6] */
            ii(0x18_a521, 3); push(memw[ds, bx + 0x8]);                 /* push word [bx+0x8] */
            ii(0x18_a524, 1); push(cx);                                 /* push cx */
            ii(0x18_a525, 1); push(cs);                                 /* push cs */
            ii(0x18_a526, 3); push(0xa11);                              /* push 0xa11 */
            ii(0x18_a529, 4); push(memw[ds, 0xc26]);                    /* push word [0xc26] */
            ii(0x18_a52d, 3); push(0x47b2);                             /* push 0x47b2 */
            ii(0x18_a530, 1); retf(); return;                           /* retf */
        //  ii(0x18_a531, 58); Недостижимый код.
        l_0x18_a56b:
            ii(0x18_a56b, 3); if(jmp_func(0x18_a838, 0x2ca)) return;    /* jmp 0xa838 */
        }
    }
}
