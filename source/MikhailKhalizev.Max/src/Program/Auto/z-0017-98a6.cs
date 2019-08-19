using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_98a6-111cea32")]
        public void Method_0017_98a6()
        {
            ii(0x17_98a6, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x17_98aa, 1); pushw(ds);                                /* push ds */
            ii(0x17_98ab, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_98ae, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_98b0, 5); mov(memw_a16[ss, bp - 0x2], 0x1);         /* mov word [bp-0x2], 0x1 */
            ii(0x17_98b5, 1); cld();                                    /* cld */
            ii(0x17_98b6, 3); mov(al, memb_a16[ss, bp + 0xa]);          /* mov al, [bp+0xa] */
            ii(0x17_98b9, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_98bb, 2); jmpw(0x17_98ea, 0x2d); goto l_0x17_98ea;  /* jmp 0x98ea */
        //  ii(0x17_98bd, 1); nop();                                    /* nop */
        l_0x17_98be:
            ii(0x17_98be, 2); jmpw(0x17_98fa, 0x3a); goto l_0x17_98fa;  /* jmp 0x98fa */
        l_0x17_98c0:
            ii(0x17_98c0, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_98c3, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_98c6, 1); pushw(cs);                                /* push cs */
            ii(0x17_98c7, 3); callw(0x17_b040, 0x1776);                 /* call 0xb040 */
            ii(0x17_98ca, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_98cd, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x17_98d2, 2); jmpw(0x17_98fa, 0x26); goto l_0x17_98fa;  /* jmp 0x98fa */
        l_0x17_98d4:
            ii(0x17_98d4, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_98d7, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_98da, 1); pushw(cs);                                /* push cs */
            ii(0x17_98db, 3); callw(0x17_b20c, 0x192e);                 /* call 0xb20c */
            ii(0x17_98de, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_98e1, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x17_98e6, 2); jmpw(0x17_98fa, 0x12); goto l_0x17_98fa;  /* jmp 0x98fa */
        //  ii(0x17_98e8, 2); jmpw(0x17_98fa, 0x10); goto l_0x17_98fa;  /* jmp 0x98fa */
        l_0x17_98ea:
            ii(0x17_98ea, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_98ec, 2); if(jlw(0x17_98fa, 0xc)) goto l_0x17_98fa; /* jl 0x98fa */
            ii(0x17_98ee, 1); dec(ax);                                  /* dec ax */
            ii(0x17_98ef, 2); if(jlew(0x17_98be, -0x33)) goto l_0x17_98be; /* jle 0x98be */
            ii(0x17_98f1, 1); dec(ax);                                  /* dec ax */
            ii(0x17_98f2, 1); dec(ax);                                  /* dec ax */
            ii(0x17_98f3, 2); if(jzw(0x17_98c0, -0x35)) goto l_0x17_98c0; /* jz 0x98c0 */
            ii(0x17_98f5, 1); dec(ax);                                  /* dec ax */
            ii(0x17_98f6, 2); if(jzw(0x17_98d4, -0x24)) goto l_0x17_98d4; /* jz 0x98d4 */
            ii(0x17_98f8, 2); jmpw(0x17_98fa, 0); goto l_0x17_98fa;     /* jmp 0x98fa */
        l_0x17_98fa:
            ii(0x17_98fa, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x17_98fd, 1); popw(ds);                                 /* pop ds */
            ii(0x17_98fe, 1); leavew();                                 /* leave */
            ii(0x17_98ff, 1); retfw(); return;                          /* retf */
        }
    }
}
