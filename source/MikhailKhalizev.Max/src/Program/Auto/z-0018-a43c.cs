using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a43c-3069a996")]
        public void Method_0018_a43c()
        {
            ii(0x18_a43c, 3); mov(ax, memw_a16[ss, bp + 0x10]);         /* mov ax, [bp+0x10] */
            ii(0x18_a43f, 1); pushw(ax);                                /* push ax */
            ii(0x18_a440, 1); xchg(si, ax);                             /* xchg si, ax */
            ii(0x18_a441, 1); sti();                                    /* sti */
            ii(0x18_a442, 3); callw(0x18_d11a, 0x2cd5);                 /* call 0xd11a */
            ii(0x18_a445, 1); cli();                                    /* cli */
            ii(0x18_a446, 3); cmp(si, memw_a16[ss, bp + 0x6]);          /* cmp si, [bp+0x6] */
            ii(0x18_a449, 2); if(jnzw(0x18_a450, 0x5)) goto l_0x18_a450; /* jnz 0xa450 */
            ii(0x18_a44b, 5); mov(memw_a16[ss, bp + 0x6], 0);           /* mov word [bp+0x6], 0x0 */
        l_0x18_a450:
            ii(0x18_a450, 3); sub(si, memw_a16[ss, bp + 0x4]);          /* sub si, [bp+0x4] */
            ii(0x18_a453, 2); if(jnzw_func(0x18_a42e, -0x27)) return;   /* jnz 0xa42e */
            ii(0x18_a455, 3); mov(memw_a16[ss, bp + 0x4], si);          /* mov [bp+0x4], si */
            ii(0x18_a458, 2); if(jmpw_func(0x18_a42e, -0x2c)) return;   /* jmp 0xa42e */
        }
    }
}