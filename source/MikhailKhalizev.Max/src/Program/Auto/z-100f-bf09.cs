using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_bf09-fa8c9d30")]
        public void Method_100f_bf09()
        {
            ii(0x100f_bf09, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100f_bf0d, 3); mov(al, memb_a32[ss, ebp - 0x34]);      /* mov al, [ebp-0x34] */
            ii(0x100f_bf10, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x100f_bf13, 2); if(jmpd_func(0x100f_bf4f, 0x3a)) return; /* jmp 0x100fbf4f */
        }
    }
}
