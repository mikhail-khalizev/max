using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_a277-e74d3250")]
        public void Method_100f_a277()
        {
            ii(0x100f_a277, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_a27c, 5);  call(0x1008_abbc, -0x6_f6c5);         /* call 0x1008abbc */
            ii(0x100f_a281, 5);  call(0x100f_8b93, -0x16f3);           /* call 0x100f8b93 */
            ii(0x100f_a286, 5);  if(jmp_func(0x100f_a75d, 0x4d2)) return;/* jmp 0x100fa75d */
        }
    }
}
