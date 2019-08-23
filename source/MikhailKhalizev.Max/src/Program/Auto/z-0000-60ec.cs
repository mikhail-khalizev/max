using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x60ec-624bbdb5")]
        public void Method_0000_60ec()
        {
            ii(0x60ec, 1);    pushw(di);                                /* push di */
            ii(0x60ed, 3);    mov(di, 0xf56);                           /* mov di, 0xf56 */
            ii(0x60f0, 3);    mov(si, 0x467);                           /* mov si, 0x467 */
            ii(0x60f3, 2);    xor(bx, bx);                              /* xor bx, bx */
            ii(0x60f5, 2);    mov(ds, bx);                              /* mov ds, bx */
            ii(0x60f7, 3);    mov(bx, 0x1a2);                           /* mov bx, 0x1a2 */
            ii(0x60fa, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0x60fc, 1);    movsw_a16();                              /* movsw */
            ii(0x60fd, 1);    movsw_a16();                              /* movsw */
            ii(0x60fe, 3);    mov(memw_a16[ds, si - 0x4], ax);          /* mov [si-0x4], ax */
            ii(0x6101, 3);    mov(memw_a16[ds, si - 0x2], cx);          /* mov [si-0x2], cx */
            ii(0x6104, 3);    mov(si, 0x3e0);                           /* mov si, 0x3e0 */
            ii(0x6107, 3);    mov(cx, 0x10);                            /* mov cx, 0x10 */
            ii(0x610a, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x610c, 2);    mov(ds, bx);                              /* mov ds, bx */
            ii(0x610e, 1);    popw(di);                                 /* pop di */
            ii(0x610f, 1);    retw();                                   /* ret */
        }
    }
}
