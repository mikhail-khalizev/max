using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5fa0ac0f-322b-46b0-a49b-f6554d706ea5")]
        public void Method_0014_e416()
        {
            ii(0x14_e416, 1); pushw(di);                                /* push di */
            ii(0x14_e417, 2); pushw(0x16);                              /* push 0x16 */
            ii(0x14_e419, 3); callw(0x14_e868, 0x44c);                  /* call 0xe868 */
            ii(0x14_e41c, 2); jmpw_func(0x14_e3ac, -0x72); return;      /* jmp 0xe3ac */
        }
    }
}
