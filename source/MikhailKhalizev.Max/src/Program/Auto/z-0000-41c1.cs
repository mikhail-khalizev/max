using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6c62dcbb-c1f6-4557-9c4d-522fbb81e153")]
        public void Method_0000_41c1()
        {
            ii(0x41c1, 3);    callw(0x4218, 0x54);                      /* call 0x4218 */
            ii(0x41c4, 2);    mov(al, 0xd1);                            /* mov al, 0xd1 */
            ii(0x41c6, 2);    outb(0x64, al);                           /* out 0x64, al */
            ii(0x41c8, 3);    callw(0x4218, 0x4d);                      /* call 0x4218 */
            ii(0x41cb, 2);    xchg(ah, al);                             /* xchg ah, al */
            ii(0x41cd, 2);    outb(0x60, al);                           /* out 0x60, al */
            ii(0x41cf, 3);    callw(0x4218, 0x46);                      /* call 0x4218 */
            ii(0x41d2, 1);    retw();                                   /* ret */
        }
    }
}