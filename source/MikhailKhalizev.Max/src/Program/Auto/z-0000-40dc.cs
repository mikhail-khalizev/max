using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x40dc-624bbdb5")]
        public void Method_0000_40dc()
        {
            ii(0x40dc, 1);    pushw(di);                                /* push di */
            ii(0x40dd, 3);    mov(di, 0xf56);                           /* mov di, 0xf56 */
            ii(0x40e0, 3);    mov(si, 0x467);                           /* mov si, 0x467 */
            ii(0x40e3, 2);    xor(bx, bx);                              /* xor bx, bx */
            ii(0x40e5, 2);    mov(ds, bx);                              /* mov ds, bx */
            ii(0x40e7, 3);    mov(bx, 0x1a2);                           /* mov bx, 0x1a2 */
            ii(0x40ea, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0x40ec, 1);    movsw_a16();                              /* movsw */
            ii(0x40ed, 1);    movsw_a16();                              /* movsw */
            ii(0x40ee, 3);    mov(memw_a16[ds, si - 0x4], ax);          /* mov [si-0x4], ax */
            ii(0x40f1, 3);    mov(memw_a16[ds, si - 0x2], cx);          /* mov [si-0x2], cx */
            ii(0x40f4, 3);    mov(si, 0x3e0);                           /* mov si, 0x3e0 */
            ii(0x40f7, 3);    mov(cx, 0x10);                            /* mov cx, 0x10 */
            ii(0x40fa, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x40fc, 2);    mov(ds, bx);                              /* mov ds, bx */
            ii(0x40fe, 1);    popw(di);                                 /* pop di */
            ii(0x40ff, 1);    retw();                                   /* ret */
        }
    }
}
