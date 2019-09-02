using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7609-9d41d03e")]
        public void Method_0000_7609()
        {
            ii(0x7609, 1);    pop(bx);                                  /* pop bx */
            ii(0x760a, 3);    push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x760d, 3);    call(0x61de, -0x1432);                    /* call 0x61de */
            ii(0x7610, 1);    pop(bx);                                  /* pop bx */
            ii(0x7611, 3);    mov(memw[ds, 0xf4e], ax);                 /* mov [0xf4e], ax */
            ii(0x7614, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x7616, 2);    if(jnz(0x761e, 6)) goto l_0x761e;         /* jnz 0x761e */
            ii(0x7618, 2);    push(9);                                  /* push 0x9 */
            ii(0x761a, 3);    call(0x604d, -0x15d0);                    /* call 0x604d */
            ii(0x761d, 1);    pop(bx);                                  /* pop bx */
        l_0x761e:
            ii(0x761e, 3);    push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x7621, 2);    push(0);                                  /* push 0x0 */
            ii(0x7623, 4);    push(memw[ds, 0xf4e]);                    /* push word [0xf4e] */
            ii(0x7627, 3);    call(0x6516, -0x1114);                    /* call 0x6516 */
            ii(0x762a, 3);    mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x762d, 4);    add(ax, memw[ds, 0xf4e]);                 /* add ax, [0xf4e] */
            ii(0x7631, 3);    mov(memw[ds, 0xf4c], ax);                 /* mov [0xf4c], ax */
            ii(0x7634, 3);    sub(ax, 0x2a);                            /* sub ax, 0x2a */
            ii(0x7637, 3);    mov(memw[ds, 0x996], ax);                 /* mov [0x996], ax */
            ii(0x763a, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0x763c, 4);    mov(cx, memw[ds, 0xf4c]);                 /* mov cx, [0xf4c] */
            ii(0x7640, 2);    mov(memw[ds, bx], cx);                    /* mov [bx], cx */
            ii(0x7642, 5);    mov(memw[ds, bx + 0x18], 0xffff);         /* mov word [bx+0x18], 0xffff */
            ii(0x7647, 6);    mov(memw[ds, 0x99e], 0);                  /* mov word [0x99e], 0x0 */
            ii(0x764d, 1);    leave();                                  /* leave */
            ii(0x764e, 1);    ret();                                    /* ret */
        }
    }
}
