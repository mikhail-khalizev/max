using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_074a-c132d51e")]
        public void Method_0018_074a()
        {
            ii(0x18_074a, 4); enter(0x16, 0);                           /* enter 0x16, 0x0 */
            ii(0x18_074e, 1); push(ds);                                 /* push ds */
            ii(0x18_074f, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x18_0752, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x18_0754, 5); mov(memw[ss, bp - 0x2], 0x3c00);          /* mov word [bp-0x2], 0x3c00 */
            ii(0x18_0759, 5); mov(memw[ss, bp - 0x14], 0);              /* mov word [bp-0x14], 0x0 */
            ii(0x18_075e, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x18_0761, 3); mov(memw[ss, bp - 0x6], ax);              /* mov [bp-0x6], ax */
            ii(0x18_0764, 3); mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0x18_0767, 3); mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0x18_076a, 3); mov(ax, memw[ss, bp + 0x8]);              /* mov ax, [bp+0x8] */
            ii(0x18_076d, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0x18_0770, 3); lea(ax, memw[ss, bp - 0x16]);             /* lea ax, [bp-0x16] */
            ii(0x18_0773, 1); push(ss);                                 /* push ss */
            ii(0x18_0774, 1); push(ax);                                 /* push ax */
            ii(0x18_0775, 3); push(0x3c00);                             /* push 0x3c00 */
            ii(0x18_0778, 1); nop();                                    /* nop */
            ii(0x18_0779, 1); push(cs);                                 /* push cs */
            ii(0x18_077a, 3); call(0x17_eaed, -0x1c90);                 /* call 0xeaed */
            ii(0x18_077d, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x18_0780, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_0782, 2); if(jz(0x18_0789, 0x5)) goto l_0x18_0789;  /* jz 0x789 */
            ii(0x18_0784, 3); mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x18_0787, 2); jmp(0x18_078c, 0x3); goto l_0x18_078c;    /* jmp 0x78c */
        l_0x18_0789:
            ii(0x18_0789, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
        l_0x18_078c:
            ii(0x18_078c, 1); pop(ds);                                  /* pop ds */
            ii(0x18_078d, 1); leave();                                  /* leave */
            ii(0x18_078e, 3); retf(0x6);                                /* retf 0x6 */
        }
    }
}
