using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_3998-e3c6b8ff")]
        public void Method_0019_3998()
        {
            ii(0x19_3998, 1); pushw(bp);                                /* push bp */
            ii(0x19_3999, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_399b, 2); mov(cx, ds);                              /* mov cx, ds */
            ii(0x19_399d, 3); lds(bx, ss, bp + 0x6);                    /* lds bx, [bp+0x6] */
            ii(0x19_39a0, 2); mov(dx, bx);                              /* mov dx, bx */
            ii(0x19_39a2, 2); jmpw(0x19_39af, 0xb); goto l_0x19_39af;   /* jmp 0x39af */
        l_0x19_39a4:
            ii(0x19_39a4, 2); sub(al, 0x61);                            /* sub al, 0x61 */
            ii(0x19_39a6, 2); cmp(al, 0x1a);                            /* cmp al, 0x1a */
            ii(0x19_39a8, 2); if(jaew(0x19_39ae, 0x4)) goto l_0x19_39ae; /* jae 0x39ae */
            ii(0x19_39aa, 2); add(al, 0x41);                            /* add al, 0x41 */
            ii(0x19_39ac, 2); mov(memb_a16[ds, bx], al);                /* mov [bx], al */
        l_0x19_39ae:
            ii(0x19_39ae, 1); inc(bx);                                  /* inc bx */
        l_0x19_39af:
            ii(0x19_39af, 2); mov(al, memb_a16[ds, bx]);                /* mov al, [bx] */
            ii(0x19_39b1, 2); or(al, al);                               /* or al, al */
            ii(0x19_39b3, 2); if(jnzw(0x19_39a4, -0x11)) goto l_0x19_39a4; /* jnz 0x39a4 */
            ii(0x19_39b5, 1); xchg(dx, ax);                             /* xchg dx, ax */
            ii(0x19_39b6, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x19_39b8, 2); mov(ds, cx);                              /* mov ds, cx */
            ii(0x19_39ba, 1); popw(bp);                                 /* pop bp */
            ii(0x19_39bb, 1); retfw();                                  /* retf */
        }
    }
}
