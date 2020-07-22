using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5e40-8e317bd0")]
        public void Method_0000_5e40()
        {
            ii(0x5e40, 1);  push(di);                                  /* push di */
            ii(0x5e41, 1);  push(si);                                  /* push si */
            ii(0x5e42, 3);  mov(al, memb[ds, 0xcda]);                  /* mov al, [0xcda] */
            ii(0x5e45, 4);  inc(memb[ds, 0xcda]);                      /* inc byte [0xcda] */
            ii(0x5e49, 2);  or(al, al);                                /* or al, al */
            ii(0x5e4b, 2);  if(jnz(0x5e50, 3)) goto l_0x5e50;          /* jnz 0x5e50 */
            ii(0x5e4d, 3);  call(0x51e1, -0xc6f);                      /* call 0x51e1 */
        l_0x5e50:
            ii(0x5e50, 4);  mov(bx, memw[ds, 0x996]);                  /* mov bx, [0x996] */
            ii(0x5e54, 4);  cmp(memw[ds, bx + 24], 0x21);              /* cmp word [bx+0x18], 0x21 */
            ii(0x5e58, 2);  if(jnz(0x5e63, 9)) goto l_0x5e63;          /* jnz 0x5e63 */
            ii(0x5e5a, 3);  mov(al, memb[ds, bx + 22]);                /* mov al, [bx+0x16] */
            ii(0x5e5d, 1);  cbw();                                     /* cbw */
            ii(0x5e5e, 1);  push(ax);                                  /* push ax */
            ii(0x5e5f, 3);  call(0x3dd2, -0x2090);                     /* call 0x3dd2 */
            ii(0x5e62, 1);  pop(bx);                                   /* pop bx */
        l_0x5e63:
            ii(0x5e63, 3);  call(0x4f67, -0xeff);                      /* call 0x4f67 */
            ii(0x5e66, 3);  call(0x5578, -0x8f1);                      /* call 0x5578 */
            ii(0x5e69, 4);  mov(bx, memw[ds, 0x996]);                  /* mov bx, [0x996] */
            ii(0x5e6d, 4);  cmp(memw[ds, bx + 24], 0);                 /* cmp word [bx+0x18], 0x0 */
            ii(0x5e71, 2);  if(jge(0x5e76, 3)) goto l_0x5e76;          /* jge 0x5e76 */
            ii(0x5e73, 3);  jmp(0x6007, 0x191); goto l_0x6007;         /* jmp 0x6007 */
        l_0x5e76:
            ii(0x5e76, 3);  mov(ax, 0xc4e);                            /* mov ax, 0xc4e */
            ii(0x5e79, 1);  push(ax);                                  /* push ax */
            ii(0x5e7a, 3);  call(0x5237, -0xc46);                      /* call 0x5237 */
            ii(0x5e7d, 1);  pop(bx);                                   /* pop bx */
            ii(0x5e7e, 4);  mov(bx, memw[ds, 0x996]);                  /* mov bx, [0x996] */
            ii(0x5e82, 4);  cmp(memw[ds, bx + 24], 0xd);               /* cmp word [bx+0x18], 0xd */
            ii(0x5e86, 2);  if(jnz(0x5e8d, 5)) goto l_0x5e8d;          /* jnz 0x5e8d */
            ii(0x5e88, 3);  mov(ax, 0xc5b);                            /* mov ax, 0xc5b */
            ii(0x5e8b, 2);  jmp(0x5e96, 9); goto l_0x5e96;             /* jmp 0x5e96 */
        l_0x5e8d:
            ii(0x5e8d, 4);  cmp(memw[ds, bx + 24], 6);                 /* cmp word [bx+0x18], 0x6 */
            ii(0x5e91, 2);  if(jnz(0x5e9c, 9)) goto l_0x5e9c;          /* jnz 0x5e9c */
            ii(0x5e93, 3);  mov(ax, 0xc74);                            /* mov ax, 0xc74 */
        l_0x5e96:
            ii(0x5e96, 1);  push(ax);                                  /* push ax */
            ii(0x5e97, 3);  call(0x5237, -0xc63);                      /* call 0x5237 */
            ii(0x5e9a, 2);  jmp(0x5ec2, 0x26); goto l_0x5ec2;          /* jmp 0x5ec2 */
        l_0x5e9c:
            ii(0x5e9c, 4);  cmp(memw[ds, bx + 24], 0xe);               /* cmp word [bx+0x18], 0xe */
            ii(0x5ea0, 2);  if(jnz(0x5eb7, 0x15)) goto l_0x5eb7;       /* jnz 0x5eb7 */
            ii(0x5ea2, 4);  push(memw[ds, 0xd32]);                     /* push word [0xd32] */
            ii(0x5ea6, 3);  mov(ax, 0xc83);                            /* mov ax, 0xc83 */
            ii(0x5ea9, 1);  push(ax);                                  /* push ax */
            ii(0x5eaa, 3);  call(0x55e7, -0x8c6);                      /* call 0x55e7 */
            ii(0x5ead, 1);  pop(bx);                                   /* pop bx */
            ii(0x5eae, 1);  pop(bx);                                   /* pop bx */
            ii(0x5eaf, 4);  push(memw[ds, 0xd30]);                     /* push word [0xd30] */
            ii(0x5eb3, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x5eb5, 2);  jmp(0x5ebd, 6); goto l_0x5ebd;             /* jmp 0x5ebd */
        l_0x5eb7:
            ii(0x5eb7, 3);  push(memw[ds, bx + 24]);                   /* push word [bx+0x18] */
            ii(0x5eba, 3);  mov(ax, 0xc8e);                            /* mov ax, 0xc8e */
        l_0x5ebd:
            ii(0x5ebd, 1);  push(ax);                                  /* push ax */
            ii(0x5ebe, 3);  call(0x55e7, -0x8da);                      /* call 0x55e7 */
            ii(0x5ec1, 1);  pop(bx);                                   /* pop bx */
        l_0x5ec2:
            ii(0x5ec2, 1);  pop(bx);                                   /* pop bx */
            ii(0x5ec3, 3);  mov(ax, 0xca3);                            /* mov ax, 0xca3 */
            ii(0x5ec6, 1);  push(ax);                                  /* push ax */
            ii(0x5ec7, 3);  call(0x5237, -0xc93);                      /* call 0x5237 */
            ii(0x5eca, 1);  pop(bx);                                   /* pop bx */
            ii(0x5ecb, 4);  mov(si, memw[ds, 0x11f8]);                 /* mov si, [0x11f8] */
            ii(0x5ecf, 4);  add(si, 0x1190);                           /* add si, 0x1190 */
            ii(0x5ed3, 2);  jmp(0x5edf, 0xa); goto l_0x5edf;           /* jmp 0x5edf */
        l_0x5ed5:
            ii(0x5ed5, 3);  cmp(memb[ds, si], 0x3a);                   /* cmp byte [si], 0x3a */
            ii(0x5ed8, 2);  if(jz(0x5ee6, 0xc)) goto l_0x5ee6;         /* jz 0x5ee6 */
            ii(0x5eda, 3);  cmp(memb[ds, si], 0x5c);                   /* cmp byte [si], 0x5c */
            ii(0x5edd, 2);  if(jz(0x5ee6, 7)) goto l_0x5ee6;           /* jz 0x5ee6 */
        l_0x5edf:
            ii(0x5edf, 1);  dec(si);                                   /* dec si */
            ii(0x5ee0, 4);  cmp(si, 0x1190);                           /* cmp si, 0x1190 */
            ii(0x5ee4, 2);  if(jae(0x5ed5, -0x11)) goto l_0x5ed5;      /* jae 0x5ed5 */
        l_0x5ee6:
            ii(0x5ee6, 3);  lea(ax, memw[ds, si + 1]);                 /* lea ax, [si+0x1] */
            ii(0x5ee9, 1);  push(ax);                                  /* push ax */
            ii(0x5eea, 3);  call(0x5237, -0xcb6);                      /* call 0x5237 */
            ii(0x5eed, 1);  pop(bx);                                   /* pop bx */
            ii(0x5eee, 3);  mov(ax, 0xca8);                            /* mov ax, 0xca8 */
            ii(0x5ef1, 1);  push(ax);                                  /* push ax */
            ii(0x5ef2, 3);  call(0x5237, -0xcbe);                      /* call 0x5237 */
            ii(0x5ef5, 1);  pop(bx);                                   /* pop bx */
            ii(0x5ef6, 4);  mov(bx, memw[ds, 0x996]);                  /* mov bx, [0x996] */
            ii(0x5efa, 3);  push(memw[ds, bx + 34]);                   /* push word [bx+0x22] */
            ii(0x5efd, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x5eff, 1);  push(ax);                                  /* push ax */
            ii(0x5f00, 3);  call(0x55e7, -0x91c);                      /* call 0x55e7 */
            ii(0x5f03, 1);  pop(bx);                                   /* pop bx */
            ii(0x5f04, 1);  pop(bx);                                   /* pop bx */
            ii(0x5f05, 3);  mov(ax, 0xcad);                            /* mov ax, 0xcad */
            ii(0x5f08, 1);  push(ax);                                  /* push ax */
            ii(0x5f09, 3);  call(0x5237, -0xcd5);                      /* call 0x5237 */
            ii(0x5f0c, 1);  pop(bx);                                   /* pop bx */
            ii(0x5f0d, 4);  mov(bx, memw[ds, 0x996]);                  /* mov bx, [0x996] */
            ii(0x5f11, 3);  push(memw[ds, bx + 30]);                   /* push word [bx+0x1e] */
            ii(0x5f14, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x5f16, 1);  push(ax);                                  /* push ax */
            ii(0x5f17, 3);  call(0x55e7, -0x933);                      /* call 0x55e7 */
            ii(0x5f1a, 1);  pop(bx);                                   /* pop bx */
            ii(0x5f1b, 1);  pop(bx);                                   /* pop bx */
            ii(0x5f1c, 4);  mov(bx, memw[ds, 0x996]);                  /* mov bx, [0x996] */
            ii(0x5f20, 3);  push(memw[ds, bx + 34]);                   /* push word [bx+0x22] */
            ii(0x5f23, 3);  call(0x6012, 0xec);                        /* call 0x6012 */
            ii(0x5f26, 1);  pop(bx);                                   /* pop bx */
            ii(0x5f27, 2);  mov(di, ax);                               /* mov di, ax */
            ii(0x5f29, 2);  or(di, di);                                /* or di, di */
            ii(0x5f2b, 2);  if(jz(0x5f37, 0xa)) goto l_0x5f37;         /* jz 0x5f37 */
            ii(0x5f2d, 1);  push(di);                                  /* push di */
            ii(0x5f2e, 3);  mov(ax, 0xcaf);                            /* mov ax, 0xcaf */
            ii(0x5f31, 1);  push(ax);                                  /* push ax */
            ii(0x5f32, 3);  call(0x55e7, -0x94e);                      /* call 0x55e7 */
            ii(0x5f35, 1);  pop(bx);                                   /* pop bx */
            ii(0x5f36, 1);  pop(bx);                                   /* pop bx */
        l_0x5f37:
            ii(0x5f37, 3);  call(0x5578, -0x9c2);                      /* call 0x5578 */
            ii(0x5f3a, 4);  mov(bx, memw[ds, 0x996]);                  /* mov bx, [0x996] */
            ii(0x5f3e, 3);  push(memw[ds, bx + 26]);                   /* push word [bx+0x1a] */
            ii(0x5f41, 3);  mov(ax, 0xcb4);                            /* mov ax, 0xcb4 */
            ii(0x5f44, 1);  push(ax);                                  /* push ax */
            ii(0x5f45, 3);  call(0x55e7, -0x961);                      /* call 0x55e7 */
            ii(0x5f48, 1);  pop(bx);                                   /* pop bx */
            ii(0x5f49, 1);  pop(bx);                                   /* pop bx */
            ii(0x5f4a, 4);  mov(bx, memw[ds, 0x996]);                  /* mov bx, [0x996] */
            ii(0x5f4e, 3);  push(memw[ds, bx + 2]);                    /* push word [bx+0x2] */
            ii(0x5f51, 3);  mov(ax, 0xcb9);                            /* mov ax, 0xcb9 */
            ii(0x5f54, 1);  push(ax);                                  /* push ax */
            ii(0x5f55, 3);  call(0x55e7, -0x971);                      /* call 0x55e7 */
            ii(0x5f58, 1);  pop(bx);                                   /* pop bx */
            ii(0x5f59, 1);  pop(bx);                                   /* pop bx */
            ii(0x5f5a, 4);  mov(bx, memw[ds, 0x996]);                  /* mov bx, [0x996] */
            ii(0x5f5e, 3);  push(memw[ds, bx + 4]);                    /* push word [bx+0x4] */
            ii(0x5f61, 3);  mov(ax, 0xcbc);                            /* mov ax, 0xcbc */
            ii(0x5f64, 1);  push(ax);                                  /* push ax */
            ii(0x5f65, 3);  call(0x55e7, -0x981);                      /* call 0x55e7 */
            ii(0x5f68, 1);  pop(bx);                                   /* pop bx */
            ii(0x5f69, 1);  pop(bx);                                   /* pop bx */
            ii(0x5f6a, 4);  mov(bx, memw[ds, 0x996]);                  /* mov bx, [0x996] */
            ii(0x5f6e, 3);  push(memw[ds, bx + 6]);                    /* push word [bx+0x6] */
            ii(0x5f71, 3);  mov(ax, 0xcbf);                            /* mov ax, 0xcbf */
            ii(0x5f74, 1);  push(ax);                                  /* push ax */
            ii(0x5f75, 3);  call(0x55e7, -0x991);                      /* call 0x55e7 */
            ii(0x5f78, 1);  pop(bx);                                   /* pop bx */
            ii(0x5f79, 1);  pop(bx);                                   /* pop bx */
            ii(0x5f7a, 3);  call(0x5578, -0xa05);                      /* call 0x5578 */
            ii(0x5f7d, 4);  mov(bx, memw[ds, 0x996]);                  /* mov bx, [0x996] */
            ii(0x5f81, 3);  push(memw[ds, bx + 22]);                   /* push word [bx+0x16] */
            ii(0x5f84, 3);  mov(ax, 0xcc2);                            /* mov ax, 0xcc2 */
            ii(0x5f87, 1);  push(ax);                                  /* push ax */
            ii(0x5f88, 3);  call(0x55e7, -0x9a4);                      /* call 0x55e7 */
            ii(0x5f8b, 1);  pop(bx);                                   /* pop bx */
            ii(0x5f8c, 1);  pop(bx);                                   /* pop bx */
            ii(0x5f8d, 4);  mov(bx, memw[ds, 0x996]);                  /* mov bx, [0x996] */
            ii(0x5f91, 3);  push(memw[ds, bx + 16]);                   /* push word [bx+0x10] */
            ii(0x5f94, 3);  mov(ax, 0xcc5);                            /* mov ax, 0xcc5 */
            ii(0x5f97, 1);  push(ax);                                  /* push ax */
            ii(0x5f98, 3);  call(0x55e7, -0x9b4);                      /* call 0x55e7 */
            ii(0x5f9b, 1);  pop(bx);                                   /* pop bx */
            ii(0x5f9c, 1);  pop(bx);                                   /* pop bx */
            ii(0x5f9d, 4);  mov(bx, memw[ds, 0x996]);                  /* mov bx, [0x996] */
            ii(0x5fa1, 3);  push(memw[ds, bx + 20]);                   /* push word [bx+0x14] */
            ii(0x5fa4, 3);  mov(ax, 0xcc8);                            /* mov ax, 0xcc8 */
            ii(0x5fa7, 1);  push(ax);                                  /* push ax */
            ii(0x5fa8, 3);  call(0x55e7, -0x9c4);                      /* call 0x55e7 */
            ii(0x5fab, 1);  pop(bx);                                   /* pop bx */
            ii(0x5fac, 1);  pop(bx);                                   /* pop bx */
            ii(0x5fad, 4);  mov(bx, memw[ds, 0x996]);                  /* mov bx, [0x996] */
            ii(0x5fb1, 3);  push(memw[ds, bx + 18]);                   /* push word [bx+0x12] */
            ii(0x5fb4, 3);  mov(ax, 0xccb);                            /* mov ax, 0xccb */
            ii(0x5fb7, 1);  push(ax);                                  /* push ax */
            ii(0x5fb8, 3);  call(0x55e7, -0x9d4);                      /* call 0x55e7 */
            ii(0x5fbb, 1);  pop(bx);                                   /* pop bx */
            ii(0x5fbc, 1);  pop(bx);                                   /* pop bx */
            ii(0x5fbd, 4);  mov(bx, memw[ds, 0x996]);                  /* mov bx, [0x996] */
            ii(0x5fc1, 3);  push(memw[ds, bx + 14]);                   /* push word [bx+0xe] */
            ii(0x5fc4, 3);  mov(ax, 0xcce);                            /* mov ax, 0xcce */
            ii(0x5fc7, 1);  push(ax);                                  /* push ax */
            ii(0x5fc8, 3);  call(0x55e7, -0x9e4);                      /* call 0x55e7 */
            ii(0x5fcb, 1);  pop(bx);                                   /* pop bx */
            ii(0x5fcc, 1);  pop(bx);                                   /* pop bx */
            ii(0x5fcd, 4);  mov(bx, memw[ds, 0x996]);                  /* mov bx, [0x996] */
            ii(0x5fd1, 3);  push(memw[ds, bx + 12]);                   /* push word [bx+0xc] */
            ii(0x5fd4, 3);  mov(ax, 0xcd1);                            /* mov ax, 0xcd1 */
            ii(0x5fd7, 1);  push(ax);                                  /* push ax */
            ii(0x5fd8, 3);  call(0x55e7, -0x9f4);                      /* call 0x55e7 */
            ii(0x5fdb, 1);  pop(bx);                                   /* pop bx */
            ii(0x5fdc, 1);  pop(bx);                                   /* pop bx */
            ii(0x5fdd, 4);  mov(bx, memw[ds, 0x996]);                  /* mov bx, [0x996] */
            ii(0x5fe1, 3);  push(memw[ds, bx + 10]);                   /* push word [bx+0xa] */
            ii(0x5fe4, 3);  mov(ax, 0xcd4);                            /* mov ax, 0xcd4 */
            ii(0x5fe7, 1);  push(ax);                                  /* push ax */
            ii(0x5fe8, 3);  call(0x55e7, -0xa04);                      /* call 0x55e7 */
            ii(0x5feb, 1);  pop(bx);                                   /* pop bx */
            ii(0x5fec, 1);  pop(bx);                                   /* pop bx */
            ii(0x5fed, 4);  mov(bx, memw[ds, 0x996]);                  /* mov bx, [0x996] */
            ii(0x5ff1, 3);  push(memw[ds, bx + 8]);                    /* push word [bx+0x8] */
            ii(0x5ff4, 3);  mov(ax, 0xcd7);                            /* mov ax, 0xcd7 */
            ii(0x5ff7, 1);  push(ax);                                  /* push ax */
            ii(0x5ff8, 3);  call(0x55e7, -0xa14);                      /* call 0x55e7 */
            ii(0x5ffb, 1);  pop(bx);                                   /* pop bx */
            ii(0x5ffc, 1);  pop(bx);                                   /* pop bx */
            ii(0x5ffd, 5);  test(memb[ds, 0x15], 0x80);                /* test byte [0x15], 0x80 */
            ii(0x6002, 2);  if(jz(0x6007, 3)) goto l_0x6007;           /* jz 0x6007 */
            ii(0x6004, 3);  call(0x501a, -0xfed);                      /* call 0x501a */
        l_0x6007:
            ii(0x6007, 3);  mov(ax, 0xffff);                           /* mov ax, 0xffff */
            ii(0x600a, 1);  push(ax);                                  /* push ax */
            ii(0x600b, 3);  call(0x3dd2, -0x223c);                     /* call 0x3dd2 */
            ii(0x600e, 1);  pop(bx);                                   /* pop bx */
            ii(0x600f, 1);  pop(si);                                   /* pop si */
            ii(0x6010, 1);  pop(di);                                   /* pop di */
            ii(0x6011, 1);  ret();                                     /* ret */
        }
    }
}
