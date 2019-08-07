using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("adf0a5fd-983f-4b03-8921-2fb04e69c9ac")]
        public void Method_0015_face()
        {
            ii(0x15_face, 1); pushw(bp);                                /* push bp */
            ii(0x15_facf, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_fad1, 1); pushw(ds);                                /* push ds */
            ii(0x15_fad2, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_fad5, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_fad7, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_fada, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_fadd, 3); callw(0x15_fa6b, -0x75);                  /* call 0xfa6b */
            ii(0x15_fae0, 1); popw(ds);                                 /* pop ds */
            ii(0x15_fae1, 1); leavew();                                 /* leave */
            ii(0x15_fae2, 3); retfw(0x4); return;                       /* retf 0x4 */
        }
    }
}
