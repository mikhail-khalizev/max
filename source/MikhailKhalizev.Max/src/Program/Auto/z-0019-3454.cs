using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_3454-b7da27f1")]
        public void Method_0019_3454()
        {
            ii(0x19_3454, 1); pushw(bp);                                /* push bp */
            ii(0x19_3455, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_3457, 3); sub(sp, 0x2);                             /* sub sp, 0x2 */
            ii(0x19_345a, 1); pushw(si);                                /* push si */
            ii(0x19_345b, 1); pushw(di);                                /* push di */
            ii(0x19_345c, 1); pushw(ds);                                /* push ds */
            ii(0x19_345d, 3); les(di, ss, bp + 0xa);                    /* les di, [bp+0xa] */
            ii(0x19_3460, 1); pushw(es);                                /* push es */
            ii(0x19_3461, 1); popw(ds);                                 /* pop ds */
            ii(0x19_3462, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_3464, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x19_3467, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x19_3469, 2); not(cx);                                  /* not cx */
            ii(0x19_346b, 1); dec(cx);                                  /* dec cx */
            ii(0x19_346c, 2); if(jcxzw(0x19_34aa, 0x3c)) goto l_0x19_34aa; /* jcxz 0x34aa */
            ii(0x19_346e, 1); dec(cx);                                  /* dec cx */
            ii(0x19_346f, 3); mov(memw_a16[ss, bp - 0x2], cx);          /* mov [bp-0x2], cx */
            ii(0x19_3472, 3); les(di, ss, bp + 0x6);                    /* les di, [bp+0x6] */
            ii(0x19_3475, 2); mov(bx, di);                              /* mov bx, di */
            ii(0x19_3477, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_3479, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x19_347c, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x19_347e, 2); not(cx);                                  /* not cx */
            ii(0x19_3480, 1); dec(cx);                                  /* dec cx */
            ii(0x19_3481, 2); mov(dx, cx);                              /* mov dx, cx */
            ii(0x19_3483, 3); sub(dx, memw_a16[ss, bp - 0x2]);          /* sub dx, [bp-0x2] */
            ii(0x19_3486, 2); if(jbew(0x19_34b1, 0x29)) goto l_0x19_34b1; /* jbe 0x34b1 */
            ii(0x19_3488, 2); mov(di, bx);                              /* mov di, bx */
        l_0x19_348a:
            ii(0x19_348a, 3); mov(si, memw_a16[ss, bp + 0xa]);          /* mov si, [bp+0xa] */
            ii(0x19_348d, 1); lodsb_a16();                              /* lodsb */
            ii(0x19_348e, 2); mov(di, bx);                              /* mov di, bx */
            ii(0x19_3490, 2); mov(cx, dx);                              /* mov cx, dx */
            ii(0x19_3492, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x19_3494, 2); if(jnzw(0x19_34b1, 0x1b)) goto l_0x19_34b1; /* jnz 0x34b1 */
            ii(0x19_3496, 2); mov(dx, cx);                              /* mov dx, cx */
            ii(0x19_3498, 2); mov(bx, di);                              /* mov bx, di */
            ii(0x19_349a, 3); mov(cx, memw_a16[ss, bp - 0x2]);          /* mov cx, [bp-0x2] */
            ii(0x19_349d, 2); if(jcxzw(0x19_34a3, 0x4)) goto l_0x19_34a3; /* jcxz 0x34a3 */
            ii(0x19_349f, 2); repe_a16(() => cmpsb_a16());              /* repe cmpsb */
            ii(0x19_34a1, 2); if(jnzw(0x19_348a, -0x19)) goto l_0x19_348a; /* jnz 0x348a */
        l_0x19_34a3:
            ii(0x19_34a3, 3); lea(ax, bx - 0x1);                        /* lea ax, [bx-0x1] */
            ii(0x19_34a6, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x19_34a8, 2); jmpw(0x19_34b4, 0xa); goto l_0x19_34b4;   /* jmp 0x34b4 */
        l_0x19_34aa:
            ii(0x19_34aa, 3); les(ax, ss, bp + 0x6);                    /* les ax, [bp+0x6] */
            ii(0x19_34ad, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x19_34af, 2); jmpw(0x19_34b4, 0x3); goto l_0x19_34b4;   /* jmp 0x34b4 */
        l_0x19_34b1:
            ii(0x19_34b1, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_34b3, 1); cwd();                                    /* cwd */
        l_0x19_34b4:
            ii(0x19_34b4, 1); popw(ds);                                 /* pop ds */
            ii(0x19_34b5, 1); popw(di);                                 /* pop di */
            ii(0x19_34b6, 1); popw(si);                                 /* pop si */
            ii(0x19_34b7, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_34b9, 1); popw(bp);                                 /* pop bp */
            ii(0x19_34ba, 1); retfw(); return;                          /* retf */
        }
    }
}
