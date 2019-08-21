using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_1121-83ab7734")]
        public void Method_001a_1121()
        {
            ii(0x1a_1121, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x1a_1124, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x1a_1126, 2); if(jzw(0x1a_112d, 0x5)) goto l_0x1a_112d; /* jz 0x112d */
            ii(0x1a_1128, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x1a_112b, 2); jmpw(0x1a_1130, 0x3); goto l_0x1a_1130;   /* jmp 0x1130 */
        l_0x1a_112d:
            ii(0x1a_112d, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
        l_0x1a_1130:
            ii(0x1a_1130, 1); popw(ds);                                 /* pop ds */
            ii(0x1a_1131, 1); leavew();                                 /* leave */
            ii(0x1a_1132, 3); retfw(0x2); return;                       /* retf 0x2 */
        }
    }
}
