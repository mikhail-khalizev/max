using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9839-dc98fec5")]
        public void Method_0000_9839()
        {
            ii(0x9839, 4);    enter(2, 0);                              /* enter 0x2, 0x0 */
            ii(0x983d, 1);    push(di);                                 /* push di */
            ii(0x983e, 1);    push(si);                                 /* push si */
            ii(0x983f, 3);    mov(ax, memw[ss, bp + 8]);                /* mov ax, [bp+0x8] */
            ii(0x9842, 2);    neg(ax);                                  /* neg ax */
            ii(0x9844, 3);    and(ax, 0xf);                             /* and ax, 0xf */
            ii(0x9847, 3);    mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
        l_0x984a:
            ii(0x984a, 4);    mov(di, memw[ds, 0x1208]);                /* mov di, [0x1208] */
            ii(0x984e, 4);    sub(di, memw[ds, 0x11d0]);                /* sub di, [0x11d0] */
            ii(0x9852, 2);    if(jnz(0x9857, 3)) goto l_0x9857;         /* jnz 0x9857 */
            ii(0x9854, 3);    call(0x97c3, -0x94);                      /* call 0x97c3 */
        l_0x9857:
            ii(0x9857, 4);    mov(di, memw[ds, 0x1208]);                /* mov di, [0x1208] */
            ii(0x985b, 4);    sub(di, memw[ds, 0x11d0]);                /* sub di, [0x11d0] */
            ii(0x985f, 2);    if(jnz(0x9883, 0x22)) goto l_0x9883;      /* jnz 0x9883 */
            ii(0x9861, 4);    cmp(memw[ss, bp + 6], 0);                 /* cmp word [bp+0x6], 0x0 */
            ii(0x9865, 2);    if(jz(0x987a, 0x13)) goto l_0x987a;       /* jz 0x987a */
            ii(0x9867, 2);    push(0);                                  /* push 0x0 */
            ii(0x9869, 3);    push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x986c, 3);    push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x986f, 3);    push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x9872, 3);    call(0x7c27, -0x1c4e);                    /* call 0x7c27 */
            ii(0x9875, 3);    add(sp, 8);                               /* add sp, 0x8 */
            ii(0x9878, 2);    jmp(0x98cd, 0x53); goto l_0x98cd;         /* jmp 0x98cd */
        l_0x987a:
            ii(0x987a, 3);    call(0x6f71, -0x290c);                    /* call 0x6f71 */
            ii(0x987d, 2);    push(-0xe /* 0xf2 */);                    /* push 0xfff2 */
            ii(0x987f, 3);    call(0x805d, -0x1825);                    /* call 0x805d */
            ii(0x9882, 1);    pop(bx);                                  /* pop bx */
        l_0x9883:
            ii(0x9883, 3);    mov(si, memw[ss, bp + 8]);                /* mov si, [bp+0x8] */
            ii(0x9886, 2);    cmp(si, di);                              /* cmp si, di */
            ii(0x9888, 2);    if(ja(0x988e, 4)) goto l_0x988e;          /* ja 0x988e */
            ii(0x988a, 2);    or(si, si);                               /* or si, si */
            ii(0x988c, 2);    if(jnz(0x9890, 2)) goto l_0x9890;         /* jnz 0x9890 */
        l_0x988e:
            ii(0x988e, 2);    mov(si, di);                              /* mov si, di */
        l_0x9890:
            ii(0x9890, 1);    push(si);                                 /* push si */
            ii(0x9891, 3);    push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x9894, 3);    push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x9897, 4);    push(memw[ds, 0x11d0]);                   /* push word [0x11d0] */
            ii(0x989b, 2);    push(0x20);                               /* push 0x20 */
            ii(0x989d, 3);    call(0xbeb2, 0x2612);                     /* call 0xbeb2 */
            ii(0x98a0, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x98a3, 3);    add(memw[ss, bp + 6], si);                /* add [bp+0x6], si */
            ii(0x98a6, 4);    add(memw[ds, 0x11d0], si);                /* add [0x11d0], si */
            ii(0x98aa, 3);    sub(memw[ss, bp + 8], si);                /* sub [bp+0x8], si */
            ii(0x98ad, 2);    if(jnz(0x984a, -0x65)) goto l_0x984a;     /* jnz 0x984a */
            ii(0x98af, 2);    jmp(0x98b8, 7); goto l_0x98b8;            /* jmp 0x98b8 */
        l_0x98b1:
            ii(0x98b1, 3);    call(0x97c3, -0xf1);                      /* call 0x97c3 */
            ii(0x98b4, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x98b6, 2);    if(jz(0x98cd, 0x15)) goto l_0x98cd;       /* jz 0x98cd */
        l_0x98b8:
            ii(0x98b8, 3);    mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x98bb, 4);    add(memw[ds, 0x11d0], ax);                /* add [0x11d0], ax */
            ii(0x98bf, 3);    mov(ax, memw[ds, 0x11d0]);                /* mov ax, [0x11d0] */
            ii(0x98c2, 4);    sub(ax, memw[ds, 0x1208]);                /* sub ax, [0x1208] */
            ii(0x98c6, 3);    mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x98c9, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x98cb, 2);    if(jg(0x98b1, -0x1c)) goto l_0x98b1;      /* jg 0x98b1 */
        l_0x98cd:
            ii(0x98cd, 1);    pop(si);                                  /* pop si */
            ii(0x98ce, 1);    pop(di);                                  /* pop di */
            ii(0x98cf, 1);    leave();                                  /* leave */
            ii(0x98d0, 1);    ret();                                    /* ret */
        }
    }
}
