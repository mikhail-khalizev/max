using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_4166-de431d81")]
        public void Method_0019_4166()
        {
            ii(0x19_4166, 2); pop(memw[ds, bx]);                        /* pop word [bx] */
            ii(0x19_4168, 3); mov(memw[ds, bx + 2], es);                /* mov [bx+0x2], es */
            ii(0x19_416b, 3); mov(memw[ds, bx + 4], di);                /* mov [bx+0x4], di */
            ii(0x19_416e, 3); mov(memw[ds, bx + 6], si);                /* mov [bx+0x6], si */
            ii(0x19_4171, 3); mov(memw[ds, bx + 0xe], dx);              /* mov [bx+0xe], dx */
            ii(0x19_4174, 3); mov(memw[ds, bx + 0x10], cx);             /* mov [bx+0x10], cx */
            ii(0x19_4177, 3); pop(memw[ds, bx + 0xc]);                  /* pop word [bx+0xc] */
            ii(0x19_417a, 3); mov(memw[ds, bx + 0x12], ax);             /* mov [bx+0x12], ax */
            ii(0x19_417d, 1); pop(ds);                                  /* pop ds */
            ii(0x19_417e, 1); pop(di);                                  /* pop di */
            ii(0x19_417f, 1); pop(si);                                  /* pop si */
            ii(0x19_4180, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_4183, 1); cmc();                                    /* cmc */
            ii(0x19_4184, 2); rcl(ax, 1);                               /* rcl ax, 1 */
            ii(0x19_4186, 1); pop(bp);                                  /* pop bp */
            ii(0x19_4187, 1); retf();                                   /* retf */
        }
    }
}
