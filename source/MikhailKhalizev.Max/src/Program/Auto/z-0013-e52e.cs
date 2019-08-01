using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9c3bf6ba-5f74-4372-a323-7b81c23718e4")]
        public void Method_0013_e52e()
        {
            ii(0x13_e52e, 1); inc(cx);                                  /* inc cx */
            ii(0x13_e52f, 3); and(cl, 0xfe);                            /* and cl, 0xfe */
            ii(0x13_e532, 1); pushw(bx);                                /* push bx */
            ii(0x13_e533, 1); cld();                                    /* cld */
            ii(0x13_e534, 3); mov(si, memw_a16[ds, bx + 0x8]);          /* mov si, [bx+0x8] */
            ii(0x13_e537, 3); mov(bx, memw_a16[ds, bx + 0xa]);          /* mov bx, [bx+0xa] */
            ii(0x13_e53a, 2); xor(di, di);                              /* xor di, di */
            ii(0x13_e53c, 2); jmpw(0x13_e561, 0x23); goto l_0x13_e561;  /* jmp 0xe561 */
        l_0x13_e53e:
            ii(0x13_e53e, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x13_e540, 1); popw(bx);                                 /* pop bx */
            ii(0x13_e541, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x13_e543, 2); if(jnzw(0x13_e587, 0x42)) goto l_0x13_e587; /* jnz 0xe587 */
            ii(0x13_e545, 1); pushw(bx);                                /* push bx */
            ii(0x13_e546, 3); mov(si, memw_a16[ds, bx + 0x6]);          /* mov si, [bx+0x6] */
            ii(0x13_e549, 3); mov(bx, memw_a16[ds, bx + 0x8]);          /* mov bx, [bx+0x8] */
            ii(0x13_e54c, 2); cmp(bx, si);                              /* cmp bx, si */
            ii(0x13_e54e, 2); if(jzw(0x13_e586, 0x36)) goto l_0x13_e586; /* jz 0xe586 */
            ii(0x13_e550, 1); dec(bx);                                  /* dec bx */
            ii(0x13_e551, 2); xor(di, di);                              /* xor di, di */
            ii(0x13_e553, 2); jmpw(0x13_e561, 0xc); goto l_0x13_e561;   /* jmp 0xe561 */
        //  ii(0x13_e555, 1); Недостижимый код.
l_0x13_e556:
            ii(0x13_e556, 3); lea(dx, si - 0x2);                        /* lea dx, [si-0x2] */
            ii(0x13_e559, 2); cmp(dx, bx);                              /* cmp dx, bx */
            ii(0x13_e55b, 2); if(jaew(0x13_e53e, -0x1f)) goto l_0x13_e53e; /* jae 0xe53e */
            ii(0x13_e55d, 2); add(si, ax);                              /* add si, ax */
            ii(0x13_e55f, 2); if(jbw(0x13_e584, 0x23)) goto l_0x13_e584; /* jb 0xe584 */
        l_0x13_e561:
            ii(0x13_e561, 1); lodsw_a16();                              /* lodsw */
            ii(0x13_e562, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x13_e564, 2); if(jzw(0x13_e556, -0x10)) goto l_0x13_e556; /* jz 0xe556 */
            ii(0x13_e566, 2); mov(di, si);                              /* mov di, si */
        l_0x13_e568:
            ii(0x13_e568, 1); dec(ax);                                  /* dec ax */
            ii(0x13_e569, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x13_e56b, 2); if(jaew(0x13_e590, 0x23)) goto l_0x13_e590; /* jae 0xe590 */
            ii(0x13_e56d, 2); add(si, ax);                              /* add si, ax */
            ii(0x13_e56f, 2); if(jbw(0x13_e584, 0x13)) goto l_0x13_e584; /* jb 0xe584 */
            ii(0x13_e571, 2); mov(dx, ax);                              /* mov dx, ax */
            ii(0x13_e573, 1); lodsw_a16();                              /* lodsw */
            ii(0x13_e574, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x13_e576, 2); if(jzw(0x13_e556, -0x22)) goto l_0x13_e556; /* jz 0xe556 */
            ii(0x13_e578, 2); add(ax, dx);                              /* add ax, dx */
            ii(0x13_e57a, 3); add(ax, 0x2);                             /* add ax, 0x2 */
            ii(0x13_e57d, 2); mov(si, di);                              /* mov si, di */
            ii(0x13_e57f, 3); mov(memw_a16[ds, si - 0x2], ax);          /* mov [si-0x2], ax */
            ii(0x13_e582, 2); jmpw(0x13_e568, -0x1c); goto l_0x13_e568; /* jmp 0xe568 */
        l_0x13_e584:
            ii(0x13_e584, 2); mov(ax, ax);                              /* mov ax, ax */
        l_0x13_e586:
            ii(0x13_e586, 1); popw(bx);                                 /* pop bx */
        l_0x13_e587:
            ii(0x13_e587, 3); mov(ax, memw_a16[ds, bx + 0x6]);          /* mov ax, [bx+0x6] */
            ii(0x13_e58a, 3); mov(memw_a16[ds, bx + 0x8], ax);          /* mov [bx+0x8], ax */
            ii(0x13_e58d, 1); stc();                                    /* stc */
            ii(0x13_e58e, 2); jmpw(0x13_e5a9, 0x19); goto l_0x13_e5a9;  /* jmp 0xe5a9 */
        l_0x13_e590:
            ii(0x13_e590, 1); popw(bx);                                 /* pop bx */
            ii(0x13_e591, 3); mov(memw_a16[ds, si - 0x2], cx);          /* mov [si-0x2], cx */
            ii(0x13_e594, 2); if(jzw(0x13_e59f, 0x9)) goto l_0x13_e59f; /* jz 0xe59f */
            ii(0x13_e596, 2); add(di, cx);                              /* add di, cx */
            ii(0x13_e598, 2); sub(ax, cx);                              /* sub ax, cx */
            ii(0x13_e59a, 1); dec(ax);                                  /* dec ax */
            ii(0x13_e59b, 2); mov(memw_a16[ds, di], ax);                /* mov [di], ax */
            ii(0x13_e59d, 2); sub(di, cx);                              /* sub di, cx */
        l_0x13_e59f:
            ii(0x13_e59f, 2); add(di, cx);                              /* add di, cx */
            ii(0x13_e5a1, 3); mov(memw_a16[ds, bx + 0x8], di);          /* mov [bx+0x8], di */
            ii(0x13_e5a4, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x13_e5a6, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x13_e5a8, 1); clc();                                    /* clc */
        l_0x13_e5a9:
            ii(0x13_e5a9, 1); retw(); return;                           /* ret */
        }
    }
}
