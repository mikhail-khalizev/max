using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("81cb06d9-1509-4382-bfce-0b88b18a2cf9")]
        public void /* sys */ Method_1016_a21c()
        {
            ii(0x1016_a21c, 1); pushd(edx);                             /* push edx */
            ii(0x1016_a21d, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1016_a220, 2); if(jged(0x1016_a242, 0x20)) goto l_0x1016_a242; /* jge 0x1016a242 */
            ii(0x1016_a222, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_a224, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1016_a227, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_a229, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1016_a22c, 7); cmp(memd_a32[ds, eax + 0x101c_f6e4], 0); /* cmp dword [eax+0x101cf6e4], 0x0 */
            ii(0x1016_a233, 2); if(jzd(0x1016_a242, 0xd)) goto l_0x1016_a242; /* jz 0x1016a242 */
            ii(0x1016_a235, 5); mov(edx, 0x101c_f6e4);                  /* mov edx, 0x101cf6e4 */
            ii(0x1016_a23a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_a23c, 6); mov(memd_a32[ds, 0x101c_f964], edx);    /* mov [0x101cf964], edx */
        l_0x1016_a242:
            ii(0x1016_a242, 1); popd(edx);                              /* pop edx */
            ii(0x1016_a243, 1); retd(); return;                         /* ret */
        }
    }
}