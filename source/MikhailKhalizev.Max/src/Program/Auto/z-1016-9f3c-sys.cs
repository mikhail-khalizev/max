using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("22c807fb-3316-4f23-b7cd-d56771e7da47")]
        public void /* sys */ Method_1016_9f3c()
        {
            ii(0x1016_9f3c, 1); pushd(edx);                             /* push edx */
            ii(0x1016_9f3d, 2); xor(edx, edx);                          /* xor edx, edx */
        l_0x1016_9f3f:
            ii(0x1016_9f3f, 7); cmp(memd_a32[ds, edx + 0x101c_f6e4], 0); /* cmp dword [edx+0x101cf6e4], 0x0 */
            ii(0x1016_9f46, 2); if(jzd(0x1016_9f5e, 0x16)) goto l_0x1016_9f5e; /* jz 0x10169f5e */
            ii(0x1016_9f48, 6); mov(eax, memd_a32[ds, edx + 0x101c_f6f0]); /* mov eax, [edx+0x101cf6f0] */
            ii(0x1016_9f4e, 5); calld(Definitions.sys_free_internal, 0x18501); /* call 0x10182454 */
            ii(0x1016_9f53, 6); mov(eax, memd_a32[ds, edx + 0x101c_f6f4]); /* mov eax, [edx+0x101cf6f4] */
            ii(0x1016_9f59, 5); calld(Definitions.sys_free_internal, 0x184f6); /* call 0x10182454 */
        l_0x1016_9f5e:
            ii(0x1016_9f5e, 3); add(edx, 0x14);                         /* add edx, 0x14 */
            ii(0x1016_9f61, 6); cmp(edx, 0xc8);                         /* cmp edx, 0xc8 */
            ii(0x1016_9f67, 2); if(jnzd(0x1016_9f3f, -0x2a)) goto l_0x1016_9f3f; /* jnz 0x10169f3f */
            ii(0x1016_9f69, 1); popd(edx);                              /* pop edx */
            ii(0x1016_9f6a, 1); retd(); return;                         /* ret */
        }
    }
}
