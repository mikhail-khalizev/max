using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x95f3-c1cb980f")]
        public void Method_0000_95f3()
        {
            ii(0x95f3, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x95f5, 1);    push(ds);                                 /* push ds */
            ii(0x95f6, 3);    mov(ax, memw[ds, 0xe70]);                 /* mov ax, [0xe70] */
            ii(0x95f9, 3);    mov(cx, memw[ds, bx + 0x6]);              /* mov cx, [bx+0x6] */
            ii(0x95fc, 3);    mov(dx, memw[ds, bx + 0x2]);              /* mov dx, [bx+0x2] */
            ii(0x95ff, 3);    mov(ds, memw[ds, bx + 0x4]);              /* mov ds, [bx+0x4] */
            ii(0x9602, 1);    xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x9603, 2);    mov(ah, 0x3f);                            /* mov ah, 0x3f */
            ii(0x9605, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x9607, 1);    pop(ds);                                  /* pop ds */
            ii(0x9608, 2);    sbb(bx, bx);                              /* sbb bx, bx */
            ii(0x960a, 2);    or(ax, bx);                               /* or ax, bx */
            ii(0x960c, 1);    ret();                                    /* ret */
        }
    }
}
