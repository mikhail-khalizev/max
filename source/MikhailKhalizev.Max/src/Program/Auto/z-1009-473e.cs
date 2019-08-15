using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6b36b48a-84ab-4b0d-84ba-a89c810a2814")]
        public void Method_1009_473e()
        {
        l_0x1009_473e:
            ii(0x1009_473e, 2); if(jmpd_func(0x1009_4781, 0x41)) return; /* jmp 0x10094781 */
            ii(0x1009_4740, 3); and(memd_a32[ss, ebp + 0x9], eax);      /* and [ebp+0x9], eax */
            ii(0x1009_4743, 2); adc(memb_a32[ds, esi], bh);             /* adc [esi], bh */
            ii(0x1009_4745, 1); inc(edi);                               /* inc edi */
            ii(0x1009_4746, 2); or(memd_a32[ds, eax], edx);             /* or [eax], edx */
            ii(0x1009_4748, 1); dec(ecx);                               /* dec ecx */
            ii(0x1009_4749, 1); inc(ebp);                               /* inc ebp */
            ii(0x1009_474a, 2); or(memd_a32[ds, eax], edx);             /* or [eax], edx */
            ii(0x1009_474c, 1); stosd_a32();                            /* stosd */
            ii(0x1009_474d, 1); inc(ebp);                               /* inc ebp */
            ii(0x1009_474e, 2); or(memd_a32[ds, eax], edx);             /* or [eax], edx */
            ii(0x1009_4750, 5); or(eax, 0x3510_0946);                   /* or eax, 0x35100946 */
            ii(0x1009_4755, 1); inc(esi);                               /* inc esi */
            ii(0x1009_4756, 2); or(memd_a32[ds, eax], edx);             /* or [eax], edx */
            ii(0x1009_4758, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_4759, 1); inc(esi);                               /* inc esi */
            ii(0x1009_475a, 2); or(memd_a32[ds, eax], edx);             /* or [eax], edx */
            ii(0x1009_475c, 2); mov(bh, 0x46);                          /* mov bh, 0x46 */
            ii(0x1009_475e, 2); or(memd_a32[ds, eax], edx);             /* or [eax], edx */
            ii(0x1009_4760, 3); fild(memw_a32[ds, esi + 0x9]);          /* fild word [esi+0x9] */
            ii(0x1009_4763, 6); adc(memb_a32[ds, edx - 0x370123bb], cl); /* adc [edx-0x370123bb], cl */
            ii(0x1009_4769, 3); mov(memb_a32[ss, ebp - 0x28], al);      /* mov [ebp-0x28], al */
            ii(0x1009_476c, 4); cmp(memb_a32[ss, ebp - 0x28], 0x8);     /* cmp byte [ebp-0x28], 0x8 */
            ii(0x1009_4770, 2); if(jad(0x1009_473e, -0x34)) goto l_0x1009_473e; /* ja 0x1009473e */
            ii(0x1009_4772, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_4774, 3); mov(al, memb_a32[ss, ebp - 0x28]);      /* mov al, [ebp-0x28] */
            ii(0x1009_4777, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_477a, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1009_4740])) return; /* jmp dword [cs:eax+0x10094740] */
        }
    }
}
