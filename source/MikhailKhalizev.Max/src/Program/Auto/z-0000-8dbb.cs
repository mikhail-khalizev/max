using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8dbb-dcb27775")]
        public void Method_0000_8dbb()
        {
            ii(0x8dbb, 4);    enter(0x6, 0);                            /* enter 0x6, 0x0 */
            ii(0x8dbf, 3);    mov(bx, memw[ss, bp + 0x4]);              /* mov bx, [bp+0x4] */
            ii(0x8dc2, 3);    mov(ax, memw[ds, bx + 0x4]);              /* mov ax, [bx+0x4] */
            ii(0x8dc5, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x8dc7, 2);    mov(cl, 0x9);                             /* mov cl, 0x9 */
            ii(0x8dc9, 3);    call(0x8554, -0x878);                     /* call 0x8554 */
            ii(0x8dcc, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x8dcf, 3);    mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x8dd2, 5);    mov(memw[ss, bp - 0x6], 0);               /* mov word [bp-0x6], 0x0 */
            ii(0x8dd7, 3);    mov(bx, memw[ss, bp + 0x4]);              /* mov bx, [bp+0x4] */
            ii(0x8dda, 4);    cmp(memw[ds, bx + 0x2], 0);               /* cmp word [bx+0x2], 0x0 */
            ii(0x8dde, 2);    if(jz(0x8df7, 0x17)) goto l_0x8df7;       /* jz 0x8df7 */
            ii(0x8de0, 3);    cmp(memb[ds, bx], 0x4d);                  /* cmp byte [bx], 0x4d */
            ii(0x8de3, 2);    if(jnz(0x8dea, 0x5)) goto l_0x8dea;       /* jnz 0x8dea */
            ii(0x8de5, 5);    mov(memw[ss, bp - 0x6], 0x200);           /* mov word [bp-0x6], 0x200 */
        l_0x8dea:
            ii(0x8dea, 3);    mov(ax, memw[ds, bx + 0x2]);              /* mov ax, [bx+0x2] */
            ii(0x8ded, 3);    sub(ax, memw[ss, bp - 0x6]);              /* sub ax, [bp-0x6] */
            ii(0x8df0, 1);    cwd();                                    /* cwd */
            ii(0x8df1, 3);    add(memw[ss, bp - 0x4], ax);              /* add [bp-0x4], ax */
            ii(0x8df4, 3);    adc(memw[ss, bp - 0x2], dx);              /* adc [bp-0x2], dx */
        l_0x8df7:
            ii(0x8df7, 3);    mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x8dfa, 3);    mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0x8dfd, 1);    leave();                                  /* leave */
            ii(0x8dfe, 1);    ret();                                    /* ret */
        }
    }
}
