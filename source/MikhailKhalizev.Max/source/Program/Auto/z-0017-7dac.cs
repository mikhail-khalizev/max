using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_7dac-817aa309")]
        public void Method_0017_7dac()
        {
            ii(0x17_7dac, 4);  enter(0x10, 0);                         /* enter 0x10, 0x0 */
            ii(0x17_7db0, 1);  push(di);                               /* push di */
            ii(0x17_7db1, 1);  push(si);                               /* push si */
            ii(0x17_7db2, 1);  push(ds);                               /* push ds */
            ii(0x17_7db3, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_7db6, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_7db8, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x17_7dbb, 3);  mov(dx, memw[ss, bp + 8]);              /* mov dx, [bp+0x8] */
            ii(0x17_7dbe, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_7dc0, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_7dc2, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_7dc4, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_7dc6, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_7dc8, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_7dca, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_7dcc, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_7dce, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_7dd0, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_7dd2, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_7dd4, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_7dd6, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x17_7dd9, 3);  mov(memw[ss, bp - 10], dx);             /* mov [bp-0xa], dx */
            ii(0x17_7ddc, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x17_7ddf, 3);  mov(dx, memw[ss, bp + 8]);              /* mov dx, [bp+0x8] */
            ii(0x17_7de2, 3);  sub(ax, 0);                             /* sub ax, 0x0 */
            ii(0x17_7de5, 3);  sbb(dx, 1);                             /* sbb dx, 0x1 */
            ii(0x17_7de8, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_7deb, 3);  mov(memw[ss, bp - 6], dx);              /* mov [bp-0x6], dx */
            ii(0x17_7dee, 1);  push(dx);                               /* push dx */
            ii(0x17_7def, 1);  push(ax);                               /* push ax */
            ii(0x17_7df0, 4);  push(memw[ds, 0x4f8e]);                 /* push word [0x4f8e] */
            ii(0x17_7df4, 4);  push(memw[ds, 0x4f8c]);                 /* push word [0x4f8c] */
            ii(0x17_7df8, 2);  mov(si, ax);                            /* mov si, ax */
            ii(0x17_7dfa, 2);  mov(di, dx);                            /* mov di, dx */
            ii(0x17_7dfc, 3);  call(0x17_9208, 0x1409);                /* call 0x9208 */
            ii(0x17_7dff, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_7e02, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_7e05, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x17_7e08, 3);  mov(bx, memw[ss, bp + 10]);             /* mov bx, [bp+0xa] */
            ii(0x17_7e0b, 3);  shl(bx, 2);                             /* shl bx, 0x2 */
            ii(0x17_7e0e, 2);  mov(ax, si);                            /* mov ax, si */
            ii(0x17_7e10, 4);  les(si, memw[ds, 0x4fa0]);              /* les si, [0x4fa0] */
            ii(0x17_7e14, 3);  mov(memw[ss, bp - 16], ax);             /* mov [bp-0x10], ax */
            ii(0x17_7e17, 3);  mov(memw[ss, bp - 14], di);             /* mov [bp-0xe], di */
            ii(0x17_7e1a, 3);  mov(ax, memw[es, bx + si]);             /* mov ax, [es:bx+si] */
            ii(0x17_7e1d, 4);  mov(dx, memw[es, bx + si + 2]);         /* mov dx, [es:bx+si+0x2] */
            ii(0x17_7e21, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_7e23, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_7e25, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_7e27, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_7e29, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_7e2b, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_7e2d, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_7e2f, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_7e31, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_7e33, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_7e35, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_7e37, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_7e39, 2);  mov(cx, ax);                            /* mov cx, ax */
            ii(0x17_7e3b, 2);  mov(si, dx);                            /* mov si, dx */
            ii(0x17_7e3d, 3);  xor(ax, memw[ss, bp - 4]);              /* xor ax, [bp-0x4] */
            ii(0x17_7e40, 3);  and(ah, 0xf);                           /* and ah, 0xf */
            ii(0x17_7e43, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x17_7e45, 2);  xor(cx, ax);                            /* xor cx, ax */
            ii(0x17_7e47, 2);  xor(si, dx);                            /* xor si, dx */
            ii(0x17_7e49, 3);  mov(memw[ss, bp - 4], cx);              /* mov [bp-0x4], cx */
            ii(0x17_7e4c, 3);  mov(memw[ss, bp - 2], si);              /* mov [bp-0x2], si */
            ii(0x17_7e4f, 4);  or(memb[ss, bp - 4], 1);                /* or byte [bp-0x4], 0x1 */
            ii(0x17_7e53, 4);  and(memb[ss, bp - 4], -0x19 /* 0xe7 */);/* and byte [bp-0x4], 0xe7 */
            ii(0x17_7e57, 1);  push(si);                               /* push si */
            ii(0x17_7e58, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x17_7e5b, 1);  push(di);                               /* push di */
            ii(0x17_7e5c, 3);  push(memw[ss, bp - 16]);                /* push word [bp-0x10] */
            ii(0x17_7e5f, 4);  push(memw[ds, 0x4f8e]);                 /* push word [0x4f8e] */
            ii(0x17_7e63, 4);  push(memw[ds, 0x4f8c]);                 /* push word [0x4f8c] */
            ii(0x17_7e67, 2);  mov(si, bx);                            /* mov si, bx */
            ii(0x17_7e69, 3);  call(0x17_9235, 0x13c9);                /* call 0x9235 */
            ii(0x17_7e6c, 3);  add(sp, 0xc);                           /* add sp, 0xc */
            ii(0x17_7e6f, 1);  nop();                                  /* nop */
            ii(0x17_7e70, 1);  push(cs);                               /* push cs */
            ii(0x17_7e71, 3);  call(0x17_8e97, 0x1023);                /* call 0x8e97 */
            ii(0x17_7e74, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x17_7e77, 3);  mov(dx, memw[ss, bp + 8]);              /* mov dx, [bp+0x8] */
            ii(0x17_7e7a, 2);  sub(dh, dh);                            /* sub dh, dh */
            ii(0x17_7e7c, 4);  les(bx, memw[ds, 0x4fa4]);              /* les bx, [0x4fa4] */
            ii(0x17_7e80, 3);  mov(memw[es, bx + si], ax);             /* mov [es:bx+si], ax */
            ii(0x17_7e83, 4);  mov(memw[es, bx + si + 2], dx);         /* mov [es:bx+si+0x2], dx */
            ii(0x17_7e87, 3);  mov(bx, memw[ss, bp + 10]);             /* mov bx, [bp+0xa] */
            ii(0x17_7e8a, 4);  les(si, memw[ds, 0x4f9c]);              /* les si, [0x4f9c] */
            ii(0x17_7e8e, 4);  or(memb[es, bx + si], 0x7f);            /* or byte [es:bx+si], 0x7f */
            ii(0x17_7e92, 1);  pop(ds);                                /* pop ds */
            ii(0x17_7e93, 1);  pop(si);                                /* pop si */
            ii(0x17_7e94, 1);  pop(di);                                /* pop di */
            ii(0x17_7e95, 1);  leave();                                /* leave */
            ii(0x17_7e96, 1);  retf();                                 /* retf */
        }
    }
}
