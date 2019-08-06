using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("af644e09-74c2-44c0-b697-6ffc6d7dc00b")]
        public void /* sys */ Method_1017_0d2c()
        {
            ii(0x1017_0d2c, 1); pushd(edx);                             /* push edx */
            ii(0x1017_0d2d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_0d2f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_0d31, 2); if(jzd(0x1017_0d53, 0x20)) goto l_0x1017_0d53; /* jz 0x10170d53 */
            ii(0x1017_0d33, 4); cmp(memd_a32[ds, eax + 0xc], 0);        /* cmp dword [eax+0xc], 0x0 */
            ii(0x1017_0d37, 2); if(jzd(0x1017_0d48, 0xf)) goto l_0x1017_0d48; /* jz 0x10170d48 */
            ii(0x1017_0d39, 4); cmp(memb_a32[ds, eax + 0x10], 0x1);     /* cmp byte [eax+0x10], 0x1 */
            ii(0x1017_0d3d, 2); if(jnzd(0x1017_0d48, 0x9)) goto l_0x1017_0d48; /* jnz 0x10170d48 */
            ii(0x1017_0d3f, 3); mov(eax, memd_a32[ds, edx + 0xc]);      /* mov eax, [edx+0xc] */
            ii(0x1017_0d42, 6); calld_abs(memd_a32[ds, 0x101b_e1d0]);   /* call dword [0x101be1d0] */ /* Вызов '0x1017_11b4'. */
        l_0x1017_0d48:
            ii(0x1017_0d48, 7); mov(memd_a32[ds, edx + 0xc], StringDefinitions.Empty3); /* mov dword [edx+0xc], 0x101b2f00 */
            ii(0x1017_0d4f, 4); mov(memb_a32[ds, edx + 0x10], 0);       /* mov byte [edx+0x10], 0x0 */
        l_0x1017_0d53:
            ii(0x1017_0d53, 1); popd(edx);                              /* pop edx */
            ii(0x1017_0d54, 1); retd(); return;                         /* ret */
        }
    }
}
