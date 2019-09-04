using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_a6e8-555146fd")]
        public void Method_100f_a6e8()
        {
            ii(0x100f_a6e8, 3);  mov(edx, memd[ss, ebp - 24]);         /* mov edx, [ebp-0x18] */
            ii(0x100f_a6eb, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_a6f0, 5);  call(0x1008_abbc, -0x6_fb39);         /* call 0x1008abbc */
            ii(0x100f_a6f5, 5);  call(0x100f_91cb, -0x152f);           /* call 0x100f91cb */
            ii(0x100f_a6fa, 2);  if(jmp_func(0x100f_a75d, 0x61)) return;/* jmp 0x100fa75d */
        }
    }
}
