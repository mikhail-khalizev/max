using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c57de83c-0c55-43d7-9b5b-187cc8979bde")]
        public void Method_0013_effa()
        {
            ii(0x13_effa, 4); enterw(0x1c, 0);                          /* enter 0x1c, 0x0 */
            ii(0x13_effe, 1); pushw(di);                                /* push di */
            ii(0x13_efff, 1); pushw(si);                                /* push si */
            ii(0x13_f000, 1); pushw(ds);                                /* push ds */
            ii(0x13_f001, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_f004, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_f006, 1); nop();                                    /* nop */
            ii(0x13_f007, 1); pushw(cs);                                /* push cs */
            ii(0x13_f008, 3); callw(0x13_f134, 0x129);                  /* call 0xf134 */
            ii(0x13_f00b, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_f00d, 2); if(jzw(0x13_f02e, 0x1f)) goto l_0x13_f02e; /* jz 0xf02e */
            ii(0x13_f00f, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x13_f012, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x13_f015, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x13_f018, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_f01a, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x13_f01d, 1); pushw(ss);                                /* push ss */
            ii(0x13_f01e, 1); pushw(ax);                                /* push ax */
            ii(0x13_f01f, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_f022, 2); pushw(0xb);                               /* push 0xb */
            ii(0x13_f024, 1); nop();                                    /* nop */
            ii(0x13_f025, 1); pushw(cs);                                /* push cs */
            ii(0x13_f026, 3); callw(0x13_eb98, -0x491);                 /* call 0xeb98 */
            ii(0x13_f029, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x13_f02c, 2); jmpw(0x13_f064, 0x36); goto l_0x13_f064;  /* jmp 0xf064 */
        l_0x13_f02e:
            ii(0x13_f02e, 3); mov(ax, memw_a16[ds, 0x1412]);            /* mov ax, [0x1412] */
            ii(0x13_f031, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x13_f034, 5); mov(memw_a16[ss, bp - 0x1c], 0);          /* mov word [bp-0x1c], 0x0 */
            ii(0x13_f039, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_f03c, 2); and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x13_f03e, 3); add(ax, memw_a16[ss, bp - 0x1c]);         /* add ax, [bp-0x1c] */
            ii(0x13_f041, 3); mov(dx, memw_a16[ss, bp - 0x1a]);         /* mov dx, [bp-0x1a] */
            ii(0x13_f044, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x13_f047, 3); mov(memw_a16[ss, bp - 0x16], dx);         /* mov [bp-0x16], dx */
            ii(0x13_f04a, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x13_f04d, 2); mov(di, bx);                              /* mov di, bx */
            ii(0x13_f04f, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x13_f051, 1); pushw(ds);                                /* push ds */
            ii(0x13_f052, 2); mov(ds, dx);                              /* mov ds, dx */
            ii(0x13_f054, 1); movsw_a16();                              /* movsw */
            ii(0x13_f055, 1); movsw_a16();                              /* movsw */
            ii(0x13_f056, 1); movsw_a16();                              /* movsw */
            ii(0x13_f057, 1); movsw_a16();                              /* movsw */
            ii(0x13_f058, 1); popw(ds);                                 /* pop ds */
            ii(0x13_f059, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x13_f05c, 5); cmp(memb_a16[es, bx + 0x5], 0x1);         /* cmp byte [es:bx+0x5], 0x1 */
            ii(0x13_f061, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x13_f063, 1); inc(ax);                                  /* inc ax */
        l_0x13_f064:
            ii(0x13_f064, 3); mov(memw_a16[ss, bp + 0x6], ax);          /* mov [bp+0x6], ax */
            ii(0x13_f067, 1); popw(ds);                                 /* pop ds */
            ii(0x13_f068, 1); popw(si);                                 /* pop si */
            ii(0x13_f069, 1); popw(di);                                 /* pop di */
            ii(0x13_f06a, 1); leavew();                                 /* leave */
            ii(0x13_f06b, 1); retfw(); return;                          /* retf */
        }
    }
}
