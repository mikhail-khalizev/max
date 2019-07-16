using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("40a3304f-4569-48a1-8d47-2be4b7bb7ebf")]
        public void Method_0000_6333()
        {
            ii(0x6333, 6);    mov(memw_a16[ds, 0x11d4], 0x7);           /* mov word [0x11d4], 0x7 */
            ii(0x6339, 3);    mov(ax, 0x15);                            /* mov ax, 0x15 */
            ii(0x633c, 1);    pushw(ax);                                /* push ax */
            ii(0x633d, 3);    callw(0x589d, -0xaa3);                    /* call 0x589d */
            ii(0x6340, 1);    popw(bx);                                 /* pop bx */
            ii(0x6341, 1);    retw();                                   /* ret */
        }
    }
}
