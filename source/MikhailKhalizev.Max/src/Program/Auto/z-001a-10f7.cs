using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_10f7-addc6c14")]
        public void Method_001a_10f7()
        {
            ii(0x1a_10f7, 4); enter(0x16, 0);                           /* enter 0x16, 0x0 */
            ii(0x1a_10fb, 1); push(ds);                                 /* push ds */
            ii(0x1a_10fc, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x1a_10ff, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x1a_1101, 5); mov(memw[ss, bp - 2], 0x3e00);            /* mov word [bp-0x2], 0x3e00 */
            ii(0x1a_1106, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x1a_1108, 3); mov(memw[ss, bp - 0x14], ax);             /* mov [bp-0x14], ax */
            ii(0x1a_110b, 3); mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0x1a_110e, 3); mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x1a_1111, 3); mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x1a_1114, 3); lea(ax, memw[ss, bp - 0x16]);             /* lea ax, [bp-0x16] */
            ii(0x1a_1117, 1); push(ss);                                 /* push ss */
            ii(0x1a_1118, 1); push(ax);                                 /* push ax */
            ii(0x1a_1119, 3); push(0x3e00);                             /* push 0x3e00 */
            ii(0x1a_111c, 5); call_far_abs(0x80, 0x4c9f);               /* call word 0x80:0x4c9f */
            ii(0x1a_1121, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x1a_1124, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x1a_1126, 2); if(jz(0x1a_112d, 5)) goto l_0x1a_112d;    /* jz 0x112d */
            ii(0x1a_1128, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x1a_112b, 2); jmp(0x1a_1130, 3); goto l_0x1a_1130;      /* jmp 0x1130 */
        l_0x1a_112d:
            ii(0x1a_112d, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
        l_0x1a_1130:
            ii(0x1a_1130, 1); pop(ds);                                  /* pop ds */
            ii(0x1a_1131, 1); leave();                                  /* leave */
            ii(0x1a_1132, 3); retf(2);                                  /* retf 0x2 */
        }
    }
}
