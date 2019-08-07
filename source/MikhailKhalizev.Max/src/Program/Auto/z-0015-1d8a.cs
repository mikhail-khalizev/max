using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c1db96f1-97c7-4c9b-b239-c018118fc322")]
        public void Method_0015_1d8a()
        {
            ii(0x15_1d8a, 4); dec(memw_a16[ds, 0x3af0]);                /* dec word [0x3af0] */
            ii(0x15_1d8e, 2); jnsw_func(0x15_1d7e, -0x12);              /* jns 0x1d7e */
            ii(0x15_1d90, 1); retw(); return;                           /* ret */
        }
    }
}
