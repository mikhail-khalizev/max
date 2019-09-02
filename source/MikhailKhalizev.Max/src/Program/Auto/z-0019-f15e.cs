using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_f15e-81a7066e")]
        public void Method_0019_f15e()
        {
            ii(0x19_f15e, 4); enter(0x24, 0);                           /* enter 0x24, 0x0 */
            ii(0x19_f162, 1); push(di);                                 /* push di */
            ii(0x19_f163, 1); push(si);                                 /* push si */
            ii(0x19_f164, 4); mov(es, memw[ds, 0x3fd6]);                /* mov es, [0x3fd6] */
            ii(0x19_f168, 4); mov(ax, memw[es, 0x3b78]);                /* mov ax, [es:0x3b78] */
            ii(0x19_f16c, 5); mov(memw[ss, bp - 10], 0);                /* mov word [bp-0xa], 0x0 */
            ii(0x19_f171, 3); mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0x19_f174, 3); les(bx, memw[ss, bp - 10]);               /* les bx, [bp-0xa] */
            ii(0x19_f177, 5); cmp(memb[es, bx + 47], 3);                /* cmp byte [es:bx+0x2f], 0x3 */
            ii(0x19_f17c, 2); if(jl(0x19_f181, 3)) goto l_0x19_f181;    /* jl 0xf181 */
            ii(0x19_f17e, 3); jmp(0x19_f187, 6); goto l_0x19_f187;      /* jmp 0xf187 */
        l_0x19_f181:
            ii(0x19_f181, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_f184, 3); jmp(0x19_f578, 0x3f1); goto l_0x19_f578;  /* jmp 0xf578 */
        l_0x19_f187:
            ii(0x19_f187, 4); cmp(memw[ss, bp + 6], 0);                 /* cmp word [bp+0x6], 0x0 */
            ii(0x19_f18b, 2); if(jnz(0x19_f190, 3)) goto l_0x19_f190;   /* jnz 0xf190 */
            ii(0x19_f18d, 3); jmp(0x19_f2c9, 0x139); goto l_0x19_f2c9;  /* jmp 0xf2c9 */
        l_0x19_f190:
            ii(0x19_f190, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_f192, 3); mov(memw[ss, bp - 18], ax);               /* mov [bp-0x12], ax */
            ii(0x19_f195, 3); mov(memw[ss, bp - 20], ax);               /* mov [bp-0x14], ax */
            ii(0x19_f198, 3); mov(si, 4);                               /* mov si, 0x4 */
        l_0x19_f19b:
            ii(0x19_f19b, 1); dec(si);                                  /* dec si */
            ii(0x19_f19c, 3); cmp(si, 0);                               /* cmp si, 0x0 */
            ii(0x19_f19f, 2); if(jge(0x19_f1a4, 3)) goto l_0x19_f1a4;   /* jge 0xf1a4 */
            ii(0x19_f1a1, 3); jmp(0x19_f290, 0xec); goto l_0x19_f290;   /* jmp 0xf290 */
        l_0x19_f1a4:
            ii(0x19_f1a4, 3); imul(bx, si, 0x1b);                       /* imul bx, si, 0x1b */
            ii(0x19_f1a7, 4); add(bx, 0x2e3c);                          /* add bx, 0x2e3c */
            ii(0x19_f1ab, 3); mov(memw[ss, bp - 24], bx);               /* mov [bp-0x18], bx */
            ii(0x19_f1ae, 3); mov(memw[ss, bp - 22], ds);               /* mov [bp-0x16], ds */
            ii(0x19_f1b1, 4); cmp(memb[ds, bx + 23], 0);                /* cmp byte [bx+0x17], 0x0 */
            ii(0x19_f1b5, 2); if(jnz(0x19_f1ba, 3)) goto l_0x19_f1ba;   /* jnz 0xf1ba */
            ii(0x19_f1b7, 3); jmp(0x19_f28d, 0xd3); goto l_0x19_f28d;   /* jmp 0xf28d */
        l_0x19_f1ba:
            ii(0x19_f1ba, 4); inc(memb[ds, 0x2ea8]);                    /* inc byte [0x2ea8] */
            ii(0x19_f1be, 3); lea(ax, memw[ss, bp - 28]);               /* lea ax, [bp-0x1c] */
            ii(0x19_f1c1, 1); push(ss);                                 /* push ss */
            ii(0x19_f1c2, 1); push(ax);                                 /* push ax */
            ii(0x19_f1c3, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f1c6, 4); push(memw[es, bx + 18]);                  /* push word [es:bx+0x12] */
            ii(0x19_f1ca, 4); push(memw[es, bx + 16]);                  /* push word [es:bx+0x10] */
            ii(0x19_f1ce, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f1d1, 4); push(memw[es, bx + 20]);                  /* push word [es:bx+0x14] */
            ii(0x19_f1d5, 3); call(0x19_f0ce, -0x10a);                  /* call 0xf0ce */
            ii(0x19_f1d8, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_f1db, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_f1de, 2); if(jnz(0x19_f1e3, 3)) goto l_0x19_f1e3;   /* jnz 0xf1e3 */
            ii(0x19_f1e0, 3); jmp(0x19_f1e6, 3); goto l_0x19_f1e6;      /* jmp 0xf1e6 */
        l_0x19_f1e3:
            ii(0x19_f1e3, 3); jmp(0x19_f19b, -0x4b); goto l_0x19_f19b;  /* jmp 0xf19b */
        l_0x19_f1e6:
            ii(0x19_f1e6, 3); push(memw[ss, bp - 26]);                  /* push word [bp-0x1a] */
            ii(0x19_f1e9, 3); push(memw[ss, bp - 28]);                  /* push word [bp-0x1c] */
            ii(0x19_f1ec, 1); push(si);                                 /* push si */
            ii(0x19_f1ed, 5); call_far_abs(0x80, 0x1749);               /* call word 0x80:0x1749 */
            ii(0x19_f1f2, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x19_f1f5, 2); mov(cx, si);                              /* mov cx, si */
            ii(0x19_f1f7, 2); shl(cl, 1);                               /* shl cl, 1 */
            ii(0x19_f1f9, 3); mov(ax, 3);                               /* mov ax, 0x3 */
            ii(0x19_f1fc, 2); shl(ax, cl);                              /* shl ax, cl */
            ii(0x19_f1fe, 3); or(memw[ss, bp - 20], ax);                /* or [bp-0x14], ax */
            ii(0x19_f201, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f204, 4); mov(al, memb[es, bx + 22]);               /* mov al, [es:bx+0x16] */
            ii(0x19_f208, 1); cbw();                                    /* cbw */
            ii(0x19_f209, 3); mov(memw[ss, bp - 12], ax);               /* mov [bp-0xc], ax */
            ii(0x19_f20c, 4); cmp(memw[ss, bp - 12], 2);                /* cmp word [bp-0xc], 0x2 */
            ii(0x19_f210, 2); if(jnz(0x19_f215, 3)) goto l_0x19_f215;   /* jnz 0xf215 */
            ii(0x19_f212, 3); jmp(0x19_f230, 0x1b); goto l_0x19_f230;   /* jmp 0xf230 */
        l_0x19_f215:
            ii(0x19_f215, 4); cmp(memw[ss, bp - 12], 5);                /* cmp word [bp-0xc], 0x5 */
            ii(0x19_f219, 2); if(jnz(0x19_f21e, 3)) goto l_0x19_f21e;   /* jnz 0xf21e */
            ii(0x19_f21b, 3); jmp(0x19_f230, 0x12); goto l_0x19_f230;   /* jmp 0xf230 */
        l_0x19_f21e:
            ii(0x19_f21e, 4); cmp(memw[ss, bp - 12], 4);                /* cmp word [bp-0xc], 0x4 */
            ii(0x19_f222, 2); if(jnz(0x19_f227, 3)) goto l_0x19_f227;   /* jnz 0xf227 */
            ii(0x19_f224, 3); jmp(0x19_f230, 9); goto l_0x19_f230;      /* jmp 0xf230 */
        l_0x19_f227:
            ii(0x19_f227, 4); cmp(memw[ss, bp - 12], 6);                /* cmp word [bp-0xc], 0x6 */
            ii(0x19_f22b, 2); if(jz(0x19_f230, 3)) goto l_0x19_f230;    /* jz 0xf230 */
            ii(0x19_f22d, 3); jmp(0x19_f235, 5); goto l_0x19_f235;      /* jmp 0xf235 */
        l_0x19_f230:
            ii(0x19_f230, 5); mov(memw[ss, bp - 12], 1);                /* mov word [bp-0xc], 0x1 */
        l_0x19_f235:
            ii(0x19_f235, 2); mov(cx, si);                              /* mov cx, si */
            ii(0x19_f237, 3); shl(cl, 2);                               /* shl cl, 0x2 */
            ii(0x19_f23a, 3); mov(ax, memw[ss, bp - 12]);               /* mov ax, [bp-0xc] */
            ii(0x19_f23d, 2); shl(ax, cl);                              /* shl ax, cl */
            ii(0x19_f23f, 3); or(memw[ss, bp - 18], ax);                /* or [bp-0x12], ax */
            ii(0x19_f242, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f245, 4); mov(al, memb[es, bx + 23]);               /* mov al, [es:bx+0x17] */
            ii(0x19_f249, 1); cbw();                                    /* cbw */
            ii(0x19_f24a, 1); dec(ax);                                  /* dec ax */
            ii(0x19_f24b, 2); mov(cx, si);                              /* mov cx, si */
            ii(0x19_f24d, 3); shl(cl, 2);                               /* shl cl, 0x2 */
            ii(0x19_f250, 3); add(cl, 2);                               /* add cl, 0x2 */
            ii(0x19_f253, 2); shl(ax, cl);                              /* shl ax, cl */
            ii(0x19_f255, 3); or(memw[ss, bp - 18], ax);                /* or [bp-0x12], ax */
            ii(0x19_f258, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f25b, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_f25d, 4); mov(memw[es, bx + 2], ax);                /* mov [es:bx+0x2], ax */
            ii(0x19_f261, 3); mov(memw[es, bx], ax);                    /* mov [es:bx], ax */
            ii(0x19_f264, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f267, 4); mov(al, memb[es, bx + 23]);               /* mov al, [es:bx+0x17] */
            ii(0x19_f26b, 1); cbw();                                    /* cbw */
            ii(0x19_f26c, 1); push(ax);                                 /* push ax */
            ii(0x19_f26d, 3); push(memw[ss, bp - 22]);                  /* push word [bp-0x16] */
            ii(0x19_f270, 3); push(memw[ss, bp - 24]);                  /* push word [bp-0x18] */
            ii(0x19_f273, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f276, 4); push(memw[es, bx + 20]);                  /* push word [es:bx+0x14] */
            ii(0x19_f27a, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f27d, 4); push(memw[es, bx + 18]);                  /* push word [es:bx+0x12] */
            ii(0x19_f281, 4); push(memw[es, bx + 16]);                  /* push word [es:bx+0x10] */
            ii(0x19_f285, 5); call_far_abs(0x80, 0x1534);               /* call word 0x80:0x1534 */
            ii(0x19_f28a, 3); add(sp, 0xc);                             /* add sp, 0xc */
        l_0x19_f28d:
            ii(0x19_f28d, 3); jmp(0x19_f19b, -0xf5); goto l_0x19_f19b;  /* jmp 0xf19b */
        l_0x19_f290:
            ii(0x19_f290, 5); cmp(memb[ds, 0x2ea8], 0);                 /* cmp byte [0x2ea8], 0x0 */
            ii(0x19_f295, 2); if(jz(0x19_f29a, 3)) goto l_0x19_f29a;    /* jz 0xf29a */
            ii(0x19_f297, 3); jmp(0x19_f2a0, 6); goto l_0x19_f2a0;      /* jmp 0xf2a0 */
        l_0x19_f29a:
            ii(0x19_f29a, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_f29d, 3); jmp(0x19_f578, 0x2d8); goto l_0x19_f578;  /* jmp 0xf578 */
        l_0x19_f2a0:
            ii(0x19_f2a0, 5); or(memw[ss, bp - 20], 0x300);             /* or word [bp-0x14], 0x300 */
            ii(0x19_f2a5, 3); push(memw[ss, bp - 18]);                  /* push word [bp-0x12] */
            ii(0x19_f2a8, 3); push(memw[ss, bp - 20]);                  /* push word [bp-0x14] */
            ii(0x19_f2ab, 2); push(7);                                  /* push 0x7 */
            ii(0x19_f2ad, 5); call_far_abs(0x80, 0x1749);               /* call word 0x80:0x1749 */
            ii(0x19_f2b2, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x19_f2b5, 2); push(0);                                  /* push 0x0 */
            ii(0x19_f2b7, 2); push(0);                                  /* push 0x0 */
            ii(0x19_f2b9, 2); push(6);                                  /* push 0x6 */
            ii(0x19_f2bb, 5); call_far_abs(0x80, 0x1749);               /* call word 0x80:0x1749 */
            ii(0x19_f2c0, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x19_f2c3, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_f2c6, 3); jmp(0x19_f578, 0x2af); goto l_0x19_f578;  /* jmp 0xf578 */
        l_0x19_f2c9:
            ii(0x19_f2c9, 5); cmp(memb[ds, 0x2ea8], 0);                 /* cmp byte [0x2ea8], 0x0 */
            ii(0x19_f2ce, 2); if(jz(0x19_f2d3, 3)) goto l_0x19_f2d3;    /* jz 0xf2d3 */
            ii(0x19_f2d0, 3); jmp(0x19_f2d9, 6); goto l_0x19_f2d9;      /* jmp 0xf2d9 */
        l_0x19_f2d3:
            ii(0x19_f2d3, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_f2d6, 3); jmp(0x19_f578, 0x29f); goto l_0x19_f578;  /* jmp 0xf578 */
        l_0x19_f2d9:
            ii(0x19_f2d9, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_f2db, 3); mov(memw[ss, bp - 18], ax);               /* mov [bp-0x12], ax */
            ii(0x19_f2de, 3); mov(memw[ss, bp - 20], ax);               /* mov [bp-0x14], ax */
            ii(0x19_f2e1, 5); mov(memb[ds, 0x2ea8], 0);                 /* mov byte [0x2ea8], 0x0 */
            ii(0x19_f2e6, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_f2e9, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x19_f2ec, 3); mov(memw[ss, bp - 12], ax);               /* mov [bp-0xc], ax */
            ii(0x19_f2ef, 5); call_far_abs(0x80, 0x1729);               /* call word 0x80:0x1729 */
            ii(0x19_f2f4, 3); mov(memw[ss, bp - 16], ax);               /* mov [bp-0x10], ax */
            ii(0x19_f2f7, 3); mov(memw[ss, bp - 14], dx);               /* mov [bp-0xe], dx */
            ii(0x19_f2fa, 3); push(memw[ss, bp - 18]);                  /* push word [bp-0x12] */
            ii(0x19_f2fd, 3); push(memw[ss, bp - 20]);                  /* push word [bp-0x14] */
            ii(0x19_f300, 2); push(7);                                  /* push 0x7 */
            ii(0x19_f302, 5); call_far_abs(0x80, 0x1749);               /* call word 0x80:0x1749 */
            ii(0x19_f307, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x19_f30a, 2); push(0);                                  /* push 0x0 */
            ii(0x19_f30c, 2); push(0);                                  /* push 0x0 */
            ii(0x19_f30e, 2); push(6);                                  /* push 0x6 */
            ii(0x19_f310, 5); call_far_abs(0x80, 0x1749);               /* call word 0x80:0x1749 */
            ii(0x19_f315, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x19_f318, 3); mov(si, 0);                               /* mov si, 0x0 */
            ii(0x19_f31b, 3); jmp(0x19_f31f, 1); goto l_0x19_f31f;      /* jmp 0xf31f */
        l_0x19_f31e:
            ii(0x19_f31e, 1); inc(si);                                  /* inc si */
        l_0x19_f31f:
            ii(0x19_f31f, 3); cmp(si, 4);                               /* cmp si, 0x4 */
            ii(0x19_f322, 2); if(jl(0x19_f327, 3)) goto l_0x19_f327;    /* jl 0xf327 */
            ii(0x19_f324, 3); jmp(0x19_f55a, 0x233); goto l_0x19_f55a;  /* jmp 0xf55a */
        l_0x19_f327:
            ii(0x19_f327, 3); imul(ax, si, 0x1b);                       /* imul ax, si, 0x1b */
            ii(0x19_f32a, 3); add(ax, 0x2e3c);                          /* add ax, 0x2e3c */
            ii(0x19_f32d, 3); mov(memw[ss, bp - 24], ax);               /* mov [bp-0x18], ax */
            ii(0x19_f330, 3); mov(memw[ss, bp - 22], ds);               /* mov [bp-0x16], ds */
            ii(0x19_f333, 3); mov(al, memb[ss, bp - 16]);               /* mov al, [bp-0x10] */
            ii(0x19_f336, 2); and(al, 1);                               /* and al, 0x1 */
            ii(0x19_f338, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f33b, 4); mov(memb[es, bx + 24], al);               /* mov [es:bx+0x18], al */
            ii(0x19_f33f, 2); cmp(al, 0);                               /* cmp al, 0x0 */
            ii(0x19_f341, 2); if(jnz(0x19_f346, 3)) goto l_0x19_f346;   /* jnz 0xf346 */
            ii(0x19_f343, 3); jmp(0x19_f551, 0x20b); goto l_0x19_f551;  /* jmp 0xf551 */
        l_0x19_f346:
            ii(0x19_f346, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_f348, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x19_f34b, 3); mov(memw[ss, bp - 6], ax);                /* mov [bp-0x6], ax */
            ii(0x19_f34e, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f351, 4); mov(al, memb[es, bx + 23]);               /* mov al, [es:bx+0x17] */
            ii(0x19_f355, 1); cbw();                                    /* cbw */
            ii(0x19_f356, 1); push(ax);                                 /* push ax */
            ii(0x19_f357, 3); lea(ax, memw[ss, bp - 6]);                /* lea ax, [bp-0x6] */
            ii(0x19_f35a, 1); push(ss);                                 /* push ss */
            ii(0x19_f35b, 1); push(ax);                                 /* push ax */
            ii(0x19_f35c, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f35f, 4); push(memw[es, bx + 20]);                  /* push word [es:bx+0x14] */
            ii(0x19_f363, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f366, 4); push(memw[es, bx + 18]);                  /* push word [es:bx+0x12] */
            ii(0x19_f36a, 4); push(memw[es, bx + 16]);                  /* push word [es:bx+0x10] */
            ii(0x19_f36e, 5); call_far_abs(0x80, 0x1534);               /* call word 0x80:0x1534 */
            ii(0x19_f373, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x19_f376, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f379, 4); mov(al, memb[es, bx + 22]);               /* mov al, [es:bx+0x16] */
            ii(0x19_f37d, 1); cbw();                                    /* cbw */
            ii(0x19_f37e, 3); jmp(0x19_f534, 0x1b3); goto l_0x19_f534;  /* jmp 0xf534 */
        l_0x19_f381:
            ii(0x19_f381, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f384, 3); mov(ax, memw[es, bx]);                    /* mov ax, [es:bx] */
            ii(0x19_f387, 4); mov(dx, memw[es, bx + 2]);                /* mov dx, [es:bx+0x2] */
            ii(0x19_f38b, 3); xor(memw[ss, bp - 6], ax);                /* xor [bp-0x6], ax */
            ii(0x19_f38e, 3); xor(memw[ss, bp - 4], dx);                /* xor [bp-0x4], dx */
            ii(0x19_f391, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x19_f394, 3); or(ax, memw[ss, bp - 6]);                 /* or ax, [bp-0x6] */
            ii(0x19_f397, 2); if(jz(0x19_f39c, 3)) goto l_0x19_f39c;    /* jz 0xf39c */
            ii(0x19_f399, 3); jmp(0x19_f3aa, 0xe); goto l_0x19_f3aa;    /* jmp 0xf3aa */
        l_0x19_f39c:
            ii(0x19_f39c, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f39f, 5); mov(memb[es, bx + 24], 0);                /* mov byte [es:bx+0x18], 0x0 */
            ii(0x19_f3a4, 3); inc(memw[ss, bp - 2]);                    /* inc word [bp-0x2] */
            ii(0x19_f3a7, 3); jmp(0x19_f3ad, 3); goto l_0x19_f3ad;      /* jmp 0xf3ad */
        l_0x19_f3aa:
            ii(0x19_f3aa, 3); inc(memw[ss, bp - 12]);                   /* inc word [bp-0xc] */
        l_0x19_f3ad:
            ii(0x19_f3ad, 3); jmp(0x19_f551, 0x1a1); goto l_0x19_f551;  /* jmp 0xf551 */
        l_0x19_f3b0:
            ii(0x19_f3b0, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f3b3, 3); mov(ax, memw[es, bx]);                    /* mov ax, [es:bx] */
            ii(0x19_f3b6, 4); mov(dx, memw[es, bx + 2]);                /* mov dx, [es:bx+0x2] */
            ii(0x19_f3ba, 3); xor(ax, memw[ss, bp - 6]);                /* xor ax, [bp-0x6] */
            ii(0x19_f3bd, 3); xor(dx, memw[ss, bp - 4]);                /* xor dx, [bp-0x4] */
            ii(0x19_f3c0, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_f3c2, 2); if(jnz(0x19_f3c7, 3)) goto l_0x19_f3c7;   /* jnz 0xf3c7 */
            ii(0x19_f3c4, 3); jmp(0x19_f426, 0x5f); goto l_0x19_f426;   /* jmp 0xf426 */
        l_0x19_f3c7:
            ii(0x19_f3c7, 5); mov(memw[ss, bp - 32], 0xffff);           /* mov word [bp-0x20], 0xffff */
            ii(0x19_f3cc, 5); mov(memw[ss, bp - 30], 0xffff);           /* mov word [bp-0x1e], 0xffff */
            ii(0x19_f3d1, 2); mov(al, 4);                               /* mov al, 0x4 */
            ii(0x19_f3d3, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f3d6, 4); sub(al, memb[es, bx + 23]);               /* sub al, [es:bx+0x17] */
            ii(0x19_f3da, 3); shl(al, 3);                               /* shl al, 0x3 */
            ii(0x19_f3dd, 1); push(ax);                                 /* push ax */
            ii(0x19_f3de, 3); lea(ax, memw[ss, bp - 32]);               /* lea ax, [bp-0x20] */
            ii(0x19_f3e1, 1); push(ax);                                 /* push ax */
            ii(0x19_f3e2, 5); call_far_abs(0x80, 0x435a);               /* call word 0x80:0x435a */
            ii(0x19_f3e7, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f3ea, 4); mov(ax, memw[es, bx + 4]);                /* mov ax, [es:bx+0x4] */
            ii(0x19_f3ee, 4); mov(dx, memw[es, bx + 6]);                /* mov dx, [es:bx+0x6] */
            ii(0x19_f3f2, 3); and(ax, memw[ss, bp - 32]);               /* and ax, [bp-0x20] */
            ii(0x19_f3f5, 3); and(dx, memw[ss, bp - 30]);               /* and dx, [bp-0x1e] */
            ii(0x19_f3f8, 3); mov(cx, memw[ss, bp - 32]);               /* mov cx, [bp-0x20] */
            ii(0x19_f3fb, 3); mov(bx, memw[ss, bp - 30]);               /* mov bx, [bp-0x1e] */
            ii(0x19_f3fe, 3); and(cx, memw[ss, bp - 6]);                /* and cx, [bp-0x6] */
            ii(0x19_f401, 3); and(bx, memw[ss, bp - 4]);                /* and bx, [bp-0x4] */
            ii(0x19_f404, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x19_f406, 2); if(jz(0x19_f40b, 3)) goto l_0x19_f40b;    /* jz 0xf40b */
            ii(0x19_f408, 3); jmp(0x19_f418, 0xd); goto l_0x19_f418;    /* jmp 0xf418 */
        l_0x19_f40b:
            ii(0x19_f40b, 2); cmp(dx, bx);                              /* cmp dx, bx */
            ii(0x19_f40d, 2); if(jz(0x19_f412, 3)) goto l_0x19_f412;    /* jz 0xf412 */
            ii(0x19_f40f, 3); jmp(0x19_f418, 6); goto l_0x19_f418;      /* jmp 0xf418 */
        l_0x19_f412:
            ii(0x19_f412, 3); inc(memw[ss, bp - 12]);                   /* inc word [bp-0xc] */
            ii(0x19_f415, 3); jmp(0x19_f423, 0xb); goto l_0x19_f423;    /* jmp 0xf423 */
        l_0x19_f418:
            ii(0x19_f418, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f41b, 5); mov(memb[es, bx + 24], 0);                /* mov byte [es:bx+0x18], 0x0 */
            ii(0x19_f420, 3); inc(memw[ss, bp - 2]);                    /* inc word [bp-0x2] */
        l_0x19_f423:
            ii(0x19_f423, 3); jmp(0x19_f431, 0xb); goto l_0x19_f431;    /* jmp 0xf431 */
        l_0x19_f426:
            ii(0x19_f426, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f429, 5); mov(memb[es, bx + 24], 0);                /* mov byte [es:bx+0x18], 0x0 */
            ii(0x19_f42e, 3); inc(memw[ss, bp - 2]);                    /* inc word [bp-0x2] */
        l_0x19_f431:
            ii(0x19_f431, 3); jmp(0x19_f551, 0x11d); goto l_0x19_f551;  /* jmp 0xf551 */
        l_0x19_f434:
            ii(0x19_f434, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f437, 3); mov(ax, memw[es, bx]);                    /* mov ax, [es:bx] */
            ii(0x19_f43a, 4); mov(dx, memw[es, bx + 2]);                /* mov dx, [es:bx+0x2] */
            ii(0x19_f43e, 3); xor(ax, memw[ss, bp - 6]);                /* xor ax, [bp-0x6] */
            ii(0x19_f441, 3); xor(dx, memw[ss, bp - 4]);                /* xor dx, [bp-0x4] */
            ii(0x19_f444, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_f446, 2); if(jnz(0x19_f44b, 3)) goto l_0x19_f44b;   /* jnz 0xf44b */
            ii(0x19_f448, 3); jmp(0x19_f51d, 0xd2); goto l_0x19_f51d;   /* jmp 0xf51d */
        l_0x19_f44b:
            ii(0x19_f44b, 5); mov(memw[ss, bp - 36], 0xffff);           /* mov word [bp-0x24], 0xffff */
            ii(0x19_f450, 5); mov(memw[ss, bp - 34], 0xffff);           /* mov word [bp-0x22], 0xffff */
            ii(0x19_f455, 5); mov(memw[ss, bp - 32], 0);                /* mov word [bp-0x20], 0x0 */
            ii(0x19_f45a, 2); mov(al, 4);                               /* mov al, 0x4 */
            ii(0x19_f45c, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f45f, 4); sub(al, memb[es, bx + 23]);               /* sub al, [es:bx+0x17] */
            ii(0x19_f463, 3); shl(al, 3);                               /* shl al, 0x3 */
            ii(0x19_f466, 1); push(ax);                                 /* push ax */
            ii(0x19_f467, 3); lea(ax, memw[ss, bp - 36]);               /* lea ax, [bp-0x24] */
            ii(0x19_f46a, 1); push(ax);                                 /* push ax */
            ii(0x19_f46b, 5); call_far_abs(0x80, 0x435a);               /* call word 0x80:0x435a */
            ii(0x19_f470, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f473, 4); mov(ax, memw[es, bx + 8]);                /* mov ax, [es:bx+0x8] */
            ii(0x19_f477, 4); mov(dx, memw[es, bx + 10]);               /* mov dx, [es:bx+0xa] */
            ii(0x19_f47b, 3); and(ax, memw[ss, bp - 36]);               /* and ax, [bp-0x24] */
            ii(0x19_f47e, 3); and(dx, memw[ss, bp - 34]);               /* and dx, [bp-0x22] */
            ii(0x19_f481, 3); mov(cx, memw[ss, bp - 6]);                /* mov cx, [bp-0x6] */
            ii(0x19_f484, 3); mov(bx, memw[ss, bp - 4]);                /* mov bx, [bp-0x4] */
            ii(0x19_f487, 3); and(cx, memw[ss, bp - 36]);               /* and cx, [bp-0x24] */
            ii(0x19_f48a, 3); and(bx, memw[ss, bp - 34]);               /* and bx, [bp-0x22] */
            ii(0x19_f48d, 2); cmp(dx, bx);                              /* cmp dx, bx */
            ii(0x19_f48f, 2); if(jbe(0x19_f494, 3)) goto l_0x19_f494;   /* jbe 0xf494 */
            ii(0x19_f491, 3); jmp(0x19_f4d8, 0x44); goto l_0x19_f4d8;   /* jmp 0xf4d8 */
        l_0x19_f494:
            ii(0x19_f494, 2); if(jae(0x19_f499, 3)) goto l_0x19_f499;   /* jae 0xf499 */
            ii(0x19_f496, 3); jmp(0x19_f4a0, 7); goto l_0x19_f4a0;      /* jmp 0xf4a0 */
        l_0x19_f499:
            ii(0x19_f499, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x19_f49b, 2); if(jbe(0x19_f4a0, 3)) goto l_0x19_f4a0;   /* jbe 0xf4a0 */
            ii(0x19_f49d, 3); jmp(0x19_f4d8, 0x38); goto l_0x19_f4d8;   /* jmp 0xf4d8 */
        l_0x19_f4a0:
            ii(0x19_f4a0, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f4a3, 4); mov(ax, memw[es, bx + 12]);               /* mov ax, [es:bx+0xc] */
            ii(0x19_f4a7, 4); mov(dx, memw[es, bx + 14]);               /* mov dx, [es:bx+0xe] */
            ii(0x19_f4ab, 3); and(ax, memw[ss, bp - 36]);               /* and ax, [bp-0x24] */
            ii(0x19_f4ae, 3); and(dx, memw[ss, bp - 34]);               /* and dx, [bp-0x22] */
            ii(0x19_f4b1, 3); mov(cx, memw[ss, bp - 6]);                /* mov cx, [bp-0x6] */
            ii(0x19_f4b4, 3); mov(bx, memw[ss, bp - 4]);                /* mov bx, [bp-0x4] */
            ii(0x19_f4b7, 3); and(cx, memw[ss, bp - 36]);               /* and cx, [bp-0x24] */
            ii(0x19_f4ba, 3); and(bx, memw[ss, bp - 34]);               /* and bx, [bp-0x22] */
            ii(0x19_f4bd, 2); cmp(dx, bx);                              /* cmp dx, bx */
            ii(0x19_f4bf, 2); if(jae(0x19_f4c4, 3)) goto l_0x19_f4c4;   /* jae 0xf4c4 */
            ii(0x19_f4c1, 3); jmp(0x19_f4d8, 0x14); goto l_0x19_f4d8;   /* jmp 0xf4d8 */
        l_0x19_f4c4:
            ii(0x19_f4c4, 2); if(jbe(0x19_f4c9, 3)) goto l_0x19_f4c9;   /* jbe 0xf4c9 */
            ii(0x19_f4c6, 3); jmp(0x19_f4d0, 7); goto l_0x19_f4d0;      /* jmp 0xf4d0 */
        l_0x19_f4c9:
            ii(0x19_f4c9, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x19_f4cb, 2); if(jae(0x19_f4d0, 3)) goto l_0x19_f4d0;   /* jae 0xf4d0 */
            ii(0x19_f4cd, 3); jmp(0x19_f4d8, 8); goto l_0x19_f4d8;      /* jmp 0xf4d8 */
        l_0x19_f4d0:
            ii(0x19_f4d0, 5); mov(memw[ss, bp - 32], 1);                /* mov word [bp-0x20], 0x1 */
            ii(0x19_f4d5, 3); jmp(0x19_f4dd, 5); goto l_0x19_f4dd;      /* jmp 0xf4dd */
        l_0x19_f4d8:
            ii(0x19_f4d8, 5); mov(memw[ss, bp - 32], 0);                /* mov word [bp-0x20], 0x0 */
        l_0x19_f4dd:
            ii(0x19_f4dd, 4); cmp(memw[ss, bp - 32], 0);                /* cmp word [bp-0x20], 0x0 */
            ii(0x19_f4e1, 2); if(jz(0x19_f4e6, 3)) goto l_0x19_f4e6;    /* jz 0xf4e6 */
            ii(0x19_f4e3, 3); jmp(0x19_f4f3, 0xd); goto l_0x19_f4f3;    /* jmp 0xf4f3 */
        l_0x19_f4e6:
            ii(0x19_f4e6, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f4e9, 5); cmp(memb[es, bx + 22], 6);                /* cmp byte [es:bx+0x16], 0x6 */
            ii(0x19_f4ee, 2); if(jnz(0x19_f4f3, 3)) goto l_0x19_f4f3;   /* jnz 0xf4f3 */
            ii(0x19_f4f0, 3); jmp(0x19_f509, 0x16); goto l_0x19_f509;   /* jmp 0xf509 */
        l_0x19_f4f3:
            ii(0x19_f4f3, 4); cmp(memw[ss, bp - 32], 0);                /* cmp word [bp-0x20], 0x0 */
            ii(0x19_f4f7, 2); if(jnz(0x19_f4fc, 3)) goto l_0x19_f4fc;   /* jnz 0xf4fc */
            ii(0x19_f4f9, 3); jmp(0x19_f50f, 0x13); goto l_0x19_f50f;   /* jmp 0xf50f */
        l_0x19_f4fc:
            ii(0x19_f4fc, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f4ff, 5); cmp(memb[es, bx + 22], 5);                /* cmp byte [es:bx+0x16], 0x5 */
            ii(0x19_f504, 2); if(jz(0x19_f509, 3)) goto l_0x19_f509;    /* jz 0xf509 */
            ii(0x19_f506, 3); jmp(0x19_f50f, 6); goto l_0x19_f50f;      /* jmp 0xf50f */
        l_0x19_f509:
            ii(0x19_f509, 3); inc(memw[ss, bp - 12]);                   /* inc word [bp-0xc] */
            ii(0x19_f50c, 3); jmp(0x19_f51a, 0xb); goto l_0x19_f51a;    /* jmp 0xf51a */
        l_0x19_f50f:
            ii(0x19_f50f, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f512, 5); mov(memb[es, bx + 24], 0);                /* mov byte [es:bx+0x18], 0x0 */
            ii(0x19_f517, 3); inc(memw[ss, bp - 2]);                    /* inc word [bp-0x2] */
        l_0x19_f51a:
            ii(0x19_f51a, 3); jmp(0x19_f528, 0xb); goto l_0x19_f528;    /* jmp 0xf528 */
        l_0x19_f51d:
            ii(0x19_f51d, 3); les(bx, memw[ss, bp - 24]);               /* les bx, [bp-0x18] */
            ii(0x19_f520, 5); mov(memb[es, bx + 24], 0);                /* mov byte [es:bx+0x18], 0x0 */
            ii(0x19_f525, 3); inc(memw[ss, bp - 2]);                    /* inc word [bp-0x2] */
        l_0x19_f528:
            ii(0x19_f528, 3); jmp(0x19_f551, 0x26); goto l_0x19_f551;   /* jmp 0xf551 */
        l_0x19_f52b:
            ii(0x19_f52b, 3); inc(memw[ss, bp - 12]);                   /* inc word [bp-0xc] */
            ii(0x19_f52e, 3); jmp(0x19_f551, 0x20); goto l_0x19_f551;   /* jmp 0xf551 */
        //  ii(0x19_f531, 3); jmp(0x19_f551, 0x1d); goto l_0x19_f551;   /* jmp 0xf551 */
        l_0x19_f534:
            ii(0x19_f534, 1); dec(ax);                                  /* dec ax */
            ii(0x19_f535, 1); dec(ax);                                  /* dec ax */
            ii(0x19_f536, 2); if(jnz(0x19_f53b, 3)) goto l_0x19_f53b;   /* jnz 0xf53b */
            ii(0x19_f538, 3); jmp(0x19_f381, -0x1ba); goto l_0x19_f381; /* jmp 0xf381 */
        l_0x19_f53b:
            ii(0x19_f53b, 1); dec(ax);                                  /* dec ax */
            ii(0x19_f53c, 1); dec(ax);                                  /* dec ax */
            ii(0x19_f53d, 2); if(jnz(0x19_f542, 3)) goto l_0x19_f542;   /* jnz 0xf542 */
            ii(0x19_f53f, 3); jmp(0x19_f3b0, -0x192); goto l_0x19_f3b0; /* jmp 0xf3b0 */
        l_0x19_f542:
            ii(0x19_f542, 1); dec(ax);                                  /* dec ax */
            ii(0x19_f543, 2); if(jge(0x19_f548, 3)) goto l_0x19_f548;   /* jge 0xf548 */
            ii(0x19_f545, 3); jmp(0x19_f52b, -0x1d); goto l_0x19_f52b;  /* jmp 0xf52b */
        l_0x19_f548:
            ii(0x19_f548, 1); dec(ax);                                  /* dec ax */
            ii(0x19_f549, 2); if(jg(0x19_f54e, 3)) goto l_0x19_f54e;    /* jg 0xf54e */
            ii(0x19_f54b, 3); jmp(0x19_f434, -0x11a); goto l_0x19_f434; /* jmp 0xf434 */
        l_0x19_f54e:
            ii(0x19_f54e, 3); jmp(0x19_f52b, -0x26); goto l_0x19_f52b;  /* jmp 0xf52b */
        l_0x19_f551:
            ii(0x19_f551, 3); shr(memw[ss, bp - 14], 1);                /* shr word [bp-0xe], 1 */
            ii(0x19_f554, 3); rcr(memw[ss, bp - 16], 1);                /* rcr word [bp-0x10], 1 */
            ii(0x19_f557, 3); jmp(0x19_f31e, -0x23c); goto l_0x19_f31e; /* jmp 0xf31e */
        l_0x19_f55a:
            ii(0x19_f55a, 4); cmp(memw[ss, bp - 2], 0);                 /* cmp word [bp-0x2], 0x0 */
            ii(0x19_f55e, 2); if(jnz(0x19_f563, 3)) goto l_0x19_f563;   /* jnz 0xf563 */
            ii(0x19_f560, 3); jmp(0x19_f572, 0xf); goto l_0x19_f572;    /* jmp 0xf572 */
        l_0x19_f563:
            ii(0x19_f563, 4); cmp(memw[ss, bp - 12], 0);                /* cmp word [bp-0xc], 0x0 */
            ii(0x19_f567, 2); if(jz(0x19_f56c, 3)) goto l_0x19_f56c;    /* jz 0xf56c */
            ii(0x19_f569, 3); jmp(0x19_f572, 6); goto l_0x19_f572;      /* jmp 0xf572 */
        l_0x19_f56c:
            ii(0x19_f56c, 3); mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x19_f56f, 3); jmp(0x19_f575, 3); goto l_0x19_f575;      /* jmp 0xf575 */
        l_0x19_f572:
            ii(0x19_f572, 3); mov(ax, 0);                               /* mov ax, 0x0 */
        l_0x19_f575:
            ii(0x19_f575, 3); jmp(0x19_f578, 0); goto l_0x19_f578;      /* jmp 0xf578 */
        l_0x19_f578:
            ii(0x19_f578, 1); pop(si);                                  /* pop si */
            ii(0x19_f579, 1); pop(di);                                  /* pop di */
            ii(0x19_f57a, 1); leave();                                  /* leave */
            ii(0x19_f57b, 1); retf();                                   /* retf */
        }
    }
}
