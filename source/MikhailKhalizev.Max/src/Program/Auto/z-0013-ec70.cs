using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8a075c2a-b9bb-4b9f-9337-29157a32584d")]
        public void Method_0013_ec70()
        {
            ii(0x13_ec70, 4); enterw(0x6, 0);                           /* enter 0x6, 0x0 */
            ii(0x13_ec74, 1); pushw(ds);                                /* push ds */
            ii(0x13_ec75, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_ec78, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_ec7a, 5); mov(memw_a16[ss, bp - 0x6], 0);           /* mov word [bp-0x6], 0x0 */
            ii(0x13_ec7f, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_ec82, 4); mov(ax, memw_a16[es, bx + 0xc]);          /* mov ax, [es:bx+0xc] */
            ii(0x13_ec86, 4); mov(dx, memw_a16[es, bx + 0xe]);          /* mov dx, [es:bx+0xe] */
            ii(0x13_ec8a, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_ec8d, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x13_ec90, 2); jmpw(0x13_ec99, 0x7); goto l_0x13_ec99;   /* jmp 0xec99 */
        l_0x13_ec92:
            ii(0x13_ec92, 3); inc(memw_a16[ss, bp - 0x6]);              /* inc word [bp-0x6] */
            ii(0x13_ec95, 4); add(memw_a16[ss, bp - 0x4], 0x8);         /* add word [bp-0x4], 0x8 */
        l_0x13_ec99:
            ii(0x13_ec99, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x13_ec9c, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_ec9f, 4); cmp(memw_a16[es, bx + 0xa], ax);          /* cmp [es:bx+0xa], ax */
            ii(0x13_eca3, 2); if(jlew(0x13_ecce, 0x29)) goto l_0x13_ecce; /* jle 0xecce */
            ii(0x13_eca5, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x13_eca8, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x13_ecac, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x13_ecaf, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x13_ecb2, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x13_ecb5, 1); pushw(cs);                                /* push cs */
            ii(0x13_ecb6, 3); callw(0x13_ec28, -0x91);                  /* call 0xec28 */
            ii(0x13_ecb9, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_ecbc, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_ecbe, 2); if(jzw(0x13_ec92, -0x2e)) goto l_0x13_ec92; /* jz 0xec92 */
        l_0x13_ecc0:
            ii(0x13_ecc0, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x13_ecc3, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x13_ecc7, 4); mov(dx, memw_a16[es, bx + 0x6]);          /* mov dx, [es:bx+0x6] */
            ii(0x13_eccb, 1); popw(ds);                                 /* pop ds */
            ii(0x13_eccc, 1); leavew();                                 /* leave */
            ii(0x13_eccd, 1); retfw(); return;                          /* retf */
        l_0x13_ecce:
            ii(0x13_ecce, 5); mov(memw_a16[ss, bp - 0x6], 0);           /* mov word [bp-0x6], 0x0 */
            ii(0x13_ecd3, 4); mov(ax, memw_a16[es, bx + 0x12]);         /* mov ax, [es:bx+0x12] */
            ii(0x13_ecd7, 4); mov(dx, memw_a16[es, bx + 0x14]);         /* mov dx, [es:bx+0x14] */
            ii(0x13_ecdb, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_ecde, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x13_ece1, 2); jmpw(0x13_eceb, 0x8); goto l_0x13_eceb;   /* jmp 0xeceb */
        //  ii(0x13_ece3, 1); Недостижимый код.
l_0x13_ece4:
            ii(0x13_ece4, 3); inc(memw_a16[ss, bp - 0x6]);              /* inc word [bp-0x6] */
            ii(0x13_ece7, 4); add(memw_a16[ss, bp - 0x4], 0x8);         /* add word [bp-0x4], 0x8 */
        l_0x13_eceb:
            ii(0x13_eceb, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x13_ecee, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_ecf1, 4); cmp(memw_a16[es, bx + 0x10], ax);         /* cmp [es:bx+0x10], ax */
            ii(0x13_ecf5, 2); if(jlew(0x13_ed14, 0x1d)) goto l_0x13_ed14; /* jle 0xed14 */
            ii(0x13_ecf7, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x13_ecfa, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x13_ecfe, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x13_ed01, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x13_ed04, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x13_ed07, 1); pushw(cs);                                /* push cs */
            ii(0x13_ed08, 3); callw(0x13_ec28, -0xe3);                  /* call 0xec28 */
            ii(0x13_ed0b, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_ed0e, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_ed10, 2); if(jzw(0x13_ece4, -0x2e)) goto l_0x13_ece4; /* jz 0xece4 */
            ii(0x13_ed12, 2); jmpw(0x13_ecc0, -0x54); goto l_0x13_ecc0; /* jmp 0xecc0 */
        l_0x13_ed14:
            ii(0x13_ed14, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_ed16, 1); cwd();                                    /* cwd */
            ii(0x13_ed17, 1); popw(ds);                                 /* pop ds */
            ii(0x13_ed18, 1); leavew();                                 /* leave */
            ii(0x13_ed19, 1); retfw(); return;                          /* retf */
        }
    }
}
