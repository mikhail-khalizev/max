using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6043-b1e8c28e")]
        public void Method_0000_6043()
        {
            ii(0x6043, 1);    pusha();                                  /* pusha */
            ii(0x6044, 4);    call_abs(memw[ds, 0x9c0]);                /* call word [0x9c0] */
            ii(0x6048, 2);    mov(ss, dx);                              /* mov ss, dx */
            ii(0x604a, 3);    mov(dx, 0x20);                            /* mov dx, 0x20 */
            ii(0x604d, 2);    mov(ds, dx);                              /* mov ds, dx */
            ii(0x604f, 2);    mov(es, dx);                              /* mov es, dx */
            ii(0x6051, 3);    mov(ax, 0x68);                            /* mov ax, 0x68 */
            ii(0x6054, 3);    lldt(ax);                                 /* lldt ax */
            ii(0x6057, 3);    smsw(ax);                                 /* smsw ax */
            ii(0x605a, 4);    or(ax, memw[ds, 0x40]);                   /* or ax, [0x40] */
            ii(0x605e, 3);    lmsw(ax);                                 /* lmsw ax */
            ii(0x6061, 4);    jmp_abs(memw[ds, 0x9c2]);                 /* jmp word [0x9c2] */
        }
    }
}
