using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_ee6c-a4625f82")]
        public void Method_0018_ee6c()
        {
            ii(0x18_ee6c, 5); test(memb[ds, 0x1582], 0x1);              /* test byte [0x1582], 0x1 */
            ii(0x18_ee71, 2); if(jnz_func(0x18_ee44, -0x2f)) return;    /* jnz 0xee44 */
            ii(0x18_ee73, 2); mov(al, 0xb);                             /* mov al, 0xb */
            ii(0x18_ee75, 1); outb(dx, al);                             /* out dx, al */
            ii(0x18_ee76, 1); pop(ds);                                  /* pop ds */
            ii(0x18_ee77, 2); jmp(0x18_ee79, 0); goto l_0x18_ee79;      /* jmp 0xee79 */
        l_0x18_ee79:
            ii(0x18_ee79, 2); jmp(0x18_ee7b, 0); goto l_0x18_ee7b;      /* jmp 0xee7b */
        l_0x18_ee7b:
            ii(0x18_ee7b, 1); inb(al, dx);                              /* in al, dx */
            ii(0x18_ee7c, 1); pop(dx);                                  /* pop dx */
            ii(0x18_ee7d, 2); test(ch, al);                             /* test ch, al */
            ii(0x18_ee7f, 1); pop(ax);                                  /* pop ax */
            ii(0x18_ee80, 2); if(jz_func(0x18_ee84, 0x2)) return;       /* jz 0xee84 */
            ii(0x18_ee82, 1); ret();                                    /* ret */
        }
    }
}
