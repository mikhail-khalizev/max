using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1a642766-f419-427a-9f49-3b863fc1a27f")]
        public void Method_0000_88c0()
        {
            ii(0x88c0, 1);    cld();                                    /* cld */
            ii(0x88c1, 3);    add(ah, 0x60);                            /* add ah, 0x60 */
            ii(0x88c4, 3);    mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x88c7, 2);    mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x88c9, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x88cb, 2);    if(jzw(0x88d5, 0x8)) goto l_0x88d5;       /* jz 0x88d5 */
            ii(0x88cd, 3);    mov(ax, 0xa000);                          /* mov ax, 0xa000 */
            ii(0x88d0, 3);    mov(dx, 0xf);                             /* mov dx, 0xf */
            ii(0x88d3, 1);    leavew();                                 /* leave */
            ii(0x88d4, 1);    retw(); return;                           /* ret */
        l_0x88d5:
            ii(0x88d5, 5);    and(memb_a16[ds, 0x47], -0x3 /* 0xfd */); /* and byte [0x47], 0xfd */
            ii(0x88da, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x88dc, 1);    cwd();                                    /* cwd */
            ii(0x88dd, 1);    leavew();                                 /* leave */
            ii(0x88de, 1);    retw(); return;                           /* ret */
        }
    }
}
