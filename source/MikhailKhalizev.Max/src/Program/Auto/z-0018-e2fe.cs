using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e2fe-e674e3cb")]
        public void Method_0018_e2fe()
        {
            ii(0x18_e2fe, 3);  call(0x18_e070, -0x291);                /* call 0xe070 */
            ii(0x18_e301, 2);  if(jcxz_func(0x18_e2b3, -0x50)) return; /* jcxz 0xe2b3 */
            ii(0x18_e303, 3);  mov(esi, ebx);                          /* mov esi, ebx */
            ii(0x18_e306, 3);  movsd_a32();                            /* a32 movsd */
            ii(0x18_e309, 3);  movsd_a32();                            /* a32 movsd */
            ii(0x18_e30c, 3);  if(jmp_func(0x18_e067, -0x2a8)) return; /* jmp 0xe067 */
        }
    }
}
