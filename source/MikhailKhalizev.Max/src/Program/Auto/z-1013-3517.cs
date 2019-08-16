using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2835730b-5ec5-4bc5-8075-5159dd29ac0d")]
        public void Method_1013_3517()
        {
            ii(0x1013_3517, 2); if(jmpd_func(0x1013_3557, 0x3e)) return; /* jmp 0x10133557 */
            ii(0x1013_3519, 3); lea(eax, eax + 0);                      /* lea eax, [eax] */
            ii(0x1013_351c, 2); sysenter();                             /* sysenter */
            ii(0x1013_351e, 2); adc(edx, memd_a32[ds, eax]);            /* adc edx, [eax] */
            ii(0x1013_3520, 3); xor(memd_a32[ds, ebx + edx], esi);      /* xor [ebx+edx], esi */
            ii(0x1013_3523, 3); adc(memb_a32[ds, ebx + 0x34], dl);      /* adc [ebx+0x34], dl */
            ii(0x1013_3526, 2); adc(edx, memd_a32[ds, eax]);            /* adc edx, [eax] */
            ii(0x1013_3528, 2); if(jnzd_func(0x1013_355e, 0x34)) return; /* jnz 0x1013355e */
            ii(0x1013_352a, 2); adc(edx, memd_a32[ds, eax]);            /* adc edx, [eax] */
            ii(0x1013_352c, 1); xchg(edi, eax);                         /* xchg edi, eax */
            ii(0x1013_352d, 2); xor(al, 0x13);                          /* xor al, 0x13 */
            ii(0x1013_352f, 6); adc(memb_a32[ds, ecx - 0x24efeccc], bh); /* adc [ecx-0x24efeccc], bh */
            ii(0x1013_3535, 2); xor(al, 0x13);                          /* xor al, 0x13 */
            ii(0x1013_3537, 2); adc(dl, bh);                            /* adc dl, bh */
            ii(0x1013_3539, 2); xor(al, 0x13);                          /* xor al, 0x13 */
            ii(0x1013_353b, 6); adc(memb_a32[ds, edx + 0x4588_e845], cl); /* adc [edx+0x4588e845], cl */
            ii(0x1013_3541, 7); rol(memb_a32[ds, eax + 0x7707_c07d], 0xcf); /* rol byte [eax+0x7707c07d], 0xcf */
            ii(0x1013_3548, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_354a, 3); mov(al, memb_a32[ss, ebp - 0x40]);      /* mov al, [ebp-0x40] */
            ii(0x1013_354d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_3550, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1013_351c])) return; /* jmp dword [cs:eax+0x1013351c] */
        }
    }
}
