using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_086c-9dc9f6df")]
        public void Method_1007_086c()
        {
            ii(0x1007_086c, 2); if(jmpd_func(0x1007_089d, 0x2f)) return; /* jmp 0x1007089d */
            ii(0x1007_086e, 2); mov(eax, eax);                          /* mov eax, eax */
            ii(0x1007_0870, 2); sub(al, 0x8);                           /* sub al, 0x8 */
            ii(0x1007_0872, 1); popd(es);                               /* pop es */
            ii(0x1007_0873, 3); adc(memb_a32[ds, eax + ecx], bh);       /* adc [eax+ecx], bh */
            ii(0x1007_0876, 1); popd(es);                               /* pop es */
            ii(0x1007_0877, 4); adc(memb_a32[ds, eax + ecx + 0x7], cl); /* adc [eax+ecx+0x7], cl */
            ii(0x1007_087b, 4); adc(memb_a32[ds, eax + ecx + 0x7], bl); /* adc [eax+ecx+0x7], bl */
        }
    }
}
