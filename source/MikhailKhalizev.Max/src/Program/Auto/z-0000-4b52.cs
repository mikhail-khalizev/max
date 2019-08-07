using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("336069ba-7d26-46a1-956b-280f770f6e13")]
        public void Method_0000_4b52()
        {
            ii(0x4b52, 1);    pushw(bp);                                /* push bp */
            ii(0x4b53, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x4b55, 3);    mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x4b58, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x4b5a, 2);    if(jnzw(0x4b73, 0x17)) goto l_0x4b73;     /* jnz 0x4b73 */
            ii(0x4b5c, 3);    mov(ax, 0x1a2);                           /* mov ax, 0x1a2 */
            ii(0x4b5f, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x4b61, 3);    callw(0x4033, -0xb31);                    /* call 0x4033 */
            ii(0x4b64, 3);    mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x4b67, 3);    mov(memw_a16[ss, bp + 0x4], ax);          /* mov [bp+0x4], ax */
            ii(0x4b6a, 3);    mov(ds, memw_a16[ss, bp + 0xa]);          /* mov ds, [bp+0xa] */
            ii(0x4b6d, 3);    mov(es, memw_a16[ss, bp + 0xc]);          /* mov es, [bp+0xc] */
            ii(0x4b70, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
        l_0x4b73:
            ii(0x4b73, 1);    popw(bp);                                 /* pop bp */
            ii(0x4b74, 1);    retfw(); return;                          /* retf */
        }
    }
}
