using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d1816830-7498-42ab-b91c-eff94dc4a9b7")]
        public void Method_0000_4de3()
        {
            ii(0x4de3, 2);    mov(ax, memw_a16[ds, bx]);                /* mov ax, [bx] */
            ii(0x4de5, 4);    mov(memw_a16[cs, 0x8], ax);               /* mov [cs:0x8], ax */
            ii(0x4de9, 1);    popw(ax);                                 /* pop ax */
            ii(0x4dea, 3);    mov(es, memw_a16[ds, bx + 0x4]);          /* mov es, [bx+0x4] */
            ii(0x4ded, 3);    mov(ds, memw_a16[ds, bx + 0x6]);          /* mov ds, [bx+0x6] */
            ii(0x4df0, 1);    popw(bx);                                 /* pop bx */
            ii(0x4df1, 1);    popw(bp);                                 /* pop bp */
            ii(0x4df2, 1);    iretw(); return;                          /* iretw */
        }
    }
}
