using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("abbbbcde-62b9-4c20-90c0-d1bd96a7d6a4")]
        public void Method_0015_ea66()
        {
            ii(0x15_ea66, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x15_ea6a, 1); pushw(di);                                /* push di */
            ii(0x15_ea6b, 1); pushw(si);                                /* push si */
            ii(0x15_ea6c, 4); mov(es, memw_a16[ds, 0x3fd4]);            /* mov es, [0x3fd4] */
            ii(0x15_ea70, 4); mov(ax, memw_a16[es, 0xd8e]);             /* mov ax, [es:0xd8e] */
            ii(0x15_ea74, 5); or(ax, memw_a16[es, 0xd8c]);              /* or ax, [es:0xd8c] */
            ii(0x15_ea79, 2); if(jnzw(0x15_ea7e, 0x3)) goto l_0x15_ea7e; /* jnz 0xea7e */
            ii(0x15_ea7b, 3); jmpw(0x15_eabd, 0x3f); goto l_0x15_eabd;  /* jmp 0xeabd */
        l_0x15_ea7e:
            ii(0x15_ea7e, 1); pushw(ds);                                /* push ds */
            ii(0x15_ea7f, 3); pushw(0x2d9a);                            /* push 0x2d9a */
            ii(0x15_ea82, 5); callw_far_abs(0x80, 0x2289);              /* call word 0x80:0x2289 */
            ii(0x15_ea87, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_ea8a, 4); mov(es, memw_a16[ds, 0x3fd4]);            /* mov es, [0x3fd4] */
            ii(0x15_ea8e, 5); callw_a16_far_ind(es, 0xd8c);             /* call far word [es:0xd8c] */
            ii(0x15_ea93, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_ea96, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_ea99, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_ea9b, 2); if(jnzw(0x15_eaa0, 0x3)) goto l_0x15_eaa0; /* jnz 0xeaa0 */
            ii(0x15_ea9d, 3); jmpw(0x15_eab8, 0x18); goto l_0x15_eab8;  /* jmp 0xeab8 */
        l_0x15_eaa0:
            ii(0x15_eaa0, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_eaa3, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_eaa6, 1); pushw(ds);                                /* push ds */
            ii(0x15_eaa7, 3); pushw(0x2da4);                            /* push 0x2da4 */
            ii(0x15_eaaa, 3); pushw(0x3f3);                             /* push 0x3f3 */
            ii(0x15_eaad, 5); callw_far_abs(0x80, 0x216e);              /* call word 0x80:0x216e */
            ii(0x15_eab2, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x15_eab5, 3); jmpw(0x15_eabd, 0x5); goto l_0x15_eabd;   /* jmp 0xeabd */
        l_0x15_eab8:
            ii(0x15_eab8, 5); mov(memb_a16[ds, 0xd8a], 0x1);            /* mov byte [0xd8a], 0x1 */
        l_0x15_eabd:
            ii(0x15_eabd, 1); popw(si);                                 /* pop si */
            ii(0x15_eabe, 1); popw(di);                                 /* pop di */
            ii(0x15_eabf, 1); leavew();                                 /* leave */
            ii(0x15_eac0, 1); retfw(); return;                          /* retf */
        }
    }
}
