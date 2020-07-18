using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_0027-75fb132e")]
        public void Method_0001_0027()
        {
            ii(0x1_0027, 3);  mov(esp, ebp);                           /* mov esp, ebp */
            ii(0x1_002a, 1);  pop(ds);                                 /* pop ds */
            ii(0x1_002b, 1);  pop(es);                                 /* pop es */
            ii(0x1_002c, 2);  popad();                                 /* popad */
            ii(0x1_002e, 2);  iretd();                                 /* iretd */
        }
    }
}
