using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9cd1-ccf9672f")]
        public void Method_0000_9cd1()
        {
            ii(0x9cd1, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x9cd3, 1);    push(si);                                 /* push si */
            ii(0x9cd4, 1);    push(di);                                 /* push di */
            ii(0x9cd5, 2);    mov(ax, ds);                              /* mov ax, ds */
            ii(0x9cd7, 1);    push(ax);                                 /* push ax */
            ii(0x9cd8, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x9cda, 4);    mov(cx, memw[ss, bx + 0x8]);              /* mov cx, [ss:bx+0x8] */
            ii(0x9cde, 4);    mov(di, memw[ss, bx + 0x6]);              /* mov di, [ss:bx+0x6] */
            ii(0x9ce2, 4);    mov(si, memw[ss, bx + 0x4]);              /* mov si, [ss:bx+0x4] */
            ii(0x9ce6, 4);    mov(ds, memw[ss, bx + 0x2]);              /* mov ds, [ss:bx+0x2] */
            ii(0x9cea, 1);    cld();                                    /* cld */
            ii(0x9ceb, 2);    rep(() => movsb());                       /* rep movsb */
            ii(0x9ced, 1);    pop(ds);                                  /* pop ds */
            ii(0x9cee, 1);    pop(di);                                  /* pop di */
            ii(0x9cef, 1);    pop(si);                                  /* pop si */
            ii(0x9cf0, 1);    ret();                                    /* ret */
        }
    }
}
