using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_9836-c04d5f07")]
        public void Method_0017_9836()
        {
            ii(0x17_9836, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x17_983a, 1); pushw(ds);                                /* push ds */
            ii(0x17_983b, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_983e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_9840, 5); mov(memw_a16[ss, bp - 0x2], 0x1);         /* mov word [bp-0x2], 0x1 */
            ii(0x17_9845, 1); cld();                                    /* cld */
            ii(0x17_9846, 3); mov(al, memb_a16[ss, bp + 0xa]);          /* mov al, [bp+0xa] */
            ii(0x17_9849, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_984b, 2); jmpw(0x17_988e, 0x41); goto l_0x17_988e;  /* jmp 0x988e */
        //  ii(0x17_984d, 1); Недостижимый код.
        l_0x17_984e:
            ii(0x17_984e, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_9851, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_9854, 1); pushw(cs);                                /* push cs */
            ii(0x17_9855, 3); callw(0x17_ac34, 0x13dc);                 /* call 0xac34 */
            ii(0x17_9858, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_985b, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x17_9860, 2); jmpw(0x17_989c, 0x3a); goto l_0x17_989c;  /* jmp 0x989c */
        l_0x17_9862:
            ii(0x17_9862, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_9865, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_9868, 1); pushw(cs);                                /* push cs */
            ii(0x17_9869, 3); callw(0x17_af46, 0x16da);                 /* call 0xaf46 */
            ii(0x17_986c, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_986f, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x17_9874, 2); jmpw(0x17_989c, 0x26); goto l_0x17_989c;  /* jmp 0x989c */
        l_0x17_9876:
            ii(0x17_9876, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_9879, 6); mov(memw_a16[es, bx + 0x14], 0);          /* mov word [es:bx+0x14], 0x0 */
            ii(0x17_987f, 6); mov(memw_a16[es, bx + 0x1c], 0x1000);     /* mov word [es:bx+0x1c], 0x1000 */
            ii(0x17_9885, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x17_988a, 2); jmpw(0x17_989c, 0x10); goto l_0x17_989c;  /* jmp 0x989c */
        //  ii(0x17_988c, 2); Недостижимый код.
        l_0x17_988e:
            ii(0x17_988e, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_9890, 2); if(jzw(0x17_984e, -0x44)) goto l_0x17_984e; /* jz 0x984e */
            ii(0x17_9892, 1); dec(ax);                                  /* dec ax */
            ii(0x17_9893, 2); if(jzw(0x17_9862, -0x33)) goto l_0x17_9862; /* jz 0x9862 */
            ii(0x17_9895, 3); sub(ax, 0x3);                             /* sub ax, 0x3 */
            ii(0x17_9898, 2); if(jzw(0x17_9876, -0x24)) goto l_0x17_9876; /* jz 0x9876 */
            ii(0x17_989a, 2); jmpw(0x17_989c, 0); goto l_0x17_989c;     /* jmp 0x989c */
        l_0x17_989c:
            ii(0x17_989c, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x17_989f, 1); popw(ds);                                 /* pop ds */
            ii(0x17_98a0, 1); leavew();                                 /* leave */
            ii(0x17_98a1, 1); retfw(); return;                          /* retf */
        }
    }
}
