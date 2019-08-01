using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6bd7aad9-7e9d-4f9e-ac92-dbb80f460f2b")]
        public void Method_0015_f9ac()
        {
            ii(0x15_f9ac, 4); enterw(0xe, 0);                           /* enter 0xe, 0x0 */
            ii(0x15_f9b0, 4); mov(es, memw_a16[ds, 0x3fde]);            /* mov es, [0x3fde] */
            ii(0x15_f9b4, 4); mov(ax, memw_a16[es, 0x3b78]);            /* mov ax, [es:0x3b78] */
            ii(0x15_f9b8, 2); sub(bx, bx);                              /* sub bx, bx */
            ii(0x15_f9ba, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x15_f9bc, 4); mov(ax, memw_a16[es, bx + 0x42]);         /* mov ax, [es:bx+0x42] */
            ii(0x15_f9c0, 4); mov(dx, memw_a16[es, bx + 0x44]);         /* mov dx, [es:bx+0x44] */
            ii(0x15_f9c4, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_f9c7, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_f9ca, 3); mov(memw_a16[ss, bp - 0xa], bx);          /* mov [bp-0xa], bx */
        l_0x15_f9cd:
            ii(0x15_f9cd, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x15_f9d0, 3); or(ax, memw_a16[ss, bp - 0x4]);           /* or ax, [bp-0x4] */
            ii(0x15_f9d3, 2); if(jzw(0x15_fa13, 0x3e)) goto l_0x15_fa13; /* jz 0xfa13 */
            ii(0x15_f9d5, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_f9d8, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_f9db, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_f9de, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_f9e1, 5); callw_far_abs(0x80, 0x5a20);              /* call word 0x80:0x5a20 */
            ii(0x15_f9e6, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_f9e9, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x15_f9ec, 3); mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
            ii(0x15_f9ef, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_f9f1, 2); if(jzw(0x15_fa01, 0xe)) goto l_0x15_fa01; /* jz 0xfa01 */
            ii(0x15_f9f3, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_f9f6, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_f9f9, 3); callw_a16_far_ind(ss, bp - 0xe);          /* call far word [bp-0xe] */
            ii(0x15_f9fc, 1); popw(bx);                                 /* pop bx */
            ii(0x15_f9fd, 1); popw(bx);                                 /* pop bx */
            ii(0x15_f9fe, 3); inc(memw_a16[ss, bp - 0xa]);              /* inc word [bp-0xa] */
        l_0x15_fa01:
            ii(0x15_fa01, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x15_fa04, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x15_fa07, 4); mov(dx, memw_a16[es, bx + 0x2]);          /* mov dx, [es:bx+0x2] */
            ii(0x15_fa0b, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_fa0e, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_fa11, 2); jmpw(0x15_f9cd, -0x46); goto l_0x15_f9cd; /* jmp 0xf9cd */
        l_0x15_fa13:
            ii(0x15_fa13, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x15_fa16, 1); leavew();                                 /* leave */
            ii(0x15_fa17, 1); retfw(); return;                          /* retf */
        }
    }
}
