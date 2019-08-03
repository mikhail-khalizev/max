using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a5392510-0159-4929-b3ed-8c68bcb27425")]
        public void Method_0000_4a28()
        {
            ii(0x4a28, 3);    mov(ax, memw_a16[ds, 0xf88]);             /* mov ax, [0xf88] */
            ii(0x4a2b, 2);    or(al, 0x1);                              /* or al, 0x1 */
            ii(0x4a2d, 3);    lmsw(ax);                                 /* lmsw ax */
            ii(0x4a30, 1);    retw(); return;                           /* ret */
        }
    }
}