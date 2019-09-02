using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x796c-cfb49c25")]
        public void Method_0000_796c()
        {
            ii(0x796c, 4);    enter(8, 0);                              /* enter 0x8, 0x0 */
            ii(0x7970, 1);    push(di);                                 /* push di */
            ii(0x7971, 1);    push(si);                                 /* push si */
            ii(0x7972, 5);    mov(memw[ss, bp - 8], 0);                 /* mov word [bp-0x8], 0x0 */
            ii(0x7977, 3);    call(0x572a, -0x2250);                    /* call 0x572a */
            ii(0x797a, 5);    mov(memw[ss, bp - 6], 0);                 /* mov word [bp-0x6], 0x0 */
            ii(0x797f, 5);    mov(memw[ss, bp - 4], 8);                 /* mov word [bp-0x4], 0x8 */
            ii(0x7984, 4);    cmp(memw[ss, bp + 4], 0);                 /* cmp word [bp+0x4], 0x0 */
            ii(0x7988, 2);    if(jle(0x79de, 0x54)) goto l_0x79de;      /* jle 0x79de */
            ii(0x798a, 3);    mov(bx, 8);                               /* mov bx, 0x8 */
            ii(0x798d, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0x798f, 3);    mov(si, memw[es, bx]);                    /* mov si, [es:bx] */
            ii(0x7992, 3);    shr(si, 3);                               /* shr si, 0x3 */
            ii(0x7995, 1);    dec(si);                                  /* dec si */
            ii(0x7996, 1);    dec(si);                                  /* dec si */
            ii(0x7997, 3);    mov(ax, memw[ss, bp + 4]);                /* mov ax, [bp+0x4] */
            ii(0x799a, 3);    add(ax, 0x10);                            /* add ax, 0x10 */
            ii(0x799d, 3);    mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x79a0, 2);    jmp(0x79ab, 9); goto l_0x79ab;            /* jmp 0x79ab */
        l_0x79a2:
            ii(0x79a2, 3);    cmp(memw[ss, bp - 2], si);                /* cmp [bp-0x2], si */
            ii(0x79a5, 2);    if(jl(0x79aa, 3)) goto l_0x79aa;          /* jl 0x79aa */
            ii(0x79a7, 3);    jmp(0x7a33, 0x89); goto l_0x7a33;         /* jmp 0x7a33 */
        l_0x79aa:
            ii(0x79aa, 1);    dec(si);                                  /* dec si */
        l_0x79ab:
            ii(0x79ab, 2);    mov(bx, si);                              /* mov bx, si */
            ii(0x79ad, 3);    shl(bx, 3);                               /* shl bx, 0x3 */
            ii(0x79b0, 3);    add(bx, memw[ss, bp - 6]);                /* add bx, [bp-0x6] */
            ii(0x79b3, 3);    mov(es, memw[ss, bp - 4]);                /* mov es, [bp-0x4] */
            ii(0x79b6, 5);    cmp(memb[es, bx + 5], 0);                 /* cmp byte [es:bx+0x5], 0x0 */
            ii(0x79bb, 2);    if(jnz(0x79a2, -0x1b)) goto l_0x79a2;     /* jnz 0x79a2 */
            ii(0x79bd, 3);    mov(di, memw[ss, bp + 4]);                /* mov di, [bp+0x4] */
            ii(0x79c0, 1);    dec(di);                                  /* dec di */
        l_0x79c1:
            ii(0x79c1, 1);    dec(di);                                  /* dec di */
            ii(0x79c2, 2);    if(jns(0x79c9, 5)) goto l_0x79c9;         /* jns 0x79c9 */
        l_0x79c4:
            ii(0x79c4, 3);    mov(memw[ss, bp - 8], si);                /* mov [bp-0x8], si */
            ii(0x79c7, 2);    jmp(0x7a33, 0x6a); goto l_0x7a33;         /* jmp 0x7a33 */
        l_0x79c9:
            ii(0x79c9, 1);    dec(si);                                  /* dec si */
            ii(0x79ca, 2);    mov(bx, si);                              /* mov bx, si */
            ii(0x79cc, 3);    shl(bx, 3);                               /* shl bx, 0x3 */
            ii(0x79cf, 3);    add(bx, memw[ss, bp - 6]);                /* add bx, [bp-0x6] */
            ii(0x79d2, 3);    mov(es, memw[ss, bp - 4]);                /* mov es, [bp-0x4] */
            ii(0x79d5, 5);    cmp(memb[es, bx + 5], 0);                 /* cmp byte [es:bx+0x5], 0x0 */
            ii(0x79da, 2);    if(jz(0x79c1, -0x1b)) goto l_0x79c1;      /* jz 0x79c1 */
            ii(0x79dc, 2);    jmp(0x79ab, -0x33); goto l_0x79ab;        /* jmp 0x79ab */
        l_0x79de:
            ii(0x79de, 3);    les(bx, memw[ss, bp - 6]);                /* les bx, [bp-0x6] */
            ii(0x79e1, 4);    mov(ax, memw[es, bx + 8]);                /* mov ax, [es:bx+0x8] */
            ii(0x79e5, 3);    shr(ax, 3);                               /* shr ax, 0x3 */
            ii(0x79e8, 3);    add(ax, memw[ss, bp + 4]);                /* add ax, [bp+0x4] */
            ii(0x79eb, 1);    dec(ax);                                  /* dec ax */
            ii(0x79ec, 1);    dec(ax);                                  /* dec ax */
            ii(0x79ed, 3);    mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x79f0, 3);    mov(si, 0x10);                            /* mov si, 0x10 */
            ii(0x79f3, 2);    jmp(0x7a2d, 0x38); goto l_0x7a2d;         /* jmp 0x7a2d */
        l_0x79f5:
            ii(0x79f5, 2);    mov(bx, si);                              /* mov bx, si */
            ii(0x79f7, 3);    shl(bx, 3);                               /* shl bx, 0x3 */
            ii(0x79fa, 3);    add(bx, memw[ss, bp - 6]);                /* add bx, [bp-0x6] */
            ii(0x79fd, 5);    cmp(memb[es, bx + 5], 0);                 /* cmp byte [es:bx+0x5], 0x0 */
            ii(0x7a02, 2);    if(jnz(0x7a25, 0x21)) goto l_0x7a25;      /* jnz 0x7a25 */
            ii(0x7a04, 3);    mov(di, memw[ss, bp + 4]);                /* mov di, [bp+0x4] */
            ii(0x7a07, 2);    neg(di);                                  /* neg di */
            ii(0x7a09, 2);    add(si, di);                              /* add si, di */
        l_0x7a0b:
            ii(0x7a0b, 1);    dec(si);                                  /* dec si */
            ii(0x7a0c, 2);    mov(bx, si);                              /* mov bx, si */
            ii(0x7a0e, 3);    shl(bx, 3);                               /* shl bx, 0x3 */
            ii(0x7a11, 3);    add(bx, memw[ss, bp - 6]);                /* add bx, [bp-0x6] */
            ii(0x7a14, 3);    mov(es, memw[ss, bp - 4]);                /* mov es, [bp-0x4] */
            ii(0x7a17, 5);    cmp(memb[es, bx + 5], 0);                 /* cmp byte [es:bx+0x5], 0x0 */
            ii(0x7a1c, 2);    if(jnz(0x7a2d, 0xf)) goto l_0x7a2d;       /* jnz 0x7a2d */
            ii(0x7a1e, 1);    dec(di);                                  /* dec di */
            ii(0x7a1f, 2);    or(di, di);                               /* or di, di */
            ii(0x7a21, 2);    if(jg(0x7a0b, -0x18)) goto l_0x7a0b;      /* jg 0x7a0b */
            ii(0x7a23, 2);    jmp(0x79c4, -0x61); goto l_0x79c4;        /* jmp 0x79c4 */
        l_0x7a25:
            ii(0x7a25, 1);    inc(si);                                  /* inc si */
            ii(0x7a26, 3);    cmp(memw[ss, bp - 2], si);                /* cmp [bp-0x2], si */
            ii(0x7a29, 2);    if(jg(0x79f5, -0x36)) goto l_0x79f5;      /* jg 0x79f5 */
            ii(0x7a2b, 2);    jmp(0x7a33, 6); goto l_0x7a33;            /* jmp 0x7a33 */
        l_0x7a2d:
            ii(0x7a2d, 4);    cmp(memw[ss, bp - 8], 0);                 /* cmp word [bp-0x8], 0x0 */
            ii(0x7a31, 2);    if(jz(0x79f5, -0x3e)) goto l_0x79f5;      /* jz 0x79f5 */
        l_0x7a33:
            ii(0x7a33, 3);    call(0x4f61, -0x2ad5);                    /* call 0x4f61 */
            ii(0x7a36, 3);    mov(ax, memw[ss, bp - 8]);                /* mov ax, [bp-0x8] */
            ii(0x7a39, 1);    pop(si);                                  /* pop si */
            ii(0x7a3a, 1);    pop(di);                                  /* pop di */
            ii(0x7a3b, 1);    leave();                                  /* leave */
            ii(0x7a3c, 1);    ret();                                    /* ret */
        }
    }
}
