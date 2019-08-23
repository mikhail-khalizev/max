using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x3e08-7f8ab8ab")]
        public void Method_0000_3e08()
        {
            ii(0x3e08, 1);    cld();                                    /* cld */
            ii(0x3e09, 1);    push(ss);                                 /* push ss */
            ii(0x3e0a, 1);    pop(ds);                                  /* pop ds */
            ii(0x3e0b, 4);    inc(memb[ds, 0x9f8]);                     /* inc byte [0x9f8] */
            ii(0x3e0f, 2);    if(jnz(0x3e72, 0x61)) goto l_0x3e72;      /* jnz 0x3e72 */
            ii(0x3e11, 3);    push(0xf8a);                              /* push 0xf8a */
            ii(0x3e14, 3);    call(0x5038, 0x1221);                     /* call 0x5038 */
            ii(0x3e17, 1);    pop(cx);                                  /* pop cx */
            ii(0x3e18, 1);    push(es);                                 /* push es */
            ii(0x3e19, 2);    xor(di, di);                              /* xor di, di */
            ii(0x3e1b, 3);    mov(cx, 0x200);                           /* mov cx, 0x200 */
            ii(0x3e1e, 2);    mov(ax, cs);                              /* mov ax, cs */
            ii(0x3e20, 4);    mov(bx, memw[ds, 0x56]);                  /* mov bx, [0x56] */
            ii(0x3e24, 4);    mov(dx, memw[ds, 0x58]);                  /* mov dx, [0x58] */
        l_0x3e28:
            ii(0x3e28, 2);    if(jcxz(0x3e4e, 0x24)) goto l_0x3e4e;     /* jcxz 0x3e4e */
            ii(0x3e2a, 2);    repne(() => scasw());                     /* repne scasw */
            ii(0x3e2c, 2);    if(jnz(0x3e4e, 0x20)) goto l_0x3e4e;      /* jnz 0x3e4e */
            ii(0x3e2e, 4);    test(di, 0x2);                            /* test di, 0x2 */
            ii(0x3e32, 2);    if(jnz(0x3e28, -0xc)) goto l_0x3e28;      /* jnz 0x3e28 */
            ii(0x3e34, 6);    cmp(memw[es, di - 0x4], 0x12cc);          /* cmp word [es:di-0x4], 0x12cc */
            ii(0x3e3a, 2);    if(jz(0x3e28, -0x14)) goto l_0x3e28;      /* jz 0x3e28 */
            ii(0x3e3c, 6);    cmp(memw[es, di - 0x4], 0x14d8);          /* cmp word [es:di-0x4], 0x14d8 */
            ii(0x3e42, 2);    if(jz(0x3e28, -0x1c)) goto l_0x3e28;      /* jz 0x3e28 */
            ii(0x3e44, 4);    mov(memw[es, di - 0x4], bx);              /* mov [es:di-0x4], bx */
            ii(0x3e48, 4);    mov(memw[es, di - 0x2], dx);              /* mov [es:di-0x2], dx */
            ii(0x3e4c, 2);    jmp(0x3e28, -0x26); goto l_0x3e28;        /* jmp 0x3e28 */
        l_0x3e4e:
            ii(0x3e4e, 1);    pop(es);                                  /* pop es */
            ii(0x3e4f, 5);    cmp(memb[ds, 0xcda], 0);                  /* cmp byte [0xcda], 0x0 */
            ii(0x3e54, 2);    if(jnz(0x3e5d, 0x7)) goto l_0x3e5d;       /* jnz 0x3e5d */
            ii(0x3e56, 4);    inc(memb[ds, 0xcda]);                     /* inc byte [0xcda] */
            ii(0x3e5a, 3);    call(0x51e1, 0x1384);                     /* call 0x51e1 */
        l_0x3e5d:
            ii(0x3e5d, 5);    cmp(memw[ds, 0xa14], 0);                  /* cmp word [0xa14], 0x0 */
            ii(0x3e62, 2);    if(jz(0x3e67, 0x3)) goto l_0x3e67;        /* jz 0x3e67 */
            ii(0x3e64, 3);    call(0x5464, 0x15fd);                     /* call 0x5464 */
        l_0x3e67:
            ii(0x3e67, 1);    cli();                                    /* cli */
            ii(0x3e68, 3);    call(0x3f0c, 0xa1);                       /* call 0x3f0c */
            ii(0x3e6b, 1);    sti();                                    /* sti */
            ii(0x3e6c, 3);    call(0x58aa, 0x1a3b);                     /* call 0x58aa */
            ii(0x3e6f, 3);    call(0x514d, 0x12db);                     /* call 0x514d */
        l_0x3e72:
            ii(0x3e72, 5);    cmp(memb[ds, 0x2e], 0xb);                 /* cmp byte [0x2e], 0xb */
            ii(0x3e77, 2);    if(jnz(0x3e7e, 0x5)) goto l_0x3e7e;       /* jnz 0x3e7e */
            ii(0x3e79, 3);    call(0x6993, 0x2b17);                     /* call 0x6993 */
            ii(0x3e7c, 2);    jmp(0x3eb2, 0x34); goto l_0x3eb2;         /* jmp 0x3eb2 */
        l_0x3e7e:
            ii(0x3e7e, 5);    test(memb[ds, 0x47], 0x80);               /* test byte [0x47], 0x80 */
            ii(0x3e83, 2);    if(jz(0x3e98, 0x13)) goto l_0x3e98;       /* jz 0x3e98 */
            ii(0x3e85, 3);    mov(ax, 0xbfde);                          /* mov ax, 0xbfde */
            ii(0x3e88, 3);    mov(bx, 0xa);                             /* mov bx, 0xa */
            ii(0x3e8b, 3);    call(0x4c94, 0xe06);                      /* call 0x4c94 */
            ii(0x3e8e, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x3e90, 2);    if(jl(0x3e98, 0x6)) goto l_0x3e98;        /* jl 0x3e98 */
            ii(0x3e92, 6);    mov(memw[ds, 0xadc], 0);                  /* mov word [0xadc], 0x0 */
        l_0x3e98:
            ii(0x3e98, 5);    cmp(memb[ds, 0x2e], 0x2);                 /* cmp byte [0x2e], 0x2 */
            ii(0x3e9d, 2);    if(jle(0x3eb2, 0x13)) goto l_0x3eb2;      /* jle 0x3eb2 */
            ii(0x3e9f, 5);    test(memb[ds, 0x47], 0x1);                /* test byte [0x47], 0x1 */
            ii(0x3ea4, 2);    if(jz(0x3eb2, 0xc)) goto l_0x3eb2;        /* jz 0x3eb2 */
            ii(0x3ea6, 1);    cli();                                    /* cli */
            ii(0x3ea7, 2);    mov(al, 0xf);                             /* mov al, 0xf */
            ii(0x3ea9, 2);    outb(0x70, al);                           /* out 0x70, al */
            ii(0x3eab, 2);    jmp(0x3ead, 0); goto l_0x3ead;            /* jmp 0x3ead */
        l_0x3ead:
            ii(0x3ead, 2);    xor(al, al);                              /* xor al, al */
            ii(0x3eaf, 2);    outb(0x71, al);                           /* out 0x71, al */
            ii(0x3eb1, 1);    sti();                                    /* sti */
        l_0x3eb2:
            ii(0x3eb2, 3);    call(0x5b97, 0x1ce2);                     /* call 0x5b97 */
            ii(0x3eb5, 4);    mov(es, memw[ds, 0xcec]);                 /* mov es, [0xcec] */
            ii(0x3eb9, 3);    mov(ax, memw[ds, 0x9b8]);                 /* mov ax, [0x9b8] */
            ii(0x3ebc, 4);    mov(memw[es, 0x2c], ax);                  /* mov [es:0x2c], ax */
            ii(0x3ec0, 1);    push(es);                                 /* push es */
            ii(0x3ec1, 4);    push(memw[ds, 0x120a]);                   /* push word [0x120a] */
            ii(0x3ec5, 3);    call(0x5ab1, 0x1be9);                     /* call 0x5ab1 */
            ii(0x3ec8, 1);    pop(cx);                                  /* pop cx */
            ii(0x3ec9, 2);    xor(bx, bx);                              /* xor bx, bx */
            ii(0x3ecb, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0x3ecd, 5);    test(memb[ds, 0x47], 0x80);               /* test byte [0x47], 0x80 */
            ii(0x3ed2, 2);    if(jz(0x3edf, 0xb)) goto l_0x3edf;        /* jz 0x3edf */
            ii(0x3ed4, 3);    mov(ax, 0xbfde);                          /* mov ax, 0xbfde */
            ii(0x3ed7, 3);    mov(bx, 0x15);                            /* mov bx, 0x15 */
            ii(0x3eda, 3);    mov(cx, 0x5);                             /* mov cx, 0x5 */
            ii(0x3edd, 2);    @int(0x15);                               /* int 0x15 */
        l_0x3edf:
            ii(0x3edf, 1);    pop(es);                                  /* pop es */
            ii(0x3ee0, 7);    cmp(memw[es, 0xa], 0x10);                 /* cmp word [es:0xa], 0x10 */
            ii(0x3ee7, 2);    if(jnz(0x3f00, 0x17)) goto l_0x3f00;      /* jnz 0x3f00 */
            ii(0x3ee9, 2);    mov(ax, cs);                              /* mov ax, cs */
            ii(0x3eeb, 5);    cmp(memw[es, 0xc], ax);                   /* cmp [es:0xc], ax */
            ii(0x3ef0, 2);    if(jnz(0x3f00, 0xe)) goto l_0x3f00;       /* jnz 0x3f00 */
            ii(0x3ef2, 3);    mov(ax, memw[ds, 0x10c2]);                /* mov ax, [0x10c2] */
            ii(0x3ef5, 4);    mov(memw[es, 0xa], ax);                   /* mov [es:0xa], ax */
            ii(0x3ef9, 3);    mov(ax, memw[ds, 0x10c4]);                /* mov ax, [0x10c4] */
            ii(0x3efc, 4);    mov(memw[es, 0xc], ax);                   /* mov [es:0xc], ax */
        l_0x3f00:
            ii(0x3f00, 5);    cmp(memb[ds, 0x2f], 0x3);                 /* cmp byte [0x2f], 0x3 */
            ii(0x3f05, 2);    if(jb(0x3f0b, 0x4)) goto l_0x3f0b;        /* jb 0x3f0b */
            ii(0x3f07, 4);    mov(eax, memd[ds, 0x10f2]);               /* mov eax, [0x10f2] */
        l_0x3f0b:
            ii(0x3f0b, 1);    ret();                                    /* ret */
        }
    }
}
