using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_7160-6de7be5a")]
        public void /* sys */ Method_1018_7160()
        {
            ii(0x1018_7160, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1018_7162, 6);  if(jnz_func(0x1018_d5d9, 0x6471)) return;/* jnz 0x1018d5d9 */
            ii(0x1018_7168, 5);  call(/* sys */ 0x1018_d465, 0x62f8);  /* call 0x1018d465 */
            ii(0x1018_716d, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1018_716f, 1);  ret();                                /* ret */
        }
    }
}
