using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_086c-a92b22c2")]
        public void Method_1007_086c()
        {
        l_0x1007_086c:
            ii(0x1007_086c, 2); if(jmpd_func(0x1007_089d, 0x2f)) return; /* jmp 0x1007089d */
            ii(0x1007_086e, 2); mov(eax, eax);                          /* mov eax, eax */
            ii(0x1007_0870, 2); sub(al, 0x8);                           /* sub al, 0x8 */
            ii(0x1007_0872, 1); popd(es);                               /* pop es */
            ii(0x1007_0873, 3); adc(memb_a32[ds, eax + ecx], bh);       /* adc [eax+ecx], bh */
            ii(0x1007_0876, 1); popd(es);                               /* pop es */
            ii(0x1007_0877, 4); adc(memb_a32[ds, eax + ecx + 0x7], cl); /* adc [eax+ecx+0x7], cl */
            ii(0x1007_087b, 4); adc(memb_a32[ds, eax + ecx + 0x7], bl); /* adc [eax+ecx+0x7], bl */
            ii(0x1007_087f, 6); adc(memb_a32[ds, ebx + 0x4589_ec45], cl); /* adc [ebx+0x4589ec45], cl */
            ii(0x1007_0885, 2); aam(0x66);                              /* aam 0x66 */
            ii(0x1007_0887, 4); cmp(memd_a32[ss, ebp - 0x2c], 0x3);     /* cmp dword [ebp-0x2c], 0x3 */
            ii(0x1007_088b, 2); if(jad(0x1007_086c, -0x21)) goto l_0x1007_086c; /* ja 0x1007086c */
            ii(0x1007_088d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_088f, 4); mov(ax, memw_a32[ss, ebp - 0x2c]);      /* mov ax, [ebp-0x2c] */
            ii(0x1007_0893, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1007_0896, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1007_0870])) return; /* jmp dword [cs:eax+0x10070870] */
        }
    }
}
