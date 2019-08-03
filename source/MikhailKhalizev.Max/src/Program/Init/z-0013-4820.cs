using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f3859c2b-06e2-4005-bb25-55b541baf73e")]
        public void Method_0013_4820()
        {
            ii(0x13_4820, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x13_4824, 1); pushw(si);                                /* push si */
            ii(0x13_4825, 1); pushw(ds);                                /* push ds */
            ii(0x13_4826, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_4829, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_482b, 2); sub(si, si);                              /* sub si, si */
            ii(0x13_482d, 2); jmpw(0x13_4831, 0x2); goto l_0x13_4831;   /* jmp 0x4831 */
        //  ii(0x13_482f, 1); Недостижимый код.
l_0x13_4830:
            ii(0x13_4830, 1); inc(si);                                  /* inc si */
        l_0x13_4831:
            ii(0x13_4831, 3); cmp(si, 0x8);                             /* cmp si, 0x8 */
            ii(0x13_4834, 2); if(jgew(0x13_4856, 0x20)) goto l_0x13_4856; /* jge 0x4856 */
            ii(0x13_4836, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_4838, 2); pushw(0xb);                               /* push 0xb */
            ii(0x13_483a, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_483c, 1); nop();                                    /* nop */
            ii(0x13_483d, 1); pushw(cs);                                /* push cs */
            ii(0x13_483e, 3); callw(0x12_e96a, -0x5ed7);                /* call 0xe96a */
            ii(0x13_4841, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_4844, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_4847, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x13_484a, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x13_484c, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x13_484e, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x13_4850, 4); mov(memw_a16[ds, bx + 0x1e8e], ax);       /* mov [bx+0x1e8e], ax */
            ii(0x13_4854, 2); jmpw(0x13_4830, -0x26); goto l_0x13_4830; /* jmp 0x4830 */
        l_0x13_4856:
            ii(0x13_4856, 6); mov(memw_a16[ds, 0xd8], 0);               /* mov word [0xd8], 0x0 */
            ii(0x13_485c, 1); popw(ds);                                 /* pop ds */
            ii(0x13_485d, 1); popw(si);                                 /* pop si */
            ii(0x13_485e, 1); leavew();                                 /* leave */
            ii(0x13_485f, 1); retfw(); return;                          /* retf */
        }
    }
}
