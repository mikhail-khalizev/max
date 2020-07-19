using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8dee-11c6c4dd")]
        public void Method_0000_8dee()
        {
            ii(0x8dee, 4);  enter(0x1c, 0);                            /* enter 0x1c, 0x0 */
            ii(0x8df2, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x8df4, 3);  mov(memw[ds, 0xa6], ax);                   /* mov [0xa6], ax */
            ii(0x8df7, 3);  mov(memw[ds, 0xa4], ax);                   /* mov [0xa4], ax */
            ii(0x8dfa, 3);  mov(memw[ds, 0x9e], ax);                   /* mov [0x9e], ax */
            ii(0x8dfd, 3);  mov(memw[ds, 0x9c], ax);                   /* mov [0x9c], ax */
            ii(0x8e00, 3);  mov(memw[ds, 0x9a], ax);                   /* mov [0x9a], ax */
            ii(0x8e03, 3);  mov(memw[ds, 0x98], ax);                   /* mov [0x98], ax */
            ii(0x8e06, 6);  mov(memw[ds, 0xa0], 0x98);                 /* mov word [0xa0], 0x98 */
            ii(0x8e0c, 4);  mov(memw[ds, 0xa2], ds);                   /* mov [0xa2], ds */
            ii(0x8e10, 5);  cmp(memb[ds, 0x2e], 0xb);                  /* cmp byte [0x2e], 0xb */
            ii(0x8e15, 2);  if(jnz(0x8e4c, 0x35)) goto l_0x8e4c;       /* jnz 0x8e4c */
            ii(0x8e17, 4);  push(memw[ds, 0xeca]);                     /* push word [0xeca] */
            ii(0x8e1b, 3);  call(0xa4ec, 0x16ce);                      /* call 0xa4ec */
            ii(0x8e1e, 1);  pop(bx);                                   /* pop bx */
            ii(0x8e1f, 3);  mov(memw[ds, 0x98], ax);                   /* mov [0x98], ax */
            ii(0x8e22, 4);  mov(memw[ds, 0x9a], dx);                   /* mov [0x9a], dx */
            ii(0x8e26, 3);  mov(ax, memw[ds, 0xecc]);                  /* mov ax, [0xecc] */
            ii(0x8e29, 4);  add(ax, memw[ds, 0xeca]);                  /* add ax, [0xeca] */
            ii(0x8e2d, 3);  mov(memw[ss, bp - 28], ax);                /* mov [bp-0x1c], ax */
            ii(0x8e30, 4);  cmp(ax, memw[ds, 0xeca]);                  /* cmp ax, [0xeca] */
            ii(0x8e34, 2);  if(jae(0x8e3b, 5)) goto l_0x8e3b;          /* jae 0x8e3b */
            ii(0x8e36, 5);  mov(memw[ss, bp - 28], 0xff00);            /* mov word [bp-0x1c], 0xff00 */
        l_0x8e3b:
            ii(0x8e3b, 3);  push(memw[ss, bp - 28]);                   /* push word [bp-0x1c] */
            ii(0x8e3e, 3);  call(0xa4ec, 0x16ab);                      /* call 0xa4ec */
            ii(0x8e41, 1);  pop(bx);                                   /* pop bx */
            ii(0x8e42, 3);  mov(memw[ds, 0x9c], ax);                   /* mov [0x9c], ax */
            ii(0x8e45, 4);  mov(memw[ds, 0x9e], dx);                   /* mov [0x9e], dx */
            ii(0x8e49, 3);  jmp(0x8f36, 0xea); goto l_0x8f36;          /* jmp 0x8f36 */
        l_0x8e4c:
            ii(0x8e4c, 5);  test(memb[ds, 0x47], 1);                   /* test byte [0x47], 0x1 */
            ii(0x8e51, 2);  if(jnz(0x8e97, 0x44)) goto l_0x8e97;       /* jnz 0x8e97 */
            ii(0x8e53, 4);  push(memw[ds, 0xeca]);                     /* push word [0xeca] */
            ii(0x8e57, 3);  call(0xa4ec, 0x1692);                      /* call 0xa4ec */
            ii(0x8e5a, 1);  pop(bx);                                   /* pop bx */
            ii(0x8e5b, 3);  mov(memw[ds, 0x98], ax);                   /* mov [0x98], ax */
            ii(0x8e5e, 4);  mov(memw[ds, 0x9a], dx);                   /* mov [0x9a], dx */
            ii(0x8e62, 4);  push(memw[ds, 0xece]);                     /* push word [0xece] */
            ii(0x8e66, 3);  call(0xa4ec, 0x1683);                      /* call 0xa4ec */
            ii(0x8e69, 1);  pop(bx);                                   /* pop bx */
            ii(0x8e6a, 3);  mov(memw[ds, 0x9c], ax);                   /* mov [0x9c], ax */
            ii(0x8e6d, 4);  mov(memw[ds, 0x9e], dx);                   /* mov [0x9e], dx */
            ii(0x8e71, 3);  call(0xaa24, 0x1bb0);                      /* call 0xaa24 */
            ii(0x8e74, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x8e76, 2);  if(jnz(0x8e7b, 3)) goto l_0x8e7b;          /* jnz 0x8e7b */
            ii(0x8e78, 3);  jmp(0x8f36, 0xbb); goto l_0x8f36;          /* jmp 0x8f36 */
        l_0x8e7b:
            ii(0x8e7b, 3);  mov(ax, memw[ds, 0xecc]);                  /* mov ax, [0xecc] */
            ii(0x8e7e, 3);  mov(memw[ds, 0xa8], ax);                   /* mov [0xa8], ax */
            ii(0x8e81, 1);  push(ax);                                  /* push ax */
            ii(0x8e82, 3);  call(0xa4ec, 0x1667);                      /* call 0xa4ec */
            ii(0x8e85, 1);  pop(bx);                                   /* pop bx */
            ii(0x8e86, 4);  add(ax, memw[ds, 0x98]);                   /* add ax, [0x98] */
            ii(0x8e8a, 4);  adc(dx, memw[ds, 0x9a]);                   /* adc dx, [0x9a] */
        l_0x8e8e:
            ii(0x8e8e, 3);  mov(memw[ds, 0x9c], ax);                   /* mov [0x9c], ax */
            ii(0x8e91, 4);  mov(memw[ds, 0x9e], dx);                   /* mov [0x9e], dx */
            ii(0x8e95, 1);  leave();                                   /* leave */
            ii(0x8e96, 1);  ret(); return;                             /* ret */
        l_0x8e97:
            ii(0x8e97, 4);  mov(memb[ss, bp - 13], 0x88);              /* mov byte [bp-0xd], 0x88 */
            ii(0x8e9b, 3);  lea(ax, memw[ss, bp - 14]);                /* lea ax, [bp-0xe] */
            ii(0x8e9e, 1);  push(ax);                                  /* push ax */
            ii(0x8e9f, 1);  push(ax);                                  /* push ax */
            ii(0x8ea0, 2);  push(0x15);                                /* push 0x15 */
            ii(0x8ea2, 3);  call(0x9e24, 0xf7f);                       /* call 0x9e24 */
            ii(0x8ea5, 3);  add(sp, 6);                                /* add sp, 0x6 */
            ii(0x8ea8, 3);  mov(ax, memw[ss, bp - 14]);                /* mov ax, [bp-0xe] */
            ii(0x8eab, 3);  mov(memw[ds, 0xa8], ax);                   /* mov [0xa8], ax */
            ii(0x8eae, 3);  call(0xaa24, 0x1b73);                      /* call 0xaa24 */
            ii(0x8eb1, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x8eb3, 2);  if(jnz(0x8e7b, -0x3a)) goto l_0x8e7b;      /* jnz 0x8e7b */
            ii(0x8eb5, 6);  cmp(memw[ds, 0xa8], 0xfc00);               /* cmp word [0xa8], 0xfc00 */
            ii(0x8ebb, 2);  if(jb(0x8ec1, 4)) goto l_0x8ec1;           /* jb 0x8ec1 */
            ii(0x8ebd, 4);  dec(memw[ds, 0xa8]);                       /* dec word [0xa8] */
        l_0x8ec1:
            ii(0x8ec1, 4);  push(memw[ds, 0xa8]);                      /* push word [0xa8] */
            ii(0x8ec5, 3);  call(0xa4ec, 0x1624);                      /* call 0xa4ec */
            ii(0x8ec8, 1);  pop(bx);                                   /* pop bx */
            ii(0x8ec9, 3);  add(ax, 0);                                /* add ax, 0x0 */
            ii(0x8ecc, 3);  adc(dx, 1);                                /* adc dx, 0x1 */
            ii(0x8ecf, 3);  mov(memw[ss, bp - 18], ax);                /* mov [bp-0x12], ax */
            ii(0x8ed2, 3);  mov(memw[ss, bp - 16], dx);                /* mov [bp-0x10], dx */
            ii(0x8ed5, 3);  call(0x8d92, -0x146);                      /* call 0x8d92 */
            ii(0x8ed8, 4);  cmp(memw[ss, bp - 14], 0);                 /* cmp word [bp-0xe], 0x0 */
            ii(0x8edc, 2);  if(jz(0x8f36, 0x58)) goto l_0x8f36;        /* jz 0x8f36 */
            ii(0x8ede, 6);  mov(memw[ds, 0xaa4], 0x1b41);              /* mov word [0xaa4], 0x1b41 */
            ii(0x8ee4, 6);  mov(memw[ds, 0xaa6], 0x1bb5);              /* mov word [0xaa6], 0x1bb5 */
            ii(0x8eea, 6);  mov(memw[ds, 0x98], 0);                    /* mov word [0x98], 0x0 */
            ii(0x8ef0, 6);  mov(memw[ds, 0x9a], 1);                    /* mov word [0x9a], 0x1 */
            ii(0x8ef6, 3);  mov(ax, memw[ss, bp - 18]);                /* mov ax, [bp-0x12] */
            ii(0x8ef9, 3);  mov(dx, memw[ss, bp - 16]);                /* mov dx, [bp-0x10] */
            ii(0x8efc, 3);  mov(memw[ds, 0x9c], ax);                   /* mov [0x9c], ax */
            ii(0x8eff, 4);  mov(memw[ds, 0x9e], dx);                   /* mov [0x9e], dx */
            ii(0x8f03, 3);  call(0x8cca, -0x23c);                      /* call 0x8cca */
            ii(0x8f06, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x8f08, 2);  if(jnz(0x8f36, 0x2c)) goto l_0x8f36;       /* jnz 0x8f36 */
            ii(0x8f0a, 5);  mov(memw[ss, bp - 14], 0x3519);            /* mov word [bp-0xe], 0x3519 */
            ii(0x8f0f, 3);  lea(ax, memw[ss, bp - 26]);                /* lea ax, [bp-0x1a] */
            ii(0x8f12, 1);  push(ax);                                  /* push ax */
            ii(0x8f13, 3);  lea(cx, memw[ss, bp - 14]);                /* lea cx, [bp-0xe] */
            ii(0x8f16, 1);  push(cx);                                  /* push cx */
            ii(0x8f17, 1);  push(cx);                                  /* push cx */
            ii(0x8f18, 3);  call(0x64b8, -0x2a63);                     /* call 0x64b8 */
            ii(0x8f1b, 3);  add(sp, 6);                                /* add sp, 0x6 */
            ii(0x8f1e, 2);  push(0);                                   /* push 0x0 */
            ii(0x8f20, 3);  push(memw[ss, bp - 26]);                   /* push word [bp-0x1a] */
            ii(0x8f23, 3);  call(0x8bd6, -0x350);                      /* call 0x8bd6 */
            ii(0x8f26, 1);  pop(bx);                                   /* pop bx */
            ii(0x8f27, 1);  pop(bx);                                   /* pop bx */
            ii(0x8f28, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x8f2a, 2);  if(jnz(0x8f33, 7)) goto l_0x8f33;          /* jnz 0x8f33 */
            ii(0x8f2c, 3);  push(0x4e36);                              /* push 0x4e36 */
            ii(0x8f2f, 3);  call(0x8d23, -0x20f);                      /* call 0x8d23 */
            ii(0x8f32, 1);  pop(bx);                                   /* pop bx */
        l_0x8f33:
            ii(0x8f33, 3);  call(0x8c54, -0x2e2);                      /* call 0x8c54 */
        l_0x8f36:
            ii(0x8f36, 5);  cmp(memw[ds, 0xecc], 0);                   /* cmp word [0xecc], 0x0 */
            ii(0x8f3b, 2);  if(jnz(0x8f47, 0xa)) goto l_0x8f47;        /* jnz 0x8f47 */
            ii(0x8f3d, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x8f3f, 3);  mov(memw[ds, 0x9e], ax);                   /* mov [0x9e], ax */
            ii(0x8f42, 3);  mov(memw[ds, 0x9c], ax);                   /* mov [0x9c], ax */
            ii(0x8f45, 1);  leave();                                   /* leave */
            ii(0x8f46, 1);  ret(); return;                             /* ret */
        l_0x8f47:
            ii(0x8f47, 3);  mov(ax, memw[ds, 0x9c]);                   /* mov ax, [0x9c] */
            ii(0x8f4a, 4);  mov(dx, memw[ds, 0x9e]);                   /* mov dx, [0x9e] */
            ii(0x8f4e, 2);  mov(cl, 6);                                /* mov cl, 0x6 */
            ii(0x8f50, 3);  call(0x9f82, 0x102f);                      /* call 0x9f82 */
            ii(0x8f53, 4);  cmp(ax, memw[ds, 0xece]);                  /* cmp ax, [0xece] */
            ii(0x8f57, 2);  if(jbe(0x8f68, 0xf)) goto l_0x8f68;        /* jbe 0x8f68 */
            ii(0x8f59, 4);  push(memw[ds, 0xece]);                     /* push word [0xece] */
            ii(0x8f5d, 3);  call(0xa4ec, 0x158c);                      /* call 0xa4ec */
            ii(0x8f60, 1);  pop(bx);                                   /* pop bx */
            ii(0x8f61, 3);  mov(memw[ds, 0x9c], ax);                   /* mov [0x9c], ax */
            ii(0x8f64, 4);  mov(memw[ds, 0x9e], dx);                   /* mov [0x9e], dx */
        l_0x8f68:
            ii(0x8f68, 4);  push(memw[ds, 0xecc]);                     /* push word [0xecc] */
            ii(0x8f6c, 3);  call(0xa4ec, 0x157d);                      /* call 0xa4ec */
            ii(0x8f6f, 1);  pop(bx);                                   /* pop bx */
            ii(0x8f70, 4);  add(ax, memw[ds, 0x98]);                   /* add ax, [0x98] */
            ii(0x8f74, 4);  adc(dx, memw[ds, 0x9a]);                   /* adc dx, [0x9a] */
            ii(0x8f78, 3);  mov(memw[ss, bp - 18], ax);                /* mov [bp-0x12], ax */
            ii(0x8f7b, 3);  mov(memw[ss, bp - 16], dx);                /* mov [bp-0x10], dx */
            ii(0x8f7e, 3);  mov(ax, memw[ds, 0x98]);                   /* mov ax, [0x98] */
            ii(0x8f81, 4);  mov(dx, memw[ds, 0x9a]);                   /* mov dx, [0x9a] */
            ii(0x8f85, 2);  mov(cl, 6);                                /* mov cl, 0x6 */
            ii(0x8f87, 3);  call(0x9f82, 0xff8);                       /* call 0x9f82 */
            ii(0x8f8a, 4);  cmp(ax, memw[ds, 0xeca]);                  /* cmp ax, [0xeca] */
            ii(0x8f8e, 2);  if(jae(0x8fd1, 0x41)) goto l_0x8fd1;       /* jae 0x8fd1 */
            ii(0x8f90, 4);  push(memw[ds, 0xeca]);                     /* push word [0xeca] */
            ii(0x8f94, 3);  call(0xa4ec, 0x1555);                      /* call 0xa4ec */
            ii(0x8f97, 1);  pop(bx);                                   /* pop bx */
            ii(0x8f98, 3);  mov(memw[ds, 0x98], ax);                   /* mov [0x98], ax */
            ii(0x8f9b, 4);  mov(memw[ds, 0x9a], dx);                   /* mov [0x9a], dx */
            ii(0x8f9f, 4);  push(memw[ds, 0xecc]);                     /* push word [0xecc] */
            ii(0x8fa3, 3);  call(0xa4ec, 0x1546);                      /* call 0xa4ec */
            ii(0x8fa6, 1);  pop(bx);                                   /* pop bx */
            ii(0x8fa7, 4);  add(ax, memw[ds, 0x98]);                   /* add ax, [0x98] */
            ii(0x8fab, 4);  adc(dx, memw[ds, 0x9a]);                   /* adc dx, [0x9a] */
            ii(0x8faf, 3);  mov(memw[ss, bp - 18], ax);                /* mov [bp-0x12], ax */
            ii(0x8fb2, 3);  mov(memw[ss, bp - 16], dx);                /* mov [bp-0x10], dx */
            ii(0x8fb5, 3);  mov(ax, memw[ds, 0x9c]);                   /* mov ax, [0x9c] */
            ii(0x8fb8, 4);  mov(dx, memw[ds, 0x9e]);                   /* mov dx, [0x9e] */
            ii(0x8fbc, 3);  cmp(memw[ss, bp - 16], dx);                /* cmp [bp-0x10], dx */
            ii(0x8fbf, 2);  if(ja(0x9000, 0x3f)) goto l_0x9000;        /* ja 0x9000 */
            ii(0x8fc1, 2);  if(jb(0x8fc8, 5)) goto l_0x8fc8;           /* jb 0x8fc8 */
            ii(0x8fc3, 3);  cmp(memw[ss, bp - 18], ax);                /* cmp [bp-0x12], ax */
            ii(0x8fc6, 2);  if(jae(0x9000, 0x38)) goto l_0x9000;       /* jae 0x9000 */
        l_0x8fc8:
            ii(0x8fc8, 3);  mov(ax, memw[ss, bp - 18]);                /* mov ax, [bp-0x12] */
            ii(0x8fcb, 3);  mov(dx, memw[ss, bp - 16]);                /* mov dx, [bp-0x10] */
            ii(0x8fce, 3);  jmp(0x8e8e, -0x143); goto l_0x8e8e;        /* jmp 0x8e8e */
        l_0x8fd1:
            ii(0x8fd1, 3);  mov(ax, memw[ds, 0x9c]);                   /* mov ax, [0x9c] */
            ii(0x8fd4, 4);  mov(dx, memw[ds, 0x9e]);                   /* mov dx, [0x9e] */
            ii(0x8fd8, 3);  cmp(memw[ss, bp - 16], dx);                /* cmp [bp-0x10], dx */
            ii(0x8fdb, 2);  if(ja(0x9000, 0x23)) goto l_0x9000;        /* ja 0x9000 */
            ii(0x8fdd, 2);  if(jb(0x8fe4, 5)) goto l_0x8fe4;           /* jb 0x8fe4 */
            ii(0x8fdf, 3);  cmp(memw[ss, bp - 18], ax);                /* cmp [bp-0x12], ax */
            ii(0x8fe2, 2);  if(jae(0x9000, 0x1c)) goto l_0x9000;       /* jae 0x9000 */
        l_0x8fe4:
            ii(0x8fe4, 4);  push(memw[ds, 0xecc]);                     /* push word [0xecc] */
            ii(0x8fe8, 3);  call(0xa4ec, 0x1501);                      /* call 0xa4ec */
            ii(0x8feb, 1);  pop(bx);                                   /* pop bx */
            ii(0x8fec, 4);  mov(cx, memw[ds, 0x9c]);                   /* mov cx, [0x9c] */
            ii(0x8ff0, 4);  mov(bx, memw[ds, 0x9e]);                   /* mov bx, [0x9e] */
            ii(0x8ff4, 2);  sub(cx, ax);                               /* sub cx, ax */
            ii(0x8ff6, 2);  sbb(bx, dx);                               /* sbb bx, dx */
            ii(0x8ff8, 4);  mov(memw[ds, 0x98], cx);                   /* mov [0x98], cx */
            ii(0x8ffc, 4);  mov(memw[ds, 0x9a], bx);                   /* mov [0x9a], bx */
        l_0x9000:
            ii(0x9000, 1);  leave();                                   /* leave */
            ii(0x9001, 1);  ret();                                     /* ret */
        }
    }
}
