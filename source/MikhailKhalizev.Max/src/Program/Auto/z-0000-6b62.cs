using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("13b84098-7407-4eb7-85ea-0468600cd4bb")]
        public void Method_0000_6b62()
        {
            ii(0x6b62, 1);    pushw(bp);                                /* push bp */
            ii(0x6b63, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x6b65, 3);    mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x6b68, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x6b6a, 2);    if(jnzw(0x6b83, 0x17)) goto l_0x6b83;     /* jnz 0x6b83 */
            ii(0x6b6c, 3);    mov(ax, 0x1a2);                           /* mov ax, 0x1a2 */
            ii(0x6b6f, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x6b71, 3);    callw(0x6043, -0xb31);                    /* call 0x6043 */
            ii(0x6b74, 3);    mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x6b77, 3);    mov(memw_a16[ss, bp + 0x4], ax);          /* mov [bp+0x4], ax */
            ii(0x6b7a, 3);    mov(ds, memw_a16[ss, bp + 0xa]);          /* mov ds, [bp+0xa] */
            ii(0x6b7d, 3);    mov(es, memw_a16[ss, bp + 0xc]);          /* mov es, [bp+0xc] */
            ii(0x6b80, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
        l_0x6b83:
            ii(0x6b83, 1);    popw(bp);                                 /* pop bp */
            ii(0x6b84, 1);    retfw(); return;                          /* retf */
        }
    }
}
