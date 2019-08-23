using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x979d-108064a3")]
        public void Method_0000_979d()
        {
            ii(0x979d, 1);    popw(bx);                                 /* pop bx */
            ii(0x979e, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x97a0, 2);    if(jnzw(0x97a8, 0x6)) goto l_0x97a8;      /* jnz 0x97a8 */
        l_0x97a2:
            ii(0x97a2, 2);    pushw(0xd);                               /* push 0xd */
            ii(0x97a4, 3);    callw(0x805d, -0x174a);                   /* call 0x805d */
            ii(0x97a7, 1);    popw(bx);                                 /* pop bx */
        l_0x97a8:
            ii(0x97a8, 1);    pushw(si);                                /* push si */
            ii(0x97a9, 3);    callw(0x81ee, -0x15be);                   /* call 0x81ee */
            ii(0x97ac, 1);    popw(bx);                                 /* pop bx */
            ii(0x97ad, 3);    add(ax, 0xf);                             /* add ax, 0xf */
            ii(0x97b0, 2);    and(al, 0xf0);                            /* and al, 0xf0 */
            ii(0x97b2, 3);    mov(memw_a16[ds, 0xa], ax);               /* mov [0xa], ax */
            ii(0x97b5, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x97b7, 2);    if(jzw(0x97a2, -0x17)) goto l_0x97a2;     /* jz 0x97a2 */
            ii(0x97b9, 2);    mov(ax, si);                              /* mov ax, si */
            ii(0x97bb, 2);    and(al, 0xf0);                            /* and al, 0xf0 */
            ii(0x97bd, 3);    mov(memw_a16[ds, 0xe], ax);               /* mov [0xe], ax */
            ii(0x97c0, 1);    popw(si);                                 /* pop si */
            ii(0x97c1, 1);    popw(di);                                 /* pop di */
            ii(0x97c2, 1);    retw();                                   /* ret */
        }
    }
}
