using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("15a7f796-a4ba-4f82-82ed-894e82a5a1fc")]
        public void Method_0000_5a2e()
        {
            ii(0x5a2e, 1);    pushw(bp);                                /* push bp */
            ii(0x5a2f, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x5a31, 3);    sub(sp, 0x2);                             /* sub sp, 0x2 */
            ii(0x5a34, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x5a37, 3);    callw(0x9bb3, 0x4179);                    /* call 0x9bb3 */
            ii(0x5a3a, 1);    popw(bx);                                 /* pop bx */
            ii(0x5a3b, 3);    mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x5a3e, 1);    inc(ax);                                  /* inc ax */
            ii(0x5a3f, 2);    if(jzw(0x5a46, 0x5)) goto l_0x5a46;       /* jz 0x5a46 */
            ii(0x5a41, 3);    mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x5a44, 2);    jmpw(0x5a48, 0x2); goto l_0x5a48;         /* jmp 0x5a48 */
        l_0x5a46:
            ii(0x5a46, 2);    sub(ax, ax);                              /* sub ax, ax */
        l_0x5a48:
            ii(0x5a48, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x5a4a, 1);    popw(bp);                                 /* pop bp */
            ii(0x5a4b, 1);    retw(); return;                           /* ret */
        }
    }
}
