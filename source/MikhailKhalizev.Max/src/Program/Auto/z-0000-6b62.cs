using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6b62-9d69ac09")]
        public void Method_0000_6b62()
        {
            ii(0x6b62, 1);    push(bp);                                 /* push bp */
            ii(0x6b63, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x6b65, 3);    mov(dx, memw[ss, bp + 8]);                /* mov dx, [bp+0x8] */
            ii(0x6b68, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x6b6a, 2);    if(jnz(0x6b83, 0x17)) goto l_0x6b83;      /* jnz 0x6b83 */
            ii(0x6b6c, 3);    mov(ax, 0x1a2);                           /* mov ax, 0x1a2 */
            ii(0x6b6f, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x6b71, 3);    call(0x6043, -0xb31);                     /* call 0x6043 */
            ii(0x6b74, 3);    mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x6b77, 3);    mov(memw[ss, bp + 4], ax);                /* mov [bp+0x4], ax */
            ii(0x6b7a, 3);    mov(ds, memw[ss, bp + 0xa]);              /* mov ds, [bp+0xa] */
            ii(0x6b7d, 3);    mov(es, memw[ss, bp + 0xc]);              /* mov es, [bp+0xc] */
            ii(0x6b80, 3);    mov(ax, 1);                               /* mov ax, 0x1 */
        l_0x6b83:
            ii(0x6b83, 1);    pop(bp);                                  /* pop bp */
            ii(0x6b84, 1);    retf();                                   /* retf */
        }
    }
}
