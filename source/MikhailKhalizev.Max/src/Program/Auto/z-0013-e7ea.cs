using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1b33e7d8-afbd-44a5-aeaf-49a2c9dbf10e")]
        public void Method_0013_e7ea()
        {
            ii(0x13_e7ea, 4); enterw(0x16, 0);                          /* enter 0x16, 0x0 */
            ii(0x13_e7ee, 1); pushw(ds);                                /* push ds */
            ii(0x13_e7ef, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_e7f2, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_e7f4, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_e7f7, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_e7fa, 1); nop();                                    /* nop */
            ii(0x13_e7fb, 1); pushw(cs);                                /* push cs */
            ii(0x13_e7fc, 3); callw(0x13_ef26, 0x727);                  /* call 0xef26 */
            ii(0x13_e7ff, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_e802, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x13_e805, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_e807, 2); if(jlw(0x13_e80f, 0x6)) goto l_0x13_e80f; /* jl 0xe80f */
            ii(0x13_e809, 4); test(memb_a16[ss, bp - 0x16], 0x10);      /* test byte [bp-0x16], 0x10 */
            ii(0x13_e80d, 2); if(jnzw(0x13_e814, 0x5)) goto l_0x13_e814; /* jnz 0xe814 */
        l_0x13_e80f:
            ii(0x13_e80f, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_e811, 1); popw(ds);                                 /* pop ds */
            ii(0x13_e812, 1); leavew();                                 /* leave */
            ii(0x13_e813, 1); retfw(); return;                          /* retf */
        l_0x13_e814:
            ii(0x13_e814, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_e817, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_e819, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x13_e81c, 1); pushw(ss);                                /* push ss */
            ii(0x13_e81d, 1); pushw(ax);                                /* push ax */
            ii(0x13_e81e, 3); pushw(0x4900);                            /* push 0x4900 */
            ii(0x13_e821, 1); nop();                                    /* nop */
            ii(0x13_e822, 1); pushw(cs);                                /* push cs */
            ii(0x13_e823, 3); callw(0x13_eb40, 0x31a);                  /* call 0xeb40 */
            ii(0x13_e826, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x13_e829, 1); popw(ds);                                 /* pop ds */
            ii(0x13_e82a, 1); leavew();                                 /* leave */
            ii(0x13_e82b, 1); retfw(); return;                          /* retf */
        }
    }
}
