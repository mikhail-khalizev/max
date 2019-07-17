using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9ee3eafc-d781-443f-8783-dd894c85d273")]
        public void Method_0000_6342()
        {
            ii(0x6342, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x6345, 1);    pushw(ax);                                /* push ax */
            ii(0x6346, 3);    callw(0x9c45, 0x38fc);                    /* call 0x9c45 */
            ii(0x6349, 1);    popw(bx);                                 /* pop bx */
            ii(0x634a, 3);    mov(memb_a16[ds, 0x1186], al);            /* mov [0x1186], al */
            ii(0x634d, 5);    cmp(memb_a16[ds, 0x26], 0);               /* cmp byte [0x26], 0x0 */
            ii(0x6352, 2);    if(jzw(0x6372, 0x1e)) goto l_0x6372;      /* jz 0x6372 */
            ii(0x6354, 3);    mov(ax, 0xe20);                           /* mov ax, 0xe20 */
            ii(0x6357, 1);    pushw(ax);                                /* push ax */
            ii(0x6358, 3);    callw(0x4a87, -0x18d4);                   /* call 0x4a87 */
            ii(0x635b, 1);    popw(bx);                                 /* pop bx */
            ii(0x635c, 3);    mov(ax, 0xad6);                           /* mov ax, 0xad6 */
            ii(0x635f, 1);    pushw(ax);                                /* push ax */
            ii(0x6360, 3);    callw(0x4a87, -0x18dc);                   /* call 0x4a87 */
            ii(0x6363, 1);    popw(bx);                                 /* pop bx */
            ii(0x6364, 3);    callw(0x4dc8, -0x159f);                   /* call 0x4dc8 */
            ii(0x6367, 4);    pushw(memw_a16[ds, 0x30]);                /* push word [0x30] */
            ii(0x636b, 3);    callw(0x4a87, -0x18e7);                   /* call 0x4a87 */
            ii(0x636e, 1);    popw(bx);                                 /* pop bx */
            ii(0x636f, 3);    callw(0x4dc8, -0x15aa);                   /* call 0x4dc8 */
        l_0x6372:
            ii(0x6372, 6);    mov(memw_a16[ds, 0xe], 0x2000);           /* mov word [0xe], 0x2000 */
            ii(0x6378, 3);    jmpw_func(0x9b39, 0x37be);                /* jmp 0x9b39 */
        }
    }
}