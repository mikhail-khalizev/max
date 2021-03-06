using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_1c53-b5b4615d")]
        public void Method_0019_1c53()
        {
            ii(0x19_1c53, 4);  enter(6, 0);                            /* enter 0x6, 0x0 */
            ii(0x19_1c57, 1);  push(ds);                               /* push ds */
            ii(0x19_1c58, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_1c5b, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_1c5d, 4);  push(memw[ds, 0x3a60]);                 /* push word [0x3a60] */
            ii(0x19_1c61, 4);  push(memw[ds, 0x3a5e]);                 /* push word [0x3a5e] */
            ii(0x19_1c65, 1);  nop();                                  /* nop */
            ii(0x19_1c66, 1);  push(cs);                               /* push cs */
            ii(0x19_1c67, 3);  call(0x19_5030, 0x33c6);                /* call 0x5030 */
            ii(0x19_1c6a, 1);  pop(bx);                                /* pop bx */
            ii(0x19_1c6b, 1);  pop(bx);                                /* pop bx */
            ii(0x19_1c6c, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_1c6e, 2);  if(jnz(0x19_1c7b, 0xb)) goto l_0x19_1c7b;/* jnz 0x1c7b */
            ii(0x19_1c70, 1);  push(ds);                               /* push ds */
            ii(0x19_1c71, 3);  push(0x3a5a);                           /* push 0x3a5a */
            ii(0x19_1c74, 1);  nop();                                  /* nop */
            ii(0x19_1c75, 1);  push(cs);                               /* push cs */
            ii(0x19_1c76, 3);  call(0x19_4f5a, 0x32e1);                /* call 0x4f5a */
            ii(0x19_1c79, 1);  pop(bx);                                /* pop bx */
            ii(0x19_1c7a, 1);  pop(bx);                                /* pop bx */
        l_0x19_1c7b:
            ii(0x19_1c7b, 1);  push(ds);                               /* push ds */
            ii(0x19_1c7c, 3);  push(0x3ac8);                           /* push 0x3ac8 */
            ii(0x19_1c7f, 1);  nop();                                  /* nop */
            ii(0x19_1c80, 1);  push(cs);                               /* push cs */
            ii(0x19_1c81, 3);  call(0x19_5030, 0x33ac);                /* call 0x5030 */
            ii(0x19_1c84, 1);  pop(bx);                                /* pop bx */
            ii(0x19_1c85, 1);  pop(bx);                                /* pop bx */
            ii(0x19_1c86, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x19_1c89, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_1c8b, 2);  if(jz(0x19_1ca4, 0x17)) goto l_0x19_1ca4;/* jz 0x1ca4 */
            ii(0x19_1c8d, 1);  push(ds);                               /* push ds */
            ii(0x19_1c8e, 3);  push(0x3ad0);                           /* push 0x3ad0 */
            ii(0x19_1c91, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x19_1c94, 1);  push(ax);                               /* push ax */
            ii(0x19_1c95, 1);  nop();                                  /* nop */
            ii(0x19_1c96, 1);  push(cs);                               /* push cs */
            ii(0x19_1c97, 3);  call(0x19_4eb0, 0x3216);                /* call 0x4eb0 */
            ii(0x19_1c9a, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x19_1c9d, 3);  mov(memw[ds, 0x3a74], ax);              /* mov [0x3a74], ax */
            ii(0x19_1ca0, 4);  mov(memw[ds, 0x3a76], dx);              /* mov [0x3a76], dx */
        l_0x19_1ca4:
            ii(0x19_1ca4, 5);  mov(memw[ss, bp - 6], 0xffff);          /* mov word [bp-0x6], 0xffff */
        l_0x19_1ca9:
            ii(0x19_1ca9, 3);  mov(bx, memw[ss, bp - 6]);              /* mov bx, [bp-0x6] */
            ii(0x19_1cac, 2);  shl(bx, 1);                             /* shl bx, 1 */
            ii(0x19_1cae, 6);  mov(memw[ds, bx + 0x3a3a], 0);          /* mov word [bx+0x3a3a], 0x0 */
            ii(0x19_1cb4, 3);  inc(memw[ss, bp - 6]);                  /* inc word [bp-0x6] */
            ii(0x19_1cb7, 4);  cmp(memw[ss, bp - 6], 3);               /* cmp word [bp-0x6], 0x3 */
            ii(0x19_1cbb, 2);  if(jle(0x19_1ca9, -0x14)) goto l_0x19_1ca9;/* jle 0x1ca9 */
            ii(0x19_1cbd, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x19_1cc0, 3);  mov(dx, memw[ss, bp + 8]);              /* mov dx, [bp+0x8] */
            ii(0x19_1cc3, 3);  mov(memw[ds, 0x3a70], ax);              /* mov [0x3a70], ax */
            ii(0x19_1cc6, 4);  mov(memw[ds, 0x3a72], dx);              /* mov [0x3a72], dx */
            ii(0x19_1cca, 1);  push(cs);                               /* push cs */
            ii(0x19_1ccb, 3);  call(0x19_1c3c, -0x92);                 /* call 0x1c3c */
            ii(0x19_1cce, 1);  pop(ds);                                /* pop ds */
            ii(0x19_1ccf, 1);  leave();                                /* leave */
            ii(0x19_1cd0, 3);  retf(4);                                /* retf 0x4 */
        }
    }
}
