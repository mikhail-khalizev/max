using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("96b3fca3-9ec6-4508-93c3-54ba40f2ffc8")]
        public void /* sys */ Method_1018_1f92()
        {
            ii(0x1018_1f92, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_1f93, 1); pushd(edx);                             /* push edx */
            ii(0x1018_1f94, 5); mov(edx, /* sys */ 0x1019_670d);        /* mov edx, 0x1019670d */
            ii(0x1018_1f99, 5); mov(ebx, /* sys */ 0x1019_6856);        /* mov ebx, 0x10196856 */
            ii(0x1018_1f9e, 6); mov(memd_a32[ds, 0x101c_1b60], edx);    /* mov [0x101c1b60], edx */
            ii(0x1018_1fa4, 6); mov(memd_a32[ds, 0x101c_1b64], ebx);    /* mov [0x101c1b64], ebx */
            ii(0x1018_1faa, 1); popd(edx);                              /* pop edx */
            ii(0x1018_1fab, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_1fac, 1); retd(); return;                         /* ret */
        }
    }
}