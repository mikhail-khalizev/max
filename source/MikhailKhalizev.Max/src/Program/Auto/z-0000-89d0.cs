using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x89d0-70e44246")]
        public void Method_0000_89d0()
        {
            ii(0x89d0, 4);    enter(0x28, 0);                           /* enter 0x28, 0x0 */
            ii(0x89d4, 1);    push(di);                                 /* push di */
            ii(0x89d5, 1);    push(si);                                 /* push si */
            ii(0x89d6, 3);    mov(ax, memw[ds, 0x98]);                  /* mov ax, [0x98] */
            ii(0x89d9, 4);    mov(dx, memw[ds, 0x9a]);                  /* mov dx, [0x9a] */
            ii(0x89dd, 4);    cmp(memw[ds, 0x9e], dx);                  /* cmp [0x9e], dx */
            ii(0x89e1, 2);    if(jae(0x89e6, 0x3)) goto l_0x89e6;       /* jae 0x89e6 */
            ii(0x89e3, 3);    jmp(0x8a6c, 0x86); goto l_0x8a6c;         /* jmp 0x8a6c */
        l_0x89e6:
            ii(0x89e6, 2);    if(ja(0x89ee, 0x6)) goto l_0x89ee;        /* ja 0x89ee */
            ii(0x89e8, 4);    cmp(memw[ds, 0x9c], ax);                  /* cmp [0x9c], ax */
            ii(0x89ec, 2);    if(jbe(0x89f5, 0x7)) goto l_0x89f5;       /* jbe 0x89f5 */
        l_0x89ee:
            ii(0x89ee, 5);    cmp(memb[ds, 0x2e], 0xb);                 /* cmp byte [0x2e], 0xb */
            ii(0x89f3, 2);    if(jnz(0x89f7, 0x2)) goto l_0x89f7;       /* jnz 0x89f7 */
        l_0x89f5:
            ii(0x89f5, 2);    jmp(0x8a6c, 0x75); goto l_0x8a6c;         /* jmp 0x8a6c */
        l_0x89f7:
            ii(0x89f7, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x89fa, 3);    mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x89fd, 1);    push(dx);                                 /* push dx */
            ii(0x89fe, 1);    push(ax);                                 /* push ax */
            ii(0x89ff, 3);    call(0x85ed, -0x415);                     /* call 0x85ed */
            ii(0x8a02, 1);    pop(bx);                                  /* pop bx */
            ii(0x8a03, 1);    pop(bx);                                  /* pop bx */
            ii(0x8a04, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x8a06, 2);    if(jz(0x8a5f, 0x57)) goto l_0x8a5f;       /* jz 0x8a5f */
        l_0x8a08:
            ii(0x8a08, 3);    mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x8a0b, 3);    mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0x8a0e, 3);    add(ax, 0x3ff);                           /* add ax, 0x3ff */
            ii(0x8a11, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x8a14, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x8a17, 3);    mov(memw[ss, bp - 0x18], dx);             /* mov [bp-0x18], dx */
            ii(0x8a1a, 4);    cmp(dx, memw[ds, 0x9e]);                  /* cmp dx, [0x9e] */
            ii(0x8a1e, 2);    if(ja(0x8a47, 0x27)) goto l_0x8a47;       /* ja 0x8a47 */
            ii(0x8a20, 2);    if(jb(0x8a28, 0x6)) goto l_0x8a28;        /* jb 0x8a28 */
            ii(0x8a22, 4);    cmp(ax, memw[ds, 0x9c]);                  /* cmp ax, [0x9c] */
            ii(0x8a26, 2);    if(jae(0x8a47, 0x1f)) goto l_0x8a47;      /* jae 0x8a47 */
        l_0x8a28:
            ii(0x8a28, 1);    push(dx);                                 /* push dx */
            ii(0x8a29, 1);    push(ax);                                 /* push ax */
            ii(0x8a2a, 3);    call(0x85ed, -0x440);                     /* call 0x85ed */
            ii(0x8a2d, 1);    pop(bx);                                  /* pop bx */
            ii(0x8a2e, 1);    pop(bx);                                  /* pop bx */
            ii(0x8a2f, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x8a31, 2);    if(jz(0x8a5f, 0x2c)) goto l_0x8a5f;       /* jz 0x8a5f */
            ii(0x8a33, 3);    mov(ax, memw[ss, bp - 0x1a]);             /* mov ax, [bp-0x1a] */
            ii(0x8a36, 3);    mov(dx, memw[ss, bp - 0x18]);             /* mov dx, [bp-0x18] */
            ii(0x8a39, 3);    add(ax, 0x1);                             /* add ax, 0x1 */
            ii(0x8a3c, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x8a3f, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x8a42, 3);    mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x8a45, 2);    jmp(0x8a08, -0x3f); goto l_0x8a08;        /* jmp 0x8a08 */
        l_0x8a47:
            ii(0x8a47, 3);    mov(ax, memw[ds, 0x9c]);                  /* mov ax, [0x9c] */
            ii(0x8a4a, 4);    mov(dx, memw[ds, 0x9e]);                  /* mov dx, [0x9e] */
            ii(0x8a4e, 3);    sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0x8a51, 3);    sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x8a54, 1);    push(dx);                                 /* push dx */
            ii(0x8a55, 1);    push(ax);                                 /* push ax */
            ii(0x8a56, 3);    call(0x85ed, -0x46c);                     /* call 0x85ed */
            ii(0x8a59, 1);    pop(bx);                                  /* pop bx */
            ii(0x8a5a, 1);    pop(bx);                                  /* pop bx */
            ii(0x8a5b, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x8a5d, 2);    if(jnz(0x8a6c, 0xd)) goto l_0x8a6c;       /* jnz 0x8a6c */
        l_0x8a5f:
            ii(0x8a5f, 3);    mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x8a62, 3);    mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0x8a65, 3);    mov(memw[ds, 0x9c], ax);                  /* mov [0x9c], ax */
            ii(0x8a68, 4);    mov(memw[ds, 0x9e], dx);                  /* mov [0x9e], dx */
        l_0x8a6c:
            ii(0x8a6c, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x8a6e, 3);    mov(memw[ds, 0xa6], ax);                  /* mov [0xa6], ax */
            ii(0x8a71, 3);    mov(memw[ds, 0xa4], ax);                  /* mov [0xa4], ax */
            ii(0x8a74, 3);    mov(memw[ss, bp - 0x10], ax);             /* mov [bp-0x10], ax */
            ii(0x8a77, 3);    mov(memw[ss, bp - 0x12], ax);             /* mov [bp-0x12], ax */
            ii(0x8a7a, 3);    mov(memw[ss, bp - 0x18], ax);             /* mov [bp-0x18], ax */
            ii(0x8a7d, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x8a80, 5);    cmp(memb[ds, 0x2e], 0x3);                 /* cmp byte [0x2e], 0x3 */
            ii(0x8a85, 2);    if(jnz(0x8a99, 0x12)) goto l_0x8a99;      /* jnz 0x8a99 */
            ii(0x8a87, 3);    lea(ax, bp - 0x6);                        /* lea ax, [bp-0x6] */
            ii(0x8a8a, 1);    push(ax);                                 /* push ax */
            ii(0x8a8b, 3);    call(0x88df, -0x1af);                     /* call 0x88df */
            ii(0x8a8e, 1);    pop(bx);                                  /* pop bx */
            ii(0x8a8f, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x8a92, 3);    mov(memw[ss, bp - 0x18], dx);             /* mov [bp-0x18], dx */
            ii(0x8a95, 2);    or(dx, ax);                               /* or dx, ax */
            ii(0x8a97, 2);    if(jnz(0x8aab, 0x12)) goto l_0x8aab;      /* jnz 0x8aab */
        l_0x8a99:
            ii(0x8a99, 3);    lea(ax, bp - 0x6);                        /* lea ax, [bp-0x6] */
            ii(0x8a9c, 1);    push(ax);                                 /* push ax */
            ii(0x8a9d, 3);    call(0x8852, -0x24e);                     /* call 0x8852 */
            ii(0x8aa0, 1);    pop(bx);                                  /* pop bx */
            ii(0x8aa1, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x8aa4, 3);    mov(memw[ss, bp - 0x18], dx);             /* mov [bp-0x18], dx */
            ii(0x8aa7, 2);    or(dx, ax);                               /* or dx, ax */
            ii(0x8aa9, 2);    if(jz(0x8ae2, 0x37)) goto l_0x8ae2;       /* jz 0x8ae2 */
        l_0x8aab:
            ii(0x8aab, 3);    mov(ax, memw[ds, 0x98]);                  /* mov ax, [0x98] */
            ii(0x8aae, 4);    mov(dx, memw[ds, 0x9a]);                  /* mov dx, [0x9a] */
            ii(0x8ab2, 4);    cmp(memw[ds, 0x9e], dx);                  /* cmp [0x9e], dx */
            ii(0x8ab6, 2);    if(ja(0x8ae2, 0x2a)) goto l_0x8ae2;       /* ja 0x8ae2 */
            ii(0x8ab8, 2);    if(jb(0x8ac0, 0x6)) goto l_0x8ac0;        /* jb 0x8ac0 */
            ii(0x8aba, 4);    cmp(memw[ds, 0x9c], ax);                  /* cmp [0x9c], ax */
            ii(0x8abe, 2);    if(ja(0x8ae2, 0x22)) goto l_0x8ae2;       /* ja 0x8ae2 */
        l_0x8ac0:
            ii(0x8ac0, 3);    mov(ax, memw[ss, bp - 0x1a]);             /* mov ax, [bp-0x1a] */
            ii(0x8ac3, 3);    mov(dx, memw[ss, bp - 0x18]);             /* mov dx, [bp-0x18] */
            ii(0x8ac6, 3);    mov(memw[ds, 0x98], ax);                  /* mov [0x98], ax */
            ii(0x8ac9, 4);    mov(memw[ds, 0x9a], dx);                  /* mov [0x9a], dx */
            ii(0x8acd, 3);    add(ax, memw[ss, bp - 0x6]);              /* add ax, [bp-0x6] */
            ii(0x8ad0, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x8ad3, 3);    mov(memw[ds, 0x9c], ax);                  /* mov [0x9c], ax */
            ii(0x8ad6, 4);    mov(memw[ds, 0x9e], dx);                  /* mov [0x9e], dx */
            ii(0x8ada, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x8adc, 3);    mov(memw[ss, bp - 0x18], ax);             /* mov [bp-0x18], ax */
            ii(0x8adf, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
        l_0x8ae2:
            ii(0x8ae2, 3);    mov(ax, memw[ds, 0x98]);                  /* mov ax, [0x98] */
            ii(0x8ae5, 4);    mov(dx, memw[ds, 0x9a]);                  /* mov dx, [0x9a] */
            ii(0x8ae9, 4);    cmp(memw[ds, 0x9e], dx);                  /* cmp [0x9e], dx */
            ii(0x8aed, 2);    if(jae(0x8af2, 0x3)) goto l_0x8af2;       /* jae 0x8af2 */
            ii(0x8aef, 3);    jmp(0x8bfe, 0x10c); goto l_0x8bfe;        /* jmp 0x8bfe */
        l_0x8af2:
            ii(0x8af2, 2);    if(ja(0x8afd, 0x9)) goto l_0x8afd;        /* ja 0x8afd */
            ii(0x8af4, 4);    cmp(memw[ds, 0x9c], ax);                  /* cmp [0x9c], ax */
            ii(0x8af8, 2);    if(ja(0x8afd, 0x3)) goto l_0x8afd;        /* ja 0x8afd */
            ii(0x8afa, 3);    jmp(0x8bfe, 0x101); goto l_0x8bfe;        /* jmp 0x8bfe */
        l_0x8afd:
            ii(0x8afd, 3);    add(ax, 0x1);                             /* add ax, 0x1 */
            ii(0x8b00, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x8b03, 3);    mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0x8b06, 3);    mov(memw[ss, bp - 0x14], dx);             /* mov [bp-0x14], dx */
            ii(0x8b09, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x8b0c, 3);    mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x8b0f, 6);    mov(memw[ds, 0x11d4], 0x9);               /* mov word [0x11d4], 0x9 */
            ii(0x8b15, 5);    cmp(memb[ds, 0x2e], 0xb);                 /* cmp byte [0x2e], 0xb */
            ii(0x8b1a, 2);    if(jnz(0x8b56, 0x3a)) goto l_0x8b56;      /* jnz 0x8b56 */
            ii(0x8b1c, 1);    push(dx);                                 /* push dx */
            ii(0x8b1d, 1);    push(ax);                                 /* push ax */
            ii(0x8b1e, 3);    call(0xb078, 0x2557);                     /* call 0xb078 */
            ii(0x8b21, 1);    pop(bx);                                  /* pop bx */
            ii(0x8b22, 1);    pop(bx);                                  /* pop bx */
            ii(0x8b23, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x8b25, 2);    if(jnz(0x8b2d, 0x6)) goto l_0x8b2d;       /* jnz 0x8b2d */
            ii(0x8b27, 2);    push(0x1b);                               /* push 0x1b */
            ii(0x8b29, 3);    call(0x589d, -0x328f);                    /* call 0x589d */
            ii(0x8b2c, 1);    pop(bx);                                  /* pop bx */
        l_0x8b2d:
            ii(0x8b2d, 5);    test(memb[ds, 0xa16], 0x2);               /* test byte [0xa16], 0x2 */
            ii(0x8b32, 2);    if(jz(0x8b56, 0x22)) goto l_0x8b56;       /* jz 0x8b56 */
            ii(0x8b34, 3);    mov(ax, memw[ds, 0x9c]);                  /* mov ax, [0x9c] */
            ii(0x8b37, 4);    mov(dx, memw[ds, 0x9e]);                  /* mov dx, [0x9e] */
            ii(0x8b3b, 3);    sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0x8b3e, 3);    sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x8b41, 1);    push(dx);                                 /* push dx */
            ii(0x8b42, 1);    push(ax);                                 /* push ax */
            ii(0x8b43, 3);    call(0xb078, 0x2532);                     /* call 0xb078 */
            ii(0x8b46, 1);    pop(bx);                                  /* pop bx */
            ii(0x8b47, 1);    pop(bx);                                  /* pop bx */
            ii(0x8b48, 3);    mov(ax, memw[ds, 0xac]);                  /* mov ax, [0xac] */
            ii(0x8b4b, 4);    mov(dx, memw[ds, 0xae]);                  /* mov dx, [0xae] */
            ii(0x8b4f, 3);    mov(memw[ds, 0x9c], ax);                  /* mov [0x9c], ax */
            ii(0x8b52, 4);    mov(memw[ds, 0x9e], dx);                  /* mov [0x9e], dx */
        l_0x8b56:
            ii(0x8b56, 2);    push(0x10);                               /* push 0x10 */
            ii(0x8b58, 3);    lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x8b5b, 1);    push(ax);                                 /* push ax */
            ii(0x8b5c, 3);    mov(ax, memw[ds, 0x98]);                  /* mov ax, [0x98] */
            ii(0x8b5f, 4);    mov(dx, memw[ds, 0x9a]);                  /* mov dx, [0x9a] */
            ii(0x8b63, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x8b65, 3);    call(0x5d94, -0x2dd4);                    /* call 0x5d94 */
            ii(0x8b68, 1);    push(dx);                                 /* push dx */
            ii(0x8b69, 1);    push(ax);                                 /* push ax */
            ii(0x8b6a, 3);    call(0x4812, -0x435b);                    /* call 0x4812 */
            ii(0x8b6d, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x8b70, 3);    mov(ax, memw[ds, 0x9c]);                  /* mov ax, [0x9c] */
            ii(0x8b73, 4);    mov(dx, memw[ds, 0x9e]);                  /* mov dx, [0x9e] */
            ii(0x8b77, 3);    sub(ax, memw[ss, bp - 0x16]);             /* sub ax, [bp-0x16] */
            ii(0x8b7a, 3);    sbb(dx, memw[ss, bp - 0x14]);             /* sbb dx, [bp-0x14] */
            ii(0x8b7d, 3);    mov(memw[ss, bp - 0x12], ax);             /* mov [bp-0x12], ax */
            ii(0x8b80, 3);    mov(memw[ss, bp - 0x10], dx);             /* mov [bp-0x10], dx */
            ii(0x8b83, 3);    mov(memw[ds, 0xa4], ax);                  /* mov [0xa4], ax */
            ii(0x8b86, 4);    mov(memw[ds, 0xa6], dx);                  /* mov [0xa6], dx */
            ii(0x8b8a, 3);    mov(ax, memw[ss, bp - 0x1a]);             /* mov ax, [bp-0x1a] */
            ii(0x8b8d, 3);    mov(dx, memw[ss, bp - 0x18]);             /* mov dx, [bp-0x18] */
            ii(0x8b90, 3);    mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0x8b93, 3);    mov(memw[ss, bp - 0x14], dx);             /* mov [bp-0x14], dx */
            ii(0x8b96, 2);    push(0x10);                               /* push 0x10 */
            ii(0x8b98, 3);    lea(cx, bp - 0x16);                       /* lea cx, [bp-0x16] */
            ii(0x8b9b, 1);    push(cx);                                 /* push cx */
            ii(0x8b9c, 3);    mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x8b9f, 3);    mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0x8ba2, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x8ba4, 3);    call(0x5d94, -0x2e13);                    /* call 0x5d94 */
            ii(0x8ba7, 1);    push(dx);                                 /* push dx */
            ii(0x8ba8, 1);    push(ax);                                 /* push ax */
            ii(0x8ba9, 3);    call(0x4812, -0x439a);                    /* call 0x4812 */
            ii(0x8bac, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x8baf, 3);    mov(ax, memw[ss, bp - 0x18]);             /* mov ax, [bp-0x18] */
            ii(0x8bb2, 3);    or(ax, memw[ss, bp - 0x1a]);              /* or ax, [bp-0x1a] */
            ii(0x8bb5, 2);    if(jz(0x8bfe, 0x47)) goto l_0x8bfe;       /* jz 0x8bfe */
            ii(0x8bb7, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x8bb9, 3);    mov(memw[ss, bp - 0x14], ax);             /* mov [bp-0x14], ax */
            ii(0x8bbc, 3);    mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0x8bbf, 3);    mov(ax, memw[ss, bp - 0x6]);              /* mov ax, [bp-0x6] */
            ii(0x8bc2, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x8bc4, 3);    mov(memw[ss, bp - 0x12], ax);             /* mov [bp-0x12], ax */
            ii(0x8bc7, 3);    mov(memw[ss, bp - 0x10], dx);             /* mov [bp-0x10], dx */
            ii(0x8bca, 4);    add(memw[ds, 0xa4], ax);                  /* add [0xa4], ax */
            ii(0x8bce, 4);    adc(memw[ds, 0xa6], dx);                  /* adc [0xa6], dx */
            ii(0x8bd2, 2);    push(0x10);                               /* push 0x10 */
            ii(0x8bd4, 3);    lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x8bd7, 1);    push(ax);                                 /* push ax */
            ii(0x8bd8, 3);    mov(ax, memw[ss, bp - 0x1a]);             /* mov ax, [bp-0x1a] */
            ii(0x8bdb, 3);    mov(dx, memw[ss, bp - 0x18]);             /* mov dx, [bp-0x18] */
            ii(0x8bde, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x8be0, 3);    call(0x5d94, -0x2e4f);                    /* call 0x5d94 */
            ii(0x8be3, 1);    push(dx);                                 /* push dx */
            ii(0x8be4, 1);    push(ax);                                 /* push ax */
            ii(0x8be5, 3);    call(0x4812, -0x43d6);                    /* call 0x4812 */
            ii(0x8be8, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x8beb, 3);    mov(ax, memw[ss, bp - 0x1a]);             /* mov ax, [bp-0x1a] */
            ii(0x8bee, 3);    mov(dx, memw[ss, bp - 0x18]);             /* mov dx, [bp-0x18] */
            ii(0x8bf1, 3);    add(ax, memw[ss, bp - 0x12]);             /* add ax, [bp-0x12] */
            ii(0x8bf4, 3);    adc(dx, memw[ss, bp - 0x10]);             /* adc dx, [bp-0x10] */
            ii(0x8bf7, 3);    mov(memw[ds, 0x9c], ax);                  /* mov [0x9c], ax */
            ii(0x8bfa, 4);    mov(memw[ds, 0x9e], dx);                  /* mov [0x9e], dx */
        l_0x8bfe:
            ii(0x8bfe, 5);    test(memb[ds, 0x47], 0x80);               /* test byte [0x47], 0x80 */
            ii(0x8c03, 2);    if(jz(0x8c52, 0x4d)) goto l_0x8c52;       /* jz 0x8c52 */
            ii(0x8c05, 5);    mov(memb[ds, 0xa16], 0x1);                /* mov byte [0xa16], 0x1 */
            ii(0x8c0a, 5);    mov(memw[ss, bp - 0x28], 0xbfde);         /* mov word [bp-0x28], 0xbfde */
            ii(0x8c0f, 5);    mov(memw[ss, bp - 0x26], 0x4);            /* mov word [bp-0x26], 0x4 */
            ii(0x8c14, 5);    mov(memw[ss, bp - 0x24], 0x1);            /* mov word [bp-0x24], 0x1 */
            ii(0x8c19, 5);    cmp(memw[ds, 0xadc], 0);                  /* cmp word [0xadc], 0x0 */
            ii(0x8c1e, 2);    if(jnz(0x8c27, 0x7)) goto l_0x8c27;       /* jnz 0x8c27 */
            ii(0x8c20, 5);    cmp(memb[ds, 0x2e], 0xb);                 /* cmp byte [0x2e], 0xb */
            ii(0x8c25, 2);    if(jnz(0x8c2c, 0x5)) goto l_0x8c2c;       /* jnz 0x8c2c */
        l_0x8c27:
            ii(0x8c27, 5);    mov(memw[ss, bp - 0x24], 0);              /* mov word [bp-0x24], 0x0 */
        l_0x8c2c:
            ii(0x8c2c, 3);    lea(ax, bp - 0x28);                       /* lea ax, [bp-0x28] */
            ii(0x8c2f, 1);    push(ax);                                 /* push ax */
            ii(0x8c30, 1);    push(ax);                                 /* push ax */
            ii(0x8c31, 2);    push(0x15);                               /* push 0x15 */
            ii(0x8c33, 3);    call(0x9674, 0xa3e);                      /* call 0x9674 */
            ii(0x8c36, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x8c39, 3);    mov(ax, memw[ss, bp - 0x22]);             /* mov ax, [bp-0x22] */
            ii(0x8c3c, 3);    mov(dx, memw[ss, bp - 0x24]);             /* mov dx, [bp-0x24] */
            ii(0x8c3f, 3);    mov(memw[ds, 0xa0], ax);                  /* mov [0xa0], ax */
            ii(0x8c42, 4);    mov(memw[ds, 0xa2], dx);                  /* mov [0xa2], dx */
            ii(0x8c46, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x8c48, 3);    mov(si, 0x98);                            /* mov si, 0x98 */
            ii(0x8c4b, 2);    mov(es, dx);                              /* mov es, dx */
            ii(0x8c4d, 3);    mov(cx, 0xc);                             /* mov cx, 0xc */
            ii(0x8c50, 2);    rep(() => movsw());                       /* rep movsw */
        l_0x8c52:
            ii(0x8c52, 5);    cmp(memb[ds, 0x2e], 0xb);                 /* cmp byte [0x2e], 0xb */
            ii(0x8c57, 2);    if(jz(0x8c6c, 0x13)) goto l_0x8c6c;       /* jz 0x8c6c */
            ii(0x8c59, 3);    mov(ax, memw[ds, 0xa4]);                  /* mov ax, [0xa4] */
            ii(0x8c5c, 4);    mov(dx, memw[ds, 0xa6]);                  /* mov dx, [0xa6] */
            ii(0x8c60, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x8c62, 3);    call(0x5d94, -0x2ed1);                    /* call 0x5d94 */
            ii(0x8c65, 3);    mov(memw[ds, 0xaa8], ax);                 /* mov [0xaa8], ax */
            ii(0x8c68, 4);    mov(memw[ds, 0xaaa], dx);                 /* mov [0xaaa], dx */
        l_0x8c6c:
            ii(0x8c6c, 1);    pop(si);                                  /* pop si */
            ii(0x8c6d, 1);    pop(di);                                  /* pop di */
            ii(0x8c6e, 1);    leave();                                  /* leave */
            ii(0x8c6f, 1);    ret();                                    /* ret */
        }
    }
}
