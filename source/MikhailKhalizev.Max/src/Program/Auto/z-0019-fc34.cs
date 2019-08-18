using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_fc34-840f54a2")]
        public void Method_0019_fc34()
        {
            ii(0x19_fc34, 4); enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x19_fc38, 1); pushw(ds);                                /* push ds */
            ii(0x19_fc39, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_fc3c, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_fc3e, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_fc41, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x19_fc44, 4); mov(dx, memw_a16[es, bx + 0x2]);          /* mov dx, [es:bx+0x2] */
            ii(0x19_fc48, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_fc4b, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x19_fc4e, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_fc50, 2); if(jnzw(0x19_fc6f, 0x1d)) goto l_0x19_fc6f; /* jnz 0xfc6f */
            ii(0x19_fc52, 3); pushw(memw_a16[ss, bp + 0x12]);           /* push word [bp+0x12] */
            ii(0x19_fc55, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x19_fc58, 5); callw_far_abs(0x80, 0x5ba0);              /* call word 0x80:0x5ba0 */
            ii(0x19_fc5d, 1); popw(bx);                                 /* pop bx */
            ii(0x19_fc5e, 1); popw(bx);                                 /* pop bx */
            ii(0x19_fc5f, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_fc62, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x19_fc65, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_fc68, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x19_fc6b, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
        l_0x19_fc6f:
            ii(0x19_fc6f, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x19_fc72, 3); or(ax, memw_a16[ss, bp - 0x4]);           /* or ax, [bp-0x4] */
            ii(0x19_fc75, 2); if(jzw(0x19_fca1, 0x2a)) goto l_0x19_fca1; /* jz 0xfca1 */
            ii(0x19_fc77, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x19_fc7a, 3); or(ax, memw_a16[ss, bp + 0x4]);           /* or ax, [bp+0x4] */
            ii(0x19_fc7d, 2); if(jzw(0x19_fca6, 0x27)) goto l_0x19_fca6; /* jz 0xfca6 */
            ii(0x19_fc7f, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x19_fc82, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x19_fc85, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x19_fc88, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x19_fc8b, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x19_fc90, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_fc93, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x19_fc96, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x19_fc99, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
            ii(0x19_fc9d, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_fc9f, 2); if(jnzw(0x19_fca6, 0x5)) goto l_0x19_fca6; /* jnz 0xfca6 */
        l_0x19_fca1:
            ii(0x19_fca1, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_fca4, 2); jmpw(0x19_fca8, 0x2); goto l_0x19_fca8;   /* jmp 0xfca8 */
        l_0x19_fca6:
            ii(0x19_fca6, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_fca8:
            ii(0x19_fca8, 1); popw(ds);                                 /* pop ds */
            ii(0x19_fca9, 1); leavew();                                 /* leave */
            ii(0x19_fcaa, 3); retw(0x10); return;                       /* ret 0x10 */
        }
    }
}
