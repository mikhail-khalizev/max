using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("257ea4f2-f926-440e-932d-a0ab79483ae7")]
        public void Method_0019_84c5()
        {
            ii(0x19_84c5, 4); enterw(0x1c, 0);                          /* enter 0x1c, 0x0 */
            ii(0x19_84c9, 1); pushw(di);                                /* push di */
            ii(0x19_84ca, 1); pushw(si);                                /* push si */
            ii(0x19_84cb, 1); pushw(ds);                                /* push ds */
            ii(0x19_84cc, 3); pushw(0x174a);                            /* push 0x174a */
            ii(0x19_84cf, 3); callw(0x19_105e, -0x7474);                /* call 0x105e */
            ii(0x19_84d2, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_84d5, 4); cmp(memw_a16[ss, bp + 0xc], 0x1);         /* cmp word [bp+0xc], 0x1 */
            ii(0x19_84d9, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x19_84db, 3); and(ax, 0xfffb);                          /* and ax, 0xfffb */
            ii(0x19_84de, 3); add(ax, 0x6);                             /* add ax, 0x6 */
            ii(0x19_84e1, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x19_84e4, 3); jmpw(0x19_84ea, 0x3); goto l_0x19_84ea;   /* jmp 0x84ea */
        l_0x19_84e7:
            ii(0x19_84e7, 3); dec(memw_a16[ss, bp - 0x2]);              /* dec word [bp-0x2] */
        l_0x19_84ea:
            ii(0x19_84ea, 4); cmp(memw_a16[ss, bp - 0x2], 0);           /* cmp word [bp-0x2], 0x0 */
            ii(0x19_84ee, 2); if(jgw(0x19_84f3, 0x3)) goto l_0x19_84f3; /* jg 0x84f3 */
            ii(0x19_84f0, 3); jmpw(0x19_855c, 0x69); goto l_0x19_855c;  /* jmp 0x855c */
        l_0x19_84f3:
            ii(0x19_84f3, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_84f6, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_84f9, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_84fc, 1); pushw(ds);                                /* push ds */
            ii(0x19_84fd, 3); pushw(0x1752);                            /* push 0x1752 */
            ii(0x19_8500, 3); callw(0x19_105e, -0x74a5);                /* call 0x105e */
            ii(0x19_8503, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_8506, 2); pushw(0x18);                              /* push 0x18 */
            ii(0x19_8508, 3); lea(ax, bp - 0x1c);                       /* lea ax, [bp-0x1c] */
            ii(0x19_850b, 1); pushw(ss);                                /* push ss */
            ii(0x19_850c, 1); pushw(ax);                                /* push ax */
            ii(0x19_850d, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_8510, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_8513, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_8516, 5); callw_far_abs(0x80, 0x1534);              /* call word 0x80:0x1534 */
            ii(0x19_851b, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x19_851e, 4); add(memw_a16[ss, bp + 0x8], 0x18);        /* add word [bp+0x8], 0x18 */
            ii(0x19_8522, 4); adc(memw_a16[ss, bp + 0xa], 0);           /* adc word [bp+0xa], 0x0 */
            ii(0x19_8526, 5); mov(memw_a16[ss, bp - 0x4], 0);           /* mov word [bp-0x4], 0x0 */
            ii(0x19_852b, 3); jmpw(0x19_8531, 0x3); goto l_0x19_8531;   /* jmp 0x8531 */
        l_0x19_852e:
            ii(0x19_852e, 3); inc(memw_a16[ss, bp - 0x4]);              /* inc word [bp-0x4] */
        l_0x19_8531:
            ii(0x19_8531, 4); cmp(memw_a16[ss, bp - 0x4], 0xc);         /* cmp word [bp-0x4], 0xc */
            ii(0x19_8535, 2); if(jlw(0x19_853a, 0x3)) goto l_0x19_853a; /* jl 0x853a */
            ii(0x19_8537, 3); jmpw(0x19_854f, 0x15); goto l_0x19_854f;  /* jmp 0x854f */
        l_0x19_853a:
            ii(0x19_853a, 3); mov(si, memw_a16[ss, bp - 0x4]);          /* mov si, [bp-0x4] */
            ii(0x19_853d, 2); shl(si, 0x1);                             /* shl si, 1 */
            ii(0x19_853f, 3); pushw(memw_a16[ss, bp + si - 0x1c]);      /* push word [bp+si-0x1c] */
            ii(0x19_8542, 1); pushw(ds);                                /* push ds */
            ii(0x19_8543, 3); pushw(0x175f);                            /* push 0x175f */
            ii(0x19_8546, 3); callw(0x19_105e, -0x74eb);                /* call 0x105e */
            ii(0x19_8549, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_854c, 3); jmpw(0x19_852e, -0x21); goto l_0x19_852e; /* jmp 0x852e */
        l_0x19_854f:
            ii(0x19_854f, 1); pushw(ds);                                /* push ds */
            ii(0x19_8550, 3); pushw(0x1765);                            /* push 0x1765 */
            ii(0x19_8553, 3); callw(0x19_105e, -0x74f8);                /* call 0x105e */
            ii(0x19_8556, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_8559, 3); jmpw(0x19_84e7, -0x75); goto l_0x19_84e7; /* jmp 0x84e7 */
        l_0x19_855c:
            ii(0x19_855c, 1); popw(si);                                 /* pop si */
            ii(0x19_855d, 1); popw(di);                                 /* pop di */
            ii(0x19_855e, 1); leavew();                                 /* leave */
            ii(0x19_855f, 1); retfw(); return;                          /* retf */
        }
    }
}
