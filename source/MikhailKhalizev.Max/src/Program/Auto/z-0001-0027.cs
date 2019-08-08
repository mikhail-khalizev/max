using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("649da55b-973a-45a5-9866-c8da577c125a")]
        public void Method_0001_0027()
        {
            ii(0x1_0027, 3);  mov(esp, ebp);                            /* mov esp, ebp */
            ii(0x1_002a, 1);  popw(ds);                                 /* pop ds */
            ii(0x1_002b, 1);  popw(es);                                 /* pop es */
            ii(0x1_002c, 2);  popad();                                  /* popad */
            ii(0x1_002e, 2);  iretd(); return;                          /* iretd */
        }
    }
}
