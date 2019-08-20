using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_6796-4caeb1f3")]
        public void Method_100c_6796()
        {
            ii(0x100c_6796, 2); if(jmpd_func(0x100c_67d1, 0x39)) return; /* jmp 0x100c67d1 */
            ii(0x100c_6798, 3); sub(ah, memb_a32[ds, edi + 0xc]);       /* sub ah, [edi+0xc] */
            ii(0x100c_679b, 3); adc(memb_a32[ds, esi + 0x67], cl);      /* adc [esi+0x67], cl */
            ii(0x100c_679e, 2); or(al, 0x10);                           /* or al, 0x10 */
            ii(0x100c_67a0, 2); if(jbd_func(0x100c_6809, 0x67)) return; /* jb 0x100c6809 */
            ii(0x100c_67a2, 2); or(al, 0x10);                           /* or al, 0x10 */
            ii(0x100c_67a4, 1); xchg(esi, eax);                         /* xchg esi, eax */
            ii(0x100c_67a5, 3); or(al, 0x10);                           /* a16 or al, 0x10 */
            ii(0x100c_67a8, 1); xchg(esi, eax);                         /* xchg esi, eax */
            ii(0x100c_67a9, 3); or(al, 0x10);                           /* a16 or al, 0x10 */
            ii(0x100c_67ac, 1); xchg(esi, eax);                         /* xchg esi, eax */
            ii(0x100c_67ad, 3); or(al, 0x10);                           /* a16 or al, 0x10 */
            ii(0x100c_67b0, 3); sub(ah, memb_a32[ds, edi + 0xc]);       /* sub ah, [edi+0xc] */
        }
    }
}
