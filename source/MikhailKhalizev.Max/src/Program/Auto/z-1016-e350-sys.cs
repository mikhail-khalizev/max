using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_e350-bfcfa183")]
        public void /* sys */ Method_1016_e350()
        {
            ii(0x1016_e350, 1); pushd(edx);                             /* push edx */
            ii(0x1016_e351, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_e353, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1016_e355:
            ii(0x1016_e355, 7); cmp(memd_a32[ds, eax + 0x1020_88b8], 0); /* cmp dword [eax+0x102088b8], 0x0 */
            ii(0x1016_e35c, 2); if(jzd(0x1016_e35f, 0x1)) goto l_0x1016_e35f; /* jz 0x1016e35f */
            ii(0x1016_e35e, 1); inc(edx);                               /* inc edx */
        l_0x1016_e35f:
            ii(0x1016_e35f, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1016_e362, 3); cmp(eax, 0x28);                         /* cmp eax, 0x28 */
            ii(0x1016_e365, 2); if(jnzd(0x1016_e355, -0x12)) goto l_0x1016_e355; /* jnz 0x1016e355 */
            ii(0x1016_e367, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_e369, 1); popd(edx);                              /* pop edx */
            ii(0x1016_e36a, 1); retd();                                 /* ret */
        }
    }
}
