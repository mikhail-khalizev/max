using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0f709f13-346d-4cd6-94e8-e22ec396511a")]
        public void Method_0000_6f76()
        {
            ii(0x6f76, 1);    pushw(di);                                /* push di */
            ii(0x6f77, 1);    pushw(si);                                /* push si */
            ii(0x6f78, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x6f7a, 3);    mov(memw_a16[ds, 0x11d0], ax);            /* mov [0x11d0], ax */
            ii(0x6f7d, 3);    mov(memw_a16[ds, 0x1208], ax);            /* mov [0x1208], ax */
            ii(0x6f80, 4);    cmp(memw_a16[ds, 0xa], ax);               /* cmp [0xa], ax */
            ii(0x6f84, 2);    if(jnzw(0x7000, 0x7a)) goto l_0x7000;     /* jnz 0x7000 */
            ii(0x6f86, 4);    mov(si, memw_a16[ds, 0xe]);               /* mov si, [0xe] */
            ii(0x6f8a, 4);    cmp(memw_a16[ds, 0x11d6], ax);            /* cmp [0x11d6], ax */
            ii(0x6f8e, 2);    if(jzw(0x6f94, 0x4)) goto l_0x6f94;       /* jz 0x6f94 */
            ii(0x6f90, 4);    mov(si, memw_a16[ds, 0x11d6]);            /* mov si, [0x11d6] */
        l_0x6f94:
            ii(0x6f94, 2);    or(si, si);                               /* or si, si */
            ii(0x6f96, 2);    if(jnzw(0x6f9b, 0x3)) goto l_0x6f9b;      /* jnz 0x6f9b */
            ii(0x6f98, 3);    mov(si, 0x800);                           /* mov si, 0x800 */
        l_0x6f9b:
            ii(0x6f9b, 4);    cmp(si, 0x400);                           /* cmp si, 0x400 */
            ii(0x6f9f, 2);    if(jaew(0x6fa4, 0x3)) goto l_0x6fa4;      /* jae 0x6fa4 */
            ii(0x6fa1, 3);    mov(si, 0x400);                           /* mov si, 0x400 */
        l_0x6fa4:
            ii(0x6fa4, 3);    mov(ax, memw_a16[ds, 0x9b8]);             /* mov ax, [0x9b8] */
            ii(0x6fa7, 1);    dec(ax);                                  /* dec ax */
            ii(0x6fa8, 2);    sub(bx, bx);                              /* sub bx, bx */
            ii(0x6faa, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x6fac, 4);    cmp(memb_a16[es, bx], 0x4d);              /* cmp byte [es:bx], 0x4d */
            ii(0x6fb0, 2);    if(jnzw(0x6fcb, 0x19)) goto l_0x6fcb;     /* jnz 0x6fcb */
            ii(0x6fb2, 3);    mov(ax, memw_a16[ds, 0xcec]);             /* mov ax, [0xcec] */
            ii(0x6fb5, 4);    cmp(memw_a16[es, bx + 0x1], ax);          /* cmp [es:bx+0x1], ax */
            ii(0x6fb9, 2);    if(jnzw(0x6fcb, 0x10)) goto l_0x6fcb;     /* jnz 0x6fcb */
            ii(0x6fbb, 4);    mov(di, memw_a16[es, bx + 0x3]);          /* mov di, [es:bx+0x3] */
            ii(0x6fbf, 3);    add(di, 0x20);                            /* add di, 0x20 */
            ii(0x6fc2, 3);    shl(di, 0x4);                             /* shl di, 0x4 */
            ii(0x6fc5, 2);    cmp(di, si);                              /* cmp di, si */
            ii(0x6fc7, 2);    if(jbew(0x6fcb, 0x2)) goto l_0x6fcb;      /* jbe 0x6fcb */
            ii(0x6fc9, 2);    mov(si, di);                              /* mov si, di */
        l_0x6fcb:
            ii(0x6fcb, 4);    cmp(si, 0x8200);                          /* cmp si, 0x8200 */
            ii(0x6fcf, 2);    if(jbew(0x6fd4, 0x3)) goto l_0x6fd4;      /* jbe 0x6fd4 */
            ii(0x6fd1, 3);    mov(si, 0x8200);                          /* mov si, 0x8200 */
        l_0x6fd4:
            ii(0x6fd4, 3);    add(si, 0xf);                             /* add si, 0xf */
            ii(0x6fd7, 1);    pushw(si);                                /* push si */
            ii(0x6fd8, 5);    callw_far_abs(0x1a2, 0xb12);              /* call word 0x1a2:0xb12 */
            ii(0x6fdd, 1);    popw(bx);                                 /* pop bx */
            ii(0x6fde, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x6fe0, 2);    if(jnzw(0x6fe8, 0x6)) goto l_0x6fe8;      /* jnz 0x6fe8 */
        l_0x6fe2:
            ii(0x6fe2, 2);    pushw(0xd);                               /* push 0xd */
            ii(0x6fe4, 3);    callw(0x589d, -0x174a);                   /* call 0x589d */
            ii(0x6fe7, 1);    popw(bx);                                 /* pop bx */
        l_0x6fe8:
            ii(0x6fe8, 1);    pushw(si);                                /* push si */
            ii(0x6fe9, 3);    callw(0x5a2e, -0x15be);                   /* call 0x5a2e */
            ii(0x6fec, 1);    popw(bx);                                 /* pop bx */
            ii(0x6fed, 3);    add(ax, 0xf);                             /* add ax, 0xf */
            ii(0x6ff0, 2);    and(al, 0xf0);                            /* and al, 0xf0 */
            ii(0x6ff2, 3);    mov(memw_a16[ds, 0xa], ax);               /* mov [0xa], ax */
            ii(0x6ff5, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x6ff7, 2);    if(jzw(0x6fe2, -0x17)) goto l_0x6fe2;     /* jz 0x6fe2 */
            ii(0x6ff9, 2);    mov(ax, si);                              /* mov ax, si */
            ii(0x6ffb, 2);    and(al, 0xf0);                            /* and al, 0xf0 */
            ii(0x6ffd, 3);    mov(memw_a16[ds, 0xe], ax);               /* mov [0xe], ax */
        l_0x7000:
            ii(0x7000, 1);    popw(si);                                 /* pop si */
            ii(0x7001, 1);    popw(di);                                 /* pop di */
            ii(0x7002, 1);    retw(); return;                           /* ret */
        }
    }
}
