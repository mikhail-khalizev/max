using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xbeb2-4358619d")]
        public void Method_0000_beb2()
        {
            ii(0xbeb2, 1);    push(bp);                                 /* push bp */
            ii(0xbeb3, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xbeb5, 1);    push(si);                                 /* push si */
            ii(0xbeb6, 1);    push(di);                                 /* push di */
            ii(0xbeb7, 1);    push(ds);                                 /* push ds */
            ii(0xbeb8, 3);    mov(ds, memw[ss, bp + 4]);                /* mov ds, [bp+0x4] */
            ii(0xbebb, 3);    mov(si, memw[ss, bp + 6]);                /* mov si, [bp+0x6] */
            ii(0xbebe, 3);    mov(es, memw[ss, bp + 8]);                /* mov es, [bp+0x8] */
            ii(0xbec1, 3);    mov(di, memw[ss, bp + 0xa]);              /* mov di, [bp+0xa] */
            ii(0xbec4, 3);    mov(cx, memw[ss, bp + 0xc]);              /* mov cx, [bp+0xc] */
            ii(0xbec7, 2);    rep(() => movsb());                       /* rep movsb */
            ii(0xbec9, 1);    pop(ds);                                  /* pop ds */
            ii(0xbeca, 1);    pop(di);                                  /* pop di */
            ii(0xbecb, 1);    pop(si);                                  /* pop si */
            ii(0xbecc, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0xbece, 1);    pop(bp);                                  /* pop bp */
            ii(0xbecf, 1);    ret();                                    /* ret */
        }
    }
}
