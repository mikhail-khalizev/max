using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb124-c31a9d8d")]
        public void Method_0000_b124()
        {
            ii(0xb124, 2);    xor(bx, bx);                              /* xor bx, bx */
            ii(0xb126, 2);    xor(dx, dx);                              /* xor dx, dx */
            ii(0xb128, 2);    mov(ah, 0x42);                            /* mov ah, 0x42 */
            ii(0xb12a, 3);    call(0xac9b, -0x492);                     /* call 0xac9b */
            ii(0xb12d, 2);    or(bx, bx);                               /* or bx, bx */
            ii(0xb12f, 4);    if(jnz(0xb13f, 0xc)) goto l_0xb13f;       /* jnz 0xb13f */
            ii(0xb133, 3);    mov(ax, 0xde03);                          /* mov ax, 0xde03 */
            ii(0xb136, 3);    call(0xac9b, -0x49e);                     /* call 0xac9b */
            ii(0xb139, 4);    shr(edx, 2);                              /* shr edx, 0x2 */
            ii(0xb13d, 2);    mov(bx, dx);                              /* mov bx, dx */
        l_0xb13f:
            ii(0xb13f, 1);    ret();                                    /* ret */
        }
    }
}
