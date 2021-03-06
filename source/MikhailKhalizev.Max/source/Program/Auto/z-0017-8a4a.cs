using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_8a4a-5759c9d7")]
        public void Method_0017_8a4a()
        {
            ii(0x17_8a4a, 4);  enter(6, 0);                            /* enter 0x6, 0x0 */
            ii(0x17_8a4e, 1);  push(si);                               /* push si */
            ii(0x17_8a4f, 1);  push(ds);                               /* push ds */
            ii(0x17_8a50, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_8a53, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_8a55, 4);  les(bx, memw[ds, 0xa30]);               /* les bx, [0xa30] */
            ii(0x17_8a59, 4);  mov(al, memb[es, bx + 19]);             /* mov al, [es:bx+0x13] */
            ii(0x17_8a5d, 3);  mov(memb[ss, bp - 6], al);              /* mov [bp-0x6], al */
            ii(0x17_8a60, 3);  mov(si, memw[ss, bp + 6]);              /* mov si, [bp+0x6] */
            ii(0x17_8a63, 2);  mov(ax, si);                            /* mov ax, si */
            ii(0x17_8a65, 2);  shl(si, 1);                             /* shl si, 1 */
            ii(0x17_8a67, 2);  add(si, ax);                            /* add si, ax */
            ii(0x17_8a69, 2);  shl(si, 1);                             /* shl si, 1 */
            ii(0x17_8a6b, 2);  mov(ax, bx);                            /* mov ax, bx */
            ii(0x17_8a6d, 2);  mov(cx, es);                            /* mov cx, es */
            ii(0x17_8a6f, 4);  les(bx, memw[ds, 0x1f60]);              /* les bx, [0x1f60] */
            ii(0x17_8a73, 4);  mov(dl, memb[es, bx + si + 4]);         /* mov dl, [es:bx+si+0x4] */
            ii(0x17_8a77, 2);  mov(es, cx);                            /* mov es, cx */
            ii(0x17_8a79, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x17_8a7b, 4);  mov(memb[es, bx + 19], dl);             /* mov [es:bx+0x13], dl */
            ii(0x17_8a7f, 2);  push(0);                                /* push 0x0 */
            ii(0x17_8a81, 3);  push(0x1000);                           /* push 0x1000 */
            ii(0x17_8a84, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x17_8a87, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x17_8a8a, 2);  push(0x13);                             /* push 0x13 */
            ii(0x17_8a8c, 1);  nop();                                  /* nop */
            ii(0x17_8a8d, 1);  push(cs);                               /* push cs */
            ii(0x17_8a8e, 3);  call(0x17_9195, 0x704);                 /* call 0x9195 */
            ii(0x17_8a91, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x17_8a94, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_8a97, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x17_8a9a, 3);  mov(al, memb[ss, bp - 6]);              /* mov al, [bp-0x6] */
            ii(0x17_8a9d, 4);  les(bx, memw[ds, 0xa30]);               /* les bx, [0xa30] */
            ii(0x17_8aa1, 4);  mov(memb[es, bx + 19], al);             /* mov [es:bx+0x13], al */
            ii(0x17_8aa5, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x17_8aa8, 3);  mov(dx, memw[ss, bp - 2]);              /* mov dx, [bp-0x2] */
            ii(0x17_8aab, 1);  pop(ds);                                /* pop ds */
            ii(0x17_8aac, 1);  pop(si);                                /* pop si */
            ii(0x17_8aad, 1);  leave();                                /* leave */
            ii(0x17_8aae, 1);  retf();                                 /* retf */
        }
    }
}
