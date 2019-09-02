using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7c35-deb84d9a")]
        public void Method_0000_7c35()
        {
            ii(0x7c35, 1);    push(bp);                                 /* push bp */
            ii(0x7c36, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x7c38, 1);    push(si);                                 /* push si */
            ii(0x7c39, 3);    mov(si, memw[ss, bp + 4]);                /* mov si, [bp+0x4] */
            ii(0x7c3c, 2);    jmp(0x7c49, 0xb); goto l_0x7c49;          /* jmp 0x7c49 */
        l_0x7c3e:
            ii(0x7c3e, 3);    cmp(memb[ds, si], 0x20);                  /* cmp byte [si], 0x20 */
            ii(0x7c41, 2);    if(jz(0x7c48, 5)) goto l_0x7c48;          /* jz 0x7c48 */
            ii(0x7c43, 3);    cmp(memb[ds, si], 9);                     /* cmp byte [si], 0x9 */
            ii(0x7c46, 2);    if(jnz(0x7c4e, 6)) goto l_0x7c4e;         /* jnz 0x7c4e */
        l_0x7c48:
            ii(0x7c48, 1);    inc(si);                                  /* inc si */
        l_0x7c49:
            ii(0x7c49, 3);    cmp(memb[ds, si], 0);                     /* cmp byte [si], 0x0 */
            ii(0x7c4c, 2);    if(jnz(0x7c3e, -0x10)) goto l_0x7c3e;     /* jnz 0x7c3e */
        l_0x7c4e:
            ii(0x7c4e, 2);    mov(ax, si);                              /* mov ax, si */
            ii(0x7c50, 1);    pop(si);                                  /* pop si */
            ii(0x7c51, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x7c53, 1);    pop(bp);                                  /* pop bp */
            ii(0x7c54, 1);    ret();                                    /* ret */
        }
    }
}
