using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x65fb-dcb27775")]
        public void Method_0000_65fb()
        {
            ii(0x65fb, 4);    enterw(0x6, 0);                           /* enter 0x6, 0x0 */
            ii(0x65ff, 3);    mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x6602, 3);    mov(ax, memw_a16[ds, bx + 0x4]);          /* mov ax, [bx+0x4] */
            ii(0x6605, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x6607, 2);    mov(cl, 0x9);                             /* mov cl, 0x9 */
            ii(0x6609, 3);    callw(0x5d94, -0x878);                    /* call 0x5d94 */
            ii(0x660c, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x660f, 3);    mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x6612, 5);    mov(memw_a16[ss, bp - 0x6], 0);           /* mov word [bp-0x6], 0x0 */
            ii(0x6617, 3);    mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x661a, 4);    cmp(memw_a16[ds, bx + 0x2], 0);           /* cmp word [bx+0x2], 0x0 */
            ii(0x661e, 2);    if(jzw(0x6637, 0x17)) goto l_0x6637;      /* jz 0x6637 */
            ii(0x6620, 3);    cmp(memb_a16[ds, bx], 0x4d);              /* cmp byte [bx], 0x4d */
            ii(0x6623, 2);    if(jnzw(0x662a, 0x5)) goto l_0x662a;      /* jnz 0x662a */
            ii(0x6625, 5);    mov(memw_a16[ss, bp - 0x6], 0x200);       /* mov word [bp-0x6], 0x200 */
        l_0x662a:
            ii(0x662a, 3);    mov(ax, memw_a16[ds, bx + 0x2]);          /* mov ax, [bx+0x2] */
            ii(0x662d, 3);    sub(ax, memw_a16[ss, bp - 0x6]);          /* sub ax, [bp-0x6] */
            ii(0x6630, 1);    cwd();                                    /* cwd */
            ii(0x6631, 3);    add(memw_a16[ss, bp - 0x4], ax);          /* add [bp-0x4], ax */
            ii(0x6634, 3);    adc(memw_a16[ss, bp - 0x2], dx);          /* adc [bp-0x2], dx */
        l_0x6637:
            ii(0x6637, 3);    mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x663a, 3);    mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x663d, 1);    leavew();                                 /* leave */
            ii(0x663e, 1);    retw(); return;                           /* ret */
        }
    }
}
