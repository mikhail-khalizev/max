using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8ab0337c-c726-44be-8a4c-4b3a3330f3a8")]
        public void Method_0019_0826()
        {
            ii(0x19_0826, 4); enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x19_082a, 1); pushw(ds);                                /* push ds */
            ii(0x19_082b, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_082e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_0830, 4); cmp(memw_a16[ss, bp + 0x6], 0);           /* cmp word [bp+0x6], 0x0 */
            ii(0x19_0834, 2); if(jnzw(0x19_0871, 0x3b)) goto l_0x19_0871; /* jnz 0x871 */
            ii(0x19_0836, 5); cmp(memw_a16[ds, 0x1890], 0);             /* cmp word [0x1890], 0x0 */
            ii(0x19_083b, 2); if(jzw(0x19_0871, 0x34)) goto l_0x19_0871; /* jz 0x871 */
            ii(0x19_083d, 1); pushw(ds);                                /* push ds */
            ii(0x19_083e, 3); pushw(0x1925);                            /* push 0x1925 */
            ii(0x19_0841, 1); nop();                                    /* nop */
            ii(0x19_0842, 1); pushw(cs);                                /* push cs */
            ii(0x19_0843, 3); callw(0x19_5030, 0x47ea);                 /* call 0x5030 */
            ii(0x19_0846, 1); popw(bx);                                 /* pop bx */
            ii(0x19_0847, 1); popw(bx);                                 /* pop bx */
            ii(0x19_0848, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x19_084b, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_084d, 2); if(jzw(0x19_0871, 0x22)) goto l_0x19_0871; /* jz 0x871 */
            ii(0x19_084f, 1); pushw(ds);                                /* push ds */
            ii(0x19_0850, 3); pushw(0x1930);                            /* push 0x1930 */
            ii(0x19_0853, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x19_0856, 1); pushw(ax);                                /* push ax */
            ii(0x19_0857, 1); nop();                                    /* nop */
            ii(0x19_0858, 1); pushw(cs);                                /* push cs */
            ii(0x19_0859, 3); callw(0x19_4eb0, 0x4654);                 /* call 0x4eb0 */
            ii(0x19_085c, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_085f, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x19_0862, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x19_0865, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_0867, 2); if(jzw(0x19_0871, 0x8)) goto l_0x19_0871; /* jz 0x871 */
            ii(0x19_0869, 4); pushw(memw_a16[ds, 0x1890]);              /* push word [0x1890] */
            ii(0x19_086d, 3); callw_a16_far_ind(ss, bp - 0x8);          /* call far word [bp-0x8] */
            ii(0x19_0870, 1); popw(bx);                                 /* pop bx */
        l_0x19_0871:
            ii(0x19_0871, 3); mov(ax, memw_a16[ds, 0x185c]);            /* mov ax, [0x185c] */
            ii(0x19_0874, 4); or(ax, memw_a16[ds, 0x185a]);             /* or ax, [0x185a] */
            ii(0x19_0878, 2); if(jzw(0x19_088b, 0x11)) goto l_0x19_088b; /* jz 0x88b */
            ii(0x19_087a, 4); pushw(memw_a16[ds, 0x185c]);              /* push word [0x185c] */
            ii(0x19_087e, 4); pushw(memw_a16[ds, 0x185a]);              /* push word [0x185a] */
            ii(0x19_0882, 2); pushw(0x3);                               /* push 0x3 */
            ii(0x19_0884, 1); pushw(cs);                                /* push cs */
            ii(0x19_0885, 3); callw(0x19_0588, -0x300);                 /* call 0x588 */
            ii(0x19_0888, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x19_088b:
            ii(0x19_088b, 3); mov(ax, memw_a16[ds, 0x1858]);            /* mov ax, [0x1858] */
            ii(0x19_088e, 4); or(ax, memw_a16[ds, 0x1856]);             /* or ax, [0x1856] */
            ii(0x19_0892, 2); if(jzw(0x19_08a5, 0x11)) goto l_0x19_08a5; /* jz 0x8a5 */
            ii(0x19_0894, 4); pushw(memw_a16[ds, 0x1858]);              /* push word [0x1858] */
            ii(0x19_0898, 4); pushw(memw_a16[ds, 0x1856]);              /* push word [0x1856] */
            ii(0x19_089c, 2); pushw(0xa);                               /* push 0xa */
            ii(0x19_089e, 1); pushw(cs);                                /* push cs */
            ii(0x19_089f, 3); callw(0x19_0588, -0x31a);                 /* call 0x588 */
            ii(0x19_08a2, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x19_08a5:
            ii(0x19_08a5, 1); popw(ds);                                 /* pop ds */
            ii(0x19_08a6, 1); leavew();                                 /* leave */
            ii(0x19_08a7, 1); retfw(); return;                          /* retf */
        }
    }
}
