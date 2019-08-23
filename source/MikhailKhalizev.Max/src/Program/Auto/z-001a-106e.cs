using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_106e-9404ae")]
        public void Method_001a_106e()
        {
            ii(0x1a_106e, 4); enter(0x16, 0);                           /* enter 0x16, 0x0 */
            ii(0x1a_1072, 1); push(ds);                                 /* push ds */
            ii(0x1a_1073, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x1a_1076, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x1a_1078, 5); mov(memw[ss, bp - 0x14], 0);              /* mov word [bp-0x14], 0x0 */
            ii(0x1a_107d, 3); mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0x1a_1080, 3); mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0x1a_1083, 3); mov(ax, memw[ss, bp + 0x8]);              /* mov ax, [bp+0x8] */
            ii(0x1a_1086, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0x1a_1089, 3); mov(al, memb[ss, bp + 0x6]);              /* mov al, [bp+0x6] */
            ii(0x1a_108c, 2); mov(ah, 0x3d);                            /* mov ah, 0x3d */
            ii(0x1a_108e, 3); mov(memw[ss, bp - 0x2], ax);              /* mov [bp-0x2], ax */
            ii(0x1a_1091, 3); lea(cx, memw[ss, bp - 0x16]);             /* lea cx, [bp-0x16] */
            ii(0x1a_1094, 1); push(ss);                                 /* push ss */
            ii(0x1a_1095, 1); push(cx);                                 /* push cx */
            ii(0x1a_1096, 1); push(ax);                                 /* push ax */
            ii(0x1a_1097, 5); call_far_abs(0x80, 0x4c9f);               /* call word 0x80:0x4c9f */
            ii(0x1a_109c, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x1a_109f, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x1a_10a1, 2); if(jz(0x1a_10a8, 0x5)) goto l_0x1a_10a8;  /* jz 0x10a8 */
            ii(0x1a_10a3, 3); mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x1a_10a6, 2); jmp(0x1a_10ab, 0x3); goto l_0x1a_10ab;    /* jmp 0x10ab */
        l_0x1a_10a8:
            ii(0x1a_10a8, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
        l_0x1a_10ab:
            ii(0x1a_10ab, 1); pop(ds);                                  /* pop ds */
            ii(0x1a_10ac, 1); leave();                                  /* leave */
            ii(0x1a_10ad, 3); retf(0x6);                                /* retf 0x6 */
        }
    }
}
