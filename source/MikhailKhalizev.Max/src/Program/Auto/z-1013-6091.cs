using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_6091-d3a4932")]
        public void Method_1013_6091()
        {
            ii(0x1013_6091, 2); if(jmpd_func(0x1013_60c5, 0x32)) return; /* jmp 0x101360c5 */
            ii(0x1013_6093, 1); nop();                                  /* nop */
            ii(0x1013_6094, 2); pushad();                               /* pushad */
            ii(0x1013_6096, 2); adc(edx, memd_a32[ds, eax]);            /* adc edx, [eax] */
            ii(0x1013_6098, 1); insd_a32();                             /* insd */
            ii(0x1013_6099, 1); pushad();                               /* pushad */
            ii(0x1013_609a, 2); adc(edx, memd_a32[ds, eax]);            /* adc edx, [eax] */
            ii(0x1013_609c, 2); if(jbed_func(0x1013_60fe, 0x60)) return; /* jbe 0x101360fe */
            ii(0x1013_609e, 2); adc(edx, memd_a32[ds, eax]);            /* adc edx, [eax] */
            ii(0x1013_60a0, 2); if(jgd_func(0x1013_6102, 0x60)) return; /* jg 0x10136102 */
            ii(0x1013_60a2, 2); adc(edx, memd_a32[ds, eax]);            /* adc edx, [eax] */
            ii(0x1013_60a4, 3); mov(memb_a32[ds, eax + 0x13], ah);      /* mov [eax+0x13], ah */
        }
    }
}
