using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_8e58-663b3a1")]
        public void /* sys */ Method_1017_8e58()
        {
            ii(0x1017_8e58, 1); pushd(edx);                             /* push edx */
            ii(0x1017_8e59, 6); mov(dl, memb_a32[ds, 0x101b_e1f2]);     /* mov dl, [0x101be1f2] */
            ii(0x1017_8e5f, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1017_8e61, 3); test(dl, 0x1);                          /* test dl, 0x1 */
            ii(0x1017_8e64, 2); if(jzd(0x1017_8e68, 0x2)) goto l_0x1017_8e68; /* jz 0x10178e68 */
            ii(0x1017_8e66, 2); mov(ah, 0x2);                           /* mov ah, 0x2 */
        l_0x1017_8e68:
            ii(0x1017_8e68, 7); test(memb_a32[ds, 0x101b_e1f2], 0x2);   /* test byte [0x101be1f2], 0x2 */
            ii(0x1017_8e6f, 2); if(jzd(0x1017_8e74, 0x3)) goto l_0x1017_8e74; /* jz 0x10178e74 */
            ii(0x1017_8e71, 3); or(ah, 0x4);                            /* or ah, 0x4 */
        l_0x1017_8e74:
            ii(0x1017_8e74, 7); test(memb_a32[ds, 0x101b_e1f2], 0x4);   /* test byte [0x101be1f2], 0x4 */
            ii(0x1017_8e7b, 2); if(jzd(0x1017_8e80, 0x3)) goto l_0x1017_8e80; /* jz 0x10178e80 */
            ii(0x1017_8e7d, 3); or(ah, 0x1);                            /* or ah, 0x1 */
        l_0x1017_8e80:
            ii(0x1017_8e80, 2); mov(al, 0xed);                          /* mov al, 0xed */
            ii(0x1017_8e82, 5); mov(edx, 0x60);                         /* mov edx, 0x60 */
            ii(0x1017_8e87, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1017_8e88, 2); mov(al, ah);                            /* mov al, ah */
            ii(0x1017_8e8a, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1017_8e8b, 1); popd(edx);                              /* pop edx */
            ii(0x1017_8e8c, 1); retd();                                 /* ret */
        }
    }
}
