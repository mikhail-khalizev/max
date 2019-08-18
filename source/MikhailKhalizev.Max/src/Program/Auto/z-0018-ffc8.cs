using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f2395a42-0be3-40f1-90a1-8426467b05b0")]
        public void Method_0018_ffc8()
        {
            ii(0x18_ffc8, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x18_ffcc, 1); pushw(ds);                                /* push ds */
            ii(0x18_ffcd, 2); pushd(esi);                               /* push esi */
            ii(0x18_ffcf, 2); pushd(edi);                               /* push edi */
            ii(0x18_ffd1, 2); pushd(ebx);                               /* push ebx */
            ii(0x18_ffd3, 5); movzx(ebx, memw_a16[ss, bp + 0x6]);       /* movzx ebx, word [bp+0x6] */
            ii(0x18_ffd8, 7); cmp(ebx, 0xff);                           /* cmp ebx, 0xff */
            ii(0x18_ffdf, 2); if(jbew_func(0x18_fffa, 0x19)) return;    /* jbe 0xfffa */
            ii(0x18_ffe1, 2); if(jmpw_func(0x19_0034, 0x51)) return;    /* jmp 0x34 */
        }
    }
}
