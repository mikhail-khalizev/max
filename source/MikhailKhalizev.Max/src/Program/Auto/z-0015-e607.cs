using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("de400dbd-96cd-48b5-877a-9877930b2bd4")]
        public void Method_0015_e607()
        {
            ii(0x15_e607, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x15_e60b, 1); pushw(di);                                /* push di */
            ii(0x15_e60c, 1); pushw(si);                                /* push si */
            ii(0x15_e60d, 1); pushw(ds);                                /* push ds */
            ii(0x15_e60e, 3); pushw(0x48b6);                            /* push 0x48b6 */
            ii(0x15_e611, 3); callw(0x15_ff2f, 0x191b);                 /* call 0xff2f */
            ii(0x15_e614, 4); cmp(ax, memw_a16[ds, 0x48f6]);            /* cmp ax, [0x48f6] */
            ii(0x15_e618, 2); if(jzw(0x15_e61d, 0x3)) goto l_0x15_e61d; /* jz 0xe61d */
            ii(0x15_e61a, 3); jmpw(0x15_e62b, 0xe); goto l_0x15_e62b;   /* jmp 0xe62b */
        l_0x15_e61d:
            ii(0x15_e61d, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_e620, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_e623, 1); nop();                                    /* nop */
            ii(0x15_e624, 1); pushw(cs);                                /* push cs */
            ii(0x15_e625, 3); callw(0x15_e5ec, -0x3c);                  /* call 0xe5ec */
            ii(0x15_e628, 3); add(sp, 0x4);                             /* add sp, 0x4 */
        l_0x15_e62b:
            ii(0x15_e62b, 1); popw(si);                                 /* pop si */
            ii(0x15_e62c, 1); popw(di);                                 /* pop di */
            ii(0x15_e62d, 1); leavew();                                 /* leave */
            ii(0x15_e62e, 1); retfw(); return;                          /* retf */
        }
    }
}
