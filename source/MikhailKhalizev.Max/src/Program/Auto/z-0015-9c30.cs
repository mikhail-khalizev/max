using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9989ef11-73ba-4d1f-8888-c85f8af63f3c")]
        public void Method_0015_9c30()
        {
            ii(0x15_9c30, 4); enterw(0x32, 0);                          /* enter 0x32, 0x0 */
            ii(0x15_9c34, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_9c36, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x15_9c39, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_9c3c, 4); mov(es, memw_a16[ds, 0x3fbe]);            /* mov es, [0x3fbe] */
            ii(0x15_9c40, 4); mov(ax, memw_a16[es, 0x3b84]);            /* mov ax, [es:0x3b84] */
            ii(0x15_9c44, 5); mov(memw_a16[ss, bp - 0x8], 0);           /* mov word [bp-0x8], 0x0 */
            ii(0x15_9c49, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x15_9c4c, 5); mov(memw_a16[ss, bp - 0x10], 0);          /* mov word [bp-0x10], 0x0 */
            ii(0x15_9c51, 2); pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0x15_9c53, 2); pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0x15_9c55, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_9c57, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_9c59, 1); pushw(cs);                                /* push cs */
            ii(0x15_9c5a, 3); callw(0x15_9be0, -0x7d);                  /* call 0x9be0 */
            ii(0x15_9c5d, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_9c60, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_9c62, 2); if(jnzw(0x15_9c6a, 0x6)) goto l_0x15_9c6a; /* jnz 0x9c6a */
        l_0x15_9c64:
            ii(0x15_9c64, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_9c66, 1); cwd();                                    /* cwd */
            ii(0x15_9c67, 3); jmpw(0x15_9db4, 0x14a); goto l_0x15_9db4; /* jmp 0x9db4 */
        l_0x15_9c6a:
            ii(0x15_9c6a, 3); mov(ax, memw_a16[ds, 0x3292]);            /* mov ax, [0x3292] */
            ii(0x15_9c6d, 4); or(ax, memw_a16[ds, 0x3290]);             /* or ax, [0x3290] */
            ii(0x15_9c71, 2); if(jzw(0x15_9c7d, 0xa)) goto l_0x15_9c7d; /* jz 0x9c7d */
            ii(0x15_9c73, 5); cmp(memb_a16[ds, 0x19f4], 0x1);           /* cmp byte [0x19f4], 0x1 */
            ii(0x15_9c78, 2); if(jnzw(0x15_9c7d, 0x3)) goto l_0x15_9c7d; /* jnz 0x9c7d */
            ii(0x15_9c7a, 3); inc(memw_a16[ss, bp - 0x10]);             /* inc word [bp-0x10] */
        l_0x15_9c7d:
            ii(0x15_9c7d, 4); cmp(memw_a16[ss, bp - 0x10], 0);          /* cmp word [bp-0x10], 0x0 */
            ii(0x15_9c81, 2); if(jnzw(0x15_9cde, 0x5b)) goto l_0x15_9cde; /* jnz 0x9cde */
            ii(0x15_9c83, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_9c86, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_9c89, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_9c8c, 3); callw(0x15_c7eb, 0x2b5c);                 /* call 0xc7eb */
            ii(0x15_9c8f, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_9c92, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x15_9c95, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x15_9c97, 3); or(ax, memw_a16[ss, bp - 0xc]);           /* or ax, [bp-0xc] */
            ii(0x15_9c9a, 2); if(jzw(0x15_9cd5, 0x39)) goto l_0x15_9cd5; /* jz 0x9cd5 */
            ii(0x15_9c9c, 1); pushw(dx);                                /* push dx */
            ii(0x15_9c9d, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x15_9ca0, 5); callw_far_abs(0x80, 0x55dc);              /* call word 0x80:0x55dc */
            ii(0x15_9ca5, 1); popw(bx);                                 /* pop bx */
            ii(0x15_9ca6, 1); popw(bx);                                 /* pop bx */
            ii(0x15_9ca7, 1); pushw(dx);                                /* push dx */
            ii(0x15_9ca8, 1); pushw(ax);                                /* push ax */
            ii(0x15_9ca9, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_9cab, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_9cae, 3); callw(0x15_fb9f, 0x5eee);                 /* call 0xfb9f */
            ii(0x15_9cb1, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_9cb3, 2); if(jzw(0x15_9c64, -0x51)) goto l_0x15_9c64; /* jz 0x9c64 */
            ii(0x15_9cb5, 5); callw_far_abs(0x80, 0x5740);              /* call word 0x80:0x5740 */
            ii(0x15_9cba, 6); mov(memw_a16[ds, 0x2b9a], 0);             /* mov word [0x2b9a], 0x0 */
            ii(0x15_9cc0, 3); mov(memw_a16[ds, 0x2b9c], ax);            /* mov [0x2b9c], ax */
            ii(0x15_9cc3, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_9cc5, 2); pushw(0x10);                              /* push 0x10 */
            ii(0x15_9cc7, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x15_9cca, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x15_9ccd, 1); nop();                                    /* nop */
            ii(0x15_9cce, 1); pushw(cs);                                /* push cs */
            ii(0x15_9ccf, 3); callw(0x16_0faf, 0x72dd);                 /* call 0xfaf */
            ii(0x15_9cd2, 3); add(sp, 0x8);                             /* add sp, 0x8 */
        l_0x15_9cd5:
            ii(0x15_9cd5, 3); mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0x15_9cd8, 3); mov(dx, memw_a16[ss, bp - 0xa]);          /* mov dx, [bp-0xa] */
            ii(0x15_9cdb, 3); jmpw(0x15_9db4, 0xd6); goto l_0x15_9db4;  /* jmp 0x9db4 */
        l_0x15_9cde:
            ii(0x15_9cde, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_9ce0, 3); lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x15_9ce3, 1); pushw(ss);                                /* push ss */
            ii(0x15_9ce4, 1); pushw(ax);                                /* push ax */
            ii(0x15_9ce5, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_9ce8, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_9ceb, 3); callw(0x15_9bb6, -0x138);                 /* call 0x9bb6 */
            ii(0x15_9cee, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x15_9cf1, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_9cf3, 2); if(jgew(0x15_9cf8, 0x3)) goto l_0x15_9cf8; /* jge 0x9cf8 */
            ii(0x15_9cf5, 3); jmpw(0x15_9c64, -0x94); goto l_0x15_9c64; /* jmp 0x9c64 */
        l_0x15_9cf8:
            ii(0x15_9cf8, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x15_9cfb, 3); mov(memw_a16[ds, 0x1f22], ax);            /* mov [0x1f22], ax */
            ii(0x15_9cfe, 4); cmp(memw_a16[ss, bp - 0xe], 0);           /* cmp word [bp-0xe], 0x0 */
            ii(0x15_9d02, 2); if(jlew(0x15_9d3e, 0x3a)) goto l_0x15_9d3e; /* jle 0x9d3e */
            ii(0x15_9d04, 2); pushw(0x2);                               /* push 0x2 */
            ii(0x15_9d06, 3); lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x15_9d09, 1); pushw(ss);                                /* push ss */
            ii(0x15_9d0a, 1); pushw(ax);                                /* push ax */
            ii(0x15_9d0b, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_9d0d, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_9d0f, 3); callw(0x15_9bb6, -0x15c);                 /* call 0x9bb6 */
            ii(0x15_9d12, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_9d14, 2); if(jlw(0x15_9cd5, -0x41)) goto l_0x15_9cd5; /* jl 0x9cd5 */
            ii(0x15_9d16, 2); pushw(0x9);                               /* push 0x9 */
            ii(0x15_9d18, 3); lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x15_9d1b, 1); pushw(ss);                                /* push ss */
            ii(0x15_9d1c, 1); pushw(ax);                                /* push ax */
            ii(0x15_9d1d, 3); lea(ax, bp - 0x32);                       /* lea ax, [bp-0x32] */
            ii(0x15_9d20, 1); pushw(ss);                                /* push ss */
            ii(0x15_9d21, 1); pushw(ax);                                /* push ax */
            ii(0x15_9d22, 3); callw(0x15_9bb6, -0x16f);                 /* call 0x9bb6 */
            ii(0x15_9d25, 3); mov(ax, memw_a16[ss, bp - 0x1c]);         /* mov ax, [bp-0x1c] */
            ii(0x15_9d28, 5); mov(memw_a16[ss, bp - 0xc], 0);           /* mov word [bp-0xc], 0x0 */
            ii(0x15_9d2d, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x15_9d30, 3); mov(ax, memw_a16[ss, bp - 0x22]);         /* mov ax, [bp-0x22] */
            ii(0x15_9d33, 6); mov(memw_a16[ds, 0x2b9a], 0);             /* mov word [0x2b9a], 0x0 */
            ii(0x15_9d39, 3); mov(memw_a16[ds, 0x2b9c], ax);            /* mov [0x2b9c], ax */
            ii(0x15_9d3c, 2); jmpw(0x15_9cd5, -0x69); goto l_0x15_9cd5; /* jmp 0x9cd5 */
        l_0x15_9d3e:
            ii(0x15_9d3e, 1); pushw(ax);                                /* push ax */
            ii(0x15_9d3f, 3); pushw(0x1a8);                             /* push 0x1a8 */
            ii(0x15_9d42, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_9d44, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_9d47, 4); mov(es, memw_a16[ds, 0x3fc0]);            /* mov es, [0x3fc0] */
            ii(0x15_9d4b, 5); callw_a16_far_ind(es, 0x32ac);            /* call far word [es:0x32ac] */
            ii(0x15_9d50, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_9d53, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_9d56, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x15_9d59, 2); pushw(0x5);                               /* push 0x5 */
            ii(0x15_9d5b, 3); lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x15_9d5e, 1); pushw(ss);                                /* push ss */
            ii(0x15_9d5f, 1); pushw(ax);                                /* push ax */
            ii(0x15_9d60, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_9d62, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_9d64, 3); callw(0x15_9bb6, -0x1b1);                 /* call 0x9bb6 */
            ii(0x15_9d67, 3); mov(memw_a16[ds, 0x2b9c], ax);            /* mov [0x2b9c], ax */
            ii(0x15_9d6a, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x15_9d6d, 3); or(ax, memw_a16[ss, bp - 0xc]);           /* or ax, [bp-0xc] */
            ii(0x15_9d70, 2); if(jzw(0x15_9da3, 0x31)) goto l_0x15_9da3; /* jz 0x9da3 */
            ii(0x15_9d72, 5); cmp(memw_a16[ds, 0x2b9c], 0);             /* cmp word [0x2b9c], 0x0 */
            ii(0x15_9d77, 2); if(jzw(0x15_9da3, 0x2a)) goto l_0x15_9da3; /* jz 0x9da3 */
            ii(0x15_9d79, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x15_9d7c, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x15_9d7f, 3); mov(ax, memw_a16[ds, 0x2b9c]);            /* mov ax, [0x2b9c] */
            ii(0x15_9d82, 3); mov(memw_a16[ss, bp - 0x22], ax);         /* mov [bp-0x22], ax */
            ii(0x15_9d85, 2); pushw(0x6);                               /* push 0x6 */
            ii(0x15_9d87, 3); lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x15_9d8a, 1); pushw(ss);                                /* push ss */
            ii(0x15_9d8b, 1); pushw(ax);                                /* push ax */
            ii(0x15_9d8c, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x15_9d8f, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x15_9d92, 3); callw(0x15_9bb6, -0x1df);                 /* call 0x9bb6 */
            ii(0x15_9d95, 2); pushw(0x8);                               /* push 0x8 */
            ii(0x15_9d97, 3); lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x15_9d9a, 1); pushw(ss);                                /* push ss */
            ii(0x15_9d9b, 1); pushw(ax);                                /* push ax */
            ii(0x15_9d9c, 3); lea(ax, bp - 0x32);                       /* lea ax, [bp-0x32] */
            ii(0x15_9d9f, 1); pushw(ss);                                /* push ss */
            ii(0x15_9da0, 1); pushw(ax);                                /* push ax */
            ii(0x15_9da1, 2); jmpw(0x15_9dae, 0xb); goto l_0x15_9dae;   /* jmp 0x9dae */
        l_0x15_9da3:
            ii(0x15_9da3, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x15_9da5, 3); lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x15_9da8, 1); pushw(ss);                                /* push ss */
            ii(0x15_9da9, 1); pushw(ax);                                /* push ax */
            ii(0x15_9daa, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_9dac, 2); pushw(0);                                 /* push 0x0 */
        l_0x15_9dae:
            ii(0x15_9dae, 3); callw(0x15_9bb6, -0x1fb);                 /* call 0x9bb6 */
            ii(0x15_9db1, 3); jmpw(0x15_9cd5, -0xdf); goto l_0x15_9cd5; /* jmp 0x9cd5 */
        l_0x15_9db4:
            ii(0x15_9db4, 1); leavew();                                 /* leave */
            ii(0x15_9db5, 3); retw(0x6); return;                        /* ret 0x6 */
        }
    }
}
