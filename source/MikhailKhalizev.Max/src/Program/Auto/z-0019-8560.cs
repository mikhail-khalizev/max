using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fcfaaac4-3539-4f7f-8709-b9547b185d88")]
        public void Method_0019_8560()
        {
            ii(0x19_8560, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x19_8564, 1); pushw(di);                                /* push di */
            ii(0x19_8565, 1); pushw(si);                                /* push si */
            ii(0x19_8566, 1); pushw(ds);                                /* push ds */
            ii(0x19_8567, 3); pushw(0x1767);                            /* push 0x1767 */
            ii(0x19_856a, 3); callw(0x19_105e, -0x750f);                /* call 0x105e */
            ii(0x19_856d, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_8570, 4); mov(es, memw_a16[ds, 0x3fac]);            /* mov es, [0x3fac] */
            ii(0x19_8574, 5); mov(si, memw_a16[es, 0xa70]);             /* mov si, [es:0xa70] */
            ii(0x19_8579, 3); and(si, 0x3);                             /* and si, 0x3 */
            ii(0x19_857c, 3); mov(memw_a16[ss, bp - 0x2], si);          /* mov [bp-0x2], si */
        l_0x19_857f:
            ii(0x19_857f, 4); mov(es, memw_a16[ds, 0x3fae]);            /* mov es, [0x3fae] */
            ii(0x19_8583, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x19_8585, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x19_8588, 6); cmp(memw_a16[es, bx + 0xa52], 0);         /* cmp word [es:bx+0xa52], 0x0 */
            ii(0x19_858e, 2); if(jzw(0x19_8593, 0x3)) goto l_0x19_8593; /* jz 0x8593 */
            ii(0x19_8590, 3); jmpw(0x19_85a7, 0x14); goto l_0x19_85a7;  /* jmp 0x85a7 */
        l_0x19_8593:
            ii(0x19_8593, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x19_8595, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x19_8598, 5); mov(ax, memw_a16[es, bx + 0xa56]);        /* mov ax, [es:bx+0xa56] */
            ii(0x19_859d, 5); or(ax, memw_a16[es, bx + 0xa54]);         /* or ax, [es:bx+0xa54] */
            ii(0x19_85a2, 2); if(jnzw(0x19_85a7, 0x3)) goto l_0x19_85a7; /* jnz 0x85a7 */
            ii(0x19_85a4, 3); jmpw(0x19_85d8, 0x31); goto l_0x19_85d8;  /* jmp 0x85d8 */
        l_0x19_85a7:
            ii(0x19_85a7, 4); mov(es, memw_a16[ds, 0x3fae]);            /* mov es, [0x3fae] */
            ii(0x19_85ab, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x19_85ad, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x19_85b0, 5); pushw(memw_a16[es, bx + 0xa56]);          /* push word [es:bx+0xa56] */
            ii(0x19_85b5, 5); pushw(memw_a16[es, bx + 0xa54]);          /* push word [es:bx+0xa54] */
            ii(0x19_85ba, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x19_85bc, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x19_85bf, 5); pushw(memw_a16[es, bx + 0xa52]);          /* push word [es:bx+0xa52] */
            ii(0x19_85c4, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x19_85c6, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x19_85c9, 5); pushw(memw_a16[es, bx + 0xa50]);          /* push word [es:bx+0xa50] */
            ii(0x19_85ce, 1); pushw(ds);                                /* push ds */
            ii(0x19_85cf, 3); pushw(0x1775);                            /* push 0x1775 */
            ii(0x19_85d2, 3); callw(0x19_105e, -0x7577);                /* call 0x105e */
            ii(0x19_85d5, 3); add(sp, 0xc);                             /* add sp, 0xc */
        l_0x19_85d8:
            ii(0x19_85d8, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x19_85da, 2); inc(al);                                  /* inc al */
            ii(0x19_85dc, 3); and(ax, 0x3);                             /* and ax, 0x3 */
            ii(0x19_85df, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x19_85e1, 3); cmp(memw_a16[ss, bp - 0x2], si);          /* cmp [bp-0x2], si */
            ii(0x19_85e4, 2); if(jzw(0x19_85e9, 0x3)) goto l_0x19_85e9; /* jz 0x85e9 */
            ii(0x19_85e6, 3); jmpw(0x19_857f, -0x6a); goto l_0x19_857f; /* jmp 0x857f */
        l_0x19_85e9:
            ii(0x19_85e9, 1); pushw(ds);                                /* push ds */
            ii(0x19_85ea, 3); pushw(0x1782);                            /* push 0x1782 */
            ii(0x19_85ed, 3); callw(0x19_105e, -0x7592);                /* call 0x105e */
            ii(0x19_85f0, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_85f3, 1); popw(si);                                 /* pop si */
            ii(0x19_85f4, 1); popw(di);                                 /* pop di */
            ii(0x19_85f5, 1); leavew();                                 /* leave */
            ii(0x19_85f6, 1); retfw(); return;                          /* retf */
        }
    }
}
