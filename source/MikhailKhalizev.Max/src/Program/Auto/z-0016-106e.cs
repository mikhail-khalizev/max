using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d41fe7d5-f2fa-42a9-af24-30e801496122")]
        public void Method_0016_106e()
        {
            ii(0x16_106e, 4); enterw(0x16, 0);                          /* enter 0x16, 0x0 */
            ii(0x16_1072, 1); pushw(ds);                                /* push ds */
            ii(0x16_1073, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x16_1076, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x16_1078, 5); mov(memw_a16[ss, bp - 0x14], 0);          /* mov word [bp-0x14], 0x0 */
            ii(0x16_107d, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x16_1080, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x16_1083, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x16_1086, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x16_1089, 3); mov(al, memb_a16[ss, bp + 0x6]);          /* mov al, [bp+0x6] */
            ii(0x16_108c, 2); mov(ah, 0x3d);                            /* mov ah, 0x3d */
            ii(0x16_108e, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x16_1091, 3); lea(cx, bp - 0x16);                       /* lea cx, [bp-0x16] */
            ii(0x16_1094, 1); pushw(ss);                                /* push ss */
            ii(0x16_1095, 1); pushw(cx);                                /* push cx */
            ii(0x16_1096, 1); pushw(ax);                                /* push ax */
            ii(0x16_1097, 5); callw_far_abs(0x80, 0x4c9f);              /* call word 0x80:0x4c9f */
            ii(0x16_109c, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x16_109f, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x16_10a1, 2); if(jzw(0x16_10a8, 0x5)) goto l_0x16_10a8; /* jz 0x10a8 */
            ii(0x16_10a3, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x16_10a6, 2); jmpw(0x16_10ab, 0x3); goto l_0x16_10ab;   /* jmp 0x10ab */
        l_0x16_10a8:
            ii(0x16_10a8, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
        l_0x16_10ab:
            ii(0x16_10ab, 1); popw(ds);                                 /* pop ds */
            ii(0x16_10ac, 1); leavew();                                 /* leave */
            ii(0x16_10ad, 3); retfw(0x6); return;                       /* retf 0x6 */
        }
    }
}
