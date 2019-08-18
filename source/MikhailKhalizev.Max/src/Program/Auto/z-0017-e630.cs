using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_e630-221c7e44")]
        public void Method_0017_e630()
        {
            ii(0x17_e630, 4); enterw(0x18, 0);                          /* enter 0x18, 0x0 */
            ii(0x17_e634, 1); pushw(ds);                                /* push ds */
            ii(0x17_e635, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_e638, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_e63a, 1); nop();                                    /* nop */
            ii(0x17_e63b, 1); pushw(cs);                                /* push cs */
            ii(0x17_e63c, 3); callw(0x17_f134, 0xaf5);                  /* call 0xf134 */
            ii(0x17_e63f, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_e641, 2); if(jzw(0x17_e664, 0x21)) goto l_0x17_e664; /* jz 0xe664 */
            ii(0x17_e643, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_e645, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_e647, 3); lea(ax, bp - 0x18);                       /* lea ax, [bp-0x18] */
            ii(0x17_e64a, 1); pushw(ss);                                /* push ss */
            ii(0x17_e64b, 1); pushw(ax);                                /* push ax */
            ii(0x17_e64c, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_e64f, 2); pushw(0xa);                               /* push 0xa */
            ii(0x17_e651, 1); nop();                                    /* nop */
            ii(0x17_e652, 1); pushw(cs);                                /* push cs */
            ii(0x17_e653, 3); callw(0x17_eb98, 0x542);                  /* call 0xeb98 */
            ii(0x17_e656, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x17_e659, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_e65b, 2); if(jnzw(0x17_e687, 0x2a)) goto l_0x17_e687; /* jnz 0xe687 */
        l_0x17_e65d:
            ii(0x17_e65d, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_e65f, 1); cwd();                                    /* cwd */
            ii(0x17_e660, 1); popw(ds);                                 /* pop ds */
            ii(0x17_e661, 1); leavew();                                 /* leave */
            ii(0x17_e662, 1); retfw(); return;                          /* retf */
        //  ii(0x17_e663, 1); Недостижимый (и не декодированный) код.
        l_0x17_e664:
            ii(0x17_e664, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x17_e667, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x17_e66a, 5); mov(memw_a16[ss, bp - 0xa], 0x500);       /* mov word [bp-0xa], 0x500 */
            ii(0x17_e66f, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_e671, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_e673, 3); lea(ax, bp - 0x18);                       /* lea ax, [bp-0x18] */
            ii(0x17_e676, 1); pushw(ss);                                /* push ss */
            ii(0x17_e677, 1); pushw(ax);                                /* push ax */
            ii(0x17_e678, 3); pushw(0xff00);                            /* push 0xff00 */
            ii(0x17_e67b, 1); nop();                                    /* nop */
            ii(0x17_e67c, 1); pushw(cs);                                /* push cs */
            ii(0x17_e67d, 3); callw(0x17_eb40, 0x4c0);                  /* call 0xeb40 */
            ii(0x17_e680, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_e683, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_e685, 2); if(jzw(0x17_e65d, -0x2a)) goto l_0x17_e65d; /* jz 0xe65d */
        l_0x17_e687:
            ii(0x17_e687, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x17_e68a, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x17_e68d, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_e68f, 2); if(jzw(0x17_e697, 0x6)) goto l_0x17_e697; /* jz 0xe697 */
            ii(0x17_e691, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_e694, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
        l_0x17_e697:
            ii(0x17_e697, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x17_e69a, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x17_e69d, 1); popw(ds);                                 /* pop ds */
            ii(0x17_e69e, 1); leavew();                                 /* leave */
            ii(0x17_e69f, 1); retfw(); return;                          /* retf */
        }
    }
}
