using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("632261bf-f5fc-4642-b53c-e9b04b9606dc")]
        public void Method_0016_1212()
        {
            ii(0x16_1212, 4); enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x16_1216, 1); pushw(ds);                                /* push ds */
            ii(0x16_1217, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x16_121a, 2); mov(ds, ax);                              /* mov ds, ax */
        l_0x16_121c:
            ii(0x16_121c, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x16_121f, 3); inc(memw_a16[ss, bp + 0x6]);              /* inc word [bp+0x6] */
            ii(0x16_1222, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x16_1225, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x16_1228, 3); inc(memw_a16[ss, bp + 0xa]);              /* inc word [bp+0xa] */
            ii(0x16_122b, 3); mov(memb_a16[es, bx], al);                /* mov [es:bx], al */
            ii(0x16_122e, 2); or(al, al);                               /* or al, al */
            ii(0x16_1230, 2); if(jnzw(0x16_121c, -0x16)) goto l_0x16_121c; /* jnz 0x121c */
            ii(0x16_1232, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x16_1235, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x16_1238, 1); popw(ds);                                 /* pop ds */
            ii(0x16_1239, 1); leavew();                                 /* leave */
            ii(0x16_123a, 3); retfw(0x8); return;                       /* retf 0x8 */
        }
    }
}
