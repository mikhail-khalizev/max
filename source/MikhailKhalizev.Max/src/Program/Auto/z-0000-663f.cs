using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x663f-3d800b7a")]
        public void Method_0000_663f()
        {
            ii(0x663f, 4);    enter(0x2, 0);                            /* enter 0x2, 0x0 */
            ii(0x6643, 5);    mov(memw[ss, bp - 0x2], 0x2);             /* mov word [bp-0x2], 0x2 */
        l_0x6648:
            ii(0x6648, 4);    push(memw[ds, 0x11dc]);                   /* push word [0x11dc] */
            ii(0x664c, 4);    push(memw[ds, 0x11da]);                   /* push word [0x11da] */
            ii(0x6650, 3);    call(0x95ba, 0x2f67);                     /* call 0x95ba */
            ii(0x6653, 1);    pop(bx);                                  /* pop bx */
            ii(0x6654, 1);    pop(bx);                                  /* pop bx */
            ii(0x6655, 3);    push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x6658, 3);    push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x665b, 3);    call(0x95d2, 0x2f74);                     /* call 0x95d2 */
            ii(0x665e, 1);    pop(bx);                                  /* pop bx */
            ii(0x665f, 1);    pop(bx);                                  /* pop bx */
            ii(0x6660, 3);    cmp(ax, memw[ss, bp + 0x8]);              /* cmp ax, [bp+0x8] */
            ii(0x6663, 2);    if(jnz(0x66b2, 0x4d)) goto l_0x66b2;      /* jnz 0x66b2 */
            ii(0x6665, 3);    mov(bx, memw[ss, bp + 0x4]);              /* mov bx, [bp+0x4] */
            ii(0x6668, 3);    cmp(memb[ds, bx], 0x4d);                  /* cmp byte [bx], 0x4d */
            ii(0x666b, 2);    if(jnz(0x6683, 0x16)) goto l_0x6683;      /* jnz 0x6683 */
            ii(0x666d, 4);    cmp(memb[ds, bx + 0x1], 0x46);            /* cmp byte [bx+0x1], 0x46 */
            ii(0x6671, 2);    if(jnz(0x6683, 0x10)) goto l_0x6683;      /* jnz 0x6683 */
            ii(0x6673, 3);    mov(ax, memw[ds, bx + 0x2]);              /* mov ax, [bx+0x2] */
            ii(0x6676, 3);    mov(dx, memw[ds, bx + 0x4]);              /* mov dx, [bx+0x4] */
        l_0x6679:
            ii(0x6679, 4);    add(memw[ds, 0x11da], ax);                /* add [0x11da], ax */
            ii(0x667d, 4);    adc(memw[ds, 0x11dc], dx);                /* adc [0x11dc], dx */
            ii(0x6681, 2);    jmp(0x66ac, 0x29); goto l_0x66ac;         /* jmp 0x66ac */
        l_0x6683:
            ii(0x6683, 3);    cmp(memb[ds, bx], 0x4d);                  /* cmp byte [bx], 0x4d */
            ii(0x6686, 2);    if(jnz(0x6695, 0xd)) goto l_0x6695;       /* jnz 0x6695 */
            ii(0x6688, 4);    cmp(memb[ds, bx + 0x1], 0x5a);            /* cmp byte [bx+0x1], 0x5a */
            ii(0x668c, 2);    if(jnz(0x6695, 0x7)) goto l_0x6695;       /* jnz 0x6695 */
            ii(0x668e, 1);    push(bx);                                 /* push bx */
            ii(0x668f, 3);    call(0x65fb, -0x97);                      /* call 0x65fb */
            ii(0x6692, 1);    pop(bx);                                  /* pop bx */
            ii(0x6693, 2);    jmp(0x6679, -0x1c); goto l_0x6679;        /* jmp 0x6679 */
        l_0x6695:
            ii(0x6695, 3);    cmp(memb[ds, bx], 0x42);                  /* cmp byte [bx], 0x42 */
            ii(0x6698, 2);    if(jnz(0x66a5, 0xb)) goto l_0x66a5;       /* jnz 0x66a5 */
            ii(0x669a, 4);    cmp(memb[ds, bx + 0x1], 0x57);            /* cmp byte [bx+0x1], 0x57 */
            ii(0x669e, 2);    if(jnz(0x66a5, 0x5)) goto l_0x66a5;       /* jnz 0x66a5 */
            ii(0x66a0, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x66a3, 1);    leave();                                  /* leave */
            ii(0x66a4, 1);    ret(); return;                            /* ret */
        l_0x66a5:
            ii(0x66a5, 2);    mov(ah, 0xd);                             /* mov ah, 0xd */
            ii(0x66a7, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x66a9, 3);    dec(memw[ss, bp - 0x2]);                  /* dec word [bp-0x2] */
        l_0x66ac:
            ii(0x66ac, 4);    cmp(memw[ss, bp - 0x2], 0);               /* cmp word [bp-0x2], 0x0 */
            ii(0x66b0, 2);    if(jge(0x6648, -0x6a)) goto l_0x6648;     /* jge 0x6648 */
        l_0x66b2:
            ii(0x66b2, 4);    cmp(memw[ss, bp + 0x6], 0);               /* cmp word [bp+0x6], 0x0 */
            ii(0x66b6, 2);    if(jz(0x66be, 0x6)) goto l_0x66be;        /* jz 0x66be */
            ii(0x66b8, 2);    push(-0x2 /* 0xfe */);                    /* push 0xfffe */
            ii(0x66ba, 3);    call(0x589d, -0xe20);                     /* call 0x589d */
            ii(0x66bd, 1);    pop(bx);                                  /* pop bx */
        l_0x66be:
            ii(0x66be, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x66c0, 3);    mov(memw[ds, 0x11dc], ax);                /* mov [0x11dc], ax */
            ii(0x66c3, 3);    mov(memw[ds, 0x11da], ax);                /* mov [0x11da], ax */
            ii(0x66c6, 1);    leave();                                  /* leave */
            ii(0x66c7, 1);    ret();                                    /* ret */
        }
    }
}
