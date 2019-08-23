using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_cd74-729978de")]
        public void Method_0019_cd74()
        {
            ii(0x19_cd74, 1); push(bp);                                 /* push bp */
            ii(0x19_cd75, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_cd77, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x19_cd7a, 5); test(memb[es, bx + 0x9], 0x10);           /* test byte [es:bx+0x9], 0x10 */
            ii(0x19_cd7f, 2); if(jz(0x19_cd8b, 0xa)) goto l_0x19_cd8b;  /* jz 0xcd8b */
            ii(0x19_cd81, 4); mov(ax, memw[es, bx + 0x4]);              /* mov ax, [es:bx+0x4] */
            ii(0x19_cd85, 4); mov(dx, memw[es, bx + 0x6]);              /* mov dx, [es:bx+0x6] */
            ii(0x19_cd89, 2); jmp(0x19_cd9b, 0x10); goto l_0x19_cd9b;   /* jmp 0xcd9b */
        l_0x19_cd8b:
            ii(0x19_cd8b, 4); mov(ax, memw[es, bx + 0x4]);              /* mov ax, [es:bx+0x4] */
            ii(0x19_cd8f, 4); mov(dx, memw[es, bx + 0x6]);              /* mov dx, [es:bx+0x6] */
            ii(0x19_cd93, 4); sub(ax, memw[ds, 0x19ea]);                /* sub ax, [0x19ea] */
            ii(0x19_cd97, 4); sbb(dx, memw[ds, 0x19ec]);                /* sbb dx, [0x19ec] */
        l_0x19_cd9b:
            ii(0x19_cd9b, 1); leave();                                  /* leave */
            ii(0x19_cd9c, 3); ret(0x4);                                 /* ret 0x4 */
        }
    }
}
