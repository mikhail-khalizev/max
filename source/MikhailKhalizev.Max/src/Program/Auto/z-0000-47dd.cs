using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x47dd-a44991aa")]
        public void Method_0000_47dd()
        {
            ii(0x47dd, 1);    push(bp);                                 /* push bp */
            ii(0x47de, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x47e0, 1);    push(si);                                 /* push si */
            ii(0x47e1, 1);    push(di);                                 /* push di */
            ii(0x47e2, 3);    call(0x3880, -0xf65);                     /* call 0x3880 */
            ii(0x47e5, 2);    push(0x8);                                /* push 0x8 */
            ii(0x47e7, 1);    pop(ds);                                  /* pop ds */
            ii(0x47e8, 3);    mov(ax, memw[ss, bp + 0x4]);              /* mov ax, [bp+0x4] */
            ii(0x47eb, 3);    mov(memw[ds, 0x62], ax);                  /* mov [0x62], ax */
            ii(0x47ee, 3);    mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x47f1, 3);    mov(memb[ds, 0x64], al);                  /* mov [0x64], al */
            ii(0x47f4, 4);    mov(memb[ds, 0x67], ah);                  /* mov [0x67], ah */
            ii(0x47f8, 3);    mov(cx, memw[ss, bp + 0xa]);              /* mov cx, [bp+0xa] */
            ii(0x47fb, 2);    push(0x60);                               /* push 0x60 */
            ii(0x47fd, 1);    pop(ds);                                  /* pop ds */
            ii(0x47fe, 2);    xor(si, si);                              /* xor si, si */
            ii(0x4800, 3);    mov(di, memw[ss, bp + 0x8]);              /* mov di, [bp+0x8] */
            ii(0x4803, 1);    cld();                                    /* cld */
            ii(0x4804, 2);    rep(() => movsb());                       /* rep movsb */
            ii(0x4806, 1);    push(ss);                                 /* push ss */
            ii(0x4807, 1);    pop(ds);                                  /* pop ds */
            ii(0x4808, 3);    call(0x3f19, -0x8f2);                     /* call 0x3f19 */
            ii(0x480b, 1);    pop(di);                                  /* pop di */
            ii(0x480c, 1);    pop(si);                                  /* pop si */
            ii(0x480d, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x480f, 1);    pop(bp);                                  /* pop bp */
            ii(0x4810, 1);    sti();                                    /* sti */
            ii(0x4811, 1);    ret();                                    /* ret */
        }
    }
}
