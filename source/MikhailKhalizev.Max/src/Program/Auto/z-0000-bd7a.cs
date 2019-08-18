using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xbd7a-b5eb8f7")]
        public void Method_0000_bd7a()
        {
            ii(0xbd7a, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0xbd7c, 3);    mov(dx, memw_a16[ds, bx + 0x2]);          /* mov dx, [bx+0x2] */
            ii(0xbd7f, 3);    mov(cx, memw_a16[ds, bx + 0x4]);          /* mov cx, [bx+0x4] */
            ii(0xbd82, 4);    mov(bx, memw_a16[ds, 0xe70]);             /* mov bx, [0xe70] */
            ii(0xbd86, 3);    mov(ax, 0x4200);                          /* mov ax, 0x4200 */
            ii(0xbd89, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xbd8b, 2);    sbb(bx, bx);                              /* sbb bx, bx */
            ii(0xbd8d, 2);    or(ax, bx);                               /* or ax, bx */
            ii(0xbd8f, 2);    or(dx, bx);                               /* or dx, bx */
            ii(0xbd91, 1);    retw(); return;                           /* ret */
        }
    }
}
