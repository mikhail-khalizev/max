using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5186cf90-586a-417e-955a-3113cf016865")]
        public void Method_0000_4cb4()
        {
            ii(0x4cb4, 6);    test(memw_a16[ds, 0x1582], 0x1);          /* test word [0x1582], 0x1 */
            ii(0x4cba, 2);    if(jzw(0x4cc9, 0xd)) goto l_0x4cc9;       /* jz 0x5479 */
            ii(0x4cbc, 3);    mov(ax, 0x1706);                          /* mov ax, 0x1706 */
            ii(0x4cbf, 3);    mov(memw_a16[ds, 0x9c0], ax);             /* mov [0x9c0], ax */
            ii(0x4cc2, 3);    mov(ax, 0x2);                             /* mov ax, 0x2 */
            ii(0x4cc5, 4);    callw_a16_far_ind(ds, 0x155c);            /* call far word [0x155c] */
        l_0x4cc9:
            ii(0x4cc9, 1);    retw(); return;                           /* ret */
        }
    }
}
