using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c429f3b5-7048-4754-8785-ae5d4ee93fab")]
        public void Method_0000_f96f()
        {
            ii(0xf96f, 4);    mov(bx, memw_a16[ds, 0xafa]);             /* mov bx, [0xafa] */
            ii(0xf973, 2);    mov(cx, memw_a16[ds, bx]);                /* mov cx, [bx] */
            ii(0xf975, 1);    dec(bx);                                  /* dec bx */
            ii(0xf976, 1);    dec(bx);                                  /* dec bx */
            ii(0xf977, 4);    mov(memw_a16[ds, 0xafa], bx);             /* mov [0xafa], bx */
            ii(0xf97b, 4);    cmp(bx, 0xafa);                           /* cmp bx, 0xafa */
            ii(0xf97f, 4);    jmpw_a16_far_ind(ds, 0xaf6); return;      /* jmp far word [0xaf6] */
        }
    }
}
