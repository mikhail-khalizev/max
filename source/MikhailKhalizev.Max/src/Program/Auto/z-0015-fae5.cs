using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1b25648c-b164-44d3-86d4-0d43bba656fb")]
        public void Method_0015_fae5()
        {
            ii(0x15_fae5, 1); pushw(bp);                                /* push bp */
            ii(0x15_fae6, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_fae8, 1); pushw(di);                                /* push di */
            ii(0x15_fae9, 1); pushw(si);                                /* push si */
            ii(0x15_faea, 1); pushw(ds);                                /* push ds */
            ii(0x15_faeb, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_faee, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_faf0, 2); sub(si, si);                              /* sub si, si */
            ii(0x15_faf2, 2); pushw(0x3);                               /* push 0x3 */
            ii(0x15_faf4, 5); callw_far_abs(0x80, 0x51ba);              /* call word 0x80:0x51ba */
            ii(0x15_faf9, 1); popw(bx);                                 /* pop bx */
            ii(0x15_fafa, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x15_fafc, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_faff, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_fb02, 5); callw_far_abs(0x80, 0x535a);              /* call word 0x80:0x535a */
            ii(0x15_fb07, 1); popw(bx);                                 /* pop bx */
            ii(0x15_fb08, 1); popw(bx);                                 /* pop bx */
            ii(0x15_fb09, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_fb0b, 2); if(jzw(0x15_fb10, 0x3)) goto l_0x15_fb10; /* jz 0xfb10 */
            ii(0x15_fb0d, 3); mov(si, 0x1);                             /* mov si, 0x1 */
        l_0x15_fb10:
            ii(0x15_fb10, 1); pushw(di);                                /* push di */
            ii(0x15_fb11, 5); callw_far_abs(0x80, 0x51ba);              /* call word 0x80:0x51ba */
            ii(0x15_fb16, 1); popw(bx);                                 /* pop bx */
            ii(0x15_fb17, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x15_fb19, 1); popw(ds);                                 /* pop ds */
            ii(0x15_fb1a, 1); popw(si);                                 /* pop si */
            ii(0x15_fb1b, 1); popw(di);                                 /* pop di */
            ii(0x15_fb1c, 1); leavew();                                 /* leave */
            ii(0x15_fb1d, 3); retw(0x4); return;                        /* ret 0x4 */
        }
    }
}
