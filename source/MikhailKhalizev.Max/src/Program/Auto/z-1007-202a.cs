using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_202a-647aac8b")]
        public void Method_1007_202a()
        {
            ii(0x1007_202a, 2); if(jmpd_func(0x1007_2060, 0x34)) return; /* jmp 0x10072060 */
            ii(0x1007_202c, 2); sbb(memb_a32[ds, eax], ah);             /* sbb [eax], ah */
            ii(0x1007_202e, 1); popd(es);                               /* pop es */
            ii(0x1007_202f, 2); adc(memb_a32[ds, ecx], ah);             /* adc [ecx], ah */
            ii(0x1007_2031, 2); and(memb_a32[ds, edi], al);             /* and [edi], al */
            ii(0x1007_2033, 2); adc(memb_a32[ds, ecx], ah);             /* adc [ecx], ah */
            ii(0x1007_2035, 2); and(memb_a32[ds, edi], al);             /* and [edi], al */
            ii(0x1007_2037, 2); adc(memb_a32[ds, edx], ch);             /* adc [edx], ch */
            ii(0x1007_2039, 2); and(memb_a32[ds, edi], al);             /* and [edi], al */
            ii(0x1007_203b, 2); adc(memb_a32[ds, ecx], ah);             /* adc [ecx], ah */
            ii(0x1007_203d, 2); and(memb_a32[ds, edi], al);             /* and [edi], al */
        }
    }
}
