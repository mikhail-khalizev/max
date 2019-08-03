using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3fc0caa6-6998-4672-b766-a5c6d5b3d4a5")]
        public void Method_0000_4370()
        {
            ii(0x4370, 1);    pushw(bp);                                /* push bp */
            ii(0x4371, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x4373, 2);    mov(cx, ds);                              /* mov cx, ds */
            ii(0x4375, 3);    mov(ax, 0x8);                             /* mov ax, 0x8 */
            ii(0x4378, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x437a, 3);    mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x437d, 3);    callw(0x4352, -0x2e);                     /* call 0x4b02 */
            ii(0x4380, 2);    if(jnzw(0x439c, 0x1a)) goto l_0x439c;     /* jnz 0x4b4c */
            ii(0x4382, 1);    xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x4383, 2);    mov(bx, cx);                              /* mov bx, cx */
            ii(0x4385, 3);    callw(0x4352, -0x36);                     /* call 0x4b02 */
            ii(0x4388, 1);    pushw(bx);                                /* push bx */
            ii(0x4389, 2);    mov(bx, ss);                              /* mov bx, ss */
            ii(0x438b, 3);    callw(0x4352, -0x3c);                     /* call 0x4b02 */
            ii(0x438e, 2);    if(jnzw(0x439c, 0xc)) goto l_0x439c;      /* jnz 0x4b4c */
            ii(0x4390, 3);    xchg(memw_a16[ss, bp + 0x4], ax);         /* xchg [bp+0x4], ax */
            ii(0x4393, 2);    pushw(0x20);                              /* push 0x20 */
            ii(0x4395, 1);    popw(ds);                                 /* pop ds */
            ii(0x4396, 3);    callw(0x3f21, -0x478);                    /* call 0x46d1 */
            ii(0x4399, 1);    popw(ds);                                 /* pop ds */
            ii(0x439a, 1);    popw(bp);                                 /* pop bp */
            ii(0x439b, 1);    retfw(); return;                          /* retf */
        l_0x439c:
            ii(0x439c, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x439e, 2);    mov(ds, cx);                              /* mov ds, cx */
            ii(0x43a0, 1);    leavew();                                 /* leave */
            ii(0x43a1, 1);    retfw(); return;                          /* retf */
        }
    }
}
