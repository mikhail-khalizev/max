using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_0ee8-7d814c80")]
        public void Method_001a_0ee8()
        {
            ii(0x1a_0ee8, 4); enter(0, 0);                              /* enter 0x0, 0x0 */
            ii(0x1a_0eec, 1); push(cx);                                 /* push cx */
            ii(0x1a_0eed, 3); mov(cx, memw[ss, bp + 6]);                /* mov cx, [bp+0x6] */
            ii(0x1a_0ef0, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x1a_0ef2, 3); lar(ax, cx);                              /* lar ax, cx */
            ii(0x1a_0ef5, 2); jmp(0x1a_0ef7, 0); goto l_0x1a_0ef7;      /* jmp 0xef7 */
        l_0x1a_0ef7:
            ii(0x1a_0ef7, 3); test(ah, 0x10);                           /* test ah, 0x10 */
            ii(0x1a_0efa, 2); if(jnz(0x1a_0efe, 2)) goto l_0x1a_0efe;   /* jnz 0xefe */
            ii(0x1a_0efc, 2); xor(cx, cx);                              /* xor cx, cx */
        l_0x1a_0efe:
            ii(0x1a_0efe, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x1a_0f00, 1); pop(cx);                                  /* pop cx */
            ii(0x1a_0f01, 1); leave();                                  /* leave */
            ii(0x1a_0f02, 1); retf();                                   /* retf */
        }
    }
}
