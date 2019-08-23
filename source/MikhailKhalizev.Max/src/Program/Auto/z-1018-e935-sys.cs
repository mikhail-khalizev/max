using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_e935-4d79e16c")]
        public void /* sys */ Method_1018_e935()
        {
            ii(0x1018_e935, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_e937, 2); mov(bl, ah);                            /* mov bl, ah */
            ii(0x1018_e939, 3); shl(eax, 0x18);                         /* shl eax, 0x18 */
            ii(0x1018_e93c, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1018_e93f, 7); add(eax, memd[ds, ebx * 4 + 0x101b_e8d0]); /* add eax, [ebx*4+0x101be8d0] */
            ii(0x1018_e946, 2); if(jmp_func(0x1018_e9b0, 0x68)) return; /* jmp 0x1018e9b0 */
        }
    }
}
