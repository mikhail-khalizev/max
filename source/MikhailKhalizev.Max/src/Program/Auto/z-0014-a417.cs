using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0f26033b-6361-4af7-955c-f3542de79c8b")]
        public void Method_0014_a417()
        {
            ii(0x14_a417, 3); mov(cx, 0x3309);                          /* mov cx, 0x3309 */
            ii(0x14_a41a, 1); pushw(ss);                                /* push ss */
            ii(0x14_a41b, 1); pushw(bp);                                /* push bp */
            ii(0x14_a41c, 2); callw_abs(cx);                            /* call cx */
            ii(0x14_a41e, 1); popw(cx);                                 /* pop cx */
            ii(0x14_a41f, 1); popw(cx);                                 /* pop cx */
            ii(0x14_a420, 3); jmpw_func(0x14_a838, 0x415); return;      /* jmp 0xa838 */
        }
    }
}
