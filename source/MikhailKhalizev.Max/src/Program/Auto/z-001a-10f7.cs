using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_10f7-addc6c14")]
        public void Method_001a_10f7()
        {
            ii(0x1a_10f7, 4); enterw(0x16, 0);                          /* enter 0x16, 0x0 */
            ii(0x1a_10fb, 1); pushw(ds);                                /* push ds */
            ii(0x1a_10fc, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x1a_10ff, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x1a_1101, 5); mov(memw_a16[ss, bp - 0x2], 0x3e00);      /* mov word [bp-0x2], 0x3e00 */
            ii(0x1a_1106, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x1a_1108, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x1a_110b, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x1a_110e, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x1a_1111, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x1a_1114, 3); lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x1a_1117, 1); pushw(ss);                                /* push ss */
            ii(0x1a_1118, 1); pushw(ax);                                /* push ax */
            ii(0x1a_1119, 3); pushw(0x3e00);                            /* push 0x3e00 */
            ii(0x1a_111c, 5); if(callw_far_abs_up(0x80, 0x4c9f)) return; /* call word 0x80:0x4c9f */
            ii(0x1a_1121, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x1a_1124, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x1a_1126, 2); if(jzw(0x1a_112d, 0x5)) goto l_0x1a_112d; /* jz 0x112d */
            ii(0x1a_1128, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x1a_112b, 2); jmpw(0x1a_1130, 0x3); goto l_0x1a_1130;   /* jmp 0x1130 */
        l_0x1a_112d:
            ii(0x1a_112d, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
        l_0x1a_1130:
            ii(0x1a_1130, 1); popw(ds);                                 /* pop ds */
            ii(0x1a_1131, 1); leavew();                                 /* leave */
            ii(0x1a_1132, 3); retfw(0x2);                               /* retf 0x2 */
        }
    }
}
