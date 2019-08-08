using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("488798b9-1871-4f54-b0a3-93e7825247cc")]
        public void Method_0000_95f3()
        {
            ii(0x95f3, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x95f5, 1);    pushw(ds);                                /* push ds */
            ii(0x95f6, 3);    mov(ax, memw_a16[ds, 0xe70]);             /* mov ax, [0xe70] */
            ii(0x95f9, 3);    mov(cx, memw_a16[ds, bx + 0x6]);          /* mov cx, [bx+0x6] */
            ii(0x95fc, 3);    mov(dx, memw_a16[ds, bx + 0x2]);          /* mov dx, [bx+0x2] */
            ii(0x95ff, 3);    mov(ds, memw_a16[ds, bx + 0x4]);          /* mov ds, [bx+0x4] */
            ii(0x9602, 1);    xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x9603, 2);    mov(ah, 0x3f);                            /* mov ah, 0x3f */
            ii(0x9605, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x9607, 1);    popw(ds);                                 /* pop ds */
            ii(0x9608, 2);    sbb(bx, bx);                              /* sbb bx, bx */
            ii(0x960a, 2);    or(ax, bx);                               /* or ax, bx */
            ii(0x960c, 1);    retw(); return;                           /* ret */
        }
    }
}
