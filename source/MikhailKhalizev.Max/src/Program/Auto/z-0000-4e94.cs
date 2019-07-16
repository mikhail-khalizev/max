using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f7f196a2-391e-43f1-8f09-3fca938104b4")]
        public void Method_0000_4e94()
        {
            ii(0x4e94, 1);    pushw(bp);                                /* push bp */
            ii(0x4e95, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x4e97, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x4e9a, 3);    mov(ax, memw_a16[ds, 0x11f8]);            /* mov ax, [0x11f8] */
            ii(0x4e9d, 3);    add(ax, 0x1190);                          /* add ax, 0x1190 */
            ii(0x4ea0, 1);    pushw(ax);                                /* push ax */
            ii(0x4ea1, 3);    callw(0x5bde, 0xd3a);                     /* call 0x5bde */
            ii(0x4ea4, 1);    popw(bx);                                 /* pop bx */
            ii(0x4ea5, 1);    popw(bx);                                 /* pop bx */
            ii(0x4ea6, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x4ea8, 1);    popw(bp);                                 /* pop bp */
            ii(0x4ea9, 1);    retw();                                   /* ret */
        }
    }
}
