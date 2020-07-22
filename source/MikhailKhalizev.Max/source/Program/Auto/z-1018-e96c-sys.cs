using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_e96c-c5a904f2")]
        public void /* sys */ Method_1018_e96c()
        {
            ii(0x1018_e96c, 3);  mov(ax, memw[ds, esi]);               /* mov ax, [esi] */
            ii(0x1018_e96f, 3);  add(esi, 2);                          /* add esi, 0x2 */
            ii(0x1018_e972, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1018_e974, 2);  mov(bl, ah);                          /* mov bl, ah */
            ii(0x1018_e976, 3);  shl(eax, 0x18);                       /* shl eax, 0x18 */
            ii(0x1018_e979, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x1018_e97c, 7);  add(eax, memd[ds, ebx * 4 + 0x101b_e8d0]);/* add eax, [ebx*4+0x101be8d0] */
            ii(0x1018_e983, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1018_e986, 2);  jmp_func(0x1018_e9b0, 0x28);          /* jmp 0x1018e9b0 */
        }
    }
}
