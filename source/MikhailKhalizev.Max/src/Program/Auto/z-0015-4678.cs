using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e3f38539-8880-4901-8c30-b94013397a18")]
        public void Method_0015_4678()
        {
            ii(0x15_4678, 4); enterw(0x18, 0);                          /* enter 0x18, 0x0 */
            ii(0x15_467c, 1); pushw(ds);                                /* push ds */
            ii(0x15_467d, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_4680, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_4682, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_4685, 1); dec(ax);                                  /* dec ax */
            ii(0x15_4686, 3); shr(ax, 0x4);                             /* shr ax, 0x4 */
            ii(0x15_4689, 1); inc(ax);                                  /* inc ax */
            ii(0x15_468a, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x15_468d, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_468f, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x15_4692, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x15_4695, 1); pushw(ax);                                /* push ax */
            ii(0x15_4696, 1); pushw(ax);                                /* push ax */
            ii(0x15_4697, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x15_469a, 1); pushw(ss);                                /* push ss */
            ii(0x15_469b, 1); pushw(ax);                                /* push ax */
            ii(0x15_469c, 3); pushw(0x4800);                            /* push 0x4800 */
            ii(0x15_469f, 1); nop();                                    /* nop */
            ii(0x15_46a0, 1); pushw(cs);                                /* push cs */
            ii(0x15_46a1, 3); callw(0x15_4188, -0x51c);                 /* call 0x4188 */
            ii(0x15_46a4, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x15_46a7, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_46a9, 2); if(jzw(0x15_46b1, 0x6)) goto l_0x15_46b1; /* jz 0x46b1 */
            ii(0x15_46ab, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x15_46ae, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
        l_0x15_46b1:
            ii(0x15_46b1, 3); mov(ax, memw_a16[ss, bp - 0x18]);         /* mov ax, [bp-0x18] */
            ii(0x15_46b4, 3); mov(dx, memw_a16[ss, bp - 0x16]);         /* mov dx, [bp-0x16] */
            ii(0x15_46b7, 1); popw(ds);                                 /* pop ds */
            ii(0x15_46b8, 1); leavew();                                 /* leave */
            ii(0x15_46b9, 1); retfw(); return;                          /* retf */
        }
    }
}
