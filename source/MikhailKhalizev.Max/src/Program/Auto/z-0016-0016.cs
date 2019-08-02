using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ff10f5cc-f5dc-4ece-996d-9bfdd7d13431")]
        public void Method_0016_0016()
        {
            ii(0x16_0016, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x16_001a, 1); pushw(ds);                                /* push ds */
            ii(0x16_001b, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x16_001e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x16_0020, 1); pushw(ds);                                /* push ds */
            ii(0x16_0021, 3); pushw(0x31cc);                            /* push 0x31cc */
            ii(0x16_0024, 5); callw_far_abs(0x80, 0x5ba0);              /* call word 0x80:0x5ba0 */
            ii(0x16_0029, 1); popw(bx);                                 /* pop bx */
            ii(0x16_002a, 1); popw(bx);                                 /* pop bx */
            ii(0x16_002b, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x16_002e, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x16_0031, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x16_0033, 2); if(jzw(0x16_0097, 0x62)) goto l_0x16_0097; /* jz 0x97 */
            ii(0x16_0035, 1); pushw(ds);                                /* push ds */
            ii(0x16_0036, 3); pushw(0x31e0);                            /* push 0x31e0 */
            ii(0x16_0039, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x16_003c, 1); pushw(ax);                                /* push ax */
            ii(0x16_003d, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x16_0042, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x16_0045, 3); mov(memw_a16[ds, 0x3290], ax);            /* mov [0x3290], ax */
            ii(0x16_0048, 4); mov(memw_a16[ds, 0x3292], dx);            /* mov [0x3292], dx */
            ii(0x16_004c, 1); pushw(ds);                                /* push ds */
            ii(0x16_004d, 3); pushw(0x31f9);                            /* push 0x31f9 */
            ii(0x16_0050, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x16_0053, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x16_0056, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x16_005b, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x16_005e, 3); mov(memw_a16[ds, 0x32ac], ax);            /* mov [0x32ac], ax */
            ii(0x16_0061, 4); mov(memw_a16[ds, 0x32ae], dx);            /* mov [0x32ae], dx */
            ii(0x16_0065, 1); pushw(ds);                                /* push ds */
            ii(0x16_0066, 3); pushw(0x320e);                            /* push 0x320e */
            ii(0x16_0069, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x16_006c, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x16_006f, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x16_0074, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x16_0077, 3); mov(memw_a16[ds, 0x32b0], ax);            /* mov [0x32b0], ax */
            ii(0x16_007a, 4); mov(memw_a16[ds, 0x32b2], dx);            /* mov [0x32b2], dx */
            ii(0x16_007e, 1); pushw(ds);                                /* push ds */
            ii(0x16_007f, 3); pushw(0x3227);                            /* push 0x3227 */
            ii(0x16_0082, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x16_0085, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x16_0088, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x16_008d, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x16_0090, 3); mov(memw_a16[ds, 0x32a8], ax);            /* mov [0x32a8], ax */
            ii(0x16_0093, 4); mov(memw_a16[ds, 0x32aa], dx);            /* mov [0x32aa], dx */
        l_0x16_0097:
            ii(0x16_0097, 1); pushw(ds);                                /* push ds */
            ii(0x16_0098, 3); pushw(0x323d);                            /* push 0x323d */
            ii(0x16_009b, 5); callw_far_abs(0x80, 0x5ba0);              /* call word 0x80:0x5ba0 */
            ii(0x16_00a0, 1); popw(bx);                                 /* pop bx */
            ii(0x16_00a1, 1); popw(bx);                                 /* pop bx */
            ii(0x16_00a2, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x16_00a5, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x16_00a8, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x16_00aa, 2); if(jzw(0x16_00f5, 0x49)) goto l_0x16_00f5; /* jz 0xf5 */
            ii(0x16_00ac, 1); pushw(ds);                                /* push ds */
            ii(0x16_00ad, 3); pushw(0x3243);                            /* push 0x3243 */
            ii(0x16_00b0, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x16_00b3, 1); pushw(ax);                                /* push ax */
            ii(0x16_00b4, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x16_00b9, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x16_00bc, 3); mov(memw_a16[ds, 0x3294], ax);            /* mov [0x3294], ax */
            ii(0x16_00bf, 4); mov(memw_a16[ds, 0x3296], dx);            /* mov [0x3296], dx */
            ii(0x16_00c3, 1); pushw(ds);                                /* push ds */
            ii(0x16_00c4, 3); pushw(0x324e);                            /* push 0x324e */
            ii(0x16_00c7, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x16_00ca, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x16_00cd, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x16_00d2, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x16_00d5, 3); mov(memw_a16[ds, 0x3298], ax);            /* mov [0x3298], ax */
            ii(0x16_00d8, 4); mov(memw_a16[ds, 0x329a], dx);            /* mov [0x329a], dx */
            ii(0x16_00dc, 1); pushw(ds);                                /* push ds */
            ii(0x16_00dd, 3); pushw(0x325b);                            /* push 0x325b */
            ii(0x16_00e0, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x16_00e3, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x16_00e6, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x16_00eb, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x16_00ee, 3); mov(memw_a16[ds, 0x329c], ax);            /* mov [0x329c], ax */
            ii(0x16_00f1, 4); mov(memw_a16[ds, 0x329e], dx);            /* mov [0x329e], dx */
        l_0x16_00f5:
            ii(0x16_00f5, 1); pushw(ds);                                /* push ds */
            ii(0x16_00f6, 3); pushw(0x3266);                            /* push 0x3266 */
            ii(0x16_00f9, 5); callw_far_abs(0x80, 0x5ba0);              /* call word 0x80:0x5ba0 */
            ii(0x16_00fe, 1); popw(bx);                                 /* pop bx */
            ii(0x16_00ff, 1); popw(bx);                                 /* pop bx */
            ii(0x16_0100, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x16_0103, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x16_0106, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x16_0108, 2); if(jzw(0x16_013a, 0x30)) goto l_0x16_013a; /* jz 0x13a */
            ii(0x16_010a, 1); pushw(ds);                                /* push ds */
            ii(0x16_010b, 3); pushw(0x3271);                            /* push 0x3271 */
            ii(0x16_010e, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x16_0111, 1); pushw(ax);                                /* push ax */
            ii(0x16_0112, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x16_0117, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x16_011a, 3); mov(memw_a16[ds, 0x32a0], ax);            /* mov [0x32a0], ax */
            ii(0x16_011d, 4); mov(memw_a16[ds, 0x32a2], dx);            /* mov [0x32a2], dx */
            ii(0x16_0121, 1); pushw(ds);                                /* push ds */
            ii(0x16_0122, 3); pushw(0x327e);                            /* push 0x327e */
            ii(0x16_0125, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x16_0128, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x16_012b, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x16_0130, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x16_0133, 3); mov(memw_a16[ds, 0x32a4], ax);            /* mov [0x32a4], ax */
            ii(0x16_0136, 4); mov(memw_a16[ds, 0x32a6], dx);            /* mov [0x32a6], dx */
        l_0x16_013a:
            ii(0x16_013a, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x16_013d, 1); popw(ds);                                 /* pop ds */
            ii(0x16_013e, 1); leavew();                                 /* leave */
            ii(0x16_013f, 1); retfw(); return;                          /* retf */
        }
    }
}
