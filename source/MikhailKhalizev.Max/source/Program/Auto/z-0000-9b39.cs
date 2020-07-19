using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9b39-d6ed0baf")]
        public void Method_0000_9b39()
        {
            ii(0x9b39, 5);  test(memb[ds, 0x47], 1);                   /* test byte [0x47], 0x1 */
            ii(0x9b3e, 2);  if(jz(0x9b47, 7)) goto l_0x9b47;           /* jz 0x9b47 */
            ii(0x9b40, 2);  mov(ah, 0xf);                              /* mov ah, 0xf */
            ii(0x9b42, 2);  @int(0x10);                                /* int 0x10 */
            ii(0x9b44, 3);  mov(memb[ds, 0xa17], al);                  /* mov [0xa17], al */
        l_0x9b47:
            ii(0x9b47, 1);  ret();                                     /* ret */
        }
    }
}
