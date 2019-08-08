using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d8529c78-5588-42b5-b44a-1c815ceafb40")]
        public void Method_0014_08f7()
        {
            ii(0x14_08f7, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x14_08fb, 1); pushw(ds);                                /* push ds */
            ii(0x14_08fc, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x14_08ff, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x14_0901, 1); pushw(ds);                                /* push ds */
            ii(0x14_0902, 1); pushw(ss);                                /* push ss */
            ii(0x14_0903, 1); popw(ds);                                 /* pop ds */
            ii(0x14_0904, 2); pushw(0);                                 /* push 0x0 */
            ii(0x14_0906, 2); pushw(0);                                 /* push 0x0 */
            ii(0x14_0908, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x14_090b, 1); nop();                                    /* nop */
            ii(0x14_090c, 1); pushw(cs);                                /* push cs */
            ii(0x14_090d, 3); callw(0x13_dc4c, -0x2cc4);                /* call 0xdc4c */
            ii(0x14_0910, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x14_0913, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x14_0916, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x14_0919, 1); popw(ds);                                 /* pop ds */
            ii(0x14_091a, 1); popw(ds);                                 /* pop ds */
            ii(0x14_091b, 1); leavew();                                 /* leave */
            ii(0x14_091c, 3); retfw(0x4); return;                       /* retf 0x4 */
        }
    }
}
