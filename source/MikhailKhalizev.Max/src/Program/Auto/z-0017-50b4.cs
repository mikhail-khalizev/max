using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_50b4-a83724f7")]
        public void Method_0017_50b4()
        {
            ii(0x17_50b4, 1); pushw(ds);                                /* push ds */
            ii(0x17_50b5, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_50b8, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_50ba, 2); pushw(0x68);                              /* push 0x68 */
            ii(0x17_50bc, 1); nop();                                    /* nop */
            ii(0x17_50bd, 1); pushw(cs);                                /* push cs */
            ii(0x17_50be, 3); callw(0x16_e7a8, -0x6919);                /* call 0xe7a8 */
            ii(0x17_50c1, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_50c4, 3); mov(memw_a16[ds, 0x1ef8], ax);            /* mov [0x1ef8], ax */
            ii(0x17_50c7, 4); mov(memw_a16[ds, 0x1efa], dx);            /* mov [0x1efa], dx */
            ii(0x17_50cb, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x17_50cd, 4); or(ax, memw_a16[ds, 0x1ef8]);             /* or ax, [0x1ef8] */
            ii(0x17_50d1, 2); if(jnzw(0x17_50e4, 0x11)) goto l_0x17_50e4; /* jnz 0x50e4 */
            ii(0x17_50d3, 1); pushw(ds);                                /* push ds */
            ii(0x17_50d4, 3); pushw(0x16c);                             /* push 0x16c */
            ii(0x17_50d7, 1); nop();                                    /* nop */
            ii(0x17_50d8, 1); pushw(cs);                                /* push cs */
            ii(0x17_50d9, 3); callw(0x17_104f, -0x408d);                /* call 0x104f */
            ii(0x17_50dc, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_50df, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x17_50e2, 1); popw(ds);                                 /* pop ds */
            ii(0x17_50e3, 1); retfw(); return;                          /* retf */
        l_0x17_50e4:
            ii(0x17_50e4, 2); pushw(0x68);                              /* push 0x68 */
            ii(0x17_50e6, 1); pushw(dx);                                /* push dx */
            ii(0x17_50e7, 4); pushw(memw_a16[ds, 0x1ef8]);              /* push word [0x1ef8] */
            ii(0x17_50eb, 1); nop();                                    /* nop */
            ii(0x17_50ec, 1); pushw(cs);                                /* push cs */
            ii(0x17_50ed, 3); callw(0x17_8ed0, 0x3de0);                 /* call 0x8ed0 */
            ii(0x17_50f0, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_50f3, 1); nop();                                    /* nop */
            ii(0x17_50f4, 1); pushw(cs);                                /* push cs */
            ii(0x17_50f5, 3); callw(0x17_8e80, 0x3d88);                 /* call 0x8e80 */
            ii(0x17_50f8, 4); les(bx, ds, 0x1ef8);                      /* les bx, [0x1ef8] */
            ii(0x17_50fc, 4); mov(memw_a16[es, bx + 0x1c], ax);         /* mov [es:bx+0x1c], ax */
            ii(0x17_5100, 4); mov(memw_a16[es, bx + 0x1e], dx);         /* mov [es:bx+0x1e], dx */
            ii(0x17_5104, 4); pushw(memw_a16[ds, 0x1efa]);              /* push word [0x1efa] */
            ii(0x17_5108, 1); pushw(cs);                                /* push cs */
            ii(0x17_5109, 3); callw(0x17_55f0, 0x4e4);                  /* call 0x55f0 */
            ii(0x17_510c, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_510f, 4); pushw(memw_a16[ds, 0x1efa]);              /* push word [0x1efa] */
            ii(0x17_5113, 1); nop();                                    /* nop */
            ii(0x17_5114, 1); pushw(cs);                                /* push cs */
            ii(0x17_5115, 3); callw(0x17_90b6, 0x3f9e);                 /* call 0x90b6 */
            ii(0x17_5118, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_511b, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_511d, 1); popw(ds);                                 /* pop ds */
            ii(0x17_511e, 1); retfw();                                  /* retf */
        }
    }
}
