using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4662-1a36d357")]
        public void Method_0000_4662()
        {
            ii(0x4662, 3);    mov(ax, 0x9db);                           /* mov ax, 0x9db */
            ii(0x4665, 2);    mov(cx, ds);                              /* mov cx, ds */
            ii(0x4667, 3);    callw(0x40dc, -0x58e);                    /* call 0x40dc */
            ii(0x466a, 2);    mov(al, 0xf);                             /* mov al, 0xf */
            ii(0x466c, 2);    outb(0x70, al);                           /* out 0x70, al */
            ii(0x466e, 2);    jmpw(0x4670, 0); goto l_0x4670;           /* jmp 0x4670 */
        l_0x4670:
            ii(0x4670, 3);    mov(al, memb_a16[ds, 0x10ee]);            /* mov al, [0x10ee] */
            ii(0x4673, 2);    outb(0x71, al);                           /* out 0x71, al */
            ii(0x4675, 1);    retw(); return;                           /* ret */
        }
    }
}
