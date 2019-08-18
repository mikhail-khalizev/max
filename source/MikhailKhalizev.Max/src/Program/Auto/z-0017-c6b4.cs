using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("466b9bd2-ac09-43aa-bf59-45adb026fb19")]
        public void Method_0017_c6b4()
        {
            ii(0x17_c6b4, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x17_c6b8, 1); pushw(ds);                                /* push ds */
            ii(0x17_c6b9, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_c6bc, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_c6be, 4); mov(memb_a16[ss, bp - 0x2], 0x1);         /* mov byte [bp-0x2], 0x1 */
            ii(0x17_c6c2, 2); jmpw(0x17_c6c7, 0x3); goto l_0x17_c6c7;   /* jmp 0xc6c7 */
        l_0x17_c6c4:
            ii(0x17_c6c4, 3); inc(memb_a16[ss, bp - 0x2]);              /* inc byte [bp-0x2] */
        l_0x17_c6c7:
            ii(0x17_c6c7, 4); cmp(memb_a16[ss, bp - 0x2], 0x64);        /* cmp byte [bp-0x2], 0x64 */
            ii(0x17_c6cb, 2); if(jaew(0x17_c6e8, 0x1b)) goto l_0x17_c6e8; /* jae 0xc6e8 */
            ii(0x17_c6cd, 3); mov(bl, memb_a16[ss, bp - 0x2]);          /* mov bl, [bp-0x2] */
            ii(0x17_c6d0, 2); sub(bh, bh);                              /* sub bh, bh */
            ii(0x17_c6d2, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x17_c6d5, 4); mov(ax, memw_a16[ds, bx + 0x2022]);       /* mov ax, [bx+0x2022] */
            ii(0x17_c6d9, 4); or(ax, memw_a16[ds, bx + 0x2020]);        /* or ax, [bx+0x2020] */
            ii(0x17_c6dd, 2); if(jnzw(0x17_c6e6, 0x7)) goto l_0x17_c6e6; /* jnz 0xc6e6 */
            ii(0x17_c6df, 3); mov(al, memb_a16[ss, bp - 0x2]);          /* mov al, [bp-0x2] */
            ii(0x17_c6e2, 1); popw(ds);                                 /* pop ds */
            ii(0x17_c6e3, 1); leavew();                                 /* leave */
            ii(0x17_c6e4, 1); retfw(); return;                          /* retf */
        //  ii(0x17_c6e5, 1); Недостижимый (и не декодированный) код.
        l_0x17_c6e6:
            ii(0x17_c6e6, 2); jmpw(0x17_c6c4, -0x24); goto l_0x17_c6c4; /* jmp 0xc6c4 */
        l_0x17_c6e8:
            ii(0x17_c6e8, 2); mov(al, 0xff);                            /* mov al, 0xff */
            ii(0x17_c6ea, 1); popw(ds);                                 /* pop ds */
            ii(0x17_c6eb, 1); leavew();                                 /* leave */
            ii(0x17_c6ec, 1); retfw(); return;                          /* retf */
        }
    }
}
