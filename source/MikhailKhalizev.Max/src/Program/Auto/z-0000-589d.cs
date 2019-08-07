using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d8d00774-8229-448a-993b-a1afc3d391f1")]
        public void Method_0000_589d()
        {
            ii(0x589d, 1);    pushw(bp);                                /* push bp */
            ii(0x589e, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x58a0, 4);    sub(sp, 0x9c);                            /* sub sp, 0x9c */
            ii(0x58a4, 1);    pushw(di);                                /* push di */
            ii(0x58a5, 1);    pushw(si);                                /* push si */
            ii(0x58a6, 5);    mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x58ab, 4);    cmp(memw_a16[ss, bp + 0x4], 0);           /* cmp word [bp+0x4], 0x0 */
            ii(0x58af, 2);    if(jgew(0x58b9, 0x8)) goto l_0x58b9;      /* jge 0x58b9 */
            ii(0x58b1, 5);    mov(memw_a16[ss, bp - 0x2], 0x1);         /* mov word [bp-0x2], 0x1 */
            ii(0x58b6, 3);    neg(memw_a16[ss, bp + 0x4]);              /* neg word [bp+0x4] */
        l_0x58b9:
            ii(0x58b9, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x58bc, 4);    mov(memw_a16[ss, bp - 0x9a], ax);         /* mov [bp-0x9a], ax */
            ii(0x58c0, 4);    lea(si, bp - 0x98);                       /* lea si, [bp-0x98] */
            ii(0x58c4, 5);    cmp(memb_a16[ds, 0xf21], 0x1);            /* cmp byte [0xf21], 0x1 */
            ii(0x58c9, 2);    if(jzw(0x591d, 0x52)) goto l_0x591d;      /* jz 0x591d */
            ii(0x58cb, 5);    mov(memb_a16[ss, bp - 0x98], 0x5b);       /* mov byte [bp-0x98], 0x5b */
            ii(0x58d0, 4);    lea(si, bp - 0x97);                       /* lea si, [bp-0x97] */
        l_0x58d4:
            ii(0x58d4, 1);    inc(si);                                  /* inc si */
            ii(0x58d5, 3);    mov(cx, 0xa);                             /* mov cx, 0xa */
            ii(0x58d8, 4);    mov(ax, memw_a16[ss, bp - 0x9a]);         /* mov ax, [bp-0x9a] */
            ii(0x58dc, 1);    cwd();                                    /* cwd */
            ii(0x58dd, 2);    idiv(cx);                                 /* idiv cx */
            ii(0x58df, 4);    mov(memw_a16[ss, bp - 0x9a], ax);         /* mov [bp-0x9a], ax */
            ii(0x58e3, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x58e5, 2);    if(jnzw(0x58d4, -0x13)) goto l_0x58d4;    /* jnz 0x58d4 */
            ii(0x58e7, 2);    mov(di, si);                              /* mov di, si */
            ii(0x58e9, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x58ec, 4);    mov(memw_a16[ss, bp - 0x9a], ax);         /* mov [bp-0x9a], ax */
        l_0x58f0:
            ii(0x58f0, 1);    cwd();                                    /* cwd */
            ii(0x58f1, 2);    idiv(cx);                                 /* idiv cx */
            ii(0x58f3, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0x58f5, 4);    mov(al, memb_a16[ds, bx + 0xab0]);        /* mov al, [bx+0xab0] */
            ii(0x58f9, 1);    dec(di);                                  /* dec di */
            ii(0x58fa, 2);    mov(memb_a16[ds, di], al);                /* mov [di], al */
            ii(0x58fc, 4);    mov(ax, memw_a16[ss, bp - 0x9a]);         /* mov ax, [bp-0x9a] */
            ii(0x5900, 1);    cwd();                                    /* cwd */
            ii(0x5901, 2);    idiv(cx);                                 /* idiv cx */
            ii(0x5903, 4);    mov(memw_a16[ss, bp - 0x9a], ax);         /* mov [bp-0x9a], ax */
            ii(0x5907, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x5909, 2);    if(jnzw(0x58f0, -0x1b)) goto l_0x58f0;    /* jnz 0x58f0 */
            ii(0x590b, 1);    inc(si);                                  /* inc si */
            ii(0x590c, 4);    mov(memb_a16[ds, si - 0x1], 0x5d);        /* mov byte [si-0x1], 0x5d */
            ii(0x5910, 1);    inc(si);                                  /* inc si */
            ii(0x5911, 4);    mov(memb_a16[ds, si - 0x1], 0x20);        /* mov byte [si-0x1], 0x20 */
            ii(0x5915, 1);    inc(si);                                  /* inc si */
            ii(0x5916, 4);    mov(memb_a16[ds, si - 0x1], 0x20);        /* mov byte [si-0x1], 0x20 */
            ii(0x591a, 3);    mov(memb_a16[ds, si], 0);                 /* mov byte [si], 0x0 */
        l_0x591d:
            ii(0x591d, 3);    mov(di, 0x15e8);                          /* mov di, 0x15e8 */
            ii(0x5920, 2);    jmpw(0x593d, 0x1b); goto l_0x593d;        /* jmp 0x593d */
        l_0x5922:
            ii(0x5922, 4);    cmp(memw_a16[ds, 0xf22], di);             /* cmp [0xf22], di */
            ii(0x5926, 2);    if(jbew(0x5949, 0x21)) goto l_0x5949;     /* jbe 0x5949 */
            ii(0x5928, 3);    cmp(ax, memw_a16[ss, bp + 0x4]);          /* cmp ax, [bp+0x4] */
            ii(0x592b, 2);    if(jnzw(0x5936, 0x9)) goto l_0x5936;      /* jnz 0x5936 */
            ii(0x592d, 1);    pushw(di);                                /* push di */
            ii(0x592e, 1);    pushw(si);                                /* push si */
            ii(0x592f, 3);    callw(0x5bde, 0x2ac);                     /* call 0x5bde */
            ii(0x5932, 1);    popw(bx);                                 /* pop bx */
            ii(0x5933, 1);    popw(bx);                                 /* pop bx */
            ii(0x5934, 2);    jmpw(0x5949, 0x13); goto l_0x5949;        /* jmp 0x5949 */
        l_0x5936:
            ii(0x5936, 1);    inc(di);                                  /* inc di */
            ii(0x5937, 4);    cmp(memb_a16[ds, di - 0x1], 0);           /* cmp byte [di-0x1], 0x0 */
            ii(0x593b, 2);    if(jnzw(0x5936, -0x7)) goto l_0x5936;     /* jnz 0x5936 */
        l_0x593d:
            ii(0x593d, 2);    mov(ax, memw_a16[ds, di]);                /* mov ax, [di] */
            ii(0x593f, 1);    inc(di);                                  /* inc di */
            ii(0x5940, 1);    inc(di);                                  /* inc di */
            ii(0x5941, 4);    mov(memw_a16[ss, bp - 0x9a], ax);         /* mov [bp-0x9a], ax */
            ii(0x5945, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x5947, 2);    if(jgew(0x5922, -0x27)) goto l_0x5922;    /* jge 0x5922 */
        l_0x5949:
            ii(0x5949, 4);    cmp(memw_a16[ss, bp - 0x2], 0);           /* cmp word [bp-0x2], 0x0 */
            ii(0x594d, 2);    if(jzw(0x595e, 0xf)) goto l_0x595e;       /* jz 0x595e */
            ii(0x594f, 3);    mov(ax, 0x1190);                          /* mov ax, 0x1190 */
            ii(0x5952, 1);    pushw(ax);                                /* push ax */
            ii(0x5953, 4);    lea(ax, bp - 0x98);                       /* lea ax, [bp-0x98] */
            ii(0x5957, 1);    pushw(ax);                                /* push ax */
            ii(0x5958, 4);    callw_abs(memw_a16[ds, 0xe6c]);           /* call word [0xe6c] */
            ii(0x595c, 1);    popw(bx);                                 /* pop bx */
            ii(0x595d, 1);    popw(bx);                                 /* pop bx */
        l_0x595e:
            ii(0x595e, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x5960, 1);    pushw(ax);                                /* push ax */
            ii(0x5961, 4);    lea(ax, bp - 0x98);                       /* lea ax, [bp-0x98] */
            ii(0x5965, 1);    pushw(ax);                                /* push ax */
            ii(0x5966, 4);    callw_abs(memw_a16[ds, 0xe6c]);           /* call word [0xe6c] */
            ii(0x596a, 1);    popw(bx);                                 /* pop bx */
            ii(0x596b, 1);    popw(bx);                                 /* pop bx */
            ii(0x596c, 1);    popw(si);                                 /* pop si */
            ii(0x596d, 1);    popw(di);                                 /* pop di */
            ii(0x596e, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x5970, 1);    popw(bp);                                 /* pop bp */
            ii(0x5971, 1);    retw(); return;                           /* ret */
        }
    }
}
