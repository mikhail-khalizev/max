using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7fa5be77-8ade-466f-99b5-aaab8b7ea2ff")]
        public void Method_0000_ad41()
        {
            ii(0xad41, 3);    callw(0x9cc4, -0x1080);                   /* call 0x9cc4 */
            ii(0xad44, 2);    jzw_func(0xad30, -0x16);                  /* jz 0xad30 */
            ii(0xad46, 0);    jmpd_func(0xad46, 0);                     /* Принудительное завершение функции. */
        }
    }
}
