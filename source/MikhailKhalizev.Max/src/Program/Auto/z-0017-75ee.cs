using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_75ee-aa90f4b8")]
        public void Method_0017_75ee()
        {
            ii(0x17_75ee, 4); enter(2, 0);                              /* enter 0x2, 0x0 */
            ii(0x17_75f2, 1); push(ds);                                 /* push ds */
            ii(0x17_75f3, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_75f6, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_75f8, 5); mov(memw[ss, bp - 2], 0);                 /* mov word [bp-0x2], 0x0 */
        l_0x17_75fd:
            ii(0x17_75fd, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x17_7600, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x17_7603, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x17_7606, 2); push(1);                                  /* push 0x1 */
            ii(0x17_7608, 1); nop();                                    /* nop */
            ii(0x17_7609, 1); push(cs);                                 /* push cs */
            ii(0x17_760a, 3); call(0x17_081c, -0x6df1);                 /* call 0x81c */
            ii(0x17_760d, 1); dec(ax);                                  /* dec ax */
            ii(0x17_760e, 2); if(jnz(0x17_7630, 0x20)) goto l_0x17_7630; /* jnz 0x7630 */
            ii(0x17_7610, 3); les(bx, memw[ss, bp + 6]);                /* les bx, [bp+0x6] */
            ii(0x17_7613, 4); cmp(memb[es, bx], 0xa);                   /* cmp byte [es:bx], 0xa */
            ii(0x17_7617, 2); if(jz(0x17_7630, 0x17)) goto l_0x17_7630; /* jz 0x7630 */
            ii(0x17_7619, 4); cmp(memb[es, bx], 0x1a);                  /* cmp byte [es:bx], 0x1a */
            ii(0x17_761d, 2); if(jz(0x17_7630, 0x11)) goto l_0x17_7630; /* jz 0x7630 */
            ii(0x17_761f, 3); mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0x17_7622, 3); inc(memw[ss, bp - 2]);                    /* inc word [bp-0x2] */
            ii(0x17_7625, 3); cmp(memw[ss, bp - 2], ax);                /* cmp [bp-0x2], ax */
            ii(0x17_7628, 2); if(jg(0x17_7630, 6)) goto l_0x17_7630;    /* jg 0x7630 */
            ii(0x17_762a, 3); inc(memw[ss, bp + 6]);                    /* inc word [bp+0x6] */
            ii(0x17_762d, 2); jmp(0x17_75fd, -0x32); goto l_0x17_75fd;  /* jmp 0x75fd */
        //  ii(0x17_762f, 1); nop();                                    /* nop */
        l_0x17_7630:
            ii(0x17_7630, 3); les(bx, memw[ss, bp + 6]);                /* les bx, [bp+0x6] */
            ii(0x17_7633, 4); mov(memb[es, bx], 0);                     /* mov byte [es:bx], 0x0 */
            ii(0x17_7637, 3); mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x17_763a, 1); pop(ds);                                  /* pop ds */
            ii(0x17_763b, 1); leave();                                  /* leave */
            ii(0x17_763c, 1); retf();                                   /* retf */
        }
    }
}
