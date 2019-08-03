using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a01b93fb-cbda-483a-84c5-ed3559a40ce4")]
        public void Method_0015_47ea()
        {
            ii(0x15_47ea, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x15_47ee, 1); pushw(ds);                                /* push ds */
            ii(0x15_47ef, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_47f2, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_47f4, 5); mov(memw_a16[ss, bp - 0x6], 0x300);       /* mov word [bp-0x6], 0x300 */
            ii(0x15_47f9, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_47fc, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_47fe, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x15_4801, 1); pushw(ss);                                /* push ss */
            ii(0x15_4802, 1); pushw(ax);                                /* push ax */
            ii(0x15_4803, 2); pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0x15_4805, 1); nop();                                    /* nop */
            ii(0x15_4806, 1); pushw(cs);                                /* push cs */
            ii(0x15_4807, 3); callw(0x15_4188, -0x682);                 /* call 0x4188 */
            ii(0x15_480a, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x15_480d, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_480f, 2); if(jzw(0x15_481a, 0x9)) goto l_0x15_481a; /* jz 0x481a */
            ii(0x15_4811, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x15_4814, 3); mov(memw_a16[ss, bp + 0x8], ax);          /* mov [bp+0x8], ax */
            ii(0x15_4817, 2); jmpw(0x15_4822, 0x9); goto l_0x15_4822;   /* jmp 0x4822 */
        //  ii(0x15_4819, 1); Недостижимый код.
l_0x15_481a:
            ii(0x15_481a, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_481c, 3); mov(memw_a16[ss, bp + 0x8], ax);          /* mov [bp+0x8], ax */
            ii(0x15_481f, 3); mov(memw_a16[ss, bp + 0x6], ax);          /* mov [bp+0x6], ax */
        l_0x15_4822:
            ii(0x15_4822, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_4825, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x15_4828, 1); popw(ds);                                 /* pop ds */
            ii(0x15_4829, 1); leavew();                                 /* leave */
            ii(0x15_482a, 1); retfw(); return;                          /* retf */
        }
    }
}