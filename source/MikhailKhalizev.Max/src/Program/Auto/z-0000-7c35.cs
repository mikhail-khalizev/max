using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2147c581-81ae-45ef-8c98-c52bb3582225")]
        public void Method_0000_7c35()
        {
            ii(0x7c35, 1);    pushw(bp);                                /* push bp */
            ii(0x7c36, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x7c38, 1);    pushw(si);                                /* push si */
            ii(0x7c39, 3);    mov(si, memw_a16[ss, bp + 0x4]);          /* mov si, [bp+0x4] */
            ii(0x7c3c, 2);    jmpw(0x7c49, 0xb); goto l_0x7c49;         /* jmp 0x7c49 */
        l_0x7c3e:
            ii(0x7c3e, 3);    cmp(memb_a16[ds, si], 0x20);              /* cmp byte [si], 0x20 */
            ii(0x7c41, 2);    if(jzw(0x7c48, 0x5)) goto l_0x7c48;       /* jz 0x7c48 */
            ii(0x7c43, 3);    cmp(memb_a16[ds, si], 0x9);               /* cmp byte [si], 0x9 */
            ii(0x7c46, 2);    if(jnzw(0x7c4e, 0x6)) goto l_0x7c4e;      /* jnz 0x7c4e */
        l_0x7c48:
            ii(0x7c48, 1);    inc(si);                                  /* inc si */
        l_0x7c49:
            ii(0x7c49, 3);    cmp(memb_a16[ds, si], 0);                 /* cmp byte [si], 0x0 */
            ii(0x7c4c, 2);    if(jnzw(0x7c3e, -0x10)) goto l_0x7c3e;    /* jnz 0x7c3e */
        l_0x7c4e:
            ii(0x7c4e, 2);    mov(ax, si);                              /* mov ax, si */
            ii(0x7c50, 1);    popw(si);                                 /* pop si */
            ii(0x7c51, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x7c53, 1);    popw(bp);                                 /* pop bp */
            ii(0x7c54, 1);    retw(); return;                           /* ret */
        }
    }
}
