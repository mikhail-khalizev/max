using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_ffc8-50dec0c2")]
        public void Method_0018_ffc8()
        {
            ii(0x18_ffc8, 4); enter(0, 0);                              /* enter 0x0, 0x0 */
            ii(0x18_ffcc, 1); push(ds);                                 /* push ds */
            ii(0x18_ffcd, 2); push(esi);                                /* push esi */
            ii(0x18_ffcf, 2); push(edi);                                /* push edi */
            ii(0x18_ffd1, 2); push(ebx);                                /* push ebx */
            ii(0x18_ffd3, 5); movzx(ebx, memw[ss, bp + 6]);             /* movzx ebx, word [bp+0x6] */
            ii(0x18_ffd8, 7); cmp(ebx, 0xff);                           /* cmp ebx, 0xff */
            ii(0x18_ffdf, 2); if(jbe_func(0x18_fffa, 0x19)) return;     /* jbe 0xfffa */
            ii(0x18_ffe1, 2); if(jmp_func(0x19_0034, 0x51)) return;     /* jmp 0x34 */
        }
    }
}
