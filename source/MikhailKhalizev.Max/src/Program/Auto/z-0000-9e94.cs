using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("656b3c90-6d9a-4cf0-ae73-b46b8a7ddc89")]
        public void Method_0000_9e94()
        {
            ii(0x9e94, 2);    xor(dx, dx);                              /* xor dx, dx */
            ii(0x9e96, 3);    pushw(0xf000);                            /* push 0xf000 */
            ii(0x9e99, 1);    popw(ds);                                 /* pop ds */
            ii(0x9e9a, 2);    xor(bx, bx);                              /* xor bx, bx */
        l_0x9e9c:
            ii(0x9e9c, 1);    lodsw_a16();                              /* lodsw */
            ii(0x9e9d, 2);    add(bx, ax);                              /* add bx, ax */
            ii(0x9e9f, 1);    lodsw_a16();                              /* lodsw */
            ii(0x9ea0, 2);    adc(dx, ax);                              /* adc dx, ax */
            ii(0x9ea2, 2);    if(loopw_a16(0x9e9c, -0x8)) goto l_0x9e9c; /* loop 0x9e9c */
            ii(0x9ea4, 1);    popw(si);                                 /* pop si */
            ii(0x9ea5, 1);    pushw(ss);                                /* push ss */
            ii(0x9ea6, 1);    popw(ds);                                 /* pop ds */
            ii(0x9ea7, 1);    xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x9ea8, 1);    retw();                                   /* ret */
        }
    }
}
