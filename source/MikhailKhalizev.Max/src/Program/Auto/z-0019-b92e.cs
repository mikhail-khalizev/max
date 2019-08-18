using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_b92e-8bf9c1be")]
        public void Method_0019_b92e()
        {
            ii(0x19_b92e, 1); pushw(bp);                                /* push bp */
            ii(0x19_b92f, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_b931, 1); pushw(si);                                /* push si */
            ii(0x19_b932, 2); sub(si, si);                              /* sub si, si */
            ii(0x19_b934, 2); jmpw(0x19_b941, 0xb); goto l_0x19_b941;   /* jmp 0xb941 */
        l_0x19_b936:
            ii(0x19_b936, 4); mov(al, memb_a16[es, bx + si + 0x1]);     /* mov al, [es:bx+si+0x1] */
            ii(0x19_b93a, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x19_b93d, 3); mov(memb_a16[es, bx + si], al);           /* mov [es:bx+si], al */
            ii(0x19_b940, 1); inc(si);                                  /* inc si */
        l_0x19_b941:
            ii(0x19_b941, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_b944, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x19_b947, 1); cbw();                                    /* cbw */
            ii(0x19_b948, 2); cmp(ax, si);                              /* cmp ax, si */
            ii(0x19_b94a, 2); if(jgw(0x19_b936, -0x16)) goto l_0x19_b936; /* jg 0xb936 */
            ii(0x19_b94c, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x19_b94f, 4); mov(memb_a16[es, bx + si], 0);            /* mov byte [es:bx+si], 0x0 */
            ii(0x19_b953, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x19_b955, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x19_b957, 1); popw(si);                                 /* pop si */
            ii(0x19_b958, 1); leavew();                                 /* leave */
            ii(0x19_b959, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}
