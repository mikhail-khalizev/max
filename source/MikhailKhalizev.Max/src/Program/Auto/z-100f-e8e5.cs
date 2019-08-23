using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_e8e5-af01ea77")]
        public void Method_100f_e8e5()
        {
            ii(0x100f_e8e5, 4); cmp(memb[ss, ebp - 0x8], 0xa);          /* cmp byte [ebp-0x8], 0xa */
            ii(0x100f_e8e9, 2); if(jz(0x100f_e8f4, 0x9)) goto l_0x100f_e8f4; /* jz 0x100fe8f4 */
            ii(0x100f_e8eb, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100f_e8ef, 5); call(0x100f_2ec7, -0xba2d);             /* call 0x100f2ec7 */
        l_0x100f_e8f4:
            ii(0x100f_e8f4, 2); if(jmp_func(0x100f_e927, 0x31)) return; /* jmp 0x100fe927 */
        }
    }
}
