using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("60fbab03-bfd6-4d92-99cc-f3702f495d51")]
        public void Method_0000_91f7()
        {
            ii(0x91f7, 3);    mov(ax, memw_a16[ds, 0x9c]);              /* mov ax, [0x9c] */
            ii(0x91fa, 4);    mov(dx, memw_a16[ds, 0x9e]);              /* mov dx, [0x9e] */
            ii(0x91fe, 3);    sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0x9201, 3);    sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x9204, 1);    pushw(dx);                                /* push dx */
            ii(0x9205, 1);    pushw(ax);                                /* push ax */
            ii(0x9206, 3);    callw(0x8d9d, -0x46c);                    /* call 0x8d9d */
            ii(0x9209, 1);    popw(bx);                                 /* pop bx */
            ii(0x920a, 1);    popw(bx);                                 /* pop bx */
            ii(0x920b, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x920d, 2);    jnzw_func(0x921c, 0xd);                   /* jnz 0x921c */
        }
    }
}
