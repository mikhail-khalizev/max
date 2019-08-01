using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0d20faa7-8837-4b4c-bca0-9a69d7bc8119")]
        public void Method_0013_f719()
        {
            ii(0x13_f719, 1); pushw(bp);                                /* push bp */
            ii(0x13_f71a, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_f71c, 1); pushw(ds);                                /* push ds */
            ii(0x13_f71d, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_f720, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_f722, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x13_f725, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_f728, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_f72b, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x13_f72e, 1); nop();                                    /* nop */
            ii(0x13_f72f, 1); pushw(cs);                                /* push cs */
            ii(0x13_f730, 3); callw(0x14_0a10, 0x12dd);                 /* call 0xa10 */
            ii(0x13_f733, 1); popw(ds);                                 /* pop ds */
            ii(0x13_f734, 1); leavew();                                 /* leave */
            ii(0x13_f735, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}
