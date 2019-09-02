using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_8ab4-80b8d5a8")]
        public void Method_0017_8ab4()
        {
            ii(0x17_8ab4, 4); enter(6, 0);                              /* enter 0x6, 0x0 */
            ii(0x17_8ab8, 1); push(si);                                 /* push si */
            ii(0x17_8ab9, 1); push(ds);                                 /* push ds */
            ii(0x17_8aba, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_8abd, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_8abf, 4); les(bx, memw[ds, 0xa30]);                 /* les bx, [0xa30] */
            ii(0x17_8ac3, 4); mov(al, memb[es, bx + 0x13]);             /* mov al, [es:bx+0x13] */
            ii(0x17_8ac7, 3); mov(memb[ss, bp - 6], al);                /* mov [bp-0x6], al */
            ii(0x17_8aca, 3); mov(si, memw[ss, bp + 6]);                /* mov si, [bp+0x6] */
            ii(0x17_8acd, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x17_8acf, 2); shl(si, 1);                               /* shl si, 1 */
            ii(0x17_8ad1, 2); add(si, ax);                              /* add si, ax */
            ii(0x17_8ad3, 2); shl(si, 1);                               /* shl si, 1 */
            ii(0x17_8ad5, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x17_8ad7, 2); mov(cx, es);                              /* mov cx, es */
            ii(0x17_8ad9, 4); les(bx, memw[ds, 0x1f60]);                /* les bx, [0x1f60] */
            ii(0x17_8add, 4); mov(dl, memb[es, bx + si + 4]);           /* mov dl, [es:bx+si+0x4] */
            ii(0x17_8ae1, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x17_8ae3, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_8ae5, 4); mov(memb[es, bx + 0x13], dl);             /* mov [es:bx+0x13], dl */
            ii(0x17_8ae9, 2); push(0);                                  /* push 0x0 */
            ii(0x17_8aeb, 3); push(0x1000);                             /* push 0x1000 */
            ii(0x17_8aee, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x17_8af1, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x17_8af4, 2); push(0x13);                               /* push 0x13 */
            ii(0x17_8af6, 1); nop();                                    /* nop */
            ii(0x17_8af7, 1); push(cs);                                 /* push cs */
            ii(0x17_8af8, 3); call(0x17_9175, 0x67a);                   /* call 0x9175 */
            ii(0x17_8afb, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_8afe, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x17_8b01, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x17_8b04, 3); mov(al, memb[ss, bp - 6]);                /* mov al, [bp-0x6] */
            ii(0x17_8b07, 4); les(bx, memw[ds, 0xa30]);                 /* les bx, [0xa30] */
            ii(0x17_8b0b, 4); mov(memb[es, bx + 0x13], al);             /* mov [es:bx+0x13], al */
            ii(0x17_8b0f, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x17_8b12, 3); mov(dx, memw[ss, bp - 2]);                /* mov dx, [bp-0x2] */
            ii(0x17_8b15, 1); pop(ds);                                  /* pop ds */
            ii(0x17_8b16, 1); pop(si);                                  /* pop si */
            ii(0x17_8b17, 1); leave();                                  /* leave */
            ii(0x17_8b18, 1); retf();                                   /* retf */
        }
    }
}
