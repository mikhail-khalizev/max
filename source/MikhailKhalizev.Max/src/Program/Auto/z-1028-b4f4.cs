using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1028_b4f4-a7708f2c")]
        public void Method_1028_b4f4()
        {
            ii(0x1028_b4f4, 6); mov(memw[ds, 0x1388], ax);              /* mov [0x1388], ax */
            ii(0x1028_b4fa, 7); mov(memw[ds, 0x14be], dx);              /* mov [0x14be], dx */
            ii(0x1028_b501, 7); mov(memw[ds, 0x1366], cx);              /* mov [0x1366], cx */
            ii(0x1028_b508, 3); mov(ax, es);                            /* mov ax, es */
            ii(0x1028_b50b, 6); mov(memw[ds, 0x135c], ax);              /* mov [0x135c], ax */
            ii(0x1028_b511, 6); mov(memd[ds, 0x1358], edi);             /* mov [0x1358], edi */
            ii(0x1028_b517, 7); mov(memw[ds, 0x136e], gs);              /* mov [0x136e], gs */
            ii(0x1028_b51e, 5); mov(edi, 0x152e);                       /* mov edi, 0x152e */
            ii(0x1028_b523, 5); mov(esi, 0x3d0);                        /* mov esi, 0x3d0 */
            ii(0x1028_b528, 5); mov(ecx, 0x1330);                       /* mov ecx, 0x1330 */
            ii(0x1028_b52d, 1); ret();                                  /* ret */
        }
    }
}
