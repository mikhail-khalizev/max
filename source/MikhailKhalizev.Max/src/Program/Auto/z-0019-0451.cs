using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_0451-6821978a")]
        public void Method_0019_0451()
        {
            ii(0x19_0451, 4); enter(0x4, 0);                            /* enter 0x4, 0x0 */
            ii(0x19_0455, 1); push(di);                                 /* push di */
            ii(0x19_0456, 1); push(si);                                 /* push si */
            ii(0x19_0457, 4); mov(es, memw[ds, 0x3f9c]);                /* mov es, [0x3f9c] */
            ii(0x19_045b, 3); mov(bx, memw[ss, bp + 0x6]);              /* mov bx, [bp+0x6] */
            ii(0x19_045e, 5); mov(al, memb[es, bx + 0x2]);              /* mov al, [es:bx+0x2] */
            ii(0x19_0463, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x19_0465, 2); mov(si, ax);                              /* mov si, ax */
        l_0x19_0467:
            ii(0x19_0467, 3); cmp(si, 0x1);                             /* cmp si, 0x1 */
            ii(0x19_046a, 2); if(jnz(0x19_046f, 0x3)) goto l_0x19_046f; /* jnz 0x46f */
            ii(0x19_046c, 3); jmp(0x19_04c6, 0x57); goto l_0x19_04c6;   /* jmp 0x4c6 */
        l_0x19_046f:
            ii(0x19_046f, 4); mov(es, memw[ds, 0x3f9e]);                /* mov es, [0x3f9e] */
            ii(0x19_0473, 4); mov(ax, memw[es, 0x122]);                 /* mov ax, [es:0x122] */
            ii(0x19_0477, 5); mov(dx, memw[es, 0x124]);                 /* mov dx, [es:0x124] */
            ii(0x19_047c, 2); mov(cx, si);                              /* mov cx, si */
            ii(0x19_047e, 3); shl(cx, 0x3);                             /* shl cx, 0x3 */
            ii(0x19_0481, 2); add(ax, cx);                              /* add ax, cx */
            ii(0x19_0483, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_0486, 3); mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x19_0489, 3); mov(ax, memw[ss, bp + 0x8]);              /* mov ax, [bp+0x8] */
            ii(0x19_048c, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x19_048f, 4); cmp(memw[es, bx + 0x6], ax);              /* cmp [es:bx+0x6], ax */
            ii(0x19_0493, 2); if(jz(0x19_0498, 0x3)) goto l_0x19_0498;  /* jz 0x498 */
            ii(0x19_0495, 3); jmp(0x19_04b8, 0x20); goto l_0x19_04b8;   /* jmp 0x4b8 */
        l_0x19_0498:
            ii(0x19_0498, 3); mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0x19_049b, 3); mov(dx, memw[ss, bp + 0xc]);              /* mov dx, [bp+0xc] */
            ii(0x19_049e, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x19_04a1, 4); cmp(memw[es, bx + 0x2], ax);              /* cmp [es:bx+0x2], ax */
            ii(0x19_04a5, 2); if(jz(0x19_04aa, 0x3)) goto l_0x19_04aa;  /* jz 0x4aa */
            ii(0x19_04a7, 3); jmp(0x19_04b8, 0xe); goto l_0x19_04b8;    /* jmp 0x4b8 */
        l_0x19_04aa:
            ii(0x19_04aa, 4); cmp(memw[es, bx + 0x4], dx);              /* cmp [es:bx+0x4], dx */
            ii(0x19_04ae, 2); if(jz(0x19_04b3, 0x3)) goto l_0x19_04b3;  /* jz 0x4b3 */
            ii(0x19_04b0, 3); jmp(0x19_04b8, 0x5); goto l_0x19_04b8;    /* jmp 0x4b8 */
        l_0x19_04b3:
            ii(0x19_04b3, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x19_04b5, 3); jmp(0x19_04cc, 0x14); goto l_0x19_04cc;   /* jmp 0x4cc */
        l_0x19_04b8:
            ii(0x19_04b8, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x19_04bb, 4); mov(al, memb[es, bx + 0x1]);              /* mov al, [es:bx+0x1] */
            ii(0x19_04bf, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x19_04c1, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x19_04c3, 3); jmp(0x19_0467, -0x5f); goto l_0x19_0467;  /* jmp 0x467 */
        l_0x19_04c6:
            ii(0x19_04c6, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_04c9, 3); jmp(0x19_04cc, 0); goto l_0x19_04cc;      /* jmp 0x4cc */
        l_0x19_04cc:
            ii(0x19_04cc, 1); pop(si);                                  /* pop si */
            ii(0x19_04cd, 1); pop(di);                                  /* pop di */
            ii(0x19_04ce, 1); leave();                                  /* leave */
            ii(0x19_04cf, 1); retf();                                   /* retf */
        }
    }
}
