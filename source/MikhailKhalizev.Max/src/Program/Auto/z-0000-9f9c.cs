using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b4804777-17d0-4274-a23d-e64b6221b20e")]
        public void Method_0000_9f9c()
        {
            ii(0x9f9c, 3);    mov(bx, 0xb);                             /* mov bx, 0xb */
            ii(0x9f9f, 3);    mov(ax, 0xbfde);                          /* mov ax, 0xbfde */
            ii(0x9fa2, 3);    if(jmpw_func(0x44e4, -0x5ac1)) return;    /* jmp 0x44e4 */
        }
    }
}
