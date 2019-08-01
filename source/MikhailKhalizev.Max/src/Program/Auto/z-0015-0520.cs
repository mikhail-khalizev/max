using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("28daa3b9-973e-4d07-ae80-d1f309b6b0b6")]
        public void Method_0015_0520()
        {
            ii(0x15_0520, 1); pushw(cs);                                /* push cs */
            ii(0x15_0521, 3); callw(0x15_0534, 0x10);                   /* call 0x534 */
            ii(0x15_0524, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_0526, 2); if(jzw(0x15_0533, 0xb)) goto l_0x15_0533; /* jz 0x533 */
            ii(0x15_0528, 1); pushw(ds);                                /* push ds */
            ii(0x15_0529, 3); pushw(0x1878);                            /* push 0x1878 */
            ii(0x15_052c, 1); nop();                                    /* nop */
            ii(0x15_052d, 1); pushw(cs);                                /* push cs */
            ii(0x15_052e, 3); callw(0x15_4f5a, 0x4a29);                 /* call 0x4f5a */
            ii(0x15_0531, 1); popw(bx);                                 /* pop bx */
            ii(0x15_0532, 1); popw(bx);                                 /* pop bx */
        l_0x15_0533:
            ii(0x15_0533, 1); retfw(); return;                          /* retf */
        }
    }
}
