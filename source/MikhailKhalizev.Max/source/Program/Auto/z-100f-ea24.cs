using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_ea24-3883f183")]
        public void Method_100f_ea24()
        {
            ii(0x100f_ea24, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_ea26, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_ea27, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_ea28, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_ea29, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_ea2a, 1);  ret();                                /* ret */
        }
    }
}
