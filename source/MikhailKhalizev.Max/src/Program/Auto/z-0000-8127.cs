using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8127-41b1436")]
        public void Method_0000_8127()
        {
            ii(0x8127, 4);    enter(8, 0);                              /* enter 0x8, 0x0 */
            ii(0x812b, 5);    mov(memw[ss, bp - 4], 0x47b2);            /* mov word [bp-0x4], 0x47b2 */
            ii(0x8130, 5);    mov(memw[ss, bp - 2], 0x35f);             /* mov word [bp-0x2], 0x35f */
            ii(0x8135, 3);    mov(memw[ss, bp - 6], ds);                /* mov [bp-0x6], ds */
            ii(0x8138, 5);    cmp(memw[ds, 0xe70], 0);                  /* cmp word [0xe70], 0x0 */
            ii(0x813d, 2);    if(jge(0x8146, 7)) goto l_0x8146;         /* jge 0x8146 */
            ii(0x813f, 3);    push(0x1190);                             /* push 0x1190 */
            ii(0x8142, 3);    call(0x95a8, 0x1463);                     /* call 0x95a8 */
            ii(0x8145, 1);    pop(bx);                                  /* pop bx */
        l_0x8146:
            ii(0x8146, 5);    cmp(memw[ds, 0xe70], 0);                  /* cmp word [0xe70], 0x0 */
            ii(0x814b, 2);    if(jge(0x8153, 6)) goto l_0x8153;         /* jge 0x8153 */
            ii(0x814d, 2);    push(-8 /* 0xf8 */);                      /* push 0xfff8 */
            ii(0x814f, 3);    call(0x589d, -0x28b5);                    /* call 0x589d */
            ii(0x8152, 1);    pop(bx);                                  /* pop bx */
        l_0x8153:
            ii(0x8153, 3);    mov(ax, memw[ds, 0xc26]);                 /* mov ax, [0xc26] */
            ii(0x8156, 3);    mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x8159, 1);    push(ds);                                 /* push ds */
            ii(0x815a, 3);    push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x815d, 2);    push(0);                                  /* push 0x0 */
            ii(0x815f, 3);    call_far_ind(memw[ss, bp - 4]);           /* call far word [bp-0x4] */
            ii(0x8162, 3);    mov(ax, memw[ss, bp - 6]);                /* mov ax, [bp-0x6] */
            ii(0x8165, 6);    mov(memw[ds, 0x42], 0x9fa);               /* mov word [0x42], 0x9fa */
            ii(0x816b, 3);    mov(memw[ds, 0x44], ax);                  /* mov [0x44], ax */
            ii(0x816e, 1);    leave();                                  /* leave */
            ii(0x816f, 1);    ret();                                    /* ret */
        }
    }
}
