using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_e91c-2e697b5f")]
        public void /* sys */ Method_1018_e91c()
        {
            ii(0x1018_e91c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1018_e91f, 5); if(jmpd_func(0x1018_e9b0, 0x8c)) return; /* jmp 0x1018e9b0 */
        }
    }
}
