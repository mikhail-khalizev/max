using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9d7dbe69-edf9-4a29-b2e5-7aef572d7399")]
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
