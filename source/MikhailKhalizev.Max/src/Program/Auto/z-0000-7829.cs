using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7829-dc98fec5")]
        public void Method_0000_7829()
        {
            ii(0x7829, 4);    enter(2, 0);                              /* enter 0x2, 0x0 */
            ii(0x782d, 1);    push(di);                                 /* push di */
            ii(0x782e, 1);    push(si);                                 /* push si */
            ii(0x782f, 3);    mov(ax, memw[ss, bp + 8]);                /* mov ax, [bp+0x8] */
            ii(0x7832, 2);    neg(ax);                                  /* neg ax */
            ii(0x7834, 3);    and(ax, 0xf);                             /* and ax, 0xf */
            ii(0x7837, 3);    mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
        l_0x783a:
            ii(0x783a, 4);    mov(di, memw[ds, 0x1208]);                /* mov di, [0x1208] */
            ii(0x783e, 4);    sub(di, memw[ds, 0x11d0]);                /* sub di, [0x11d0] */
            ii(0x7842, 2);    if(jnz(0x7847, 3)) goto l_0x7847;         /* jnz 0x7847 */
            ii(0x7844, 3);    call(0x77b3, -0x94);                      /* call 0x77b3 */
        l_0x7847:
            ii(0x7847, 4);    mov(di, memw[ds, 0x1208]);                /* mov di, [0x1208] */
            ii(0x784b, 4);    sub(di, memw[ds, 0x11d0]);                /* sub di, [0x11d0] */
            ii(0x784f, 2);    if(jnz(0x7873, 0x22)) goto l_0x7873;      /* jnz 0x7873 */
            ii(0x7851, 4);    cmp(memw[ss, bp + 6], 0);                 /* cmp word [bp+0x6], 0x0 */
            ii(0x7855, 2);    if(jz(0x786a, 0x13)) goto l_0x786a;       /* jz 0x786a */
            ii(0x7857, 2);    push(0);                                  /* push 0x0 */
            ii(0x7859, 3);    push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x785c, 3);    push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x785f, 3);    push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x7862, 3);    call(0x5c17, -0x1c4e);                    /* call 0x5c17 */
            ii(0x7865, 3);    add(sp, 8);                               /* add sp, 0x8 */
            ii(0x7868, 2);    jmp(0x78bd, 0x53); goto l_0x78bd;         /* jmp 0x78bd */
        l_0x786a:
            ii(0x786a, 3);    call(0x4f61, -0x290c);                    /* call 0x4f61 */
            ii(0x786d, 2);    push(-0xe /* 0xf2 */);                    /* push 0xfff2 */
            ii(0x786f, 3);    call(0x604d, -0x1825);                    /* call 0x604d */
            ii(0x7872, 1);    pop(bx);                                  /* pop bx */
        l_0x7873:
            ii(0x7873, 3);    mov(si, memw[ss, bp + 8]);                /* mov si, [bp+0x8] */
            ii(0x7876, 2);    cmp(si, di);                              /* cmp si, di */
            ii(0x7878, 2);    if(ja(0x787e, 4)) goto l_0x787e;          /* ja 0x787e */
            ii(0x787a, 2);    or(si, si);                               /* or si, si */
            ii(0x787c, 2);    if(jnz(0x7880, 2)) goto l_0x7880;         /* jnz 0x7880 */
        l_0x787e:
            ii(0x787e, 2);    mov(si, di);                              /* mov si, di */
        l_0x7880:
            ii(0x7880, 1);    push(si);                                 /* push si */
            ii(0x7881, 3);    push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x7884, 3);    push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x7887, 4);    push(memw[ds, 0x11d0]);                   /* push word [0x11d0] */
            ii(0x788b, 2);    push(0x20);                               /* push 0x20 */
            ii(0x788d, 3);    call(0x9ea2, 0x2612);                     /* call 0x9ea2 */
            ii(0x7890, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x7893, 3);    add(memw[ss, bp + 6], si);                /* add [bp+0x6], si */
            ii(0x7896, 4);    add(memw[ds, 0x11d0], si);                /* add [0x11d0], si */
            ii(0x789a, 3);    sub(memw[ss, bp + 8], si);                /* sub [bp+0x8], si */
            ii(0x789d, 2);    if(jnz(0x783a, -0x65)) goto l_0x783a;     /* jnz 0x783a */
            ii(0x789f, 2);    jmp(0x78a8, 7); goto l_0x78a8;            /* jmp 0x78a8 */
        l_0x78a1:
            ii(0x78a1, 3);    call(0x77b3, -0xf1);                      /* call 0x77b3 */
            ii(0x78a4, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x78a6, 2);    if(jz(0x78bd, 0x15)) goto l_0x78bd;       /* jz 0x78bd */
        l_0x78a8:
            ii(0x78a8, 3);    mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x78ab, 4);    add(memw[ds, 0x11d0], ax);                /* add [0x11d0], ax */
            ii(0x78af, 3);    mov(ax, memw[ds, 0x11d0]);                /* mov ax, [0x11d0] */
            ii(0x78b2, 4);    sub(ax, memw[ds, 0x1208]);                /* sub ax, [0x1208] */
            ii(0x78b6, 3);    mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x78b9, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x78bb, 2);    if(jg(0x78a1, -0x1c)) goto l_0x78a1;      /* jg 0x78a1 */
        l_0x78bd:
            ii(0x78bd, 1);    pop(si);                                  /* pop si */
            ii(0x78be, 1);    pop(di);                                  /* pop di */
            ii(0x78bf, 1);    leave();                                  /* leave */
            ii(0x78c0, 1);    ret();                                    /* ret */
        }
    }
}
