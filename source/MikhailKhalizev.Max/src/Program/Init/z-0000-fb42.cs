using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("44c1ee57-055c-400d-80cb-5203ee45a993")]
        public void Method_0000_fb42()
        {
            ii(0xfb42, 3);    mov(dx, memw_a16[ss, bp + 0x4]);          /* mov dx, [bp+0x4] */
            ii(0xfb45, 3);    mov(cx, memw_a16[ss, bp + 0x6]);          /* mov cx, [bp+0x6] */
            ii(0xfb48, 2);    shl(dx, 0x1);                             /* shl dx, 1 */
            ii(0xfb4a, 2);    rcl(cx, 0x1);                             /* rcl cx, 1 */
            ii(0xfb4c, 2);    shl(dx, 0x1);                             /* shl dx, 1 */
            ii(0xfb4e, 2);    rcl(cx, 0x1);                             /* rcl cx, 1 */
            ii(0xfb50, 2);    shl(dx, 0x1);                             /* shl dx, 1 */
            ii(0xfb52, 2);    rcl(cx, 0x1);                             /* rcl cx, 1 */
            ii(0xfb54, 2);    shl(dx, 0x1);                             /* shl dx, 1 */
            ii(0xfb56, 2);    rcl(cx, 0x1);                             /* rcl cx, 1 */
            ii(0xfb58, 4);    mov(bx, memw_a16[ds, 0xc38]);             /* mov bx, [0xc38] */
            ii(0xfb5c, 3);    test(bl, 0x3);                            /* test bl, 0x3 */
            ii(0xfb5f, 2);    if(jnzw(0xfb73, 0x12)) goto l_0xfb73;     /* jnz 0xfb73 */
            ii(0xfb61, 2);    pushw(0x8);                               /* push 0x8 */
            ii(0xfb63, 1);    popw(ds);                                 /* pop ds */
            ii(0xfb64, 3);    mov(memw_a16[ds, bx + 0x2], dx);          /* mov [bx+0x2], dx */
            ii(0xfb67, 3);    mov(memb_a16[ds, bx + 0x4], cl);          /* mov [bx+0x4], cl */
            ii(0xfb6a, 3);    mov(memb_a16[ds, bx + 0x7], ch);          /* mov [bx+0x7], ch */
        l_0xfb6d:
            ii(0xfb6d, 2);    mov(ds, bx);                              /* mov ds, bx */
            ii(0xfb6f, 3);    mov(bx, memw_a16[ss, bp + 0x8]);          /* mov bx, [bp+0x8] */
            ii(0xfb72, 1);    retw(); return;                           /* ret */
        l_0xfb73:
            ii(0xfb73, 3);    mov(ax, 0x7);                             /* mov ax, 0x7 */
            ii(0xfb76, 1);    pushw(cs);                                /* push cs */
            ii(0xfb77, 3);    callw(0xc379, -0x3801);                   /* call 0xc379 */
            ii(0xfb7a, 2);    jmpw(0xfb6d, -0xf); goto l_0xfb6d;        /* jmp 0xfb6d */
        }
    }
}
