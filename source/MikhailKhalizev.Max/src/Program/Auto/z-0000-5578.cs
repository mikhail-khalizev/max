using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5578-95f6284a")]
        public void Method_0000_5578()
        {
            ii(0x5578, 3);  mov(ax, 0xaac);                            /* mov ax, 0xaac */
            ii(0x557b, 1);  push(ax);                                  /* push ax */
            ii(0x557c, 3);  call(0x5237, -0x348);                      /* call 0x5237 */
            ii(0x557f, 1);  pop(bx);                                   /* pop bx */
            ii(0x5580, 1);  ret();                                     /* ret */
        }
    }
}
