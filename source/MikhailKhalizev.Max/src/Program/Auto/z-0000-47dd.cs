using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8b8ab4dc-5afb-4b40-8bf7-6a566a21e39e")]
        public void Method_0000_47dd()
        {
            ii(0x47dd, 1);    pushw(bp);                                /* push bp */
            ii(0x47de, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x47e0, 1);    pushw(si);                                /* push si */
            ii(0x47e1, 1);    pushw(di);                                /* push di */
            ii(0x47e2, 3);    callw(0x3880, -0xf65);                    /* call 0x3880 */
            ii(0x47e5, 2);    pushw(0x8);                               /* push 0x8 */
            ii(0x47e7, 1);    popw(ds);                                 /* pop ds */
            ii(0x47e8, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x47eb, 3);    mov(memw_a16[ds, 0x62], ax);              /* mov [0x62], ax */
            ii(0x47ee, 3);    mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x47f1, 3);    mov(memb_a16[ds, 0x64], al);              /* mov [0x64], al */
            ii(0x47f4, 4);    mov(memb_a16[ds, 0x67], ah);              /* mov [0x67], ah */
            ii(0x47f8, 3);    mov(cx, memw_a16[ss, bp + 0xa]);          /* mov cx, [bp+0xa] */
            ii(0x47fb, 2);    pushw(0x60);                              /* push 0x60 */
            ii(0x47fd, 1);    popw(ds);                                 /* pop ds */
            ii(0x47fe, 2);    xor(si, si);                              /* xor si, si */
            ii(0x4800, 3);    mov(di, memw_a16[ss, bp + 0x8]);          /* mov di, [bp+0x8] */
            ii(0x4803, 1);    cld();                                    /* cld */
            ii(0x4804, 2);    rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x4806, 1);    pushw(ss);                                /* push ss */
            ii(0x4807, 1);    popw(ds);                                 /* pop ds */
            ii(0x4808, 3);    callw(0x3f19, -0x8f2);                    /* call 0x3f19 */
            ii(0x480b, 1);    popw(di);                                 /* pop di */
            ii(0x480c, 1);    popw(si);                                 /* pop si */
            ii(0x480d, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x480f, 1);    popw(bp);                                 /* pop bp */
            ii(0x4810, 1);    sti();                                    /* sti */
            ii(0x4811, 1);    retw();                                   /* ret */
        }
    }
}
