using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4e889695-bf11-4ef4-ba23-1aef7761647f")]
        public void /* sys */ Method_1018_21ad()
        {
            ii(0x1018_21ad, 2); mov(cl, 0x7);                           /* mov cl, 0x7 */
            ii(0x1018_21af, 4); mov(ax, 0x2504);                        /* mov ax, 0x2504 */
            ii(0x1018_21b3, 6); mov(edx, memd_a32[ds, 0x101b_e80c]);    /* mov edx, [0x101be80c] */
            ii(0x1018_21b9, 1); pushd(ds);                              /* push ds */
            ii(0x1018_21ba, 7); mov(ds, memw_a32[ds, 0x101b_e810]);     /* mov ds, [0x101be810] */
            ii(0x1018_21c1, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_21c3, 1); popd(ds);                               /* pop ds */
            ii(0x1018_21c4, 7); cmp(memb_a32[ds, 0x101b_e58e], 0x3);    /* cmp byte [0x101be58e], 0x3 */
            ii(0x1018_21cb, 2); if(jld(0x1018_21d4, 0x7)) goto l_0x1018_21d4; /* jl 0x101821d4 */
            ii(0x1018_21cd, 5); calld(/* sys */ 0x1018_21e8, 0x16);     /* call 0x101821e8 */
            ii(0x1018_21d2, 2); jmpd(0x1018_21e7, 0x13); goto l_0x1018_21e7; /* jmp 0x101821e7 */
        l_0x1018_21d4:
            ii(0x1018_21d4, 3); mov(ecx, cr0);                          /* mov ecx, cr0 */
            ii(0x1018_21d7, 3); and(ecx, -0x7 /* 0xf9 */);              /* and ecx, 0xfffffff9 */
            ii(0x1018_21da, 7); mov(dx, memw_a32[ds, 0x101b_e812]);     /* mov dx, [0x101be812] */
            ii(0x1018_21e1, 3); or(cx, dx);                             /* or cx, dx */
            ii(0x1018_21e4, 3); mov(cr0, ecx);                          /* mov cr0, ecx */
        l_0x1018_21e7:
            ii(0x1018_21e7, 1); retd(); return;                         /* ret */
        }
    }
}
