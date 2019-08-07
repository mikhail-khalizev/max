using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b9890621-d4c3-4aa1-a5d4-bacf5cb29d87")]
        public void Method_0015_3ab8()
        {
            ii(0x15_3ab8, 3); mov(ax, 0x2);                             /* mov ax, 0x2 */
            ii(0x15_3abb, 3); jmpw_func(0x15_2203, -0x18bb); return;    /* jmp 0x2203 */
        }
    }
}
