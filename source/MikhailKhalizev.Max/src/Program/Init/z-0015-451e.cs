using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a4b28c77-7a5e-4831-b86f-a13a74f1754b")]
        public void Method_0015_451e()
        {
            ii(0x15_451e, 4); enterw(0x18, 0);                          /* enter 0x18, 0x0 */
            ii(0x15_4522, 1); pushw(ds);                                /* push ds */
            ii(0x15_4523, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_4526, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_4528, 5); cmp(memw_a16[ss, bp + 0x6], 0x100);       /* cmp word [bp+0x6], 0x100 */
            ii(0x15_452d, 2); if(jbw(0x15_4534, 0x5)) goto l_0x15_4534; /* jb 0x4534 */
            ii(0x15_452f, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_4531, 1); popw(ds);                                 /* pop ds */
            ii(0x15_4532, 1); leavew();                                 /* leave */
            ii(0x15_4533, 1); retfw(); return;                          /* retf */
        l_0x15_4534:
            ii(0x15_4534, 5); cmp(memw_a16[ds, 0x3b72], 0);             /* cmp word [0x3b72], 0x0 */
            ii(0x15_4539, 2); if(jnzw(0x15_4564, 0x29)) goto l_0x15_4564; /* jnz 0x4564 */
            ii(0x15_453b, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_453d, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_453f, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x15_4542, 1); pushw(ss);                                /* push ss */
            ii(0x15_4543, 1); pushw(ax);                                /* push ax */
            ii(0x15_4544, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_4547, 3); pushw(0x200);                             /* push 0x200 */
            ii(0x15_454a, 1); nop();                                    /* nop */
            ii(0x15_454b, 1); pushw(cs);                                /* push cs */
            ii(0x15_454c, 3); callw(0x15_41fd, -0x352);                 /* call 0x41fd */
            ii(0x15_454f, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_4552, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_4555, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x15_4558, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x15_455b, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_455e, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x15_4561, 2); jmpw(0x15_4589, 0x26); goto l_0x15_4589;  /* jmp 0x4589 */
        //  ii(0x15_4563, 1); Недостижимый код.
l_0x15_4564:
            ii(0x15_4564, 3); mov(ax, memw_a16[ds, 0x3b7e]);            /* mov ax, [0x3b7e] */
            ii(0x15_4567, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x15_456a, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_456d, 3); shl(ax, 0x2);                             /* shl ax, 0x2 */
            ii(0x15_4570, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x15_4573, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_4576, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x15_4579, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_457c, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x15_457f, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x15_4582, 4); mov(ax, memw_a16[es, bx + 0x2]);          /* mov ax, [es:bx+0x2] */
            ii(0x15_4586, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
        l_0x15_4589:
            ii(0x15_4589, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x15_458d, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_4590, 1); popw(ds);                                 /* pop ds */
            ii(0x15_4591, 1); leavew();                                 /* leave */
            ii(0x15_4592, 1); retfw(); return;                          /* retf */
        }
    }
}
