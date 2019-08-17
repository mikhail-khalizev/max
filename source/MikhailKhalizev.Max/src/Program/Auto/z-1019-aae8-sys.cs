using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("015c874f-7344-42cc-8cc1-6c87cbd1477e")]
        public void /* sys */ Method_1019_aae8()
        {
            ii(0x1019_aae8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_aaea, 5); calld(/* sys */ 0x1019_aaf9, 0xa);      /* call 0x1019aaf9 */
            ii(0x1019_aaef, 5); if(jmpd_func(0x1018_d5b5, -0xd53f)) return; /* jmp 0x1018d5b5 */
        }
    }
}
