using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("22c4bff0-73ee-4115-b197-353bca35d932")]
        public void Method_0016_1046()
        {
            ii(0x16_1046, 1); popw(ax);                                 /* pop ax */
            ii(0x16_1047, 1); pushw(cs);                                /* push cs */
            ii(0x16_1048, 1); pushw(ax);                                /* push ax */
            ii(0x16_1049, 5); jmpw_far_abs(0x80, 0x216e); return;       /* jmp word 0x80:0x216e */
        }
    }
}
