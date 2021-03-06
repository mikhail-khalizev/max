using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a54d-391bf3cd")]
        public void Method_0018_a54d()
        {
            ii(0x18_a54d, 3);  mov(memw[ss, bp + 18], ds);             /* mov [bp+0x12], ds */
            ii(0x18_a550, 5);  mov(memw[ss, bp + 22], 0x98);           /* mov word [bp+0x16], 0x98 */
            ii(0x18_a555, 3);  mov(ax, memw[ds, 0x11f4]);              /* mov ax, [0x11f4] */
            ii(0x18_a558, 3);  mov(memw[ss, bp + 16], ax);             /* mov [bp+0x10], ax */
            ii(0x18_a55b, 3);  mov(ax, memw[ds, 0x11f6]);              /* mov ax, [0x11f6] */
            ii(0x18_a55e, 3);  mov(memw[ss, bp + 20], ax);             /* mov [bp+0x14], ax */
            ii(0x18_a561, 5);  mov(memw[ss, bp + 10], 0xc10);          /* mov word [bp+0xa], 0xc10 */
            ii(0x18_a566, 5);  mov(memw[ss, bp + 8], 0x4229);          /* mov word [bp+0x8], 0x4229 */
            ii(0x18_a56b, 3);  jmp_func(0x18_a838, 0x2ca);             /* jmp 0xa838 */
        }
    }
}
