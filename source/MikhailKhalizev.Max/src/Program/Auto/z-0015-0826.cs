using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bea2c6e2-c287-4c6a-a4e3-003a17804432")]
        public void Method_0015_0826()
        {
            ii(0x15_0826, 4); enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x15_082a, 1); pushw(ds);                                /* push ds */
            ii(0x15_082b, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_082e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_0830, 4); cmp(memw_a16[ss, bp + 0x6], 0);           /* cmp word [bp+0x6], 0x0 */
            ii(0x15_0834, 2); if(jnzw(0x15_0871, 0x3b)) goto l_0x15_0871; /* jnz 0x871 */
            ii(0x15_0836, 5); cmp(memw_a16[ds, 0x1890], 0);             /* cmp word [0x1890], 0x0 */
            ii(0x15_083b, 2); if(jzw(0x15_0871, 0x34)) goto l_0x15_0871; /* jz 0x871 */
            ii(0x15_083d, 1); pushw(ds);                                /* push ds */
            ii(0x15_083e, 3); pushw(0x1925);                            /* push 0x1925 */
            ii(0x15_0841, 1); nop();                                    /* nop */
            ii(0x15_0842, 1); pushw(cs);                                /* push cs */
            ii(0x15_0843, 3); callw(0x15_5030, 0x47ea);                 /* call 0x5030 */
            ii(0x15_0846, 1); popw(bx);                                 /* pop bx */
            ii(0x15_0847, 1); popw(bx);                                 /* pop bx */
            ii(0x15_0848, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_084b, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_084d, 2); if(jzw(0x15_0871, 0x22)) goto l_0x15_0871; /* jz 0x871 */
            ii(0x15_084f, 1); pushw(ds);                                /* push ds */
            ii(0x15_0850, 3); pushw(0x1930);                            /* push 0x1930 */
            ii(0x15_0853, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_0856, 1); pushw(ax);                                /* push ax */
            ii(0x15_0857, 1); nop();                                    /* nop */
            ii(0x15_0858, 1); pushw(cs);                                /* push cs */
            ii(0x15_0859, 3); callw(0x15_4eb0, 0x4654);                 /* call 0x4eb0 */
            ii(0x15_085c, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_085f, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x15_0862, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x15_0865, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_0867, 2); if(jzw(0x15_0871, 0x8)) goto l_0x15_0871; /* jz 0x871 */
            ii(0x15_0869, 4); pushw(memw_a16[ds, 0x1890]);              /* push word [0x1890] */
            ii(0x15_086d, 3); callw_a16_far_ind(ss, bp - 0x8);          /* call far word [bp-0x8] */
            ii(0x15_0870, 1); popw(bx);                                 /* pop bx */
        l_0x15_0871:
            ii(0x15_0871, 3); mov(ax, memw_a16[ds, 0x185c]);            /* mov ax, [0x185c] */
            ii(0x15_0874, 4); or(ax, memw_a16[ds, 0x185a]);             /* or ax, [0x185a] */
            ii(0x15_0878, 2); if(jzw(0x15_088b, 0x11)) goto l_0x15_088b; /* jz 0x88b */
            ii(0x15_087a, 4); pushw(memw_a16[ds, 0x185c]);              /* push word [0x185c] */
            ii(0x15_087e, 4); pushw(memw_a16[ds, 0x185a]);              /* push word [0x185a] */
            ii(0x15_0882, 2); pushw(0x3);                               /* push 0x3 */
            ii(0x15_0884, 1); pushw(cs);                                /* push cs */
            ii(0x15_0885, 3); callw(0x15_0588, -0x300);                 /* call 0x588 */
            ii(0x15_0888, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x15_088b:
            ii(0x15_088b, 3); mov(ax, memw_a16[ds, 0x1858]);            /* mov ax, [0x1858] */
            ii(0x15_088e, 4); or(ax, memw_a16[ds, 0x1856]);             /* or ax, [0x1856] */
            ii(0x15_0892, 2); if(jzw(0x15_08a5, 0x11)) goto l_0x15_08a5; /* jz 0x8a5 */
            ii(0x15_0894, 4); pushw(memw_a16[ds, 0x1858]);              /* push word [0x1858] */
            ii(0x15_0898, 4); pushw(memw_a16[ds, 0x1856]);              /* push word [0x1856] */
            ii(0x15_089c, 2); pushw(0xa);                               /* push 0xa */
            ii(0x15_089e, 1); pushw(cs);                                /* push cs */
            ii(0x15_089f, 3); callw(0x15_0588, -0x31a);                 /* call 0x588 */
            ii(0x15_08a2, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x15_08a5:
            ii(0x15_08a5, 1); popw(ds);                                 /* pop ds */
            ii(0x15_08a6, 1); leavew();                                 /* leave */
            ii(0x15_08a7, 1); retfw(); return;                          /* retf */
        }
    }
}
