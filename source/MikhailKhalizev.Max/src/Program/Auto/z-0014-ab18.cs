using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("03c7c8eb-7e12-4023-8e21-4ba4a9d6ad85")]
        public void Method_0014_ab18()
        {
            ii(0x14_ab18, 3); mov(di, memw_a16[ss, bp + 0x4]);          /* mov di, [bp+0x4] */
            ii(0x14_ab1b, 3); callw(0x14_aae3, -0x3b);                  /* call 0xaae3 */
            ii(0x14_ab1e, 3); mov(memw_a16[ds, bx + 0x4], ax);          /* mov [bx+0x4], ax */
            ii(0x14_ab21, 1); retw(); return;                           /* ret */
        }
    }
}
