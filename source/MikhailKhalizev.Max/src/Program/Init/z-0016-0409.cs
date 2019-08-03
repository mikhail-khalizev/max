using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("31eb4638-21eb-428c-9c52-5dc187681f45")]
        public void Method_0016_0409()
        {
            ii(0x16_0409, 4); enterw(0x2a, 0);                          /* enter 0x2a, 0x0 */
            ii(0x16_040d, 1); pushw(ds);                                /* push ds */
            ii(0x16_040e, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x16_0411, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x16_0413, 3); mov(ax, memw_a16[ds, 0x32a2]);            /* mov ax, [0x32a2] */
            ii(0x16_0416, 4); or(ax, memw_a16[ds, 0x32a0]);             /* or ax, [0x32a0] */
            ii(0x16_041a, 2); if(jnzw(0x16_042e, 0x12)) goto l_0x16_042e; /* jnz 0x42e */
            ii(0x16_041c, 1); pushw(ds);                                /* push ds */
            ii(0x16_041d, 3); pushw(0x3715);                            /* push 0x3715 */
            ii(0x16_0420, 1); pushw(ds);                                /* push ds */
            ii(0x16_0421, 3); pushw(0x3708);                            /* push 0x3708 */
            ii(0x16_0424, 3); callw(0x15_fcad, -0x77a);                 /* call 0xfcad */
            ii(0x16_0427, 3); mov(memw_a16[ds, 0x32a0], ax);            /* mov [0x32a0], ax */
            ii(0x16_042a, 4); mov(memw_a16[ds, 0x32a2], dx);            /* mov [0x32a2], dx */
        l_0x16_042e:
            ii(0x16_042e, 3); lea(ax, bp - 0x26);                       /* lea ax, [bp-0x26] */
            ii(0x16_0431, 1); pushw(ss);                                /* push ss */
            ii(0x16_0432, 1); pushw(ax);                                /* push ax */
            ii(0x16_0433, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x16_0436, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x16_0439, 3); callw(0x15_fff7, -0x445);                 /* call 0xfff7 */
            ii(0x16_043c, 3); mov(ax, memw_a16[ds, 0x32a2]);            /* mov ax, [0x32a2] */
            ii(0x16_043f, 4); or(ax, memw_a16[ds, 0x32a0]);             /* or ax, [0x32a0] */
            ii(0x16_0443, 2); if(jzw(0x16_0452, 0xd)) goto l_0x16_0452; /* jz 0x452 */
            ii(0x16_0445, 3); lea(ax, bp - 0x26);                       /* lea ax, [bp-0x26] */
            ii(0x16_0448, 1); pushw(ss);                                /* push ss */
            ii(0x16_0449, 1); pushw(ax);                                /* push ax */
            ii(0x16_044a, 4); callw_a16_far_ind(ds, 0x32a0);            /* call far word [0x32a0] */
            ii(0x16_044e, 1); popw(bx);                                 /* pop bx */
            ii(0x16_044f, 1); popw(bx);                                 /* pop bx */
            ii(0x16_0450, 2); jmpw(0x16_0470, 0x1e); goto l_0x16_0470;  /* jmp 0x470 */
        l_0x16_0452:
            ii(0x16_0452, 3); lea(ax, bp - 0x26);                       /* lea ax, [bp-0x26] */
            ii(0x16_0455, 1); pushw(ss);                                /* push ss */
            ii(0x16_0456, 1); pushw(ax);                                /* push ax */
            ii(0x16_0457, 5); callw_far_abs(0x80, 0x3e14);              /* call word 0x80:0x3e14 */
            ii(0x16_045c, 1); popw(bx);                                 /* pop bx */
            ii(0x16_045d, 1); popw(bx);                                 /* pop bx */
            ii(0x16_045e, 3); mov(memw_a16[ss, bp - 0x2a], ax);         /* mov [bp-0x2a], ax */
            ii(0x16_0461, 3); mov(memw_a16[ss, bp - 0x28], dx);         /* mov [bp-0x28], dx */
            ii(0x16_0464, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x16_0466, 2); if(jzw(0x16_046d, 0x5)) goto l_0x16_046d; /* jz 0x46d */
            ii(0x16_0468, 3); mov(dx, memw_a16[ss, bp - 0x28]);         /* mov dx, [bp-0x28] */
            ii(0x16_046b, 2); jmpw(0x16_0470, 0x3); goto l_0x16_0470;   /* jmp 0x470 */
        l_0x16_046d:
            ii(0x16_046d, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x16_046f, 1); cwd();                                    /* cwd */
        l_0x16_0470:
            ii(0x16_0470, 1); popw(ds);                                 /* pop ds */
            ii(0x16_0471, 1); leavew();                                 /* leave */
            ii(0x16_0472, 3); retfw(0x4); return;                       /* retf 0x4 */
        }
    }
}