using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_e52e-90e3e801")]
        public void Method_0017_e52e()
        {
            ii(0x17_e52e, 1); inc(cx);                                  /* inc cx */
            ii(0x17_e52f, 3); and(cl, 0xfe);                            /* and cl, 0xfe */
            ii(0x17_e532, 1); push(bx);                                 /* push bx */
            ii(0x17_e533, 1); cld();                                    /* cld */
            ii(0x17_e534, 3); mov(si, memw[ds, bx + 0x8]);              /* mov si, [bx+0x8] */
            ii(0x17_e537, 3); mov(bx, memw[ds, bx + 0xa]);              /* mov bx, [bx+0xa] */
            ii(0x17_e53a, 2); xor(di, di);                              /* xor di, di */
            ii(0x17_e53c, 2); jmp(0x17_e561, 0x23); goto l_0x17_e561;   /* jmp 0xe561 */
        l_0x17_e53e:
            ii(0x17_e53e, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x17_e540, 1); pop(bx);                                  /* pop bx */
            ii(0x17_e541, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x17_e543, 2); if(jnz(0x17_e587, 0x42)) goto l_0x17_e587; /* jnz 0xe587 */
            ii(0x17_e545, 1); push(bx);                                 /* push bx */
            ii(0x17_e546, 3); mov(si, memw[ds, bx + 0x6]);              /* mov si, [bx+0x6] */
            ii(0x17_e549, 3); mov(bx, memw[ds, bx + 0x8]);              /* mov bx, [bx+0x8] */
            ii(0x17_e54c, 2); cmp(bx, si);                              /* cmp bx, si */
            ii(0x17_e54e, 2); if(jz(0x17_e586, 0x36)) goto l_0x17_e586; /* jz 0xe586 */
            ii(0x17_e550, 1); dec(bx);                                  /* dec bx */
            ii(0x17_e551, 2); xor(di, di);                              /* xor di, di */
            ii(0x17_e553, 2); jmp(0x17_e561, 0xc); goto l_0x17_e561;    /* jmp 0xe561 */
        //  ii(0x17_e555, 1); nop();                                    /* nop */
        l_0x17_e556:
            ii(0x17_e556, 3); lea(dx, memw[ds, si - 0x2]);              /* lea dx, [si-0x2] */
            ii(0x17_e559, 2); cmp(dx, bx);                              /* cmp dx, bx */
            ii(0x17_e55b, 2); if(jae(0x17_e53e, -0x1f)) goto l_0x17_e53e; /* jae 0xe53e */
            ii(0x17_e55d, 2); add(si, ax);                              /* add si, ax */
            ii(0x17_e55f, 2); if(jb(0x17_e584, 0x23)) goto l_0x17_e584; /* jb 0xe584 */
        l_0x17_e561:
            ii(0x17_e561, 1); lodsw();                                  /* lodsw */
            ii(0x17_e562, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x17_e564, 2); if(jz(0x17_e556, -0x10)) goto l_0x17_e556; /* jz 0xe556 */
            ii(0x17_e566, 2); mov(di, si);                              /* mov di, si */
        l_0x17_e568:
            ii(0x17_e568, 1); dec(ax);                                  /* dec ax */
            ii(0x17_e569, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x17_e56b, 2); if(jae(0x17_e590, 0x23)) goto l_0x17_e590; /* jae 0xe590 */
            ii(0x17_e56d, 2); add(si, ax);                              /* add si, ax */
            ii(0x17_e56f, 2); if(jb(0x17_e584, 0x13)) goto l_0x17_e584; /* jb 0xe584 */
            ii(0x17_e571, 2); mov(dx, ax);                              /* mov dx, ax */
            ii(0x17_e573, 1); lodsw();                                  /* lodsw */
            ii(0x17_e574, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x17_e576, 2); if(jz(0x17_e556, -0x22)) goto l_0x17_e556; /* jz 0xe556 */
            ii(0x17_e578, 2); add(ax, dx);                              /* add ax, dx */
            ii(0x17_e57a, 3); add(ax, 0x2);                             /* add ax, 0x2 */
            ii(0x17_e57d, 2); mov(si, di);                              /* mov si, di */
            ii(0x17_e57f, 3); mov(memw[ds, si - 0x2], ax);              /* mov [si-0x2], ax */
            ii(0x17_e582, 2); jmp(0x17_e568, -0x1c); goto l_0x17_e568;  /* jmp 0xe568 */
        l_0x17_e584:
            ii(0x17_e584, 2); mov(ax, ax);                              /* mov ax, ax */
        l_0x17_e586:
            ii(0x17_e586, 1); pop(bx);                                  /* pop bx */
        l_0x17_e587:
            ii(0x17_e587, 3); mov(ax, memw[ds, bx + 0x6]);              /* mov ax, [bx+0x6] */
            ii(0x17_e58a, 3); mov(memw[ds, bx + 0x8], ax);              /* mov [bx+0x8], ax */
            ii(0x17_e58d, 1); stc();                                    /* stc */
            ii(0x17_e58e, 2); jmp(0x17_e5a9, 0x19); goto l_0x17_e5a9;   /* jmp 0xe5a9 */
        l_0x17_e590:
            ii(0x17_e590, 1); pop(bx);                                  /* pop bx */
            ii(0x17_e591, 3); mov(memw[ds, si - 0x2], cx);              /* mov [si-0x2], cx */
            ii(0x17_e594, 2); if(jz(0x17_e59f, 0x9)) goto l_0x17_e59f;  /* jz 0xe59f */
            ii(0x17_e596, 2); add(di, cx);                              /* add di, cx */
            ii(0x17_e598, 2); sub(ax, cx);                              /* sub ax, cx */
            ii(0x17_e59a, 1); dec(ax);                                  /* dec ax */
            ii(0x17_e59b, 2); mov(memw[ds, di], ax);                    /* mov [di], ax */
            ii(0x17_e59d, 2); sub(di, cx);                              /* sub di, cx */
        l_0x17_e59f:
            ii(0x17_e59f, 2); add(di, cx);                              /* add di, cx */
            ii(0x17_e5a1, 3); mov(memw[ds, bx + 0x8], di);              /* mov [bx+0x8], di */
            ii(0x17_e5a4, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x17_e5a6, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x17_e5a8, 1); clc();                                    /* clc */
        l_0x17_e5a9:
            ii(0x17_e5a9, 1); ret();                                    /* ret */
        }
    }
}
