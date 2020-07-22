using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4789-6a2192cf")]
        public void /* sys */ Method_1019_4789()
        {
            ii(0x1019_4789, 1);  push(ebx);                            /* push ebx */
            ii(0x1019_478a, 1);  push(ecx);                            /* push ecx */
            ii(0x1019_478b, 1);  push(esi);                            /* push esi */
            ii(0x1019_478c, 1);  push(edi);                            /* push edi */
            ii(0x1019_478d, 3);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1019_4790, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1019_4792, 2);  mov(edi, edx);                        /* mov edi, edx */
            ii(0x1019_4794, 5);  and(memb[ss, esp + 4], -2 /* 0xfe */);/* and byte [esp+0x4], 0xfe */
        }
    }
}
