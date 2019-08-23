using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9bb3-2e3be89a")]
        public void Method_0000_9bb3()
        {
            ii(0x9bb3, 3);    mov(ax, memw[ds, 0xcde]);                 /* mov ax, [0xcde] */
            ii(0x9bb6, 1);    inc(ax);                                  /* inc ax */
            ii(0x9bb7, 2);    and(al, 0xfe);                            /* and al, 0xfe */
            ii(0x9bb9, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x9bbb, 3);    mov(cx, memw[ds, bx + 0x2]);              /* mov cx, [bx+0x2] */
            ii(0x9bbe, 2);    add(cx, ax);                              /* add cx, ax */
            ii(0x9bc0, 2);    if(jb(0x9bcd, 0xb)) goto l_0x9bcd;        /* jb 0x9bcd */
            ii(0x9bc2, 4);    cmp(cx, memw[ds, 0xce6]);                 /* cmp cx, [0xce6] */
            ii(0x9bc6, 2);    if(ja(0x9bcd, 0x5)) goto l_0x9bcd;        /* ja 0x9bcd */
            ii(0x9bc8, 4);    mov(memw[ds, 0xcde], cx);                 /* mov [0xcde], cx */
            ii(0x9bcc, 1);    ret(); return;                            /* ret */
        l_0x9bcd:
            ii(0x9bcd, 3);    mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x9bd0, 1);    ret();                                    /* ret */
        }
    }
}
