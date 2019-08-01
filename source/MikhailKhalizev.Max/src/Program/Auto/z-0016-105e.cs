using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("11b9f3a4-0882-4d49-9f1f-15f7fb14c441")]
        public void Method_0016_105e()
        {
            ii(0x16_105e, 1); popw(ax);                                 /* pop ax */
            ii(0x16_105f, 1); pushw(cs);                                /* push cs */
            ii(0x16_1060, 1); pushw(ax);                                /* push ax */
            ii(0x16_1061, 5); jmpw_far_abs(0x80, 0x2244); return;       /* jmp word 0x80:0x2244 */
        }
    }
}
