using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("15456257-9857-40a6-9786-3e227a6f5634")]
        public void /* sys */ Method_1018_2113()
        {
            ii(0x1018_2113, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_2115, 6); lea(edx, 0x101b_e7cc);                  /* lea edx, [0x101be7cc] */
            ii(0x1018_211b, 4); mov(ax, 0x2535);                        /* mov ax, 0x2535 */
            ii(0x1018_211f, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_2121, 7); or(memd_a32[ds, 0x101b_e7cc], 0x4);     /* or dword [0x101be7cc], 0x4 */
            ii(0x1018_2128, 7); and(memd_a32[ds, 0x101b_e7cc], -0x3 /* 0xfd */); /* and dword [0x101be7cc], 0xfffffffd */
            ii(0x1018_212f, 1); inc(ebx);                               /* inc ebx */
            ii(0x1018_2130, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_2132, 1); retd(); return;                         /* ret */
        }
    }
}