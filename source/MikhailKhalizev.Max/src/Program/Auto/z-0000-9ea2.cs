using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9ea2-4358619d")]
        public void Method_0000_9ea2()
        {
            ii(0x9ea2, 1);    push(bp);                                 /* push bp */
            ii(0x9ea3, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x9ea5, 1);    push(si);                                 /* push si */
            ii(0x9ea6, 1);    push(di);                                 /* push di */
            ii(0x9ea7, 1);    push(ds);                                 /* push ds */
            ii(0x9ea8, 3);    mov(ds, memw[ss, bp + 4]);                /* mov ds, [bp+0x4] */
            ii(0x9eab, 3);    mov(si, memw[ss, bp + 6]);                /* mov si, [bp+0x6] */
            ii(0x9eae, 3);    mov(es, memw[ss, bp + 8]);                /* mov es, [bp+0x8] */
            ii(0x9eb1, 3);    mov(di, memw[ss, bp + 10]);               /* mov di, [bp+0xa] */
            ii(0x9eb4, 3);    mov(cx, memw[ss, bp + 12]);               /* mov cx, [bp+0xc] */
            ii(0x9eb7, 2);    rep(() => movsb());                       /* rep movsb */
            ii(0x9eb9, 1);    pop(ds);                                  /* pop ds */
            ii(0x9eba, 1);    pop(di);                                  /* pop di */
            ii(0x9ebb, 1);    pop(si);                                  /* pop si */
            ii(0x9ebc, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x9ebe, 1);    pop(bp);                                  /* pop bp */
            ii(0x9ebf, 1);    ret();                                    /* ret */
        }
    }
}
