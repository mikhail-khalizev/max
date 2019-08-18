using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_5944-9c208e1a")]
        public void /* sys */ Method_1018_5944()
        {
            ii(0x1018_5944, 5); mov(eax, /* sys */ 0x1018_5b08);        /* mov eax, 0x10185b08 */
            ii(0x1018_5949, 5); calld(/* sys */ 0x1016_b42c, -0x1_a522); /* call 0x1016b42c */
            ii(0x1018_594e, 7); cmp(memd_a32[ds, 0x1020_a2a4], -0x1 /* 0xff */); /* cmp dword [0x1020a2a4], 0xffffffff */
            ii(0x1018_5955, 2); if(jzd(0x1018_5965, 0xe)) goto l_0x1018_5965; /* jz 0x10185965 */
        l_0x1018_5957:
            ii(0x1018_5957, 5); calld(/* sys */ 0x1018_5b5c, 0x200);    /* call 0x10185b5c */
            ii(0x1018_595c, 7); cmp(memd_a32[ds, 0x1020_a2a4], -0x1 /* 0xff */); /* cmp dword [0x1020a2a4], 0xffffffff */
            ii(0x1018_5963, 2); if(jnzd(0x1018_5957, -0xe)) goto l_0x1018_5957; /* jnz 0x10185957 */
        l_0x1018_5965:
            ii(0x1018_5965, 1); retd(); return;                         /* ret */
        }
    }
}
