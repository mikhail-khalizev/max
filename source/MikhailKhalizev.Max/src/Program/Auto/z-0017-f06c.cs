using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("568f9ea7-de59-4fcf-a21d-4ff37dc9cd9c")]
        public void Method_0017_f06c()
        {
            ii(0x17_f06c, 4); enterw(0x1c, 0);                          /* enter 0x1c, 0x0 */
            ii(0x17_f070, 1); pushw(di);                                /* push di */
            ii(0x17_f071, 1); pushw(si);                                /* push si */
            ii(0x17_f072, 1); pushw(ds);                                /* push ds */
            ii(0x17_f073, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_f076, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_f078, 1); nop();                                    /* nop */
            ii(0x17_f079, 1); pushw(cs);                                /* push cs */
            ii(0x17_f07a, 3); callw(0x17_f134, 0xb7);                   /* call 0xf134 */
            ii(0x17_f07d, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_f07f, 2); if(jzw(0x17_f0a4, 0x23)) goto l_0x17_f0a4; /* jz 0xf0a4 */
            ii(0x17_f081, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x17_f084, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x17_f087, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x17_f08a, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_f08c, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x17_f08f, 1); pushw(ss);                                /* push ss */
            ii(0x17_f090, 1); pushw(ax);                                /* push ax */
            ii(0x17_f091, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_f094, 2); pushw(0xc);                               /* push 0xc */
            ii(0x17_f096, 1); nop();                                    /* nop */
            ii(0x17_f097, 1); pushw(cs);                                /* push cs */
            ii(0x17_f098, 3); callw(0x17_eb98, -0x503);                 /* call 0xeb98 */
            ii(0x17_f09b, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x17_f09e, 3); mov(memw_a16[ss, bp + 0x6], ax);          /* mov [bp+0x6], ax */
            ii(0x17_f0a1, 2); jmpw(0x17_f0d5, 0x32); goto l_0x17_f0d5;  /* jmp 0xf0d5 */
        //    ii(0x17_f0a3, 1); nop();                                    /* nop */
        l_0x17_f0a4:
            ii(0x17_f0a4, 3); mov(ax, memw_a16[ds, 0x1412]);            /* mov ax, [0x1412] */
            ii(0x17_f0a7, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x17_f0aa, 5); mov(memw_a16[ss, bp - 0x1c], 0);          /* mov word [bp-0x1c], 0x0 */
            ii(0x17_f0af, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_f0b2, 2); and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x17_f0b4, 3); add(ax, memw_a16[ss, bp - 0x1c]);         /* add ax, [bp-0x1c] */
            ii(0x17_f0b7, 3); mov(dx, memw_a16[ss, bp - 0x1a]);         /* mov dx, [bp-0x1a] */
            ii(0x17_f0ba, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x17_f0bd, 3); mov(memw_a16[ss, bp - 0x16], dx);         /* mov [bp-0x16], dx */
            ii(0x17_f0c0, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x17_f0c3, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x17_f0c6, 3); mov(dx, memw_a16[ss, bp + 0xa]);          /* mov dx, [bp+0xa] */
            ii(0x17_f0c9, 2); mov(di, bx);                              /* mov di, bx */
            ii(0x17_f0cb, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_f0cd, 1); pushw(ds);                                /* push ds */
            ii(0x17_f0ce, 2); mov(ds, dx);                              /* mov ds, dx */
            ii(0x17_f0d0, 1); movsw_a16();                              /* movsw */
            ii(0x17_f0d1, 1); movsw_a16();                              /* movsw */
            ii(0x17_f0d2, 1); movsw_a16();                              /* movsw */
            ii(0x17_f0d3, 1); movsw_a16();                              /* movsw */
            ii(0x17_f0d4, 1); popw(ds);                                 /* pop ds */
        l_0x17_f0d5:
            ii(0x17_f0d5, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_f0d8, 1); popw(ds);                                 /* pop ds */
            ii(0x17_f0d9, 1); popw(si);                                 /* pop si */
            ii(0x17_f0da, 1); popw(di);                                 /* pop di */
            ii(0x17_f0db, 1); leavew();                                 /* leave */
            ii(0x17_f0dc, 1); retfw(); return;                          /* retf */
        }
    }
}
