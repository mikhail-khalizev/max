using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dbb838ea-0851-4dbb-83ea-144aa6480a30")]
        public void Method_0000_4eaa()
        {
            ii(0x4eaa, 1);    pushw(bp);                                /* push bp */
            ii(0x4eab, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x4ead, 3);    mov(ax, 0x1190);                          /* mov ax, 0x1190 */
            ii(0x4eb0, 1);    pushw(ax);                                /* push ax */
            ii(0x4eb1, 3);    callw(0x5c10, 0xd5c);                     /* call 0x5c10 */
            ii(0x4eb4, 1);    popw(bx);                                 /* pop bx */
            ii(0x4eb5, 4);    cmp(ax, memw_a16[ds, 0x11f8]);            /* cmp ax, [0x11f8] */
            ii(0x4eb9, 2);    if(jnzw(0x4ec2, 0x7)) goto l_0x4ec2;      /* jnz 0x4ec2 */
            ii(0x4ebb, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x4ebe, 3);    callw(0x4e94, -0x2d);                     /* call 0x4e94 */
            ii(0x4ec1, 1);    popw(bx);                                 /* pop bx */
        l_0x4ec2:
            ii(0x4ec2, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x4ec4, 1);    popw(bp);                                 /* pop bp */
            ii(0x4ec5, 1);    retw();                                   /* ret */
        }
    }
}
