using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1da4f5a9-f575-4b0a-bafd-dfb432915a9d")]
        public void Method_0000_a2e9()
        {
            ii(0xa2e9, 5);    test(memb_a16[ds, 0x47], 0x1);            /* test byte [0x47], 0x1 */
            ii(0xa2ee, 2);    if(jzw(0xa2f7, 0x7)) goto l_0xa2f7;       /* jz 0xa2f7 */
            ii(0xa2f0, 2);    mov(ah, 0xf);                             /* mov ah, 0xf */
            ii(0xa2f2, 2);    @int(0x10);                               /* int 0x10 */
            ii(0xa2f4, 3);    mov(memb_a16[ds, 0xa17], al);             /* mov [0xa17], al */
        l_0xa2f7:
            ii(0xa2f7, 1);    retw(); return;                           /* ret */
        }
    }
}
