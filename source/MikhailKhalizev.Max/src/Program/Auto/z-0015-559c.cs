using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("278f6f29-aee0-454b-b600-1d4d8acdf705")]
        public void Method_0015_559c()
        {
            ii(0x15_559c, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x15_55a0, 1); pushw(di);                                /* push di */
            ii(0x15_55a1, 1); pushw(si);                                /* push si */
            ii(0x15_55a2, 5); callw_far_abs(0x80, 0x51a8);              /* call word 0x80:0x51a8 */
            ii(0x15_55a7, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_55aa, 2); if(jnzw(0x15_55af, 0x3)) goto l_0x15_55af; /* jnz 0x55af */
            ii(0x15_55ac, 3); jmpw(0x15_55b2, 0x3); goto l_0x15_55b2;   /* jmp 0x55b2 */
        l_0x15_55af:
            ii(0x15_55af, 3); jmpw(0x15_55d7, 0x25); goto l_0x15_55d7;  /* jmp 0x55d7 */
        l_0x15_55b2:
            ii(0x15_55b2, 4); mov(es, memw_a16[ds, 0x3f88]);            /* mov es, [0x3f88] */
            ii(0x15_55b6, 4); mov(ax, memw_a16[es, 0x3b74]);            /* mov ax, [es:0x3b74] */
            ii(0x15_55ba, 5); mov(memw_a16[ss, bp - 0x4], 0);           /* mov word [bp-0x4], 0x0 */
            ii(0x15_55bf, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x15_55c2, 3); pushw(0x780);                             /* push 0x780 */
            ii(0x15_55c5, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_55c8, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_55cb, 1); pushw(ds);                                /* push ds */
            ii(0x15_55cc, 3); pushw(0x40f0);                            /* push 0x40f0 */
            ii(0x15_55cf, 1); nop();                                    /* nop */
            ii(0x15_55d0, 1); pushw(cs);                                /* push cs */
            ii(0x15_55d1, 3); callw(0x15_0f5f, -0x4675);                /* call 0xf5f */
            ii(0x15_55d4, 3); add(sp, 0xa);                             /* add sp, 0xa */
        l_0x15_55d7:
            ii(0x15_55d7, 1); popw(si);                                 /* pop si */
            ii(0x15_55d8, 1); popw(di);                                 /* pop di */
            ii(0x15_55d9, 1); leavew();                                 /* leave */
            ii(0x15_55da, 1); retw(); return;                           /* ret */
        }
    }
}
