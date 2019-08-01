using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("16d28ef8-419a-4bac-9e38-84b6093db58a")]
        public void Method_0013_8018()
        {
            ii(0x13_8018, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x13_801c, 1); pushw(ds);                                /* push ds */
            ii(0x13_801d, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_8020, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_8022, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x13_8027, 4); mov(es, memw_a16[ds, 0x1dca]);            /* mov es, [0x1dca] */
            ii(0x13_802b, 6); cmp(memb_a16[es, 0x2e], 0);               /* cmp byte [es:0x2e], 0x0 */
            ii(0x13_8031, 2); if(jzw(0x13_804d, 0x1a)) goto l_0x13_804d; /* jz 0x804d */
            ii(0x13_8033, 1); nop();                                    /* nop */
            ii(0x13_8034, 1); pushw(cs);                                /* push cs */
            ii(0x13_8035, 3); callw(0x13_6d68, -0x12d0);                /* call 0x6d68 */
            ii(0x13_8038, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_803a, 2); if(jnzw(0x13_804d, 0x11)) goto l_0x13_804d; /* jnz 0x804d */
            ii(0x13_803c, 1); pushw(ds);                                /* push ds */
            ii(0x13_803d, 3); pushw(0xa0c);                             /* push 0xa0c */
            ii(0x13_8040, 1); nop();                                    /* nop */
            ii(0x13_8041, 1); pushw(cs);                                /* push cs */
            ii(0x13_8042, 3); callw(0x13_ed1a, 0x6cd5);                 /* call 0xed1a */
            ii(0x13_8045, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_8048, 5); mov(memw_a16[ss, bp - 0x2], 0x1);         /* mov word [bp-0x2], 0x1 */
        l_0x13_804d:
            ii(0x13_804d, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_8050, 1); nop();                                    /* nop */
            ii(0x13_8051, 1); pushw(cs);                                /* push cs */
            ii(0x13_8052, 3); callw(0x13_ee52, 0x6dfd);                 /* call 0xee52 */
            ii(0x13_8055, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_8058, 1); popw(ds);                                 /* pop ds */
            ii(0x13_8059, 1); leavew();                                 /* leave */
            ii(0x13_805a, 1); retfw(); return;                          /* retf */
        }
    }
}
