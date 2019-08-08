using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2073b6f1-dcc9-4257-a9a9-b279e406d16f")]
        public void Method_0015_0451()
        {
            ii(0x15_0451, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x15_0455, 1); pushw(di);                                /* push di */
            ii(0x15_0456, 1); pushw(si);                                /* push si */
            ii(0x15_0457, 4); mov(es, memw_a16[ds, 0x3f9c]);            /* mov es, [0x3f9c] */
            ii(0x15_045b, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x15_045e, 5); mov(al, memb_a16[es, bx + 0x2]);          /* mov al, [es:bx+0x2] */
            ii(0x15_0463, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_0465, 2); mov(si, ax);                              /* mov si, ax */
        l_0x15_0467:
            ii(0x15_0467, 3); cmp(si, 0x1);                             /* cmp si, 0x1 */
            ii(0x15_046a, 2); if(jnzw(0x15_046f, 0x3)) goto l_0x15_046f; /* jnz 0x46f */
            ii(0x15_046c, 3); jmpw(0x15_04c6, 0x57); goto l_0x15_04c6;  /* jmp 0x4c6 */
        l_0x15_046f:
            ii(0x15_046f, 4); mov(es, memw_a16[ds, 0x3f9e]);            /* mov es, [0x3f9e] */
            ii(0x15_0473, 4); mov(ax, memw_a16[es, 0x122]);             /* mov ax, [es:0x122] */
            ii(0x15_0477, 5); mov(dx, memw_a16[es, 0x124]);             /* mov dx, [es:0x124] */
            ii(0x15_047c, 2); mov(cx, si);                              /* mov cx, si */
            ii(0x15_047e, 3); shl(cx, 0x3);                             /* shl cx, 0x3 */
            ii(0x15_0481, 2); add(ax, cx);                              /* add ax, cx */
            ii(0x15_0483, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_0486, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_0489, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x15_048c, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x15_048f, 4); cmp(memw_a16[es, bx + 0x6], ax);          /* cmp [es:bx+0x6], ax */
            ii(0x15_0493, 2); if(jzw(0x15_0498, 0x3)) goto l_0x15_0498; /* jz 0x498 */
            ii(0x15_0495, 3); jmpw(0x15_04b8, 0x20); goto l_0x15_04b8;  /* jmp 0x4b8 */
        l_0x15_0498:
            ii(0x15_0498, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x15_049b, 3); mov(dx, memw_a16[ss, bp + 0xc]);          /* mov dx, [bp+0xc] */
            ii(0x15_049e, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x15_04a1, 4); cmp(memw_a16[es, bx + 0x2], ax);          /* cmp [es:bx+0x2], ax */
            ii(0x15_04a5, 2); if(jzw(0x15_04aa, 0x3)) goto l_0x15_04aa; /* jz 0x4aa */
            ii(0x15_04a7, 3); jmpw(0x15_04b8, 0xe); goto l_0x15_04b8;   /* jmp 0x4b8 */
        l_0x15_04aa:
            ii(0x15_04aa, 4); cmp(memw_a16[es, bx + 0x4], dx);          /* cmp [es:bx+0x4], dx */
            ii(0x15_04ae, 2); if(jzw(0x15_04b3, 0x3)) goto l_0x15_04b3; /* jz 0x4b3 */
            ii(0x15_04b0, 3); jmpw(0x15_04b8, 0x5); goto l_0x15_04b8;   /* jmp 0x4b8 */
        l_0x15_04b3:
            ii(0x15_04b3, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x15_04b5, 3); jmpw(0x15_04cc, 0x14); goto l_0x15_04cc;  /* jmp 0x4cc */
        l_0x15_04b8:
            ii(0x15_04b8, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x15_04bb, 4); mov(al, memb_a16[es, bx + 0x1]);          /* mov al, [es:bx+0x1] */
            ii(0x15_04bf, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_04c1, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x15_04c3, 3); jmpw(0x15_0467, -0x5f); goto l_0x15_0467; /* jmp 0x467 */
        l_0x15_04c6:
            ii(0x15_04c6, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_04c9, 3); jmpw(0x15_04cc, 0); goto l_0x15_04cc;     /* jmp 0x4cc */
        l_0x15_04cc:
            ii(0x15_04cc, 1); popw(si);                                 /* pop si */
            ii(0x15_04cd, 1); popw(di);                                 /* pop di */
            ii(0x15_04ce, 1); leavew();                                 /* leave */
            ii(0x15_04cf, 1); retfw(); return;                          /* retf */
        }
    }
}
