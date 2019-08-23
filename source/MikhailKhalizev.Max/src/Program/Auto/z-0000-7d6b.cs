using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7d6b-52b45763")]
        public void Method_0000_7d6b()
        {
            ii(0x7d6b, 2);    @int(0x10);                               /* int 0x10 */
            ii(0x7d6d, 1);    pushfw();                                 /* pushfw */
            ii(0x7d6e, 1);    cli();                                    /* cli */
            ii(0x7d6f, 5);    popw(memw_a16[cs, 0x1fa4]);               /* pop word [cs:0x1fa4] */
            ii(0x7d74, 3);    pushw(0x1a2);                             /* push 0x1a2 */
            ii(0x7d77, 1);    popw(ss);                                 /* pop ss */
            ii(0x7d78, 5);    mov(sp, memw_a16[ss, 0x996]);             /* mov sp, [ss:0x996] */
            ii(0x7d7d, 2);    pushad();                                 /* pushad */
            ii(0x7d7f, 1);    pushw(es);                                /* push es */
            ii(0x7d80, 1);    pushw(ds);                                /* push ds */
            ii(0x7d81, 1);    pushw(ss);                                /* push ss */
            ii(0x7d82, 1);    popw(ds);                                 /* pop ds */
            ii(0x7d83, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x7d85, 3);    mov(ax, memw_a16[ss, bp + 0x38]);         /* mov ax, [bp+0x38] */
            ii(0x7d88, 4);    mov(memw_a16[cs, 0x1fbb], ax);            /* mov [cs:0x1fbb], ax */
            ii(0x7d8c, 3);    callw(0x6040, -0x1d4f);                   /* call 0x6040 */
            ii(0x7d8f, 4);    mov(ax, memw_a16[cs, 0x1fa4]);            /* mov ax, [cs:0x1fa4] */
            ii(0x7d93, 5);    jmpw_far_abs(0x70, 0x4cf9);               /* jmp word 0x70:0x4cf9 */
        }
    }
}
