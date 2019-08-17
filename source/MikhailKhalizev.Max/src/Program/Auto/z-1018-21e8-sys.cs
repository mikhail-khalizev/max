using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("93054553-a2c0-47ae-8022-20791ec329b8")]
        public void /* sys */ Method_1018_21e8()
        {
            ii(0x1018_21e8, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_21ea, 6); lea(edx, 0x101b_e7cc);                  /* lea edx, [0x101be7cc] */
            ii(0x1018_21f0, 4); mov(ax, 0x2535);                        /* mov ax, 0x2535 */
            ii(0x1018_21f4, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_21f6, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1018_21f8, 7); mov(cx, memw_a32[ds, 0x101b_e812]);     /* mov cx, [0x101be812] */
            ii(0x1018_21ff, 6); mov(memd_a32[ds, 0x101b_e7cc], ecx);    /* mov [0x101be7cc], ecx */
            ii(0x1018_2205, 1); inc(ebx);                               /* inc ebx */
            ii(0x1018_2206, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_2208, 1); retd(); return;                         /* ret */
        }
    }
}
