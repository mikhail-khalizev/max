using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x90f9-c09d7cc1")]
        public void Method_0000_90f9()
        {
            ii(0x90f9, 1);    push(bp);                                 /* push bp */
            ii(0x90fa, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x90fc, 3);    sub(sp, 6);                               /* sub sp, 0x6 */
            ii(0x90ff, 3);    mov(bx, memw[ss, bp + 4]);                /* mov bx, [bp+0x4] */
            ii(0x9102, 3);    mov(ax, memw[ds, bx + 4]);                /* mov ax, [bx+0x4] */
            ii(0x9105, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x9107, 2);    mov(cl, 9);                               /* mov cl, 0x9 */
            ii(0x9109, 3);    call(0x5d94, -0x3378);                    /* call 0x5d94 */
            ii(0x910c, 3);    mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x910f, 3);    mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x9112, 5);    mov(memw[ss, bp - 6], 0);                 /* mov word [bp-0x6], 0x0 */
            ii(0x9117, 3);    mov(bx, memw[ss, bp + 4]);                /* mov bx, [bp+0x4] */
            ii(0x911a, 4);    cmp(memw[ds, bx + 2], 0);                 /* cmp word [bx+0x2], 0x0 */
            ii(0x911e, 2);    if(jz(0x9137, 0x17)) goto l_0x9137;       /* jz 0x9137 */
            ii(0x9120, 3);    cmp(memb[ds, bx], 0x4d);                  /* cmp byte [bx], 0x4d */
            ii(0x9123, 2);    if(jnz(0x912a, 5)) goto l_0x912a;         /* jnz 0x912a */
            ii(0x9125, 5);    mov(memw[ss, bp - 6], 0x200);             /* mov word [bp-0x6], 0x200 */
        l_0x912a:
            ii(0x912a, 3);    mov(ax, memw[ds, bx + 2]);                /* mov ax, [bx+0x2] */
            ii(0x912d, 3);    sub(ax, memw[ss, bp - 6]);                /* sub ax, [bp-0x6] */
            ii(0x9130, 1);    cwd();                                    /* cwd */
            ii(0x9131, 3);    add(memw[ss, bp - 4], ax);                /* add [bp-0x4], ax */
            ii(0x9134, 3);    adc(memw[ss, bp - 2], dx);                /* adc [bp-0x2], dx */
        l_0x9137:
            ii(0x9137, 3);    mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x913a, 3);    mov(dx, memw[ss, bp - 2]);                /* mov dx, [bp-0x2] */
            ii(0x913d, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x913f, 1);    pop(bp);                                  /* pop bp */
            ii(0x9140, 1);    ret();                                    /* ret */
        }
    }
}
