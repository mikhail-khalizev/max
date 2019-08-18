using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4789-6a2192cf")]
        public void /* sys */ Method_1019_4789()
        {
            ii(0x1019_4789, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_478a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_478b, 1); pushd(esi);                             /* push esi */
            ii(0x1019_478c, 1); pushd(edi);                             /* push edi */
            ii(0x1019_478d, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1019_4790, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1019_4792, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1019_4794, 5); and(memb_a32[ss, esp + 0x4], -0x2 /* 0xfe */); /* and byte [esp+0x4], 0xfe */
        }
    }
}
