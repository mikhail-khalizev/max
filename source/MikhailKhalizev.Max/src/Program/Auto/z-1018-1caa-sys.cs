using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_1caa-e2471428")]
        public void /* sys */ Method_1018_1caa()
        {
            ii(0x1018_1caa, 1); pushd(edx);                             /* push edx */
            ii(0x1018_1cab, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1018_1cad:
            ii(0x1018_1cad, 3); cmp(memb_a32[ds, edx], 0);              /* cmp byte [edx], 0x0 */
            ii(0x1018_1cb0, 2); if(jzd(0x1018_1cc0, 0xe)) goto l_0x1018_1cc0; /* jz 0x10181cc0 */
            ii(0x1018_1cb2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_1cb4, 2); mov(al, memb_a32[ds, edx]);             /* mov al, [edx] */
            ii(0x1018_1cb6, 5); calld(Definitions.sys_tolower, -0xf226); /* call 0x10172a95 */
            ii(0x1018_1cbb, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
            ii(0x1018_1cbd, 1); inc(edx);                               /* inc edx */
            ii(0x1018_1cbe, 2); jmpd(0x1018_1cad, -0x13); goto l_0x1018_1cad; /* jmp 0x10181cad */
        l_0x1018_1cc0:
            ii(0x1018_1cc0, 1); popd(edx);                              /* pop edx */
            ii(0x1018_1cc1, 1); retd();                                 /* ret */
        }
    }
}
