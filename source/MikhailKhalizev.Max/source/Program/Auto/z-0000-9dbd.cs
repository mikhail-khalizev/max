using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9dbd-41af6b2c")]
        public void Method_0000_9dbd()
        {
            ii(0x9dbd, 1);  pop(ax);                                   /* pop ax */
            ii(0x9dbe, 1);  pop(bx);                                   /* pop bx */
            ii(0x9dbf, 4);  mov(sp, memw[ds, 0xf50]);                  /* mov sp, [0xf50] */
            ii(0x9dc3, 1);  push(bx);                                  /* push bx */
            ii(0x9dc4, 1);  push(ax);                                  /* push ax */
            ii(0x9dc5, 3);  jmp_func(0x604d, -0x3d7b);                 /* jmp 0x604d */
        }
    }
}
