using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("83cfc082-7277-47e8-936e-c62fece4619d")]
        public void Method_0013_d54f()
        {
            ii(0x13_d54f, 1); pushw(bp);                                /* push bp */
            ii(0x13_d550, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_d552, 2); xor(cx, cx);                              /* xor cx, cx */
            ii(0x13_d554, 2); jmpw_func(0x13_d570, 0x1a); return;       /* jmp 0xd570 */
        }
    }
}
