using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x81ee-16c66f28")]
        public void Method_0000_81ee()
        {
            ii(0x81ee, 1);    push(bp);                                 /* push bp */
            ii(0x81ef, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x81f1, 3);    sub(sp, 2);                               /* sub sp, 0x2 */
            ii(0x81f4, 3);    push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x81f7, 3);    call(0xc373, 0x4179);                     /* call 0xc373 */
            ii(0x81fa, 1);    pop(bx);                                  /* pop bx */
            ii(0x81fb, 3);    mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x81fe, 1);    inc(ax);                                  /* inc ax */
            ii(0x81ff, 2);    if(jz(0x8206, 5)) goto l_0x8206;          /* jz 0x8206 */
            ii(0x8201, 3);    mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x8204, 2);    jmp(0x8208, 2); goto l_0x8208;            /* jmp 0x8208 */
        l_0x8206:
            ii(0x8206, 2);    sub(ax, ax);                              /* sub ax, ax */
        l_0x8208:
            ii(0x8208, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x820a, 1);    pop(bp);                                  /* pop bp */
            ii(0x820b, 1);    ret();                                    /* ret */
        }
    }
}
