using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c4ff7556-983d-44c3-a573-3d6d0915430f")]
        public void /* sys */ Method_1016_b7a0()
        {
            ii(0x1016_b7a0, 5); mov(memd_a32[ds, 0x101c_fb5c], eax);    /* mov [0x101cfb5c], eax */
            ii(0x1016_b7a5, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_b7a7, 2); if(jnzd(0x1016_b7ae, 0x5)) goto l_0x1016_b7ae; /* jnz 0x1016b7ae */
            ii(0x1016_b7a9, 5); mov(edx, /* sys */ 0x1016_b69c);        /* mov edx, 0x1016b69c */
        l_0x1016_b7ae:
            ii(0x1016_b7ae, 6); mov(memd_a32[ds, 0x101c_fb68], edx);    /* mov [0x101cfb68], edx */
            ii(0x1016_b7b4, 1); retd(); return;                         /* ret */
        }
    }
}