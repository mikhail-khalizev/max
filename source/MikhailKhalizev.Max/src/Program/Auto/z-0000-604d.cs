using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x604d-63204d07")]
        public void Method_0000_604d()
        {
            ii(0x604d, 1);    push(bp);                                 /* push bp */
            ii(0x604e, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x6050, 4);    sub(sp, 0x9c);                            /* sub sp, 0x9c */
            ii(0x6054, 1);    push(di);                                 /* push di */
            ii(0x6055, 1);    push(si);                                 /* push si */
            ii(0x6056, 5);    mov(memw[ss, bp - 0x2], 0);               /* mov word [bp-0x2], 0x0 */
            ii(0x605b, 4);    cmp(memw[ss, bp + 0x4], 0);               /* cmp word [bp+0x4], 0x0 */
            ii(0x605f, 2);    if(jge(0x6069, 0x8)) goto l_0x6069;       /* jge 0x6069 */
            ii(0x6061, 5);    mov(memw[ss, bp - 0x2], 0x1);             /* mov word [bp-0x2], 0x1 */
            ii(0x6066, 3);    neg(memw[ss, bp + 0x4]);                  /* neg word [bp+0x4] */
        l_0x6069:
            ii(0x6069, 3);    mov(ax, memw[ss, bp + 0x4]);              /* mov ax, [bp+0x4] */
            ii(0x606c, 4);    mov(memw[ss, bp - 0x9a], ax);             /* mov [bp-0x9a], ax */
            ii(0x6070, 4);    lea(si, bp - 0x98);                       /* lea si, [bp-0x98] */
            ii(0x6074, 5);    cmp(memb[ds, 0xf21], 0x1);                /* cmp byte [0xf21], 0x1 */
            ii(0x6079, 2);    if(jz(0x60cd, 0x52)) goto l_0x60cd;       /* jz 0x60cd */
            ii(0x607b, 5);    mov(memb[ss, bp - 0x98], 0x5b);           /* mov byte [bp-0x98], 0x5b */
            ii(0x6080, 4);    lea(si, bp - 0x97);                       /* lea si, [bp-0x97] */
        l_0x6084:
            ii(0x6084, 1);    inc(si);                                  /* inc si */
            ii(0x6085, 3);    mov(cx, 0xa);                             /* mov cx, 0xa */
            ii(0x6088, 4);    mov(ax, memw[ss, bp - 0x9a]);             /* mov ax, [bp-0x9a] */
            ii(0x608c, 1);    cwd();                                    /* cwd */
            ii(0x608d, 2);    idiv(cx);                                 /* idiv cx */
            ii(0x608f, 4);    mov(memw[ss, bp - 0x9a], ax);             /* mov [bp-0x9a], ax */
            ii(0x6093, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x6095, 2);    if(jnz(0x6084, -0x13)) goto l_0x6084;     /* jnz 0x6084 */
            ii(0x6097, 2);    mov(di, si);                              /* mov di, si */
            ii(0x6099, 3);    mov(ax, memw[ss, bp + 0x4]);              /* mov ax, [bp+0x4] */
            ii(0x609c, 4);    mov(memw[ss, bp - 0x9a], ax);             /* mov [bp-0x9a], ax */
        l_0x60a0:
            ii(0x60a0, 1);    cwd();                                    /* cwd */
            ii(0x60a1, 2);    idiv(cx);                                 /* idiv cx */
            ii(0x60a3, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0x60a5, 4);    mov(al, memb[ds, bx + 0xab0]);            /* mov al, [bx+0xab0] */
            ii(0x60a9, 1);    dec(di);                                  /* dec di */
            ii(0x60aa, 2);    mov(memb[ds, di], al);                    /* mov [di], al */
            ii(0x60ac, 4);    mov(ax, memw[ss, bp - 0x9a]);             /* mov ax, [bp-0x9a] */
            ii(0x60b0, 1);    cwd();                                    /* cwd */
            ii(0x60b1, 2);    idiv(cx);                                 /* idiv cx */
            ii(0x60b3, 4);    mov(memw[ss, bp - 0x9a], ax);             /* mov [bp-0x9a], ax */
            ii(0x60b7, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x60b9, 2);    if(jnz(0x60a0, -0x1b)) goto l_0x60a0;     /* jnz 0x60a0 */
            ii(0x60bb, 1);    inc(si);                                  /* inc si */
            ii(0x60bc, 4);    mov(memb[ds, si - 0x1], 0x5d);            /* mov byte [si-0x1], 0x5d */
            ii(0x60c0, 1);    inc(si);                                  /* inc si */
            ii(0x60c1, 4);    mov(memb[ds, si - 0x1], 0x20);            /* mov byte [si-0x1], 0x20 */
            ii(0x60c5, 1);    inc(si);                                  /* inc si */
            ii(0x60c6, 4);    mov(memb[ds, si - 0x1], 0x20);            /* mov byte [si-0x1], 0x20 */
            ii(0x60ca, 3);    mov(memb[ds, si], 0);                     /* mov byte [si], 0x0 */
        l_0x60cd:
            ii(0x60cd, 3);    mov(di, 0x15e8);                          /* mov di, 0x15e8 */
            ii(0x60d0, 2);    jmp(0x60ed, 0x1b); goto l_0x60ed;         /* jmp 0x60ed */
        l_0x60d2:
            ii(0x60d2, 4);    cmp(memw[ds, 0xf22], di);                 /* cmp [0xf22], di */
            ii(0x60d6, 2);    if(jbe(0x60f9, 0x21)) goto l_0x60f9;      /* jbe 0x60f9 */
            ii(0x60d8, 3);    cmp(ax, memw[ss, bp + 0x4]);              /* cmp ax, [bp+0x4] */
            ii(0x60db, 2);    if(jnz(0x60e6, 0x9)) goto l_0x60e6;       /* jnz 0x60e6 */
            ii(0x60dd, 1);    push(di);                                 /* push di */
            ii(0x60de, 1);    push(si);                                 /* push si */
            ii(0x60df, 3);    call(0x638e, 0x2ac);                      /* call 0x638e */
            ii(0x60e2, 1);    pop(bx);                                  /* pop bx */
            ii(0x60e3, 1);    pop(bx);                                  /* pop bx */
            ii(0x60e4, 2);    jmp(0x60f9, 0x13); goto l_0x60f9;         /* jmp 0x60f9 */
        l_0x60e6:
            ii(0x60e6, 1);    inc(di);                                  /* inc di */
            ii(0x60e7, 4);    cmp(memb[ds, di - 0x1], 0);               /* cmp byte [di-0x1], 0x0 */
            ii(0x60eb, 2);    if(jnz(0x60e6, -0x7)) goto l_0x60e6;      /* jnz 0x60e6 */
        l_0x60ed:
            ii(0x60ed, 2);    mov(ax, memw[ds, di]);                    /* mov ax, [di] */
            ii(0x60ef, 1);    inc(di);                                  /* inc di */
            ii(0x60f0, 1);    inc(di);                                  /* inc di */
            ii(0x60f1, 4);    mov(memw[ss, bp - 0x9a], ax);             /* mov [bp-0x9a], ax */
            ii(0x60f5, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x60f7, 2);    if(jge(0x60d2, -0x27)) goto l_0x60d2;     /* jge 0x60d2 */
        l_0x60f9:
            ii(0x60f9, 4);    cmp(memw[ss, bp - 0x2], 0);               /* cmp word [bp-0x2], 0x0 */
            ii(0x60fd, 2);    if(jz(0x610e, 0xf)) goto l_0x610e;        /* jz 0x610e */
            ii(0x60ff, 3);    mov(ax, 0x1190);                          /* mov ax, 0x1190 */
            ii(0x6102, 1);    push(ax);                                 /* push ax */
            ii(0x6103, 4);    lea(ax, bp - 0x98);                       /* lea ax, [bp-0x98] */
            ii(0x6107, 1);    push(ax);                                 /* push ax */
            ii(0x6108, 4);    call_abs(memw[ds, 0xe6c]);                /* call word [0xe6c] */
            ii(0x610c, 1);    pop(bx);                                  /* pop bx */
            ii(0x610d, 1);    pop(bx);                                  /* pop bx */
        l_0x610e:
            ii(0x610e, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x6110, 1);    push(ax);                                 /* push ax */
            ii(0x6111, 4);    lea(ax, bp - 0x98);                       /* lea ax, [bp-0x98] */
            ii(0x6115, 1);    push(ax);                                 /* push ax */
            ii(0x6116, 4);    call_abs(memw[ds, 0xe6c]);                /* call word [0xe6c] */
            ii(0x611a, 1);    pop(bx);                                  /* pop bx */
            ii(0x611b, 1);    pop(bx);                                  /* pop bx */
            ii(0x611c, 1);    pop(si);                                  /* pop si */
            ii(0x611d, 1);    pop(di);                                  /* pop di */
            ii(0x611e, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x6120, 1);    pop(bp);                                  /* pop bp */
            ii(0x6121, 1);    ret();                                    /* ret */
        }
    }
}
