using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0e23744a-ae0e-4653-8504-555614457e91")]
        public void Method_0016_100b()
        {
            ii(0x16_100b, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x16_100f, 5); movzx(eax, memw_a16[ss, bp + 0x6]);       /* movzx eax, word [bp+0x6] */
            ii(0x16_1014, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x16_1016, 2); if(jzw(0x16_1020, 0x8)) goto l_0x16_1020; /* jz 0x1020 */
            ii(0x16_1018, 2); xchg(bx, bx);                             /* xchg bx, bx */
            ii(0x16_101a, 4); lar(eax, ax);                             /* lar eax, ax */
            ii(0x16_101e, 2); jmpw(0x16_1020, 0); goto l_0x16_1020;     /* jmp 0x1020 */
        l_0x16_1020:
            ii(0x16_1020, 3); mov(edx, eax);                            /* mov edx, eax */
            ii(0x16_1023, 4); shr(edx, 0x10);                           /* shr edx, 0x10 */
            ii(0x16_1027, 1); leavew();                                 /* leave */
            ii(0x16_1028, 1); retfw(); return;                          /* retf */
        }
    }
}
