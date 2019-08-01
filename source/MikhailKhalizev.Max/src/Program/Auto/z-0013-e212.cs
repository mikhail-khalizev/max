using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("55cd11c9-f526-47ef-a132-7205af9e3ec5")]
        public void Method_0013_e212()
        {
            ii(0x13_e212, 3); mov(ax, 0x2);                             /* mov ax, 0x2 */
            ii(0x13_e215, 3); jmpw_func(0x13_d16b, -0x10ad); return;    /* jmp 0xd16b */
        }
    }
}
