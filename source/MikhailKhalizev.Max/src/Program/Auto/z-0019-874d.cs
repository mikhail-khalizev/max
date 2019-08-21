using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_874d-5b5fac7f")]
        public void Method_0019_874d()
        {
            ii(0x19_874d, 4); enterw(0x6, 0);                           /* enter 0x6, 0x0 */
            ii(0x19_8751, 1); pushw(di);                                /* push di */
            ii(0x19_8752, 1); pushw(si);                                /* push si */
            ii(0x19_8753, 1); pushw(ds);                                /* push ds */
            ii(0x19_8754, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_8757, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_8759, 4); mov(es, memw_a16[ds, 0x3fac]);            /* mov es, [0x3fac] */
            ii(0x19_875d, 6); or(memw_a16[es, 0xa70], 0x4);             /* or word [es:0xa70], 0x4 */
            ii(0x19_8763, 5); cmp(memb_a16[ds, 0x17eb], 0);             /* cmp byte [0x17eb], 0x0 */
            ii(0x19_8768, 2); if(jzw(0x19_876d, 0x3)) goto l_0x19_876d; /* jz 0x876d */
            ii(0x19_876a, 3); jmpw(0x19_87bb, 0x4e); goto l_0x19_87bb;  /* jmp 0x87bb */
        l_0x19_876d:
            ii(0x19_876d, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_8770, 5); cmp(memw_a16[es, bx + 0x2c], 0xd);        /* cmp word [es:bx+0x2c], 0xd */
            ii(0x19_8775, 2); if(jzw(0x19_877a, 0x3)) goto l_0x19_877a; /* jz 0x877a */
            ii(0x19_8777, 3); jmpw(0x19_87bb, 0x41); goto l_0x19_87bb;  /* jmp 0x87bb */
        l_0x19_877a:
            ii(0x19_877a, 4); inc(memb_a16[ds, 0x17eb]);                /* inc byte [0x17eb] */
            ii(0x19_877e, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_8781, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_8784, 1); nop();                                    /* nop */
            ii(0x19_8785, 1); pushw(cs);                                /* push cs */
            ii(0x19_8786, 3); callw(0x19_80de, -0x6ab);                 /* call 0x80de */
            ii(0x19_8789, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_878c, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x19_878f, 4); dec(memb_a16[ds, 0x17eb]);                /* dec byte [0x17eb] */
            ii(0x19_8793, 4); cmp(memw_a16[ss, bp - 0x6], 0);           /* cmp word [bp-0x6], 0x0 */
            ii(0x19_8797, 2); if(jnzw(0x19_879c, 0x3)) goto l_0x19_879c; /* jnz 0x879c */
            ii(0x19_8799, 3); jmpw(0x19_87bb, 0x1f); goto l_0x19_87bb;  /* jmp 0x87bb */
        l_0x19_879c:
            ii(0x19_879c, 4); mov(es, memw_a16[ds, 0x3fb0]);            /* mov es, [0x3fb0] */
            ii(0x19_87a0, 6); cmp(memb_a16[es, 0xd84], 0);              /* cmp byte [es:0xd84], 0x0 */
            ii(0x19_87a6, 2); if(jnzw(0x19_87ab, 0x3)) goto l_0x19_87ab; /* jnz 0x87ab */
            ii(0x19_87a8, 3); jmpw(0x19_87b5, 0xa); goto l_0x19_87b5;   /* jmp 0x87b5 */
        l_0x19_87ab:
            ii(0x19_87ab, 4); mov(es, memw_a16[ds, 0x3fac]);            /* mov es, [0x3fac] */
            ii(0x19_87af, 6); and(memw_a16[es, 0xa70], 0x3);            /* and word [es:0xa70], 0x3 */
        l_0x19_87b5:
            ii(0x19_87b5, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_87b8, 3); jmpw(0x19_88c7, 0x10c); goto l_0x19_88c7; /* jmp 0x88c7 */
        l_0x19_87bb:
            ii(0x19_87bb, 5); cmp(memb_a16[ds, 0x17eb], 0);             /* cmp byte [0x17eb], 0x0 */
            ii(0x19_87c0, 2); if(jzw(0x19_87c5, 0x3)) goto l_0x19_87c5; /* jz 0x87c5 */
            ii(0x19_87c2, 3); jmpw(0x19_8806, 0x41); goto l_0x19_8806;  /* jmp 0x8806 */
        l_0x19_87c5:
            ii(0x19_87c5, 4); inc(memb_a16[ds, 0x17eb]);                /* inc byte [0x17eb] */
            ii(0x19_87c9, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_87cc, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_87cf, 1); nop();                                    /* nop */
            ii(0x19_87d0, 1); pushw(cs);                                /* push cs */
            ii(0x19_87d1, 3); callw(0x19_8277, -0x55d);                 /* call 0x8277 */
            ii(0x19_87d4, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_87d7, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x19_87da, 4); dec(memb_a16[ds, 0x17eb]);                /* dec byte [0x17eb] */
            ii(0x19_87de, 4); cmp(memw_a16[ss, bp - 0x6], 0);           /* cmp word [bp-0x6], 0x0 */
            ii(0x19_87e2, 2); if(jnzw(0x19_87e7, 0x3)) goto l_0x19_87e7; /* jnz 0x87e7 */
            ii(0x19_87e4, 3); jmpw(0x19_8806, 0x1f); goto l_0x19_8806;  /* jmp 0x8806 */
        l_0x19_87e7:
            ii(0x19_87e7, 4); mov(es, memw_a16[ds, 0x3fb0]);            /* mov es, [0x3fb0] */
            ii(0x19_87eb, 6); cmp(memb_a16[es, 0xd84], 0);              /* cmp byte [es:0xd84], 0x0 */
            ii(0x19_87f1, 2); if(jnzw(0x19_87f6, 0x3)) goto l_0x19_87f6; /* jnz 0x87f6 */
            ii(0x19_87f3, 3); jmpw(0x19_8800, 0xa); goto l_0x19_8800;   /* jmp 0x8800 */
        l_0x19_87f6:
            ii(0x19_87f6, 4); mov(es, memw_a16[ds, 0x3fac]);            /* mov es, [0x3fac] */
            ii(0x19_87fa, 6); and(memw_a16[es, 0xa70], 0x3);            /* and word [es:0xa70], 0x3 */
        l_0x19_8800:
            ii(0x19_8800, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_8803, 3); jmpw(0x19_88c7, 0xc1); goto l_0x19_88c7;  /* jmp 0x88c7 */
        l_0x19_8806:
            ii(0x19_8806, 5); cmp(memb_a16[ds, 0x17eb], 0);             /* cmp byte [0x17eb], 0x0 */
            ii(0x19_880b, 2); if(jnzw(0x19_8810, 0x3)) goto l_0x19_8810; /* jnz 0x8810 */
            ii(0x19_880d, 3); jmpw(0x19_8813, 0x3); goto l_0x19_8813;   /* jmp 0x8813 */
        l_0x19_8810:
            ii(0x19_8810, 3); jmpw(0x19_88bc, 0xa9); goto l_0x19_88bc;  /* jmp 0x88bc */
        l_0x19_8813:
            ii(0x19_8813, 4); inc(memb_a16[ds, 0x17eb]);                /* inc byte [0x17eb] */
            ii(0x19_8817, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_881a, 5); cmp(memw_a16[es, bx + 0x2c], 0xe);        /* cmp word [es:bx+0x2c], 0xe */
            ii(0x19_881f, 2); if(jgw(0x19_8824, 0x3)) goto l_0x19_8824; /* jg 0x8824 */
            ii(0x19_8821, 3); jmpw(0x19_882f, 0xb); goto l_0x19_882f;   /* jmp 0x882f */
        l_0x19_8824:
            ii(0x19_8824, 5); mov(memw_a16[ss, bp - 0x4], 0x17c2);      /* mov word [bp-0x4], 0x17c2 */
            ii(0x19_8829, 3); mov(memw_a16[ss, bp - 0x2], ds);          /* mov [bp-0x2], ds */
            ii(0x19_882c, 3); jmpw(0x19_8847, 0x18); goto l_0x19_8847;  /* jmp 0x8847 */
        l_0x19_882f:
            ii(0x19_882f, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_8832, 4); mov(bx, memw_a16[es, bx + 0x2c]);         /* mov bx, [es:bx+0x2c] */
            ii(0x19_8836, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x19_8839, 4); mov(ax, memw_a16[ds, bx + 0x166c]);       /* mov ax, [bx+0x166c] */
            ii(0x19_883d, 4); mov(dx, memw_a16[ds, bx + 0x166e]);       /* mov dx, [bx+0x166e] */
            ii(0x19_8841, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_8844, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
        l_0x19_8847:
            ii(0x19_8847, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_884a, 4); pushw(memw_a16[es, bx + 0x34]);           /* push word [es:bx+0x34] */
            ii(0x19_884e, 4); pushw(memw_a16[es, bx + 0x32]);           /* push word [es:bx+0x32] */
            ii(0x19_8852, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_8855, 4); pushw(memw_a16[es, bx + 0x36]);           /* push word [es:bx+0x36] */
            ii(0x19_8859, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x19_885c, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x19_885f, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_8862, 4); pushw(memw_a16[es, bx + 0x2c]);           /* push word [es:bx+0x2c] */
            ii(0x19_8866, 1); pushw(ds);                                /* push ds */
            ii(0x19_8867, 3); pushw(0x17ca);                            /* push 0x17ca */
            ii(0x19_886a, 3); pushw(0x7d1);                             /* push 0x7d1 */
            ii(0x19_886d, 3); callw(0x19_104e, -0x7822);                /* call 0x104e */
            ii(0x19_8870, 3); add(sp, 0x12);                            /* add sp, 0x12 */
            ii(0x19_8873, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_8876, 5); cmp(memw_a16[es, bx + 0x2c], 0xc);        /* cmp word [es:bx+0x2c], 0xc */
            ii(0x19_887b, 2); if(jzw(0x19_8880, 0x3)) goto l_0x19_8880; /* jz 0x8880 */
            ii(0x19_887d, 3); jmpw(0x19_88a7, 0x27); goto l_0x19_88a7;  /* jmp 0x88a7 */
        l_0x19_8880:
            ii(0x19_8880, 4); mov(es, memw_a16[ds, 0x3fb2]);            /* mov es, [0x3fb2] */
            ii(0x19_8884, 4); mov(ax, memw_a16[es, 0xa4e]);             /* mov ax, [es:0xa4e] */
            ii(0x19_8888, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_888b, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x19_888f, 4); mov(es, memw_a16[ds, 0x3fb4]);            /* mov es, [0x3fb4] */
            ii(0x19_8893, 4); mov(ax, memw_a16[es, 0xa4a]);             /* mov ax, [es:0xa4a] */
            ii(0x19_8897, 5); mov(dx, memw_a16[es, 0xa4c]);             /* mov dx, [es:0xa4c] */
            ii(0x19_889c, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_889f, 4); mov(memw_a16[es, bx + 0x18], ax);         /* mov [es:bx+0x18], ax */
            ii(0x19_88a3, 4); mov(memw_a16[es, bx + 0x1a], dx);         /* mov [es:bx+0x1a], dx */
        l_0x19_88a7:
            ii(0x19_88a7, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x19_88a9, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_88ac, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_88af, 1); nop();                                    /* nop */
            ii(0x19_88b0, 1); pushw(cs);                                /* push cs */
            ii(0x19_88b1, 3); callw(0x19_85f7, -0x2bd);                 /* call 0x85f7 */
            ii(0x19_88b4, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_88b7, 5); mov(memb_a16[ds, 0x17eb], 0);             /* mov byte [0x17eb], 0x0 */
        l_0x19_88bc:
            ii(0x19_88bc, 3); pushw(0x7d1);                             /* push 0x7d1 */
            ii(0x19_88bf, 5); callw_far_abs(0x80, 0x349f);              /* call word 0x80:0x349f */
            ii(0x19_88c4, 3); add(sp, 0x2);                             /* add sp, 0x2 */
        l_0x19_88c7:
            ii(0x19_88c7, 1); popw(ds);                                 /* pop ds */
            ii(0x19_88c8, 1); popw(si);                                 /* pop si */
            ii(0x19_88c9, 1); popw(di);                                 /* pop di */
            ii(0x19_88ca, 1); leavew();                                 /* leave */
            ii(0x19_88cb, 1); retfw(); return;                          /* retf */
        }
    }
}
