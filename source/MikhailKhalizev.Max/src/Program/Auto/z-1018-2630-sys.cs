using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_2630-b947b8d5")]
        public void /* sys */ Method_1018_2630()
        {
            ii(0x1018_2630, 5);  mov(eax, /* sys */ 0x1018_2b48);      /* mov eax, 0x10182b48 */
            ii(0x1018_2635, 5);  jmp_func(0x1016_c6c8, -0x1_5f72);     /* jmp 0x1016c6c8 */
        }
    }
}
