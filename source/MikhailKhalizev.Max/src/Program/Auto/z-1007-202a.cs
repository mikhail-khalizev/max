using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_202a-967efe87")]
        public void Method_1007_202a()
        {
        l_0x1007_202a:
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
            ii(0x1007_203f, 6); adc(memb_a32[ds, ebx - 0x177c07bb], cl); /* adc [ebx-0x177c07bb], cl */
            ii(0x1007_2045, 2); sbb(al, -0x77 /* 0x89 */);              /* sbb al, 0x89 */
            ii(0x1007_2047, 1); inc(ebp);                               /* inc ebp */
            ii(0x1007_2048, 6); cmp(memw_a32[ss, ebp - 0x10], 0x4);     /* lock cmp word [ebp-0x10], 0x4 */
            ii(0x1007_204e, 2); if(jad(0x1007_202a, -0x26)) goto l_0x1007_202a; /* ja 0x1007202a */
            ii(0x1007_2050, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_2052, 4); mov(ax, memw_a32[ss, ebp - 0x10]);      /* mov ax, [ebp-0x10] */
            ii(0x1007_2056, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1007_2059, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1007_202c])) return; /* jmp dword [cs:eax+0x1007202c] */
        }
    }
}
