using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9840-7d4187a1")]
        public void Method_0000_9840()
        {
            ii(0x9840, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x9842, 3);    mov(bx, memw[ds, bx + 0x2]);              /* mov bx, [bx+0x2] */
            ii(0x9845, 4);    mov(memw[ds, 0x9ba], bx);                 /* mov [0x9ba], bx */
            ii(0x9849, 5);    cmp(memb[ds, 0x2f], 0x3);                 /* cmp byte [0x2f], 0x3 */
            ii(0x984e, 2);    if(jb(0x9860, 0x10)) goto l_0x9860;       /* jb 0x9860 */
            ii(0x9850, 6);    mov(memb[cs, 0x31f], 0x66);               /* mov byte [cs:0x31f], 0x66 */
            ii(0x9856, 5);    cmp(memb[ds, 0x2e], 0x2);                 /* cmp byte [0x2e], 0x2 */
            ii(0x985b, 2);    if(jnz(0x9860, 0x3)) goto l_0x9860;       /* jnz 0x9860 */
            ii(0x985d, 3);    mov(bx, 0x2824);                          /* mov bx, 0x2824 */
        l_0x9860:
            ii(0x9860, 4);    mov(ax, memw[cs, bx - 0x4]);              /* mov ax, [cs:bx-0x4] */
            ii(0x9864, 3);    mov(memw[ds, 0x9bc], ax);                 /* mov [0x9bc], ax */
            ii(0x9867, 4);    mov(ax, memw[cs, bx - 0x2]);              /* mov ax, [cs:bx-0x2] */
            ii(0x986b, 3);    mov(memw[ds, 0x9be], ax);                 /* mov [0x9be], ax */
            ii(0x986e, 1);    ret();                                    /* ret */
        }
    }
}
