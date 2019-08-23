using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6672-45ddd347")]
        public void Method_0000_6672()
        {
            ii(0x6672, 3);    mov(ax, 0x9db);                           /* mov ax, 0x9db */
            ii(0x6675, 2);    mov(cx, ds);                              /* mov cx, ds */
            ii(0x6677, 3);    call(0x60ec, -0x58e);                     /* call 0x60ec */
            ii(0x667a, 2);    mov(al, 0xf);                             /* mov al, 0xf */
            ii(0x667c, 2);    outb(0x70, al);                           /* out 0x70, al */
            ii(0x667e, 2);    jmp(0x6680, 0); goto l_0x6680;            /* jmp 0x6680 */
        l_0x6680:
            ii(0x6680, 3);    mov(al, memb[ds, 0x10ee]);                /* mov al, [0x10ee] */
            ii(0x6683, 2);    outb(0x71, al);                           /* out 0x71, al */
            ii(0x6685, 1);    ret();                                    /* ret */
        }
    }
}
