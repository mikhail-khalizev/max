using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d08fa3e2-7b4e-4b6e-b564-2272ca21dd1d")]
        public void Method_0001_12e9()
        {
            ii(0x1_12e9, 4);  mov(ax, memw_a32[es, edi]);               /* mov ax, [es:edi] */
            ii(0x1_12ed, 4);  and(ax, memw_a16[ds, 0xdf2]);             /* and ax, [0xdf2] */
            ii(0x1_12f1, 4);  cmp(ax, memw_a16[ds, 0xdf2]);             /* cmp ax, [0xdf2] */
            ii(0x1_12f5, 2);  jnzw_func(0x1_1280, -0x77);               /* jnz 0x1280 */
            ii(0x1_12f7, 4);  add(edi, 0x4);                            /* add edi, 0x4 */
        }
    }
}
