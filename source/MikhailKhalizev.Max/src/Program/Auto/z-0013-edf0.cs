using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f6b3234c-627b-4c99-a569-2be202f92125")]
        public void Method_0013_edf0()
        {
            ii(0x13_edf0, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x13_edf4, 1); pushw(ds);                                /* push ds */
            ii(0x13_edf5, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_edf8, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_edfa, 4); mov(es, memw_a16[ds, 0x1dce]);            /* mov es, [0x1dce] */
            ii(0x13_edfe, 4); mov(ax, memw_a16[es, 0x1418]);            /* mov ax, [es:0x1418] */
            ii(0x13_ee02, 2); sub(bx, bx);                              /* sub bx, bx */
            ii(0x13_ee04, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x13_ee06, 4); mov(ax, memw_a16[es, bx + 0x42]);         /* mov ax, [es:bx+0x42] */
            ii(0x13_ee0a, 4); mov(dx, memw_a16[es, bx + 0x44]);         /* mov dx, [es:bx+0x44] */
        l_0x13_ee0e:
            ii(0x13_ee0e, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_ee11, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x13_ee14, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x13_ee16, 3); or(ax, memw_a16[ss, bp - 0x4]);           /* or ax, [bp-0x4] */
            ii(0x13_ee19, 2); if(jzw(0x13_ee4c, 0x31)) goto l_0x13_ee4c; /* jz 0xee4c */
            ii(0x13_ee1b, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x13_ee1e, 4); pushw(memw_a16[es, bx + 0x6]);            /* push word [es:bx+0x6] */
            ii(0x13_ee22, 4); pushw(memw_a16[es, bx + 0x4]);            /* push word [es:bx+0x4] */
            ii(0x13_ee26, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_ee29, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_ee2c, 1); pushw(cs);                                /* push cs */
            ii(0x13_ee2d, 3); callw(0x13_ec28, -0x208);                 /* call 0xec28 */
            ii(0x13_ee30, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_ee33, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_ee35, 2); if(jzw(0x13_ee40, 0x9)) goto l_0x13_ee40; /* jz 0xee40 */
            ii(0x13_ee37, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_ee3a, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_ee3d, 1); popw(ds);                                 /* pop ds */
            ii(0x13_ee3e, 1); leavew();                                 /* leave */
            ii(0x13_ee3f, 1); retfw(); return;                          /* retf */
        l_0x13_ee40:
            ii(0x13_ee40, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x13_ee43, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x13_ee46, 4); mov(dx, memw_a16[es, bx + 0x2]);          /* mov dx, [es:bx+0x2] */
            ii(0x13_ee4a, 2); jmpw(0x13_ee0e, -0x3e); goto l_0x13_ee0e; /* jmp 0xee0e */
        l_0x13_ee4c:
            ii(0x13_ee4c, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_ee4e, 1); cwd();                                    /* cwd */
            ii(0x13_ee4f, 1); popw(ds);                                 /* pop ds */
            ii(0x13_ee50, 1); leavew();                                 /* leave */
            ii(0x13_ee51, 1); retfw(); return;                          /* retf */
        }
    }
}
