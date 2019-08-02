using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bc7207e8-b573-470f-b00c-7573618bd771")]
        public void Method_0014_074a()
        {
            ii(0x14_074a, 4); enterw(0x16, 0);                          /* enter 0x16, 0x0 */
            ii(0x14_074e, 1); pushw(ds);                                /* push ds */
            ii(0x14_074f, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x14_0752, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x14_0754, 5); mov(memw_a16[ss, bp - 0x2], 0x3c00);      /* mov word [bp-0x2], 0x3c00 */
            ii(0x14_0759, 5); mov(memw_a16[ss, bp - 0x14], 0);          /* mov word [bp-0x14], 0x0 */
            ii(0x14_075e, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x14_0761, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x14_0764, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x14_0767, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x14_076a, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x14_076d, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x14_0770, 3); lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x14_0773, 1); pushw(ss);                                /* push ss */
            ii(0x14_0774, 1); pushw(ax);                                /* push ax */
            ii(0x14_0775, 3); pushw(0x3c00);                            /* push 0x3c00 */
            ii(0x14_0778, 1); nop();                                    /* nop */
            ii(0x14_0779, 1); pushw(cs);                                /* push cs */
            ii(0x14_077a, 3); callw(0x13_eaed, -0x1c90);                /* call 0xeaed */
            ii(0x14_077d, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x14_0780, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x14_0782, 2); if(jzw(0x14_0789, 0x5)) goto l_0x14_0789; /* jz 0x789 */
            ii(0x14_0784, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x14_0787, 2); jmpw(0x14_078c, 0x3); goto l_0x14_078c;   /* jmp 0x78c */
        l_0x14_0789:
            ii(0x14_0789, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
        l_0x14_078c:
            ii(0x14_078c, 1); popw(ds);                                 /* pop ds */
            ii(0x14_078d, 1); leavew();                                 /* leave */
            ii(0x14_078e, 3); retfw(0x6); return;                       /* retf 0x6 */
        }
    }
}
