using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("60963b98-77ad-45cc-b85a-64982b9c0ab3")]
        public void Method_0001_2037()
        {
            ii(0x1_2037, 3);  mov(esp, ebp);                            /* mov esp, ebp */
            ii(0x1_203a, 1);  popw(ds);                                 /* pop ds */
            ii(0x1_203b, 1);  popw(es);                                 /* pop es */
            ii(0x1_203c, 2);  popad();                                  /* popad */
            ii(0x1_203e, 2);  iretd(); return;                          /* iretd */
        }
    }
}
