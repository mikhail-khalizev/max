using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("eb588310-3cf4-490d-9b68-3dbf43490106")]
        public void Method_0014_ac85()
        {
            ii(0x14_ac85, 4); mov(ax, memw_a16[ds, bx + 0xf6a]);        /* mov ax, [bx+0xf6a] */
            ii(0x14_ac89, 4); mov(si, memw_a16[ds, bx + 0xf6c]);        /* mov si, [bx+0xf6c] */
        }
    }
}
