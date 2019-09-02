using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_cde9-75675517")]
        public void Method_0019_cde9()
        {
            ii(0x19_cde9, 4); enter(8, 0);                              /* enter 0x8, 0x0 */
            ii(0x19_cded, 1); push(si);                                 /* push si */
            ii(0x19_cdee, 3); les(bx, memw[ss, bp + 0xc]);              /* les bx, [bp+0xc] */
            ii(0x19_cdf1, 4); mov(ax, memw[es, bx + 0x28]);             /* mov ax, [es:bx+0x28] */
            ii(0x19_cdf5, 4); mov(dx, memw[es, bx + 0x2a]);             /* mov dx, [es:bx+0x2a] */
            ii(0x19_cdf9, 3); mov(memw[ss, bp - 6], ax);                /* mov [bp-0x6], ax */
            ii(0x19_cdfc, 3); mov(memw[ss, bp - 4], dx);                /* mov [bp-0x4], dx */
            ii(0x19_cdff, 3); les(bx, memw[ss, bp + 4]);                /* les bx, [bp+0x4] */
            ii(0x19_ce02, 4); mov(memb[es, bx], 0);                     /* mov byte [es:bx], 0x0 */
            ii(0x19_ce06, 3); mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0x19_ce09, 3); or(ax, memw[ss, bp + 8]);                 /* or ax, [bp+0x8] */
            ii(0x19_ce0c, 2); if(jz(0x19_ce6b, 0x5d)) goto l_0x19_ce6b; /* jz 0xce6b */
        l_0x19_ce0e:
            ii(0x19_ce0e, 4); sub(memw[ss, bp + 8], 1);                 /* sub word [bp+0x8], 0x1 */
            ii(0x19_ce12, 4); sbb(memw[ss, bp + 0xa], 0);               /* sbb word [bp+0xa], 0x0 */
            ii(0x19_ce16, 3); mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0x19_ce19, 3); or(ax, memw[ss, bp + 8]);                 /* or ax, [bp+0x8] */
            ii(0x19_ce1c, 2); if(jz(0x19_ce32, 0x14)) goto l_0x19_ce32; /* jz 0xce32 */
            ii(0x19_ce1e, 3); les(bx, memw[ss, bp - 6]);                /* les bx, [bp-0x6] */
            ii(0x19_ce21, 4); cmp(memb[es, bx], 0);                     /* cmp byte [es:bx], 0x0 */
            ii(0x19_ce25, 2); if(jz(0x19_ce32, 0xb)) goto l_0x19_ce32;  /* jz 0xce32 */
            ii(0x19_ce27, 3); mov(al, memb[es, bx]);                    /* mov al, [es:bx] */
            ii(0x19_ce2a, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x19_ce2c, 1); inc(ax);                                  /* inc ax */
            ii(0x19_ce2d, 3); add(memw[ss, bp - 6], ax);                /* add [bp-0x6], ax */
            ii(0x19_ce30, 2); jmp(0x19_ce0e, -0x24); goto l_0x19_ce0e;  /* jmp 0xce0e */
        l_0x19_ce32:
            ii(0x19_ce32, 3); les(bx, memw[ss, bp - 6]);                /* les bx, [bp-0x6] */
            ii(0x19_ce35, 3); mov(al, memb[es, bx]);                    /* mov al, [es:bx] */
            ii(0x19_ce38, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x19_ce3a, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x19_ce3d, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_ce3f, 2); if(jz(0x19_ce5d, 0x1c)) goto l_0x19_ce5d; /* jz 0xce5d */
            ii(0x19_ce41, 2); jmp(0x19_ce53, 0x10); goto l_0x19_ce53;   /* jmp 0xce53 */
        l_0x19_ce43:
            ii(0x19_ce43, 3); les(bx, memw[ss, bp - 6]);                /* les bx, [bp-0x6] */
            ii(0x19_ce46, 3); mov(si, memw[ss, bp - 2]);                /* mov si, [bp-0x2] */
            ii(0x19_ce49, 4); mov(al, memb[es, bx + si + 1]);           /* mov al, [es:bx+si+0x1] */
            ii(0x19_ce4d, 3); les(bx, memw[ss, bp + 4]);                /* les bx, [bp+0x4] */
            ii(0x19_ce50, 3); mov(memb[es, bx + si], al);               /* mov [es:bx+si], al */
        l_0x19_ce53:
            ii(0x19_ce53, 3); mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x19_ce56, 3); dec(memw[ss, bp - 2]);                    /* dec word [bp-0x2] */
            ii(0x19_ce59, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_ce5b, 2); if(jnz(0x19_ce43, -0x1a)) goto l_0x19_ce43; /* jnz 0xce43 */
        l_0x19_ce5d:
            ii(0x19_ce5d, 3); les(bx, memw[ss, bp - 6]);                /* les bx, [bp-0x6] */
            ii(0x19_ce60, 3); mov(bl, memb[es, bx]);                    /* mov bl, [es:bx] */
            ii(0x19_ce63, 2); sub(bh, bh);                              /* sub bh, bh */
            ii(0x19_ce65, 3); les(si, memw[ss, bp + 4]);                /* les si, [bp+0x4] */
            ii(0x19_ce68, 3); mov(memb[es, bx + si], bh);               /* mov [es:bx+si], bh */
        l_0x19_ce6b:
            ii(0x19_ce6b, 1); pop(si);                                  /* pop si */
            ii(0x19_ce6c, 1); leave();                                  /* leave */
            ii(0x19_ce6d, 3); ret(0xc);                                 /* ret 0xc */
        }
    }
}
