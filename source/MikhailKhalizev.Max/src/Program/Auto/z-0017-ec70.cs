using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6314a9c0-70a8-4f05-8c51-a5d3f7e4a66a")]
        public void Method_0017_ec70()
        {
            ii(0x17_ec70, 4); enterw(0x6, 0);                           /* enter 0x6, 0x0 */
            ii(0x17_ec74, 1); pushw(ds);                                /* push ds */
            ii(0x17_ec75, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_ec78, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_ec7a, 5); mov(memw_a16[ss, bp - 0x6], 0);           /* mov word [bp-0x6], 0x0 */
            ii(0x17_ec7f, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_ec82, 4); mov(ax, memw_a16[es, bx + 0xc]);          /* mov ax, [es:bx+0xc] */
            ii(0x17_ec86, 4); mov(dx, memw_a16[es, bx + 0xe]);          /* mov dx, [es:bx+0xe] */
            ii(0x17_ec8a, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_ec8d, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x17_ec90, 2); jmpw(0x17_ec99, 0x7); goto l_0x17_ec99;   /* jmp 0xec99 */
        l_0x17_ec92:
            ii(0x17_ec92, 3); inc(memw_a16[ss, bp - 0x6]);              /* inc word [bp-0x6] */
            ii(0x17_ec95, 4); add(memw_a16[ss, bp - 0x4], 0x8);         /* add word [bp-0x4], 0x8 */
        l_0x17_ec99:
            ii(0x17_ec99, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x17_ec9c, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_ec9f, 4); cmp(memw_a16[es, bx + 0xa], ax);          /* cmp [es:bx+0xa], ax */
            ii(0x17_eca3, 2); if(jlew(0x17_ecce, 0x29)) goto l_0x17_ecce; /* jle 0xecce */
            ii(0x17_eca5, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x17_eca8, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x17_ecac, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x17_ecaf, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x17_ecb2, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x17_ecb5, 1); pushw(cs);                                /* push cs */
            ii(0x17_ecb6, 3); callw(0x17_ec28, -0x91);                  /* call 0xec28 */
            ii(0x17_ecb9, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_ecbc, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_ecbe, 2); if(jzw(0x17_ec92, -0x2e)) goto l_0x17_ec92; /* jz 0xec92 */
        l_0x17_ecc0:
            ii(0x17_ecc0, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x17_ecc3, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x17_ecc7, 4); mov(dx, memw_a16[es, bx + 0x6]);          /* mov dx, [es:bx+0x6] */
            ii(0x17_eccb, 1); popw(ds);                                 /* pop ds */
            ii(0x17_eccc, 1); leavew();                                 /* leave */
            ii(0x17_eccd, 1); retfw(); return;                          /* retf */
        l_0x17_ecce:
            ii(0x17_ecce, 5); mov(memw_a16[ss, bp - 0x6], 0);           /* mov word [bp-0x6], 0x0 */
            ii(0x17_ecd3, 4); mov(ax, memw_a16[es, bx + 0x12]);         /* mov ax, [es:bx+0x12] */
            ii(0x17_ecd7, 4); mov(dx, memw_a16[es, bx + 0x14]);         /* mov dx, [es:bx+0x14] */
            ii(0x17_ecdb, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_ecde, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x17_ece1, 2); jmpw(0x17_eceb, 0x8); goto l_0x17_eceb;   /* jmp 0xeceb */
        //    ii(0x17_ece3, 1); nop();                                    /* nop */
        l_0x17_ece4:
            ii(0x17_ece4, 3); inc(memw_a16[ss, bp - 0x6]);              /* inc word [bp-0x6] */
            ii(0x17_ece7, 4); add(memw_a16[ss, bp - 0x4], 0x8);         /* add word [bp-0x4], 0x8 */
        l_0x17_eceb:
            ii(0x17_eceb, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x17_ecee, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_ecf1, 4); cmp(memw_a16[es, bx + 0x10], ax);         /* cmp [es:bx+0x10], ax */
            ii(0x17_ecf5, 2); if(jlew(0x17_ed14, 0x1d)) goto l_0x17_ed14; /* jle 0xed14 */
            ii(0x17_ecf7, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x17_ecfa, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x17_ecfe, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x17_ed01, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x17_ed04, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x17_ed07, 1); pushw(cs);                                /* push cs */
            ii(0x17_ed08, 3); callw(0x17_ec28, -0xe3);                  /* call 0xec28 */
            ii(0x17_ed0b, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_ed0e, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_ed10, 2); if(jzw(0x17_ece4, -0x2e)) goto l_0x17_ece4; /* jz 0xece4 */
            ii(0x17_ed12, 2); jmpw(0x17_ecc0, -0x54); goto l_0x17_ecc0; /* jmp 0xecc0 */
        l_0x17_ed14:
            ii(0x17_ed14, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_ed16, 1); cwd();                                    /* cwd */
            ii(0x17_ed17, 1); popw(ds);                                 /* pop ds */
            ii(0x17_ed18, 1); leavew();                                 /* leave */
            ii(0x17_ed19, 1); retfw(); return;                          /* retf */
        }
    }
}
