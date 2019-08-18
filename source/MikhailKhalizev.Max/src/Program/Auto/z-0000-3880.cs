using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1e37b3d5-e25a-4eef-a94a-937cb12235c0")]
        public void Method_0000_3880()
        {
            ii(0x3880, 3);    mov(dx, 0x20);                            /* mov dx, 0x20 */
            ii(0x3883, 1);    pusha();                                  /* pusha */
            ii(0x3884, 4);    callw_abs(memw_a16[ds, 0x9c0]);           /* call word [0x9c0] */
            ii(0x3888, 2);    mov(ss, dx);                              /* mov ss, dx */
            ii(0x388a, 3);    mov(dx, 0x20);                            /* mov dx, 0x20 */
            ii(0x388d, 2);    mov(ds, dx);                              /* mov ds, dx */
            ii(0x388f, 2);    mov(es, dx);                              /* mov es, dx */
            ii(0x3891, 3);    mov(ax, 0x68);                            /* mov ax, 0x68 */
            ii(0x3894, 3);    lldt(ax);                                 /* lldt ax */
            ii(0x3897, 3);    smsw(ax);                                 /* smsw ax */
            ii(0x389a, 4);    or(ax, memw_a16[ds, 0x40]);               /* or ax, [0x40] */
            ii(0x389e, 3);    lmsw(ax);                                 /* lmsw ax */
            ii(0x38a1, 4);    if(jmpw_abs(memw_a16[ds, 0x9c2])) return; /* jmp word [0x9c2] */
        }
    }
}
