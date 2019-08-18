using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0ff67826-a14e-4f49-9e4d-3a23a53359d5")]
        public void Method_001a_104e()
        {
            ii(0x1a_104e, 1); popw(ax);                                 /* pop ax */
            ii(0x1a_104f, 1); pushw(cs);                                /* push cs */
            ii(0x1a_1050, 1); pushw(ax);                                /* push ax */
            ii(0x1a_1051, 5); if(jmpw_far_abs(0x80, 0x21d2)) return;    /* jmp word 0x80:0x21d2 */
            ii(0x1a_1056, 1); popw(ax);                                 /* pop ax */
            ii(0x1a_1057, 1); pushw(cs);                                /* push cs */
            ii(0x1a_1058, 1); pushw(ax);                                /* push ax */
            ii(0x1a_1059, 5); if(jmpw_far_abs(0x80, 0x220b)) return;    /* jmp word 0x80:0x220b */
            ii(0x1a_105e, 1); popw(ax);                                 /* pop ax */
            ii(0x1a_105f, 1); pushw(cs);                                /* push cs */
            ii(0x1a_1060, 1); pushw(ax);                                /* push ax */
            ii(0x1a_1061, 5); if(jmpw_far_abs(0x80, 0x2244)) return;    /* jmp word 0x80:0x2244 */
            ii(0x1a_1066, 1); popw(ax);                                 /* pop ax */
            ii(0x1a_1067, 1); pushw(cs);                                /* push cs */
            ii(0x1a_1068, 1); pushw(ax);                                /* push ax */
            ii(0x1a_1069, 5); if(jmpw_far_abs(0x80, 0x2289)) return;    /* jmp word 0x80:0x2289 */
        }
    }
}
