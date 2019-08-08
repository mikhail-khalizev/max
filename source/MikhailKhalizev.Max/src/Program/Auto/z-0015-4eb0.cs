using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f9bb0480-8999-4dca-b118-9bbc0854cfe3")]
        public void Method_0015_4eb0()
        {
            ii(0x15_4eb0, 4); enterw(0x6, 0);                           /* enter 0x6, 0x0 */
            ii(0x15_4eb4, 1); pushw(ds);                                /* push ds */
            ii(0x15_4eb5, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_4eb8, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_4eba, 5); mov(memw_a16[ss, bp - 0x6], 0);           /* mov word [bp-0x6], 0x0 */
            ii(0x15_4ebf, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_4ec2, 4); mov(ax, memw_a16[es, bx + 0xc]);          /* mov ax, [es:bx+0xc] */
            ii(0x15_4ec6, 4); mov(dx, memw_a16[es, bx + 0xe]);          /* mov dx, [es:bx+0xe] */
            ii(0x15_4eca, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_4ecd, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_4ed0, 2); jmpw(0x15_4ed9, 0x7); goto l_0x15_4ed9;   /* jmp 0x4ed9 */
        l_0x15_4ed2:
            ii(0x15_4ed2, 3); inc(memw_a16[ss, bp - 0x6]);              /* inc word [bp-0x6] */
            ii(0x15_4ed5, 4); add(memw_a16[ss, bp - 0x4], 0x8);         /* add word [bp-0x4], 0x8 */
        l_0x15_4ed9:
            ii(0x15_4ed9, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x15_4edc, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_4edf, 4); cmp(memw_a16[es, bx + 0xa], ax);          /* cmp [es:bx+0xa], ax */
            ii(0x15_4ee3, 2); if(jlew(0x15_4f0e, 0x29)) goto l_0x15_4f0e; /* jle 0x4f0e */
            ii(0x15_4ee5, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x15_4ee8, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x15_4eec, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x15_4eef, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_4ef2, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_4ef5, 1); pushw(cs);                                /* push cs */
            ii(0x15_4ef6, 3); callw(0x15_4e68, -0x91);                  /* call 0x4e68 */
            ii(0x15_4ef9, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_4efc, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_4efe, 2); if(jzw(0x15_4ed2, -0x2e)) goto l_0x15_4ed2; /* jz 0x4ed2 */
        l_0x15_4f00:
            ii(0x15_4f00, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x15_4f03, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x15_4f07, 4); mov(dx, memw_a16[es, bx + 0x6]);          /* mov dx, [es:bx+0x6] */
            ii(0x15_4f0b, 1); popw(ds);                                 /* pop ds */
            ii(0x15_4f0c, 1); leavew();                                 /* leave */
            ii(0x15_4f0d, 1); retfw(); return;                          /* retf */
        l_0x15_4f0e:
            ii(0x15_4f0e, 5); mov(memw_a16[ss, bp - 0x6], 0);           /* mov word [bp-0x6], 0x0 */
            ii(0x15_4f13, 4); mov(ax, memw_a16[es, bx + 0x12]);         /* mov ax, [es:bx+0x12] */
            ii(0x15_4f17, 4); mov(dx, memw_a16[es, bx + 0x14]);         /* mov dx, [es:bx+0x14] */
            ii(0x15_4f1b, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_4f1e, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_4f21, 2); jmpw(0x15_4f2b, 0x8); goto l_0x15_4f2b;   /* jmp 0x4f2b */
        //    ii(0x15_4f23, 1); nop();                                    /* nop */
        l_0x15_4f24:
            ii(0x15_4f24, 3); inc(memw_a16[ss, bp - 0x6]);              /* inc word [bp-0x6] */
            ii(0x15_4f27, 4); add(memw_a16[ss, bp - 0x4], 0x8);         /* add word [bp-0x4], 0x8 */
        l_0x15_4f2b:
            ii(0x15_4f2b, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x15_4f2e, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_4f31, 4); cmp(memw_a16[es, bx + 0x10], ax);         /* cmp [es:bx+0x10], ax */
            ii(0x15_4f35, 2); if(jlew(0x15_4f54, 0x1d)) goto l_0x15_4f54; /* jle 0x4f54 */
            ii(0x15_4f37, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x15_4f3a, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x15_4f3e, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x15_4f41, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_4f44, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_4f47, 1); pushw(cs);                                /* push cs */
            ii(0x15_4f48, 3); callw(0x15_4e68, -0xe3);                  /* call 0x4e68 */
            ii(0x15_4f4b, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_4f4e, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_4f50, 2); if(jzw(0x15_4f24, -0x2e)) goto l_0x15_4f24; /* jz 0x4f24 */
            ii(0x15_4f52, 2); jmpw(0x15_4f00, -0x54); goto l_0x15_4f00; /* jmp 0x4f00 */
        l_0x15_4f54:
            ii(0x15_4f54, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_4f56, 1); cwd();                                    /* cwd */
            ii(0x15_4f57, 1); popw(ds);                                 /* pop ds */
            ii(0x15_4f58, 1); leavew();                                 /* leave */
            ii(0x15_4f59, 1); retfw(); return;                          /* retf */
        }
    }
}
