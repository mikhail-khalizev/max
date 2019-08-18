using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dae80bf9-f99b-4897-b8fd-31bc41ce9ec8")]
        public void Method_100b_b6f5()
        {
        l_0x100b_b6f5:
            ii(0x100b_b6f5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b6f8, 4); mov(memb_a32[ds, eax + 0x2], 0x8);      /* mov byte [eax+0x2], 0x8 */
            ii(0x100b_b6fc, 2); if(jmpd_func(0x100b_b745, 0x47)) return; /* jmp 0x100bb745 */
            ii(0x100b_b6fe, 2); mov(eax, eax);                          /* mov eax, eax */
            ii(0x100b_b700, 6); lds(esi, ds, esi - 0x492eeff5);         /* lds esi, [esi-0x492eeff5] */
            ii(0x100b_b706, 2); or(edx, memd_a32[ds, eax]);             /* or edx, [eax] */
            ii(0x100b_b708, 1); cmc();                                  /* cmc */
            ii(0x100b_b709, 2); mov(dh, 0xb);                           /* mov dh, 0xb */
            ii(0x100b_b70b, 2); adc(dl, bl);                            /* adc dl, bl */
            ii(0x100b_b70d, 2); mov(dh, 0xb);                           /* mov dh, 0xb */
            ii(0x100b_b70f, 2); adc(ch, dh);                            /* adc ch, dh */
            ii(0x100b_b711, 2); mov(dh, 0xb);                           /* mov dh, 0xb */
            ii(0x100b_b713, 2); adc(bl, ah);                            /* adc bl, ah */
            ii(0x100b_b715, 2); mov(dh, 0xb);                           /* mov dh, 0xb */
            ii(0x100b_b717, 2); adc(ah, ch);                            /* adc ah, ch */
            ii(0x100b_b719, 2); mov(dh, 0xb);                           /* mov dh, 0xb */
            ii(0x100b_b71b, 6); adc(memb_a32[ds, edx - 0xb37b], cl);    /* adc [edx-0xb37b], cl */
            ii(0x100b_b721, 1); throw new InvalidOperationException("Не декодированный код.");
            ii(0x100b_b722, 2); dec(al);                                /* dec al */
            ii(0x100b_b724, 6); mov(memb_a32[ss, ebp - 0xb8], al);      /* mov [ebp-0xb8], al */
            ii(0x100b_b72a, 7); cmp(memb_a32[ss, ebp - 0xb8], 0x6);     /* cmp byte [ebp-0xb8], 0x6 */
            ii(0x100b_b731, 2); if(jad(0x100b_b6f5, -0x3e)) goto l_0x100b_b6f5; /* ja 0x100bb6f5 */
            ii(0x100b_b733, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_b735, 6); mov(al, memb_a32[ss, ebp - 0xb8]);      /* mov al, [ebp-0xb8] */
            ii(0x100b_b73b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_b73e, 7); if(jmpd_abs(memd_a32[cs, eax + 0x100b_b700])) return; /* jmp dword [cs:eax+0x100bb700] */
        }
    }
}
