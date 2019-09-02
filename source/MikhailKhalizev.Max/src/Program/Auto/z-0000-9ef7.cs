using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9ef7-e8c8f54c")]
        public void Method_0000_9ef7()
        {
            ii(0x9ef7, 1);    push(bp);                                 /* push bp */
            ii(0x9ef8, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x9efa, 1);    push(si);                                 /* push si */
            ii(0x9efb, 1);    push(di);                                 /* push di */
            ii(0x9efc, 3);    mov(dx, memw[ss, bp + 4]);                /* mov dx, [bp+0x4] */
            ii(0x9eff, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0x9f01, 3);    add(dx, 0x10);                            /* add dx, 0x10 */
            ii(0x9f04, 3);    mov(di, 0x80);                            /* mov di, 0x80 */
            ii(0x9f07, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x9f09, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x9f0b, 5);    push(memw[es, 2]);                        /* push word [es:0x2] */
            ii(0x9f10, 5);    push(memw[es, 0]);                        /* push word [es:0x0] */
            ii(0x9f15, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0x9f17, 1);    stosb();                                  /* stosb */
            ii(0x9f18, 3);    mov(ax, 0x6956);                          /* mov ax, 0x6956 */
            ii(0x9f1b, 1);    stosw();                                  /* stosw */
            ii(0x9f1c, 2);    mov(ax, cs);                              /* mov ax, cs */
            ii(0x9f1e, 1);    stosw();                                  /* stosw */
            ii(0x9f1f, 3);    mov(ax, memw[ss, bp + 8]);                /* mov ax, [bp+0x8] */
            ii(0x9f22, 1);    stosw();                                  /* stosw */
            ii(0x9f23, 2);    mov(ax, ss);                              /* mov ax, ss */
            ii(0x9f25, 1);    stosw();                                  /* stosw */
            ii(0x9f26, 2);    mov(al, 0xd);                             /* mov al, 0xd */
            ii(0x9f28, 1);    stosb();                                  /* stosb */
            ii(0x9f29, 5);    mov(memw[cs, 0x6905], sp);                /* mov [cs:0x6905], sp */
            ii(0x9f2e, 3);    mov(bx, memw[ss, bp + 6]);                /* mov bx, [bp+0x6] */
            ii(0x9f31, 3);    mov(ax, memw[ds, bx + 0x16]);             /* mov ax, [bx+0x16] */
            ii(0x9f34, 2);    add(ax, dx);                              /* add ax, dx */
            ii(0x9f36, 3);    mov(cx, memw[ds, bx + 0x14]);             /* mov cx, [bx+0x14] */
            ii(0x9f39, 3);    add(dx, memw[ds, bx + 0xe]);              /* add dx, [bx+0xe] */
            ii(0x9f3c, 2);    mov(ss, dx);                              /* mov ss, dx */
            ii(0x9f3e, 3);    mov(sp, memw[ds, bx + 0x10]);             /* mov sp, [bx+0x10] */
            ii(0x9f41, 1);    push(es);                                 /* push es */
            ii(0x9f42, 1);    pop(ds);                                  /* pop ds */
            ii(0x9f43, 1);    push(ax);                                 /* push ax */
            ii(0x9f44, 1);    push(cx);                                 /* push cx */
            ii(0x9f45, 1);    retf();                                   /* retf */
        }
    }
}
