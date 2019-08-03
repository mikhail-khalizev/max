using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("37b5d432-cf36-4436-a4ab-046d3be29727")]
        public void Method_0000_dc8e()
        {
            ii(0xdc8e, 1);    pushw(bp);                                /* push bp */
            ii(0xdc8f, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xdc91, 3);    mov(ax, memw_a16[ds, 0x98]);              /* mov ax, [0x98] */
            ii(0xdc94, 4);    mov(dx, memw_a16[ds, 0x9a]);              /* mov dx, [0x9a] */
            ii(0xdc98, 3);    cmp(memw_a16[ss, bp + 0x6], dx);          /* cmp [bp+0x6], dx */
            ii(0xdc9b, 2);    if(jbw(0xdcbc, 0x1f)) goto l_0xdcbc;      /* jb 0xdcbc */
            ii(0xdc9d, 2);    if(jaw(0xdca4, 0x5)) goto l_0xdca4;       /* ja 0xdca4 */
            ii(0xdc9f, 3);    cmp(memw_a16[ss, bp + 0x4], ax);          /* cmp [bp+0x4], ax */
            ii(0xdca2, 2);    if(jbw(0xdcbc, 0x18)) goto l_0xdcbc;      /* jb 0xdcbc */
        l_0xdca4:
            ii(0xdca4, 3);    mov(ax, memw_a16[ds, 0x9c]);              /* mov ax, [0x9c] */
            ii(0xdca7, 4);    mov(dx, memw_a16[ds, 0x9e]);              /* mov dx, [0x9e] */
            ii(0xdcab, 3);    cmp(memw_a16[ss, bp + 0x6], dx);          /* cmp [bp+0x6], dx */
            ii(0xdcae, 2);    if(jaw(0xdcbc, 0xc)) goto l_0xdcbc;       /* ja 0xdcbc */
            ii(0xdcb0, 2);    if(jbw(0xdcb7, 0x5)) goto l_0xdcb7;       /* jb 0xdcb7 */
            ii(0xdcb2, 3);    cmp(memw_a16[ss, bp + 0x4], ax);          /* cmp [bp+0x4], ax */
            ii(0xdcb5, 2);    if(jaw(0xdcbc, 0x5)) goto l_0xdcbc;       /* ja 0xdcbc */
        l_0xdcb7:
            ii(0xdcb7, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0xdcba, 2);    jmpw(0xdcbe, 0x2); goto l_0xdcbe;         /* jmp 0xdcbe */
        l_0xdcbc:
            ii(0xdcbc, 2);    sub(ax, ax);                              /* sub ax, ax */
        l_0xdcbe:
            ii(0xdcbe, 1);    leavew();                                 /* leave */
            ii(0xdcbf, 3);    retw(0x4); return;                        /* ret 0x4 */
        }
    }
}