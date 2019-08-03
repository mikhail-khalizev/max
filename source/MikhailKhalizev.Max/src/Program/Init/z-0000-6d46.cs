using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("977b99fd-6987-43a2-b0a9-943a2fa9b5bd")]
        public void Method_0000_6d46()
        {
            ii(0x6d46, 1);    pushw(bp);                                /* push bp */
            ii(0x6d47, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x6d49, 3);    mov(ax, memw_a16[ds, 0x97c]);             /* mov ax, [0x97c] */
            ii(0x6d4c, 3);    cmp(memw_a16[ss, bp + 0x4], ax);          /* cmp [bp+0x4], ax */
            ii(0x6d4f, 2);    if(jaew(0x6d65, 0x14)) goto l_0x6d65;     /* jae 0x6d65 */
            ii(0x6d51, 3);    pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x6d54, 2);    pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0x6d56, 2);    pushw(0);                                 /* push 0x0 */
            ii(0x6d58, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x6d5b, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x6d5e, 3);    shr(ax, 0x3);                             /* shr ax, 0x3 */
            ii(0x6d61, 1);    pushw(ax);                                /* push ax */
            ii(0x6d62, 3);    callw(0x5a4a, -0x131b);                   /* call 0x5a4a */
        l_0x6d65:
            ii(0x6d65, 1);    leavew();                                 /* leave */
            ii(0x6d66, 1);    retw(); return;                           /* ret */
        }
    }
}
