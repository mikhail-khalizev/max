using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4c812841-ef7d-4420-8cce-f3cd5c27a6cf")]
        public void Method_0001_12fb()
        {
            ii(0x1_12fb, 3);  cmp(edi, ecx);                            /* cmp edi, ecx */
            ii(0x1_12fe, 2);  jbew_func(0x1_12e9, -0x17);               /* jbe 0x12e9 */
            ii(0x1_1300, 3);  callw(0x1_1316, 0x13);                    /* call 0x1316 */
        }
    }
}
