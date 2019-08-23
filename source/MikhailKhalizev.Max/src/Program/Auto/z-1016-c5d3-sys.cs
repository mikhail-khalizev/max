using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_c5d3-ab9ef2a9")]
        public void /* sys */ Method_1016_c5d3()
        {
        l_0x1016_c5d3:
            ii(0x1016_c5d3, 3); shr(ax, 0x1);                           /* shr ax, 1 */
            ii(0x1016_c5d6, 2); if(jbed(0x1016_c5dc, 0x4)) goto l_0x1016_c5dc; /* jbe 0x1016c5dc */
            ii(0x1016_c5d8, 2); fmul(ST(0), ST(0));                     /* fmul st0, st0 */
            ii(0x1016_c5da, 2); jmpd(0x1016_c5d3, -0x9); goto l_0x1016_c5d3; /* jmp 0x1016c5d3 */
        l_0x1016_c5dc:
            ii(0x1016_c5dc, 2); if(jaed(0x1016_c5f1, 0x13)) goto l_0x1016_c5f1; /* jae 0x1016c5f1 */
            ii(0x1016_c5de, 2); fld(ST(0));                             /* fld st0 */
        l_0x1016_c5e0:
            ii(0x1016_c5e0, 2); if(jzd(0x1016_c5ed, 0xb)) goto l_0x1016_c5ed; /* jz 0x1016c5ed */
            ii(0x1016_c5e2, 2); fmul(ST(0), ST(0));                     /* fmul st0, st0 */
            ii(0x1016_c5e4, 3); shr(ax, 0x1);                           /* shr ax, 1 */
            ii(0x1016_c5e7, 2); if(jaed(0x1016_c5eb, 0x2)) goto l_0x1016_c5eb; /* jae 0x1016c5eb */
            ii(0x1016_c5e9, 2); fmul(ST(1), ST(0));                     /* fmul st1, st0 */
        l_0x1016_c5eb:
            ii(0x1016_c5eb, 2); jmpd(0x1016_c5e0, -0xd); goto l_0x1016_c5e0; /* jmp 0x1016c5e0 */
        l_0x1016_c5ed:
            ii(0x1016_c5ed, 2); fstp(ST(0));                            /* fstp st0 */
            ii(0x1016_c5ef, 2); jmpd(0x1016_c5f5, 0x4); goto l_0x1016_c5f5; /* jmp 0x1016c5f5 */
        l_0x1016_c5f1:
            ii(0x1016_c5f1, 2); fstp(ST(0));                            /* fstp st0 */
            ii(0x1016_c5f3, 2); fld1();                                 /* fld1 */
        l_0x1016_c5f5:
            ii(0x1016_c5f5, 1); retd();                                 /* ret */
        }
    }
}
