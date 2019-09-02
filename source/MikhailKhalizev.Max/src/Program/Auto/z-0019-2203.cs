using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_2203-a73f61f3")]
        public void Method_0019_2203()
        {
            ii(0x19_2203, 1); push(ax);                                 /* push ax */
            ii(0x19_2204, 1); push(cs);                                 /* push cs */
            ii(0x19_2205, 3); call(0x19_29f2, 0x7ea);                   /* call 0x29f2 */
            ii(0x19_2208, 1); push(cs);                                 /* push cs */
            ii(0x19_2209, 3); call(0x19_2c8d, 0xa81);                   /* call 0x2c8d */
            ii(0x19_220c, 7); cmp(memw[ss, 0x3f68], 0xd6d6);            /* cmp word [ss:0x3f68], 0xd6d6 */
            ii(0x19_2213, 2); if(jnz(0x19_221c, 7)) goto l_0x19_221c;   /* jnz 0x221c */
            ii(0x19_2215, 1); pop(ax);                                  /* pop ax */
            ii(0x19_2216, 1); push(ax);                                 /* push ax */
            ii(0x19_2217, 5); call_abs(memw[ss, 0x3f6c]);               /* call word [ss:0x3f6c] */
        l_0x19_221c:
            ii(0x19_221c, 3); mov(ax, 0xff);                            /* mov ax, 0xff */
            ii(0x19_221f, 1); push(ax);                                 /* push ax */
            ii(0x19_2220, 1); push(cs);                                 /* push cs */
            ii(0x19_2221, 4); call_abs(memw[ds, 0x3b94]);               /* call word [0x3b94] */
            ii(0x19_2225, 2); test(al, 0);                              /* test al, 0x0 */
            ii(0x19_2227, 2); add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0x19_2229, 2); add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0x19_222b, 2); add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0x19_222d, 2); add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0x19_222f, 2); add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0x19_2231, 4); add(memb[ds, -0x48], al);                 /* add [0xffb8], al */
            ii(0x19_2235, 4); push(memw[ss, bp - 29691]);               /* push word [bp-0x73fb] */
            ii(0x19_2239, 1); retf();                                   /* retf */
        }
    }
}
