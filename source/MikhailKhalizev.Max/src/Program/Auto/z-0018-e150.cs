using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e150-f87ad400")]
        public void Method_0018_e150()
        {
            ii(0x18_e150, 5);  cmp(memw[ds, 2], 0x10);                 /* cmp word [0x2], 0x10 */
            ii(0x18_e155, 2);  if(jbe_func(0x18_e14d, -0xa)) return;   /* jbe 0xe14d */
            ii(0x18_e157, 6);  mov(memw[ds, 2], 0x10);                 /* mov word [0x2], 0x10 */
            ii(0x18_e15d, 3);  if(jmp_func(0x18_e0ba, -0xa6)) return;  /* jmp 0xe0ba */
        }
    }
}
