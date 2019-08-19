using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_96b4-1b4a009b")]
        public void Method_0017_96b4()
        {
            ii(0x17_96b4, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x17_96b8, 1); pushw(ds);                                /* push ds */
            ii(0x17_96b9, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_96bc, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_96be, 5); mov(memw_a16[ss, bp - 0x2], 0x1);         /* mov word [bp-0x2], 0x1 */
            ii(0x17_96c3, 1); cld();                                    /* cld */
            ii(0x17_96c4, 3); mov(al, memb_a16[ss, bp + 0xa]);          /* mov al, [bp+0xa] */
            ii(0x17_96c7, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_96c9, 2); jmpw(0x17_96f6, 0x2b); goto l_0x17_96f6;  /* jmp 0x96f6 */
        //  ii(0x17_96cb, 1); Недостижимый код.
        l_0x17_96cc:
            ii(0x17_96cc, 3); mov(ax, memw_a16[ds, 0x1f58]);            /* mov ax, [0x1f58] */
            ii(0x17_96cf, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_96d2, 4); mov(memw_a16[es, bx + 0x20], ax);         /* mov [es:bx+0x20], ax */
            ii(0x17_96d6, 3); mov(ax, memw_a16[ds, 0x1f5a]);            /* mov ax, [0x1f5a] */
            ii(0x17_96d9, 2); or(al, 0x4);                              /* or al, 0x4 */
            ii(0x17_96db, 4); mov(memw_a16[es, bx + 0x14], ax);         /* mov [es:bx+0x14], ax */
            ii(0x17_96df, 3); mov(ax, memw_a16[ds, 0x1f5c]);            /* mov ax, [0x1f5c] */
            ii(0x17_96e2, 4); mov(memw_a16[es, bx + 0x1c], ax);         /* mov [es:bx+0x1c], ax */
            ii(0x17_96e6, 3); mov(ax, memw_a16[ds, 0x1f5e]);            /* mov ax, [0x1f5e] */
            ii(0x17_96e9, 4); mov(memw_a16[es, bx + 0x18], ax);         /* mov [es:bx+0x18], ax */
            ii(0x17_96ed, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x17_96f2, 2); jmpw(0x17_96fc, 0x8); goto l_0x17_96fc;   /* jmp 0x96fc */
        //  ii(0x17_96f4, 2); Недостижимый код.
        l_0x17_96f6:
            ii(0x17_96f6, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_96f8, 2); if(jzw(0x17_96cc, -0x2e)) goto l_0x17_96cc; /* jz 0x96cc */
            ii(0x17_96fa, 2); jmpw(0x17_96fc, 0); goto l_0x17_96fc;     /* jmp 0x96fc */
        l_0x17_96fc:
            ii(0x17_96fc, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x17_96ff, 1); popw(ds);                                 /* pop ds */
            ii(0x17_9700, 1); leavew();                                 /* leave */
            ii(0x17_9701, 1); retfw(); return;                          /* retf */
        }
    }
}
