using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_b614-76da4a2b")]
        public void Method_0019_b614()
        {
            ii(0x19_b614, 4); enter(0x2e, 0);                           /* enter 0x2e, 0x0 */
            ii(0x19_b618, 1); push(di);                                 /* push di */
            ii(0x19_b619, 1); push(si);                                 /* push si */
            ii(0x19_b61a, 3); les(bx, memw[ss, bp + 0x4]);              /* les bx, [bp+0x4] */
            ii(0x19_b61d, 4); les(si, memw[es, bx + 0x1c]);             /* les si, [es:bx+0x1c] */
            ii(0x19_b621, 3); mov(memw[ss, bp - 0x14], si);             /* mov [bp-0x14], si */
            ii(0x19_b624, 3); mov(memw[ss, bp - 0x12], es);             /* mov [bp-0x12], es */
            ii(0x19_b627, 4); mov(ax, memw[es, si + 0x6c]);             /* mov ax, [es:si+0x6c] */
            ii(0x19_b62b, 4); mov(dx, memw[es, si + 0x6e]);             /* mov dx, [es:si+0x6e] */
            ii(0x19_b62f, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x19_b631, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x19_b633, 4); sub(ax, memw[es, si + 0x68]);             /* sub ax, [es:si+0x68] */
            ii(0x19_b637, 4); sbb(dx, memw[es, si + 0x6a]);             /* sbb dx, [es:si+0x6a] */
            ii(0x19_b63b, 3); mov(memw[ss, bp - 0x1e], ax);             /* mov [bp-0x1e], ax */
            ii(0x19_b63e, 3); mov(memw[ss, bp - 0x1c], dx);             /* mov [bp-0x1c], dx */
            ii(0x19_b641, 3); mov(memw[ss, bp - 0x26], ax);             /* mov [bp-0x26], ax */
            ii(0x19_b644, 3); mov(memw[ss, bp - 0x24], dx);             /* mov [bp-0x24], dx */
            ii(0x19_b647, 4); mov(ax, memw[es, si + 0x70]);             /* mov ax, [es:si+0x70] */
            ii(0x19_b64b, 4); mov(dx, memw[es, si + 0x72]);             /* mov dx, [es:si+0x72] */
            ii(0x19_b64f, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x19_b651, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x19_b653, 2); sub(ax, cx);                              /* sub ax, cx */
            ii(0x19_b655, 2); sbb(dx, bx);                              /* sbb dx, bx */
            ii(0x19_b657, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0x19_b65a, 3); mov(memw[ss, bp - 0x6], dx);              /* mov [bp-0x6], dx */
            ii(0x19_b65d, 3); mov(bx, memw[ss, bp - 0x14]);             /* mov bx, [bp-0x14] */
            ii(0x19_b660, 3); mov(memw[ss, bp - 0x2a], ax);             /* mov [bp-0x2a], ax */
            ii(0x19_b663, 3); mov(memw[ss, bp - 0x28], dx);             /* mov [bp-0x28], dx */
            ii(0x19_b666, 4); mov(ax, memw[es, bx + 0x78]);             /* mov ax, [es:bx+0x78] */
            ii(0x19_b66a, 4); mov(dx, memw[es, bx + 0x7a]);             /* mov dx, [es:bx+0x7a] */
            ii(0x19_b66e, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x19_b670, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x19_b672, 2); sub(ax, di);                              /* sub ax, di */
            ii(0x19_b674, 2); sbb(dx, si);                              /* sbb dx, si */
            ii(0x19_b676, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_b679, 3); mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x19_b67c, 3); mov(si, memw[ss, bp - 0x14]);             /* mov si, [bp-0x14] */
            ii(0x19_b67f, 3); mov(memw[ss, bp - 0x2e], ax);             /* mov [bp-0x2e], ax */
            ii(0x19_b682, 3); mov(memw[ss, bp - 0x2c], dx);             /* mov [bp-0x2c], dx */
            ii(0x19_b685, 5); mov(ax, memw[es, si + 0x80]);             /* mov ax, [es:si+0x80] */
            ii(0x19_b68a, 5); mov(dx, memw[es, si + 0x82]);             /* mov dx, [es:si+0x82] */
            ii(0x19_b68f, 2); sub(ax, cx);                              /* sub ax, cx */
            ii(0x19_b691, 2); sbb(dx, bx);                              /* sbb dx, bx */
            ii(0x19_b693, 3); mov(memw[ss, bp - 0x10], ax);             /* mov [bp-0x10], ax */
            ii(0x19_b696, 3); mov(memw[ss, bp - 0xe], dx);              /* mov [bp-0xe], dx */
            ii(0x19_b699, 3); mov(cx, memw[ss, bp - 0x26]);             /* mov cx, [bp-0x26] */
            ii(0x19_b69c, 3); mov(bx, memw[ss, bp - 0x24]);             /* mov bx, [bp-0x24] */
            ii(0x19_b69f, 2); shl(cx, 0x1);                             /* shl cx, 1 */
            ii(0x19_b6a1, 2); rcl(bx, 0x1);                             /* rcl bx, 1 */
            ii(0x19_b6a3, 2); add(ax, cx);                              /* add ax, cx */
            ii(0x19_b6a5, 2); adc(dx, bx);                              /* adc dx, bx */
            ii(0x19_b6a7, 3); add(ax, memw[ss, bp - 0x2a]);             /* add ax, [bp-0x2a] */
            ii(0x19_b6aa, 3); adc(dx, memw[ss, bp - 0x28]);             /* adc dx, [bp-0x28] */
            ii(0x19_b6ad, 3); add(ax, memw[ss, bp - 0x2e]);             /* add ax, [bp-0x2e] */
            ii(0x19_b6b0, 3); adc(dx, memw[ss, bp - 0x2c]);             /* adc dx, [bp-0x2c] */
            ii(0x19_b6b3, 3); mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x19_b6b6, 3); mov(memw[ss, bp - 0x18], dx);             /* mov [bp-0x18], dx */
            ii(0x19_b6b9, 3); les(bx, memw[ss, bp + 0x4]);              /* les bx, [bp+0x4] */
            ii(0x19_b6bc, 4); mov(memw[es, bx + 0x62], ax);             /* mov [es:bx+0x62], ax */
            ii(0x19_b6c0, 4); mov(memw[es, bx + 0x64], dx);             /* mov [es:bx+0x64], dx */
            ii(0x19_b6c4, 1); push(es);                                 /* push es */
            ii(0x19_b6c5, 1); push(bx);                                 /* push bx */
            ii(0x19_b6c6, 2); push(-0x3 /* 0xfd */);                    /* push 0xfffd */
            ii(0x19_b6c8, 2); push(0x1);                                /* push 0x1 */
            ii(0x19_b6ca, 1); push(dx);                                 /* push dx */
            ii(0x19_b6cb, 1); push(ax);                                 /* push ax */
            ii(0x19_b6cc, 3); call(0x19_c975, 0x12a6);                  /* call 0xc975 */
            ii(0x19_b6cf, 3); mov(memw[ss, bp - 0x22], ax);             /* mov [bp-0x22], ax */
            ii(0x19_b6d2, 3); mov(memw[ss, bp - 0x20], dx);             /* mov [bp-0x20], dx */
            ii(0x19_b6d5, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_b6d7, 2); if(jnz(0x19_b6df, 0x6)) goto l_0x19_b6df; /* jnz 0xb6df */
            ii(0x19_b6d9, 3); mov(ax, 0x51b);                           /* mov ax, 0x51b */
            ii(0x19_b6dc, 3); jmp(0x19_b858, 0x179); goto l_0x19_b858;  /* jmp 0xb858 */
        l_0x19_b6df:
            ii(0x19_b6df, 3); push(memw[ss, bp - 0x20]);                /* push word [bp-0x20] */
            ii(0x19_b6e2, 1); push(ax);                                 /* push ax */
            ii(0x19_b6e3, 3); push(memw[ss, bp - 0x18]);                /* push word [bp-0x18] */
            ii(0x19_b6e6, 3); push(memw[ss, bp - 0x1a]);                /* push word [bp-0x1a] */
            ii(0x19_b6e9, 3); call(0x19_fb9f, 0x44b3);                  /* call 0xfb9f */
            ii(0x19_b6ec, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_b6ee, 2); if(jnz(0x19_b6f6, 0x6)) goto l_0x19_b6f6; /* jnz 0xb6f6 */
            ii(0x19_b6f0, 3); mov(ax, 0x522);                           /* mov ax, 0x522 */
            ii(0x19_b6f3, 3); jmp(0x19_b858, 0x162); goto l_0x19_b858;  /* jmp 0xb858 */
        l_0x19_b6f6:
            ii(0x19_b6f6, 3); push(memw[ss, bp - 0x18]);                /* push word [bp-0x18] */
            ii(0x19_b6f9, 3); push(memw[ss, bp - 0x1a]);                /* push word [bp-0x1a] */
            ii(0x19_b6fc, 1); push(ds);                                 /* push ds */
            ii(0x19_b6fd, 3); push(0x20f1);                             /* push 0x20f1 */
            ii(0x19_b700, 3); call(0x1a_1066, 0x5963);                  /* call 0x1066 */
            ii(0x19_b703, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_b706, 3); mov(ax, memw[ss, bp - 0x1e]);             /* mov ax, [bp-0x1e] */
            ii(0x19_b709, 3); mov(dx, memw[ss, bp - 0x1c]);             /* mov dx, [bp-0x1c] */
            ii(0x19_b70c, 2); mov(cl, 0x2);                             /* mov cl, 0x2 */
            ii(0x19_b70e, 5); call_far_abs(0x80, 0x4378);               /* call word 0x80:0x4378 */
            ii(0x19_b713, 3); les(bx, memw[ss, bp + 0x4]);              /* les bx, [bp+0x4] */
            ii(0x19_b716, 4); mov(memw[es, bx + 0x50], ax);             /* mov [es:bx+0x50], ax */
            ii(0x19_b71a, 4); mov(memw[es, bx + 0x52], dx);             /* mov [es:bx+0x52], dx */
            ii(0x19_b71e, 5); push(memw[es, bx + 0x12a]);               /* push word [es:bx+0x12a] */
            ii(0x19_b723, 2); push(0x1);                                /* push 0x1 */
            ii(0x19_b725, 3); mov(ax, memw[ss, bp - 0x22]);             /* mov ax, [bp-0x22] */
            ii(0x19_b728, 3); mov(dx, memw[ss, bp - 0x20]);             /* mov dx, [bp-0x20] */
            ii(0x19_b72b, 4); mov(memw[es, bx + 0x44], ax);             /* mov [es:bx+0x44], ax */
            ii(0x19_b72f, 4); mov(memw[es, bx + 0x46], dx);             /* mov [es:bx+0x46], dx */
            ii(0x19_b733, 1); push(dx);                                 /* push dx */
            ii(0x19_b734, 1); push(ax);                                 /* push ax */
            ii(0x19_b735, 3); mov(cx, memw[ss, bp - 0x1e]);             /* mov cx, [bp-0x1e] */
            ii(0x19_b738, 3); mov(si, memw[ss, bp - 0x1c]);             /* mov si, [bp-0x1c] */
            ii(0x19_b73b, 2); shl(cx, 0x1);                             /* shl cx, 1 */
            ii(0x19_b73d, 2); rcl(si, 0x1);                             /* rcl si, 1 */
            ii(0x19_b73f, 1); push(si);                                 /* push si */
            ii(0x19_b740, 1); push(cx);                                 /* push cx */
            ii(0x19_b741, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x19_b743, 3); mov(memw[ss, bp - 0x2e], cx);             /* mov [bp-0x2e], cx */
            ii(0x19_b746, 3); mov(memw[ss, bp - 0x2c], si);             /* mov [bp-0x2c], si */
            ii(0x19_b749, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x19_b74b, 3); call(0x19_de46, 0x26f8);                  /* call 0xde46 */
            ii(0x19_b74e, 3); les(bx, memw[ss, bp + 0x4]);              /* les bx, [bp+0x4] */
            ii(0x19_b751, 4); mov(memw[es, bx + 0x54], ax);             /* mov [es:bx+0x54], ax */
            ii(0x19_b755, 4); mov(memw[es, bx + 0x56], dx);             /* mov [es:bx+0x56], dx */
            ii(0x19_b759, 5); push(memw[es, bx + 0xb4]);                /* push word [es:bx+0xb4] */
            ii(0x19_b75e, 4); mov(ax, memw[es, bx + 0x6e]);             /* mov ax, [es:bx+0x6e] */
            ii(0x19_b762, 4); mov(dx, memw[es, bx + 0x70]);             /* mov dx, [es:bx+0x70] */
            ii(0x19_b766, 3); les(bx, memw[ss, bp - 0x14]);             /* les bx, [bp-0x14] */
            ii(0x19_b769, 3); mov(memw[ss, bp - 0x2a], ax);             /* mov [bp-0x2a], ax */
            ii(0x19_b76c, 3); mov(memw[ss, bp - 0x28], dx);             /* mov [bp-0x28], dx */
            ii(0x19_b76f, 4); add(ax, memw[es, bx + 0x68]);             /* add ax, [es:bx+0x68] */
            ii(0x19_b773, 4); adc(dx, memw[es, bx + 0x6a]);             /* adc dx, [es:bx+0x6a] */
            ii(0x19_b777, 1); push(dx);                                 /* push dx */
            ii(0x19_b778, 1); push(ax);                                 /* push ax */
            ii(0x19_b779, 1); push(si);                                 /* push si */
            ii(0x19_b77a, 1); push(di);                                 /* push di */
            ii(0x19_b77b, 3); push(memw[ss, bp - 0x1c]);                /* push word [bp-0x1c] */
            ii(0x19_b77e, 3); push(memw[ss, bp - 0x1e]);                /* push word [bp-0x1e] */
            ii(0x19_b781, 3); call(0x19_c4e3, 0xd5f);                   /* call 0xc4e3 */
            ii(0x19_b784, 3); add(di, memw[ss, bp - 0x2e]);             /* add di, [bp-0x2e] */
            ii(0x19_b787, 3); adc(si, memw[ss, bp - 0x2c]);             /* adc si, [bp-0x2c] */
            ii(0x19_b78a, 3); les(bx, memw[ss, bp + 0x4]);              /* les bx, [bp+0x4] */
            ii(0x19_b78d, 4); mov(memw[es, bx + 0x48], di);             /* mov [es:bx+0x48], di */
            ii(0x19_b791, 4); mov(memw[es, bx + 0x4a], si);             /* mov [es:bx+0x4a], si */
            ii(0x19_b795, 5); push(memw[es, bx + 0xb4]);                /* push word [es:bx+0xb4] */
            ii(0x19_b79a, 3); les(bx, memw[ss, bp - 0x14]);             /* les bx, [bp-0x14] */
            ii(0x19_b79d, 4); mov(ax, memw[es, bx + 0x6c]);             /* mov ax, [es:bx+0x6c] */
            ii(0x19_b7a1, 4); mov(dx, memw[es, bx + 0x6e]);             /* mov dx, [es:bx+0x6e] */
            ii(0x19_b7a5, 3); add(ax, memw[ss, bp - 0x2a]);             /* add ax, [bp-0x2a] */
            ii(0x19_b7a8, 3); adc(dx, memw[ss, bp - 0x28]);             /* adc dx, [bp-0x28] */
            ii(0x19_b7ab, 1); push(dx);                                 /* push dx */
            ii(0x19_b7ac, 1); push(ax);                                 /* push ax */
            ii(0x19_b7ad, 1); push(si);                                 /* push si */
            ii(0x19_b7ae, 1); push(di);                                 /* push di */
            ii(0x19_b7af, 3); push(memw[ss, bp - 0x6]);                 /* push word [bp-0x6] */
            ii(0x19_b7b2, 3); push(memw[ss, bp - 0x8]);                 /* push word [bp-0x8] */
            ii(0x19_b7b5, 3); call(0x19_c4e3, 0xd2b);                   /* call 0xc4e3 */
            ii(0x19_b7b8, 3); les(bx, memw[ss, bp + 0x4]);              /* les bx, [bp+0x4] */
            ii(0x19_b7bb, 5); push(memw[es, bx + 0xb4]);                /* push word [es:bx+0xb4] */
            ii(0x19_b7c0, 3); les(bx, memw[ss, bp - 0x14]);             /* les bx, [bp-0x14] */
            ii(0x19_b7c3, 4); mov(ax, memw[es, bx + 0x70]);             /* mov ax, [es:bx+0x70] */
            ii(0x19_b7c7, 4); mov(dx, memw[es, bx + 0x72]);             /* mov dx, [es:bx+0x72] */
            ii(0x19_b7cb, 3); add(ax, memw[ss, bp - 0x2a]);             /* add ax, [bp-0x2a] */
            ii(0x19_b7ce, 3); adc(dx, memw[ss, bp - 0x28]);             /* adc dx, [bp-0x28] */
            ii(0x19_b7d1, 1); push(dx);                                 /* push dx */
            ii(0x19_b7d2, 1); push(ax);                                 /* push ax */
            ii(0x19_b7d3, 3); add(di, memw[ss, bp - 0x8]);              /* add di, [bp-0x8] */
            ii(0x19_b7d6, 3); adc(si, memw[ss, bp - 0x6]);              /* adc si, [bp-0x6] */
            ii(0x19_b7d9, 1); push(si);                                 /* push si */
            ii(0x19_b7da, 1); push(di);                                 /* push di */
            ii(0x19_b7db, 3); push(memw[ss, bp - 0x2]);                 /* push word [bp-0x2] */
            ii(0x19_b7de, 3); push(memw[ss, bp - 0x4]);                 /* push word [bp-0x4] */
            ii(0x19_b7e1, 3); call(0x19_c4e3, 0xcff);                   /* call 0xc4e3 */
            ii(0x19_b7e4, 3); les(bx, memw[ss, bp + 0x4]);              /* les bx, [bp+0x4] */
            ii(0x19_b7e7, 5); push(memw[es, bx + 0x12a]);               /* push word [es:bx+0x12a] */
            ii(0x19_b7ec, 2); push(0x1);                                /* push 0x1 */
            ii(0x19_b7ee, 1); push(si);                                 /* push si */
            ii(0x19_b7ef, 1); push(di);                                 /* push di */
            ii(0x19_b7f0, 3); push(memw[ss, bp - 0x2]);                 /* push word [bp-0x2] */
            ii(0x19_b7f3, 3); push(memw[ss, bp - 0x4]);                 /* push word [bp-0x4] */
            ii(0x19_b7f6, 3); call(0x19_de46, 0x264d);                  /* call 0xde46 */
            ii(0x19_b7f9, 3); les(bx, memw[ss, bp + 0x4]);              /* les bx, [bp+0x4] */
            ii(0x19_b7fc, 4); mov(memw[es, bx + 0x28], ax);             /* mov [es:bx+0x28], ax */
            ii(0x19_b800, 4); mov(memw[es, bx + 0x2a], dx);             /* mov [es:bx+0x2a], dx */
            ii(0x19_b804, 5); push(memw[es, bx + 0xb4]);                /* push word [es:bx+0xb4] */
            ii(0x19_b809, 3); mov(ax, memw[ss, bp - 0x2a]);             /* mov ax, [bp-0x2a] */
            ii(0x19_b80c, 3); mov(dx, memw[ss, bp - 0x28]);             /* mov dx, [bp-0x28] */
            ii(0x19_b80f, 3); les(bx, memw[ss, bp - 0x14]);             /* les bx, [bp-0x14] */
            ii(0x19_b812, 4); add(ax, memw[es, bx + 0x78]);             /* add ax, [es:bx+0x78] */
            ii(0x19_b816, 4); adc(dx, memw[es, bx + 0x7a]);             /* adc dx, [es:bx+0x7a] */
            ii(0x19_b81a, 1); push(dx);                                 /* push dx */
            ii(0x19_b81b, 1); push(ax);                                 /* push ax */
            ii(0x19_b81c, 3); add(di, memw[ss, bp - 0x4]);              /* add di, [bp-0x4] */
            ii(0x19_b81f, 3); adc(si, memw[ss, bp - 0x2]);              /* adc si, [bp-0x2] */
            ii(0x19_b822, 1); push(si);                                 /* push si */
            ii(0x19_b823, 1); push(di);                                 /* push di */
            ii(0x19_b824, 3); push(memw[ss, bp - 0xe]);                 /* push word [bp-0xe] */
            ii(0x19_b827, 3); push(memw[ss, bp - 0x10]);                /* push word [bp-0x10] */
            ii(0x19_b82a, 3); call(0x19_c4e3, 0xcb6);                   /* call 0xc4e3 */
            ii(0x19_b82d, 3); les(bx, memw[ss, bp + 0x4]);              /* les bx, [bp+0x4] */
            ii(0x19_b830, 5); push(memw[es, bx + 0x12a]);               /* push word [es:bx+0x12a] */
            ii(0x19_b835, 2); push(0x1);                                /* push 0x1 */
            ii(0x19_b837, 1); push(si);                                 /* push si */
            ii(0x19_b838, 1); push(di);                                 /* push di */
            ii(0x19_b839, 3); push(memw[ss, bp - 0xe]);                 /* push word [bp-0xe] */
            ii(0x19_b83c, 3); push(memw[ss, bp - 0x10]);                /* push word [bp-0x10] */
            ii(0x19_b83f, 3); call(0x19_de46, 0x2604);                  /* call 0xde46 */
            ii(0x19_b842, 3); les(bx, memw[ss, bp + 0x4]);              /* les bx, [bp+0x4] */
            ii(0x19_b845, 4); mov(memw[es, bx + 0x2c], ax);             /* mov [es:bx+0x2c], ax */
            ii(0x19_b849, 4); mov(memw[es, bx + 0x2e], dx);             /* mov [es:bx+0x2e], dx */
            ii(0x19_b84d, 1); push(es);                                 /* push es */
            ii(0x19_b84e, 1); push(bx);                                 /* push bx */
            ii(0x19_b84f, 1); nop();                                    /* nop */
            ii(0x19_b850, 1); push(cs);                                 /* push cs */
            ii(0x19_b851, 3); call(0x19_c40b, 0xbb7);                   /* call 0xc40b */
            ii(0x19_b854, 1); pop(bx);                                  /* pop bx */
            ii(0x19_b855, 1); pop(bx);                                  /* pop bx */
            ii(0x19_b856, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_b858:
            ii(0x19_b858, 1); pop(si);                                  /* pop si */
            ii(0x19_b859, 1); pop(di);                                  /* pop di */
            ii(0x19_b85a, 1); leave();                                  /* leave */
            ii(0x19_b85b, 3); ret(0x4);                                 /* ret 0x4 */
        }
    }
}
