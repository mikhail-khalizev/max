using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("51b1440b-bf26-4553-8e96-903c81509f8b")]
        public void Method_1013_6091()
        {
        l_0x1013_6091:
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
            ii(0x1013_60a7, 6); adc(memb_a32[ds, ebx + 0x4589_e445], cl); /* adc [ebx+0x4589e445], cl */
            ii(0x1013_60ad, 3); fsub(memq_a32[ds, esi - 0x7d]);         /* fsub qword [esi-0x7d] */
            ii(0x1013_60b0, 2); if(jged_func(0x1013_608e, -0x24)) return; /* jge 0x1013608e */
            ii(0x1013_60b2, 2); add(al, 0x77);                          /* add al, 0x77 */
            ii(0x1013_60b4, 2); fdiv(memq_a32[ds, ecx]);                /* fdiv qword [ecx] */
            ii(0x1013_60b6, 4); shl(memb_a32[ds, esi - 0x75], 0x45);    /* shl byte [esi-0x75], 0x45 */
            ii(0x1013_60ba, 2); fadd(ST(1), ST(0));                     /* fadd st1, st0 */
            ii(0x1013_60bc, 2); if(loopned_a32_func(0x1013_60c0, 0x2)) return; /* loopne 0x101360c0 */ /* Адрес перехода делит инструкцию в этой функции пополам. */
            ii(0x1013_60be, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1013_6094])) return; /* jmp dword [cs:eax+0x10136094] */
        }
    }
}
