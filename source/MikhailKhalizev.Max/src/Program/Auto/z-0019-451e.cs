using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_451e-5d9584db")]
        public void Method_0019_451e()
        {
            ii(0x19_451e, 4); enter(0x18, 0);                           /* enter 0x18, 0x0 */
            ii(0x19_4522, 1); push(ds);                                 /* push ds */
            ii(0x19_4523, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_4526, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_4528, 5); cmp(memw[ss, bp + 0x6], 0x100);           /* cmp word [bp+0x6], 0x100 */
            ii(0x19_452d, 2); if(jb(0x19_4534, 0x5)) goto l_0x19_4534;  /* jb 0x4534 */
            ii(0x19_452f, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_4531, 1); pop(ds);                                  /* pop ds */
            ii(0x19_4532, 1); leave();                                  /* leave */
            ii(0x19_4533, 1); retf(); return;                           /* retf */
        l_0x19_4534:
            ii(0x19_4534, 5); cmp(memw[ds, 0x3b72], 0);                 /* cmp word [0x3b72], 0x0 */
            ii(0x19_4539, 2); if(jnz(0x19_4564, 0x29)) goto l_0x19_4564; /* jnz 0x4564 */
            ii(0x19_453b, 2); push(0);                                  /* push 0x0 */
            ii(0x19_453d, 2); push(0);                                  /* push 0x0 */
            ii(0x19_453f, 3); lea(ax, memw[ss, bp - 0x14]);             /* lea ax, [bp-0x14] */
            ii(0x19_4542, 1); push(ss);                                 /* push ss */
            ii(0x19_4543, 1); push(ax);                                 /* push ax */
            ii(0x19_4544, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_4547, 3); push(0x200);                              /* push 0x200 */
            ii(0x19_454a, 1); nop();                                    /* nop */
            ii(0x19_454b, 1); push(cs);                                 /* push cs */
            ii(0x19_454c, 3); call(0x19_41fd, -0x352);                  /* call 0x41fd */
            ii(0x19_454f, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x19_4552, 3); les(bx, memw[ss, bp + 0x8]);              /* les bx, [bp+0x8] */
            ii(0x19_4555, 3); mov(ax, memw[ss, bp - 0x6]);              /* mov ax, [bp-0x6] */
            ii(0x19_4558, 3); mov(memw[es, bx], ax);                    /* mov [es:bx], ax */
            ii(0x19_455b, 3); les(bx, memw[ss, bp + 0x8]);              /* les bx, [bp+0x8] */
            ii(0x19_455e, 3); mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x19_4561, 2); jmp(0x19_4589, 0x26); goto l_0x19_4589;   /* jmp 0x4589 */
        //  ii(0x19_4563, 1); nop();                                    /* nop */
        l_0x19_4564:
            ii(0x19_4564, 3); mov(ax, memw[ds, 0x3b7e]);                /* mov ax, [0x3b7e] */
            ii(0x19_4567, 3); mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0x19_456a, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x19_456d, 3); shl(ax, 0x2);                             /* shl ax, 0x2 */
            ii(0x19_4570, 3); mov(memw[ss, bp - 0x18], ax);             /* mov [bp-0x18], ax */
            ii(0x19_4573, 3); les(bx, memw[ss, bp - 0x18]);             /* les bx, [bp-0x18] */
            ii(0x19_4576, 3); mov(ax, memw[es, bx]);                    /* mov ax, [es:bx] */
            ii(0x19_4579, 3); les(bx, memw[ss, bp + 0x8]);              /* les bx, [bp+0x8] */
            ii(0x19_457c, 3); mov(memw[es, bx], ax);                    /* mov [es:bx], ax */
            ii(0x19_457f, 3); les(bx, memw[ss, bp - 0x18]);             /* les bx, [bp-0x18] */
            ii(0x19_4582, 4); mov(ax, memw[es, bx + 0x2]);              /* mov ax, [es:bx+0x2] */
            ii(0x19_4586, 3); les(bx, memw[ss, bp + 0x8]);              /* les bx, [bp+0x8] */
        l_0x19_4589:
            ii(0x19_4589, 4); mov(memw[es, bx + 0x2], ax);              /* mov [es:bx+0x2], ax */
            ii(0x19_458d, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_4590, 1); pop(ds);                                  /* pop ds */
            ii(0x19_4591, 1); leave();                                  /* leave */
            ii(0x19_4592, 1); retf();                                   /* retf */
        }
    }
}
