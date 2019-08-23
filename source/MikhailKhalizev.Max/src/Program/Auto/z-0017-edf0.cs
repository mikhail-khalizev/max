using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_edf0-52dfe4a0")]
        public void Method_0017_edf0()
        {
            ii(0x17_edf0, 4); enter(0x4, 0);                            /* enter 0x4, 0x0 */
            ii(0x17_edf4, 1); push(ds);                                 /* push ds */
            ii(0x17_edf5, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_edf8, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_edfa, 4); mov(es, memw[ds, 0x1dce]);                /* mov es, [0x1dce] */
            ii(0x17_edfe, 4); mov(ax, memw[es, 0x1418]);                /* mov ax, [es:0x1418] */
            ii(0x17_ee02, 2); sub(bx, bx);                              /* sub bx, bx */
            ii(0x17_ee04, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x17_ee06, 4); mov(ax, memw[es, bx + 0x42]);             /* mov ax, [es:bx+0x42] */
            ii(0x17_ee0a, 4); mov(dx, memw[es, bx + 0x44]);             /* mov dx, [es:bx+0x44] */
        l_0x17_ee0e:
            ii(0x17_ee0e, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_ee11, 3); mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x17_ee14, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x17_ee16, 3); or(ax, memw[ss, bp - 0x4]);               /* or ax, [bp-0x4] */
            ii(0x17_ee19, 2); if(jz(0x17_ee4c, 0x31)) goto l_0x17_ee4c; /* jz 0xee4c */
            ii(0x17_ee1b, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x17_ee1e, 4); push(memw[es, bx + 0x6]);                 /* push word [es:bx+0x6] */
            ii(0x17_ee22, 4); push(memw[es, bx + 0x4]);                 /* push word [es:bx+0x4] */
            ii(0x17_ee26, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x17_ee29, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x17_ee2c, 1); push(cs);                                 /* push cs */
            ii(0x17_ee2d, 3); call(0x17_ec28, -0x208);                  /* call 0xec28 */
            ii(0x17_ee30, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_ee33, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_ee35, 2); if(jz(0x17_ee40, 0x9)) goto l_0x17_ee40;  /* jz 0xee40 */
            ii(0x17_ee37, 3); mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x17_ee3a, 3); mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0x17_ee3d, 1); pop(ds);                                  /* pop ds */
            ii(0x17_ee3e, 1); leave();                                  /* leave */
            ii(0x17_ee3f, 1); retf(); return;                           /* retf */
        l_0x17_ee40:
            ii(0x17_ee40, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x17_ee43, 3); mov(ax, memw[es, bx]);                    /* mov ax, [es:bx] */
            ii(0x17_ee46, 4); mov(dx, memw[es, bx + 0x2]);              /* mov dx, [es:bx+0x2] */
            ii(0x17_ee4a, 2); jmp(0x17_ee0e, -0x3e); goto l_0x17_ee0e;  /* jmp 0xee0e */
        l_0x17_ee4c:
            ii(0x17_ee4c, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_ee4e, 1); cwd();                                    /* cwd */
            ii(0x17_ee4f, 1); pop(ds);                                  /* pop ds */
            ii(0x17_ee50, 1); leave();                                  /* leave */
            ii(0x17_ee51, 1); retf();                                   /* retf */
        }
    }
}
