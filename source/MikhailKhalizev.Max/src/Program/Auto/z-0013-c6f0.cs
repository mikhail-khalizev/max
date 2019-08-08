using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("39b8619d-dddb-4777-922a-86649d73b68e")]
        public void Method_0013_c6f0()
        {
            ii(0x13_c6f0, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x13_c6f4, 1); pushw(ds);                                /* push ds */
            ii(0x13_c6f5, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_c6f8, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_c6fa, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_c6fc, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x13_c6ff, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x13_c702, 2); jmpw(0x13_c707, 0x3); goto l_0x13_c707;   /* jmp 0xc707 */
        l_0x13_c704:
            ii(0x13_c704, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x13_c707:
            ii(0x13_c707, 5); cmp(memw_a16[ss, bp - 0x2], 0x400);       /* cmp word [bp-0x2], 0x400 */
            ii(0x13_c70c, 2); if(jaew(0x13_c760, 0x52)) goto l_0x13_c760; /* jae 0xc760 */
            ii(0x13_c70e, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x13_c711, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x13_c713, 4); mov(ax, memw_a16[ds, bx + 0xaca]);        /* mov ax, [bx+0xaca] */
            ii(0x13_c717, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_c71a, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x13_c71d, 2); if(jzw(0x13_c75e, 0x3f)) goto l_0x13_c75e; /* jz 0xc75e */
            ii(0x13_c71f, 5); mov(memw_a16[ss, bp - 0x8], 0);           /* mov word [bp-0x8], 0x0 */
            ii(0x13_c724, 2); jmpw(0x13_c729, 0x3); goto l_0x13_c729;   /* jmp 0xc729 */
        l_0x13_c726:
            ii(0x13_c726, 3); inc(memw_a16[ss, bp - 0x8]);              /* inc word [bp-0x8] */
        l_0x13_c729:
            ii(0x13_c729, 4); cmp(memw_a16[ss, bp - 0x8], 0x10);        /* cmp word [bp-0x8], 0x10 */
            ii(0x13_c72d, 2); if(jaew(0x13_c75e, 0x2f)) goto l_0x13_c75e; /* jae 0xc75e */
            ii(0x13_c72f, 3); mov(cl, memb_a16[ss, bp - 0x8]);          /* mov cl, [bp-0x8] */
            ii(0x13_c732, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_c735, 2); shr(ax, cl);                              /* shr ax, cl */
            ii(0x13_c737, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x13_c739, 2); if(jnzw(0x13_c75c, 0x21)) goto l_0x13_c75c; /* jnz 0xc75c */
            ii(0x13_c73b, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_c73e, 2); shl(ax, cl);                              /* shl ax, cl */
            ii(0x13_c740, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x13_c743, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x13_c746, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x13_c748, 4); or(memw_a16[ds, bx + 0xaca], ax);         /* or [bx+0xaca], ax */
            ii(0x13_c74c, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x13_c74f, 3); shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0x13_c752, 3); add(ax, memw_a16[ss, bp - 0x8]);          /* add ax, [bp-0x8] */
            ii(0x13_c755, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x13_c758, 1); popw(ds);                                 /* pop ds */
            ii(0x13_c759, 1); leavew();                                 /* leave */
            ii(0x13_c75a, 1); retfw(); return;                          /* retf */
        //  ii(0x13_c75b, 1); Недостижимый код.
        l_0x13_c75c:
            ii(0x13_c75c, 2); jmpw(0x13_c726, -0x38); goto l_0x13_c726; /* jmp 0xc726 */
        l_0x13_c75e:
            ii(0x13_c75e, 2); jmpw(0x13_c704, -0x5c); goto l_0x13_c704; /* jmp 0xc704 */
        l_0x13_c760:
            ii(0x13_c760, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x13_c763, 1); popw(ds);                                 /* pop ds */
            ii(0x13_c764, 1); leavew();                                 /* leave */
            ii(0x13_c765, 1); retfw(); return;                          /* retf */
        }
    }
}
