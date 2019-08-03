using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3ac86f04-1077-47af-bb38-eb8b1fd28f2e")]
        public void Method_0000_5671()
        {
            ii(0x5671, 3);    callw(0x3880, -0x1df4);                   /* call 0x3880 */
            ii(0x5674, 5);    jmpw_far_abs(0x70, 0x5593); return;       /* jmp word 0x70:0x5593 */
        }
    }
}
