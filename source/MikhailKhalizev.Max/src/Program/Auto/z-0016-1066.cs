using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7ef60da4-cdf1-4c82-b7eb-747c5176fa12")]
        public void Method_0016_1066()
        {
            ii(0x16_1066, 1); popw(ax);                                 /* pop ax */
            ii(0x16_1067, 1); pushw(cs);                                /* push cs */
            ii(0x16_1068, 1); pushw(ax);                                /* push ax */
            ii(0x16_1069, 5); jmpw_far_abs(0x80, 0x2289); return;       /* jmp word 0x80:0x2289 */
        }
    }
}
