using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xc373-2e3be89a")]
        public void Method_0000_c373()
        {
            ii(0xc373, 3);    mov(ax, memw_a16[ds, 0xcde]);             /* mov ax, [0xcde] */
            ii(0xc376, 1);    inc(ax);                                  /* inc ax */
            ii(0xc377, 2);    and(al, 0xfe);                            /* and al, 0xfe */
            ii(0xc379, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0xc37b, 3);    mov(cx, memw_a16[ds, bx + 0x2]);          /* mov cx, [bx+0x2] */
            ii(0xc37e, 2);    add(cx, ax);                              /* add cx, ax */
            ii(0xc380, 2);    if(jbw(0xc38d, 0xb)) goto l_0xc38d;       /* jb 0xc38d */
            ii(0xc382, 4);    cmp(cx, memw_a16[ds, 0xce6]);             /* cmp cx, [0xce6] */
            ii(0xc386, 2);    if(jaw(0xc38d, 0x5)) goto l_0xc38d;       /* ja 0xc38d */
            ii(0xc388, 4);    mov(memw_a16[ds, 0xcde], cx);             /* mov [0xcde], cx */
            ii(0xc38c, 1);    retw(); return;                           /* ret */
        l_0xc38d:
            ii(0xc38d, 3);    mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0xc390, 1);    retw();                                   /* ret */
        }
    }
}
