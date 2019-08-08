using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9105adaa-c291-4d1b-aa98-641262874176")]
        public void Method_0014_ffc8()
        {
            ii(0x14_ffc8, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x14_ffcc, 1); pushw(ds);                                /* push ds */
            ii(0x14_ffcd, 2); pushd(esi);                               /* push esi */
            ii(0x14_ffcf, 2); pushd(edi);                               /* push edi */
            ii(0x14_ffd1, 2); pushd(ebx);                               /* push ebx */
            ii(0x14_ffd3, 5); movzx(ebx, memw_a16[ss, bp + 0x6]);       /* movzx ebx, word [bp+0x6] */
            ii(0x14_ffd8, 7); cmp(ebx, 0xff);                           /* cmp ebx, 0xff */
            ii(0x14_ffdf, 2); if(jbew_func(0x14_fffa, 0x19)) return;    /* jbe 0xfffa */
            ii(0x14_ffe1, 2); if(jmpw_func(0x15_0034, 0x51)) return;    /* jmp 0x34 */
        }
    }
}
