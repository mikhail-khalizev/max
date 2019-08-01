using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cc020441-8a00-4ca7-a875-4e7567f7d420")]
        public void Method_0016_1029()
        {
            ii(0x16_1029, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x16_102d, 5); movzx(eax, memw_a16[ss, bp + 0x6]);       /* movzx eax, word [bp+0x6] */
            ii(0x16_1032, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x16_1034, 2); if(jzw(0x16_103c, 0x6)) goto l_0x16_103c; /* jz 0x103c */
            ii(0x16_1036, 4); lsl(eax, ax);                             /* lsl eax, ax */
            ii(0x16_103a, 2); jmpw(0x16_103c, 0); goto l_0x16_103c;     /* jmp 0x103c */
        l_0x16_103c:
            ii(0x16_103c, 3); mov(edx, eax);                            /* mov edx, eax */
            ii(0x16_103f, 4); shr(edx, 0x10);                           /* shr edx, 0x10 */
            ii(0x16_1043, 1); leavew();                                 /* leave */
            ii(0x16_1044, 1); retfw(); return;                          /* retf */
        }
    }
}
