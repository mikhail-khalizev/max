using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2a5f5cb8-cc3a-4e8c-944f-ec268c80a44b")]
        public void Method_0000_90f9()
        {
            ii(0x90f9, 1);    pushw(bp);                                /* push bp */
            ii(0x90fa, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x90fc, 3);    sub(sp, 0x6);                             /* sub sp, 0x6 */
            ii(0x90ff, 3);    mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x9102, 3);    mov(ax, memw_a16[ds, bx + 0x4]);          /* mov ax, [bx+0x4] */
            ii(0x9105, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x9107, 2);    mov(cl, 0x9);                             /* mov cl, 0x9 */
            ii(0x9109, 3);    callw(0x5d94, -0x3378);                   /* call 0x5d94 */
            ii(0x910c, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x910f, 3);    mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x9112, 5);    mov(memw_a16[ss, bp - 0x6], 0);           /* mov word [bp-0x6], 0x0 */
            ii(0x9117, 3);    mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x911a, 4);    cmp(memw_a16[ds, bx + 0x2], 0);           /* cmp word [bx+0x2], 0x0 */
            ii(0x911e, 2);    if(jzw(0x9137, 0x17)) goto l_0x9137;      /* jz 0x9137 */
            ii(0x9120, 3);    cmp(memb_a16[ds, bx], 0x4d);              /* cmp byte [bx], 0x4d */
            ii(0x9123, 2);    if(jnzw(0x912a, 0x5)) goto l_0x912a;      /* jnz 0x912a */
            ii(0x9125, 5);    mov(memw_a16[ss, bp - 0x6], 0x200);       /* mov word [bp-0x6], 0x200 */
        l_0x912a:
            ii(0x912a, 3);    mov(ax, memw_a16[ds, bx + 0x2]);          /* mov ax, [bx+0x2] */
            ii(0x912d, 3);    sub(ax, memw_a16[ss, bp - 0x6]);          /* sub ax, [bp-0x6] */
            ii(0x9130, 1);    cwd();                                    /* cwd */
            ii(0x9131, 3);    add(memw_a16[ss, bp - 0x4], ax);          /* add [bp-0x4], ax */
            ii(0x9134, 3);    adc(memw_a16[ss, bp - 0x2], dx);          /* adc [bp-0x2], dx */
        l_0x9137:
            ii(0x9137, 3);    mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x913a, 3);    mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x913d, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x913f, 1);    popw(bp);                                 /* pop bp */
            ii(0x9140, 1);    retw(); return;                           /* ret */
        }
    }
}
