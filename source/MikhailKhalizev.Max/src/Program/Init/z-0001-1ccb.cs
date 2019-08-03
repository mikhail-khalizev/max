using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4a4a1d10-2d6c-4c5f-ab1e-9c5f92fb2f53")]
        public void Method_0001_1ccb()
        {
            ii(0x1_1ccb, 1);  cmc();                                    /* cmc */
            ii(0x1_1ccc, 2);  sbb(bx, bx);                              /* sbb bx, bx */
            ii(0x1_1cce, 2);  and(ax, bx);                              /* and ax, bx */
            ii(0x1_1cd0, 1);  retw(); return;                           /* ret */
        }
    }
}
