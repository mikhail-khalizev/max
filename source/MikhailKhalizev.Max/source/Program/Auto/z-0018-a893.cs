using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a893-8f2add4d")]
        public void Method_0018_a893()
        {
            ii(0x18_a893, 5);  cmp(memb[ds, 0x2e], 0);                 /* cmp byte [0x2e], 0x0 */
            ii(0x18_a898, 2);  if(jz_func(0x18_a863, -0x37)) return;   /* jz 0xa863 */
            ii(0x18_a89a, 1);  cli();                                  /* cli */
            ii(0x18_a89b, 1);  pusha();                                /* pusha */
            ii(0x18_a89c, 5);  jmp_far_abs(0x18, 0x1068);              /* jmp word 0x18:0x1068 */
        }
    }
}
