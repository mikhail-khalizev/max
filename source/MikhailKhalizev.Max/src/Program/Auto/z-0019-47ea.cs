using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_47ea-b4ff5a09")]
        public void Method_0019_47ea()
        {
            ii(0x19_47ea, 4); enter(0x14, 0);                           /* enter 0x14, 0x0 */
            ii(0x19_47ee, 1); push(ds);                                 /* push ds */
            ii(0x19_47ef, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_47f2, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_47f4, 5); mov(memw[ss, bp - 6], 0x300);             /* mov word [bp-0x6], 0x300 */
            ii(0x19_47f9, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x19_47fc, 2); push(0);                                  /* push 0x0 */
            ii(0x19_47fe, 3); lea(ax, memw[ss, bp - 20]);               /* lea ax, [bp-0x14] */
            ii(0x19_4801, 1); push(ss);                                 /* push ss */
            ii(0x19_4802, 1); push(ax);                                 /* push ax */
            ii(0x19_4803, 2); push(-1 /* 0xff */);                      /* push 0xffff */
            ii(0x19_4805, 1); nop();                                    /* nop */
            ii(0x19_4806, 1); push(cs);                                 /* push cs */
            ii(0x19_4807, 3); call(0x19_4188, -0x682);                  /* call 0x4188 */
            ii(0x19_480a, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_480d, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_480f, 2); if(jz(0x19_481a, 9)) goto l_0x19_481a;    /* jz 0x481a */
            ii(0x19_4811, 3); mov(ax, memw[ss, bp - 18]);               /* mov ax, [bp-0x12] */
            ii(0x19_4814, 3); mov(memw[ss, bp + 8], ax);                /* mov [bp+0x8], ax */
            ii(0x19_4817, 2); jmp(0x19_4822, 9); goto l_0x19_4822;      /* jmp 0x4822 */
        //  ii(0x19_4819, 1); nop();                                    /* nop */
        l_0x19_481a:
            ii(0x19_481a, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_481c, 3); mov(memw[ss, bp + 8], ax);                /* mov [bp+0x8], ax */
            ii(0x19_481f, 3); mov(memw[ss, bp + 6], ax);                /* mov [bp+0x6], ax */
        l_0x19_4822:
            ii(0x19_4822, 3); mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x19_4825, 3); mov(dx, memw[ss, bp + 8]);                /* mov dx, [bp+0x8] */
            ii(0x19_4828, 1); pop(ds);                                  /* pop ds */
            ii(0x19_4829, 1); leave();                                  /* leave */
            ii(0x19_482a, 1); retf();                                   /* retf */
        }
    }
}
