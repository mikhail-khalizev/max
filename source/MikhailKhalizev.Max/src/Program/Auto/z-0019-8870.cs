using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_8870-89fbaf9")]
        public void Method_0019_8870()
        {
            ii(0x19_8870, 3); add(sp, 0x12);                            /* add sp, 0x12 */
            ii(0x19_8873, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_8876, 5); cmp(memw_a16[es, bx + 0x2c], 0xc);        /* cmp word [es:bx+0x2c], 0xc */
            ii(0x19_887b, 2); if(jzw(0x19_8880, 0x3)) goto l_0x19_8880; /* jz 0x8880 */
            ii(0x19_887d, 3); jmpw(0x19_88a7, 0x27); goto l_0x19_88a7;  /* jmp 0x88a7 */
        l_0x19_8880:
            ii(0x19_8880, 4); mov(es, memw_a16[ds, 0x3fb2]);            /* mov es, [0x3fb2] */
            ii(0x19_8884, 4); mov(ax, memw_a16[es, 0xa4e]);             /* mov ax, [es:0xa4e] */
            ii(0x19_8888, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_888b, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x19_888f, 4); mov(es, memw_a16[ds, 0x3fb4]);            /* mov es, [0x3fb4] */
            ii(0x19_8893, 4); mov(ax, memw_a16[es, 0xa4a]);             /* mov ax, [es:0xa4a] */
            ii(0x19_8897, 5); mov(dx, memw_a16[es, 0xa4c]);             /* mov dx, [es:0xa4c] */
            ii(0x19_889c, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_889f, 4); mov(memw_a16[es, bx + 0x18], ax);         /* mov [es:bx+0x18], ax */
            ii(0x19_88a3, 4); mov(memw_a16[es, bx + 0x1a], dx);         /* mov [es:bx+0x1a], dx */
        l_0x19_88a7:
            ii(0x19_88a7, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x19_88a9, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_88ac, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_88af, 1); nop();                                    /* nop */
            ii(0x19_88b0, 1); pushw(cs);                                /* push cs */
            ii(0x19_88b1, 3); callw(0x19_85f7, -0x2bd);                 /* call 0x85f7 */
            ii(0x19_88b4, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_88b7, 5); mov(memb_a16[ds, 0x17eb], 0);             /* mov byte [0x17eb], 0x0 */
            ii(0x19_88bc, 3); pushw(0x7d1);                             /* push 0x7d1 */
            ii(0x19_88bf, 5); callw_far_abs(0x80, 0x349f);              /* call word 0x80:0x349f */
            ii(0x19_88c4, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x19_88c7, 1); popw(ds);                                 /* pop ds */
            ii(0x19_88c8, 1); popw(si);                                 /* pop si */
            ii(0x19_88c9, 1); popw(di);                                 /* pop di */
            ii(0x19_88ca, 1); leavew();                                 /* leave */
            ii(0x19_88cb, 1); retfw(); return;                          /* retf */
        }
    }
}
