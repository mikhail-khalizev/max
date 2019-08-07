using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("218164ac-aaaa-42c4-ab94-fa307770771e")]
        public void Method_0013_75ee()
        {
            ii(0x13_75ee, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x13_75f2, 1); pushw(ds);                                /* push ds */
            ii(0x13_75f3, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_75f6, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_75f8, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
        l_0x13_75fd:
            ii(0x13_75fd, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x13_7600, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_7603, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_7606, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x13_7608, 1); nop();                                    /* nop */
            ii(0x13_7609, 1); pushw(cs);                                /* push cs */
            ii(0x13_760a, 3); callw(0x13_081c, -0x6df1);                /* call 0x81c */
            ii(0x13_760d, 1); dec(ax);                                  /* dec ax */
            ii(0x13_760e, 2); if(jnzw(0x13_7630, 0x20)) goto l_0x13_7630; /* jnz 0x7630 */
            ii(0x13_7610, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_7613, 4); cmp(memb_a16[es, bx], 0xa);               /* cmp byte [es:bx], 0xa */
            ii(0x13_7617, 2); if(jzw(0x13_7630, 0x17)) goto l_0x13_7630; /* jz 0x7630 */
            ii(0x13_7619, 4); cmp(memb_a16[es, bx], 0x1a);              /* cmp byte [es:bx], 0x1a */
            ii(0x13_761d, 2); if(jzw(0x13_7630, 0x11)) goto l_0x13_7630; /* jz 0x7630 */
            ii(0x13_761f, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x13_7622, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
            ii(0x13_7625, 3); cmp(memw_a16[ss, bp - 0x2], ax);          /* cmp [bp-0x2], ax */
            ii(0x13_7628, 2); if(jgw(0x13_7630, 0x6)) goto l_0x13_7630; /* jg 0x7630 */
            ii(0x13_762a, 3); inc(memw_a16[ss, bp + 0x6]);              /* inc word [bp+0x6] */
            ii(0x13_762d, 2); jmpw(0x13_75fd, -0x32); goto l_0x13_75fd; /* jmp 0x75fd */
        //  ii(0x13_762f, 1); Недостижимый код.
l_0x13_7630:
            ii(0x13_7630, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_7633, 4); mov(memb_a16[es, bx], 0);                 /* mov byte [es:bx], 0x0 */
            ii(0x13_7637, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x13_763a, 1); popw(ds);                                 /* pop ds */
            ii(0x13_763b, 1); leavew();                                 /* leave */
            ii(0x13_763c, 1); retfw(); return;                          /* retf */
        }
    }
}
