using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("87990b27-aa1a-4462-b2e9-9f547a9480d4")]
        public void Method_0000_42dc()
        {
            ii(0x42dc, 4);    mov(memw_a16[ds, 0x996], bp);             /* mov [0x996], bp */
            ii(0x42e0, 4);    mov(sp, memw_a16[ds, 0xf50]);             /* mov sp, [0xf50] */
            ii(0x42e4, 3);    callw(0x3f1c, -0x3cb);                    /* call 0x3f1c */
            ii(0x42e7, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x42e9, 3);    mov(bx, memw_a16[ss, bp + 0x18]);         /* mov bx, [bp+0x18] */
            ii(0x42ec, 2);    or(bx, bx);                               /* or bx, bx */
            ii(0x42ee, 2);    if(jnzw(0x42f3, 0x3)) goto l_0x42f3;      /* jnz 0x42f3 */
            ii(0x42f0, 3);    xchg(memw_a16[ss, bp + 0x1c], bx);        /* xchg [bp+0x1c], bx */
        l_0x42f3:
            ii(0x42f3, 3);    mov(al, memb_a16[cs, bx]);                /* mov al, [cs:bx] */
            ii(0x42f6, 3);    mov(memw_a16[ss, bp + 0x18], ax);         /* mov [bp+0x18], ax */
            ii(0x42f9, 3);    jmpw_func(0x3841, -0xabb); return;        /* jmp 0x3841 */
        }
    }
}
