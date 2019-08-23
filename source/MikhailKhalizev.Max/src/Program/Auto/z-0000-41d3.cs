using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x41d3-1b456ca9")]
        public void Method_0000_41d3()
        {
            ii(0x41d3, 2);    mov(al, 0xff);                            /* mov al, 0xff */
            ii(0x41d5, 2);    outb(0x64, al);                           /* out 0x64, al */
            ii(0x41d7, 2);    if(jmp_func(0x4218, 0x3f)) return;        /* jmp 0x4218 */
        }
    }
}
