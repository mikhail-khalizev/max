using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0a91dfab-c6f9-4a82-a96a-1d3a6cb9dc24")]
        public void /* sys */ Method_1016_cae8()
        {
            ii(0x1016_cae8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_cae9, 1); pushd(edx);                             /* push edx */
            ii(0x1016_caea, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_caec, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1016_caee, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1016_caf5, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_caf7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_caf9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_cafb, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_cafd, 6); mov(al, memb_a32[ds, edx + 0x101b_dec0]); /* mov al, [edx+0x101bdec0] */
            ii(0x1016_cb03, 6); mov(bl, memb_a32[ds, edx + 0x101b_dec1]); /* mov bl, [edx+0x101bdec1] */
            ii(0x1016_cb09, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1016_cb0b, 2); sar(ebx, 0x1);                          /* sar ebx, 1 */
            ii(0x1016_cb0d, 3); shl(eax, 0x5);                          /* shl eax, 0x5 */
            ii(0x1016_cb10, 6); mov(dl, memb_a32[ds, edx + 0x101b_dec2]); /* mov dl, [edx+0x101bdec2] */
            ii(0x1016_cb16, 2); or(eax, ebx);                           /* or eax, ebx */
            ii(0x1016_cb18, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1016_cb1e, 3); shl(eax, 0x5);                          /* shl eax, 0x5 */
            ii(0x1016_cb21, 2); sar(edx, 0x1);                          /* sar edx, 1 */
            ii(0x1016_cb23, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1016_cb25, 1); popd(edx);                              /* pop edx */
            ii(0x1016_cb26, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_cb27, 1); retd(); return;                         /* ret */
        }
    }
}
