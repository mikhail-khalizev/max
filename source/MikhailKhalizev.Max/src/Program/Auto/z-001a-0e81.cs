using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_0e81-5465b8f3")]
        public void Method_001a_0e81()
        {
            ii(0x1a_0e81, 4); enter(4, 0);                              /* enter 0x4, 0x0 */
            ii(0x1a_0e85, 1); push(ds);                                 /* push ds */
            ii(0x1a_0e86, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x1a_0e89, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x1a_0e8b, 2); jmp(0x1a_0edc, 0x4f); goto l_0x1a_0edc;   /* jmp 0xedc */
        l_0x1a_0e8d:
            ii(0x1a_0e8d, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x1a_0e90, 3); lea(ax, memw[ss, bp - 4]);                /* lea ax, [bp-0x4] */
            ii(0x1a_0e93, 1); push(ss);                                 /* push ss */
            ii(0x1a_0e94, 1); push(ax);                                 /* push ax */
            ii(0x1a_0e95, 2); push(4);                                  /* push 0x4 */
            ii(0x1a_0e97, 3); call(0x19_fef1, -0xfa9);                  /* call 0xfef1 */
            ii(0x1a_0e9a, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x1a_0e9d, 3); les(bx, memw[ss, bp + 6]);                /* les bx, [bp+0x6] */
            ii(0x1a_0ea0, 4); push(memw[es, bx + 2]);                   /* push word [es:bx+0x2] */
            ii(0x1a_0ea4, 3); push(memw[es, bx]);                       /* push word [es:bx] */
            ii(0x1a_0ea7, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x1a_0eaa, 3); call(0x19_fef1, -0xfbc);                  /* call 0xfef1 */
            ii(0x1a_0ead, 3); mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x1a_0eb0, 3); add(ax, 4);                               /* add ax, 0x4 */
            ii(0x1a_0eb3, 3); sub(memw[ss, bp + 0xa], ax);              /* sub [bp+0xa], ax */
            ii(0x1a_0eb6, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x1a_0eb9, 3); push(memw[ss, bp - 4]);                   /* push word [bp-0x4] */
            ii(0x1a_0ebc, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x1a_0ebf, 3); les(bx, memw[ss, bp + 6]);                /* les bx, [bp+0x6] */
            ii(0x1a_0ec2, 4); push(memw[es, bx + 2]);                   /* push word [es:bx+0x2] */
            ii(0x1a_0ec6, 3); push(memw[es, bx]);                       /* push word [es:bx] */
            ii(0x1a_0ec9, 1); push(cs);                                 /* push cs */
            ii(0x1a_0eca, 3); call(0x1a_0e42, -0x8b);                   /* call 0xe42 */
            ii(0x1a_0ecd, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x1a_0ed0, 3); mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x1a_0ed3, 3); mul(memw[ss, bp - 4]);                    /* mul word [bp-0x4] */
            ii(0x1a_0ed6, 3); les(bx, memw[ss, bp + 6]);                /* les bx, [bp+0x6] */
            ii(0x1a_0ed9, 3); add(memw[es, bx], ax);                    /* add [es:bx], ax */
        l_0x1a_0edc:
            ii(0x1a_0edc, 4); cmp(memw[ss, bp + 0xa], 0);               /* cmp word [bp+0xa], 0x0 */
            ii(0x1a_0ee0, 2); if(jnz(0x1a_0e8d, -0x55)) goto l_0x1a_0e8d; /* jnz 0xe8d */
            ii(0x1a_0ee2, 1); pop(ds);                                  /* pop ds */
            ii(0x1a_0ee3, 1); leave();                                  /* leave */
            ii(0x1a_0ee4, 3); retf(8);                                  /* retf 0x8 */
        }
    }
}
