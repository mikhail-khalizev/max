using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_330b-4254bff0")]
        public void Method_0001_330b()
        {
            ii(0x1_330b, 3);  cmp(edi, ecx);                           /* cmp edi, ecx */
            ii(0x1_330e, 2);  if(jbe_func(0x1_32f9, -0x17)) return;    /* jbe 0x32f9 */
            ii(0x1_3310, 3);  call(0x1_3326, 0x13);                    /* call 0x3326 */
        }
    }
}
