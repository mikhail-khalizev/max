using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8f9bca16-4e64-46bb-919a-451564831b93")]
        public void Method_0000_47cd()
        {
            ii(0x47cd, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x47cf, 4);    mov(ax, memw_a16[ss, bx + 0x2]);          /* mov ax, [ss:bx+0x2] */
            ii(0x47d3, 3);    add(ax, 0x10);                            /* add ax, 0x10 */
            ii(0x47d6, 2);    rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x47d8, 2);    mov(cl, 0x3);                             /* mov cl, 0x3 */
            ii(0x47da, 2);    shr(ax, cl);                              /* shr ax, cl */
            ii(0x47dc, 1);    retw(); return;                           /* ret */
        }
    }
}
