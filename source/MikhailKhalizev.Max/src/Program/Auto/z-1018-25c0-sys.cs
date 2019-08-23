using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_25c0-c4534305")]
        public void /* sys */ Method_1018_25c0()
        {
            ii(0x1018_25c0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_25c1, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1018_25c3, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1018_25c5, 3); lea(edx, eax + 0x4);                    /* lea edx, [eax+0x4] */
            ii(0x1018_25c8, 6); mov(memd_a32[ds, edx], 0xfeed_face);    /* mov dword [edx], 0xfeedface */
            ii(0x1018_25ce, 4); lea(edx, eax + ebx - 0x4);              /* lea edx, [eax+ebx-0x4] */
            ii(0x1018_25d2, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1018_25d5, 6); mov(memd_a32[ds, edx], 0xbeef_cafe);    /* mov dword [edx], 0xbeefcafe */
            ii(0x1018_25db, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_25dc, 1); retd();                                 /* ret */
        }
    }
}
