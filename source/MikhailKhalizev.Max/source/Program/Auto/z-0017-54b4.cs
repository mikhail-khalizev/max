using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_54b4-a5b52fd")]
        public void Method_0017_54b4()
        {
            ii(0x17_54b4, 4);  enter(0x14, 0);                         /* enter 0x14, 0x0 */
            ii(0x17_54b8, 1);  push(si);                               /* push si */
            ii(0x17_54b9, 1);  push(ds);                               /* push ds */
            ii(0x17_54ba, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_54bd, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_54bf, 3);  push(0x1000);                           /* push 0x1000 */
            ii(0x17_54c2, 1);  nop();                                  /* nop */
            ii(0x17_54c3, 1);  push(cs);                               /* push cs */
            ii(0x17_54c4, 3);  call(0x16_e7a8, -0x6d1f);               /* call 0xe7a8 */
            ii(0x17_54c7, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_54ca, 3);  mov(memw[ss, bp - 20], ax);             /* mov [bp-0x14], ax */
            ii(0x17_54cd, 3);  mov(memw[ss, bp - 18], dx);             /* mov [bp-0x12], dx */
            ii(0x17_54d0, 2);  mov(ax, dx);                            /* mov ax, dx */
            ii(0x17_54d2, 3);  or(ax, memw[ss, bp - 20]);              /* or ax, [bp-0x14] */
            ii(0x17_54d5, 2);  if(jnz(0x17_54ea, 0x13)) goto l_0x17_54ea;/* jnz 0x54ea */
            ii(0x17_54d7, 1);  push(ds);                               /* push ds */
            ii(0x17_54d8, 3);  push(0x32c);                            /* push 0x32c */
            ii(0x17_54db, 1);  nop();                                  /* nop */
            ii(0x17_54dc, 1);  push(cs);                               /* push cs */
            ii(0x17_54dd, 3);  call(0x17_104f, -0x4491);               /* call 0x104f */
            ii(0x17_54e0, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x17_54e3, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_54e6, 1);  pop(ds);                                /* pop ds */
            ii(0x17_54e7, 1);  pop(si);                                /* pop si */
            ii(0x17_54e8, 1);  leave();                                /* leave */
            ii(0x17_54e9, 1);  retf(); return;                         /* retf */
        l_0x17_54ea:
            ii(0x17_54ea, 5);  mov(memw[ss, bp - 2], 0xffc);           /* mov word [bp-0x2], 0xffc */
            ii(0x17_54ef, 5);  mov(memw[ss, bp - 8], 0x4ba8);          /* mov word [bp-0x8], 0x4ba8 */
            ii(0x17_54f4, 5);  mov(memw[ss, bp - 6], 0x3e58);          /* mov word [bp-0x6], 0x3e58 */
            ii(0x17_54f9, 2);  mov(ax, dx);                            /* mov ax, dx */
            ii(0x17_54fb, 3);  mov(memw[ss, bp - 10], ax);             /* mov [bp-0xa], ax */
            ii(0x17_54fe, 1);  nop();                                  /* nop */
            ii(0x17_54ff, 1);  push(cs);                               /* push cs */
            ii(0x17_5500, 3);  call(0x17_9199, 0x3c96);                /* call 0x9199 */
            ii(0x17_5503, 3);  mov(memw[ss, bp - 14], ax);             /* mov [bp-0xe], ax */
            ii(0x17_5506, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x17_5509, 5);  mov(memw[ss, bp - 16], 1);              /* mov word [bp-0x10], 0x1 */
            ii(0x17_550e, 2);  sub(cx, cx);                            /* sub cx, cx */
            ii(0x17_5510, 3);  mov(memw[ss, bp - 4], cx);              /* mov [bp-0x4], cx */
            ii(0x17_5513, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x17_5516, 3);  mov(memw[es, bx], cx);                  /* mov [es:bx], cx */
            ii(0x17_5519, 4);  mov(memw[es, bx + 2], cx);              /* mov [es:bx+0x2], cx */
            ii(0x17_551d, 6);  mov(memw[es, bx + 4], 0xffc);           /* mov word [es:bx+0x4], 0xffc */
            ii(0x17_5523, 4);  mov(memw[es, bx + 6], cx);              /* mov [es:bx+0x6], cx */
            ii(0x17_5527, 3);  mov(cx, memw[ss, bp - 10]);             /* mov cx, [bp-0xa] */
            ii(0x17_552a, 4);  mov(memw[es, bx + 8], cx);              /* mov [es:bx+0x8], cx */
            ii(0x17_552e, 6);  mov(memw[es, bx + 10], 0);              /* mov word [es:bx+0xa], 0x0 */
            ii(0x17_5534, 6);  mov(memw[es, bx + 12], 0xffc);          /* mov word [es:bx+0xc], 0xffc */
            ii(0x17_553a, 6);  mov(memw[es, bx + 14], 0);              /* mov word [es:bx+0xe], 0x0 */
            ii(0x17_5540, 4);  mov(memw[es, bx + 16], cx);             /* mov [es:bx+0x10], cx */
            ii(0x17_5544, 6);  mov(memw[es, bx + 18], 0);              /* mov word [es:bx+0x12], 0x0 */
            ii(0x17_554a, 6);  mov(memw[es, bx + 20], 0xffc);          /* mov word [es:bx+0x14], 0xffc */
            ii(0x17_5550, 6);  mov(memw[es, bx + 22], 0);              /* mov word [es:bx+0x16], 0x0 */
            ii(0x17_5556, 4);  mov(memw[es, bx + 24], cx);             /* mov [es:bx+0x18], cx */
            ii(0x17_555a, 6);  mov(memw[es, bx + 26], 0);              /* mov word [es:bx+0x1a], 0x0 */
            ii(0x17_5560, 3);  mov(dx, memw[ss, bp - 8]);              /* mov dx, [bp-0x8] */
            ii(0x17_5563, 4);  mov(memw[es, bx + 32], dx);             /* mov [es:bx+0x20], dx */
            ii(0x17_5567, 6);  mov(memw[es, bx + 34], 0);              /* mov word [es:bx+0x22], 0x0 */
            ii(0x17_556d, 6);  mov(memw[es, bx + 36], 1);              /* mov word [es:bx+0x24], 0x1 */
            ii(0x17_5573, 6);  mov(memw[es, bx + 38], 0);              /* mov word [es:bx+0x26], 0x0 */
            ii(0x17_5579, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x17_557b, 4);  mov(memw[es, bx + 42], dx);             /* mov [es:bx+0x2a], dx */
            ii(0x17_557f, 4);  mov(memw[es, bx + 40], dx);             /* mov [es:bx+0x28], dx */
            ii(0x17_5583, 4);  mov(memw[es, bx + 46], dx);             /* mov [es:bx+0x2e], dx */
            ii(0x17_5587, 4);  mov(memw[es, bx + 44], dx);             /* mov [es:bx+0x2c], dx */
            ii(0x17_558b, 4);  mov(memw[es, bx + 50], dx);             /* mov [es:bx+0x32], dx */
            ii(0x17_558f, 4);  mov(memw[es, bx + 48], dx);             /* mov [es:bx+0x30], dx */
            ii(0x17_5593, 4);  mov(memw[es, bx + 54], dx);             /* mov [es:bx+0x36], dx */
            ii(0x17_5597, 4);  mov(memw[es, bx + 52], dx);             /* mov [es:bx+0x34], dx */
            ii(0x17_559b, 3);  mov(dx, 0xffc);                         /* mov dx, 0xffc */
            ii(0x17_559e, 2);  sub(si, si);                            /* sub si, si */
            ii(0x17_55a0, 4);  mov(memw[es, bx + 56], dx);             /* mov [es:bx+0x38], dx */
            ii(0x17_55a4, 4);  mov(memw[es, bx + 58], si);             /* mov [es:bx+0x3a], si */
            ii(0x17_55a8, 4);  mov(memw[es, bx + 60], dx);             /* mov [es:bx+0x3c], dx */
            ii(0x17_55ac, 4);  mov(memw[es, bx + 62], si);             /* mov [es:bx+0x3e], si */
            ii(0x17_55b0, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x17_55b2, 4);  mov(memw[es, bx + 66], dx);             /* mov [es:bx+0x42], dx */
            ii(0x17_55b6, 4);  mov(memw[es, bx + 64], dx);             /* mov [es:bx+0x40], dx */
            ii(0x17_55ba, 4);  mov(memw[es, bx + 70], dx);             /* mov [es:bx+0x46], dx */
            ii(0x17_55be, 4);  mov(memw[es, bx + 68], dx);             /* mov [es:bx+0x44], dx */
            ii(0x17_55c2, 4);  mov(memw[es, bx + 72], ax);             /* mov [es:bx+0x48], ax */
            ii(0x17_55c6, 4);  mov(memw[es, bx + 74], dx);             /* mov [es:bx+0x4a], dx */
            ii(0x17_55ca, 3);  mov(dx, memw[ss, bp - 6]);              /* mov dx, [bp-0x6] */
            ii(0x17_55cd, 4);  mov(memw[es, bx + 76], dx);             /* mov [es:bx+0x4c], dx */
            ii(0x17_55d1, 4);  mov(memw[es, bx + 80], cx);             /* mov [es:bx+0x50], cx */
            ii(0x17_55d5, 4);  mov(memw[es, bx + 84], ax);             /* mov [es:bx+0x54], ax */
            ii(0x17_55d9, 4);  mov(memw[es, bx + 96], si);             /* mov [es:bx+0x60], si */
            ii(0x17_55dd, 4);  mov(memw[es, bx + 100], si);            /* mov [es:bx+0x64], si */
            ii(0x17_55e1, 4);  mov(memw[es, bx + 102], si);            /* mov [es:bx+0x66], si */
            ii(0x17_55e5, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_55e7, 1);  pop(ds);                                /* pop ds */
            ii(0x17_55e8, 1);  pop(si);                                /* pop si */
            ii(0x17_55e9, 1);  leave();                                /* leave */
            ii(0x17_55ea, 1);  retf();                                 /* retf */
        }
    }
}
