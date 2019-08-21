using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xe08c-7bb9909f")]
        public void Method_0000_e08c()
        {
            ii(0xe08c, 4);    mov(di, memw_a16[ds, 0x99e]);             /* mov di, [0x99e] */
            ii(0xe090, 2);    or(di, di);                               /* or di, di */
            ii(0xe092, 2);    if(jzw(0xe09e, 0xa)) goto l_0xe09e;       /* jz 0xe09e */
            ii(0xe094, 3);    mov(dx, memw_a16[ds, di + 0x22]);         /* mov dx, [di+0x22] */
            ii(0xe097, 3);    mov(ax, memw_a16[ds, di + 0x1e]);         /* mov ax, [di+0x1e] */
            ii(0xe09a, 3);    mov(cx, memw_a16[ds, di + 0x26]);         /* mov cx, [di+0x26] */
            ii(0xe09d, 1);    retw(); return;                           /* ret */
        l_0xe09e:
            ii(0xe09e, 4);    mov(di, memw_a16[ds, 0x996]);             /* mov di, [0x996] */
            ii(0xe0a2, 3);    mov(dx, memw_a16[ds, di + 0x2]);          /* mov dx, [di+0x2] */
            ii(0xe0a5, 3);    mov(ax, memw_a16[ds, di + 0xe]);          /* mov ax, [di+0xe] */
            ii(0xe0a8, 3);    sub(ax, 0x4a);                            /* sub ax, 0x4a */
            ii(0xe0ab, 2);    xor(cx, cx);                              /* xor cx, cx */
            ii(0xe0ad, 1);    retw(); return;                           /* ret */
        }
    }
}
