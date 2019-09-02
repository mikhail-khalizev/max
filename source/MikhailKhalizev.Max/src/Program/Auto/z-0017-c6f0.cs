using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_c6f0-430cb4ac")]
        public void Method_0017_c6f0()
        {
            ii(0x17_c6f0, 4); enter(0xa, 0);                            /* enter 0xa, 0x0 */
            ii(0x17_c6f4, 1); push(ds);                                 /* push ds */
            ii(0x17_c6f5, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_c6f8, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_c6fa, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_c6fc, 3); mov(memw[ss, bp - 6], ax);                /* mov [bp-0x6], ax */
            ii(0x17_c6ff, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x17_c702, 2); jmp(0x17_c707, 3); goto l_0x17_c707;      /* jmp 0xc707 */
        l_0x17_c704:
            ii(0x17_c704, 3); inc(memw[ss, bp - 2]);                    /* inc word [bp-0x2] */
        l_0x17_c707:
            ii(0x17_c707, 5); cmp(memw[ss, bp - 2], 0x400);             /* cmp word [bp-0x2], 0x400 */
            ii(0x17_c70c, 2); if(jae(0x17_c760, 0x52)) goto l_0x17_c760; /* jae 0xc760 */
            ii(0x17_c70e, 3); mov(bx, memw[ss, bp - 2]);                /* mov bx, [bp-0x2] */
            ii(0x17_c711, 2); shl(bx, 1);                               /* shl bx, 1 */
            ii(0x17_c713, 4); mov(ax, memw[ds, bx + 0xaca]);            /* mov ax, [bx+0xaca] */
            ii(0x17_c717, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x17_c71a, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_c71d, 2); if(jz(0x17_c75e, 0x3f)) goto l_0x17_c75e; /* jz 0xc75e */
            ii(0x17_c71f, 5); mov(memw[ss, bp - 8], 0);                 /* mov word [bp-0x8], 0x0 */
            ii(0x17_c724, 2); jmp(0x17_c729, 3); goto l_0x17_c729;      /* jmp 0xc729 */
        l_0x17_c726:
            ii(0x17_c726, 3); inc(memw[ss, bp - 8]);                    /* inc word [bp-0x8] */
        l_0x17_c729:
            ii(0x17_c729, 4); cmp(memw[ss, bp - 8], 0x10);              /* cmp word [bp-0x8], 0x10 */
            ii(0x17_c72d, 2); if(jae(0x17_c75e, 0x2f)) goto l_0x17_c75e; /* jae 0xc75e */
            ii(0x17_c72f, 3); mov(cl, memb[ss, bp - 8]);                /* mov cl, [bp-0x8] */
            ii(0x17_c732, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x17_c735, 2); shr(ax, cl);                              /* shr ax, cl */
            ii(0x17_c737, 2); test(al, 1);                              /* test al, 0x1 */
            ii(0x17_c739, 2); if(jnz(0x17_c75c, 0x21)) goto l_0x17_c75c; /* jnz 0xc75c */
            ii(0x17_c73b, 3); mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x17_c73e, 2); shl(ax, cl);                              /* shl ax, cl */
            ii(0x17_c740, 3); mov(memw[ss, bp - 6], ax);                /* mov [bp-0x6], ax */
            ii(0x17_c743, 3); mov(bx, memw[ss, bp - 2]);                /* mov bx, [bp-0x2] */
            ii(0x17_c746, 2); shl(bx, 1);                               /* shl bx, 1 */
            ii(0x17_c748, 4); or(memw[ds, bx + 0xaca], ax);             /* or [bx+0xaca], ax */
            ii(0x17_c74c, 3); mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x17_c74f, 3); shl(ax, 4);                               /* shl ax, 0x4 */
            ii(0x17_c752, 3); add(ax, memw[ss, bp - 8]);                /* add ax, [bp-0x8] */
            ii(0x17_c755, 3); mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x17_c758, 1); pop(ds);                                  /* pop ds */
            ii(0x17_c759, 1); leave();                                  /* leave */
            ii(0x17_c75a, 1); retf(); return;                           /* retf */
        //  ii(0x17_c75b, 1); Недостижимый код.
        l_0x17_c75c:
            ii(0x17_c75c, 2); jmp(0x17_c726, -0x38); goto l_0x17_c726;  /* jmp 0xc726 */
        l_0x17_c75e:
            ii(0x17_c75e, 2); jmp(0x17_c704, -0x5c); goto l_0x17_c704;  /* jmp 0xc704 */
        l_0x17_c760:
            ii(0x17_c760, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x17_c763, 1); pop(ds);                                  /* pop ds */
            ii(0x17_c764, 1); leave();                                  /* leave */
            ii(0x17_c765, 1); retf();                                   /* retf */
        }
    }
}
