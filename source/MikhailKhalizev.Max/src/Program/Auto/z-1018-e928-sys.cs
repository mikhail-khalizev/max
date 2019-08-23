using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_e928-7835fbec")]
        public void /* sys */ Method_1018_e928()
        {
            ii(0x1018_e928, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_e92a, 2); mov(al, memb[ds, esi]);                 /* mov al, [esi] */
            ii(0x1018_e92c, 1); inc(esi);                               /* inc esi */
            ii(0x1018_e92d, 8); mov(ax, memw[ds, eax * 2 + 0x101b_eed0]); /* mov ax, [eax*2+0x101beed0] */
            ii(0x1018_e935, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_e937, 2); mov(bl, ah);                            /* mov bl, ah */
            ii(0x1018_e939, 3); shl(eax, 0x18);                         /* shl eax, 0x18 */
            ii(0x1018_e93c, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1018_e93f, 7); add(eax, memd[ds, ebx * 4 + 0x101b_e8d0]); /* add eax, [ebx*4+0x101be8d0] */
            ii(0x1018_e946, 2); if(jmp_func(0x1018_e9b0, 0x68)) return; /* jmp 0x1018e9b0 */
        }
    }
}
