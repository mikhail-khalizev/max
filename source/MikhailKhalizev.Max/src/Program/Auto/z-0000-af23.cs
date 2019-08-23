using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xaf23-6421af98")]
        public void Method_0000_af23()
        {
            ii(0xaf23, 5);    mov(memd[ds, 0xd5a], ebx);                /* mov [0xd5a], ebx */
            ii(0xaf28, 4);    cmp(di, 0x1000);                          /* cmp di, 0x1000 */
            ii(0xaf2c, 2);    if(jae(0xaf31, 0x3)) goto l_0xaf31;       /* jae 0xaf31 */
            ii(0xaf2e, 3);    mov(di, 0x1000);                          /* mov di, 0x1000 */
        l_0xaf31:
            ii(0xaf31, 4);    mov(memw[ds, 0xeca], di);                 /* mov [0xeca], di */
            ii(0xaf35, 3);    mov(al, memb[ds, 0xe00]);                 /* mov al, [0xe00] */
            ii(0xaf38, 2);    or(al, al);                               /* or al, al */
            ii(0xaf3a, 4);    if(jz(0xafbd, 0x7f)) goto l_0xafbd;       /* jz 0xafbd */
            ii(0xaf3e, 1);    xchg(di, ax);                             /* xchg di, ax */
            ii(0xaf3f, 5);    cmp(memb[ds, 0xdff], 0);                  /* cmp byte [0xdff], 0x0 */
            ii(0xaf44, 2);    if(jz(0xaf4c, 0x6)) goto l_0xaf4c;        /* jz 0xaf4c */
            ii(0xaf46, 3);    mov(ax, 0x1040);                          /* mov ax, 0x1040 */
            ii(0xaf49, 3);    mov(memw[ds, 0xeca], ax);                 /* mov [0xeca], ax */
        l_0xaf4c:
            ii(0xaf4c, 3);    mov(bx, 0x40);                            /* mov bx, 0x40 */
            ii(0xaf4f, 2);    mul(bx);                                  /* mul bx */
            ii(0xaf51, 3);    mov(memw[ds, 0xac], ax);                  /* mov [0xac], ax */
            ii(0xaf54, 4);    mov(memw[ds, 0xae], dx);                  /* mov [0xae], dx */
            ii(0xaf58, 3);    mov(ax, memw[ds, 0xece]);                 /* mov ax, [0xece] */
            ii(0xaf5b, 4);    add(ax, memw[ds, 0xeca]);                 /* add ax, [0xeca] */
            ii(0xaf5f, 5);    cmp(memb[ds, 0xdff], 0);                  /* cmp byte [0xdff], 0x0 */
            ii(0xaf64, 2);    if(jnz(0xaf6e, 0x8)) goto l_0xaf6e;       /* jnz 0xaf6e */
            ii(0xaf66, 3);    cmp(ax, 0x4000);                          /* cmp ax, 0x4000 */
            ii(0xaf69, 2);    if(jb(0xaf6e, 0x3)) goto l_0xaf6e;        /* jb 0xaf6e */
            ii(0xaf6b, 3);    mov(ax, 0x4000);                          /* mov ax, 0x4000 */
        l_0xaf6e:
            ii(0xaf6e, 3);    mov(memw[ds, 0xece], ax);                 /* mov [0xece], ax */
            ii(0xaf71, 5);    test(memb[ds, 0x47], 0x1);                /* test byte [0x47], 0x1 */
            ii(0xaf76, 2);    if(jz(0xaf7d, 0x5)) goto l_0xaf7d;        /* jz 0xaf7d */
            ii(0xaf78, 2);    mov(ah, 0x88);                            /* mov ah, 0x88 */
            ii(0xaf7a, 3);    call(0x44e4, -0x6a99);                    /* call 0x44e4 */
        l_0xaf7d:
            ii(0xaf7d, 3);    mov(memw[ds, 0xa8], ax);                  /* mov [0xa8], ax */
            ii(0xaf80, 3);    call(0xb1a6, 0x223);                      /* call 0xb1a6 */
            ii(0xaf83, 4);    mov(cl, memb[ds, 0xe00]);                 /* mov cl, [0xe00] */
            ii(0xaf87, 2);    xor(ch, ch);                              /* xor ch, ch */
            ii(0xaf89, 3);    shr(cx, 0x3);                             /* shr cx, 0x3 */
            ii(0xaf8c, 1);    dec(cx);                                  /* dec cx */
            ii(0xaf8d, 1);    dec(cx);                                  /* dec cx */
            ii(0xaf8e, 2);    mov(si, es);                              /* mov si, es */
            ii(0xaf90, 2);    mov(ds, si);                              /* mov ds, si */
            ii(0xaf92, 4);    sub(si, 0x100);                           /* sub si, 0x100 */
            ii(0xaf96, 2);    mov(es, si);                              /* mov es, si */
            ii(0xaf98, 3);    shr(si, 0x6);                             /* shr si, 0x6 */
            ii(0xaf9b, 2);    lodsd();                                  /* lodsd */
            ii(0xaf9d, 2);    xor(di, di);                              /* xor di, di */
            ii(0xaf9f, 2);    rep(() => movsw());                       /* rep movsw */
            ii(0xafa1, 1);    push(ss);                                 /* push ss */
            ii(0xafa2, 1);    pop(ds);                                  /* pop ds */
        l_0xafa3:
            ii(0xafa3, 4);    mov(memd[ds, 0xd38], eax);                /* mov [0xd38], eax */
            ii(0xafa7, 4);    mov(memd[ds, 0xd90], eax);                /* mov [0xd90], eax */
            ii(0xafab, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0xafae, 6);    mov(memw[ds, 0xaa4], 0x3d15);             /* mov word [0xaa4], 0x3d15 */
            ii(0xafb4, 6);    mov(memw[ds, 0xaa6], 0x3d68);             /* mov word [0xaa6], 0x3d68 */
            ii(0xafba, 1);    pop(di);                                  /* pop di */
            ii(0xafbb, 1);    pop(si);                                  /* pop si */
            ii(0xafbc, 1);    ret(); return;                            /* ret */
        l_0xafbd:
            ii(0xafbd, 4);    mov(eax, memd[ds, 0x98]);                 /* mov eax, [0x98] */
            ii(0xafc1, 4);    shr(eax, 0x6);                            /* shr eax, 0x6 */
            ii(0xafc5, 3);    mov(memw[ds, 0xeca], ax);                 /* mov [0xeca], ax */
            ii(0xafc8, 4);    mov(eax, memd[ds, 0x9c]);                 /* mov eax, [0x9c] */
            ii(0xafcc, 4);    shr(eax, 0x6);                            /* shr eax, 0x6 */
            ii(0xafd0, 3);    mov(memw[ds, 0xece], ax);                 /* mov [0xece], ax */
            ii(0xafd3, 4);    mov(cx, memw[ds, 0xaa]);                  /* mov cx, [0xaa] */
            ii(0xafd7, 2);    mov(si, cx);                              /* mov si, cx */
            ii(0xafd9, 3);    shr(si, 0x6);                             /* shr si, 0x6 */
            ii(0xafdc, 2);    inc(ch);                                  /* inc ch */
            ii(0xafde, 2);    mov(es, cx);                              /* mov es, cx */
            ii(0xafe0, 4);    mov(eax, memd[es, si]);                   /* mov eax, [es:si] */
            ii(0xafe4, 2);    jmp(0xafa3, -0x43); goto l_0xafa3;        /* jmp 0xafa3 */
        }
    }
}
