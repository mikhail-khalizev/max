using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_ea66-ab1c54fc")]
        public void Method_0019_ea66()
        {
            ii(0x19_ea66, 4); enter(4, 0);                              /* enter 0x4, 0x0 */
            ii(0x19_ea6a, 1); push(di);                                 /* push di */
            ii(0x19_ea6b, 1); push(si);                                 /* push si */
            ii(0x19_ea6c, 4); mov(es, memw[ds, 0x3fd4]);                /* mov es, [0x3fd4] */
            ii(0x19_ea70, 4); mov(ax, memw[es, 0xd8e]);                 /* mov ax, [es:0xd8e] */
            ii(0x19_ea74, 5); or(ax, memw[es, 0xd8c]);                  /* or ax, [es:0xd8c] */
            ii(0x19_ea79, 2); if(jnz(0x19_ea7e, 3)) goto l_0x19_ea7e;   /* jnz 0xea7e */
            ii(0x19_ea7b, 3); jmp(0x19_eabd, 0x3f); goto l_0x19_eabd;   /* jmp 0xeabd */
        l_0x19_ea7e:
            ii(0x19_ea7e, 1); push(ds);                                 /* push ds */
            ii(0x19_ea7f, 3); push(0x2d9a);                             /* push 0x2d9a */
            ii(0x19_ea82, 5); call_far_abs(0x80, 0x2289);               /* call word 0x80:0x2289 */
            ii(0x19_ea87, 3); add(sp, 4);                               /* add sp, 0x4 */
            ii(0x19_ea8a, 4); mov(es, memw[ds, 0x3fd4]);                /* mov es, [0x3fd4] */
            ii(0x19_ea8e, 5); call_far_ind(memw[es, 0xd8c]);            /* call far word [es:0xd8c] */
            ii(0x19_ea93, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x19_ea96, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x19_ea99, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_ea9b, 2); if(jnz(0x19_eaa0, 3)) goto l_0x19_eaa0;   /* jnz 0xeaa0 */
            ii(0x19_ea9d, 3); jmp(0x19_eab8, 0x18); goto l_0x19_eab8;   /* jmp 0xeab8 */
        l_0x19_eaa0:
            ii(0x19_eaa0, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x19_eaa3, 3); push(memw[ss, bp - 4]);                   /* push word [bp-0x4] */
            ii(0x19_eaa6, 1); push(ds);                                 /* push ds */
            ii(0x19_eaa7, 3); push(0x2da4);                             /* push 0x2da4 */
            ii(0x19_eaaa, 3); push(0x3f3);                              /* push 0x3f3 */
            ii(0x19_eaad, 5); call_far_abs(0x80, 0x216e);               /* call word 0x80:0x216e */
            ii(0x19_eab2, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_eab5, 3); jmp(0x19_eabd, 5); goto l_0x19_eabd;      /* jmp 0xeabd */
        l_0x19_eab8:
            ii(0x19_eab8, 5); mov(memb[ds, 0xd8a], 1);                  /* mov byte [0xd8a], 0x1 */
        l_0x19_eabd:
            ii(0x19_eabd, 1); pop(si);                                  /* pop si */
            ii(0x19_eabe, 1); pop(di);                                  /* pop di */
            ii(0x19_eabf, 1); leave();                                  /* leave */
            ii(0x19_eac0, 1); retf();                                   /* retf */
        }
    }
}
