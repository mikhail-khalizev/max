using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_d295-f5dd6974")]
        public void Method_0019_d295()
        {
            ii(0x19_d295, 4);  enter(0x116, 0);                        /* enter 0x116, 0x0 */
            ii(0x19_d299, 1);  push(si);                               /* push si */
            ii(0x19_d29a, 3);  les(bx, memw[ss, bp + 18]);             /* les bx, [bp+0x12] */
            ii(0x19_d29d, 4);  les(si, memw[es, bx + 44]);             /* les si, [es:bx+0x2c] */
            ii(0x19_d2a1, 3);  add(si, memw[ss, bp + 10]);             /* add si, [bp+0xa] */
            ii(0x19_d2a4, 4);  mov(memw[ss, bp - 276], si);            /* mov [bp-0x114], si */
            ii(0x19_d2a8, 4);  mov(memw[ss, bp - 274], es);            /* mov [bp-0x112], es */
            ii(0x19_d2ac, 3);  mov(al, memb[es, si]);                  /* mov al, [es:si] */
            ii(0x19_d2af, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_d2b1, 1);  push(ax);                               /* push ax */
            ii(0x19_d2b2, 3);  lea(ax, memw[ds, si + 1]);              /* lea ax, [si+0x1] */
            ii(0x19_d2b5, 1);  push(es);                               /* push es */
            ii(0x19_d2b6, 1);  push(ax);                               /* push ax */
            ii(0x19_d2b7, 4);  lea(ax, memw[ss, bp - 272]);            /* lea ax, [bp-0x110] */
            ii(0x19_d2bb, 1);  push(ss);                               /* push ss */
            ii(0x19_d2bc, 1);  push(ax);                               /* push ax */
            ii(0x19_d2bd, 1);  nop();                                  /* nop */
            ii(0x19_d2be, 1);  push(cs);                               /* push cs */
            ii(0x19_d2bf, 3);  call(0x1a_0f5f, 0x3c9d);                /* call 0xf5f */
            ii(0x19_d2c2, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x19_d2c5, 4);  les(bx, memw[ss, bp - 276]);            /* les bx, [bp-0x114] */
            ii(0x19_d2c9, 3);  mov(al, memb[es, bx]);                  /* mov al, [es:bx] */
            ii(0x19_d2cc, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_d2ce, 2);  mov(si, ax);                            /* mov si, ax */
            ii(0x19_d2d0, 4);  mov(memb[ss, bp + si - 272], ah);       /* mov [bp+si-0x110], ah */
            ii(0x19_d2d4, 3);  push(memw[ss, bp + 20]);                /* push word [bp+0x14] */
            ii(0x19_d2d7, 3);  push(memw[ss, bp + 18]);                /* push word [bp+0x12] */
            ii(0x19_d2da, 3);  push(memw[ss, bp + 16]);                /* push word [bp+0x10] */
            ii(0x19_d2dd, 3);  push(memw[ss, bp + 14]);                /* push word [bp+0xe] */
            ii(0x19_d2e0, 3);  lea(ax, memw[ss, bp - 16]);             /* lea ax, [bp-0x10] */
            ii(0x19_d2e3, 1);  push(ss);                               /* push ss */
            ii(0x19_d2e4, 1);  push(ax);                               /* push ax */
            ii(0x19_d2e5, 3);  call(0x19_cde9, -0x4ff);                /* call 0xcde9 */
            ii(0x19_d2e8, 4);  lea(ax, memw[ss, bp - 272]);            /* lea ax, [bp-0x110] */
            ii(0x19_d2ec, 1);  push(ss);                               /* push ss */
            ii(0x19_d2ed, 1);  push(ax);                               /* push ax */
            ii(0x19_d2ee, 3);  lea(ax, memw[ss, bp - 16]);             /* lea ax, [bp-0x10] */
            ii(0x19_d2f1, 1);  push(ss);                               /* push ss */
            ii(0x19_d2f2, 1);  push(ax);                               /* push ax */
            ii(0x19_d2f3, 1);  push(ds);                               /* push ds */
            ii(0x19_d2f4, 3);  push(0x29d5);                           /* push 0x29d5 */
            ii(0x19_d2f7, 5);  call_far_abs(0x80, 0x2289);             /* call word 0x80:0x2289 */
            ii(0x19_d2fc, 3);  add(sp, 0xc);                           /* add sp, 0xc */
            ii(0x19_d2ff, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_d302, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_d305, 4);  lea(ax, memw[ss, bp - 272]);            /* lea ax, [bp-0x110] */
            ii(0x19_d309, 1);  push(ss);                               /* push ss */
            ii(0x19_d30a, 1);  push(ax);                               /* push ax */
            ii(0x19_d30b, 3);  lea(ax, memw[ss, bp - 16]);             /* lea ax, [bp-0x10] */
            ii(0x19_d30e, 1);  push(ss);                               /* push ss */
            ii(0x19_d30f, 1);  push(ax);                               /* push ax */
            ii(0x19_d310, 3);  push(memw[ss, bp + 20]);                /* push word [bp+0x14] */
            ii(0x19_d313, 3);  push(memw[ss, bp + 18]);                /* push word [bp+0x12] */
            ii(0x19_d316, 1);  nop();                                  /* nop */
            ii(0x19_d317, 1);  push(cs);                               /* push cs */
            ii(0x19_d318, 3);  call(0x19_da10, 0x6f5);                 /* call 0xda10 */
            ii(0x19_d31b, 3);  add(sp, 0x10);                          /* add sp, 0x10 */
            ii(0x19_d31e, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x19_d320, 2);  if(jz(0x19_d328, 6)) goto l_0x19_d328;  /* jz 0xd328 */
            ii(0x19_d322, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x19_d325, 3);  jmp(0x19_d3d3, 0xab); goto l_0x19_d3d3; /* jmp 0xd3d3 */
        l_0x19_d328:
            ii(0x19_d328, 3);  lea(ax, memw[ss, bp - 16]);             /* lea ax, [bp-0x10] */
            ii(0x19_d32b, 1);  push(ss);                               /* push ss */
            ii(0x19_d32c, 1);  push(ax);                               /* push ax */
            ii(0x19_d32d, 3);  call(0x19_a16e, -0x31c2);               /* call 0xa16e */
            ii(0x19_d330, 4);  mov(memw[ss, bp - 278], ax);            /* mov [bp-0x116], ax */
            ii(0x19_d334, 3);  cmp(ax, 0xffff);                        /* cmp ax, 0xffff */
            ii(0x19_d337, 2);  if(jnz(0x19_d345, 0xc)) goto l_0x19_d345;/* jnz 0xd345 */
            ii(0x19_d339, 3);  lea(ax, memw[ss, bp - 16]);             /* lea ax, [bp-0x10] */
            ii(0x19_d33c, 1);  push(ss);                               /* push ss */
            ii(0x19_d33d, 1);  push(ax);                               /* push ax */
            ii(0x19_d33e, 3);  call(0x19_d6d6, 0x395);                 /* call 0xd6d6 */
            ii(0x19_d341, 4);  mov(memw[ss, bp - 278], ax);            /* mov [bp-0x116], ax */
        l_0x19_d345:
            ii(0x19_d345, 3);  push(memw[ss, bp + 20]);                /* push word [bp+0x14] */
            ii(0x19_d348, 3);  push(memw[ss, bp + 18]);                /* push word [bp+0x12] */
            ii(0x19_d34b, 3);  lea(ax, memw[ss, bp - 16]);             /* lea ax, [bp-0x10] */
            ii(0x19_d34e, 1);  push(ss);                               /* push ss */
            ii(0x19_d34f, 1);  push(ax);                               /* push ax */
            ii(0x19_d350, 3);  call(0x19_d270, -0xe3);                 /* call 0xd270 */
            ii(0x19_d353, 5);  cmp(memw[ss, bp - 278], -1 /* 0xff */); /* cmp word [bp-0x116], 0xffff */
            ii(0x19_d358, 2);  if(jz(0x19_d375, 0x1b)) goto l_0x19_d375;/* jz 0xd375 */
            ii(0x19_d35a, 6);  cmp(memw[ss, bp - 278], 0x29a);         /* cmp word [bp-0x116], 0x29a */
            ii(0x19_d360, 2);  if(jz(0x19_d375, 0x13)) goto l_0x19_d375;/* jz 0xd375 */
            ii(0x19_d362, 4);  push(memw[ss, bp - 278]);               /* push word [bp-0x116] */
            ii(0x19_d366, 4);  lea(ax, memw[ss, bp - 272]);            /* lea ax, [bp-0x110] */
            ii(0x19_d36a, 1);  push(ss);                               /* push ss */
            ii(0x19_d36b, 1);  push(ax);                               /* push ax */
            ii(0x19_d36c, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_d36f, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_d372, 3);  call(0x19_d099, -0x2dc);                /* call 0xd099 */
        l_0x19_d375:
            ii(0x19_d375, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_d378, 4);  mov(ax, memw[es, bx + 4]);              /* mov ax, [es:bx+0x4] */
            ii(0x19_d37c, 4);  or(ax, memw[es, bx + 2]);               /* or ax, [es:bx+0x2] */
            ii(0x19_d380, 2);  if(jnz(0x19_d396, 0x14)) goto l_0x19_d396;/* jnz 0xd396 */
            ii(0x19_d382, 3);  lea(ax, memw[ss, bp - 16]);             /* lea ax, [bp-0x10] */
            ii(0x19_d385, 1);  push(ss);                               /* push ss */
            ii(0x19_d386, 1);  push(ax);                               /* push ax */
            ii(0x19_d387, 4);  lea(ax, memw[ss, bp - 272]);            /* lea ax, [bp-0x110] */
            ii(0x19_d38b, 1);  push(ss);                               /* push ss */
            ii(0x19_d38c, 1);  push(ax);                               /* push ax */
            ii(0x19_d38d, 1);  push(es);                               /* push es */
            ii(0x19_d38e, 1);  push(bx);                               /* push bx */
            ii(0x19_d38f, 3);  mov(al, memb[ss, bp + 4]);              /* mov al, [bp+0x4] */
            ii(0x19_d392, 1);  push(ax);                               /* push ax */
            ii(0x19_d393, 3);  call(0x19_d1ad, -0x1e9);                /* call 0xd1ad */
        l_0x19_d396:
            ii(0x19_d396, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_d399, 4);  mov(ax, memw[es, bx + 4]);              /* mov ax, [es:bx+0x4] */
            ii(0x19_d39d, 4);  or(ax, memw[es, bx + 2]);               /* or ax, [es:bx+0x2] */
            ii(0x19_d3a1, 2);  if(jnz(0x19_d3bc, 0x19)) goto l_0x19_d3bc;/* jnz 0xd3bc */
            ii(0x19_d3a3, 3);  lea(ax, memw[ss, bp - 16]);             /* lea ax, [bp-0x10] */
            ii(0x19_d3a6, 1);  push(ss);                               /* push ss */
            ii(0x19_d3a7, 1);  push(ax);                               /* push ax */
            ii(0x19_d3a8, 4);  lea(ax, memw[ss, bp - 272]);            /* lea ax, [bp-0x110] */
            ii(0x19_d3ac, 1);  push(ss);                               /* push ss */
            ii(0x19_d3ad, 1);  push(ax);                               /* push ax */
            ii(0x19_d3ae, 3);  mov(ax, memw[ss, bp + 18]);             /* mov ax, [bp+0x12] */
            ii(0x19_d3b1, 3);  mov(dx, memw[ss, bp + 20]);             /* mov dx, [bp+0x14] */
            ii(0x19_d3b4, 3);  add(ax, 0xea);                          /* add ax, 0xea */
            ii(0x19_d3b7, 1);  push(dx);                               /* push dx */
            ii(0x19_d3b8, 1);  push(ax);                               /* push ax */
            ii(0x19_d3b9, 3);  call(0x19_cdc4, -0x5f8);                /* call 0xcdc4 */
        l_0x19_d3bc:
            ii(0x19_d3bc, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_d3bf, 4);  push(memw[es, bx + 4]);                 /* push word [es:bx+0x4] */
            ii(0x19_d3c3, 4);  push(memw[es, bx + 2]);                 /* push word [es:bx+0x2] */
            ii(0x19_d3c7, 1);  push(ds);                               /* push ds */
            ii(0x19_d3c8, 3);  push(0x29eb);                           /* push 0x29eb */
            ii(0x19_d3cb, 5);  call_far_abs(0x80, 0x2289);             /* call word 0x80:0x2289 */
            ii(0x19_d3d0, 3);  add(sp, 8);                             /* add sp, 0x8 */
        l_0x19_d3d3:
            ii(0x19_d3d3, 1);  pop(si);                                /* pop si */
            ii(0x19_d3d4, 1);  leave();                                /* leave */
            ii(0x19_d3d5, 3);  ret(0x12);                              /* ret 0x12 */
        }
    }
}
