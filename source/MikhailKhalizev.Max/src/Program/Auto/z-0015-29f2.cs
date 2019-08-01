using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2c83e8f2-65f5-4ae8-b881-7623bf4e2b10")]
        public void Method_0015_29f2()
        {
            ii(0x15_29f2, 1); pushw(bp);                                /* push bp */
            ii(0x15_29f3, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_29f5, 3); mov(ax, 0xfc);                            /* mov ax, 0xfc */
            ii(0x15_29f8, 1); pushw(ax);                                /* push ax */
            ii(0x15_29f9, 1); pushw(cs);                                /* push cs */
            ii(0x15_29fa, 3); callw(0x15_2c8d, 0x290);                  /* call 0x2c8d */
            ii(0x15_29fd, 5); cmp(memw_a16[ds, 0x3c4e], 0);             /* cmp word [0x3c4e], 0x0 */
            ii(0x15_2a02, 2); if(jzw(0x15_2a08, 0x4)) goto l_0x15_2a08; /* jz 0x2a08 */
            ii(0x15_2a04, 4); callw_a16_far_ind(ds, 0x3c4c);            /* call far word [0x3c4c] */
        l_0x15_2a08:
            ii(0x15_2a08, 3); mov(ax, 0xff);                            /* mov ax, 0xff */
            ii(0x15_2a0b, 1); pushw(ax);                                /* push ax */
            ii(0x15_2a0c, 1); pushw(cs);                                /* push cs */
            ii(0x15_2a0d, 3); callw(0x15_2c8d, 0x27d);                  /* call 0x2c8d */
            ii(0x15_2a10, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x15_2a12, 1); popw(bp);                                 /* pop bp */
            ii(0x15_2a13, 1); retfw(); return;                          /* retf */
        }
    }
}
