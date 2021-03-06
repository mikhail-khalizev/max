using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_9c30-ba370054")]
        public void Method_0019_9c30()
        {
            ii(0x19_9c30, 4);  enter(0x32, 0);                         /* enter 0x32, 0x0 */
            ii(0x19_9c34, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_9c36, 3);  mov(memw[ss, bp - 10], ax);             /* mov [bp-0xa], ax */
            ii(0x19_9c39, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_9c3c, 4);  mov(es, memw[ds, 0x3fbe]);              /* mov es, [0x3fbe] */
            ii(0x19_9c40, 4);  mov(ax, memw[es, 0x3b84]);              /* mov ax, [es:0x3b84] */
            ii(0x19_9c44, 5);  mov(memw[ss, bp - 8], 0);               /* mov word [bp-0x8], 0x0 */
            ii(0x19_9c49, 3);  mov(memw[ss, bp - 6], ax);              /* mov [bp-0x6], ax */
            ii(0x19_9c4c, 5);  mov(memw[ss, bp - 16], 0);              /* mov word [bp-0x10], 0x0 */
            ii(0x19_9c51, 2);  push(-1 /* 0xff */);                    /* push 0xffff */
            ii(0x19_9c53, 2);  push(-1 /* 0xff */);                    /* push 0xffff */
            ii(0x19_9c55, 2);  push(0);                                /* push 0x0 */
            ii(0x19_9c57, 2);  push(0);                                /* push 0x0 */
            ii(0x19_9c59, 1);  push(cs);                               /* push cs */
            ii(0x19_9c5a, 3);  call(0x19_9be0, -0x7d);                 /* call 0x9be0 */
            ii(0x19_9c5d, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x19_9c60, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x19_9c62, 2);  if(jnz(0x19_9c6a, 6)) goto l_0x19_9c6a; /* jnz 0x9c6a */
        l_0x19_9c64:
            ii(0x19_9c64, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_9c66, 1);  cwd();                                  /* cwd */
            ii(0x19_9c67, 3);  jmp(0x19_9db4, 0x14a); goto l_0x19_9db4;/* jmp 0x9db4 */
        l_0x19_9c6a:
            ii(0x19_9c6a, 3);  mov(ax, memw[ds, 0x3292]);              /* mov ax, [0x3292] */
            ii(0x19_9c6d, 4);  or(ax, memw[ds, 0x3290]);               /* or ax, [0x3290] */
            ii(0x19_9c71, 2);  if(jz(0x19_9c7d, 0xa)) goto l_0x19_9c7d;/* jz 0x9c7d */
            ii(0x19_9c73, 5);  cmp(memb[ds, 0x19f4], 1);               /* cmp byte [0x19f4], 0x1 */
            ii(0x19_9c78, 2);  if(jnz(0x19_9c7d, 3)) goto l_0x19_9c7d; /* jnz 0x9c7d */
            ii(0x19_9c7a, 3);  inc(memw[ss, bp - 16]);                 /* inc word [bp-0x10] */
        l_0x19_9c7d:
            ii(0x19_9c7d, 4);  cmp(memw[ss, bp - 16], 0);              /* cmp word [bp-0x10], 0x0 */
            ii(0x19_9c81, 2);  if(jnz(0x19_9cde, 0x5b)) goto l_0x19_9cde;/* jnz 0x9cde */
            ii(0x19_9c83, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_9c86, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_9c89, 3);  push(memw[ss, bp + 4]);                 /* push word [bp+0x4] */
            ii(0x19_9c8c, 3);  call(0x19_c7eb, 0x2b5c);                /* call 0xc7eb */
            ii(0x19_9c8f, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_9c92, 3);  mov(memw[ss, bp - 10], dx);             /* mov [bp-0xa], dx */
            ii(0x19_9c95, 2);  mov(ax, dx);                            /* mov ax, dx */
            ii(0x19_9c97, 3);  or(ax, memw[ss, bp - 12]);              /* or ax, [bp-0xc] */
            ii(0x19_9c9a, 2);  if(jz(0x19_9cd5, 0x39)) goto l_0x19_9cd5;/* jz 0x9cd5 */
            ii(0x19_9c9c, 1);  push(dx);                               /* push dx */
            ii(0x19_9c9d, 3);  push(memw[ss, bp - 12]);                /* push word [bp-0xc] */
            ii(0x19_9ca0, 5);  call_far_abs(0x80, 0x55dc);             /* call word 0x80:0x55dc */
            ii(0x19_9ca5, 1);  pop(bx);                                /* pop bx */
            ii(0x19_9ca6, 1);  pop(bx);                                /* pop bx */
            ii(0x19_9ca7, 1);  push(dx);                               /* push dx */
            ii(0x19_9ca8, 1);  push(ax);                               /* push ax */
            ii(0x19_9ca9, 2);  push(0);                                /* push 0x0 */
            ii(0x19_9cab, 3);  push(memw[ss, bp + 4]);                 /* push word [bp+0x4] */
            ii(0x19_9cae, 3);  call(0x19_fb9f, 0x5eee);                /* call 0xfb9f */
            ii(0x19_9cb1, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x19_9cb3, 2);  if(jz(0x19_9c64, -0x51)) goto l_0x19_9c64;/* jz 0x9c64 */
            ii(0x19_9cb5, 5);  call_far_abs(0x80, 0x5740);             /* call word 0x80:0x5740 */
            ii(0x19_9cba, 6);  mov(memw[ds, 0x2b9a], 0);               /* mov word [0x2b9a], 0x0 */
            ii(0x19_9cc0, 3);  mov(memw[ds, 0x2b9c], ax);              /* mov [0x2b9c], ax */
            ii(0x19_9cc3, 2);  push(0);                                /* push 0x0 */
            ii(0x19_9cc5, 2);  push(0x10);                             /* push 0x10 */
            ii(0x19_9cc7, 3);  push(memw[ss, bp - 10]);                /* push word [bp-0xa] */
            ii(0x19_9cca, 3);  push(memw[ss, bp - 12]);                /* push word [bp-0xc] */
            ii(0x19_9ccd, 1);  nop();                                  /* nop */
            ii(0x19_9cce, 1);  push(cs);                               /* push cs */
            ii(0x19_9ccf, 3);  call(0x1a_0faf, 0x72dd);                /* call 0xfaf */
            ii(0x19_9cd2, 3);  add(sp, 8);                             /* add sp, 0x8 */
        l_0x19_9cd5:
            ii(0x19_9cd5, 3);  mov(ax, memw[ss, bp - 12]);             /* mov ax, [bp-0xc] */
            ii(0x19_9cd8, 3);  mov(dx, memw[ss, bp - 10]);             /* mov dx, [bp-0xa] */
            ii(0x19_9cdb, 3);  jmp(0x19_9db4, 0xd6); goto l_0x19_9db4; /* jmp 0x9db4 */
        l_0x19_9cde:
            ii(0x19_9cde, 2);  push(1);                                /* push 0x1 */
            ii(0x19_9ce0, 3);  lea(ax, memw[ss, bp - 4]);              /* lea ax, [bp-0x4] */
            ii(0x19_9ce3, 1);  push(ss);                               /* push ss */
            ii(0x19_9ce4, 1);  push(ax);                               /* push ax */
            ii(0x19_9ce5, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_9ce8, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_9ceb, 3);  call(0x19_9bb6, -0x138);                /* call 0x9bb6 */
            ii(0x19_9cee, 3);  mov(memw[ss, bp - 14], ax);             /* mov [bp-0xe], ax */
            ii(0x19_9cf1, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x19_9cf3, 2);  if(jge(0x19_9cf8, 3)) goto l_0x19_9cf8; /* jge 0x9cf8 */
            ii(0x19_9cf5, 3);  jmp(0x19_9c64, -0x94); goto l_0x19_9c64;/* jmp 0x9c64 */
        l_0x19_9cf8:
            ii(0x19_9cf8, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x19_9cfb, 3);  mov(memw[ds, 0x1f22], ax);              /* mov [0x1f22], ax */
            ii(0x19_9cfe, 4);  cmp(memw[ss, bp - 14], 0);              /* cmp word [bp-0xe], 0x0 */
            ii(0x19_9d02, 2);  if(jle(0x19_9d3e, 0x3a)) goto l_0x19_9d3e;/* jle 0x9d3e */
            ii(0x19_9d04, 2);  push(2);                                /* push 0x2 */
            ii(0x19_9d06, 3);  lea(ax, memw[ss, bp - 4]);              /* lea ax, [bp-0x4] */
            ii(0x19_9d09, 1);  push(ss);                               /* push ss */
            ii(0x19_9d0a, 1);  push(ax);                               /* push ax */
            ii(0x19_9d0b, 2);  push(0);                                /* push 0x0 */
            ii(0x19_9d0d, 2);  push(0);                                /* push 0x0 */
            ii(0x19_9d0f, 3);  call(0x19_9bb6, -0x15c);                /* call 0x9bb6 */
            ii(0x19_9d12, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x19_9d14, 2);  if(jl(0x19_9cd5, -0x41)) goto l_0x19_9cd5;/* jl 0x9cd5 */
            ii(0x19_9d16, 2);  push(9);                                /* push 0x9 */
            ii(0x19_9d18, 3);  lea(ax, memw[ss, bp - 4]);              /* lea ax, [bp-0x4] */
            ii(0x19_9d1b, 1);  push(ss);                               /* push ss */
            ii(0x19_9d1c, 1);  push(ax);                               /* push ax */
            ii(0x19_9d1d, 3);  lea(ax, memw[ss, bp - 50]);             /* lea ax, [bp-0x32] */
            ii(0x19_9d20, 1);  push(ss);                               /* push ss */
            ii(0x19_9d21, 1);  push(ax);                               /* push ax */
            ii(0x19_9d22, 3);  call(0x19_9bb6, -0x16f);                /* call 0x9bb6 */
            ii(0x19_9d25, 3);  mov(ax, memw[ss, bp - 28]);             /* mov ax, [bp-0x1c] */
            ii(0x19_9d28, 5);  mov(memw[ss, bp - 12], 0);              /* mov word [bp-0xc], 0x0 */
            ii(0x19_9d2d, 3);  mov(memw[ss, bp - 10], ax);             /* mov [bp-0xa], ax */
            ii(0x19_9d30, 3);  mov(ax, memw[ss, bp - 34]);             /* mov ax, [bp-0x22] */
            ii(0x19_9d33, 6);  mov(memw[ds, 0x2b9a], 0);               /* mov word [0x2b9a], 0x0 */
            ii(0x19_9d39, 3);  mov(memw[ds, 0x2b9c], ax);              /* mov [0x2b9c], ax */
            ii(0x19_9d3c, 2);  jmp(0x19_9cd5, -0x69); goto l_0x19_9cd5;/* jmp 0x9cd5 */
        l_0x19_9d3e:
            ii(0x19_9d3e, 1);  push(ax);                               /* push ax */
            ii(0x19_9d3f, 3);  push(0x1a8);                            /* push 0x1a8 */
            ii(0x19_9d42, 2);  push(0);                                /* push 0x0 */
            ii(0x19_9d44, 3);  push(memw[ss, bp + 4]);                 /* push word [bp+0x4] */
            ii(0x19_9d47, 4);  mov(es, memw[ds, 0x3fc0]);              /* mov es, [0x3fc0] */
            ii(0x19_9d4b, 5);  call_far_ind(memw[es, 0x32ac]);         /* call far word [es:0x32ac] */
            ii(0x19_9d50, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x19_9d53, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_9d56, 3);  mov(memw[ss, bp - 10], dx);             /* mov [bp-0xa], dx */
            ii(0x19_9d59, 2);  push(5);                                /* push 0x5 */
            ii(0x19_9d5b, 3);  lea(ax, memw[ss, bp - 4]);              /* lea ax, [bp-0x4] */
            ii(0x19_9d5e, 1);  push(ss);                               /* push ss */
            ii(0x19_9d5f, 1);  push(ax);                               /* push ax */
            ii(0x19_9d60, 2);  push(0);                                /* push 0x0 */
            ii(0x19_9d62, 2);  push(1);                                /* push 0x1 */
            ii(0x19_9d64, 3);  call(0x19_9bb6, -0x1b1);                /* call 0x9bb6 */
            ii(0x19_9d67, 3);  mov(memw[ds, 0x2b9c], ax);              /* mov [0x2b9c], ax */
            ii(0x19_9d6a, 3);  mov(ax, memw[ss, bp - 10]);             /* mov ax, [bp-0xa] */
            ii(0x19_9d6d, 3);  or(ax, memw[ss, bp - 12]);              /* or ax, [bp-0xc] */
            ii(0x19_9d70, 2);  if(jz(0x19_9da3, 0x31)) goto l_0x19_9da3;/* jz 0x9da3 */
            ii(0x19_9d72, 5);  cmp(memw[ds, 0x2b9c], 0);               /* cmp word [0x2b9c], 0x0 */
            ii(0x19_9d77, 2);  if(jz(0x19_9da3, 0x2a)) goto l_0x19_9da3;/* jz 0x9da3 */
            ii(0x19_9d79, 3);  mov(ax, memw[ss, bp - 10]);             /* mov ax, [bp-0xa] */
            ii(0x19_9d7c, 3);  mov(memw[ss, bp - 28], ax);             /* mov [bp-0x1c], ax */
            ii(0x19_9d7f, 3);  mov(ax, memw[ds, 0x2b9c]);              /* mov ax, [0x2b9c] */
            ii(0x19_9d82, 3);  mov(memw[ss, bp - 34], ax);             /* mov [bp-0x22], ax */
            ii(0x19_9d85, 2);  push(6);                                /* push 0x6 */
            ii(0x19_9d87, 3);  lea(ax, memw[ss, bp - 4]);              /* lea ax, [bp-0x4] */
            ii(0x19_9d8a, 1);  push(ss);                               /* push ss */
            ii(0x19_9d8b, 1);  push(ax);                               /* push ax */
            ii(0x19_9d8c, 3);  push(memw[ss, bp - 10]);                /* push word [bp-0xa] */
            ii(0x19_9d8f, 3);  push(memw[ss, bp - 12]);                /* push word [bp-0xc] */
            ii(0x19_9d92, 3);  call(0x19_9bb6, -0x1df);                /* call 0x9bb6 */
            ii(0x19_9d95, 2);  push(8);                                /* push 0x8 */
            ii(0x19_9d97, 3);  lea(ax, memw[ss, bp - 4]);              /* lea ax, [bp-0x4] */
            ii(0x19_9d9a, 1);  push(ss);                               /* push ss */
            ii(0x19_9d9b, 1);  push(ax);                               /* push ax */
            ii(0x19_9d9c, 3);  lea(ax, memw[ss, bp - 50]);             /* lea ax, [bp-0x32] */
            ii(0x19_9d9f, 1);  push(ss);                               /* push ss */
            ii(0x19_9da0, 1);  push(ax);                               /* push ax */
            ii(0x19_9da1, 2);  jmp(0x19_9dae, 0xb); goto l_0x19_9dae;  /* jmp 0x9dae */
        l_0x19_9da3:
            ii(0x19_9da3, 2);  push(4);                                /* push 0x4 */
            ii(0x19_9da5, 3);  lea(ax, memw[ss, bp - 4]);              /* lea ax, [bp-0x4] */
            ii(0x19_9da8, 1);  push(ss);                               /* push ss */
            ii(0x19_9da9, 1);  push(ax);                               /* push ax */
            ii(0x19_9daa, 2);  push(0);                                /* push 0x0 */
            ii(0x19_9dac, 2);  push(0);                                /* push 0x0 */
        l_0x19_9dae:
            ii(0x19_9dae, 3);  call(0x19_9bb6, -0x1fb);                /* call 0x9bb6 */
            ii(0x19_9db1, 3);  jmp(0x19_9cd5, -0xdf); goto l_0x19_9cd5;/* jmp 0x9cd5 */
        l_0x19_9db4:
            ii(0x19_9db4, 1);  leave();                                /* leave */
            ii(0x19_9db5, 3);  ret(6);                                 /* ret 0x6 */
        }
    }
}
