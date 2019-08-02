using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("877b0d2c-04c3-4e0d-b267-e4d1e2a57aa7")]
        public void Method_0013_8ab4()
        {
            ii(0x13_8ab4, 4); enterw(0x6, 0);                           /* enter 0x6, 0x0 */
            ii(0x13_8ab8, 1); pushw(si);                                /* push si */
            ii(0x13_8ab9, 1); pushw(ds);                                /* push ds */
            ii(0x13_8aba, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_8abd, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_8abf, 4); les(bx, ds, 0xa30);                       /* les bx, [0xa30] */
            ii(0x13_8ac3, 4); mov(al, memb_a16[es, bx + 0x13]);         /* mov al, [es:bx+0x13] */
            ii(0x13_8ac7, 3); mov(memb_a16[ss, bp - 0x6], al);          /* mov [bp-0x6], al */
            ii(0x13_8aca, 3); mov(si, memw_a16[ss, bp + 0x6]);          /* mov si, [bp+0x6] */
            ii(0x13_8acd, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x13_8acf, 2); shl(si, 0x1);                             /* shl si, 1 */
            ii(0x13_8ad1, 2); add(si, ax);                              /* add si, ax */
            ii(0x13_8ad3, 2); shl(si, 0x1);                             /* shl si, 1 */
            ii(0x13_8ad5, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x13_8ad7, 2); mov(cx, es);                              /* mov cx, es */
            ii(0x13_8ad9, 4); les(bx, ds, 0x1f60);                      /* les bx, [0x1f60] */
            ii(0x13_8add, 4); mov(dl, memb_a16[es, bx + si + 0x4]);     /* mov dl, [es:bx+si+0x4] */
            ii(0x13_8ae1, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x13_8ae3, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_8ae5, 4); mov(memb_a16[es, bx + 0x13], dl);         /* mov [es:bx+0x13], dl */
            ii(0x13_8ae9, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_8aeb, 3); pushw(0x1000);                            /* push 0x1000 */
            ii(0x13_8aee, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x13_8af1, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_8af4, 2); pushw(0x13);                              /* push 0x13 */
            ii(0x13_8af6, 1); nop();                                    /* nop */
            ii(0x13_8af7, 1); pushw(cs);                                /* push cs */
            ii(0x13_8af8, 3); callw(0x13_9175, 0x67a);                  /* call 0x9175 */
            ii(0x13_8afb, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x13_8afe, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_8b01, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x13_8b04, 3); mov(al, memb_a16[ss, bp - 0x6]);          /* mov al, [bp-0x6] */
            ii(0x13_8b07, 4); les(bx, ds, 0xa30);                       /* les bx, [0xa30] */
            ii(0x13_8b0b, 4); mov(memb_a16[es, bx + 0x13], al);         /* mov [es:bx+0x13], al */
            ii(0x13_8b0f, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_8b12, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_8b15, 1); popw(ds);                                 /* pop ds */
            ii(0x13_8b16, 1); popw(si);                                 /* pop si */
            ii(0x13_8b17, 1); leavew();                                 /* leave */
            ii(0x13_8b18, 1); retfw(); return;                          /* retf */
        }
    }
}
