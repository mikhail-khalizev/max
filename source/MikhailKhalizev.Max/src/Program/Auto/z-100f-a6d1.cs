using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_a6d1-f2548e5b")]
        public void Method_100f_a6d1()
        {
            ii(0x100f_a6d1, 3);  mov(edx, memd[ss, ebp - 24]);         /* mov edx, [ebp-0x18] */
            ii(0x100f_a6d4, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_a6d9, 5);  call(0x1008_abbc, -0x6_fb22);         /* call 0x1008abbc */
            ii(0x100f_a6de, 5);  call(0x100f_911b, -0x15c8);           /* call 0x100f911b */
            ii(0x100f_a6e3, 5);  if(jmp_func(0x100f_a75d, 0x75)) return;/* jmp 0x100fa75d */
        }
    }
}
