using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x85d4-613b4c55")]
        public void Method_0000_85d4()
        {
            ii(0x85d4, 4);  mov(memw[ds, 0xd66], gs);                  /* mov [0xd66], gs */
            ii(0x85d8, 4);  mov(memw[ds, 0xd64], fs);                  /* mov [0xd64], fs */
            ii(0x85dc, 4);  mov(fs, memw[ds, 0xd60]);                  /* mov fs, [0xd60] */
            ii(0x85e0, 4);  mov(gs, memw[ds, 0xd62]);                  /* mov gs, [0xd62] */
            ii(0x85e4, 2);  xor(ax, ax);                               /* xor ax, ax */
            ii(0x85e6, 4);  cmp(memb[ds, 0x35], al);                   /* cmp [0x35], al */
            ii(0x85ea, 2);  if(jnz(0x85ef, 3)) goto l_0x85ef;          /* jnz 0x85ef */
            ii(0x85ec, 3);  call(0x6999, -0x1c56);                     /* call 0x6999 */
        l_0x85ef:
            ii(0x85ef, 5);  cmp(memb[ds, 0x11f0], 0);                  /* cmp byte [0x11f0], 0x0 */
            ii(0x85f4, 2);  if(jnz(0x85fb, 5)) goto l_0x85fb;          /* jnz 0x85fb */
            ii(0x85f6, 2);  mov(cl, 9);                                /* mov cl, 0x9 */
            ii(0x85f8, 3);  if(jmp_func(0x6672, -0x1f89)) return;      /* jmp 0x6672 */
        l_0x85fb:
            ii(0x85fb, 1);  ret();                                     /* ret */
        }
    }
}
