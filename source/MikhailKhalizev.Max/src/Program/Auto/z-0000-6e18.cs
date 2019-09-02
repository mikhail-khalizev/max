using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6e18-d079fa58")]
        public void Method_0000_6e18()
        {
            ii(0x6e18, 5);    push(memw[cs, 0x1064]);                   /* push word [cs:0x1064] */
            ii(0x6e1d, 3);    mov(memw[ds, bx + 0x1e], sp);             /* mov [bx+0x1e], sp */
            ii(0x6e20, 3);    mov(ax, memw[ss, bp + 0x26]);             /* mov ax, [bp+0x26] */
            ii(0x6e23, 3);    mov(memw[ds, bx - 0x12], ax);             /* mov [bx-0x12], ax */
            ii(0x6e26, 3);    mov(ax, 0x20);                            /* mov ax, 0x20 */
            ii(0x6e29, 2);    mov(ss, ax);                              /* mov ss, ax */
            ii(0x6e2b, 3);    lea(sp, memw[ds, bx - 0x12]);             /* lea sp, [bx-0x12] */
            ii(0x6e2e, 5);    mov(memb[ds, 0x9cc], 0x21);               /* mov byte [0x9cc], 0x21 */
            ii(0x6e33, 3);    call(0x66dc, -0x75a);                     /* call 0x66dc */
            ii(0x6e36, 3);    lea(ax, memw[ds, bx + 0x18]);             /* lea ax, [bx+0x18] */
            ii(0x6e39, 4);    mov(memw[cs, 0x1064], ax);                /* mov [cs:0x1064], ax */
            ii(0x6e3d, 3);    mov(ax, memw[ds, bx + 0x16]);             /* mov ax, [bx+0x16] */
            ii(0x6e40, 6);    mov(memb[cs, 6], 0x21);                   /* mov byte [cs:0x6], 0x21 */
            ii(0x6e46, 5);    mov(memb[cs, 7], ah);                     /* mov [cs:0x7], ah */
            ii(0x6e4b, 3);    push(memw[ds, bx + 0x10]);                /* push word [bx+0x10] */
            ii(0x6e4e, 3);    mov(cx, memw[ds, bx + 0x14]);             /* mov cx, [bx+0x14] */
            ii(0x6e51, 3);    mov(dx, memw[ds, bx + 0x12]);             /* mov dx, [bx+0x12] */
            ii(0x6e54, 3);    mov(bp, memw[ds, bx + 0xc]);              /* mov bp, [bx+0xc] */
            ii(0x6e57, 3);    mov(si, memw[ds, bx + 0xa]);              /* mov si, [bx+0xa] */
            ii(0x6e5a, 3);    mov(di, memw[ds, bx + 8]);                /* mov di, [bx+0x8] */
            ii(0x6e5d, 3);    mov(es, memw[ds, bx + 6]);                /* mov es, [bx+0x6] */
            ii(0x6e60, 3);    mov(ds, memw[ds, bx + 4]);                /* mov ds, [bx+0x4] */
            ii(0x6e63, 1);    pop(bx);                                  /* pop bx */
            ii(0x6e64, 1);    popfw();                                  /* popfw */
            ii(0x6e65, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x6e67, 1);    pushfw();                                 /* pushfw */
            ii(0x6e68, 5);    pop(memw[cs, 0x1066]);                    /* pop word [cs:0x1066] */
            ii(0x6e6d, 1);    cli();                                    /* cli */
            ii(0x6e6e, 5);    mov(ss, memw[cs, 0]);                     /* mov ss, [cs:0x0] */
            ii(0x6e73, 5);    mov(sp, memw[cs, 0x1064]);                /* mov sp, [cs:0x1064] */
            ii(0x6e78, 1);    pusha();                                  /* pusha */
            ii(0x6e79, 1);    push(es);                                 /* push es */
            ii(0x6e7a, 1);    push(ds);                                 /* push ds */
            ii(0x6e7b, 5);    mov(ds, memw[cs, 0]);                     /* mov ds, [cs:0x0] */
            ii(0x6e80, 3);    call(0x6040, -0xe43);                     /* call 0x6040 */
            ii(0x6e83, 4);    mov(ax, memw[cs, 0x1066]);                /* mov ax, [cs:0x1066] */
            ii(0x6e87, 5);    jmp_far_abs(0x70, 0xd81);                 /* jmp word 0x70:0xd81 */
        }
    }
}
