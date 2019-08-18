using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1028_920d-81fbd868")]
        public void Method_1028_920d()
        {
            ii(0x1028_920d, 1); pushd(ds);                              /* push ds */
            ii(0x1028_920e, 2); pushd(fs);                              /* push fs */
            ii(0x1028_9210, 1); popd(ds);                               /* pop ds */
            ii(0x1028_9211, 8); mov(memw_a32[fs, 0x752], fs);           /* mov [fs:0x752], fs */
            ii(0x1028_9219, 7); mov(memw_a32[ds, 0xb9], ds);            /* mov [0xb9], ds */
            ii(0x1028_9220, 7); mov(memw_a32[ds, 0xc1], ds);            /* mov [0xc1], ds */
            ii(0x1028_9227, 7); mov(memw_a32[ds, 0xc9], ds);            /* mov [0xc9], ds */
            ii(0x1028_922e, 7); mov(memw_a32[ds, 0xd1], ds);            /* mov [0xd1], ds */
            ii(0x1028_9235, 2); pushw(bx);                              /* push bx */
            ii(0x1028_9237, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1028_9239, 3); mov(bx, ax);                            /* mov bx, ax */
            ii(0x1028_923c, 3); shl(ebx, 0x2);                          /* shl ebx, 0x2 */
            ii(0x1028_923f, 2); popw(ax);                               /* pop ax */
            ii(0x1028_9241, 6); add(ebx, 0x105);                        /* add ebx, 0x105 */
            ii(0x1028_9247, 2); mov(ebx, memd_a32[ds, ebx]);            /* mov ebx, [ebx] */
            ii(0x1028_9249, 2); calld_abs(ebx);                         /* call ebx */
            ii(0x1028_924b, 1); popd(ds);                               /* pop ds */
            ii(0x1028_924c, 1); retfd(); return;                        /* retf */
        }
    }
}
