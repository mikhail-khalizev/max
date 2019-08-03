using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3b25c439-a882-4840-a96d-077a6de8b4fe")]
        public void /* sys */ Method_1016_cab4()
        {
            ii(0x1016_cab4, 4); lea(eax, eax + 0);                      /* lea eax, [eax] */
            ii(0x1016_cab8, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1016_cabe, 3); sar(eax, 0x9);                          /* sar eax, 0x9 */
            ii(0x1016_cac1, 3); shl(edx, 0x8);                          /* shl edx, 0x8 */
            ii(0x1016_cac4, 7); mov(al, memb_a32[ds, edx + eax + 0x101e_0520]); /* mov al, [edx+eax+0x101e0520] */
            ii(0x1016_cacb, 1); nop();                                  /* nop */
            ii(0x1016_cacc, 1); retd(); return;                         /* ret */
        }
    }
}
