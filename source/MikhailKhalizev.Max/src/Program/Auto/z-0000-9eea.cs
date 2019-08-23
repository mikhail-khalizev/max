using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9eea-919acae4")]
        public void Method_0000_9eea()
        {
            ii(0x9eea, 1);    push(bp);                                 /* push bp */
            ii(0x9eeb, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x9eed, 3);    sub(sp, 0x2);                             /* sub sp, 0x2 */
            ii(0x9ef0, 1);    push(si);                                 /* push si */
            ii(0x9ef1, 1);    push(di);                                 /* push di */
            ii(0x9ef2, 1);    push(ds);                                 /* push ds */
            ii(0x9ef3, 1);    pop(es);                                  /* pop es */
            ii(0x9ef4, 3);    mov(di, memw[ss, bp + 0x6]);              /* mov di, [bp+0x6] */
            ii(0x9ef7, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x9ef9, 3);    mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x9efc, 2);    repne(() => scasb());                     /* repne scasb */
            ii(0x9efe, 2);    not(cx);                                  /* not cx */
            ii(0x9f00, 1);    dec(cx);                                  /* dec cx */
            ii(0x9f01, 2);    if(jcxz(0x9f3d, 0x3a)) goto l_0x9f3d;     /* jcxz 0x9f3d */
            ii(0x9f03, 1);    dec(cx);                                  /* dec cx */
            ii(0x9f04, 3);    mov(memw[ss, bp - 0x2], cx);              /* mov [bp-0x2], cx */
            ii(0x9f07, 3);    mov(di, memw[ss, bp + 0x4]);              /* mov di, [bp+0x4] */
            ii(0x9f0a, 2);    mov(bx, di);                              /* mov bx, di */
            ii(0x9f0c, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x9f0e, 3);    mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x9f11, 2);    repne(() => scasb());                     /* repne scasb */
            ii(0x9f13, 2);    not(cx);                                  /* not cx */
            ii(0x9f15, 1);    dec(cx);                                  /* dec cx */
            ii(0x9f16, 2);    mov(dx, cx);                              /* mov dx, cx */
            ii(0x9f18, 3);    sub(dx, memw[ss, bp - 0x2]);              /* sub dx, [bp-0x2] */
            ii(0x9f1b, 2);    if(jbe(0x9f42, 0x25)) goto l_0x9f42;      /* jbe 0x9f42 */
            ii(0x9f1d, 2);    mov(di, bx);                              /* mov di, bx */
        l_0x9f1f:
            ii(0x9f1f, 3);    mov(si, memw[ss, bp + 0x6]);              /* mov si, [bp+0x6] */
            ii(0x9f22, 1);    lodsb();                                  /* lodsb */
            ii(0x9f23, 2);    mov(di, bx);                              /* mov di, bx */
            ii(0x9f25, 2);    mov(cx, dx);                              /* mov cx, dx */
            ii(0x9f27, 2);    repne(() => scasb());                     /* repne scasb */
            ii(0x9f29, 2);    if(jnz(0x9f42, 0x17)) goto l_0x9f42;      /* jnz 0x9f42 */
            ii(0x9f2b, 2);    mov(dx, cx);                              /* mov dx, cx */
            ii(0x9f2d, 2);    mov(bx, di);                              /* mov bx, di */
            ii(0x9f2f, 3);    mov(cx, memw[ss, bp - 0x2]);              /* mov cx, [bp-0x2] */
            ii(0x9f32, 2);    if(jcxz(0x9f38, 0x4)) goto l_0x9f38;      /* jcxz 0x9f38 */
            ii(0x9f34, 2);    repe(() => cmpsb());                      /* repe cmpsb */
            ii(0x9f36, 2);    if(jnz(0x9f1f, -0x19)) goto l_0x9f1f;     /* jnz 0x9f1f */
        l_0x9f38:
            ii(0x9f38, 3);    lea(ax, bx - 0x1);                        /* lea ax, [bx-0x1] */
            ii(0x9f3b, 2);    jmp(0x9f44, 0x7); goto l_0x9f44;          /* jmp 0x9f44 */
        l_0x9f3d:
            ii(0x9f3d, 3);    mov(ax, memw[ss, bp + 0x4]);              /* mov ax, [bp+0x4] */
            ii(0x9f40, 2);    jmp(0x9f44, 0x2); goto l_0x9f44;          /* jmp 0x9f44 */
        l_0x9f42:
            ii(0x9f42, 2);    xor(ax, ax);                              /* xor ax, ax */
        l_0x9f44:
            ii(0x9f44, 1);    pop(di);                                  /* pop di */
            ii(0x9f45, 1);    pop(si);                                  /* pop si */
            ii(0x9f46, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x9f48, 1);    pop(bp);                                  /* pop bp */
            ii(0x9f49, 1);    ret();                                    /* ret */
        }
    }
}
