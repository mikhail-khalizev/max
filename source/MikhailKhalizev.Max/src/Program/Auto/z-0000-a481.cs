using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xa481-ccf9672f")]
        public void Method_0000_a481()
        {
            ii(0xa481, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0xa483, 1);    push(si);                                 /* push si */
            ii(0xa484, 1);    push(di);                                 /* push di */
            ii(0xa485, 2);    mov(ax, ds);                              /* mov ax, ds */
            ii(0xa487, 1);    push(ax);                                 /* push ax */
            ii(0xa488, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0xa48a, 4);    mov(cx, memw[ss, bx + 0x8]);              /* mov cx, [ss:bx+0x8] */
            ii(0xa48e, 4);    mov(di, memw[ss, bx + 0x6]);              /* mov di, [ss:bx+0x6] */
            ii(0xa492, 4);    mov(si, memw[ss, bx + 0x4]);              /* mov si, [ss:bx+0x4] */
            ii(0xa496, 4);    mov(ds, memw[ss, bx + 0x2]);              /* mov ds, [ss:bx+0x2] */
            ii(0xa49a, 1);    cld();                                    /* cld */
            ii(0xa49b, 2);    rep(() => movsb());                       /* rep movsb */
            ii(0xa49d, 1);    pop(ds);                                  /* pop ds */
            ii(0xa49e, 1);    pop(di);                                  /* pop di */
            ii(0xa49f, 1);    pop(si);                                  /* pop si */
            ii(0xa4a0, 1);    ret();                                    /* ret */
        }
    }
}
