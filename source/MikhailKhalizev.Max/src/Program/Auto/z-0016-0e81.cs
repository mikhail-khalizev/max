using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("37af8828-3ed8-420f-9825-241784ccd2a4")]
        public void Method_0016_0e81()
        {
            ii(0x16_0e81, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x16_0e85, 1); pushw(ds);                                /* push ds */
            ii(0x16_0e86, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x16_0e89, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x16_0e8b, 2); jmpw(0x16_0edc, 0x4f); goto l_0x16_0edc;  /* jmp 0xedc */
        l_0x16_0e8d:
            ii(0x16_0e8d, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x16_0e90, 3); lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x16_0e93, 1); pushw(ss);                                /* push ss */
            ii(0x16_0e94, 1); pushw(ax);                                /* push ax */
            ii(0x16_0e95, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x16_0e97, 3); callw(0x15_fef1, -0xfa9);                 /* call 0xfef1 */
            ii(0x16_0e9a, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x16_0e9d, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x16_0ea0, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x16_0ea4, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x16_0ea7, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x16_0eaa, 3); callw(0x15_fef1, -0xfbc);                 /* call 0xfef1 */
            ii(0x16_0ead, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x16_0eb0, 3); add(ax, 0x4);                             /* add ax, 0x4 */
            ii(0x16_0eb3, 3); sub(memw_a16[ss, bp + 0xa], ax);          /* sub [bp+0xa], ax */
            ii(0x16_0eb6, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x16_0eb9, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x16_0ebc, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x16_0ebf, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x16_0ec2, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x16_0ec6, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x16_0ec9, 1); pushw(cs);                                /* push cs */
            ii(0x16_0eca, 3); callw(0x16_0e42, -0x8b);                  /* call 0xe42 */
            ii(0x16_0ecd, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x16_0ed0, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x16_0ed3, 3); mul(memw_a16[ss, bp - 0x4]);              /* mul word [bp-0x4] */
            ii(0x16_0ed6, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x16_0ed9, 3); add(memw_a16[es, bx], ax);                /* add [es:bx], ax */
        l_0x16_0edc:
            ii(0x16_0edc, 4); cmp(memw_a16[ss, bp + 0xa], 0);           /* cmp word [bp+0xa], 0x0 */
            ii(0x16_0ee0, 2); if(jnzw(0x16_0e8d, -0x55)) goto l_0x16_0e8d; /* jnz 0xe8d */
            ii(0x16_0ee2, 1); popw(ds);                                 /* pop ds */
            ii(0x16_0ee3, 1); leavew();                                 /* leave */
            ii(0x16_0ee4, 3); retfw(0x8); return;                       /* retf 0x8 */
        }
    }
}
