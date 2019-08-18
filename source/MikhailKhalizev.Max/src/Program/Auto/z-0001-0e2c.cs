using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e83e0b24-6c73-411c-93b8-eca2f7108c67")]
        public void Method_0001_0e2c()
        {
            ii(0x1_0e2c, 5);  test(memb_a16[ds, 0x1582], 0x1);          /* test byte [0x1582], 0x1 */
            ii(0x1_0e31, 2);  if(jnzw_func(0x1_0e04, -0x2f)) return;    /* jnz 0xe04 */
            ii(0x1_0e33, 2);  mov(al, 0xb);                             /* mov al, 0xb */
            ii(0x1_0e35, 1);  outb(dx, al);                             /* out dx, al */
            ii(0x1_0e36, 1);  popw(ds);                                 /* pop ds */
            ii(0x1_0e37, 2);  jmpw(0x1_0e39, 0); goto l_0x1_0e39;       /* jmp 0xe39 */
        l_0x1_0e39:
            ii(0x1_0e39, 2);  jmpw(0x1_0e3b, 0); goto l_0x1_0e3b;       /* jmp 0xe3b */
        l_0x1_0e3b:
            ii(0x1_0e3b, 1);  inb(al, dx);                              /* in al, dx */
            ii(0x1_0e3c, 1);  popw(dx);                                 /* pop dx */
            ii(0x1_0e3d, 2);  test(ch, al);                             /* test ch, al */
            ii(0x1_0e3f, 1);  popw(ax);                                 /* pop ax */
            ii(0x1_0e40, 2);  if(jzw_func(0x1_0e44, 0x2)) return;       /* jz 0xe44 */
            ii(0x1_0e42, 1);  retw(); return;                           /* ret */
        }
    }
}
