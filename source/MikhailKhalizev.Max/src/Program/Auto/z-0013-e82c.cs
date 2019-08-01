using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("041e760e-cb60-4c71-8330-737563440b17")]
        public void Method_0013_e82c()
        {
            ii(0x13_e82c, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x13_e830, 1); pushw(ds);                                /* push ds */
            ii(0x13_e831, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_e834, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_e836, 5); mov(memw_a16[ss, bp - 0x6], 0x100);       /* mov word [bp-0x6], 0x100 */
            ii(0x13_e83b, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_e83d, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_e83f, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x13_e842, 1); pushw(ss);                                /* push ss */
            ii(0x13_e843, 1); pushw(ax);                                /* push ax */
            ii(0x13_e844, 2); pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0x13_e846, 1); nop();                                    /* nop */
            ii(0x13_e847, 1); pushw(cs);                                /* push cs */
            ii(0x13_e848, 3); callw(0x13_eb40, 0x2f5);                  /* call 0xeb40 */
            ii(0x13_e84b, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x13_e84e, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x13_e851, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_e853, 3); add(ax, memw_a16[ss, bp - 0x2]);          /* add ax, [bp-0x2] */
            ii(0x13_e856, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x13_e859, 2); mov(cl, 0x4);                             /* mov cl, 0x4 */
        l_0x13_e85b:
            ii(0x13_e85b, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_e85d, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_e85f, 2); dec(cl);                                  /* dec cl */
            ii(0x13_e861, 2); if(jnzw(0x13_e85b, -0x8)) goto l_0x13_e85b; /* jnz 0xe85b */
            ii(0x13_e863, 1); popw(ds);                                 /* pop ds */
            ii(0x13_e864, 1); leavew();                                 /* leave */
            ii(0x13_e865, 1); retfw(); return;                          /* retf */
        }
    }
}
