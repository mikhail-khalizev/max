using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9c57-29f65b67")]
        public void Method_0000_9c57()
        {
            ii(0x9c57, 2);    mov(al, 0xff);                            /* mov al, 0xff */
            ii(0x9c59, 2);    outb(0x94, al);                           /* out 0x94, al */
            ii(0x9c5b, 2);    jmpw(0x9c5d, 0); goto l_0x9c5d;           /* jmp 0x9c5d */
        l_0x9c5d:
            ii(0x9c5d, 2);    xor(al, al);                              /* xor al, al */
            ii(0x9c5f, 2);    outb(0x96, al);                           /* out 0x96, al */
            ii(0x9c61, 1);    retw();                                   /* ret */
        }
    }
}
