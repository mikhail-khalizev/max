using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xbdcd-41af6b2c")]
        public void Method_0000_bdcd()
        {
            ii(0xbdcd, 1);    popw(ax);                                 /* pop ax */
            ii(0xbdce, 1);    popw(bx);                                 /* pop bx */
            ii(0xbdcf, 4);    mov(sp, memw_a16[ds, 0xf50]);             /* mov sp, [0xf50] */
            ii(0xbdd3, 1);    pushw(bx);                                /* push bx */
            ii(0xbdd4, 1);    pushw(ax);                                /* push ax */
            ii(0xbdd5, 3);    if(jmpw_func(0x805d, -0x3d7b)) return;    /* jmp 0x805d */
        }
    }
}