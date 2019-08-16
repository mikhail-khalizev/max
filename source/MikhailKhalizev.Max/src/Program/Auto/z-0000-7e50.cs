using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ca2bb2f3-903c-4159-8536-66ba32cd76b7")]
        public void Method_0000_7e50()
        {
            ii(0x7e50, 1);    pushw(di);                                /* push di */
            ii(0x7e51, 1);    pushw(si);                                /* push si */
            ii(0x7e52, 3);    mov(al, memb_a16[ds, 0xcda]);             /* mov al, [0xcda] */
            ii(0x7e55, 4);    inc(memb_a16[ds, 0xcda]);                 /* inc byte [0xcda] */
            ii(0x7e59, 2);    or(al, al);                               /* or al, al */
            ii(0x7e5b, 2);    if(jnzw(0x7e60, 0x3)) goto l_0x7e60;      /* jnz 0x7e60 */
            ii(0x7e5d, 3);    callw(0x71f1, -0xc6f);                    /* call 0x71f1 */
        l_0x7e60:
            ii(0x7e60, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x7e64, 4);    cmp(memw_a16[ds, bx + 0x18], 0x21);       /* cmp word [bx+0x18], 0x21 */
            ii(0x7e68, 2);    if(jnzw(0x7e73, 0x9)) goto l_0x7e73;      /* jnz 0x7e73 */
            ii(0x7e6a, 3);    mov(al, memb_a16[ds, bx + 0x16]);         /* mov al, [bx+0x16] */
            ii(0x7e6d, 1);    cbw();                                    /* cbw */
            ii(0x7e6e, 1);    pushw(ax);                                /* push ax */
            ii(0x7e6f, 3);    callw(0x5de2, -0x2090);                   /* call 0x5de2 */
            ii(0x7e72, 1);    popw(bx);                                 /* pop bx */
        l_0x7e73:
            ii(0x7e73, 3);    callw(0x6f77, -0xeff);                    /* call 0x6f77 */
            ii(0x7e76, 3);    callw(0x7588, -0x8f1);                    /* call 0x7588 */
            ii(0x7e79, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x7e7d, 4);    cmp(memw_a16[ds, bx + 0x18], 0);          /* cmp word [bx+0x18], 0x0 */
            ii(0x7e81, 2);    if(jgew(0x7e86, 0x3)) goto l_0x7e86;      /* jge 0x7e86 */
            ii(0x7e83, 3);    jmpw(0x8017, 0x191); goto l_0x8017;       /* jmp 0x8017 */
        l_0x7e86:
            ii(0x7e86, 3);    mov(ax, 0xc4e);                           /* mov ax, 0xc4e */
            ii(0x7e89, 1);    pushw(ax);                                /* push ax */
            ii(0x7e8a, 3);    callw(0x7247, -0xc46);                    /* call 0x7247 */
            ii(0x7e8d, 1);    popw(bx);                                 /* pop bx */
            ii(0x7e8e, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x7e92, 4);    cmp(memw_a16[ds, bx + 0x18], 0xd);        /* cmp word [bx+0x18], 0xd */
            ii(0x7e96, 2);    if(jnzw(0x7e9d, 0x5)) goto l_0x7e9d;      /* jnz 0x7e9d */
            ii(0x7e98, 3);    mov(ax, 0xc5b);                           /* mov ax, 0xc5b */
            ii(0x7e9b, 2);    jmpw(0x7ea6, 0x9); goto l_0x7ea6;         /* jmp 0x7ea6 */
        l_0x7e9d:
            ii(0x7e9d, 4);    cmp(memw_a16[ds, bx + 0x18], 0x6);        /* cmp word [bx+0x18], 0x6 */
            ii(0x7ea1, 2);    if(jnzw(0x7eac, 0x9)) goto l_0x7eac;      /* jnz 0x7eac */
            ii(0x7ea3, 3);    mov(ax, 0xc74);                           /* mov ax, 0xc74 */
        l_0x7ea6:
            ii(0x7ea6, 1);    pushw(ax);                                /* push ax */
            ii(0x7ea7, 3);    callw(0x7247, -0xc63);                    /* call 0x7247 */
            ii(0x7eaa, 2);    jmpw(0x7ed2, 0x26); goto l_0x7ed2;        /* jmp 0x7ed2 */
        l_0x7eac:
            ii(0x7eac, 4);    cmp(memw_a16[ds, bx + 0x18], 0xe);        /* cmp word [bx+0x18], 0xe */
            ii(0x7eb0, 2);    if(jnzw(0x7ec7, 0x15)) goto l_0x7ec7;     /* jnz 0x7ec7 */
            ii(0x7eb2, 4);    pushw(memw_a16[ds, 0xd32]);               /* push word [0xd32] */
            ii(0x7eb6, 3);    mov(ax, 0xc83);                           /* mov ax, 0xc83 */
            ii(0x7eb9, 1);    pushw(ax);                                /* push ax */
            ii(0x7eba, 3);    callw(0x75f7, -0x8c6);                    /* call 0x75f7 */
            ii(0x7ebd, 1);    popw(bx);                                 /* pop bx */
            ii(0x7ebe, 1);    popw(bx);                                 /* pop bx */
            ii(0x7ebf, 4);    pushw(memw_a16[ds, 0xd30]);               /* push word [0xd30] */
            ii(0x7ec3, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x7ec5, 2);    jmpw(0x7ecd, 0x6); goto l_0x7ecd;         /* jmp 0x7ecd */
        l_0x7ec7:
            ii(0x7ec7, 3);    pushw(memw_a16[ds, bx + 0x18]);           /* push word [bx+0x18] */
            ii(0x7eca, 3);    mov(ax, 0xc8e);                           /* mov ax, 0xc8e */
        l_0x7ecd:
            ii(0x7ecd, 1);    pushw(ax);                                /* push ax */
            ii(0x7ece, 3);    callw(0x75f7, -0x8da);                    /* call 0x75f7 */
            ii(0x7ed1, 1);    popw(bx);                                 /* pop bx */
        l_0x7ed2:
            ii(0x7ed2, 1);    popw(bx);                                 /* pop bx */
            ii(0x7ed3, 3);    mov(ax, 0xca3);                           /* mov ax, 0xca3 */
            ii(0x7ed6, 1);    pushw(ax);                                /* push ax */
            ii(0x7ed7, 3);    callw(0x7247, -0xc93);                    /* call 0x7247 */
            ii(0x7eda, 1);    popw(bx);                                 /* pop bx */
            ii(0x7edb, 4);    mov(si, memw_a16[ds, 0x11f8]);            /* mov si, [0x11f8] */
            ii(0x7edf, 4);    add(si, 0x1190);                          /* add si, 0x1190 */
            ii(0x7ee3, 2);    jmpw(0x7eef, 0xa); goto l_0x7eef;         /* jmp 0x7eef */
        l_0x7ee5:
            ii(0x7ee5, 3);    cmp(memb_a16[ds, si], 0x3a);              /* cmp byte [si], 0x3a */
            ii(0x7ee8, 2);    if(jzw(0x7ef6, 0xc)) goto l_0x7ef6;       /* jz 0x7ef6 */
            ii(0x7eea, 3);    cmp(memb_a16[ds, si], 0x5c);              /* cmp byte [si], 0x5c */
            ii(0x7eed, 2);    if(jzw(0x7ef6, 0x7)) goto l_0x7ef6;       /* jz 0x7ef6 */
        l_0x7eef:
            ii(0x7eef, 1);    dec(si);                                  /* dec si */
            ii(0x7ef0, 4);    cmp(si, 0x1190);                          /* cmp si, 0x1190 */
            ii(0x7ef4, 2);    if(jaew(0x7ee5, -0x11)) goto l_0x7ee5;    /* jae 0x7ee5 */
        l_0x7ef6:
            ii(0x7ef6, 3);    lea(ax, si + 0x1);                        /* lea ax, [si+0x1] */
            ii(0x7ef9, 1);    pushw(ax);                                /* push ax */
            ii(0x7efa, 3);    callw(0x7247, -0xcb6);                    /* call 0x7247 */
            ii(0x7efd, 1);    popw(bx);                                 /* pop bx */
            ii(0x7efe, 3);    mov(ax, 0xca8);                           /* mov ax, 0xca8 */
            ii(0x7f01, 1);    pushw(ax);                                /* push ax */
            ii(0x7f02, 3);    callw(0x7247, -0xcbe);                    /* call 0x7247 */
            ii(0x7f05, 1);    popw(bx);                                 /* pop bx */
            ii(0x7f06, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x7f0a, 3);    pushw(memw_a16[ds, bx + 0x22]);           /* push word [bx+0x22] */
            ii(0x7f0d, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x7f0f, 1);    pushw(ax);                                /* push ax */
            ii(0x7f10, 3);    callw(0x75f7, -0x91c);                    /* call 0x75f7 */
            ii(0x7f13, 1);    popw(bx);                                 /* pop bx */
            ii(0x7f14, 1);    popw(bx);                                 /* pop bx */
            ii(0x7f15, 3);    mov(ax, 0xcad);                           /* mov ax, 0xcad */
            ii(0x7f18, 1);    pushw(ax);                                /* push ax */
            ii(0x7f19, 3);    callw(0x7247, -0xcd5);                    /* call 0x7247 */
            ii(0x7f1c, 1);    popw(bx);                                 /* pop bx */
            ii(0x7f1d, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x7f21, 3);    pushw(memw_a16[ds, bx + 0x1e]);           /* push word [bx+0x1e] */
            ii(0x7f24, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x7f26, 1);    pushw(ax);                                /* push ax */
            ii(0x7f27, 3);    callw(0x75f7, -0x933);                    /* call 0x75f7 */
            ii(0x7f2a, 1);    popw(bx);                                 /* pop bx */
            ii(0x7f2b, 1);    popw(bx);                                 /* pop bx */
            ii(0x7f2c, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x7f30, 3);    pushw(memw_a16[ds, bx + 0x22]);           /* push word [bx+0x22] */
            ii(0x7f33, 3);    callw(0x8022, 0xec);                      /* call 0x8022 */
            ii(0x7f36, 1);    popw(bx);                                 /* pop bx */
            ii(0x7f37, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x7f39, 2);    or(di, di);                               /* or di, di */
            ii(0x7f3b, 2);    if(jzw(0x7f47, 0xa)) goto l_0x7f47;       /* jz 0x7f47 */
            ii(0x7f3d, 1);    pushw(di);                                /* push di */
            ii(0x7f3e, 3);    mov(ax, 0xcaf);                           /* mov ax, 0xcaf */
            ii(0x7f41, 1);    pushw(ax);                                /* push ax */
            ii(0x7f42, 3);    callw(0x75f7, -0x94e);                    /* call 0x75f7 */
            ii(0x7f45, 1);    popw(bx);                                 /* pop bx */
            ii(0x7f46, 1);    popw(bx);                                 /* pop bx */
        l_0x7f47:
            ii(0x7f47, 3);    callw(0x7588, -0x9c2);                    /* call 0x7588 */
            ii(0x7f4a, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x7f4e, 3);    pushw(memw_a16[ds, bx + 0x1a]);           /* push word [bx+0x1a] */
            ii(0x7f51, 3);    mov(ax, 0xcb4);                           /* mov ax, 0xcb4 */
            ii(0x7f54, 1);    pushw(ax);                                /* push ax */
            ii(0x7f55, 3);    callw(0x75f7, -0x961);                    /* call 0x75f7 */
            ii(0x7f58, 1);    popw(bx);                                 /* pop bx */
            ii(0x7f59, 1);    popw(bx);                                 /* pop bx */
            ii(0x7f5a, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x7f5e, 3);    pushw(memw_a16[ds, bx + 0x2]);            /* push word [bx+0x2] */
            ii(0x7f61, 3);    mov(ax, 0xcb9);                           /* mov ax, 0xcb9 */
            ii(0x7f64, 1);    pushw(ax);                                /* push ax */
            ii(0x7f65, 3);    callw(0x75f7, -0x971);                    /* call 0x75f7 */
            ii(0x7f68, 1);    popw(bx);                                 /* pop bx */
            ii(0x7f69, 1);    popw(bx);                                 /* pop bx */
            ii(0x7f6a, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x7f6e, 3);    pushw(memw_a16[ds, bx + 0x4]);            /* push word [bx+0x4] */
            ii(0x7f71, 3);    mov(ax, 0xcbc);                           /* mov ax, 0xcbc */
            ii(0x7f74, 1);    pushw(ax);                                /* push ax */
            ii(0x7f75, 3);    callw(0x75f7, -0x981);                    /* call 0x75f7 */
            ii(0x7f78, 1);    popw(bx);                                 /* pop bx */
            ii(0x7f79, 1);    popw(bx);                                 /* pop bx */
            ii(0x7f7a, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x7f7e, 3);    pushw(memw_a16[ds, bx + 0x6]);            /* push word [bx+0x6] */
            ii(0x7f81, 3);    mov(ax, 0xcbf);                           /* mov ax, 0xcbf */
            ii(0x7f84, 1);    pushw(ax);                                /* push ax */
            ii(0x7f85, 3);    callw(0x75f7, -0x991);                    /* call 0x75f7 */
            ii(0x7f88, 1);    popw(bx);                                 /* pop bx */
            ii(0x7f89, 1);    popw(bx);                                 /* pop bx */
            ii(0x7f8a, 3);    callw(0x7588, -0xa05);                    /* call 0x7588 */
            ii(0x7f8d, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x7f91, 3);    pushw(memw_a16[ds, bx + 0x16]);           /* push word [bx+0x16] */
            ii(0x7f94, 3);    mov(ax, 0xcc2);                           /* mov ax, 0xcc2 */
            ii(0x7f97, 1);    pushw(ax);                                /* push ax */
            ii(0x7f98, 3);    callw(0x75f7, -0x9a4);                    /* call 0x75f7 */
            ii(0x7f9b, 1);    popw(bx);                                 /* pop bx */
            ii(0x7f9c, 1);    popw(bx);                                 /* pop bx */
            ii(0x7f9d, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x7fa1, 3);    pushw(memw_a16[ds, bx + 0x10]);           /* push word [bx+0x10] */
            ii(0x7fa4, 3);    mov(ax, 0xcc5);                           /* mov ax, 0xcc5 */
            ii(0x7fa7, 1);    pushw(ax);                                /* push ax */
            ii(0x7fa8, 3);    callw(0x75f7, -0x9b4);                    /* call 0x75f7 */
            ii(0x7fab, 1);    popw(bx);                                 /* pop bx */
            ii(0x7fac, 1);    popw(bx);                                 /* pop bx */
            ii(0x7fad, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x7fb1, 3);    pushw(memw_a16[ds, bx + 0x14]);           /* push word [bx+0x14] */
            ii(0x7fb4, 3);    mov(ax, 0xcc8);                           /* mov ax, 0xcc8 */
            ii(0x7fb7, 1);    pushw(ax);                                /* push ax */
            ii(0x7fb8, 3);    callw(0x75f7, -0x9c4);                    /* call 0x75f7 */
            ii(0x7fbb, 1);    popw(bx);                                 /* pop bx */
            ii(0x7fbc, 1);    popw(bx);                                 /* pop bx */
            ii(0x7fbd, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x7fc1, 3);    pushw(memw_a16[ds, bx + 0x12]);           /* push word [bx+0x12] */
            ii(0x7fc4, 3);    mov(ax, 0xccb);                           /* mov ax, 0xccb */
            ii(0x7fc7, 1);    pushw(ax);                                /* push ax */
            ii(0x7fc8, 3);    callw(0x75f7, -0x9d4);                    /* call 0x75f7 */
            ii(0x7fcb, 1);    popw(bx);                                 /* pop bx */
            ii(0x7fcc, 1);    popw(bx);                                 /* pop bx */
            ii(0x7fcd, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x7fd1, 3);    pushw(memw_a16[ds, bx + 0xe]);            /* push word [bx+0xe] */
            ii(0x7fd4, 3);    mov(ax, 0xcce);                           /* mov ax, 0xcce */
            ii(0x7fd7, 1);    pushw(ax);                                /* push ax */
            ii(0x7fd8, 3);    callw(0x75f7, -0x9e4);                    /* call 0x75f7 */
            ii(0x7fdb, 1);    popw(bx);                                 /* pop bx */
            ii(0x7fdc, 1);    popw(bx);                                 /* pop bx */
            ii(0x7fdd, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x7fe1, 3);    pushw(memw_a16[ds, bx + 0xc]);            /* push word [bx+0xc] */
            ii(0x7fe4, 3);    mov(ax, 0xcd1);                           /* mov ax, 0xcd1 */
            ii(0x7fe7, 1);    pushw(ax);                                /* push ax */
            ii(0x7fe8, 3);    callw(0x75f7, -0x9f4);                    /* call 0x75f7 */
            ii(0x7feb, 1);    popw(bx);                                 /* pop bx */
            ii(0x7fec, 1);    popw(bx);                                 /* pop bx */
            ii(0x7fed, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x7ff1, 3);    pushw(memw_a16[ds, bx + 0xa]);            /* push word [bx+0xa] */
            ii(0x7ff4, 3);    mov(ax, 0xcd4);                           /* mov ax, 0xcd4 */
            ii(0x7ff7, 1);    pushw(ax);                                /* push ax */
            ii(0x7ff8, 3);    callw(0x75f7, -0xa04);                    /* call 0x75f7 */
            ii(0x7ffb, 1);    popw(bx);                                 /* pop bx */
            ii(0x7ffc, 1);    popw(bx);                                 /* pop bx */
            ii(0x7ffd, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x8001, 3);    pushw(memw_a16[ds, bx + 0x8]);            /* push word [bx+0x8] */
            ii(0x8004, 3);    mov(ax, 0xcd7);                           /* mov ax, 0xcd7 */
            ii(0x8007, 1);    pushw(ax);                                /* push ax */
            ii(0x8008, 3);    callw(0x75f7, -0xa14);                    /* call 0x75f7 */
            ii(0x800b, 1);    popw(bx);                                 /* pop bx */
            ii(0x800c, 1);    popw(bx);                                 /* pop bx */
            ii(0x800d, 5);    test(memb_a16[ds, 0x15], 0x80);           /* test byte [0x15], 0x80 */
            ii(0x8012, 2);    if(jzw(0x8017, 0x3)) goto l_0x8017;       /* jz 0x8017 */
            ii(0x8014, 3);    callw(0x702a, -0xfed);                    /* call 0x702a */
        l_0x8017:
            ii(0x8017, 3);    mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x801a, 1);    pushw(ax);                                /* push ax */
            ii(0x801b, 3);    callw(0x5de2, -0x223c);                   /* call 0x5de2 */
            ii(0x801e, 1);    popw(bx);                                 /* pop bx */
            ii(0x801f, 1);    popw(si);                                 /* pop si */
            ii(0x8020, 1);    popw(di);                                 /* pop di */
            ii(0x8021, 1);    retw(); return;                           /* ret */
        }
    }
}
