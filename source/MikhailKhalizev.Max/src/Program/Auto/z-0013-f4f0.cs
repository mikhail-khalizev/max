using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4e0147e0-54ec-48ca-91ff-fc5dfecb5cd2")]
        public void Method_0013_f4f0()
        {
            ii(0x13_f4f0, 4); enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x13_f4f4, 1); pushw(ds);                                /* push ds */
            ii(0x13_f4f5, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_f4f8, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_f4fa, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x13_f4fd, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x13_f500, 4); mov(dx, memw_a16[es, bx + 0x2]);          /* mov dx, [es:bx+0x2] */
            ii(0x13_f504, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_f507, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x13_f50a, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x13_f50c, 2); if(jnzw(0x13_f52b, 0x1d)) goto l_0x13_f52b; /* jnz 0xf52b */
            ii(0x13_f50e, 3); pushw(memw_a16[ss, bp + 0x12]);           /* push word [bp+0x12] */
            ii(0x13_f511, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x13_f514, 1); nop();                                    /* nop */
            ii(0x13_f515, 1); pushw(cs);                                /* push cs */
            ii(0x13_f516, 3); callw(0x13_edf0, -0x729);                 /* call 0xedf0 */
            ii(0x13_f519, 1); popw(bx);                                 /* pop bx */
            ii(0x13_f51a, 1); popw(bx);                                 /* pop bx */
            ii(0x13_f51b, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_f51e, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x13_f521, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x13_f524, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x13_f527, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
        l_0x13_f52b:
            ii(0x13_f52b, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x13_f52e, 3); or(ax, memw_a16[ss, bp - 0x4]);           /* or ax, [bp-0x4] */
            ii(0x13_f531, 2); if(jzw(0x13_f55d, 0x2a)) goto l_0x13_f55d; /* jz 0xf55d */
            ii(0x13_f533, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_f536, 3); or(ax, memw_a16[ss, bp + 0x4]);           /* or ax, [bp+0x4] */
            ii(0x13_f539, 2); if(jzw(0x13_f562, 0x27)) goto l_0x13_f562; /* jz 0xf562 */
            ii(0x13_f53b, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x13_f53e, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x13_f541, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_f544, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_f547, 1); nop();                                    /* nop */
            ii(0x13_f548, 1); pushw(cs);                                /* push cs */
            ii(0x13_f549, 3); callw(0x13_ec70, -0x8dc);                 /* call 0xec70 */
            ii(0x13_f54c, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_f54f, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x13_f552, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x13_f555, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
            ii(0x13_f559, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x13_f55b, 2); if(jnzw(0x13_f562, 0x5)) goto l_0x13_f562; /* jnz 0xf562 */
        l_0x13_f55d:
            ii(0x13_f55d, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_f560, 2); jmpw(0x13_f564, 0x2); goto l_0x13_f564;   /* jmp 0xf564 */
        l_0x13_f562:
            ii(0x13_f562, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x13_f564:
            ii(0x13_f564, 1); popw(ds);                                 /* pop ds */
            ii(0x13_f565, 1); leavew();                                 /* leave */
            ii(0x13_f566, 3); retw(0x10); return;                       /* ret 0x10 */
        }
    }
}
