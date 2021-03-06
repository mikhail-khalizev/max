using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x41d9-98a54cc1")]
        public void Method_0000_41d9()
        {
            ii(0x41d9, 2);  mov(ah, 0xdf);                             /* mov ah, 0xdf */
            ii(0x41db, 3);  call(0x41c1, -0x1d);                       /* call 0x41c1 */
            ii(0x41de, 5);  test(memb[ds, 0x14], 1);                   /* test byte [0x14], 0x1 */
            ii(0x41e3, 2);  if(jz_func(0x41d3, -0x12)) return;         /* jz 0x41d3 */
        l_0x41e5:
            ii(0x41e5, 3);  call(0x41fd, 0x15);                        /* call 0x41fd */
            ii(0x41e8, 2);  if(jz(0x41e5, -5)) goto l_0x41e5;          /* jz 0x41e5 */
            ii(0x41ea, 1);  ret();                                     /* ret */
        }
    }
}
