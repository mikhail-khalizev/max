using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1028_95e8-523496e2")]
        public void Method_1028_95e8()
        {
            ii(0x1028_95e8, 2); pushw(ax);                              /* push ax */
            ii(0x1028_95ea, 2); pushw(dx);                              /* push dx */
            ii(0x1028_95ec, 7); mov(dx, memw_a32[ds, 0x135]);           /* mov dx, [0x135] */
            ii(0x1028_95f3, 4); add(dx, 0xc);                           /* add dx, 0xc */
        l_0x1028_95f7:
            ii(0x1028_95f7, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1028_95f8, 2); and(al, 0x80);                          /* and al, 0x80 */
            ii(0x1028_95fa, 2); if(jnzd(0x1028_95f7, -0x5)) goto l_0x1028_95f7; /* jnz 0x102895f7 */
            ii(0x1028_95fc, 2); popw(dx);                               /* pop dx */
            ii(0x1028_95fe, 2); popw(ax);                               /* pop ax */
            ii(0x1028_9600, 1); retd(); return;                         /* ret */
        }
    }
}
