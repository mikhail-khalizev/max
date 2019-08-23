using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_6183-f81d7cab")]
        public void Method_0019_6183()
        {
            ii(0x19_6183, 4); enter(0x2, 0);                            /* enter 0x2, 0x0 */
            ii(0x19_6187, 1); push(di);                                 /* push di */
            ii(0x19_6188, 1); push(si);                                 /* push si */
            ii(0x19_6189, 5); mov(memw[ss, bp - 0x2], 0);               /* mov word [bp-0x2], 0x0 */
            ii(0x19_618e, 3); jmp(0x19_6194, 0x3); goto l_0x19_6194;    /* jmp 0x6194 */
        l_0x19_6191:
            ii(0x19_6191, 3); inc(memw[ss, bp - 0x2]);                  /* inc word [bp-0x2] */
        l_0x19_6194:
            ii(0x19_6194, 4); cmp(memw[ss, bp - 0x2], 0x1);             /* cmp word [bp-0x2], 0x1 */
            ii(0x19_6198, 2); if(jl(0x19_619d, 0x3)) goto l_0x19_619d;  /* jl 0x619d */
            ii(0x19_619a, 3); jmp(0x19_61b7, 0x1a); goto l_0x19_61b7;   /* jmp 0x61b7 */
        l_0x19_619d:
            ii(0x19_619d, 3); mov(bx, memw[ss, bp - 0x2]);              /* mov bx, [bp-0x2] */
            ii(0x19_61a0, 4); mov(al, memb[ds, bx + 0x12f2]);           /* mov al, [bx+0x12f2] */
            ii(0x19_61a4, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x19_61a6, 3); cmp(ax, memw[ss, bp + 0x6]);              /* cmp ax, [bp+0x6] */
            ii(0x19_61a9, 2); if(jz(0x19_61ae, 0x3)) goto l_0x19_61ae;  /* jz 0x61ae */
            ii(0x19_61ab, 3); jmp(0x19_61b4, 0x6); goto l_0x19_61b4;    /* jmp 0x61b4 */
        l_0x19_61ae:
            ii(0x19_61ae, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_61b1, 3); jmp(0x19_61bd, 0x9); goto l_0x19_61bd;    /* jmp 0x61bd */
        l_0x19_61b4:
            ii(0x19_61b4, 3); jmp(0x19_6191, -0x26); goto l_0x19_6191;  /* jmp 0x6191 */
        l_0x19_61b7:
            ii(0x19_61b7, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_61ba, 3); jmp(0x19_61bd, 0); goto l_0x19_61bd;      /* jmp 0x61bd */
        l_0x19_61bd:
            ii(0x19_61bd, 1); pop(si);                                  /* pop si */
            ii(0x19_61be, 1); pop(di);                                  /* pop di */
            ii(0x19_61bf, 1); leave();                                  /* leave */
            ii(0x19_61c0, 1); retf();                                   /* retf */
        }
    }
}
