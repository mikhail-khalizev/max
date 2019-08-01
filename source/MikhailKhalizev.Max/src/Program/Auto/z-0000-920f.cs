using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("082e1dbf-3ffe-481c-bb39-c0ed86e22b06")]
        public void Method_0000_920f()
        {
            ii(0x920f, 3);    mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x9212, 3);    mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x9215, 3);    mov(memw_a16[ds, 0x9c], ax);              /* mov [0x9c], ax */
            ii(0x9218, 4);    mov(memw_a16[ds, 0x9e], dx);              /* mov [0x9e], dx */
        }
    }
}
