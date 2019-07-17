using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0c03c56d-aaaa-4584-95c8-ed321d2b4cc5")]
        public void Method_0000_a87b()
        {
            ii(0xa87b, 2);    pushw(0x1f);                              /* push 0x1f */
            ii(0xa87d, 3);    callw(0x589d, -0x4fe3);                   /* call 0x589d */
            ii(0xa880, 0);    jmpd_func(0xa880, 0);                     /* Принудительное завершение функции. */
        }
    }
}