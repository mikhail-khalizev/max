using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("05fbe7d4-a304-4b5e-96c5-800f53539266")]
        public void Method_0015_f57c()
        {
            ii(0x15_f57c, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x15_f580, 1); pushw(di);                                /* push di */
            ii(0x15_f581, 1); pushw(si);                                /* push si */
            ii(0x15_f582, 1); pushw(ds);                                /* push ds */
            ii(0x15_f583, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_f586, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_f588, 4); cmp(memw_a16[ss, bp + 0x6], 0);           /* cmp word [bp+0x6], 0x0 */
            ii(0x15_f58c, 2); if(jnzw(0x15_f591, 0x3)) goto l_0x15_f591; /* jnz 0xf591 */
            ii(0x15_f58e, 3); jmpw(0x15_f5be, 0x2d); goto l_0x15_f5be;  /* jmp 0xf5be */
        l_0x15_f591:
            ii(0x15_f591, 4); dec(memb_a16[ds, 0x2ea9]);                /* dec byte [0x2ea9] */
            ii(0x15_f595, 5); cmp(memb_a16[ds, 0x2ea9], 0);             /* cmp byte [0x2ea9], 0x0 */
            ii(0x15_f59a, 2); if(jzw(0x15_f59f, 0x3)) goto l_0x15_f59f; /* jz 0xf59f */
            ii(0x15_f59c, 3); jmpw(0x15_f5ac, 0xd); goto l_0x15_f5ac;   /* jmp 0xf5ac */
        l_0x15_f59f:
            ii(0x15_f59f, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_f5a1, 1); nop();                                    /* nop */
            ii(0x15_f5a2, 1); pushw(cs);                                /* push cs */
            ii(0x15_f5a3, 3); callw(0x15_f15e, -0x448);                 /* call 0xf15e */
            ii(0x15_f5a6, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_f5a9, 3); jmpw(0x15_f5bb, 0xf); goto l_0x15_f5bb;   /* jmp 0xf5bb */
        l_0x15_f5ac:
            ii(0x15_f5ac, 5); cmp(memb_a16[ds, 0x2ea9], 0);             /* cmp byte [0x2ea9], 0x0 */
            ii(0x15_f5b1, 2); if(jlw(0x15_f5b6, 0x3)) goto l_0x15_f5b6; /* jl 0xf5b6 */
            ii(0x15_f5b3, 3); jmpw(0x15_f5bb, 0x5); goto l_0x15_f5bb;   /* jmp 0xf5bb */
        l_0x15_f5b6:
            ii(0x15_f5b6, 5); mov(memb_a16[ds, 0x2ea9], 0);             /* mov byte [0x2ea9], 0x0 */
        l_0x15_f5bb:
            ii(0x15_f5bb, 3); jmpw(0x15_f5d6, 0x18); goto l_0x15_f5d6;  /* jmp 0xf5d6 */
        l_0x15_f5be:
            ii(0x15_f5be, 4); inc(memb_a16[ds, 0x2ea9]);                /* inc byte [0x2ea9] */
            ii(0x15_f5c2, 5); cmp(memb_a16[ds, 0x2ea9], 0x1);           /* cmp byte [0x2ea9], 0x1 */
            ii(0x15_f5c7, 2); if(jzw(0x15_f5cc, 0x3)) goto l_0x15_f5cc; /* jz 0xf5cc */
            ii(0x15_f5c9, 3); jmpw(0x15_f5d6, 0xa); goto l_0x15_f5d6;   /* jmp 0xf5d6 */
        l_0x15_f5cc:
            ii(0x15_f5cc, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_f5ce, 1); nop();                                    /* nop */
            ii(0x15_f5cf, 1); pushw(cs);                                /* push cs */
            ii(0x15_f5d0, 3); callw(0x15_f15e, -0x475);                 /* call 0xf15e */
            ii(0x15_f5d3, 3); add(sp, 0x2);                             /* add sp, 0x2 */
        l_0x15_f5d6:
            ii(0x15_f5d6, 3); mov(ax, 0x2e3c);                          /* mov ax, 0x2e3c */
            ii(0x15_f5d9, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x15_f5db, 3); jmpw(0x15_f5de, 0); goto l_0x15_f5de;     /* jmp 0xf5de */
        l_0x15_f5de:
            ii(0x15_f5de, 1); popw(ds);                                 /* pop ds */
            ii(0x15_f5df, 1); popw(si);                                 /* pop si */
            ii(0x15_f5e0, 1); popw(di);                                 /* pop di */
            ii(0x15_f5e1, 1); leavew();                                 /* leave */
            ii(0x15_f5e2, 1); retfw(); return;                          /* retf */
        }
    }
}
