using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8d48fcc1-5801-4951-9d13-2ac5f1f474bb")]
        public void Method_0000_95e7()
        {
            ii(0x95e7, 3);    mov(bx, 0xffff);                          /* mov bx, 0xffff */
            ii(0x95ea, 4);    xchg(memw_a16[ds, 0xe70], bx);            /* xchg [0xe70], bx */
            ii(0x95ee, 2);    mov(ah, 0x3e);                            /* mov ah, 0x3e */
            ii(0x95f0, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x95f2, 1);    retw();                                   /* ret */
        }
    }
}
