using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dd2cfd54-05bc-400c-819b-7996068fa303")]
        public void Method_0000_9dbd()
        {
            ii(0x9dbd, 1);    popw(ax);                                 /* pop ax */
            ii(0x9dbe, 1);    popw(bx);                                 /* pop bx */
            ii(0x9dbf, 4);    mov(sp, memw_a16[ds, 0xf50]);             /* mov sp, [0xf50] */
            ii(0x9dc3, 1);    pushw(bx);                                /* push bx */
            ii(0x9dc4, 1);    pushw(ax);                                /* push ax */
            ii(0x9dc5, 3);    if(jmpw_func(0x604d, -0x3d7b)) return;    /* jmp 0x604d */
        }
    }
}
