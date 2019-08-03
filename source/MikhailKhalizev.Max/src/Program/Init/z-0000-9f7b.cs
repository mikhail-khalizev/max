using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("490b2f85-a0f4-4d0b-ab55-7c799c70b613")]
        public void Method_0000_9f7b()
        {
            ii(0x9f7b, 5);    test(memb_a16[ds, 0x47], 0x80);           /* test byte [0x47], 0x80 */
            ii(0x9f80, 2);    if(jnzw(0x9f9b, 0x19)) goto l_0x9f9b;     /* jnz 0x9f9b */
            ii(0x9f82, 3);    mov(ax, 0xbfde);                          /* mov ax, 0xbfde */
            ii(0x9f85, 3);    mov(bx, 0x8);                             /* mov bx, 0x8 */
            ii(0x9f88, 2);    mov(cx, cs);                              /* mov cx, cs */
            ii(0x9f8a, 2);    xor(dx, dx);                              /* xor dx, dx */
            ii(0x9f8c, 3);    callw(0x44e4, -0x5aab);                   /* call 0x44e4 */
            ii(0x9f8f, 2);    or(bx, bx);                               /* or bx, bx */
            ii(0x9f91, 2);    if(jnzw(0x9f9b, 0x8)) goto l_0x9f9b;      /* jnz 0x9f9b */
            ii(0x9f93, 4);    or(memb_a16[ds, 0x47], al);               /* or [0x47], al */
            ii(0x9f97, 4);    mov(memw_a16[ds, 0xdec], dx);             /* mov [0xdec], dx */
        l_0x9f9b:
            ii(0x9f9b, 1);    retw(); return;                           /* ret */
        }
    }
}