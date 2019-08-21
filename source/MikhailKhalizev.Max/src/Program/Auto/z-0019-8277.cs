using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_8277-a24eb9cc")]
        public void Method_0019_8277()
        {
            ii(0x19_8277, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x19_827b, 1); pushw(di);                                /* push di */
            ii(0x19_827c, 1); pushw(si);                                /* push si */
            ii(0x19_827d, 1); nop();                                    /* nop */
            ii(0x19_827e, 1); pushw(cs);                                /* push cs */
            ii(0x19_827f, 3); callw(0x19_821a, -0x68);                  /* call 0x821a */
            ii(0x19_8282, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_8285, 2); if(jzw(0x19_828a, 0x3)) goto l_0x19_828a; /* jz 0x828a */
            ii(0x19_8287, 3); jmpw(0x19_82f2, 0x68); goto l_0x19_82f2;  /* jmp 0x82f2 */
        l_0x19_828a:
            ii(0x19_828a, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_828d, 5); cmp(memw_a16[es, bx + 0x2c], 0x3);        /* cmp word [es:bx+0x2c], 0x3 */
            ii(0x19_8292, 2); if(jzw(0x19_8297, 0x3)) goto l_0x19_8297; /* jz 0x8297 */
            ii(0x19_8294, 3); jmpw(0x19_829d, 0x6); goto l_0x19_829d;   /* jmp 0x829d */
        l_0x19_8297:
            ii(0x19_8297, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_829a, 3); jmpw(0x19_8305, 0x68); goto l_0x19_8305;  /* jmp 0x8305 */
        l_0x19_829d:
            ii(0x19_829d, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_82a0, 5); cmp(memw_a16[es, bx + 0x2c], 0x1);        /* cmp word [es:bx+0x2c], 0x1 */
            ii(0x19_82a5, 2); if(jzw(0x19_82aa, 0x3)) goto l_0x19_82aa; /* jz 0x82aa */
            ii(0x19_82a7, 3); jmpw(0x19_82ec, 0x42); goto l_0x19_82ec;  /* jmp 0x82ec */
        l_0x19_82aa:
            ii(0x19_82aa, 2); pushw(0x2);                               /* push 0x2 */
            ii(0x19_82ac, 1); pushw(ds);                                /* push ds */
            ii(0x19_82ad, 3); pushw(0x48a4);                            /* push 0x48a4 */
            ii(0x19_82b0, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_82b3, 4); pushw(memw_a16[es, bx + 0x36]);           /* push word [es:bx+0x36] */
            ii(0x19_82b7, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_82ba, 4); mov(ax, memw_a16[es, bx + 0x32]);         /* mov ax, [es:bx+0x32] */
            ii(0x19_82be, 4); mov(dx, memw_a16[es, bx + 0x34]);         /* mov dx, [es:bx+0x34] */
            ii(0x19_82c2, 3); sub(ax, 0x2);                             /* sub ax, 0x2 */
            ii(0x19_82c5, 3); sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x19_82c8, 1); pushw(dx);                                /* push dx */
            ii(0x19_82c9, 1); pushw(ax);                                /* push ax */
            ii(0x19_82ca, 5); callw_far_abs(0x80, 0x1534);              /* call word 0x80:0x1534 */
            ii(0x19_82cf, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x19_82d2, 6); cmp(memw_a16[ds, 0x48a4], 0x1cd);         /* cmp word [0x48a4], 0x1cd */
            ii(0x19_82d8, 2); if(jzw(0x19_82dd, 0x3)) goto l_0x19_82dd; /* jz 0x82dd */
            ii(0x19_82da, 3); jmpw(0x19_82e3, 0x6); goto l_0x19_82e3;   /* jmp 0x82e3 */
        l_0x19_82dd:
            ii(0x19_82dd, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_82e0, 3); jmpw(0x19_82e6, 0x3); goto l_0x19_82e6;   /* jmp 0x82e6 */
        l_0x19_82e3:
            ii(0x19_82e3, 3); mov(ax, 0);                               /* mov ax, 0x0 */
        l_0x19_82e6:
            ii(0x19_82e6, 3); jmpw(0x19_8305, 0x1c); goto l_0x19_8305;  /* jmp 0x8305 */
        //  ii(0x19_82e9, 3); jmpw(0x19_82f2, 0x6); goto l_0x19_82f2;   /* jmp 0x82f2 */
        l_0x19_82ec:
            ii(0x19_82ec, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_82ef, 3); jmpw(0x19_8305, 0x13); goto l_0x19_8305;  /* jmp 0x8305 */
        l_0x19_82f2:
            ii(0x19_82f2, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_82f5, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_82f8, 4); callw_a16_far_ind(ds, 0x16d4);            /* call far word [0x16d4] */
            ii(0x19_82fc, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_82ff, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_8302, 3); jmpw(0x19_8305, 0); goto l_0x19_8305;     /* jmp 0x8305 */
        l_0x19_8305:
            ii(0x19_8305, 1); popw(si);                                 /* pop si */
            ii(0x19_8306, 1); popw(di);                                 /* pop di */
            ii(0x19_8307, 1); leavew();                                 /* leave */
            ii(0x19_8308, 1); retfw(); return;                          /* retf */
        }
    }
}
