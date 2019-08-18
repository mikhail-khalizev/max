using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dc3e4449-58a0-4d8c-9f60-3924055ab19d")]
        public void Method_0000_6ea2()
        {
            ii(0x6ea2, 1);    pushw(cs);                                /* push cs */
            ii(0x6ea3, 3);    callw(0x6b30, -0x376);                    /* call 0x6b30 */
            ii(0x6ea6, 1);    popw(bx);                                 /* pop bx */
            ii(0x6ea7, 4);    inc(memb_a16[ds, 0x1182]);                /* inc byte [0x1182] */
            ii(0x6eab, 3);    callw(0x9076, 0x21c8);                    /* call 0x9076 */
            ii(0x6eae, 1);    popw(cx);                                 /* pop cx */
            ii(0x6eaf, 1);    popw(cx);                                 /* pop cx */
            ii(0x6eb0, 2);    mov(ax, sp);                              /* mov ax, sp */
            ii(0x6eb2, 3);    sub(ax, 0x6);                             /* sub ax, 0x6 */
            ii(0x6eb5, 1);    pushw(ax);                                /* push ax */
            ii(0x6eb6, 3);    callw(0x8c79, 0x1dc0);                    /* call 0x8c79 */
            ii(0x6eb9, 1);    popw(cx);                                 /* pop cx */
            ii(0x6eba, 4);    dec(memb_a16[ds, 0x1182]);                /* dec byte [0x1182] */
            ii(0x6ebe, 1);    pushw(cs);                                /* push cs */
            ii(0x6ebf, 3);    callw(0x6b62, -0x360);                    /* call 0x6b62 */
            ii(0x6ec2, 5);    if(jmpw_far_abs(0x70, 0x9da)) return;     /* jmp word 0x70:0x9da */
        }
    }
}
