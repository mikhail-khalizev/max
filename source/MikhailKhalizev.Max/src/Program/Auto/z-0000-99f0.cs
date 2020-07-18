using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x99f0-4d76d219")]
        public void Method_0000_99f0()
        {
            ii(0x99f0, 2);  xor(ax, ax);                               /* xor ax, ax */
            ii(0x99f2, 2);  xor(bx, bx);                               /* xor bx, bx */
            ii(0x99f4, 2);  mov(cl, 0x82);                             /* mov cl, 0x82 */
            ii(0x99f6, 2);  @int(0xdc);                                /* int 0xdc */
            ii(0x99f8, 2);  mov(al, bl);                               /* mov al, bl */
            ii(0x99fa, 2);  or(al, bh);                                /* or al, bh */
            ii(0x99fc, 2);  if(jz(0x9a0c, 0xe)) goto l_0x9a0c;         /* jz 0x9a0c */
            ii(0x99fe, 3);  shl(bx, 6);                                /* shl bx, 0x6 */
            ii(0x9a01, 4);  mov(memw[ds, 0xeca], bx);                  /* mov [0xeca], bx */
            ii(0x9a05, 3);  shl(dx, 6);                                /* shl dx, 0x6 */
            ii(0x9a08, 4);  mov(memw[ds, 0xece], dx);                  /* mov [0xece], dx */
        l_0x9a0c:
            ii(0x9a0c, 1);  ret();                                     /* ret */
        }
    }
}
