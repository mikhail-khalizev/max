using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("826b1812-ae7e-45d6-a2b0-bde6e2ad40c8")]
        public void Method_0015_6183()
        {
            ii(0x15_6183, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x15_6187, 1); pushw(di);                                /* push di */
            ii(0x15_6188, 1); pushw(si);                                /* push si */
            ii(0x15_6189, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x15_618e, 3); jmpw(0x15_6194, 0x3); goto l_0x15_6194;   /* jmp 0x6194 */
        l_0x15_6191:
            ii(0x15_6191, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x15_6194:
            ii(0x15_6194, 4); cmp(memw_a16[ss, bp - 0x2], 0x1);         /* cmp word [bp-0x2], 0x1 */
            ii(0x15_6198, 2); if(jlw(0x15_619d, 0x3)) goto l_0x15_619d; /* jl 0x619d */
            ii(0x15_619a, 3); jmpw(0x15_61b7, 0x1a); goto l_0x15_61b7;  /* jmp 0x61b7 */
        l_0x15_619d:
            ii(0x15_619d, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x15_61a0, 4); mov(al, memb_a16[ds, bx + 0x12f2]);       /* mov al, [bx+0x12f2] */
            ii(0x15_61a4, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_61a6, 3); cmp(ax, memw_a16[ss, bp + 0x6]);          /* cmp ax, [bp+0x6] */
            ii(0x15_61a9, 2); if(jzw(0x15_61ae, 0x3)) goto l_0x15_61ae; /* jz 0x61ae */
            ii(0x15_61ab, 3); jmpw(0x15_61b4, 0x6); goto l_0x15_61b4;   /* jmp 0x61b4 */
        l_0x15_61ae:
            ii(0x15_61ae, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_61b1, 3); jmpw(0x15_61bd, 0x9); goto l_0x15_61bd;   /* jmp 0x61bd */
        l_0x15_61b4:
            ii(0x15_61b4, 3); jmpw(0x15_6191, -0x26); goto l_0x15_6191; /* jmp 0x6191 */
        l_0x15_61b7:
            ii(0x15_61b7, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_61ba, 3); jmpw(0x15_61bd, 0); goto l_0x15_61bd;     /* jmp 0x61bd */
        l_0x15_61bd:
            ii(0x15_61bd, 1); popw(si);                                 /* pop si */
            ii(0x15_61be, 1); popw(di);                                 /* pop di */
            ii(0x15_61bf, 1); leavew();                                 /* leave */
            ii(0x15_61c0, 1); retfw(); return;                          /* retf */
        }
    }
}
