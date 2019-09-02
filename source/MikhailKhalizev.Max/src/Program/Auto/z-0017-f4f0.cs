using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_f4f0-8d919a21")]
        public void Method_0017_f4f0()
        {
            ii(0x17_f4f0, 4); enter(8, 0);                              /* enter 0x8, 0x0 */
            ii(0x17_f4f4, 1); push(ds);                                 /* push ds */
            ii(0x17_f4f5, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_f4f8, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_f4fa, 3); les(bx, memw[ss, bp + 8]);                /* les bx, [bp+0x8] */
            ii(0x17_f4fd, 3); mov(ax, memw[es, bx]);                    /* mov ax, [es:bx] */
            ii(0x17_f500, 4); mov(dx, memw[es, bx + 2]);                /* mov dx, [es:bx+0x2] */
            ii(0x17_f504, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x17_f507, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x17_f50a, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x17_f50c, 2); if(jnz(0x17_f52b, 0x1d)) goto l_0x17_f52b; /* jnz 0xf52b */
            ii(0x17_f50e, 3); push(memw[ss, bp + 0x12]);                /* push word [bp+0x12] */
            ii(0x17_f511, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x17_f514, 1); nop();                                    /* nop */
            ii(0x17_f515, 1); push(cs);                                 /* push cs */
            ii(0x17_f516, 3); call(0x17_edf0, -0x729);                  /* call 0xedf0 */
            ii(0x17_f519, 1); pop(bx);                                  /* pop bx */
            ii(0x17_f51a, 1); pop(bx);                                  /* pop bx */
            ii(0x17_f51b, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x17_f51e, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x17_f521, 3); les(bx, memw[ss, bp + 8]);                /* les bx, [bp+0x8] */
            ii(0x17_f524, 3); mov(memw[es, bx], ax);                    /* mov [es:bx], ax */
            ii(0x17_f527, 4); mov(memw[es, bx + 2], dx);                /* mov [es:bx+0x2], dx */
        l_0x17_f52b:
            ii(0x17_f52b, 3); mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x17_f52e, 3); or(ax, memw[ss, bp - 4]);                 /* or ax, [bp-0x4] */
            ii(0x17_f531, 2); if(jz(0x17_f55d, 0x2a)) goto l_0x17_f55d; /* jz 0xf55d */
            ii(0x17_f533, 3); mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x17_f536, 3); or(ax, memw[ss, bp + 4]);                 /* or ax, [bp+0x4] */
            ii(0x17_f539, 2); if(jz(0x17_f562, 0x27)) goto l_0x17_f562; /* jz 0xf562 */
            ii(0x17_f53b, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x17_f53e, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x17_f541, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x17_f544, 3); push(memw[ss, bp - 4]);                   /* push word [bp-0x4] */
            ii(0x17_f547, 1); nop();                                    /* nop */
            ii(0x17_f548, 1); push(cs);                                 /* push cs */
            ii(0x17_f549, 3); call(0x17_ec70, -0x8dc);                  /* call 0xec70 */
            ii(0x17_f54c, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_f54f, 3); les(bx, memw[ss, bp + 4]);                /* les bx, [bp+0x4] */
            ii(0x17_f552, 3); mov(memw[es, bx], ax);                    /* mov [es:bx], ax */
            ii(0x17_f555, 4); mov(memw[es, bx + 2], dx);                /* mov [es:bx+0x2], dx */
            ii(0x17_f559, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x17_f55b, 2); if(jnz(0x17_f562, 5)) goto l_0x17_f562;   /* jnz 0xf562 */
        l_0x17_f55d:
            ii(0x17_f55d, 3); mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x17_f560, 2); jmp(0x17_f564, 2); goto l_0x17_f564;      /* jmp 0xf564 */
        l_0x17_f562:
            ii(0x17_f562, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x17_f564:
            ii(0x17_f564, 1); pop(ds);                                  /* pop ds */
            ii(0x17_f565, 1); leave();                                  /* leave */
            ii(0x17_f566, 3); ret(0x10);                                /* ret 0x10 */
        }
    }
}
