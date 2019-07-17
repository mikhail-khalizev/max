using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("463c8e7e-48da-4af3-bf3c-f0f5d1d8ebdf")]
        public void Method_0000_a38c()
        {
            ii(0xa38c, 1);    pushw(si);                                /* push si */
            ii(0xa38d, 1);    pushw(di);                                /* push di */
            ii(0xa38e, 3);    mov(ax, 0x1687);                          /* mov ax, 0x1687 */
            ii(0xa391, 2);    @int(0x2f);                               /* int 0x2f */
            ii(0xa393, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xa395, 3);    mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0xa398, 2);    if(jnzw(0xa3af, 0x15)) goto l_0xa3af;     /* jnz 0xa3af */
            ii(0xa39a, 5);    mov(memw_a16[cs, 0x6d64], si);            /* mov [cs:0x6d64], si */
            ii(0xa39f, 5);    mov(memw_a16[cs, 0x6e86], di);            /* mov [cs:0x6e86], di */
            ii(0xa3a4, 5);    mov(memw_a16[cs, 0x6e88], es);            /* mov [cs:0x6e88], es */
            ii(0xa3a9, 2);    mov(al, cl);                              /* mov al, cl */
            ii(0xa3ab, 4);    mov(memb_a16[ds, 0xc44], dh);             /* mov [0xc44], dh */
        l_0xa3af:
            ii(0xa3af, 1);    popw(di);                                 /* pop di */
            ii(0xa3b0, 1);    popw(si);                                 /* pop si */
            ii(0xa3b1, 1);    retw();                                   /* ret */
        }
    }
}
