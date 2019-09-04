using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a8cf-acb40a88")]
        public void Method_0018_a8cf()
        {
            ii(0x18_a8cf, 3); call(0x18_a8f3, 0x21);                    /* call 0xa8f3 */
            ii(0x18_a8d2, 1); pushfw();                                 /* pushfw */
            ii(0x18_a8d3, 3); call(0x18_a893, -0x43);                   /* call 0xa893 */
            ii(0x18_a8d6, 1); popfw();                                  /* popfw */
            ii(0x18_a8d7, 2); if(jae(0x18_a8dc, 3)) goto l_0x18_a8dc;   /* jae 0xa8dc */
            ii(0x18_a8d9, 3); if(jmp_func(0x18_b03d, 0x761)) return;    /* jmp 0xb03d */
        l_0x18_a8dc:
            ii(0x18_a8dc, 3); mov(es, memw[ss, bp + 4]);                /* mov es, [bp+0x4] */
            ii(0x18_a8df, 3); mov(di, memw[ss, bp + 18]);               /* mov di, [bp+0x12] */
            ii(0x18_a8e2, 4); mov(si, memw[ds, 0xa]);                   /* mov si, [0xa] */
            ii(0x18_a8e6, 4); mov(cx, memw[ds, 0xe]);                   /* mov cx, [0xe] */
        l_0x18_a8ea:
            ii(0x18_a8ea, 1); lodsb();                                  /* lodsb */
            ii(0x18_a8eb, 1); stosb();                                  /* stosb */
            ii(0x18_a8ec, 2); or(al, al);                               /* or al, al */
            ii(0x18_a8ee, 2); if(loopne(0x18_a8ea, -6)) goto l_0x18_a8ea; /* loopne 0xa8ea */
            ii(0x18_a8f0, 3); if(jmp_func(0x18_b03d, 0x74a)) return;    /* jmp 0xb03d */
        }
    }
}
