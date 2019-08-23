using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6dab-dcb27775")]
        public void Method_0000_6dab()
        {
            ii(0x6dab, 4);    enter(0x6, 0);                            /* enter 0x6, 0x0 */
            ii(0x6daf, 3);    mov(bx, memw[ss, bp + 0x4]);              /* mov bx, [bp+0x4] */
            ii(0x6db2, 3);    mov(ax, memw[ds, bx + 0x4]);              /* mov ax, [bx+0x4] */
            ii(0x6db5, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x6db7, 2);    mov(cl, 0x9);                             /* mov cl, 0x9 */
            ii(0x6db9, 3);    call(0x6544, -0x878);                     /* call 0x6544 */
            ii(0x6dbc, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x6dbf, 3);    mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x6dc2, 5);    mov(memw[ss, bp - 0x6], 0);               /* mov word [bp-0x6], 0x0 */
            ii(0x6dc7, 3);    mov(bx, memw[ss, bp + 0x4]);              /* mov bx, [bp+0x4] */
            ii(0x6dca, 4);    cmp(memw[ds, bx + 0x2], 0);               /* cmp word [bx+0x2], 0x0 */
            ii(0x6dce, 2);    if(jz(0x6de7, 0x17)) goto l_0x6de7;       /* jz 0x6de7 */
            ii(0x6dd0, 3);    cmp(memb[ds, bx], 0x4d);                  /* cmp byte [bx], 0x4d */
            ii(0x6dd3, 2);    if(jnz(0x6dda, 0x5)) goto l_0x6dda;       /* jnz 0x6dda */
            ii(0x6dd5, 5);    mov(memw[ss, bp - 0x6], 0x200);           /* mov word [bp-0x6], 0x200 */
        l_0x6dda:
            ii(0x6dda, 3);    mov(ax, memw[ds, bx + 0x2]);              /* mov ax, [bx+0x2] */
            ii(0x6ddd, 3);    sub(ax, memw[ss, bp - 0x6]);              /* sub ax, [bp-0x6] */
            ii(0x6de0, 1);    cwd();                                    /* cwd */
            ii(0x6de1, 3);    add(memw[ss, bp - 0x4], ax);              /* add [bp-0x4], ax */
            ii(0x6de4, 3);    adc(memw[ss, bp - 0x2], dx);              /* adc [bp-0x2], dx */
        l_0x6de7:
            ii(0x6de7, 3);    mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x6dea, 3);    mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0x6ded, 1);    leave();                                  /* leave */
            ii(0x6dee, 1);    ret();                                    /* ret */
        }
    }
}
