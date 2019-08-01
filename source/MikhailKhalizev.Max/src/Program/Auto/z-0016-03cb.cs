using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("05816488-96ff-4d44-ad1d-5f0a759d9ff3")]
        public void Method_0016_03cb()
        {
            ii(0x16_03cb, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x16_03cf, 1); pushw(ds);                                /* push ds */
            ii(0x16_03d0, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x16_03d3, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x16_03d5, 2); jmpw(0x16_03fa, 0x23); goto l_0x16_03fa;  /* jmp 0x3fa */
        l_0x16_03d7:
            ii(0x16_03d7, 3); mov(ax, memw_a16[ss, bp + 0xe]);          /* mov ax, [bp+0xe] */
            ii(0x16_03da, 3); mov(dx, memw_a16[ss, bp + 0x10]);         /* mov dx, [bp+0x10] */
            ii(0x16_03dd, 3); mov(cl, memb_a16[ss, bp + 0xa]);          /* mov cl, [bp+0xa] */
            ii(0x16_03e0, 3); shl(cl, 0x2);                             /* shl cl, 0x2 */
            ii(0x16_03e3, 5); callw_far_abs(0x80, 0x4378);              /* call word 0x80:0x4378 */
            ii(0x16_03e8, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x16_03ea, 3); and(bx, 0xf);                             /* and bx, 0xf */
            ii(0x16_03ed, 4); mov(al, memb_a16[ds, bx + 0x36f8]);       /* mov al, [bx+0x36f8] */
            ii(0x16_03f1, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x16_03f4, 3); inc(memw_a16[ss, bp + 0x6]);              /* inc word [bp+0x6] */
            ii(0x16_03f7, 3); mov(memb_a16[es, bx], al);                /* mov [es:bx], al */
        l_0x16_03fa:
            ii(0x16_03fa, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x16_03fd, 3); dec(memw_a16[ss, bp + 0xa]);              /* dec word [bp+0xa] */
            ii(0x16_0400, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x16_0402, 2); if(jnzw(0x16_03d7, -0x2d)) goto l_0x16_03d7; /* jnz 0x3d7 */
            ii(0x16_0404, 1); popw(ds);                                 /* pop ds */
            ii(0x16_0405, 1); leavew();                                 /* leave */
            ii(0x16_0406, 3); retfw(0xc); return;                       /* retf 0xc */
        }
    }
}
