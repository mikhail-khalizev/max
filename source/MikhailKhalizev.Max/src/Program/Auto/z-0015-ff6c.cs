using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("50afb80a-c987-4a60-a15c-8d6b9ffbb015")]
        public void Method_0015_ff6c()
        {
            ii(0x15_ff6c, 1); pushw(bp);                                /* push bp */
            ii(0x15_ff6d, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_ff6f, 1); pushw(ds);                                /* push ds */
            ii(0x15_ff70, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_ff73, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_ff75, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_ff78, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_ff7b, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_ff7e, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_ff81, 5); callw_far_abs(0x80, 0x4544);              /* call word 0x80:0x4544 */
            ii(0x15_ff86, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_ff89, 1); popw(ds);                                 /* pop ds */
            ii(0x15_ff8a, 1); leavew();                                 /* leave */
            ii(0x15_ff8b, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}
