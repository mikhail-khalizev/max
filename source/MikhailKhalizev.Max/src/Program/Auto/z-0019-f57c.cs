using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_f57c-77037827")]
        public void Method_0019_f57c()
        {
            ii(0x19_f57c, 4); enter(0, 0);                              /* enter 0x0, 0x0 */
            ii(0x19_f580, 1); push(di);                                 /* push di */
            ii(0x19_f581, 1); push(si);                                 /* push si */
            ii(0x19_f582, 1); push(ds);                                 /* push ds */
            ii(0x19_f583, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_f586, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_f588, 4); cmp(memw[ss, bp + 6], 0);                 /* cmp word [bp+0x6], 0x0 */
            ii(0x19_f58c, 2); if(jnz(0x19_f591, 3)) goto l_0x19_f591;   /* jnz 0xf591 */
            ii(0x19_f58e, 3); jmp(0x19_f5be, 0x2d); goto l_0x19_f5be;   /* jmp 0xf5be */
        l_0x19_f591:
            ii(0x19_f591, 4); dec(memb[ds, 0x2ea9]);                    /* dec byte [0x2ea9] */
            ii(0x19_f595, 5); cmp(memb[ds, 0x2ea9], 0);                 /* cmp byte [0x2ea9], 0x0 */
            ii(0x19_f59a, 2); if(jz(0x19_f59f, 3)) goto l_0x19_f59f;    /* jz 0xf59f */
            ii(0x19_f59c, 3); jmp(0x19_f5ac, 0xd); goto l_0x19_f5ac;    /* jmp 0xf5ac */
        l_0x19_f59f:
            ii(0x19_f59f, 2); push(1);                                  /* push 0x1 */
            ii(0x19_f5a1, 1); nop();                                    /* nop */
            ii(0x19_f5a2, 1); push(cs);                                 /* push cs */
            ii(0x19_f5a3, 3); call(0x19_f15e, -0x448);                  /* call 0xf15e */
            ii(0x19_f5a6, 3); add(sp, 2);                               /* add sp, 0x2 */
            ii(0x19_f5a9, 3); jmp(0x19_f5bb, 0xf); goto l_0x19_f5bb;    /* jmp 0xf5bb */
        l_0x19_f5ac:
            ii(0x19_f5ac, 5); cmp(memb[ds, 0x2ea9], 0);                 /* cmp byte [0x2ea9], 0x0 */
            ii(0x19_f5b1, 2); if(jl(0x19_f5b6, 3)) goto l_0x19_f5b6;    /* jl 0xf5b6 */
            ii(0x19_f5b3, 3); jmp(0x19_f5bb, 5); goto l_0x19_f5bb;      /* jmp 0xf5bb */
        l_0x19_f5b6:
            ii(0x19_f5b6, 5); mov(memb[ds, 0x2ea9], 0);                 /* mov byte [0x2ea9], 0x0 */
        l_0x19_f5bb:
            ii(0x19_f5bb, 3); jmp(0x19_f5d6, 0x18); goto l_0x19_f5d6;   /* jmp 0xf5d6 */
        l_0x19_f5be:
            ii(0x19_f5be, 4); inc(memb[ds, 0x2ea9]);                    /* inc byte [0x2ea9] */
            ii(0x19_f5c2, 5); cmp(memb[ds, 0x2ea9], 1);                 /* cmp byte [0x2ea9], 0x1 */
            ii(0x19_f5c7, 2); if(jz(0x19_f5cc, 3)) goto l_0x19_f5cc;    /* jz 0xf5cc */
            ii(0x19_f5c9, 3); jmp(0x19_f5d6, 0xa); goto l_0x19_f5d6;    /* jmp 0xf5d6 */
        l_0x19_f5cc:
            ii(0x19_f5cc, 2); push(0);                                  /* push 0x0 */
            ii(0x19_f5ce, 1); nop();                                    /* nop */
            ii(0x19_f5cf, 1); push(cs);                                 /* push cs */
            ii(0x19_f5d0, 3); call(0x19_f15e, -0x475);                  /* call 0xf15e */
            ii(0x19_f5d3, 3); add(sp, 2);                               /* add sp, 0x2 */
        l_0x19_f5d6:
            ii(0x19_f5d6, 3); mov(ax, 0x2e3c);                          /* mov ax, 0x2e3c */
            ii(0x19_f5d9, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x19_f5db, 3); jmp(0x19_f5de, 0); goto l_0x19_f5de;      /* jmp 0xf5de */
        l_0x19_f5de:
            ii(0x19_f5de, 1); pop(ds);                                  /* pop ds */
            ii(0x19_f5df, 1); pop(si);                                  /* pop si */
            ii(0x19_f5e0, 1); pop(di);                                  /* pop di */
            ii(0x19_f5e1, 1); leave();                                  /* leave */
            ii(0x19_f5e2, 1); retf();                                   /* retf */
        }
    }
}
