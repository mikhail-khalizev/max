using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4030-33a07d94")]
        public void Method_0000_4030()
        {
            ii(0x4030, 3);    mov(dx, 0x20);                            /* mov dx, 0x20 */
            ii(0x4033, 1);    pusha();                                  /* pusha */
            ii(0x4034, 4);    callw_abs(memw_a16[ds, 0x9c0]);           /* call word [0x9c0] */
            ii(0x4038, 2);    mov(ss, dx);                              /* mov ss, dx */
            ii(0x403a, 3);    mov(dx, 0x20);                            /* mov dx, 0x20 */
            ii(0x403d, 2);    mov(ds, dx);                              /* mov ds, dx */
            ii(0x403f, 2);    mov(es, dx);                              /* mov es, dx */
            ii(0x4041, 3);    mov(ax, 0x68);                            /* mov ax, 0x68 */
            ii(0x4044, 3);    lldt(ax);                                 /* lldt ax */
            ii(0x4047, 3);    smsw(ax);                                 /* smsw ax */
            ii(0x404a, 4);    or(ax, memw_a16[ds, 0x40]);               /* or ax, [0x40] */
            ii(0x404e, 3);    lmsw(ax);                                 /* lmsw ax */
            ii(0x4051, 4);    jmpw_abs(memw_a16[ds, 0x9c2]);            /* jmp word [0x9c2] */
        }
    }
}
