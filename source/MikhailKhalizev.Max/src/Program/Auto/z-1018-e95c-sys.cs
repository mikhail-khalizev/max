using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_e95c-23be12ac")]
        public void /* sys */ Method_1018_e95c()
        {
            ii(0x1018_e95c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_e95e, 2); mov(al, memb[ds, esi]);                 /* mov al, [esi] */
            ii(0x1018_e960, 1); inc(esi);                               /* inc esi */
            ii(0x1018_e961, 8); mov(ax, memw[ds, eax * 2 + 0x101b_ecd0]); /* mov ax, [eax*2+0x101becd0] */
            ii(0x1018_e969, 2); jmp(0x1018_e972, 7); goto l_0x1018_e972; /* jmp 0x1018e972 */
        //  ii(0x1018_e96b, 1); nop();                                  /* nop */
        //  ii(0x1018_e96c, 3); mov(ax, memw[ds, esi]);                 /* mov ax, [esi] */
        //  ii(0x1018_e96f, 3); add(esi, 2);                            /* add esi, 0x2 */
        l_0x1018_e972:
            ii(0x1018_e972, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_e974, 2); mov(bl, ah);                            /* mov bl, ah */
            ii(0x1018_e976, 3); shl(eax, 0x18);                         /* shl eax, 0x18 */
            ii(0x1018_e979, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1018_e97c, 7); add(eax, memd[ds, ebx * 4 + 0x101b_e8d0]); /* add eax, [ebx*4+0x101be8d0] */
            ii(0x1018_e983, 3); add(eax, memd[ss, ebp - 0xc]);          /* add eax, [ebp-0xc] */
            ii(0x1018_e986, 2); if(jmp_func(0x1018_e9b0, 0x28)) return; /* jmp 0x1018e9b0 */
        }
    }
}
