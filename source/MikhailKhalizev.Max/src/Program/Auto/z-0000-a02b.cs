using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xa02b-3133deca")]
        public void Method_0000_a02b()
        {
            ii(0xa02b, 3);    call(0x49ad, -0x5681);                    /* call 0x49ad */
            ii(0xa02e, 4);    mov(memb[ds, 0x35], cl);                  /* mov [0x35], cl */
            ii(0xa032, 4);    mov(memb[ds, 0x37], cl);                  /* mov [0x37], cl */
            ii(0xa036, 3);    call(0x6d43, -0x32f6);                    /* call 0x6d43 */
            ii(0xa039, 5);    cmp(memb[ds, 0x2e], 0);                   /* cmp byte [0x2e], 0x0 */
            ii(0xa03e, 2);    if(jz(0xa063, 0x23)) goto l_0xa063;       /* jz 0xa063 */
            ii(0xa040, 3);    call(0x573a, -0x4909);                    /* call 0x573a */
            ii(0xa043, 5);    cmp(memb[ds, 0x2e], 0xa);                 /* cmp byte [0x2e], 0xa */
            ii(0xa048, 2);    if(jnz(0xa04d, 3)) goto l_0xa04d;         /* jnz 0xa04d */
            ii(0xa04a, 3);    call(0xa257, 0x20a);                      /* call 0xa257 */
        l_0xa04d:
            ii(0xa04d, 5);    cmp(memb[ds, 0x2e], 9);                   /* cmp byte [0x2e], 0x9 */
            ii(0xa052, 2);    if(jnz(0xa057, 3)) goto l_0xa057;         /* jnz 0xa057 */
            ii(0xa054, 3);    call(0xa1bd, 0x166);                      /* call 0xa1bd */
        l_0xa057:
            ii(0xa057, 3);    call(0x3f0c, -0x614e);                    /* call 0x3f0c */
            ii(0xa05a, 3);    call(0xa346, 0x2e9);                      /* call 0xa346 */
            ii(0xa05d, 6);    mov(memw[ds, 0xac2], 0x32);               /* mov word [0xac2], 0x32 */
        l_0xa063:
            ii(0xa063, 3);    push(0xf8a);                              /* push 0xf8a */
            ii(0xa066, 3);    call(0x5020, -0x5049);                    /* call 0x5020 */
            ii(0xa069, 1);    pop(cx);                                  /* pop cx */
            ii(0xa06a, 4);    mov(es, memw[ds, 0xcec]);                 /* mov es, [0xcec] */
            ii(0xa06e, 3);    mov(bx, 0xa);                             /* mov bx, 0xa */
            ii(0xa071, 3);    mov(ax, memw[es, bx]);                    /* mov ax, [es:bx] */
            ii(0xa074, 3);    mov(memw[ds, 0x10c2], ax);                /* mov [0x10c2], ax */
            ii(0xa077, 4);    mov(ax, memw[es, bx + 2]);                /* mov ax, [es:bx+0x2] */
            ii(0xa07b, 3);    mov(memw[ds, 0x10c4], ax);                /* mov [0x10c4], ax */
            ii(0xa07e, 4);    mov(memw[ds, 0xf50], sp);                 /* mov [0xf50], sp */
            ii(0xa082, 5);    cmp(memb[ds, 0x2e], 0);                   /* cmp byte [0x2e], 0x0 */
            ii(0xa087, 2);    if(jz(0xa095, 0xc)) goto l_0xa095;        /* jz 0xa095 */
            ii(0xa089, 5);    mov(memw[es, bx], 0x10);                  /* mov word [es:bx], 0x10 */
            ii(0xa08e, 4);    mov(memw[es, bx + 2], cs);                /* mov [es:bx+0x2], cs */
            ii(0xa092, 3);    if(jmp_func(0x3ff1, -0x60a4)) return;     /* jmp 0x3ff1 */
        l_0xa095:
            ii(0xa095, 3);    call(0xb030, 0xf98);                      /* call 0xb030 */
            ii(0xa098, 1);    pusha();                                  /* pusha */
            ii(0xa099, 1);    push(ds);                                 /* push ds */
            ii(0xa09a, 3);    mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0xa09d, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0xa09f, 3);    mov(si, 0x2f6);                           /* mov si, 0x2f6 */
            ii(0xa0a2, 1);    std();                                    /* std */
        l_0xa0a3:
            ii(0xa0a3, 2);    mov(bx, si);                              /* mov bx, si */
            ii(0xa0a5, 1);    lodsw();                                  /* lodsw */
            ii(0xa0a6, 2);    mov(dx, ax);                              /* mov dx, ax */
            ii(0xa0a8, 1);    lodsw();                                  /* lodsw */
        l_0xa0a9:
            ii(0xa0a9, 4);    cmp(bx, 0x2fa);                           /* cmp bx, 0x2fa */
            ii(0xa0ad, 2);    if(jae(0xa0a3, -0xc)) goto l_0xa0a3;      /* jae 0xa0a3 */
            ii(0xa0af, 1);    inc(bx);                                  /* inc bx */
            ii(0xa0b0, 1);    inc(bx);                                  /* inc bx */
            ii(0xa0b1, 2);    cmp(memw[ds, bx], ax);                    /* cmp [bx], ax */
            ii(0xa0b3, 1);    pushfw();                                 /* pushfw */
            ii(0xa0b4, 1);    inc(bx);                                  /* inc bx */
            ii(0xa0b5, 1);    inc(bx);                                  /* inc bx */
            ii(0xa0b6, 1);    popfw();                                  /* popfw */
            ii(0xa0b7, 2);    if(jnz(0xa0a9, -0x10)) goto l_0xa0a9;     /* jnz 0xa0a9 */
            ii(0xa0b9, 2);    cmp(memw[ds, bx], dx);                    /* cmp [bx], dx */
            ii(0xa0bb, 2);    if(jnz(0xa0a9, -0x14)) goto l_0xa0a9;     /* jnz 0xa0a9 */
            ii(0xa0bd, 1);    pop(ds);                                  /* pop ds */
            ii(0xa0be, 3);    mov(memw[ds, 0x56], ax);                  /* mov [0x56], ax */
            ii(0xa0c1, 4);    mov(memw[ds, 0x58], dx);                  /* mov [0x58], dx */
            ii(0xa0c5, 1);    popa();                                   /* popa */
            ii(0xa0c6, 1);    cld();                                    /* cld */
            ii(0xa0c7, 1);    ret();                                    /* ret */
        }
    }
}
