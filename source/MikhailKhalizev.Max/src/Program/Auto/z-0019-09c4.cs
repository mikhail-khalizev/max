using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_09c4-eb09560d")]
        public void Method_0019_09c4()
        {
            ii(0x19_09c4, 4); enter(0, 0);                              /* enter 0x0, 0x0 */
            ii(0x19_09c8, 1); push(es);                                 /* push es */
            ii(0x19_09c9, 1); push(ds);                                 /* push ds */
            ii(0x19_09ca, 2); pushd(esi);                               /* push esi */
            ii(0x19_09cc, 2); pushd(edi);                               /* push edi */
            ii(0x19_09ce, 2); pushd(ecx);                               /* push ecx */
            ii(0x19_09d0, 4); mov(esi, memd[ss, bp + 0x6]);             /* mov esi, [bp+0x6] */
            ii(0x19_09d4, 3); mov(ds, memw[ss, bp + 0xa]);              /* mov ds, [bp+0xa] */
            ii(0x19_09d7, 3); les(di, ss, bp + 0xc);                    /* les di, [bp+0xc] */
            ii(0x19_09da, 4); movzx(edi, di);                           /* movzx edi, di */
            ii(0x19_09de, 3); mov(cx, memw[ss, bp + 0x10]);             /* mov cx, [bp+0x10] */
            ii(0x19_09e1, 2); if(jcxz(0x19_09ec, 0x9)) goto l_0x19_09ec; /* jcxz 0x9ec */
            ii(0x19_09e3, 4); movzx(ecx, cx);                           /* movzx ecx, cx */
            ii(0x19_09e7, 3); rep_a32(() => movsb_a32());               /* a32 rep movsb */
            ii(0x19_09ea, 2); nop();                                    /* a32 nop */
        l_0x19_09ec:
            ii(0x19_09ec, 2); popd(ecx);                                /* pop ecx */
            ii(0x19_09ee, 2); popd(edi);                                /* pop edi */
            ii(0x19_09f0, 2); popd(esi);                                /* pop esi */
            ii(0x19_09f2, 1); pop(ds);                                  /* pop ds */
            ii(0x19_09f3, 1); pop(es);                                  /* pop es */
            ii(0x19_09f4, 1); leave();                                  /* leave */
            ii(0x19_09f5, 1); retf();                                   /* retf */
        }
    }
}
