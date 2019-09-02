using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x91cb-d71eac04")]
        public void Method_0000_91cb()
        {
            ii(0x91cb, 1);    push(bp);                                 /* push bp */
            ii(0x91cc, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x91ce, 3);    sub(sp, 0x42);                            /* sub sp, 0x42 */
            ii(0x91d1, 1);    push(di);                                 /* push di */
            ii(0x91d2, 1);    push(si);                                 /* push si */
        l_0x91d3:
            ii(0x91d3, 3);    call(0x90c6, -0x110);                     /* call 0x90c6 */
            ii(0x91d6, 1);    inc(ax);                                  /* inc ax */
            ii(0x91d7, 2);    if(jz(0x921a, 0x41)) goto l_0x921a;       /* jz 0x921a */
            ii(0x91d9, 3);    sub(ax, 0x3c);                            /* sub ax, 0x3c */
            ii(0x91dc, 2);    if(jnz(0x91e1, 3)) goto l_0x91e1;         /* jnz 0x91e1 */
            ii(0x91de, 3);    jmp(0x9262, 0x81); goto l_0x9262;         /* jmp 0x9262 */
        l_0x91e1:
            ii(0x91e1, 3);    sub(ax, 0xa);                             /* sub ax, 0xa */
            ii(0x91e4, 2);    if(jz(0x91ed, 7)) goto l_0x91ed;          /* jz 0x91ed */
            ii(0x91e6, 3);    sub(ax, 0xd);                             /* sub ax, 0xd */
        l_0x91e9:
            ii(0x91e9, 2);    if(jz(0x91f5, 0xa)) goto l_0x91f5;        /* jz 0x91f5 */
            ii(0x91eb, 2);    jmp(0x91d3, -0x1a); goto l_0x91d3;        /* jmp 0x91d3 */
        l_0x91ed:
            ii(0x91ed, 3);    call(0x90c6, -0x12a);                     /* call 0x90c6 */
            ii(0x91f0, 3);    cmp(ax, 0x52);                            /* cmp ax, 0x52 */
            ii(0x91f3, 2);    jmp(0x91e9, -0xc); goto l_0x91e9;         /* jmp 0x91e9 */
        l_0x91f5:
            ii(0x91f5, 3);    mov(ax, 0xf24);                           /* mov ax, 0xf24 */
            ii(0x91f8, 1);    push(ax);                                 /* push ax */
            ii(0x91f9, 3);    call(0x919b, -0x61);                      /* call 0x919b */
            ii(0x91fc, 1);    pop(bx);                                  /* pop bx */
            ii(0x91fd, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x91ff, 2);    if(jz(0x91d3, -0x2e)) goto l_0x91d3;      /* jz 0x91d3 */
        l_0x9201:
            ii(0x9201, 3);    call(0x9141, -0xc3);                      /* call 0x9141 */
            ii(0x9204, 2);    mov(si, ax);                              /* mov si, ax */
            ii(0x9206, 3);    cmp(si, memw[ss, bp + 4]);                /* cmp si, [bp+0x4] */
            ii(0x9209, 2);    if(jz(0x9210, 5)) goto l_0x9210;          /* jz 0x9210 */
            ii(0x920b, 3);    cmp(si, -3 /* 0xfd */);                   /* cmp si, 0xfffd */
            ii(0x920e, 2);    if(jnz(0x9215, 5)) goto l_0x9215;         /* jnz 0x9215 */
        l_0x9210:
            ii(0x9210, 3);    mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x9213, 2);    jmp(0x9275, 0x60); goto l_0x9275;         /* jmp 0x9275 */
        l_0x9215:
            ii(0x9215, 3);    cmp(si, -1 /* 0xff */);                   /* cmp si, 0xffff */
            ii(0x9218, 2);    if(jnz(0x921e, 4)) goto l_0x921e;         /* jnz 0x921e */
        l_0x921a:
            ii(0x921a, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x921c, 2);    jmp(0x9275, 0x57); goto l_0x9275;         /* jmp 0x9275 */
        l_0x921e:
            ii(0x921e, 3);    cmp(si, 0x3b);                            /* cmp si, 0x3b */
            ii(0x9221, 2);    if(jz(0x9262, 0x3f)) goto l_0x9262;       /* jz 0x9262 */
            ii(0x9223, 3);    cmp(si, -4 /* 0xfc */);                   /* cmp si, 0xfffc */
            ii(0x9226, 2);    if(jnz(0x925a, 0x32)) goto l_0x925a;      /* jnz 0x925a */
            ii(0x9228, 3);    lea(di, memw[ss, bp - 0x42]);             /* lea di, [bp-0x42] */
            ii(0x922b, 2);    jmp(0x922e, 1); goto l_0x922e;            /* jmp 0x922e */
        l_0x922d:
            ii(0x922d, 1);    inc(di);                                  /* inc di */
        l_0x922e:
            ii(0x922e, 3);    call(0x90c6, -0x16b);                     /* call 0x90c6 */
            ii(0x9231, 2);    mov(memb[ds, di], al);                    /* mov [di], al */
            ii(0x9233, 2);    cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x9235, 2);    if(jg(0x922d, -0xa)) goto l_0x922d;       /* jg 0x922d */
            ii(0x9237, 3);    call(0x95e7, 0x3ad);                      /* call 0x95e7 */
            ii(0x923a, 4);    mov(bx, memw[ds, 0x1188]);                /* mov bx, [0x1188] */
            ii(0x923e, 5);    mov(memw[ds, bx + 2], 0);                 /* mov word [bx+0x2], 0x0 */
            ii(0x9243, 3);    mov(memb[ds, di], 0);                     /* mov byte [di], 0x0 */
            ii(0x9246, 3);    lea(ax, memw[ss, bp - 0x42]);             /* lea ax, [bp-0x42] */
            ii(0x9249, 1);    push(ax);                                 /* push ax */
            ii(0x924a, 3);    call(0x95a8, 0x35b);                      /* call 0x95a8 */
            ii(0x924d, 1);    pop(bx);                                  /* pop bx */
            ii(0x924e, 5);    cmp(memw[ds, 0xe70], 0);                  /* cmp word [0xe70], 0x0 */
            ii(0x9253, 2);    if(jl(0x9258, 3)) goto l_0x9258;          /* jl 0x9258 */
            ii(0x9255, 3);    jmp(0x91d3, -0x85); goto l_0x91d3;        /* jmp 0x91d3 */
        l_0x9258:
            ii(0x9258, 2);    jmp(0x921a, -0x40); goto l_0x921a;        /* jmp 0x921a */
        l_0x925a:
            ii(0x925a, 3);    cmp(si, -2 /* 0xfe */);                   /* cmp si, 0xfffe */
            ii(0x925d, 2);    if(jnz(0x9201, -0x5e)) goto l_0x9201;     /* jnz 0x9201 */
            ii(0x925f, 3);    jmp(0x91d3, -0x8f); goto l_0x91d3;        /* jmp 0x91d3 */
        l_0x9262:
            ii(0x9262, 3);    call(0x90c6, -0x19f);                     /* call 0x90c6 */
            ii(0x9265, 2);    mov(si, ax);                              /* mov si, ax */
            ii(0x9267, 3);    cmp(si, 0xa);                             /* cmp si, 0xa */
            ii(0x926a, 2);    if(jnz(0x926f, 3)) goto l_0x926f;         /* jnz 0x926f */
            ii(0x926c, 3);    jmp(0x91d3, -0x9c); goto l_0x91d3;        /* jmp 0x91d3 */
        l_0x926f:
            ii(0x926f, 2);    or(si, si);                               /* or si, si */
            ii(0x9271, 2);    if(jge(0x9262, -0x11)) goto l_0x9262;     /* jge 0x9262 */
            ii(0x9273, 2);    jmp(0x921a, -0x5b); goto l_0x921a;        /* jmp 0x921a */
        l_0x9275:
            ii(0x9275, 1);    pop(si);                                  /* pop si */
            ii(0x9276, 1);    pop(di);                                  /* pop di */
            ii(0x9277, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x9279, 1);    pop(bp);                                  /* pop bp */
            ii(0x927a, 1);    ret();                                    /* ret */
        }
    }
}
