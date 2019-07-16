using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e17bf013-e0b7-4cc2-95e5-5f656ff5e24e")]
        public void Method_0000_41d9()
        {
            ii(0x41d9, 2);    mov(ah, 0xdf);                            /* mov ah, 0xdf */
            ii(0x41db, 3);    callw(0x41c1, -0x1d);                     /* call 0x41c1 */
            ii(0x41de, 5);    test(memb_a16[ds, 0x14], 0x1);            /* test byte [0x14], 0x1 */
            ii(0x41e3, 2);    jzw_func(0x41d3, -0x12);                  /* jz 0x41d3 */
        l_0x41e5:
            ii(0x41e5, 3);    callw(0x41fd, 0x15);                      /* call 0x41fd */
            ii(0x41e8, 2);    if(jzw(0x41e5, -0x5)) goto l_0x41e5;      /* jz 0x41e5 */
            ii(0x41ea, 1);    retw();                                   /* ret */
        }
    }
}
