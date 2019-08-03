using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("45e96260-e849-4c16-95d3-f7c857d00df4")]
        public void /* sys */ sys_display_draw_0()
        {
            ii(0x1016_7484, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_7485, 1); pushd(edx);                             /* push edx */
            ii(0x1016_7486, 5); calld(/* sys */ 0x1016_7dac, 0x921);    /* call 0x10167dac */
            ii(0x1016_748b, 7); cmp(memd_a32[ds, 0x101b_ddbc], 0);      /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_7492, 2); if(jzd(0x1016_74a2, 0xe)) goto l_0x1016_74a2; /* jz 0x101674a2 */
            ii(0x1016_7494, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_7496, 2); if(jzd(0x1016_74a2, 0xa)) goto l_0x1016_74a2; /* jz 0x101674a2 */
            ii(0x1016_7498, 3); lea(edx, eax + 0x8);                    /* lea edx, [eax+0x8] */
            ii(0x1016_749b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_749d, 5); calld(/* sys */ 0x1016_7500, 0x5e);     /* call 0x10167500 */
        l_0x1016_74a2:
            ii(0x1016_74a2, 1); popd(edx);                              /* pop edx */
            ii(0x1016_74a3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_74a4, 1); retd(); return;                         /* ret */
        }
    }
}