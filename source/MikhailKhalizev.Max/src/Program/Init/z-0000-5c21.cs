using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("286a2a05-0583-42b9-b821-28eec1f7d29e")]
        public void Method_0000_5c21()
        {
            ii(0x5c21, 3);    callw(0x5c26, 0x2);                       /* call 0x5c26 */
            ii(0x5c24, 3);    mov(si, 0x5b39);                          /* mov si, 0x5b39 */
            ii(0x5c27, 3);    mov(cx, memw_a16[cs, bx]);                /* mov cx, [cs:bx] */
            ii(0x5c2a, 4);    mov(bx, memw_a16[ds, 0xafa]);             /* mov bx, [0xafa] */
            ii(0x5c2e, 1);    inc(bx);                                  /* inc bx */
            ii(0x5c2f, 1);    inc(bx);                                  /* inc bx */
            ii(0x5c30, 4);    mov(memw_a16[ds, 0xafa], bx);             /* mov [0xafa], bx */
            ii(0x5c34, 2);    popw(memw_a16[ds, bx]);                   /* pop word [bx] */
            ii(0x5c36, 3);    pushw(0x3e8f);                            /* push 0x3e8f */
            ii(0x5c39, 4);    jmpw_a16_far_ind(ds, 0xaf2); return;      /* jmp far word [0xaf2] */
        }
    }
}
