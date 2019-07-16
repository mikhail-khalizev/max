using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("478447a8-5592-4436-b7dd-10a433b5a66c")]
        public void Method_0000_af1b()
        {
            ii(0xaf1b, 3);    callw(0x60cb, -0x4e53);                   /* call 0x60cb */
            ii(0xaf1e, 2);    pushw(0x19);                              /* push 0x19 */
            ii(0xaf20, 3);    callw(0x589d, -0x5686);                   /* call 0x589d */
            ii(0xaf23, 0);    jmpd_func(0xaf23, 0);                     /* Принудительное завершение функции. */
        }
    }
}
