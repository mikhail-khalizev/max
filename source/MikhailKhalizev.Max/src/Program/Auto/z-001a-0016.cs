using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_0016-df5242cc")]
        public void Method_001a_0016()
        {
            ii(0x1a_0016, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x1a_001a, 1); pushw(ds);                                /* push ds */
            ii(0x1a_001b, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x1a_001e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x1a_0020, 1); pushw(ds);                                /* push ds */
            ii(0x1a_0021, 3); pushw(0x31cc);                            /* push 0x31cc */
            ii(0x1a_0024, 5); callw_far_abs(0x80, 0x5ba0);              /* call word 0x80:0x5ba0 */
            ii(0x1a_0029, 1); popw(bx);                                 /* pop bx */
            ii(0x1a_002a, 1); popw(bx);                                 /* pop bx */
            ii(0x1a_002b, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x1a_002e, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x1a_0031, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x1a_0033, 2); if(jzw(0x1a_0097, 0x62)) goto l_0x1a_0097; /* jz 0x97 */
            ii(0x1a_0035, 1); pushw(ds);                                /* push ds */
            ii(0x1a_0036, 3); pushw(0x31e0);                            /* push 0x31e0 */
            ii(0x1a_0039, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x1a_003c, 1); pushw(ax);                                /* push ax */
            ii(0x1a_003d, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x1a_0042, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x1a_0045, 3); mov(memw_a16[ds, 0x3290], ax);            /* mov [0x3290], ax */
            ii(0x1a_0048, 4); mov(memw_a16[ds, 0x3292], dx);            /* mov [0x3292], dx */
            ii(0x1a_004c, 1); pushw(ds);                                /* push ds */
            ii(0x1a_004d, 3); pushw(0x31f9);                            /* push 0x31f9 */
            ii(0x1a_0050, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x1a_0053, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x1a_0056, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x1a_005b, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x1a_005e, 3); mov(memw_a16[ds, 0x32ac], ax);            /* mov [0x32ac], ax */
            ii(0x1a_0061, 4); mov(memw_a16[ds, 0x32ae], dx);            /* mov [0x32ae], dx */
            ii(0x1a_0065, 1); pushw(ds);                                /* push ds */
            ii(0x1a_0066, 3); pushw(0x320e);                            /* push 0x320e */
            ii(0x1a_0069, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x1a_006c, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x1a_006f, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x1a_0074, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x1a_0077, 3); mov(memw_a16[ds, 0x32b0], ax);            /* mov [0x32b0], ax */
            ii(0x1a_007a, 4); mov(memw_a16[ds, 0x32b2], dx);            /* mov [0x32b2], dx */
            ii(0x1a_007e, 1); pushw(ds);                                /* push ds */
            ii(0x1a_007f, 3); pushw(0x3227);                            /* push 0x3227 */
            ii(0x1a_0082, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x1a_0085, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x1a_0088, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x1a_008d, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x1a_0090, 3); mov(memw_a16[ds, 0x32a8], ax);            /* mov [0x32a8], ax */
            ii(0x1a_0093, 4); mov(memw_a16[ds, 0x32aa], dx);            /* mov [0x32aa], dx */
        l_0x1a_0097:
            ii(0x1a_0097, 1); pushw(ds);                                /* push ds */
            ii(0x1a_0098, 3); pushw(0x323d);                            /* push 0x323d */
            ii(0x1a_009b, 5); callw_far_abs(0x80, 0x5ba0);              /* call word 0x80:0x5ba0 */
            ii(0x1a_00a0, 1); popw(bx);                                 /* pop bx */
            ii(0x1a_00a1, 1); popw(bx);                                 /* pop bx */
            ii(0x1a_00a2, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x1a_00a5, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x1a_00a8, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x1a_00aa, 2); if(jzw(0x1a_00f5, 0x49)) goto l_0x1a_00f5; /* jz 0xf5 */
            ii(0x1a_00ac, 1); pushw(ds);                                /* push ds */
            ii(0x1a_00ad, 3); pushw(0x3243);                            /* push 0x3243 */
            ii(0x1a_00b0, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x1a_00b3, 1); pushw(ax);                                /* push ax */
            ii(0x1a_00b4, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x1a_00b9, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x1a_00bc, 3); mov(memw_a16[ds, 0x3294], ax);            /* mov [0x3294], ax */
            ii(0x1a_00bf, 4); mov(memw_a16[ds, 0x3296], dx);            /* mov [0x3296], dx */
            ii(0x1a_00c3, 1); pushw(ds);                                /* push ds */
            ii(0x1a_00c4, 3); pushw(0x324e);                            /* push 0x324e */
            ii(0x1a_00c7, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x1a_00ca, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x1a_00cd, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x1a_00d2, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x1a_00d5, 3); mov(memw_a16[ds, 0x3298], ax);            /* mov [0x3298], ax */
            ii(0x1a_00d8, 4); mov(memw_a16[ds, 0x329a], dx);            /* mov [0x329a], dx */
            ii(0x1a_00dc, 1); pushw(ds);                                /* push ds */
            ii(0x1a_00dd, 3); pushw(0x325b);                            /* push 0x325b */
            ii(0x1a_00e0, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x1a_00e3, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x1a_00e6, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x1a_00eb, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x1a_00ee, 3); mov(memw_a16[ds, 0x329c], ax);            /* mov [0x329c], ax */
            ii(0x1a_00f1, 4); mov(memw_a16[ds, 0x329e], dx);            /* mov [0x329e], dx */
        l_0x1a_00f5:
            ii(0x1a_00f5, 1); pushw(ds);                                /* push ds */
            ii(0x1a_00f6, 3); pushw(0x3266);                            /* push 0x3266 */
            ii(0x1a_00f9, 5); callw_far_abs(0x80, 0x5ba0);              /* call word 0x80:0x5ba0 */
            ii(0x1a_00fe, 1); popw(bx);                                 /* pop bx */
            ii(0x1a_00ff, 1); popw(bx);                                 /* pop bx */
            ii(0x1a_0100, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x1a_0103, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x1a_0106, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x1a_0108, 2); if(jzw(0x1a_013a, 0x30)) goto l_0x1a_013a; /* jz 0x13a */
            ii(0x1a_010a, 1); pushw(ds);                                /* push ds */
            ii(0x1a_010b, 3); pushw(0x3271);                            /* push 0x3271 */
            ii(0x1a_010e, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x1a_0111, 1); pushw(ax);                                /* push ax */
            ii(0x1a_0112, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x1a_0117, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x1a_011a, 3); mov(memw_a16[ds, 0x32a0], ax);            /* mov [0x32a0], ax */
            ii(0x1a_011d, 4); mov(memw_a16[ds, 0x32a2], dx);            /* mov [0x32a2], dx */
            ii(0x1a_0121, 1); pushw(ds);                                /* push ds */
            ii(0x1a_0122, 3); pushw(0x327e);                            /* push 0x327e */
            ii(0x1a_0125, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x1a_0128, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x1a_012b, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x1a_0130, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x1a_0133, 3); mov(memw_a16[ds, 0x32a4], ax);            /* mov [0x32a4], ax */
            ii(0x1a_0136, 4); mov(memw_a16[ds, 0x32a6], dx);            /* mov [0x32a6], dx */
        l_0x1a_013a:
            ii(0x1a_013a, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x1a_013d, 1); popw(ds);                                 /* pop ds */
            ii(0x1a_013e, 1); leavew();                                 /* leave */
            ii(0x1a_013f, 1); retfw(); return;                          /* retf */
        }
    }
}
